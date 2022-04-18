using System;
using System.Drawing;
using System.Windows.Forms;

namespace Felisz
{
    public partial class formMunkaTörvénykönyve : Form
    {
        public formMunkaTörvénykönyve()
        {
            InitializeComponent();
        }

        private void formMunkaTörvénykönyve_Load(object sender, EventArgs e)
        {
            if(Program.TTSEngedélyezve==false)
            {
                btPlay.Visible = false;
                btStop.Visible = false;
            }
        }

        private void lbMTKeresés_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btMTKeresés_Click(object sender, EventArgs e)
        {
            tbMTKeresésParagrafus.Text = "";
            MTKeresés();

        }

        private string MTKeresés()
        {

            if (tbMTKeresés.Text == "" && tbMTKeresésParagrafus.Text == "")
            {
                MessageBox.Show("Nincs megadva keresési paraméter!", "Hiba");
                return null;
            }

            string keresendőKifejezés = "";
            string találat = "";
            if (tbMTKeresésParagrafus.Text != "")
            {
                keresendőKifejezés = tbMTKeresésParagrafus.Text;
                foreach (var item in MunkaTörvénykönyve.törvények)
                {
                    if (item.törvényNr == keresendőKifejezés) találat += item.törvénySzöveg + Environment.NewLine;

                }

            }
            else
            {


                keresendőKifejezés = tbMTKeresés.Text;
                foreach (var item in MunkaTörvénykönyve.törvények)
                {
                    if (item.törvénySzöveg.Contains(keresendőKifejezés)) találat += item.törvénySzöveg + Environment.NewLine;
                }
            }
            rtTalálat.Text = találat;





            //Találat megjelölése
            int találatSzámláló = 0;
            string kijelölendőSzöveg = keresendőKifejezés;
            int kijelölésKezdete = 0;
            int kijelölésVége = 0;
            int szövegVége = rtTalálat.Text.Length;
            for (int i = 0; i < szövegVége; i = kijelölésKezdete)
            {
                if (i == -1)
                {
                    break;
                }

                kijelölésKezdete = rtTalálat.Find(kijelölendőSzöveg, kijelölésKezdete, szövegVége, RichTextBoxFinds.None);
                if (kijelölésKezdete >= 0)
                {
                    találatSzámláló++;
                    rtTalálat.SelectionBackColor = Color.Gray;
                    kijelölésVége = kijelölendőSzöveg.Length;
                    kijelölésKezdete = kijelölésKezdete + kijelölésVége;
                }
            }

            if (találatSzámláló == 0) MessageBox.Show("Nincs találat...", "Info");

            tbTalálatokSzáma.Text = találatSzámláló.ToString();


            return rtTalálat.Text;
        }

        private void btMásolásVágólapra_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(MTKeresés());
        }

        private void tbMTKeresés_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbMTKeresésParagrafus.Text = "";
                MTKeresés();
            }
        }

        private void btKeresésParagrafus_Click(object sender, EventArgs e)
        {
            tbMTKeresés.Text = "";
            MTKeresés();
        }



        private void tbMTKeresésParagrafus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbMTKeresés.Text = "";
                MTKeresés();
            }
        }

        private void pbFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbFormClose_MouseEnter(object sender, EventArgs e)
        {
            pbFormClose.BackColor = Color.Gray;
        }

        private void pbFormClose_MouseLeave(object sender, EventArgs e)
        {
            pbFormClose.BackColor = Color.Transparent;
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            TTS.TTS_Play(rtTalálat.Text.Replace("§"," paragrafus "));
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            TTS.hang.SpeakAsyncCancelAll();
            
        }
    }
}
