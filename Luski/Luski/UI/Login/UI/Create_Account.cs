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
    public partial class Create_Account : UserControl
    {
        private string png = null;

        public Create_Account()
        {
            InitializeComponent();
        }

        private void LollipopButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Picture Files (*.png)|*.png",
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                png = Path.GetFullPath(ofd.FileName);
                pictureBox2.Image = new Bitmap(png);
            }
            else
            {
                lollipopButton1.Enabled = true;
                png = null;
            }
        }

        private async void LollipopButton2_Click(object sender, EventArgs e)
        {
            string[] arr = new string[]
            {
                metroTextBox1.Text,
                metroTextBox3.Text,
                png,
                metroTextBox5.Text,
            };
            if (arr.Any(str => string.IsNullOrEmpty(str)))
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else if (metroTextBox1.Text != metroTextBox2.Text)
            {
                MessageBox.Show("The emails do not match.");
            }
            else if (metroTextBox3.Text != metroTextBox4.Text)
            {
                MessageBox.Show("The passwords do not match.");
            }
            else
            {
                try
                {
                    new MainScreen.MainScreen(new Server.CreateAccount(metroTextBox1.Text, metroTextBox5.Text, metroTextBox3.Text, Image.FromFile(png))).Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
