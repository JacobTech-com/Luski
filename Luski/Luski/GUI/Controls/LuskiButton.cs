using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Luski.GUI.Controls
{
    public class LuskiButton : Control
    {
        #region Properties

        bool isHovered = false;
        bool mouseDown = false;
        bool buttonGlowState = true;
        private Image blendImageLight = null;
        private Image blendImageDark = null;
        private float blendingFactor = 0F;
        private Color backColor;

        public Image LightBlendImage
        {
            get { return blendImageLight; }
            set { blendImageLight = value; Invalidate(); }
        }

        public Image DarkBlendImage
        {
            get { return blendImageDark; }
            set { blendImageDark = value; Invalidate(); }
        }

        public float BlendingFactor
        {
            get { return blendingFactor; }
            set { blendingFactor = value; Invalidate(); }
        }

        public Color BackColor
        {
            get
            {
                return backColor;
            }
            set
            {
                backColor = value;
            }
        }

        private ButtonTheme _buttonTheme = ButtonTheme.Normal;
        public ButtonTheme ButtonTheme
        {
            get { return _buttonTheme; }
            set
            {
                _buttonTheme = value;
                Invalidate();
            }
        }

        private Color textColor = Color.White;
        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                Invalidate();
            }
        }
        #endregion

        #region Overrides
        protected override void OnMouseEnter(EventArgs e)
        {
            isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
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
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            graphics.Clear(Parent.BackColor);


            /*if (_buttonType == ButtonType.Normal)
            {
                var BG = Utils.Drawing.MakeRectangle(0.5f, 0.5f, Width - 1, Height - 1, 2.5f);
                graphics.DrawPath(new Pen(isHovered ? (mouseDown ? ThemeColors.DarkPrimary : ThemeColors.PrimaryColor) : ThemeColors.OneLevelBorder, 3f), BG);
                graphics.DrawString(Text, Font, new SolidBrush(isHovered ? (mouseDown?ThemeColors.DarkPrimary:ThemeColors.PrimaryColor ): ThemeColors.MainText), new RectangleF(0, 0, Width, Height), Utils.StringFormats.Center);
            }
            else
            {*/
            switch (_buttonTheme)
            {
                case ButtonTheme.Warning:
                    backColor = Color.Red;
                    break;
                default:
                    break;
            }

            var BG = Utils.MakeRectangle(0.5f, 0.5f, Width - 1, Height - 1, 4f);
            if (!isHovered)
            {
                BG = Utils.MakeRectangle(0, 0, Width, Height, 2.5f);
            }
            else if (isHovered)
            {
                #region Shadows
                // Top & bottom shadow
                graphics.FillRectangle(new SolidBrush(Color.FromArgb(64, Color.Black)), 5, 0, Width - 10, Height - 6);
                // Corner shadows
                graphics.FillRectangle(new SolidBrush(Color.FromArgb(64, Color.Black)), 4, 1, Width - 8, Height - 8);
                // Middle shadow
                graphics.FillRectangle(new SolidBrush(Color.FromArgb(64, Color.Black)), 3, 2, Width - 6, Height - 10);
                // Drop shadow
                graphics.FillRectangle(new SolidBrush(Color.FromArgb(32, Color.Black)), 5, Height - 6, Width - 10, 1);
                graphics.FillRectangle(new SolidBrush(Color.FromArgb(16, Color.Black)), 5, Height - 5, Width - 10, 1);
                graphics.FillRectangle(new SolidBrush(Color.FromArgb(8, Color.Black)), 5, Height - 4, Width - 10, 1);
                #endregion

                #region Pulsating Border

                // button glow state means
                // TRUE = can go light
                // FALSE = can go dark, dont do light code
                if (buttonGlowState) 
                {
                    if (blendingFactor < 1)
                    {
                        blendingFactor += 0.0005f;
                    }
                    else if (blendingFactor > 1)
                    {
                        buttonGlowState = false;
                    }
                }
                if (!buttonGlowState)
                {
                    blendingFactor -= 0.0005f;

                    if (blendingFactor < 0) // classic notch mistake
                    {
                        buttonGlowState = true;
                    }
                }

                Rectangle rc = new Rectangle();
                System.Drawing.Imaging.ColorMatrix cm = new System.Drawing.Imaging.ColorMatrix();
                System.Drawing.Imaging.ImageAttributes ia = new System.Drawing.Imaging.ImageAttributes();
                cm.Matrix33 = blendingFactor;
                ia.SetColorMatrix(cm);

                // Bright top & bottom border
                rc = new Rectangle(4, 2, Width - 8, Height - 10);
                e.Graphics.DrawImage(LightBlendImage, rc, 0, 0, LightBlendImage.Width, LightBlendImage.Height, GraphicsUnit.Pixel, ia);

                // Bright middle border
                rc = new Rectangle(5, 1, Width - 10, Height - 8);
                e.Graphics.DrawImage(LightBlendImage, rc, 0, 0, LightBlendImage.Width, LightBlendImage.Height, GraphicsUnit.Pixel, ia);

                // Prepare for dark borders
                cm.Matrix33 = 1F - blendingFactor;
                ia.SetColorMatrix(cm);

                // Dark top & bottom border
                rc = new Rectangle(4, 2, Width - 8, Height - 10);
                e.Graphics.DrawImage(DarkBlendImage, rc, 0, 0, DarkBlendImage.Width, DarkBlendImage.Height, GraphicsUnit.Pixel, ia);

                // Dark middle border
                rc = new Rectangle(5, 1, Width - 10, Height - 8);
                e.Graphics.DrawImage(DarkBlendImage, rc, 0, 0, DarkBlendImage.Width, DarkBlendImage.Height, GraphicsUnit.Pixel, ia);
                #endregion

                #region Misc.
                rc = new Rectangle(7, 4, Width - 14, Height - 14);
                e.Graphics.FillRectangle(new SolidBrush(mouseDown ? Color.FromArgb(255, 42, 44, 48) : Color.FromArgb(255, 32, 34, 38)), rc);
                #endregion

                Invalidate();
            }

            graphics.DrawString(Text, Font, new SolidBrush(isHovered ? Luski.GUI.CurrentTheme.Theme.ActiveColor : Luski.GUI.CurrentTheme.Theme.ForeColor), new RectangleF(Height / 4, ((Height - 4) / 2) - Font.Size, Width, Height), Utils.StringFormats.TopLeft);
        }

        #endregion

        public LuskiButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            Font = new Font("nintendo_udsg-r_std_003", 10);
        }
    }
}