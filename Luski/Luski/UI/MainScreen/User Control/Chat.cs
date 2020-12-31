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
        IUser lastUser = null;
        ChatMessage lastMessage = null;

        public Chat()
        {
            InitializeComponent();
        }

        private void MessagesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void addMessage(IMessage message)
        {
            if (message.GetAuthor() == null)
            {
                return;
            }

            if (lastUser == null || lastUser.ID != message.GetAuthor().ID)
            {
                if (lastMessage == null)
                {
                    MessagesPanel.Controls.Add(lastMessage = new ChatMessage(message)
                    {
                        Size = new Size(MessagesPanel.Width, 48),
                        Anchor = AnchorStyles.Left | AnchorStyles.Right,
                        Location = new Point(3,3),
                    });
                }
                else
                {
                    MessagesPanel.Controls.Add(lastMessage = new ChatMessage(message)
                    {
                        Size = new Size(MessagesPanel.Width, 48),
                        Anchor = AnchorStyles.Left | AnchorStyles.Right,
                    });
                }
            }
            else if (lastMessage != null)
            {
                lastMessage.AddMessage(message);
            }

            lastUser = message.GetAuthor();
        }

        public void addMessageInline(IMessage message)
        {
            MessagesPanel.Controls.Add(new ChatMessageInline(message));
        }

        private void luskiFilledButton1_Click(object sender, EventArgs e)
        {
            //luskiButton1.BlendingFactor += 1;
        }

        private void luskiButton1_Enter(object sender, EventArgs e)
        {
            //luskiButton1.BlendingFactor += 0.05f;
        }

        private void luskiButton1_MouseHover(object sender, EventArgs e)
        {
            //luskiButton1.BlendingFactor += 0.2f;
        }

        private void luskiButton1_MouseEnter(object sender, EventArgs e)
        {
            //luskiButton1.BlendingFactor += 0.2f;
        }

        private void luskiTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Chat_Resize(object sender, EventArgs e)
        {
            panel1.Width = this.Width;
        }

        private void luskiTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void luskiTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Program.Server.SendMessage(luskiTextBox2.Text, Program.Server.CurrentUser.SelectedChannel);
            }
        }
    }
}