using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRC_protocol
{
    public partial class LoginForm : Form
    {
        private const string passwordPlaceholder = "oauth:";
        private const string usernamePlaceholder = "username";
        private const string channelPlaceholder = "channel";

        public LoginForm()
        {
            InitializeComponent();

            AddPlaceholderText(TokenTextBox, passwordPlaceholder);
            AddPlaceholderText(UsernameTextBox, usernamePlaceholder);
            AddPlaceholderText(ChannelTextBox, channelPlaceholder);
        }

        private void TokenButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitchapps.com/tmi/");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm(new LoginCredentials(UsernameTextBox.Text, TokenTextBox.Text, ChannelTextBox.Text));
            chatForm.Show();

            Hide();
        }

        private void UsernameTextBox_Enter(object sender, EventArgs e)
        {
            RemovePlaceholderText((TextBox)sender);
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            AddPlaceholderText((TextBox)sender, usernamePlaceholder);
        }

        private void ChannelTextBox_Enter(object sender, EventArgs e)
        {
            RemovePlaceholderText((TextBox)sender);
        }

        private void ChannelTextBox_Leave(object sender, EventArgs e)
        {
            AddPlaceholderText((TextBox)sender, channelPlaceholder);
        }

        private void TokenTextBox_Enter(object sender, EventArgs e)
        {
            RemovePlaceholderText((TextBox)sender);
        }

        private void TokenTextBox_Leave(object sender, EventArgs e)
        {
            AddPlaceholderText((TextBox)sender, passwordPlaceholder);
        }

        private void AddPlaceholderText(TextBox textBox, string placeholderText)
        {
            if (textBox.Text == string.Empty)
            {
                textBox.Text = placeholderText;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholderText(TextBox textBox)
        {
            if (textBox.ForeColor == Color.Gray)
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = Color.Black;
            }
        }
    }
}
