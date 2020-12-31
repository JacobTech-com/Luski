using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Luski.GUI.Controls
{
    public class LuskiTabControl : TabControl
    {
        private System.ComponentModel.Container components = null;
        private SubClass scUpDown = null;
        private bool hasUpDown;
        private ImageList leftRightImages = null;
        private const int MarginCount = 5;
        private Color bgColor = Color.Empty;
        private Color shColor = Color.Empty;

        public LuskiTabControl()
        {
            bgColor = Color.FromArgb(45, 45, 45);
            
            InitializeComponent();
            
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            hasUpDown = false;

            ControlAdded += new ControlEventHandler(LuskiTabControl_ControlAdded);
            ControlRemoved += new ControlEventHandler(LuskiTabControl_ControlRemoved);
            SelectedIndexChanged += new EventHandler(LuskiTabControl_SelectedIndexChanged);

            Refresh();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            FindUpDown();
            UpdateUpDown();

            base.OnSizeChanged(e);
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing) if (components != null) components.Dispose();
            base.Dispose(disposing);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawControl(e.Graphics);
        }

        internal void DrawControl(Graphics g)
        {
            if (!Visible) return;

            Rectangle TabControlArea = ClientRectangle;
            Rectangle TabArea = DisplayRectangle;
            
            Brush br = new SolidBrush(bgColor);
            g.FillRectangle(br, TabControlArea);
            br.Dispose();
            
            int Delta = SystemInformation.Border3DSize.Width;

            Pen border = new Pen(shColor);
            TabArea.Inflate(Delta, Delta);
            g.DrawRectangle(border, TabArea);
            border.Dispose();

            Region reg = g.Clip;
            Rectangle rec;

            int w = TabArea.Width + MarginCount;
            if (hasUpDown)
            {
                if (Win32.IsWindowVisible(scUpDown.Handle))
                {
                    Rectangle rupdown = new Rectangle();
                    Win32.GetWindowRect(scUpDown.Handle, ref rupdown);
                    Rectangle rupdown2 = RectangleToClient(rupdown);

                    w = rupdown2.X;
                }
            }

            rec = new Rectangle(TabArea.Left, TabControlArea.Top, w - MarginCount, TabControlArea.Height);

            g.SetClip(rec);

            for (int i = 0; i < TabCount; i++) DrawTab(g, TabPages[i], i);

            g.Clip = reg;

            if (SelectedTab != null)
            {
                TabPage tabPage = SelectedTab;
                tabPage.BackColor = Color.FromArgb(45, 45, 45);

                Color color = tabPage.BackColor;
                border = new Pen(color);

                TabArea.Offset(1, 1);
                TabArea.Width -= 2;
                TabArea.Height -= 2;

                g.DrawRectangle(border, TabArea);
                TabArea.Width -= 1;
                TabArea.Height -= 1;
                g.DrawRectangle(border, TabArea);

                border.Dispose();
            }
        }

        private const int WM_SETREDRAW = 11;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

        private void UpdateTabColor()
        {
            foreach (TabPage tpCheck in TabPages)
            {
                tpCheck.BackColor = Color.FromArgb(45, 45, 45);
                tpCheck.ForeColor = Color.Gray;
            }

            if (SelectedTab != null)
            {
                SelectedTab.BackColor = Color.FromArgb(50, 50, 50);
                SelectedTab.ForeColor = Color.White;
            }

            Refresh();
        }

        internal void DrawTab(Graphics g, TabPage tabPage, int nIndex)
        {
            Rectangle recBounds = GetTabRect(nIndex);
            RectangleF tabTextArea = GetTabRect(nIndex);

            bool s = (SelectedIndex == nIndex);

            Point[] pt = new Point[7];
            if (Alignment == TabAlignment.Top)
            {
                pt[0] = new Point(recBounds.Left, recBounds.Bottom);
                pt[1] = new Point(recBounds.Left, recBounds.Top + 3);
                pt[2] = new Point(recBounds.Left + 3, recBounds.Top);
                pt[3] = new Point(recBounds.Right - 3, recBounds.Top);
                pt[4] = new Point(recBounds.Right, recBounds.Top + 3);
                pt[5] = new Point(recBounds.Right, recBounds.Bottom);
                pt[6] = new Point(recBounds.Left, recBounds.Bottom);
            }
            else
            {
                pt[0] = new Point(recBounds.Left, recBounds.Top);
                pt[1] = new Point(recBounds.Right, recBounds.Top);
                pt[2] = new Point(recBounds.Right, recBounds.Bottom - 3);
                pt[3] = new Point(recBounds.Right - 3, recBounds.Bottom);
                pt[4] = new Point(recBounds.Left + 3, recBounds.Bottom);
                pt[5] = new Point(recBounds.Left, recBounds.Bottom - 3);
                pt[6] = new Point(recBounds.Left, recBounds.Top);
            }
            
            Brush br = new SolidBrush(Color.FromArgb(61, 61, 61));
            g.FillPolygon(br, pt);
            br.Dispose();
            g.DrawPolygon(new Pen(Color.FromArgb(40, 40, 40)), pt);

            if (s)
            {
                Pen pen = new Pen(tabPage.BackColor);

                switch (Alignment)
                {
                    case TabAlignment.Top:
                        g.DrawLine(pen, recBounds.Left + 1, recBounds.Bottom, recBounds.Right - 1, recBounds.Bottom);
                        g.DrawLine(pen, recBounds.Left + 1, recBounds.Bottom + 1, recBounds.Right - 1, recBounds.Bottom + 1);
                        break;

                    case TabAlignment.Bottom:
                        g.DrawLine(pen, recBounds.Left + 1, recBounds.Top, recBounds.Right - 1, recBounds.Top);
                        g.DrawLine(pen, recBounds.Left + 1, recBounds.Top - 1, recBounds.Right - 1, recBounds.Top - 1);
                        g.DrawLine(pen, recBounds.Left + 1, recBounds.Top - 2, recBounds.Right - 1, recBounds.Top - 2);
                        break;
                }

                pen.Dispose();
            }

            if ((tabPage.ImageIndex >= 0) && (ImageList != null) && (ImageList.Images[tabPage.ImageIndex] != null))
            {
                int lm = 8, rm = 2;

                Image img = ImageList.Images[tabPage.ImageIndex];

                Rectangle rimage = new Rectangle(recBounds.X + lm, recBounds.Y + 1, img.Width, img.Height);

                float a = (lm + img.Width + rm);

                rimage.Y += (recBounds.Height - img.Height) / 2;
                tabTextArea.X += a;
                tabTextArea.Width -= a;
                
                g.DrawImage(img, rimage);
            }

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            br = new SolidBrush(tabPage.ForeColor);

            g.DrawString(tabPage.Text, Font, br, tabTextArea, stringFormat);
        }

        internal void DrawIcons(Graphics g)
        {
            if ((leftRightImages == null) || (leftRightImages.Images.Count != 4)) return;
            
            Rectangle TabControlArea = ClientRectangle;

            Rectangle r = new Rectangle();
            Win32.GetClientRect(scUpDown.Handle, ref r);

            Brush br = new SolidBrush(bgColor);
            g.FillRectangle(br, r);
            br.Dispose();

            Pen border = new Pen(shColor);
            Rectangle b = r;
            b.Inflate(-1, -1);
            g.DrawRectangle(border, b);
            border.Dispose();

            int m = (r.Width / 2), t = (r.Height - 16) / 2, l = (m - 16) / 2;

            Rectangle r1 = new Rectangle(l, t, 16, 16), r2 = new Rectangle(m + l, t, 16, 16);
            Image img = leftRightImages.Images[1];

            if (img != null)
            {
                if (TabCount > 0)
                {
                    Rectangle r3 = GetTabRect(0);
                    if (r3.Left < TabControlArea.Left) g.DrawImage(img, r1);
                    else
                    {
                        img = leftRightImages.Images[3];
                        if (img != null) g.DrawImage(img, r1);
                    }
                }
            }

            img = leftRightImages.Images[0];
            if (img != null)
            {
                if (TabCount > 0)
                {
                    Rectangle r3 = GetTabRect(TabCount - 1);
                    if (r3.Right > (TabControlArea.Width - r.Width)) g.DrawImage(img, r2);
                    else
                    {
                        img = leftRightImages.Images[2];
                        if (img != null) g.DrawImage(img, r2);
                    }
                }
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            FindUpDown();
        }

        private void LuskiTabControl_ControlAdded(object sender, ControlEventArgs e)
        {
            FindUpDown();
            UpdateUpDown();
            UpdateTabColor();
        }

        private void LuskiTabControl_ControlRemoved(object sender, ControlEventArgs e)
        {
            FindUpDown();
            UpdateUpDown();
        }

        private void LuskiTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUpDown();
            Invalidate();
        }

        private void FindUpDown()
        {
            bool sel = false;
            
            IntPtr pWnd = Win32.GetWindow(Handle, Win32.GW_CHILD);

            while (pWnd != IntPtr.Zero)
            {
                char[] className = new char[33];
                int length = Win32.GetClassName(pWnd, className, 32);
                string s = new string(className, 0, length);

                if (s == "msctls_updown32")
                {
                    sel = true;

                    if (!hasUpDown)
                    {
                        scUpDown = new SubClass(pWnd, true);
                        scUpDown.SubClassedWndProc += new SubClass.SubClassWndProcEventHandler(scUpDown_SubClassedWndProc);

                        hasUpDown = true;
                    }
                    break;
                }

                pWnd = Win32.GetWindow(pWnd, Win32.GW_HWNDNEXT);
            }

            if ((!sel) && (hasUpDown)) hasUpDown = false;
        }

        private void UpdateUpDown()
        {
            if (hasUpDown)
            {
                if (Win32.IsWindowVisible(scUpDown.Handle))
                {
                    Rectangle rect = new Rectangle();

                    Win32.GetClientRect(scUpDown.Handle, ref rect);
                    Win32.InvalidateRect(scUpDown.Handle, ref rect, true);
                }
            }
        }

        #region scUpDown_SubClassedWndProc Event Handler

        private int scUpDown_SubClassedWndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case Win32.WM_PAINT:
                    {
                        IntPtr h = Win32.GetWindowDC(scUpDown.Handle);
                        Graphics g = Graphics.FromHdc(h);

                        DrawIcons(g);

                        g.Dispose();
                        Win32.ReleaseDC(scUpDown.Handle, h);
                        m.Result = IntPtr.Zero;
                        Rectangle r = new Rectangle();

                        Win32.GetClientRect(scUpDown.Handle, ref r);
                        Win32.ValidateRect(scUpDown.Handle, ref r);
                    }
                    return 1;
            }

            return 0;
        }
        #endregion

        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            Selected += new System.Windows.Forms.TabControlEventHandler(LuskiTabControl_Selected);
            ResumeLayout(false);

        }


        #endregion

        #region Properties

        [Editor(typeof(TabpageExCollectionEditor), typeof(UITypeEditor))]
        public new TabPageCollection TabPages
        {
            get
            {
                return base.TabPages;
            }
        }

        new public TabAlignment Alignment
        {
            get
            {
                return base.Alignment;
            }
            set
            {
                TabAlignment ta = value;
                if ((ta != TabAlignment.Top) && (ta != TabAlignment.Bottom)) ta = TabAlignment.Top;

                base.Alignment = ta;
            }
        }

        [Browsable(false)]
        new public bool Multiline
        {
            get
            {
                return base.Multiline;
            }
            set
            {
                base.Multiline = false;
            }
        }

        [Browsable(true)]
        new public Color BackColor
        {
            get
            {
                return bgColor;
            }
            set
            {
                bgColor = value;
                Invalidate();
            }
        }

        #endregion

        #region TabpageExCollectionEditor

        internal class TabpageExCollectionEditor : CollectionEditor
        {
            public TabpageExCollectionEditor(System.Type type) : base(type)
            {
            }

            protected override Type CreateCollectionItemType()
            {
                return typeof(TabPage);
            }
        }

        #endregion

        private void LuskiTabControl_Selected(object sender, TabControlEventArgs e)
        {
            foreach (TabPage tpCheck in TabPages)
            {
                tpCheck.BackColor = Color.FromArgb(45, 45, 45);
                tpCheck.ForeColor = Color.Gray;
            }

            if (SelectedTab != null)
            {
                SelectedTab.BackColor = Color.FromArgb(50, 50, 50);
                SelectedTab.ForeColor = Color.White;
            }
        }
    }
}