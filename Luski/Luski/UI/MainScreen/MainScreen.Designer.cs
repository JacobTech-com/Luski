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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.luskiButton1 = new Luski.GUI.Controls.LuskiButton();
            this.callPanel1 = new Luski.UI.MainScreen.User_Control.CallPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.TitleBar.Location = new System.Drawing.Point(-9, -1);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(1094, 26);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            this.TitleBar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainScreen_PreviewKeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(11, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 16);
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
            this.CloseButton.Location = new System.Drawing.Point(1057, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 24);
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
            this.ServerPanel.Location = new System.Drawing.Point(-1, 24);
            this.ServerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ServerPanel.Name = "ServerPanel";
            this.ServerPanel.Size = new System.Drawing.Size(66, 616);
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
            this.ChannelPickerPanel.Location = new System.Drawing.Point(64, 81);
            this.ChannelPickerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ChannelPickerPanel.Name = "ChannelPickerPanel";
            this.ChannelPickerPanel.Size = new System.Drawing.Size(294, 602);
            this.ChannelPickerPanel.TabIndex = 3;
            this.ChannelPickerPanel.WrapContents = false;
            this.ChannelPickerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ChannelPickerPanel_Paint);
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
            this.UsernameLabel.Font = new System.Drawing.Font("WhitneyBold", 12.25F);
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UsernameLabel.Location = new System.Drawing.Point(127, 587);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(85, 19);
            this.UsernameLabel.TabIndex = 5;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainScreen_PreviewKeyDown);
            // 
            // TagLabel
            // 
            this.TagLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TagLabel.AutoSize = true;
            this.TagLabel.Font = new System.Drawing.Font("Whitney Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagLabel.ForeColor = System.Drawing.Color.Gray;
            this.TagLabel.Location = new System.Drawing.Point(128, 606);
            this.TagLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TagLabel.Name = "TagLabel";
            this.TagLabel.Size = new System.Drawing.Size(57, 17);
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
            this.UserIcon.Location = new System.Drawing.Point(72, 581);
            this.UserIcon.Margin = new System.Windows.Forms.Padding(2);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(46, 46);
            this.UserIcon.TabIndex = 4;
            this.UserIcon.TabStop = false;
            this.UserIcon.Click += new System.EventHandler(this.UserIcon_Click);
            this.UserIcon.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainScreen_PreviewKeyDown);
            // 
            // friendsPanel1
            // 
            this.friendsPanel1.BackColor = System.Drawing.Color.Red;
            this.friendsPanel1.Enabled = false;
            this.friendsPanel1.Location = new System.Drawing.Point(359, 24);
            this.friendsPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.friendsPanel1.Name = "friendsPanel1";
            this.friendsPanel1.Size = new System.Drawing.Size(699, 570);
            this.friendsPanel1.TabIndex = 7;
            this.friendsPanel1.Visible = false;
            // 
            // chat1
            // 
            this.chat1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.chat1.Location = new System.Drawing.Point(357, 23);
            this.chat1.Margin = new System.Windows.Forms.Padding(0);
            this.chat1.Name = "chat1";
            this.chat1.Size = new System.Drawing.Size(711, 607);
            this.chat1.TabIndex = 8;
            this.chat1.Load += new System.EventHandler(this.chat1_Load);
            this.chat1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainScreen_PreviewKeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel1.Controls.Add(this.luskiButton1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(65, 29);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(290, 42);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // luskiButton1
            // 
            this.luskiButton1.BlendingFactor = 0.0005F;
            this.luskiButton1.ButtonTheme = Luski.GUI.Controls.ButtonTheme.Normal;
            this.luskiButton1.DarkBlendImage = global::Luski.Properties.Resources._023;
            this.luskiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.luskiButton1.LightBlendImage = global::Luski.Properties.Resources._13;
            this.luskiButton1.Location = new System.Drawing.Point(3, 3);
            this.luskiButton1.Name = "luskiButton1";
            this.luskiButton1.Size = new System.Drawing.Size(265, 40);
            this.luskiButton1.TabIndex = 9;
            this.luskiButton1.Text = "Friends";
            this.luskiButton1.TextColor = System.Drawing.Color.White;
            this.luskiButton1.Click += new System.EventHandler(this.luskiButton1_Click);
            // 
            // callPanel1
            // 
            this.callPanel1.Location = new System.Drawing.Point(828, 27);
            this.callPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.callPanel1.Name = "callPanel1";
            this.callPanel1.Size = new System.Drawing.Size(238, 46);
            this.callPanel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 54);
            this.button1.TabIndex = 10;
            this.button1.Text = "overload time";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1075, 634);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.callPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.chat1);
            this.Controls.Add(this.TagLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UserIcon);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.ServerPanel);
            this.Controls.Add(this.ChannelPickerPanel);
            this.Controls.Add(this.friendsPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luski";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainScreen_PreviewKeyDown);
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private GUI.Controls.LuskiButton luskiButton1;
        private User_Control.CallPanel callPanel1;
        private System.Windows.Forms.Button button1;
    }
}