using Luski.net.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luski.UI.MainScreen.User_Control
{
    public partial class Group : UserControl
    {
        IChannel chan;
        public Group(IChannel person)
        {
            //bob
            InitializeComponent();
            chan = person;
            UsernameLabel.Text = person.Title;
            pictureBox1.BackgroundImage = person.Members.First().GetAvatar();
            StatusLabel.Text = person.Description;
        }

        public event Func<IChannel, Task> ClickCon;

        private void UsernameLabel_Click(object sender, EventArgs e)
        {
            if (ClickCon != null) ClickCon.Invoke(chan);
        }
    }
}
