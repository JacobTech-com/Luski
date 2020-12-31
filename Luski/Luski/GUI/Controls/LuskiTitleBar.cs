using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Luski.GUI.Controls
{
    public class LuskiTitleBar : ContainerControl
    {
        #region Properties
        private bool mouseDown = false;
        private Point location;
        private Rectangle mRect, mxRect, closeBox;
        private Image icon = null;
        private Color themeColor = Luski.GUI.CurrentTheme.Theme.ForeColor;

        public Color ThemeColor
        {
            get
            {
                return themeColor;
            }
            set
            {
                themeColor = value;
                Invalidate();
            }
        }

        public Image Icon
        {
            get
            {
                return icon;
            }
            set
            {
                icon = value;
                Invalidate();
            }
        }

        [DefaultValue(true)]
        [Category("Control")]
        public bool MinimizeBox
        {
            get
            {
                return ParentForm.MinimizeBox;
            }
        }

        [DefaultValue(false)]
        [Category("Control")]
        public bool MaximizeBox
        {
            get
            {
                return ParentForm.MaximizeBox;
            }
        }

        [DefaultValue(true)]
        [Category("Control")]
        public bool ControlBox
        {
            get
            {
                return ParentForm.ControlBox;
            }
        }
        #endregion

        #region Overrides
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                location = e.Location;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (mouseDown) Parent.Location = new Point(MousePosition.X - location.X, MousePosition.Y - location.Y);
            else
            {
                location = e.Location;
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            mouseDown = false;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (mRect.Contains(location)) ParentForm.WindowState = FormWindowState.Minimized; 
            if (mxRect.Contains(location))
            {
                if (ParentForm.WindowState == FormWindowState.Maximized)  ParentForm.WindowState = FormWindowState.Normal; 
                else ParentForm.WindowState = FormWindowState.Maximized; 
            }
            if (closeBox.Contains(location)) ParentForm.Close();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Height = 45;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            ParentForm.FormBorderStyle = FormBorderStyle.None;
            ParentForm.AllowTransparency = false;
            ParentForm.FindForm().StartPosition = FormStartPosition.CenterScreen;
            ParentForm.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            #region Draw TitleBar
            base.OnPaint(e);
            Location = new Point(0, 0);
            Width = ParentForm.Width;
            Bitmap bitmap = new Bitmap(Width, Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            graphics.Clear(themeColor);

            #region Separator
            graphics.FillRectangle(new SolidBrush(Color.Silver), new Rectangle(15, 43, this.Width - 30, 1));
            #endregion

            #region Icon
            var symbols = new Font("Marlett", 12);
            if (icon != null)
            {
                graphics.DrawImage(icon, new Rectangle(29, 10, 32, 32));
                graphics.DrawString(Text, Font, new SolidBrush(Color.White), new Rectangle(66, 5, Width - 100, Height), Utils.StringFormats.Left);
            }
            else graphics.DrawString(Text, Font, new SolidBrush(Color.White), new Rectangle(15, 1, Width - 100, Height), Utils.StringFormats.Left);
            #endregion

            #region Control Boxes
            if (ControlBox)
            {
                if (MinimizeBox)
                {
                    mRect = new Rectangle(Width - 54 - (MaximizeBox ? 1 : 0) * 22, (Height - 16) / 2, 18, 18);
                    if (mRect.Contains(location)) graphics.DrawString("0", symbols, new SolidBrush(Color.White), mRect, Utils.StringFormats.Center);
                    else graphics.DrawString("0", symbols, new SolidBrush(Color.White), mRect, Utils.StringFormats.Center);
                }
                if (MaximizeBox)
                {
                    mxRect = new Rectangle(Width - 54, (Height - 16) / 2, 18, 18);
                    if (mxRect.Contains(location))
                    {
                        if (ParentForm.WindowState == FormWindowState.Normal) graphics.DrawString("1", symbols, new SolidBrush(Color.White), mxRect, Utils.StringFormats.Center);
                        else graphics.DrawString("2", symbols, new SolidBrush(Color.White), mxRect, Utils.StringFormats.Center);
                    }
                    else
                    {
                        if (ParentForm.WindowState == FormWindowState.Normal) graphics.DrawString("1", symbols, new SolidBrush(Color.White), mxRect, Utils.StringFormats.Center);
                        else graphics.DrawString("2", symbols, new SolidBrush(Color.White), mxRect, Utils.StringFormats.Center);
                    }
                }

                closeBox = new Rectangle(Width - 32, (Height - 16) / 2, 18, 18);
                if (closeBox.Contains(location)) graphics.DrawString("r", symbols, new SolidBrush(Color.Red), closeBox, Utils.StringFormats.Center);
                else graphics.DrawString("r", symbols, new SolidBrush(Color.White), closeBox, Utils.StringFormats.Center);
            }
            #endregion

            base.OnPaint(e);
            graphics.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
            bitmap.Dispose();
            #endregion
        }
        #endregion

        public LuskiTitleBar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            Height = 45;
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        }
    }
}