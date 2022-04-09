using System;
using System.Drawing;
using System.Windows.Forms;

namespace Felisz
{
    class MenüGombokNew : Button
    {
        public MenüGombokNew()
        {
            MouseEnter += MenüGombok_MouseEnter;
            MouseLeave += MenüGombok_MouseLeave;
            Click += MenüGombok_Click;

            this.BackColor = Color.FromArgb(30, 30, 30);
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.Dock = DockStyle.Top;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Microsoft Sans Serif", 12.0f);
            this.ForeColor = Color.FromArgb(109, 109, 109);
            this.Size = new Size(273, 40);

            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(25, 25);
            this.ImageList = imageList;

            this.ImageAlign = ContentAlignment.MiddleLeft;
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.TextImageRelation = TextImageRelation.ImageBeforeText;

            this.Padding = new Padding(15, 0, 0, 0);






        }


        private void MenüGombok_Click(object sender, EventArgs e)
        {



        }

        private void MenüGombok_MouseLeave(object sender, EventArgs e)
        {
            this.Image = (Image)Properties.Resources.ResourceManager.GetObject("ikon_" + this.Text.Trim().Replace(' ', '_'));
        }

        private void MenüGombok_MouseEnter(object sender, EventArgs e)
        {
            this.Image = (Image)Properties.Resources.ResourceManager.GetObject("ikon_" + this.Text.Trim().Replace(' ', '_') + "_sel");
        }
    }
}
