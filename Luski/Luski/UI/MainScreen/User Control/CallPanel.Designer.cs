namespace Luski.UI.MainScreen.User_Control
{
    partial class CallPanel
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
            this.luskiFilledButton1 = new Luski.GUI.Controls.LuskiFilledButton();
            this.SuspendLayout();
            // 
            // luskiFilledButton1
            // 
            this.luskiFilledButton1.BgColor = System.Drawing.Color.Red;
            this.luskiFilledButton1.ButtonTheme = Luski.GUI.Controls.ButtonTheme.Warning;
            this.luskiFilledButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.luskiFilledButton1.Location = new System.Drawing.Point(3, 3);
            this.luskiFilledButton1.Name = "luskiFilledButton1";
            this.luskiFilledButton1.Size = new System.Drawing.Size(232, 40);
            this.luskiFilledButton1.TabIndex = 0;
            this.luskiFilledButton1.Text = "make call";
            this.luskiFilledButton1.TextColor = System.Drawing.Color.White;
            this.luskiFilledButton1.Click += new System.EventHandler(this.luskiFilledButton1_Click);
            // 
            // CallPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.luskiFilledButton1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CallPanel";
            this.Size = new System.Drawing.Size(238, 46);
            this.ResumeLayout(false);

        }

        #endregion

        private GUI.Controls.LuskiFilledButton luskiFilledButton1;
    }
}
