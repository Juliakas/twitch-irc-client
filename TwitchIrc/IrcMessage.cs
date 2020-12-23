namespace IRC_protocol.TwitchIrc
{
    public class IrcMessage
    {
        public string Text { private get;  set; }

        public IrcMessage(string message)
        {
            Text = message;
        }

        public MessageType GetMessageType()
        {
            if (IsPrivMsg()) return MessageType.Chat;
            else if (IsPing()) return MessageType.Ping;
            else return MessageType.Generic;
        }

        private bool IsPrivMsg()
        {
            return Text.Contains("PRIVMSG");
        }

        private bool IsPing()
        {
            return Text.Equals("PING :tmi.twitch.tv");
        }

        public override string ToString()
        {
            return Text;
        }

    }
}
