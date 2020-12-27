namespace Luski.UI.Main_Form
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ServerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ChannelPickerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.friendsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.noteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UserIcon = new System.Windows.Forms.PictureBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.TagLabel = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.chat1 = new Luski.UI.Main_Form.User_Control.Chat();
            this.friendsPanel1 = new Luski.UI.Main_Form.User_Control.FriendsPanel();
            this.TitleBar.SuspendLayout();
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TitleBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBar.Controls.Add(this.CloseButton);
            this.TitleBar.Location = new System.Drawing.Point(-14, -2);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(1617, 39);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CloseButton.Location = new System.Drawing.Point(1564, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(37, 37);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
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
            this.ServerPanel.Size = new System.Drawing.Size(98, 892);
            this.ServerPanel.TabIndex = 1;
            // 
            // ChannelPickerPanel
            // 
            this.ChannelPickerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ChannelPickerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ChannelPickerPanel.ContextMenuStrip = this.metroContextMenu1;
            this.ChannelPickerPanel.Location = new System.Drawing.Point(95, 37);
            this.ChannelPickerPanel.Name = "ChannelPickerPanel";
            this.ChannelPickerPanel.Size = new System.Drawing.Size(443, 786);
            this.ChannelPickerPanel.TabIndex = 3;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.friendsToolStripMenuItem1,
            this.noteToolStripMenuItem1});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(142, 68);
            this.metroContextMenu1.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            // UserIcon
            // 
            this.UserIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UserIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserIcon.Location = new System.Drawing.Point(103, 830);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(84, 84);
            this.UserIcon.TabIndex = 4;
            this.UserIcon.TabStop = false;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UsernameLabel.Location = new System.Drawing.Point(193, 840);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(132, 29);
            this.UsernameLabel.TabIndex = 5;
            this.UsernameLabel.Text = "Username";
            // 
            // TagLabel
            // 
            this.TagLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TagLabel.AutoSize = true;
            this.TagLabel.ForeColor = System.Drawing.Color.Gray;
            this.TagLabel.Location = new System.Drawing.Point(194, 878);
            this.TagLabel.Name = "TagLabel";
            this.TagLabel.Size = new System.Drawing.Size(74, 20);
            this.TagLabel.TabIndex = 6;
            this.TagLabel.Text = "User Tag";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // chat1
            // 
            this.chat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.chat1.Location = new System.Drawing.Point(538, 39);
            this.chat1.Name = "chat1";
            this.chat1.Size = new System.Drawing.Size(1048, 877);
            this.chat1.TabIndex = 8;
            // 
            // friendsPanel1
            // 
            this.friendsPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.friendsPanel1.Enabled = false;
            this.friendsPanel1.Location = new System.Drawing.Point(538, 39);
            this.friendsPanel1.Name = "friendsPanel1";
            this.friendsPanel1.Size = new System.Drawing.Size(1048, 877);
            this.friendsPanel1.TabIndex = 7;
            this.friendsPanel1.Visible = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1590, 920);
            this.Controls.Add(this.chat1);
            this.Controls.Add(this.friendsPanel1);
            this.Controls.Add(this.TagLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UserIcon);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.ServerPanel);
            this.Controls.Add(this.ChannelPickerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main_Form";
            this.Text = "Luski";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.TitleBar.ResumeLayout(false);
            this.metroContextMenu1.ResumeLayout(false);
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
        private User_Control.Chat chat1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem friendsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuItem1;
    }
}