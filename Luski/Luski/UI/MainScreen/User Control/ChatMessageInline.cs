using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Luski.net.Interfaces;

namespace Luski.UI.MainScreen.User_Control
{
    public partial class ChatMessageInline : UserControl
    {
        public ChatMessageInline(IMessage message)
        {
            InitializeComponent();
            IUser author = message.GetAuthor();
            label1.Text = author.Username;
            label2.Text = message.Context;
            label3.Location = new Point(label1.Location.X + 8, this.Size.Height / 2 - label3.Height);
            label3.Text = "" + message.Id; // placeholder until timestamps
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
