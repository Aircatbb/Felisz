using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Felisz.Formok
{
    public partial class formMentésDialógus : Form
    {
        public static string mód = "";

        public static void MentésMódVálasztás()
        {
            Form formMD = new formMentésDialógus();
            if (formMunkavállalóVálasztás.mód == "M") formMD.Text = "Módosítások mentése";
            if (formMunkavállalóVálasztás.mód == "N") formMD.Text = "Mentés";
            DialogResult diagRes= formMD.ShowDialog();
            if (diagRes == DialogResult.Cancel) mód = "MM";
            


        }

        public formMentésDialógus()
        {
            InitializeComponent();
        }

        



        private void btMeBe_Click(object sender, EventArgs e)
        {
            mód = "MB";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btMeFo_Click(object sender, EventArgs e)
        {
            mód = "MF";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btMeMe_Click(object sender, EventArgs e)
        {
            mód = "MM";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
