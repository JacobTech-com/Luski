namespace Luski.UI.MainScreen
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ServerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ChannelPickerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.friendsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.noteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.TagLabel = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.UserIcon = new System.Windows.Forms.PictureBox();
            this.friendsPanel1 = new Luski.UI.MainScreen.User_Control.FriendsPanel();
            this.chat1 = new Luski.UI.MainScreen.User_Control.Chat();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TitleBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBar.Controls.Add(this.pictureBox1);
            this.TitleBar.Controls.Add(this.CloseButton);
            this.TitleBar.Location = new System.Drawing.Point(-14, -2);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(1640, 39);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            this.TitleBar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainScreen_PreviewKeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 28);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainScreen_PreviewKeyDown);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CloseButton.Location = new System.Drawing.Point(1586, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(38, 37);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainScreen_PreviewKeyDown);
            // 
            // ServerPanel
            // 
            this.ServerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ServerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ServerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ServerPanel.Location = new System.Drawing.Point(-2, 37);
            this.ServerPanel.Name = "ServerPanel";
            this.ServerPanel.Size = new System.Drawing.Size(98, 947);
            this.ServerPanel.TabIndex = 1;
            this.ServerPanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainScreen_PreviewKeyDown);
            // 
            // ChannelPickerPanel
            // 
            this.ChannelPickerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ChannelPickerPanel.AutoScroll = true;
            this.ChannelPickerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ChannelPickerPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ChannelPickerPanel.Location = new System.Drawing.Point(98, 37);
            this.ChannelPickerPanel.Name = "ChannelPickerPanel";
            this.ChannelPickerPanel.Size = new System.Drawing.Size(441, 844);
            this.ChannelPickerPanel.TabIndex = 3;
            this.ChannelPickerPanel.WrapContents = false;
            this.ChannelPickerPanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainScreen_PreviewKeyDown);
            // 
            // friendsToolStripMenuItem1
            // 
            this.friendsToolStripMenuItem1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.friendsToolStripMenuItem1.Name = "friendsToolStripMenuItem1";
            this.friendsToolStripMenuItem1.Size = new System.Drawing.Size(141, 32);
            this.friendsToolStripMenuItem1.Text = "Friends";
            this.friendsToolStripMenuItem1.Click += new System.EventHandler(this.friendsToolStripMenuItem1_Click);
            // 
            // noteToolStripMenuItem1
            // 
            this.noteToolStripMenuItem1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.noteToolStripMenuItem1.Name = "noteToolStripMenuItem1";
            this.noteToolStripMenuItem1.Size = new System.Drawing.Size(141, 32);
            this.noteToolStripMenuItem1.Text = "Note";
            this.noteToolStripMenuItem1.Click += new System.EventHandler(this.noteToolStripMenuItem1_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UsernameLabel.Location = new System.Drawing.Point(194, 896);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(132, 29);
            this.UsernameLabel.TabIndex = 5;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainScreen_PreviewKeyDown);
            // 
            // TagLabel
            // 
            this.TagLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TagLabel.AutoSize = true;
            this.TagLabel.ForeColor = System.Drawing.Color.Gray;
            this.TagLabel.Location = new System.Drawing.Point(194, 934);
            this.TagLabel.Name = "TagLabel";
            this.TagLabel.Size = new System.Drawing.Size(74, 20);
            this.TagLabel.TabIndex = 6;
            this.TagLabel.Text = "User Tag";
            this.TagLabel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainScreen_PreviewKeyDown);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // UserIcon
            // 
            this.UserIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UserIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserIcon.Location = new System.Drawing.Point(104, 885);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(84, 85);
            this.UserIcon.TabIndex = 4;
            this.UserIcon.TabStop = false;
            this.UserIcon.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainScreen_PreviewKeyDown);
            // 
            // friendsPanel1
            // 
            this.friendsPanel1.BackColor = System.Drawing.Color.Red;
            this.friendsPanel1.Enabled = false;
            this.friendsPanel1.Location = new System.Drawing.Point(538, 37);
            this.friendsPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.friendsPanel1.Name = "friendsPanel1";
            this.friendsPanel1.Size = new System.Drawing.Size(1048, 877);
            this.friendsPanel1.TabIndex = 7;
            this.friendsPanel1.Visible = false;
            // 
            // chat1
            // 
            this.chat1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.chat1.Location = new System.Drawing.Point(536, 36);
            this.chat1.Margin = new System.Windows.Forms.Padding(0);
            this.chat1.Name = "chat1";
            this.chat1.Size = new System.Drawing.Size(1067, 934);
            this.chat1.TabIndex = 8;
            this.chat1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainScreen_PreviewKeyDown);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1612, 976);
            this.Controls.Add(this.chat1);
            this.Controls.Add(this.TagLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UserIcon);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.ServerPanel);
            this.Controls.Add(this.ChannelPickerPanel);
            this.Controls.Add(this.friendsPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luski";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainScreen_PreviewKeyDown);
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.FlowLayoutPanel ServerPanel;
        private System.Windows.Forms.FlowLayoutPanel ChannelPickerPanel;
        private System.Windows.Forms.PictureBox UserIcon;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label TagLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private User_Control.FriendsPanel friendsPanel1;
        private System.Windows.Forms.ToolStripMenuItem friendsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private User_Control.Chat chat1;
    }
}