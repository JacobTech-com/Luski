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
    public partial class Chat : UserControl
    {
        public string id = "-1";
        IUser lastUser = null;
        ChatMessage lastMessage = null;
        int down = 0;
        int downn = 0;
        public Chat()
        {
            InitializeComponent();
            down = Height- luskiTextBox1.Location.Y;
            downn = Height - (MessagesPanel.Location.Y + MessagesPanel.Size.Height);
        }

        private void MessagesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void UpdateChannel(string Name, string dec = null)
        {
            label1.Text = Name;
            if (dec != null)
            {
                label2.Visible = true;
                label2.Text = dec;
                label2.Location = new Point(label1.Location.X + label1.Size.Width + 2, label2.Location.Y);
            }
            else
            {
                label2.Visible = false;
            }
        }

        public void ClearChat()
        {
            id = "-1";
            MessagesPanel.Controls.Clear();
            lastMessage = null;
            lastUser = null;
        }

        public void addMessage(IMessage message)
        {
            if (id == "-1") id = message.GetChannel().Id.ToString();
            IUser a = message.GetAuthor();
            if (a == null)
            {
                return;
            }
            
            if (lastUser == null)
            {

                if (MessagesPanel.InvokeRequired)
                {
                    MessagesPanel.Invoke(new Action(() =>
                    {
                        MessagesPanel.Controls.Add(lastMessage = new ChatMessage(message)
                        {
                            Size = new Size(MessagesPanel.Width - 25, 48),
                            Anchor = AnchorStyles.Left | AnchorStyles.Right,
                        });
                    }));
                }
                else
                {
                    MessagesPanel.Controls.Add(lastMessage = new ChatMessage(message)
                    {
                        Size = new Size(MessagesPanel.Width -25, 48),
                        Anchor = AnchorStyles.Left | AnchorStyles.Right,
                    });
                }
            }
            else if (lastUser.ID != a.ID)
            {
                if (MessagesPanel.InvokeRequired)
                {
                    MessagesPanel.Invoke(new Action(() =>
                    {
                        MessagesPanel.Controls.Add(lastMessage = new ChatMessage(message)
                        {
                            Size = new Size(MessagesPanel.Width -25, 48),
                            Anchor = AnchorStyles.Left | AnchorStyles.Right,
                        });
                    }));
                }
                else
                {
                    MessagesPanel.Controls.Add(lastMessage = new ChatMessage(message)
                    {
                        Size = new Size(MessagesPanel.Width-25, 48),
                        Anchor = AnchorStyles.Left | AnchorStyles.Right,
                    });
                }
            }
            else
            {
                lastMessage.AddMessage(message);
            }
            lastUser = a;
        }

        public void addMessageInline(IMessage message)
        {
            MessagesPanel.Controls.Add(new ChatMessageInline(message));
        }

        private void Chat_Resize(object sender, EventArgs e)
        {
            panel1.Width = this.Width;
            luskiTextBox1.Width = Width - (luskiTextBox1.Location.X * 2);
            if (down != 0) luskiTextBox1.Location = new Point(luskiTextBox1.Location.X, Height - down);
            if (downn != 0) MessagesPanel.Size = new Size(MessagesPanel.Size.Width, Height - downn);
        }

        private void luskiTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Enter)
            {
                Program.Server.SendMessage(luskiTextBox1.Text, Program.Server.CurrentUser.SelectedChannel);
                luskiTextBox1.Clear();
            }
        }
    }
}