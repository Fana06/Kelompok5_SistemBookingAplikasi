using System.Drawing;
using System.Windows.Forms;

namespace BookingKontrolPasien.Helpers
{
    internal static class BindingNavigatorIconHelper
    {
        public static void ApplyTo(Control root)
        {
            if (root == null)
                return;

            ApplyRecursive(root);
        }

        private static void ApplyRecursive(Control control)
        {
            BindingNavigator navigator = control as BindingNavigator;

            if (navigator != null)
                ApplyToNavigator(navigator);

            foreach (Control child in control.Controls)
                ApplyRecursive(child);
        }

        private static void ApplyToNavigator(BindingNavigator navigator)
        {
            foreach (ToolStripItem item in navigator.Items)
            {
                ToolStripButton button = item as ToolStripButton;

                if (button == null)
                    continue;

                string action = (button.Text ?? string.Empty).ToLowerInvariant();
                Bitmap icon = null;

                if (action.Contains("move first"))
                    icon = CreateMoveIcon(first: true, previous: true);
                else if (action.Contains("move previous"))
                    icon = CreateMoveIcon(first: false, previous: true);
                else if (action.Contains("move next"))
                    icon = CreateMoveIcon(first: false, previous: false);
                else if (action.Contains("move last"))
                    icon = CreateMoveIcon(first: true, previous: false);
                else if (action.Contains("add new"))
                    icon = CreateSymbolIcon("+");
                else if (action.Contains("delete"))
                    icon = CreateSymbolIcon("x");

                if (icon == null)
                    continue;

                button.Image = icon;
                button.DisplayStyle = ToolStripItemDisplayStyle.Image;
                button.ImageTransparentColor = Color.Transparent;
            }
        }

        private static Bitmap CreateMoveIcon(bool first, bool previous)
        {
            Bitmap bitmap = new Bitmap(16, 16);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            using (Brush brush = new SolidBrush(Color.FromArgb(65, 65, 65)))
            using (Pen pen = new Pen(Color.FromArgb(65, 65, 65), 2))
            {
                graphics.Clear(Color.Transparent);
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                if (previous)
                {
                    if (first)
                        graphics.DrawLine(pen, 3, 4, 3, 12);

                    Point[] triangle =
                    {
                        new Point(first ? 12 : 11, 3),
                        new Point(first ? 6 : 5, 8),
                        new Point(first ? 12 : 11, 13)
                    };

                    graphics.FillPolygon(brush, triangle);
                }
                else
                {
                    if (first)
                        graphics.DrawLine(pen, 13, 4, 13, 12);

                    Point[] triangle =
                    {
                        new Point(first ? 4 : 5, 3),
                        new Point(first ? 10 : 11, 8),
                        new Point(first ? 4 : 5, 13)
                    };

                    graphics.FillPolygon(brush, triangle);
                }
            }

            return bitmap;
        }

        private static Bitmap CreateSymbolIcon(string symbol)
        {
            Bitmap bitmap = new Bitmap(16, 16);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            using (Font font = new Font("Segoe UI", 10F, FontStyle.Bold))
            using (Brush brush = new SolidBrush(Color.FromArgb(65, 65, 65)))
            using (StringFormat format = new StringFormat())
            {
                graphics.Clear(Color.Transparent);
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                graphics.DrawString(symbol, font, brush, new RectangleF(0, -1, 16, 16), format);
            }

            return bitmap;
        }
    }
}