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
using System.Drawing.Drawing2D;

namespace Luski.UI.MainScreen.User_Control
{
    public partial class ChatMessage : UserControl
    {
        int lastY = 0;
        IMessage _msg;
        public ChatMessage(IMessage message)
        {
            InitializeComponent();
            _msg = message;
        }

        public void AddMessage(IMessage msg)
        {
            Label newLabel = new Label();
            newLabel.BackColor = Color.Transparent;
            newLabel.Font = label2.Font;
            newLabel.ForeColor = label2.ForeColor;
            newLabel.Text = msg.Context;
            newLabel.AutoSize = false;
            Size textSize = TextRenderer.MeasureText(newLabel.Text, newLabel.Font, new Size(Width -label2.Location.X -4, int.MaxValue), TextFormatFlags.WordBreak);
            newLabel.Width = textSize.Width;
            newLabel.Height = textSize.Height;
            newLabel.Text = msg.Context;
            int messageGroupSpacing = 4;
            newLabel.Location = new Point(label2.Location.X, lastY + messageGroupSpacing);
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    
                    lastY += messageGroupSpacing + textSize.Height;
                    Height += messageGroupSpacing + textSize.Height;
                    Controls.Add(newLabel);
                    //newLabel.Focus();
                }));
            }
            else
            {
                lastY += messageGroupSpacing + textSize.Height;
                Height += messageGroupSpacing + textSize.Height;
                Controls.Add(newLabel);
                //newLabel.Focus();
            }
        }

        private void ChatMessage_Load(object sender, EventArgs e)
        {
            IUser author = _msg.GetAuthor();
            label1.Text = author.Username;
            label2.Text = _msg.Context;
            label3.Location = new Point(label1.Location.X + label1.Size.Width + 4, label3.Location.Y);
            label2.AutoSize = false;
            label3.Text = "" + _msg.Id; // placeholder until timestamps
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            Image m = author.GetAvatar();
            pictureBox1.BackgroundImage = m.CropToCircle(m.Width / 2, BackColor); ;
            label2.AutoSize = false;
            Size textSize = TextRenderer.MeasureText(label2.Text, label2.Font, new Size(Width - label2.Location.X - 4, int.MaxValue), TextFormatFlags.WordBreak);
            Height += textSize.Height - label2.Height + 4;
            label2.Width = textSize.Width;
            label2.Height = textSize.Height;
            label2.Text = _msg.Context;
            //label2.Focus();
            lastY = label2.Location.Y + label2.Height;
        }
    }
}
