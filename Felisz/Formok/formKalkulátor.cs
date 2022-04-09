using System;
using System.Drawing;
using System.Windows.Forms;


namespace Felisz
{
    public partial class formKalkulátor : Form
    {
        public formKalkulátor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

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

        private void formKalkulátor_Load(object sender, EventArgs e)
        {

        }

        private void btBérkalkulátor_Click(object sender, EventArgs e)
        {
            /*
            
            //Gyerekek számát ellenőrizni
            //Beadott értéket ellenőrizni
            //Minimálbér?


            tbBruttóBér.Text = tbBruttóBér.Text.Replace(" Ft", "").Replace(",", "");
            tbNettóBér.Text = tbNettóBér.Text.Replace(" Ft", "").Replace(",", "");

            //Családi adókedvezmény számítása            
            int CsaládiAdóKedvezmény = 0;
            int eltartottGyerekSzáma = int.Parse(cbeltartottGyerekSzáma.Text);
            int eltartottKedvezményezettGyerekSzáma = int.Parse(cbCsaládiKedvezményreJogosítóGyerekekSzáma.Text);
            switch (eltartottGyerekSzáma)
            {
                case 0:
                    CsaládiAdóKedvezmény = 0;
                    break;
                case 1:
                    CsaládiAdóKedvezmény = eltartottKedvezményezettGyerekSzáma * 10000;
                    break;
                case 2:
                    CsaládiAdóKedvezmény = eltartottKedvezményezettGyerekSzáma * 20000;
                    break;
                default:
                    CsaládiAdóKedvezmény = eltartottKedvezményezettGyerekSzáma * 33000;
                    break;
            }

            //Családi pótlék számítása
            int CsaládiPótlék = 0;
            switch (eltartottGyerekSzáma)
            {
                case 0:
                    CsaládiPótlék = 0;
                    break;
                case 1 when cbGyermekétEgyedülNeveli.Text == "nem":
                    CsaládiPótlék = 12200 * eltartottKedvezményezettGyerekSzáma;
                    break;
                case 1 when cbGyermekétEgyedülNeveli.Text == "igen":
                    CsaládiPótlék = 13700 * eltartottKedvezményezettGyerekSzáma;
                    break;
                case 2 when cbGyermekétEgyedülNeveli.Text == "nem":
                    CsaládiPótlék = 13300 * eltartottKedvezményezettGyerekSzáma;
                    break;
                case 2 when cbGyermekétEgyedülNeveli.Text == "igen":
                    CsaládiPótlék = 14800 * eltartottKedvezményezettGyerekSzáma;
                    break;
                case int n when n > 2 && cbGyermekétEgyedülNeveli.Text == "nem":
                    CsaládiPótlék = 16000 * eltartottKedvezményezettGyerekSzáma;
                    break;
                case int n when n > 2 && cbGyermekétEgyedülNeveli.Text == "igen":
                    CsaládiPótlék = 17000 * eltartottKedvezményezettGyerekSzáma;
                    break;

            }






            float BruttóBér = float.Parse(tbBruttóBér.Text);
            float Szocho = BruttóBér * 0.155f;
            float Szakképzési = BruttóBér * 0.015f;
            float TB = BruttóBér * 0.185f;
            float Gyes = 0;
            float SzámítottSZJA = BruttóBér * 0.15f;
            float CsaládiAdókedvezménnyelCsökkentettSZJA = Math.Max(0, (BruttóBér * 0.15f) - CsaládiAdóKedvezmény);
            float FelNemHasználtAdókedvezmény = 0;
            float ÖsszesAdó = CsaládiAdókedvezménnyelCsökkentettSZJA;
            float Adójóváírás = 0;
            float FelhasználtÖsszesMunkavállalóiKedvezmény = CsaládiAdóKedvezmény;
            float HaviÖsszesLevonás = Math.Max(0, (TB + SzámítottSZJA - CsaládiAdóKedvezmény));
            float HaviÖsszesMunkaadóiKedvezmény = 0;
            float HaviÖsszesMunkaadóiJárulék = Szocho + Szakképzési;
            float ÁllamnakFizetendő = Math.Max(0, (TB + SzámítottSZJA + Szocho + Szakképzési - CsaládiAdóKedvezmény));
            float MunkaadóKöltsége = HaviÖsszesMunkaadóiJárulék + BruttóBér;
            float NettóBér = BruttóBér - HaviÖsszesLevonás;
            float ÖsszesNettóJövedelem = BruttóBér - HaviÖsszesLevonás + CsaládiPótlék;

            tbBruttóBér.Text = BruttóBér.ToString("#,###,##0 Ft");
            tbNettóBér.Text = NettóBér.ToString("#,###,##0 Ft");
            lbMunkavállalóJárulékaiAdói.Text = Szocho.ToString("#,###,##0 Ft");
            lbSZJAKedvezményekNélkül.Text = Szakképzési.ToString("#,###,##0 Ft");
            lbSZJAKedvezmény.Text = TB.ToString("#,###,##0 Ft");
            lbGyes.Text = Gyes.ToString("#,###,##0 Ft");
            lbSZJACsaládiKedvezmény.Text = CsaládiAdóKedvezmény.ToString("#,###,##0 Ft");
            lbTBJárulékKedvezményekNélkül.Text = SzámítottSZJA.ToString("#,###,##0 Ft");
            lbSZJANégyVagyTöbbGyermeketNevelőAnyákKedvezménye.Text = CsaládiAdókedvezménnyelCsökkentettSZJA.ToString("#,###,##0 Ft");
            lbSZJASzemélyiKedvezmény.Text = FelNemHasználtAdókedvezmény.ToString("#,###,##0 Ft");
            lbJárulékokÖsszesen.Text = ÖsszesAdó.ToString("#,###,##0 Ft");
            lb25ÉvAlattiSZJAKedvezmény.Text = Adójóváírás.ToString("#,###,##0 Ft");
            lbSZJAElsőHázasokKedvezménye.Text = FelhasználtÖsszesMunkavállalóiKedvezmény.ToString("#,###,##0 Ft");
            lbHaviÖsszesLevonás.Text = HaviÖsszesLevonás.ToString("#,###,##0 Ft");
            lbHaviÖsszesMunkaadóiKedvezmény.Text = HaviÖsszesMunkaadóiKedvezmény.ToString("#,###,##0 Ft");
            lbHaviÖsszesMunkaadóiJárulék.Text = HaviÖsszesMunkaadóiJárulék.ToString("#,###,##0 Ft");
            lbÁllamnakFizetendő.Text = ÁllamnakFizetendő.ToString("#,###,##0 Ft");
            lbMunkaadóKöltsége.Text = MunkaadóKöltsége.ToString("#,###,##0 Ft");
            lbNettóBér.Text = NettóBér.ToString("#,###,##0 Ft");
            lbCsaládiPótlék.Text = CsaládiPótlék.ToString("#,###,##0 Ft");
            lbÖsszesNettóJövedelem.Text = ÖsszesNettóJövedelem.ToString("#,###,##0 Ft");
            */


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void lbTBSzemélyiKedvezmény_Click(object sender, EventArgs e)
        {

        }
    }
}
