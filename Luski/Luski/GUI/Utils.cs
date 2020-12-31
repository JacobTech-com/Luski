using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Luski.GUI
{
    public class Utils
    {
        public static async void ConfigureSelectorGlow(List<dynamic> c)
        {
            float blendingFactor = 0;
            int i = 0;
            Timer timer1 = new Timer() { Enabled = false, Interval = 1 };

            await Glow();

            async Task Glow()
            {
                #region Properties
                Bitmap lightImage = new System.Drawing.Bitmap(@"LuskiData\Settings\Themes\Default\BasicBlack\SelectorBorderTextureLight.png"), darkImage = new System.Drawing.Bitmap(@"LuskiData\Settings\Themes\Default\BasicBlack\SelectorBorderTextureDark.png");

                #endregion

                i++;

                timer1.Tick += BlendTick;

                #region Assign Images
                c.ForEach(ctrl => { ctrl.LightBlendImage = lightImage; ctrl.DarkBlendImage = darkImage; });
                #endregion

                timer1.Enabled = true;

                #region Blending
                void BlendTick(object sender, EventArgs e)
                {
                    blendingFactor += .032f;
                    if (blendingFactor > 1)
                    {
                        blendingFactor = 0;
                        if ((i + 1) < 2)
                        {
                            c.ForEach(ctrl => { ctrl.LightBlendImage = lightImage; ctrl.DarkBlendImage = darkImage; });
                            i++;
                        }
                        else
                        {
                            c.ForEach(ctrl => { ctrl.LightBlendImage = darkImage; ctrl.DarkBlendImage = lightImage; });
                            i = 0;
                        }
                    }
                    c.ForEach(ctrl => { ctrl.BlendingFactor = blendingFactor; });
                }
                #endregion
            }
        }

        public static GraphicsPath MakeRectangle(float x, float y, float w, float h, float br)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddLine(x + br, y, x + w - (br * 2), y);
            p.AddArc(x + w - (br * 2), y, br * 2, br * 2, 270, 90);
            p.AddLine(x + w, y + br, x + w, y + h - (br * 2));
            p.AddArc(x + w - (br * 2), y + h - (br * 2), br * 2, br * 2, 0, 90);
            p.AddLine(x + w - (br * 2), y + h, x + br, y + h);
            p.AddArc(x, y + h - (br * 2), br * 2, br * 2, 90, 90);
            p.AddLine(x, y + h - (br * 2), x, y + br);
            p.AddArc(x, y, br * 2, br * 2, 180, 90);
            p.CloseFigure();

            return p;
        }

        public static GraphicsPath CreateUpRoundRect(float x, float y, float width, float height, float radius)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddLine(x + radius, y, x + width - (radius * 2), y);
            gp.AddArc(x + width - (radius * 2), y, radius * 2, radius * 2, 270, 90);

            gp.AddLine(x + width, y + radius, x + width, y + height - (radius * 2) + 1);
            gp.AddArc(x + width - (radius * 2), y + height - (radius * 2), radius * 2, 2, 0, 90);

            gp.AddLine(x + width, y + height, x + radius, y + height);
            gp.AddArc(x, y + height - (radius * 2) + 1, radius * 2, 1, 90, 90);

            gp.AddLine(x, y + height, x, y + radius);
            gp.AddArc(x, y, radius * 2, radius * 2, 180, 90);

            gp.CloseFigure();
            return gp;
        }

        public static GraphicsPath CreateLeftRoundRect(float x, float y, float width, float height, float radius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(x + radius, y, x + width - (radius * 2), y);
            gp.AddArc(x + width - (radius * 2), y, radius * 2, radius * 2, 270, 90);

            gp.AddLine(x + width, y + 0, x + width, y + height);
            gp.AddArc(x + width - (radius * 2), y + height - (1), radius * 2, 1, 0, 90);

            gp.AddLine(x + width - (radius * 2), y + height, x + radius, y + height);
            gp.AddArc(x, y + height - (radius * 2), radius * 2, radius * 2, 90, 90);

            gp.AddLine(x, y + height - (radius * 2), x, y + radius);
            gp.AddArc(x, y, radius * 2, radius * 2, 180, 90);

            gp.CloseFigure();
            return gp;
        }

        public static Color BlendColor(Color backgroundColor, Color frontColor)
        {
            double ratio = 0 / 255d;
            double invRatio = 1d - ratio;
            int r = (int)((backgroundColor.R * invRatio) + (frontColor.R * ratio));
            int g = (int)((backgroundColor.G * invRatio) + (frontColor.G * ratio));
            int b = (int)((backgroundColor.B * invRatio) + (frontColor.B * ratio));
            return Color.FromArgb(r, g, b);
        }

        public static class StringFormats
        {
            public static StringFormat TopLeft
            {
                get => new StringFormat
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Near
                };
            }
            public static StringFormat TopCenter
            {
                get => new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Near
                };
            }
            public static StringFormat TopRight
            {
                get => new StringFormat
                {
                    Alignment = StringAlignment.Far,
                    LineAlignment = StringAlignment.Near
                };
            }
            public static StringFormat Left
            {
                get => new StringFormat
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Center
                };
            }
            public static StringFormat Center
            {
                get => new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
            }
            public static StringFormat Right
            {
                get => new StringFormat
                {
                    Alignment = StringAlignment.Far,
                    LineAlignment = StringAlignment.Center
                };
            }
            public static StringFormat BottomLeft
            {
                get => new StringFormat
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Far
                };
            }
            public static StringFormat BottomCenter
            {
                get => new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Far
                };
            }
            public static StringFormat BottomRight
            {
                get => new StringFormat
                {
                    Alignment = StringAlignment.Far,
                    LineAlignment = StringAlignment.Far
                };
            }
        }
    }
}