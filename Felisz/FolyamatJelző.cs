using System.Drawing;
using System.Windows.Forms;

namespace Felisz
{
    class FolyamatJelző : ProgressBar
    {
        public FolyamatJelző()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);

            var brush = new SolidBrush(Color.FromArgb(166, 66, 51));
            e.Graphics.FillRectangle(brush, 0, 0, rec.Width, 3);
        }
    }

}
