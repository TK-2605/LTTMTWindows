using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace ShoppingSystem.GUI.Auth
{
    public class RoundedPanel : Panel
    {
        private int _borderRadius = 15;
        private Color _borderColor = Color.LightGray;
        private int _borderSize = 1; // Độ dày viền mặc định

        [Category("Appearance")]
        public int BorderRadius
        {
            get { return _borderRadius; }
            set { _borderRadius = value; this.Invalidate(); }
        }

        [Category("Appearance")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; this.Invalidate(); }
        }

        public RoundedPanel()
        {
            this.DoubleBuffered = true; // Giảm giật hình
            this.BackColor = Color.White;
            this.Padding = new Padding(10); // Tạo khoảng cách nội dung
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            // Vẽ nền và viền
            using (var path = GetRoundedPath(rect, _borderRadius))
            using (var pen = new Pen(_borderColor, _borderSize))
            using (var brush = new SolidBrush(this.BackColor))
            {
                // Fill nền (quan trọng nếu Panel cha có màu khác)
                e.Graphics.FillPath(brush, path);

                // Vẽ viền
                e.Graphics.DrawPath(pen, path);
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float d = radius * 2.0F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90); // Top left
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90); // Top right
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90); // Bottom right
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90); // Bottom left
            path.CloseFigure();
            return path;
        }
    }
}