using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_protocol.Chat
{
    static class ChatMessageExtractor
    {
        public static ChatMessage Extract(string fullMessage)
        {
            if (!fullMessage.Contains("PRIVMSG")) throw new FormatException("Not a chat message - string doesn't contain \"PRIVMSG\"");
            var sender = fullMessage.Substring(1, fullMessage.IndexOf('!') - 1);
            var message = fullMessage.Substring(fullMessage.IndexOf(':', 1) + 1);
            return new ChatMessage(sender, message);
        }
    }
}
