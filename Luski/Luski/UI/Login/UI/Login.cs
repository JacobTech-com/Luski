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
        bool Email = false;
        bool pw = false;

        public Login_UI()
        {
            InitializeComponent();
        }

        private async void LollipopButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Email && pw)
                {
                    new MainScreen.MainScreen(new Server.Login(metroTextBox1.Text, metroTextBox4.Text)).Show();
                }
                else
                {
                    MessageBox.Show("Fill in your email and password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            if (!Email)
            {
                metroTextBox1.Clear();
                Email = true;
            }
        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {
            if (!pw)
            {
                metroTextBox4.Clear();
                pw = true;
            }
        }
    }
}
