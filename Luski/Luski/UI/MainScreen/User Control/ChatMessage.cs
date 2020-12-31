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

        public ChatMessage(IMessage message)
        {
            InitializeComponent();
            IUser author = message.GetAuthor();
            label1.Text = author.Username;
            label2.Text = message.Context;
            label3.Location = new Point(label1.Location.X + label1.Size.Width + 4, label3.Location.Y);
            label2.AutoEllipsis = true;
            label2.Width = this.Width - label2.Location.X - 4;
            label3.Text = "" + message.Id; // placeholder until timestamps
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BackgroundImage = CropToCircle(author.GetAvatar(), Color.Transparent);
            Size sz = new Size(int.MaxValue, int.MaxValue);
            Size size = TextRenderer.MeasureText(label2.Text, label2.Font, sz, TextFormatFlags.WordBreak);
            lastY = label2.Location.Y + size.Height;
            //Width = 300;
        }
        // im making small chanbges
        public static Image CropToCircle(Image srcImage, Color backGround)
        {
            Bitmap dstImage = new Bitmap(srcImage);
            Graphics g = Graphics.FromImage(dstImage);
            using (Brush br = new SolidBrush(backGround))
            {
                g.FillRectangle(br, 0, 0, dstImage.Width, dstImage.Height);
            }

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, dstImage.Width, dstImage.Height);
            g.SetClip(path);
            g.DrawImage(srcImage, 0, 0);

            return dstImage;
        }

        private void ChatMessage_Load(object sender, EventArgs e)
        {

        }

        public void AddMessage(IMessage msg)
        {
            /*
             * this took 3 hours to make
             *   -xnq
            */

            Label newLabel = new Label();

            newLabel.BackColor = Color.Transparent;
            newLabel.Font = label2.Font;
            newLabel.ForeColor = label2.ForeColor;
            newLabel.Text = msg.Context;
            newLabel.Width = label2.Width;
            newLabel.AutoSize = false;
            newLabel.AutoEllipsis = true;

            Size textSize = TextRenderer.MeasureText(newLabel.Text, newLabel.Font, new Size(int.MaxValue, int.MaxValue), TextFormatFlags.Default);
            int messageGroupSpacing = 4;

            newLabel.Location = new Point(label2.Location.X, lastY + messageGroupSpacing);
            lastY += messageGroupSpacing + textSize.Height;
            Height += messageGroupSpacing + textSize.Height;

            Controls.Add(newLabel);
        }
    }
}
