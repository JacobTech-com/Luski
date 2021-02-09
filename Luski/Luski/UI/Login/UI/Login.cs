using Luski.net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luski.UI.Login.UI
{
    public partial class Login_UI : UserControl
    {
        public Login_UI()
        {
            InitializeComponent();
        }

        private async void LollipopButton2_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text.Contains("@") && metroTextBox1.Text.Length > 5 && metroTextBox4.Text.Length > 8)
            {
                new MainScreen.MainScreen(new Server.Login(metroTextBox1.Text, metroTextBox4.Text)).Show();
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {
        }
    }
}
