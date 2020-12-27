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

namespace Luski.UI.Main_Form.User_Control
{
    public partial class Friend : UserControl
    {
        IRemoteUser User;
        public Friend(IRemoteUser person)
        {
            //bob
            InitializeComponent();
            User = person;
            UsernameLabel.Text = person.Username;
            pictureBox1.BackgroundImage = person.GetAvatar();
            StatusLabel.Text = person.Status.ToString();
        }
    }
}
