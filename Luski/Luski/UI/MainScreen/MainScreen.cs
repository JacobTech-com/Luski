using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Luski.net;
using Luski.net.Interfaces;
using Luski.UI.MainScreen.User_Control;
using Luski.UI.Theme;

namespace Luski.UI.MainScreen
{
    public partial class MainScreen : Form
    {
        private new bool MouseDown = false;
        private Point LastLocation;
        Color CloseHove = Color.Red;
        Color CloseCol = Color.White;
        Color TitleBarCol = Color.FromArgb(255,32,32,32);

        public MainScreen(Server.Login Login)
        {
            InitializeComponent();
            Program.Server = Login;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }



        private List<Friend> fr = new List<Friend>();

        private void MainScreen_Load(object sender, EventArgs e)
        {
            //ThemeManager.ThemeUpdate += ThemeManager_ThemeUpdate;

            var m = Program.Server.CurrentUser.GetAvatar();
            UserIcon.BackgroundImage = m;
            UsernameLabel.Text = Program.Server.CurrentUser.Username;
            int inttag = Program.Server.CurrentUser.Tag;
            string tag;
            tag = inttag != -1 ? $"000{inttag}".Substring($"000{inttag}".Length - 4) : "Developer";
            TagLabel.Text = "#" + tag;
            ChannelPickerPanel.HorizontalScroll.Enabled = false;
            ChannelPickerPanel.HorizontalScroll.Visible = false;


            IReadOnlyList<IRemoteUser> friends = Program.Server.CurrentUser.Friends;
            Friend f = new Friend(Program.Server.GetUser(0));
            f.ClickCon += Friend_Click;
            ChannelPickerPanel.Controls.Add(f);
            List<IChannel> chans = new List<IChannel>();

            foreach (IRemoteUser item in friends)
            {
                if (item.Channel != null)
                {
                    chans.Add(item.Channel);
                    Friend friend = new Friend(item);
                    fr.Add(friend);
                    friend.ClickCon += Friend_Click;
                    ChannelPickerPanel.Controls.Add(friend);
                }
            }

            foreach (IChannel ch in Program.Server.CurrentUser.Channels)
            {
                if (!chans.Contains(ch)  && ch.Id != 0)
                {
                    Group friend = new Group(ch);
                    friend.ClickCon += Friend_Click;
                    ChannelPickerPanel.Controls.Add(friend);
                }
            }

            IChannel chan = Program.Server.GetChannel(Program.Server.CurrentUser.SelectedChannel);
            chat1.UpdateChannel(chan.Title, chan.Description);
            IReadOnlyList<IMessage> msgs = chan.GetMessages(200);
            foreach (IMessage msg in msgs.Reverse())
            {
                chat1.addMessage(msg);
            }
            Program.Server.MessageReceived += Server_MessageReceived;
            Program.Server.UserStatusUpdate += Server_UserStatusUpdate;
        }

        private async Task Server_UserStatusUpdate(IUser before, IUser after)
        {
            fr.Where(s => s.User.ID == before.ID).First().UpdateStatus(after.Status.ToString());
        }

        private async Task Server_MessageReceived(IMessage arg)
        {
            if (arg.GetChannel().Id != Program.Server.CurrentUser.SelectedChannel) return;
            chat1.addMessage(arg);
        }

        private async Task Friend_Click(IChannel channel)
        {
            if (chat1.id != channel.Id.ToString())
            {
                chat1.ClearChat();
                chat1.UpdateChannel(channel.Title, channel.Description);
                IReadOnlyList<IMessage> msgs = channel.GetMessages();
                foreach (IMessage msg in msgs.Reverse())
                {
                    chat1.addMessage(msg);
                }
                Program.Server.ChangeChannel(channel.Id);
            }
        }

        public void Notification(string note)
        {
            notifyIcon1.ShowBalloonTip(1000, "New", "This is a test", ToolTipIcon.None);
        }

        private async Task ThemeManager_ThemeUpdate()
        {
            #region Title Bar
            //TitleBarCol = the
            #endregion
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            LastLocation = e.Location;
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                Location = new Point(Location.X - LastLocation.X + e.X, Location.Y - LastLocation.Y + e.Y);
            }
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = CloseHove;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = CloseCol;
        }

        private void friendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nOTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void friendsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (friendsPanel1.Enabled)
            {
                friendsPanel1.Enabled = false;
                friendsPanel1.Visible = false;
                friendsPanel1.SendToBack();
            }
            else
            {
                friendsPanel1.Enabled = true;
                friendsPanel1.Visible = true;
                friendsPanel1.BringToFront();
            }
        }

        private void noteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Notification("bob");
        }


        private void chat1_Load_1(object sender, EventArgs e)
        {

        }

        private void MainScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;
                }
                else
                {
                    WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void UserIcon_Click(object sender, EventArgs e)
        {

        }

        private void chat1_Load(object sender, EventArgs e)
        {
            dynamic aaa = "{\"thing\":\"test\"}";
            string aaaa = (string)aaa;
        }

        private void ChannelPickerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void luskiButton1_Click(object sender, EventArgs e)
        {
            if (friendsPanel1.Enabled)
            {
                friendsPanel1.Enabled = false;
                friendsPanel1.Visible = false;
                friendsPanel1.SendToBack();
                luskiButton1.Text = "Friends";
            }
            else
            {
                friendsPanel1.Enabled = true;
                friendsPanel1.Visible = true;
                friendsPanel1.BringToFront();
                luskiButton1.Text = "Friends (Viewing)";
            }
        }

        private void luskiButton2_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // do funny test
            int dir = 0;
            while (true)
            {
                if (Width < 500 && dir == 0)
                {
                    Width++;
                }
                else if (Width > 100)
                {
                    dir = 1;
                    Width--;
                }
                else
                {
                    dir = 0;
                }
            }
        }
    }
}
