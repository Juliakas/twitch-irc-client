using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace IRC_protocol.TwitchIrc
{
    class TwitchIrcClient
    {
        private TcpClient client;
        private IrcStream stream;

        private Queue<IrcMessage> messageQueue;

        private readonly string username;
        private readonly string password;

        const string hostname = "irc.chat.twitch.tv";
        const int port = 6667;

        private bool preventExplicitRead;

        public bool CanRead { get => (client.Available > 0 || stream.Reader.Peek() >= 0) && !preventExplicitRead; }
        public bool Connected { get => client.Connected; }

        public TwitchIrcClient(string username, string password) : this(username, password, port) { }

        public TwitchIrcClient(string username, string password, int port)
        {
            this.username = username;
            this.password = password;

            client = new TcpClient(hostname, port);
            stream = new IrcStream(client.GetStream());

            messageQueue = new Queue<IrcMessage>();

            preventExplicitRead = false;

            Login();
        }

        public async Task<IrcMessage> TryReadStreamLineAsync()
        {
            if (messageQueue.Count > 0) return messageQueue.Dequeue();

            if ((client.Available > 0 || stream.Reader.Peek() >= 0) && !preventExplicitRead)
                return await stream.GetIrcMessageAsync();
            return new IrcMessage(string.Empty);
        }

        public IrcMessage ReadStreamLine()
        {
            if (messageQueue.Count > 0) return messageQueue.Dequeue();

            return stream.GetIrcMessage();
        }

        public void Login()
        {
            stream.SendIrcMessage($"PASS {password}\nNICK {username}");
        }

        public async Task LoginAsync()
        {
            await stream.SendIrcMessageAsync($"PASS {password}\nNICK {username}");

        }

        public async Task<bool> JoinChannelAsync(string channelName)
        {
            preventExplicitRead = true;
            await stream.SendIrcMessageAsync($"JOIN #{channelName}");

            bool isJoinSuccessful = false;

            
            
            Thread channelResponse = new Thread(() =>
            {
                DateTime endTime = DateTime.Now.Add(new TimeSpan(0, 0, 3));
                while (endTime > DateTime.Now)
                {
                    if (client.Available > 0 || stream.Reader.Peek() >= 0)
                    {
                        IrcMessage message = stream.GetIrcMessage();
                        messageQueue.Enqueue(message);
                        string messageStr = message.ToString();
                        if (Regex.IsMatch(messageStr, @"^:[a-zA-Z_]+![a-zA-Z_]+@[a-zA-Z_]+\.tmi\.twitch\.tv JOIN #[a-zA-Z_]+.*$"))
                        {
                            isJoinSuccessful = true;
                            preventExplicitRead = false;
                            return;
                        }
                    }
                }
                preventExplicitRead = false;
            });
            channelResponse.Start();
            await Task.Run(() => channelResponse.Join());

            return isJoinSuccessful;
        }

        public async Task PartChannelAsync(string channelName)
        {
            await stream.SendIrcMessageAsync($"PART #{channelName}");
        }

        public async Task SendChatMessageAsync(string channelName, string message)
        {
            string fullMessage = $":{username}!{username}@{username}.tmi.twitch.tv PRIVMSG #{channelName} :{message}";
            await stream.SendIrcMessageAsync(fullMessage);
        }

        public async Task PongResponseAsync()
        {
            await stream.SendIrcMessageAsync("PONG: tmi.twitch.tv");
        }
    }
}
