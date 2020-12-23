using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_protocol.TwitchIrc
{
    class IrcStream
    {
        public StreamWriter Writer { get; set; }
        public StreamReader Reader { get; set; }

        public IrcStream (Stream stream)
        {
            Writer = new StreamWriter(stream);
            Reader = new StreamReader(stream);
        }

        public void SendIrcMessage(string message)
        {
            Writer.WriteLine(message);
            Writer.Flush();
        }

        public async Task SendIrcMessageAsync(string message)
        {
            await Writer.WriteLineAsync(message);
            Writer.Flush();
        }

        public async Task<IrcMessage> GetIrcMessageAsync()
        {
            string message = await Reader.ReadLineAsync();
            return new IrcMessage(message);
        }

        public IrcMessage GetIrcMessage()
        {
            string message = Reader.ReadLine();
            return new IrcMessage(message);
        }
    }
}
