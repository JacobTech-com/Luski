using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;


namespace Luski.GUI.Controls
{
    public class LuskiFilledButton : Control
    {
        #region Properties

        bool isHovered = false;
        bool mouseDown = false;
        private Color backColor = Color.Red, altText = Luski.GUI.CurrentTheme.Theme.ForeColor;
        [RefreshProperties(RefreshProperties.Repaint)]
        public ButtonTheme ButtonTheme { get; set; } = ButtonTheme.Normal;
        [RefreshProperties(RefreshProperties.Repaint)]
        public Color TextColor { get; set; } = Color.White;
        [RefreshProperties(RefreshProperties.Repaint)]
        public Color BgColor
        {
            get
            {
                return backColor;
            }
            set
            {
                backColor = value;
                Invalidate();
            }
        }
        #endregion

        #region Overrides
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovered = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            mouseDown = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            mouseDown = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            #region Draw Button
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            graphics.Clear(Parent.BackColor);

            #region BG
            var BG = Luski.GUI.Utils.MakeRectangle(0, 0, Width, Height, 3);
            switch (ButtonTheme)
            {
                case ButtonTheme.Warning:
                    backColor = Color.Red;
                    break;
                default:
                    break;
            }
            var brush = new SolidBrush(isHovered ? (mouseDown ? backColor : Color.FromArgb(225, backColor)) : backColor);
            graphics.FillPath(brush, BG);
            if (!Enabled) graphics.FillPath(new SolidBrush(Color.FromArgb(128, Luski.GUI.CurrentTheme.Theme.ActiveColor)), BG);
            if (BackgroundImage != null) graphics.DrawImage(BackgroundImage, new Rectangle(0, (Height / 2) - (BackgroundImage.Height / 2), BackgroundImage.Width, BackgroundImage.Height));
            #endregion

            #region Text
            graphics.DrawString(Text, Font, new SolidBrush(TextColor), new RectangleF(0, -10, Width, Height), Utils.StringFormats.BottomCenter);
            
            #endregion
            #endregion
        }
        #endregion

        public LuskiFilledButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            Font = new Font("nintendo_udsg-r_std_003", 10);
        }
    }
}