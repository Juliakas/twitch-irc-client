using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IRC_protocol.TwitchIrc;
using IRC_protocol.Chat;
using System.Threading;

namespace IRC_protocol
{
    public partial class ChatForm : Form
    {
        private TwitchIrcClient client;
        
        private readonly string username;
        private string channel;
        private readonly string password;

        public ChatForm(LoginCredentials credentials)
        {
            InitializeComponent();
            AdjustPanels();

            username = credentials.Username;
            password = credentials.Password;
            channel = credentials.Channel;

            client = Connect();
            JoinChannelAsync(channel);

            new Thread(Reconnect).Start();
        }

        private void Reconnect()
        {
            while (true)
            {
                if (!client.Connected)
                {
                    client = Connect();
                    JoinChannelAsync(channel);
                }
            }
        }

        private async Task JoinChannelAsync(string channel)
        {
            bool joined = await client.JoinChannelAsync(channel);
            if(joined)
            {
                this.channel = channel;
                ChannelLabel.Text = channel;
                ChannelLabel.ForeColor = Color.Black;
            }
            else
            {
                ChannelLabel.Text = "Invalid Channel!";
                ChannelLabel.ForeColor = Color.Red;
            }
        }

        private TwitchIrcClient Connect()
        {
            return new TwitchIrcClient(username, password);
        }
        
        private void AdjustPanels()
        {
            int width = MainFlowLayoutPanel.Width;
            int height = MainFlowLayoutPanel.Height;

                ControlFlowLayoutPanel.Height = height;

                TextFlowLayoutPanel.Width = width - ControlFlowLayoutPanel.Width - 12;
                TextFlowLayoutPanel.Height = height;

                    UpperLayoutPanel.Width = TextFlowLayoutPanel.Width;
                    UpperLayoutPanel.Height = TextFlowLayoutPanel.Height - SendTextFlowLayoutPanel.Height;

                        DebugPanel.Width = (int)Math.Floor(TextFlowLayoutPanel.Width * 0.7) - 3;
                        DebugPanel.Height = UpperLayoutPanel.Height;

                            DebugLabel.MaximumSize = new Size(DebugPanel.Width - 10, 0);

                        ChatPanel.Width = (int)Math.Floor(TextFlowLayoutPanel.Width * 0.3) - 4;
                        ChatPanel.Height = UpperLayoutPanel.Height;

                            ChatLabel.MaximumSize = new Size(ChatPanel.Width - 10, 0);

                    SendTextFlowLayoutPanel.Width = TextFlowLayoutPanel.Width;

                        MessageTextBox.Width = SendTextFlowLayoutPanel.Width - SendButton.Width - 9;
        }

        private async Task SendMessageAsync(string channel)
        {
            string displayMessage = $"{username}: {MessageTextBox.Text}";
            AppendChatLabel(displayMessage + "\n");

            await client.SendChatMessageAsync(channel, MessageTextBox.Text);
        }

        private void AppendDebugLabel(string text)
        {
            DebugLabel.Text += text;
        }

        private void AppendChatLabel(string text)
        {
            ChatLabel.Text += text;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            AdjustPanels();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(client.CanRead)
            {
                IrcMessage message = client.ReadStreamLine();
                if (!string.IsNullOrEmpty(message.ToString()))
                {
                    AppendDebugLabel(message.ToString() + Environment.NewLine);
                    if (message.GetMessageType() == MessageType.Chat)
                    {
                        ChatMessage chatMsg = new ChatMessage(message);
                        AppendChatLabel(chatMsg.ToString() + Environment.NewLine);
                    }
                    else if(message.GetMessageType() == MessageType.Ping)
                    {
                        client.PongResponseAsync();
                    }
                }
            }
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MessageTextBox.Text)) await SendMessageAsync(channel);
            MessageTextBox.Clear();
        }

        private void MessageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) SendButton_Click(sender, e);
        }

        private async void ChannelButton_Click(object sender, EventArgs e)
        {
            await client.PartChannelAsync(channel);

            ChatLabel.Text = "";

            await JoinChannelAsync(ChannelTextBox.Text);

            ChannelTextBox.Text = "";
        }
    }
}
