using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ClassPors.Tables
{
    /// <summary>
    /// دکمه‌ی گرد و تخت مناسب لمس:
    /// گوشه‌ها نرم (anti-aliased)، اندازه‌ی گردی نسبت به اندازه‌ی دکمه،
    /// متن خودکار با اندازه‌ی دکمه بزرگ/کوچک می‌شود و هنگام لمس رنگ تیره‌تر می‌شود.
    /// </summary>
    class RoundedButton : Button
    {
        bool pressed;

        public RoundedButton()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw, true);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            UseVisualStyleBackColor = false;
        }

        static GraphicsPath GetRoundPath(Rectangle r, int radius)
        {
            int d = Math.Max(2, Math.Min(radius * 2, Math.Min(r.Width, r.Height)));
            GraphicsPath path = new GraphicsPath();
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        static Color Darken(Color c, float factor)
        {
            return Color.FromArgb(c.A, (int)(c.R * factor), (int)(c.G * factor), (int)(c.B * factor));
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            pressed = true;
            Invalidate();
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            pressed = false;
            Invalidate();
            base.OnMouseUp(mevent);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            pressed = false;
            Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            Color back = Parent != null ? Parent.BackColor : SystemColors.Control;
            g.Clear(back);

            // فاصله‌ی کوچک تا لبه‌ی آنتی‌الیاس بریده نشود
            Rectangle rect = new Rectangle(1, 1, Width - 3, Height - 3);
            if (rect.Width < 4 || rect.Height < 4) return;

            int radius = Math.Max(10, Math.Min(rect.Width, rect.Height) / 6);
            Color fill = pressed ? Darken(BackColor, 0.72f) : BackColor;

            // سایه‌ی ملایم (در حالت فشرده حذف می‌شود تا حس فشردن بدهد)
            if (!pressed)
            {
                Rectangle shadowRect = new Rectangle(rect.X, rect.Y + 4, rect.Width, rect.Height - 4);
                using (GraphicsPath sp = GetRoundPath(shadowRect, radius))
                using (SolidBrush sb = new SolidBrush(Color.FromArgb(60, 0, 0, 0)))
                    g.FillPath(sb, sp);
                rect.Height -= 4;
            }
            else
            {
                rect.Y += 3;
                rect.Height -= 4;
            }

            using (GraphicsPath path = GetRoundPath(rect, radius))
            using (SolidBrush brush = new SolidBrush(fill))
                g.FillPath(brush, path);

            // متن؛ اندازه‌ی فونت از روی ارتفاع دکمه محاسبه و در صورت نیاز کم می‌شود
            using (StringFormat sf = new StringFormat(StringFormat.GenericTypographic))
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                if (RightToLeft == RightToLeft.Yes)
                    sf.FormatFlags |= StringFormatFlags.DirectionRightToLeft;

                float maxW = rect.Width * 0.88f;
                float maxH = rect.Height * 0.62f;
                float size = Math.Max(10f, rect.Height * 0.38f);
                Font font = null;
                try
                {
                    while (true)
                    {
                        if (font != null) font.Dispose();
                        font = new Font(Font.FontFamily, size, Font.Style, GraphicsUnit.Pixel);
                        SizeF s = g.MeasureString(Text, font, PointF.Empty, sf);
                        if ((s.Width <= maxW && s.Height <= maxH) || size <= 10f) break;
                        size -= 1f;
                    }
                    using (SolidBrush tb = new SolidBrush(ForeColor))
                        g.DrawString(Text, font, tb, new RectangleF(rect.X, rect.Y, rect.Width, rect.Height), sf);
                }
                finally
                {
                    if (font != null) font.Dispose();
                }
            }
        }
    }
}