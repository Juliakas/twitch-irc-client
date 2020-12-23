namespace IRC_protocol
{
    partial class ChatForm
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
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.DebugLabel = new System.Windows.Forms.Label();
            this.ChatPanel = new System.Windows.Forms.Panel();
            this.ChatLabel = new System.Windows.Forms.Label();
            this.SendTextFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SendButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.TextFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.UpperLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DebugPanel = new System.Windows.Forms.Panel();
            this.MainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ControlFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ChannelTextBox = new System.Windows.Forms.TextBox();
            this.ChannelButton = new System.Windows.Forms.Button();
            this.ChannelLabel = new System.Windows.Forms.Label();
            this.ChatPanel.SuspendLayout();
            this.SendTextFlowLayoutPanel.SuspendLayout();
            this.TextFlowLayoutPanel.SuspendLayout();
            this.UpperLayoutPanel.SuspendLayout();
            this.DebugPanel.SuspendLayout();
            this.MainFlowLayoutPanel.SuspendLayout();
            this.ControlFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // DebugLabel
            // 
            this.DebugLabel.AutoSize = true;
            this.DebugLabel.Location = new System.Drawing.Point(3, 3);
            this.DebugLabel.Margin = new System.Windows.Forms.Padding(10);
            this.DebugLabel.Name = "DebugLabel";
            this.DebugLabel.Size = new System.Drawing.Size(0, 13);
            this.DebugLabel.TabIndex = 0;
            // 
            // ChatPanel
            // 
            this.ChatPanel.AutoScroll = true;
            this.ChatPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChatPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatPanel.Controls.Add(this.ChatLabel);
            this.ChatPanel.Location = new System.Drawing.Point(490, 0);
            this.ChatPanel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ChatPanel.Name = "ChatPanel";
            this.ChatPanel.Size = new System.Drawing.Size(229, 307);
            this.ChatPanel.TabIndex = 1;
            // 
            // ChatLabel
            // 
            this.ChatLabel.AutoSize = true;
            this.ChatLabel.Location = new System.Drawing.Point(0, 0);
            this.ChatLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ChatLabel.Name = "ChatLabel";
            this.ChatLabel.Padding = new System.Windows.Forms.Padding(2);
            this.ChatLabel.Size = new System.Drawing.Size(4, 17);
            this.ChatLabel.TabIndex = 0;
            // 
            // SendTextFlowLayoutPanel
            // 
            this.SendTextFlowLayoutPanel.Controls.Add(this.SendButton);
            this.SendTextFlowLayoutPanel.Controls.Add(this.MessageTextBox);
            this.SendTextFlowLayoutPanel.Location = new System.Drawing.Point(0, 307);
            this.SendTextFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SendTextFlowLayoutPanel.Name = "SendTextFlowLayoutPanel";
            this.SendTextFlowLayoutPanel.Size = new System.Drawing.Size(729, 33);
            this.SendTextFlowLayoutPanel.TabIndex = 2;
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(3, 3);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(67, 23);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageTextBox.Location = new System.Drawing.Point(76, 3);
            this.MessageTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(644, 23);
            this.MessageTextBox.TabIndex = 0;
            this.MessageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MessageTextBox_KeyPress);
            // 
            // TextFlowLayoutPanel
            // 
            this.TextFlowLayoutPanel.Controls.Add(this.UpperLayoutPanel);
            this.TextFlowLayoutPanel.Controls.Add(this.SendTextFlowLayoutPanel);
            this.TextFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.TextFlowLayoutPanel.Location = new System.Drawing.Point(3, 0);
            this.TextFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.TextFlowLayoutPanel.Name = "TextFlowLayoutPanel";
            this.TextFlowLayoutPanel.Size = new System.Drawing.Size(726, 341);
            this.TextFlowLayoutPanel.TabIndex = 3;
            this.TextFlowLayoutPanel.WrapContents = false;
            this.TextFlowLayoutPanel.Resize += new System.EventHandler(this.Form_Resize);
            // 
            // UpperLayoutPanel
            // 
            this.UpperLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpperLayoutPanel.Controls.Add(this.DebugPanel);
            this.UpperLayoutPanel.Controls.Add(this.ChatPanel);
            this.UpperLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.UpperLayoutPanel.Name = "UpperLayoutPanel";
            this.UpperLayoutPanel.Size = new System.Drawing.Size(726, 307);
            this.UpperLayoutPanel.TabIndex = 3;
            // 
            // DebugPanel
            // 
            this.DebugPanel.AutoScroll = true;
            this.DebugPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DebugPanel.Controls.Add(this.DebugLabel);
            this.DebugPanel.Location = new System.Drawing.Point(0, 0);
            this.DebugPanel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.DebugPanel.Name = "DebugPanel";
            this.DebugPanel.Padding = new System.Windows.Forms.Padding(3);
            this.DebugPanel.Size = new System.Drawing.Size(484, 307);
            this.DebugPanel.TabIndex = 1;
            // 
            // MainFlowLayoutPanel
            // 
            this.MainFlowLayoutPanel.Controls.Add(this.TextFlowLayoutPanel);
            this.MainFlowLayoutPanel.Controls.Add(this.ControlFlowLayoutPanel);
            this.MainFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainFlowLayoutPanel.Name = "MainFlowLayoutPanel";
            this.MainFlowLayoutPanel.Size = new System.Drawing.Size(901, 340);
            this.MainFlowLayoutPanel.TabIndex = 4;
            // 
            // ControlFlowLayoutPanel
            // 
            this.ControlFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ControlFlowLayoutPanel.Controls.Add(this.ChannelTextBox);
            this.ControlFlowLayoutPanel.Controls.Add(this.ChannelButton);
            this.ControlFlowLayoutPanel.Controls.Add(this.ChannelLabel);
            this.ControlFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ControlFlowLayoutPanel.Location = new System.Drawing.Point(735, 0);
            this.ControlFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ControlFlowLayoutPanel.Name = "ControlFlowLayoutPanel";
            this.ControlFlowLayoutPanel.Size = new System.Drawing.Size(160, 341);
            this.ControlFlowLayoutPanel.TabIndex = 0;
            // 
            // ChannelTextBox
            // 
            this.ChannelTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChannelTextBox.Location = new System.Drawing.Point(12, 12);
            this.ChannelTextBox.Margin = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.ChannelTextBox.Name = "ChannelTextBox";
            this.ChannelTextBox.Size = new System.Drawing.Size(136, 20);
            this.ChannelTextBox.TabIndex = 1;
            // 
            // ChannelButton
            // 
            this.ChannelButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChannelButton.Location = new System.Drawing.Point(25, 44);
            this.ChannelButton.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.ChannelButton.Name = "ChannelButton";
            this.ChannelButton.Size = new System.Drawing.Size(109, 23);
            this.ChannelButton.TabIndex = 0;
            this.ChannelButton.Text = "Change Channel";
            this.ChannelButton.UseVisualStyleBackColor = true;
            this.ChannelButton.Click += new System.EventHandler(this.ChannelButton_Click);
            // 
            // ChannelLabel
            // 
            this.ChannelLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChannelLabel.AutoSize = true;
            this.ChannelLabel.ForeColor = System.Drawing.Color.Red;
            this.ChannelLabel.Location = new System.Drawing.Point(38, 77);
            this.ChannelLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ChannelLabel.Name = "ChannelLabel";
            this.ChannelLabel.Size = new System.Drawing.Size(83, 13);
            this.ChannelLabel.TabIndex = 2;
            this.ChannelLabel.Text = "Invalid Channel!";
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 340);
            this.Controls.Add(this.MainFlowLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "ChatForm";
            this.Text = "Bot";
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.ChatPanel.ResumeLayout(false);
            this.ChatPanel.PerformLayout();
            this.SendTextFlowLayoutPanel.ResumeLayout(false);
            this.SendTextFlowLayoutPanel.PerformLayout();
            this.TextFlowLayoutPanel.ResumeLayout(false);
            this.UpperLayoutPanel.ResumeLayout(false);
            this.DebugPanel.ResumeLayout(false);
            this.DebugPanel.PerformLayout();
            this.MainFlowLayoutPanel.ResumeLayout(false);
            this.ControlFlowLayoutPanel.ResumeLayout(false);
            this.ControlFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label DebugLabel;
        private System.Windows.Forms.Panel ChatPanel;
        private System.Windows.Forms.FlowLayoutPanel SendTextFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel TextFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel UpperLayoutPanel;
        private System.Windows.Forms.Panel DebugPanel;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label ChatLabel;
        private System.Windows.Forms.FlowLayoutPanel MainFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel ControlFlowLayoutPanel;
        private System.Windows.Forms.TextBox ChannelTextBox;
        private System.Windows.Forms.Button ChannelButton;
        private System.Windows.Forms.Label ChannelLabel;
    }
}

