using System;
using System.Drawing;
using System.Windows.Forms;

namespace Felisz
{
    public partial class formGlobalAdmin : Form
    {
        public formGlobalAdmin()
        {
            InitializeComponent();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(1, 109, 180);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(1, 109, 180);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(1, 109, 180);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(1, 109, 180);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(1, 109, 180);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
        }

        private void lbRSSLink_Click(object sender, EventArgs e)
        {

        }

        private void formGlobalAdmin_Load(object sender, EventArgs e)
        {
            tbMTLink.Text = Properties.Settings.Default.MTUrl;
            tbRSSLink.Text = Properties.Settings.Default.RSSUrl;
            tbDataSource.Text = Properties.Settings.Default.felisz_db_ConnectionString;


        }

        private void btRSSLink_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RSSUrl = tbRSSLink.Text;
            Properties.Settings.Default.Save();

        }

        private void btMTLink_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MTUrl = tbMTLink.Text;
            Properties.Settings.Default.Save();
        }

        private void btMTFrissítése_Click(object sender, EventArgs e)
        {

            tbDataSource.Enabled = false;
            tbMTLink.Enabled = false;
            btMTFrissítése.Enabled = false;

            if (MunkaTörvénykönyve.MTFrissítése())
            {
                MessageBox.Show("MT frissítése sikeres!", "Info");
            }
            else
            {
                MessageBox.Show("Hiba az MT frissítése közben!", "Hiba");
            }
            tbDataSource.Enabled = true;
            tbMTLink.Enabled = true;
            btMTFrissítése.Enabled = true;
        }

        private void btDataSource_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.felisz_db_ConnectionString = tbDataSource.Text;
            Properties.Settings.Default.Save();
        }

        private void pbFormClose_MouseEnter(object sender, EventArgs e)
        {
            pbFormClose.BackColor = Color.Gray;
        }

        private void pbFormClose_MouseLeave(object sender, EventArgs e)
        {
            pbFormClose.BackColor = Color.Transparent;
        }

        private void pbFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
