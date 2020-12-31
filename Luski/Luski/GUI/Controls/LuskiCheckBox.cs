using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Luski.GUI.Controls
{
    public class LuskiCheckBox : CheckBox
    {
        #region Properties
        Color CheckedColor = Luski.GUI.CurrentTheme.Theme.ActiveColor;
        Color UnCheckedColor = Luski.GUI.CurrentTheme.Theme.ElementBackColor;
        Color DisabledColor = Luski.GUI.CurrentTheme.Theme.DisabledColor;
        Color themeColor = Luski.GUI.CurrentTheme.Theme.ForeColor;
        Color DisabledText = Luski.GUI.CurrentTheme.Theme.ForeColor;

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
        
        bool isHovered = false;
        #endregion

        #region Overrides
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
        }

        protected override void OnResize(EventArgs e)
        {
            Height = 20;
            Width = 25 + (int)CreateGraphics().MeasureString(Text, Font).Width;
        }

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

        protected override void OnPaint(PaintEventArgs e)
        {
            #region Draw Checkbox
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            graphics.Clear(Parent.BackColor);

            #region BG
            var checkmarkPath = Utils.MakeRectangle(1, 1, 18, 18, 2);
            CheckedColor = themeColor;
            SolidBrush BG = new SolidBrush(Enabled ? (Checked || isHovered ? CheckedColor : UnCheckedColor) : DisabledColor);
            Pen Pen = new Pen(Color.FromArgb(60, Color.Black));
            graphics.FillPath(BG, checkmarkPath);
            graphics.DrawPath(Pen, checkmarkPath);
            #endregion

            #region Checkmark
            graphics.DrawLines(new Pen(Checked || isHovered ? Parent.BackColor : Luski.GUI.CurrentTheme.Theme.ElementBackColor, 2), new PointF[]
            {
                new PointF(4, 10),new PointF(8, 14), new PointF(16, 5f)
            });
            #endregion

            #region Text
            graphics.DrawString(Text, Font, new SolidBrush(Checked ? themeColor : DisabledText), new RectangleF(22, 0, Width - 22, Height), Utils.StringFormats.Center);
            #endregion
            #endregion
        }
        #endregion

        public LuskiCheckBox()
        {
            Font = new Font("nintendo_udsg-r_std_003", 9);
        }
    }
}