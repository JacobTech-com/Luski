namespace Luski.UI.MainScreen.User_Control
{
    partial class FriendsPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.luskiTabControl1 = new Luski.GUI.Controls.LuskiTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Freiend_req = new System.Windows.Forms.TabPage();
            this.luskiTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // luskiTabControl1
            // 
            this.luskiTabControl1.Controls.Add(this.tabPage1);
            this.luskiTabControl1.Controls.Add(this.Freiend_req);
            this.luskiTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.luskiTabControl1.Location = new System.Drawing.Point(0, 0);
            this.luskiTabControl1.Name = "luskiTabControl1";
            this.luskiTabControl1.SelectedIndex = 0;
            this.luskiTabControl1.Size = new System.Drawing.Size(1048, 877);
            this.luskiTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1040, 844);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Friends";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1034, 838);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Freiend_req
            // 
            this.Freiend_req.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Freiend_req.ForeColor = System.Drawing.Color.Gray;
            this.Freiend_req.Location = new System.Drawing.Point(4, 29);
            this.Freiend_req.Name = "Freiend_req";
            this.Freiend_req.Padding = new System.Windows.Forms.Padding(3);
            this.Freiend_req.Size = new System.Drawing.Size(1040, 844);
            this.Freiend_req.TabIndex = 1;
            this.Freiend_req.Text = "Friend Request";
            // 
            // FriendsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.luskiTabControl1);
            this.Name = "FriendsPanel";
            this.Size = new System.Drawing.Size(1048, 877);
            this.Load += new System.EventHandler(this.FriendsPanel_Load);
            this.luskiTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GUI.Controls.LuskiTabControl luskiTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Freiend_req;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
