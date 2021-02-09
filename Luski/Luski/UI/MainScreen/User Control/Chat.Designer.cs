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
            this.MessagesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.luskiTextBox1 = new Luski.GUI.Controls.LuskiTextBox();
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
            this.panel1.Size = new System.Drawing.Size(700, 56);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 54);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 6);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(45, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // MessagesPanel
            // 
            this.MessagesPanel.AccessibleName = "what if";
            this.MessagesPanel.AutoScroll = true;
            this.MessagesPanel.Location = new System.Drawing.Point(1, 54);
            this.MessagesPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MessagesPanel.Name = "MessagesPanel";
            this.MessagesPanel.Size = new System.Drawing.Size(700, 460);
            this.MessagesPanel.TabIndex = 5;
            this.MessagesPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.MessagesPanel_ControlAdded);
            this.MessagesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MessagesPanel_Paint_1);
            // 
            // luskiTextBox1
            // 
            this.luskiTextBox1.BlendingFactor = 0F;
            this.luskiTextBox1.DarkBlendImage = null;
            this.luskiTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.luskiTextBox1.LightBlendImage = null;
            this.luskiTextBox1.Location = new System.Drawing.Point(12, 527);
            this.luskiTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.luskiTextBox1.MaxTextLength = 32767;
            this.luskiTextBox1.Multiline = false;
            this.luskiTextBox1.Name = "luskiTextBox1";
            this.luskiTextBox1.PasswordCharacter = '\0';
            this.luskiTextBox1.PlaceholderText = "";
            this.luskiTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.luskiTextBox1.SelectedText = "";
            this.luskiTextBox1.SelectionLength = 0;
            this.luskiTextBox1.SelectionStart = 0;
            this.luskiTextBox1.Size = new System.Drawing.Size(675, 31);
            this.luskiTextBox1.TabIndex = 4;
            this.luskiTextBox1.TabStop = false;
            this.luskiTextBox1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.luskiTextBox1.UseSystemPasswordChar = false;
            this.luskiTextBox1.Click += new System.EventHandler(this.luskiTextBox1_Click);
            this.luskiTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.luskiTextBox1_KeyDown);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.MessagesPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.luskiTextBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Chat";
            this.Size = new System.Drawing.Size(700, 570);
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
