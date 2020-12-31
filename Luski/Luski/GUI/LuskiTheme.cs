using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Luski.GUI
{
    public class LuskiTheme
    {
        public Color BackColor
        {
            get;
            set;
        }
        public Color ElementBackColor
        {
            get;
            set;
        }
        public Color SideMenuColor
        {
            get;
            set;
        }
        public Color ActiveColor
        {
            get;
            set;
        }
        public Color InactiveColor
        {
            get;
            set;
        }
        public Color DisabledColor
        {
            get;
            set;
        }
        public Color ForeColor
        {
            get;
            set;
        }
        public Color WireframeColorTL
        {
            get;
            set;
        }
        public Color WireframeColorTR
        {
            get;
            set;
        }
        public Color WireframeColorBL
        {
            get;
            set;
        }
        public Color WireframeColorBR
        {
            get;
            set;
        }
        public Color WireframeColorOverlay
        {
            get;
            set;
        }

        public LuskiTheme()
        {

        }

        public LuskiTheme(Color BackColor, Color ElementBackColor, Color SideMenuColor, Color ActiveColor, Color InactiveColor, Color DisabledColor, Color ForeColor, Color WireframeColorTL, Color WireframeColorTR, Color WireframeColorBL, Color WireframeColorBR, Color WireframeColorOverlay)
        {
            this.BackColor = BackColor;
            this.ElementBackColor = ElementBackColor;
            this.SideMenuColor = SideMenuColor;
            this.ActiveColor = ActiveColor;
            this.InactiveColor = InactiveColor;
            this.DisabledColor = DisabledColor;
            this.ForeColor = ForeColor;
            this.WireframeColorTL = WireframeColorTL;
            this.WireframeColorTR = WireframeColorTR;
            this.WireframeColorBL = WireframeColorBL;
            this.WireframeColorBR = WireframeColorBR;
            this.WireframeColorOverlay = WireframeColorOverlay;
        }
    }
}
