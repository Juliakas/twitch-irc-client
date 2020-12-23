namespace IRC_protocol
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginButton = new System.Windows.Forms.Button();
            this.TokenButton = new System.Windows.Forms.Button();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.TokenTextBox = new System.Windows.Forms.TextBox();
            this.ChannelTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(310, 68);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(78, 23);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // TokenButton
            // 
            this.TokenButton.Location = new System.Drawing.Point(64, 68);
            this.TokenButton.Name = "TokenButton";
            this.TokenButton.Size = new System.Drawing.Size(117, 23);
            this.TokenButton.TabIndex = 1;
            this.TokenButton.Text = "Get Password Token";
            this.TokenButton.UseVisualStyleBackColor = true;
            this.TokenButton.Click += new System.EventHandler(this.TokenButton_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(12, 12);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(220, 20);
            this.UsernameTextBox.TabIndex = 2;
            this.UsernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
            this.UsernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
            // 
            // TokenTextBox
            // 
            this.TokenTextBox.Location = new System.Drawing.Point(12, 38);
            this.TokenTextBox.Name = "TokenTextBox";
            this.TokenTextBox.Size = new System.Drawing.Size(451, 20);
            this.TokenTextBox.TabIndex = 3;
            this.TokenTextBox.Enter += new System.EventHandler(this.TokenTextBox_Enter);
            this.TokenTextBox.Leave += new System.EventHandler(this.TokenTextBox_Leave);
            // 
            // ChannelTextBox
            // 
            this.ChannelTextBox.Location = new System.Drawing.Point(243, 12);
            this.ChannelTextBox.Name = "ChannelTextBox";
            this.ChannelTextBox.Size = new System.Drawing.Size(220, 20);
            this.ChannelTextBox.TabIndex = 4;
            this.ChannelTextBox.Enter += new System.EventHandler(this.ChannelTextBox_Enter);
            this.ChannelTextBox.Leave += new System.EventHandler(this.ChannelTextBox_Leave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 103);
            this.Controls.Add(this.ChannelTextBox);
            this.Controls.Add(this.TokenTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.TokenButton);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(489, 142);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(489, 142);
            this.Name = "LoginForm";
            this.Text = "Log In Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button TokenButton;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox TokenTextBox;
        private System.Windows.Forms.TextBox ChannelTextBox;
    }
}