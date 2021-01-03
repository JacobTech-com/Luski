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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.luskiTextBox1 = new Luski.GUI.Controls.LuskiTextBox();
            this.MessagesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 86);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 10);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(67, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // luskiTextBox1
            // 
            this.luskiTextBox1.BlendingFactor = 0F;
            this.luskiTextBox1.DarkBlendImage = null;
            this.luskiTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.luskiTextBox1.LightBlendImage = null;
            this.luskiTextBox1.Location = new System.Drawing.Point(17, 812);
            this.luskiTextBox1.MaxTextLength = 32767;
            this.luskiTextBox1.Multiline = false;
            this.luskiTextBox1.Name = "luskiTextBox1";
            this.luskiTextBox1.PasswordCharacter = '\0';
            this.luskiTextBox1.PlaceholderText = "";
            this.luskiTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.luskiTextBox1.SelectedText = "";
            this.luskiTextBox1.SelectionLength = 0;
            this.luskiTextBox1.SelectionStart = 0;
            this.luskiTextBox1.Size = new System.Drawing.Size(1012, 38);
            this.luskiTextBox1.TabIndex = 4;
            this.luskiTextBox1.TabStop = false;
            this.luskiTextBox1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.luskiTextBox1.UseSystemPasswordChar = false;
            this.luskiTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.luskiTextBox1_KeyDown);
            // 
            // MessagesPanel
            // 
            this.MessagesPanel.AutoScroll = true;
            this.MessagesPanel.Location = new System.Drawing.Point(0, 93);
            this.MessagesPanel.Name = "MessagesPanel";
            this.MessagesPanel.Size = new System.Drawing.Size(1050, 611);
            this.MessagesPanel.TabIndex = 5;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.MessagesPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.luskiTextBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Chat";
            this.Size = new System.Drawing.Size(1050, 878);
            this.Resize += new System.EventHandler(this.Chat_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private GUI.Controls.LuskiTextBox luskiTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel MessagesPanel;
    }
}
