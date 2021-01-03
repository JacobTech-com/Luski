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
    public partial class FriendsPanel : UserControl
    {
        public FriendsPanel()
        {
            InitializeComponent();
        }

        private void FriendsPanel_Load(object sender, EventArgs e)
        {
            if (Program.Server != null)
            {
                IReadOnlyList<IRemoteUser> friends = Program.Server.CurrentUser.Friends;

                foreach (IRemoteUser item in friends)
                {
                    Friend friend = new Friend(item);
                    flowLayoutPanel1.Controls.Add(friend);
                }
            }
        }
    }
}
