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
        Server.Login s => Program.Server;

        public MainScreen(Server.Login Login)
        {
            InitializeComponent();
            Program.Server = Login;
        }

        public static Image CropToCircle(Image srcImage, Color backGround)
        {
            Bitmap dstImage = new Bitmap(srcImage);
            Graphics g = Graphics.FromImage(dstImage);
            using (Brush br = new SolidBrush(backGround))
            {
                g.FillRectangle(br, 20, 0, srcImage.Width, srcImage.Height);
            }

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, srcImage.Width, srcImage.Height);
            g.SetClip(path);
            g.DrawImage(srcImage, 0, 0);

            return dstImage;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            //ThemeManager.ThemeUpdate += ThemeManager_ThemeUpdate;

            UserIcon.BackgroundImage = CropToCircle(Program.Server.CurrentUser.GetAvatar(), BackColor);
            UsernameLabel.Text = Program.Server.CurrentUser.Username;
            int inttag = Program.Server.CurrentUser.Tag;
            string tag;
            tag = inttag != -1 ? $"000{inttag}".Substring($"000{inttag}".Length - 4) : "Developer";
            TagLabel.Text = "#" + tag;


            IReadOnlyList<net.Interfaces.IRemoteUser> friends = Program.Server.CurrentUser.Friends;
            ChannelPickerPanel.Controls.Add(new Friend(Program.Server.GetUser(0)));

            foreach (net.Interfaces.IRemoteUser item in friends)
            {
                ChannelPickerPanel.Controls.Add(new Friend(item));
            }

            IUser lastUser;
            IReadOnlyList<net.Interfaces.IMessage> msgs = Program.Server.GetChannel(Program.Server.CurrentUser.SelectedChannel).GetMessages();
            for (int i = 0; i < msgs.Count; i++)
            {
                chat1.addMessage(msgs[i]);
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Username: " + s.CurrentUser.Username + "\n" + "Email: " + s.CurrentUser.Email + "\n" + "ID: " + s.CurrentUser.ID);
            UsernameLabel.Text = s.CurrentUser.Username;
            TagLabel.Text = "#" + s.CurrentUser.Tag;
        }

        private void chat1_Load(object sender, EventArgs e)
        {

        }

        private void chat1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
