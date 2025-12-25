using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ShoppingSystem.GUI.Auth
{
    public class RoundedForm : Form
    {
        private int _borderRadius = 30;

        [Category("Appearance")]
        public int BorderRadius
        {
            get { return _borderRadius; }
            set { _borderRadius = value; this.Invalidate(); }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
        );

        public RoundedForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            SetRegion();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRegion();
        }

        private void SetRegion()
        {
            // Chỉ tạo vùng bo tròn khi Form có kích thước hợp lệ và không bị Minimize
            if (this.Width > 0 && this.Height > 0 && this.WindowState != FormWindowState.Minimized)
            {
                this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, _borderRadius, _borderRadius));
            }
        }
    }
}