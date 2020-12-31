namespace Luski.UI.MainScreen.User_Control
{
    partial class Chat
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
            this.MessagesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.luskiTextBox2 = new Luski.GUI.Controls.LuskiTextBox();
            this.MessagesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessagesPanel
            // 
            this.MessagesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MessagesPanel.Controls.Add(this.panel1);
            this.MessagesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MessagesPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MessagesPanel.Location = new System.Drawing.Point(0, 0);
            this.MessagesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MessagesPanel.Name = "MessagesPanel";
            this.MessagesPanel.Size = new System.Drawing.Size(700, 512);
            this.MessagesPanel.TabIndex = 3;
            this.MessagesPanel.WrapContents = false;
            this.MessagesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MessagesPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MessagesPanel.SetFlowBreak(this.panel1, true);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 56);
            this.panel1.TabIndex = 0;
            // 
            // luskiTextBox2
            // 
            this.luskiTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.luskiTextBox2.BlendingFactor = 0.0005F;
            this.luskiTextBox2.DarkBlendImage = global::Luski.Properties.Resources._023;
            this.luskiTextBox2.Font = new System.Drawing.Font("Whitney Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luskiTextBox2.LightBlendImage = global::Luski.Properties.Resources._1;
            this.luskiTextBox2.Location = new System.Drawing.Point(10, 524);
            this.luskiTextBox2.MaxTextLength = 32767;
            this.luskiTextBox2.Multiline = false;
            this.luskiTextBox2.Name = "luskiTextBox2";
            this.luskiTextBox2.PasswordCharacter = '\0';
            this.luskiTextBox2.PlaceholderText = "";
            this.luskiTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.luskiTextBox2.SelectedText = "";
            this.luskiTextBox2.SelectionLength = 0;
            this.luskiTextBox2.SelectionStart = 0;
            this.luskiTextBox2.Size = new System.Drawing.Size(680, 36);
            this.luskiTextBox2.TabIndex = 5;
            this.luskiTextBox2.TabStop = false;
            this.luskiTextBox2.Text = "the";
            this.luskiTextBox2.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.luskiTextBox2.UseSystemPasswordChar = false;
            this.luskiTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.luskiTextBox2_KeyDown);
            this.luskiTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.luskiTextBox2_KeyPress);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.MessagesPanel);
            this.Controls.Add(this.luskiTextBox2);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Chat";
            this.Size = new System.Drawing.Size(700, 570);
            this.Resize += new System.EventHandler(this.Chat_Resize);
            this.MessagesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MessagesPanel;
        private GUI.Controls.LuskiTextBox luskiTextBox2;
        private System.Windows.Forms.Panel panel1;
    }
}
