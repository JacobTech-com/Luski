using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Luski.GUI.Controls
{
    public class LuskiTextBox : Control
    {
        bool buttonGlowState = true;
        float blendingFactor = 0;
        Image blendImageLight = null, blendImageDark = null;

        #region Properties
        private BaseBox box = new BaseBox
        {
            BackColor = Luski.GUI.CurrentTheme.Theme.ElementBackColor,
            ForeColor = Color.White,
            BorderStyle = BorderStyle.None
        };

        public override string Text
        {
            get
            {
                return box.Text;
            }
            set
            {
                box.Text = value;
            }
        }

        public new object Tag
        {
            get
            {
                return box.Tag;
            }
            set
            {
                box.Tag = value;
            }
        }

        public int MaxTextLength
        {
            get
            {
                return box.MaxLength;
            }
            set
            {
                box.MaxLength = value;
            }
        }

        public string SelectedText
        {
            get
            {
                return box.SelectedText;
            }
            set
            {
                box.SelectedText = value;
            }
        }

        public string PlaceholderText
        {
            get
            {
                return box.PlaceholderText;
            }
            set
            {
                box.PlaceholderText = value;
            }
        }

        public int SelectionStart
        {
            get
            {
                return box.SelectionStart;
            }
            set
            {
                box.SelectionStart = value;
            }
        }

        public int SelectionLength
        {
            get
            {
                return box.SelectionLength;
            }
            set
            {
                box.SelectionLength = value;
            }
        }

        public bool UseSystemPasswordChar
        {
            get
            {
                return box.UseSystemPasswordChar;
            }
            set
            {
                box.UseSystemPasswordChar = value;
            }
        }

        public char PasswordCharacter
        {
            get
            {
                return box.PasswordChar;
            }
            set
            {
                box.PasswordChar = value;
            }
        }

        public bool Multiline
        {
            get
            {
                return box.Multiline;
            }
            set
            {
                box.Multiline = value;
            }
        }

        public ScrollBars ScrollBars
        {
            get
            {
                return box.ScrollBars;
            }
            set
            {
                box.ScrollBars = value;
            }
        }

        public new void Focus()
        {
            box.Focus();
        }

        public void SelectAll()
        {
            box.SelectAll();
        }

        public void Clear()
        {
            box.Clear();
        }

        public Color themeColor = Luski.GUI.CurrentTheme.Theme.ForeColor;

        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                box.Font = value;
                Invalidate();
            }
        }

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
        #endregion

        #region Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            #region Draw TextBox
            box.Location = new Point(12, 8);
            box.Width = Width - 24;
            box.Height = (Height - 16) > 0 ? (Height - 16) : 0;
            Height = box.Height + 16;
            Graphics g = e.Graphics;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.Clear(Parent.BackColor);

            if (box.Focused)
            {
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
                rc = new Rectangle(0, 0, Width, Height);
                var rec = Luski.GUI.Utils.MakeRectangle(rc.X, rc.Y, rc.Width, rc.Height, 2f);
                g.FillPath(new SolidBrush(Color.Red), rec);
                //e.Graphics.DrawImage(LightBlendImage, rc, 0, 0, LightBlendImage.Width, LightBlendImage.Height, GraphicsUnit.Pixel, ia);

                // Bright middle border
                //rc = new Rectangle(5, 1, Width - 10, Height - 8);
                //e.Graphics.DrawImage(LightBlendImage, rc, 0, 0, LightBlendImage.Width, LightBlendImage.Height, GraphicsUnit.Pixel, ia);

                // Prepare for dark borders
                cm.Matrix33 = 1F - blendingFactor;
                ia.SetColorMatrix(cm);
                // i think im just not updating blendingFactor
                rc = new Rectangle(0, 0, Width, Height);
                rec = Luski.GUI.Utils.MakeRectangle(rc.X, rc.Y, rc.Width, rc.Height, 2f);
                g.FillPath(new SolidBrush(Color.Blue), rec);

                // Dark top & bottom border
                //rc = new Rectangle(4, 2, Width - 8, Height - 10);
                //e.Graphics.DrawImage(DarkBlendImage, rc, 0, 0, DarkBlendImage.Width, DarkBlendImage.Height, GraphicsUnit.Pixel, ia);

                // Dark middle border
                //rc = new Rectangle(5, 1, Width - 10, Height - 8);
                //e.Graphics.DrawImage(DarkBlendImage, rc, 0, 0, DarkBlendImage.Width, DarkBlendImage.Height, GraphicsUnit.Pixel, ia);
                #endregion

                Invalidate();
            }
            #endregion

            #region Draw BG
            var bg = Luski.GUI.Utils.MakeRectangle(1f, 1f, Width - 2, Height - 2, 2f);
            g.FillPath(new SolidBrush(Luski.GUI.CurrentTheme.Theme.ElementBackColor), bg);
            //g.DrawPath(new Pen(box.Focused ? themeColor : Color.FromArgb(60, Color.Black), 0.5f), bg);

           
            #endregion
        }
        #endregion

        #region Events

        private void box_LostFocus(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void box_GotFocus(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\x1')
            {
                ((TextBox)sender).SelectAll();
                e.Handled = true;
            }
        }

        #endregion

        #region BaseBox

        #region BaseBox Events
        public event EventHandler AcceptsTabChanged
        {
            add
            {
                box.AcceptsTabChanged += value;
            }
            remove
            {
                box.AcceptsTabChanged -= value;
            }
        }

        public new event EventHandler AutoSizeChanged
        {
            add
            {
                box.AutoSizeChanged += value;
            }
            remove
            {
                box.AutoSizeChanged -= value;
            }
        }

        public new event EventHandler BackgroundImageChanged
        {
            add
            {
                box.BackgroundImageChanged += value;
            }
            remove
            {
                box.BackgroundImageChanged -= value;
            }
        }

        public new event EventHandler BackgroundImageLayoutChanged
        {
            add
            {
                box.BackgroundImageLayoutChanged += value;
            }
            remove
            {
                box.BackgroundImageLayoutChanged -= value;
            }
        }

        public new event EventHandler BindingContextChanged
        {
            add
            {
                box.BindingContextChanged += value;
            }
            remove
            {
                box.BindingContextChanged -= value;
            }
        }

        public event EventHandler BorderStyleChanged
        {
            add
            {
                box.BorderStyleChanged += value;
            }
            remove
            {
                box.BorderStyleChanged -= value;
            }
        }

        public new event EventHandler CausesValidationChanged
        {
            add
            {
                box.CausesValidationChanged += value;
            }
            remove
            {
                box.CausesValidationChanged -= value;
            }
        }

        public new event UICuesEventHandler ChangeUICues
        {
            add
            {
                box.ChangeUICues += value;
            }
            remove
            {
                box.ChangeUICues -= value;
            }
        }

        public new event EventHandler Click
        {
            add
            {
                box.Click += value;
            }
            remove
            {
                box.Click -= value;
            }
        }

        public new event EventHandler ClientSizeChanged
        {
            add
            {
                box.ClientSizeChanged += value;
            }
            remove
            {
                box.ClientSizeChanged -= value;
            }
        }

        public new event EventHandler ContextMenuChanged
        {
            add
            {
                box.ContextMenuChanged += value;
            }
            remove
            {
                box.ContextMenuChanged -= value;
            }
        }

        public new event EventHandler ContextMenuStripChanged
        {
            add
            {
                box.ContextMenuStripChanged += value;
            }
            remove
            {
                box.ContextMenuStripChanged -= value;
            }
        }

        public new event ControlEventHandler ControlAdded
        {
            add
            {
                box.ControlAdded += value;
            }
            remove
            {
                box.ControlAdded -= value;
            }
        }

        public new event ControlEventHandler ControlRemoved
        {
            add
            {
                box.ControlRemoved += value;
            }
            remove
            {
                box.ControlRemoved -= value;
            }
        }

        public new event EventHandler CursorChanged
        {
            add
            {
                box.CursorChanged += value;
            }
            remove
            {
                box.CursorChanged -= value;
            }
        }

        public new event EventHandler Disposed
        {
            add
            {
                box.Disposed += value;
            }
            remove
            {
                box.Disposed -= value;
            }
        }

        public new event EventHandler DockChanged
        {
            add
            {
                box.DockChanged += value;
            }
            remove
            {
                box.DockChanged -= value;
            }
        }

        public new event EventHandler DoubleClick
        {
            add
            {
                box.DoubleClick += value;
            }
            remove
            {
                box.DoubleClick -= value;
            }
        }

        public new event DragEventHandler DragDrop
        {
            add
            {
                box.DragDrop += value;
            }
            remove
            {
                box.DragDrop -= value;
            }
        }

        public new event DragEventHandler DragEnter
        {
            add
            {
                box.DragEnter += value;
            }
            remove
            {
                box.DragEnter -= value;
            }
        }

        public new event EventHandler DragLeave
        {
            add
            {
                box.DragLeave += value;
            }
            remove
            {
                box.DragLeave -= value;
            }
        }

        public new event DragEventHandler DragOver
        {
            add
            {
                box.DragOver += value;
            }
            remove
            {
                box.DragOver -= value;
            }
        }

        public new event EventHandler EnabledChanged
        {
            add
            {
                box.EnabledChanged += value;
            }
            remove
            {
                box.EnabledChanged -= value;
            }
        }

        public new event EventHandler Enter
        {
            add
            {
                box.Enter += value;
            }
            remove
            {
                box.Enter -= value;
            }
        }

        public new event EventHandler FontChanged
        {
            add
            {
                box.FontChanged += value;
            }
            remove
            {
                box.FontChanged -= value;
            }
        }

        public new event EventHandler ForeColorChanged
        {
            add
            {
                box.ForeColorChanged += value;
            }
            remove
            {
                box.ForeColorChanged -= value;
            }
        }

        public new event GiveFeedbackEventHandler GiveFeedback
        {
            add
            {
                box.GiveFeedback += value;
            }
            remove
            {
                box.GiveFeedback -= value;
            }
        }

        public new event EventHandler GotFocus
        {
            add
            {
                box.GotFocus += value;
            }
            remove
            {
                box.GotFocus -= value;
            }
        }

        public new event EventHandler HandleCreated
        {
            add
            {
                box.HandleCreated += value;
            }
            remove
            {
                box.HandleCreated -= value;
            }
        }

        public new event EventHandler HandleDestroyed
        {
            add
            {
                box.HandleDestroyed += value;
            }
            remove
            {
                box.HandleDestroyed -= value;
            }
        }

        public new event HelpEventHandler HelpRequested
        {
            add
            {
                box.HelpRequested += value;
            }
            remove
            {
                box.HelpRequested -= value;
            }
        }

        public event EventHandler HideSelectionChanged
        {
            add
            {
                box.HideSelectionChanged += value;
            }
            remove
            {
                box.HideSelectionChanged -= value;
            }
        }

        public new event EventHandler ImeModeChanged
        {
            add
            {
                box.ImeModeChanged += value;
            }
            remove
            {
                box.ImeModeChanged -= value;
            }
        }

        public new event InvalidateEventHandler Invalidated
        {
            add
            {
                box.Invalidated += value;
            }
            remove
            {
                box.Invalidated -= value;
            }
        }

        public new event KeyEventHandler KeyDown
        {
            add
            {
                box.KeyDown += value;
            }
            remove
            {
                box.KeyDown -= value;
            }
        }

        public new event KeyPressEventHandler KeyPress
        {
            add
            {
                box.KeyPress += value;
            }
            remove
            {
                box.KeyPress -= value;
            }
        }

        public new event KeyEventHandler KeyUp
        {
            add
            {
                box.KeyUp += value;
            }
            remove
            {
                box.KeyUp -= value;
            }
        }

        public new event LayoutEventHandler Layout
        {
            add
            {
                box.Layout += value;
            }
            remove
            {
                box.Layout -= value;
            }
        }

        public new event EventHandler Leave
        {
            add
            {
                box.Leave += value;
            }
            remove
            {
                box.Leave -= value;
            }
        }

        public new event EventHandler LocationChanged
        {
            add
            {
                box.LocationChanged += value;
            }
            remove
            {
                box.LocationChanged -= value;
            }
        }

        public new event EventHandler LostFocus
        {
            add
            {
                box.LostFocus += value;
            }
            remove
            {
                box.LostFocus -= value;
            }
        }

        public new event EventHandler MarginChanged
        {
            add
            {
                box.MarginChanged += value;
            }
            remove
            {
                box.MarginChanged -= value;
            }
        }

        public event EventHandler ModifiedChanged
        {
            add
            {
                box.ModifiedChanged += value;
            }
            remove
            {
                box.ModifiedChanged -= value;
            }
        }

        public new event EventHandler MouseCaptureChanged
        {
            add
            {
                box.MouseCaptureChanged += value;
            }
            remove
            {
                box.MouseCaptureChanged -= value;
            }
        }

        public new event MouseEventHandler MouseClick
        {
            add
            {
                box.MouseClick += value;
            }
            remove
            {
                box.MouseClick -= value;
            }
        }

        public new event MouseEventHandler MouseDoubleClick
        {
            add
            {
                box.MouseDoubleClick += value;
            }
            remove
            {
                box.MouseDoubleClick -= value;
            }
        }

        public new event MouseEventHandler MouseDown
        {
            add
            {
                box.MouseDown += value;
            }
            remove
            {
                box.MouseDown -= value;
            }
        }

        public new event EventHandler MouseEnter
        {
            add
            {
                box.MouseEnter += value;
            }
            remove
            {
                box.MouseEnter -= value;
            }
        }

        public new event EventHandler MouseHover
        {
            add
            {
                box.MouseHover += value;
            }
            remove
            {
                box.MouseHover -= value;
            }
        }

        public new event EventHandler MouseLeave
        {
            add
            {
                box.MouseLeave += value;
            }
            remove
            {
                box.MouseLeave -= value;
            }
        }

        public new event MouseEventHandler MouseMove
        {
            add
            {
                box.MouseMove += value;
            }
            remove
            {
                box.MouseMove -= value;
            }
        }

        public new event MouseEventHandler MouseUp
        {
            add
            {
                box.MouseUp += value;
            }
            remove
            {
                box.MouseUp -= value;
            }
        }

        public new event MouseEventHandler MouseWheel
        {
            add
            {
                box.MouseWheel += value;
            }
            remove
            {
                box.MouseWheel -= value;
            }
        }

        public new event EventHandler Move
        {
            add
            {
                box.Move += value;
            }
            remove
            {
                box.Move -= value;
            }
        }

        public event EventHandler MultilineChanged
        {
            add
            {
                box.MultilineChanged += value;
            }
            remove
            {
                box.MultilineChanged -= value;
            }
        }

        public new event EventHandler PaddingChanged
        {
            add
            {
                box.PaddingChanged += value;
            }
            remove
            {
                box.PaddingChanged -= value;
            }
        }

        public new event PaintEventHandler Paint
        {
            add
            {
                box.Paint += value;
            }
            remove
            {
                box.Paint -= value;
            }
        }

        public new event EventHandler ParentChanged
        {
            add
            {
                box.ParentChanged += value;
            }
            remove
            {
                box.ParentChanged -= value;
            }
        }

        public new event PreviewKeyDownEventHandler PreviewKeyDown
        {
            add
            {
                box.PreviewKeyDown += value;
            }
            remove
            {
                box.PreviewKeyDown -= value;
            }
        }

        public new event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp
        {
            add
            {
                box.QueryAccessibilityHelp += value;
            }
            remove
            {
                box.QueryAccessibilityHelp -= value;
            }
        }

        public new event QueryContinueDragEventHandler QueryContinueDrag
        {
            add
            {
                box.QueryContinueDrag += value;
            }
            remove
            {
                box.QueryContinueDrag -= value;
            }
        }

        public event EventHandler ReadOnlyChanged
        {
            add
            {
                box.ReadOnlyChanged += value;
            }
            remove
            {
                box.ReadOnlyChanged -= value;
            }
        }

        public new event EventHandler RegionChanged
        {
            add
            {
                box.RegionChanged += value;
            }
            remove
            {
                box.RegionChanged -= value;
            }
        }

        public new event EventHandler Resize
        {
            add
            {
                box.Resize += value;
            }
            remove
            {
                box.Resize -= value;
            }
        }

        public new event EventHandler RightToLeftChanged
        {
            add
            {
                box.RightToLeftChanged += value;
            }
            remove
            {
                box.RightToLeftChanged -= value;
            }
        }

        public new event EventHandler SizeChanged
        {
            add
            {
                box.SizeChanged += value;
            }
            remove
            {
                box.SizeChanged -= value;
            }
        }

        public new event EventHandler StyleChanged
        {
            add
            {
                box.StyleChanged += value;
            }
            remove
            {
                box.StyleChanged -= value;
            }
        }

        public new event EventHandler SystemColorsChanged
        {
            add
            {
                box.SystemColorsChanged += value;
            }
            remove
            {
                box.SystemColorsChanged -= value;
            }
        }

        public new event EventHandler TabIndexChanged
        {
            add
            {
                box.TabIndexChanged += value;
            }
            remove
            {
                box.TabIndexChanged -= value;
            }
        }

        public new event EventHandler TabStopChanged
        {
            add
            {
                box.TabStopChanged += value;
            }
            remove
            {
                box.TabStopChanged -= value;
            }
        }

        public event EventHandler TextAlignChanged
        {
            add
            {
                box.TextAlignChanged += value;
            }
            remove
            {
                box.TextAlignChanged -= value;
            }
        }

        public new event EventHandler TextChanged
        {
            add
            {
                box.TextChanged += value;
            }
            remove
            {
                box.TextChanged -= value;
            }
        }

        public new event EventHandler Validated
        {
            add
            {
                box.Validated += value;
            }
            remove
            {
                box.Validated -= value;
            }
        }

        public new event CancelEventHandler Validating
        {
            add
            {
                box.Validating += value;
            }
            remove
            {
                box.Validating -= value;
            }
        }

        public new event EventHandler VisibleChanged
        {
            add
            {
                box.VisibleChanged += value;
            }
            remove
            {
                box.VisibleChanged -= value;
            }
        }
        #endregion

        private class BaseBox : TextBox
        {
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);
            private const int EM_SETCUEBANNER = 0x1501;
            private const char EmptyChar = (char)0, VisualStylePasswordChar = '\u25CF', NonVisualStylePasswordChar = '\u002A';
            private string p = "";

            public string PlaceholderText
            {
                get
                {
                    return p;
                }
                set
                {
                    p = value;
                    SendMessage(Handle, EM_SETCUEBANNER, (int)IntPtr.Zero, PlaceholderText);
                }
            }

            private char pwc = EmptyChar;
            public new char PasswordChar
            {
                get
                {
                    return pwc;
                }
                set
                {
                    pwc = value;
                    SetBasePasswordChar();
                }
            }

            public new void SelectAll()
            {
                BeginInvoke((MethodInvoker) delegate()
                {
                    base.Focus();
                    base.SelectAll();
                });
            }

            public new void Focus()
            {
                BeginInvoke((MethodInvoker) delegate()
                {
                    base.Focus();
                });
            }

            private char sysPwc = EmptyChar;
            public new bool UseSystemPasswordChar
            {
                get
                {
                    return sysPwc != EmptyChar;
                }
                set
                {
                    if (value) sysPwc = Application.RenderWithVisualStyles ? VisualStylePasswordChar : NonVisualStylePasswordChar;
                    else sysPwc = EmptyChar;
                    SetBasePasswordChar();
                }
            }

            private void SetBasePasswordChar()
            {
                base.PasswordChar = UseSystemPasswordChar ? sysPwc : pwc;
            }

            public BaseBox()
            {
                
            }
        }
        #endregion

        public LuskiTextBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            Font = new Font("nintendo_udsg-r_std_003", 9.7f);
            if (!Controls.Contains(box) && !DesignMode) Controls.Add(box);
            box.KeyPress += box_KeyPress;
            box.GotFocus += box_GotFocus;
            box.LostFocus += box_LostFocus;
            box.TabStop = true;
            this.TabStop = false;
        }
    }
}
