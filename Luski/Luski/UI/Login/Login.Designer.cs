
namespace Luski.UI.Login
{
    partial class Login
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
            this.create_Account1 = new Luski.UI.Login.UI.Create_Account();
            this.login_UI1 = new Luski.UI.Login.UI.Login_UI();
            this.SuspendLayout();
            // 
            // create_Account1
            // 
            this.create_Account1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.create_Account1.Location = new System.Drawing.Point(690, 252);
            this.create_Account1.Name = "create_Account1";
            this.create_Account1.Size = new System.Drawing.Size(411, 654);
            this.create_Account1.TabIndex = 0;
            // 
            // login_UI1
            // 
            this.login_UI1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login_UI1.Location = new System.Drawing.Point(81, 252);
            this.login_UI1.Name = "login_UI1";
            this.login_UI1.Size = new System.Drawing.Size(411, 525);
            this.login_UI1.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 1156);
            this.Controls.Add(this.login_UI1);
            this.Controls.Add(this.create_Account1);
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Create_Account create_Account1;
        private UI.Login_UI login_UI1;
    }
}