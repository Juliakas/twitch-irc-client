using IRC_protocol.TwitchIrc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_protocol.Chat
{
    public class ChatMessage
    {
        public string Sender { get; set; }
        public string Message { get; set; }

        public ChatMessage() : this(string.Empty, string.Empty) {}

        public ChatMessage(string sender, string message)
        {
            Sender = sender;
            Message = message;
        }

        public ChatMessage(string forExtraction) 
        {
            CopyFrom(ChatMessageExtractor.Extract(forExtraction));
        }

        public ChatMessage(IrcMessage forExtraction)
        {
            CopyFrom(ChatMessageExtractor.Extract(forExtraction.ToString()));
        }

        public override string ToString()
        {
            return $"{Sender}: {Message}";
        }

        public void CopyFrom(ChatMessage copy)
        {
            Sender = copy.Sender;
            Message = copy.Message;
        }
    }
}
