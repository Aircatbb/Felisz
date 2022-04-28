using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;



namespace Felisz.Formok
{



    public partial class formSzemAdatok : Form
    {


        public string tempIrsz = "";
        public string tempVáros = "";
        public string tempVárosIrsz = "";
        public string tempKözterület = "";
        private static readonly List<ToolTipRekord> listToolTipRekords = new List<ToolTipRekord>();
        private string hozzáTartVezetéknév = "";
        private string hozzáTartUtónév1 = "";
        private string hozzáTartUtónév2 = "";





        public formSzemAdatok()
        {
            InitializeComponent();

        }

        private void cbFEORFeltöltés()
        {
            for (int i = 0; i < Adatbázis.FEORList.Count; i++)
            {
                FEOR item = new FEOR();
                item.Feor4 = Adatbázis.FEORList[i].Feor4;
                item.Megnevezés = Adatbázis.FEORList[i].Feor4 + " - " + Adatbázis.FEORList[i].Megnevezés;
                cbFEOR.Items.Add(item);
            }

        }

        private void cbÁllampolgárságcbLakhelyOrszágFeltöltéscbSzületésiOrszág()
        {


            for (int i = 0; i < Adatbázis.országKódokList.Count; i++)
            {
                Országkód item = new Országkód();
                item.Kód = Adatbázis.országKódokList[i].Kód;
                item.Ország = Adatbázis.országKódokList[i].Ország;
                cbÁllampolgárság.Items.Add(item);
                cbLakhelyOrszág.Items.Add(item);
                cbSzületésiOrszág.Items.Add(item);

            }
            cbÁllampolgárság.SelectedIndex = 140;
            cbLakhelyOrszág.SelectedIndex = 140;
            cbSzületésiOrszág.SelectedIndex = 140;
        }

        private void cbFoglakoztatásHelyeFeltöltés()
        {

            for (int i = 0; i < Adatbázis.foglalkoztatásHelyeList.Count; i++)
            {
                FoglalkoztatásHelye item = new FoglalkoztatásHelye();

                item.ID = Adatbázis.foglalkoztatásHelyeList[i].ID;
                item.Irsz = Adatbázis.foglalkoztatásHelyeList[i].Irsz;
                item.Város = Adatbázis.foglalkoztatásHelyeList[i].Város;
                item.Közterület = Adatbázis.foglalkoztatásHelyeList[i].Közterület;
                item.KözterületJellege = Adatbázis.foglalkoztatásHelyeList[i].KözterületJellege;
                item.Házszám = Adatbázis.foglalkoztatásHelyeList[i].Házszám;
                item.Megnevezés = Adatbázis.foglalkoztatásHelyeList[i].Megnevezés;
                cbFoglalkoztatásHelye.Items.Add(item);

            }
            cbFoglalkoztatásHelye.SelectedIndex = 0;

        }

        private void cbIrszámFeltöltés()
        {
            /*
            cbIrszám.Items.Clear();
            for (int i = 0; i < Adatbázis.csakIrszámList.Count; i++)
            {
                Irszámkód item = new Irszámkód();
                item.Irányítószám = Adatbázis.csakIrszámList[i].Irsz;
                item.VárosIrsz = Adatbázis.csakIrszámList[i].Irsz + " - " + Adatbázis.csakIrszámList[i].Város;
                cbIrszám.Items.Add(item);
            }
            */


            cbIrszám.Items.Clear();
            for (int i = 0; i < Adatbázis.csakVárosList.Count; i++)
            {
                Irszámkód item = new Irszámkód();
                item.Irányítószám = Adatbázis.csakVárosList[i].Irsz;
                item.VárosIrsz = Adatbázis.csakVárosList[i].Irsz + " - " + Adatbázis.csakVárosList[i].Város;
                cbIrszám.Items.Add(item);
            }



        }

        private void cbVárosFeltöltés()
        {
            cbVáros.Items.Clear();


            for (int i = 0; i < Adatbázis.csakVárosList.Count; i++)
            {
                Városkód item = new Városkód();
                item.Város = Adatbázis.csakVárosList[i].Város;
                item.VárosIrsz = Adatbázis.csakVárosList[i].Város + " - " + Adatbázis.csakVárosList[i].Irsz;
                cbVáros.Items.Add(item);
            }
        }

        private void cbSzületésiHelyFeltöltés()
        {
            cbSzületésiHely.Items.Clear();

            string elozo = "";
            for (int i = 0; i < Adatbázis.csakVárosList.Count; i++)
            {
                if (elozo != Adatbázis.csakVárosList[i].Város)
                {
                    cbSzületésiHely.Items.Add(Adatbázis.csakVárosList[i].Város);
                }
                elozo = Adatbázis.csakVárosList[i].Város;

            }
        }

        private void cbKözterületFeltöltés()
        {
            cbKözterület.Items.Clear();

            List<IszVárosUtca> tempTalálat = Adatbázis.iszVárosUtcaList.FindAll(item => item.Irsz == tempVárosIrsz);

            for (int i = 0; i < tempTalálat.Count; i++)
            {
                cbKözterület.Items.Add(tempTalálat[i].Utca);
            }


        }

        private void cbVáros_Validated(object sender, EventArgs e)
        {

            if (cbVáros.SelectedItem != null && cbVáros.SelectedItem.ToString().Contains("-"))
            {


                tempVáros = (cbVáros.SelectedItem as Városkód).Város;
                tempVárosIrsz = (cbVáros.SelectedItem as Városkód).VárosIrsz;
                tempVárosIrsz = tempVárosIrsz.Substring(tempVárosIrsz.Length - 4, 4);
                cbVáros.Items.Add(tempVáros);
                cbVáros.SelectedItem = tempVáros;

                IszVárosUtca tempTalálat = Adatbázis.csakVárosList.Find(item => item.Irsz == tempVárosIrsz);
                //IszVárosUtca tempTalálat = Adatbázis.csakIrszámList.Find(item => item.Irsz == tempVárosIrsz);

                cbIrszám.Items.Remove(tempIrsz);
                cbIrszám.Items.Add(tempTalálat.Irsz);
                cbIrszám.SelectedItem = tempTalálat.Irsz;
                tempIrsz = tempTalálat.Irsz;
                cbKözterületFeltöltés();
            }

            TávolságSzámítása();

            if (cbVáros.Text != "")
            {
                CímkeSzínBeállítás(lbVáros, true);
                CímkeSzínBeállítás(lbIrszám, true);
            }
            else
            {
                CímkeSzínBeállítás(lbVáros, false);
            }
        }

        private void cbIrszám_Validated(object sender, EventArgs e)
        {

            if (cbIrszám.SelectedItem != null && cbIrszám.SelectedItem.ToString().Contains("-"))
            {

                tempIrsz = (cbIrszám.SelectedItem as Irszámkód).Irányítószám;
                tempVárosIrsz = tempIrsz;
                cbIrszám.Items.Add(tempIrsz);
                cbIrszám.SelectedItem = tempIrsz;

                IszVárosUtca tempTalálat = Adatbázis.csakVárosList.Find(item => item.Irsz == tempIrsz);

                cbVáros.Items.Remove(tempVáros);
                cbVáros.Items.Add(tempTalálat.Város);
                cbVáros.SelectedItem = tempTalálat.Város;
                tempVáros = tempTalálat.Város;
                cbKözterületFeltöltés();
            }

            TávolságSzámítása();

            if (cbIrszám.Text != "")
            {
                CímkeSzínBeállítás(lbIrszám, true);
                CímkeSzínBeállítás(lbVáros, true);
            }
            else
            {
                CímkeSzínBeállítás(lbIrszám, false);
            }
        }

        private void TávolságSzámítása()
        {
            tbTávolság.Text = "";
            if (cbIrszám.Text == "" ||
                cbVáros.Text == "" ||
                cbKözterület.Text == "" ||
                tbKözterületJellege.Text == "" ||
                tbHázszám.Text == "")
            {
                return;
            }

            string cím1 = (cbFoglalkoztatásHelye.SelectedItem as FoglalkoztatásHelye).Irsz + " " +
                        (cbFoglalkoztatásHelye.SelectedItem as FoglalkoztatásHelye).Város + " " +
                        (cbFoglalkoztatásHelye.SelectedItem as FoglalkoztatásHelye).Közterület + " " +
                        (cbFoglalkoztatásHelye.SelectedItem as FoglalkoztatásHelye).KözterületJellege + " " +
                        (cbFoglalkoztatásHelye.SelectedItem as FoglalkoztatásHelye).Házszám;
            string cím2 = cbIrszám.Text + " " +
                         cbVáros.Text + " " +
                         cbKözterület.Text + " " +
                         tbKözterületJellege.Text + " " +
                         tbHázszám.Text;

            string távolság = "";
            Funkciók.GoogleMapsTávolság(cím1, cím2, ref távolság);
            tbTávolság.Text = távolság;

            if ((cbFoglalkoztatásHelye.SelectedItem as FoglalkoztatásHelye).Irsz == cbIrszám.Text)
            {
                tbTávolság.Text = "0 Km";
            }
        }

        private void cbIrszám_Click(object sender, EventArgs e)
        {
            cbIrszám.Items.Remove(tempIrsz);
        }

        private void cbVáros_Click(object sender, EventArgs e)
        {
            cbVáros.Items.Remove(tempVáros);
        }

        private void cbKözterület_Validated(object sender, EventArgs e)
        {


            if (cbKözterület.SelectedItem == null)
            {
                tbKözterületJellege.Text = "";
            }
            else
            {
                tbKözterületJellege.Text = cbKözterület.Text.Substring(cbKözterület.Text.LastIndexOf(' ') + 1);
            }


            cbKözterület.Items.Remove(tempKözterület);
            if (cbKözterület.Text != "")
            {
                try
                {
                    tempKözterület = cbKözterület.Text.Substring(0, cbKözterület.Text.LastIndexOf(' '));
                }
                catch (Exception)
                {
                    tempKözterület = cbKözterület.Text;
                }

                cbKözterület.Items.Add(tempKözterület);
                cbKözterület.SelectedItem = tempKözterület;
            }

            TávolságSzámítása();

            if (cbKözterület.Text != "")
            {
                CímkeSzínBeállítás(lbKözterület, true);
            }
            else
            {
                CímkeSzínBeállítás(lbKözterület, false);
            }
        }

        private void cbKözterület_Click(object sender, EventArgs e)
        {
            cbKözterület.Items.Remove(tempKözterület);
        }

        private void cbFoglalkoztatásHelye_Validated(object sender, EventArgs e)
        {
            TávolságSzámítása();
        }

        private void tbKözterületJellege_Validated(object sender, EventArgs e)
        {
            TávolságSzámítása();

            if (tbKözterületJellege.Text != "")
            {
                CímkeSzínBeállítás(lbKözterületJellege, true);
            }
            else
            {
                CímkeSzínBeállítás(lbKözterületJellege, false);
            }
        }

        private void tbHázszám_Validated(object sender, EventArgs e)
        {
            TávolságSzámítása();

            if (tbHázszám.Text != "")
            {
                CímkeSzínBeállítás(lbHázszám, true);
            }
            else
            {
                CímkeSzínBeállítás(lbHázszám, false);
            }
        }

        private void CímkeSzínBeállítás(Label címke, bool engedélyezve)
        {
            if (engedélyezve == true)
            {
                címke.BackColor = Color.FromArgb(30, 30, 30);
                címke.ForeColor = Color.FromArgb(200, 200, 200);
            }
            else
            {
                címke.BackColor = Color.FromArgb(166, 66, 51);
                címke.ForeColor = Color.White;
            }
        }

        private void tbVezetéknév_Validated(object sender, EventArgs e)
        {
            Funkciók.NévValidálás(lbVezetéknév, tbVezetéknév, tbSzülVezetéknév, false);

        }

        private void tbUtónév1_Validated(object sender, EventArgs e)
        {

            Funkciók.NévValidálás(lbUtónév1, tbUtónév1, tbSzülUtónév1, false);

        }

        private void tbSzülVezetéknév_Validated(object sender, EventArgs e)
        {
            Funkciók.NévValidálás(lbSzülVezetéknév, tbSzülVezetéknév, null, false);
        }

        private void tbSzülUtónév1_Validated(object sender, EventArgs e)
        {
            Funkciók.NévValidálás(lbSzülUtónév1, tbSzülUtónév1, null, false);
        }

        private void tbUtónév2_Validated(object sender, EventArgs e)
        {
            Funkciók.NévValidálás(lbUtónév2, tbUtónév2, tbSzülUtónév2, true);
        }

        private void cbIrszám_Validating(object sender, CancelEventArgs e)
        {

            //erre valószínűleg nincs szükség TÖRÖLNI
            if (cbIrszám.Text != "")
            {
                CímkeSzínBeállítás(lbIrszám, true);
            }
            else
            {
                CímkeSzínBeállítás(lbIrszám, false);
            }
        }

        private void tbAzonosítószám_Validated(object sender, EventArgs e)
        {
            int tempAzon = 0;
            if (!int.TryParse(tbAzonosítószám.Text, out tempAzon))
            {
                CímkeSzínBeállítás(lbAzonosítószám, false);
                return;
            }

            if (tbAzonosítószám.Text.Length >= 1 && Adatbázis.AzonosítószámSzabad(tempAzon))
            {
                CímkeSzínBeállítás(lbAzonosítószám, true);
            }
            else
            {
                CímkeSzínBeállítás(lbAzonosítószám, false);
            }
        }

        private void cbSzületésiHely_Validated(object sender, EventArgs e)
        {
            if (cbSzületésiHely.Text.Length >= 2)
            {
                CímkeSzínBeállítás(lbSzületésiHely, true);
            }
            else
            {
                CímkeSzínBeállítás(lbSzületésiHely, false);
            }
        }

        private void tbAnyjaNeve_Validated(object sender, EventArgs e)
        {
            Funkciók.NévValidálás(lbAnyjaNeve, tbAnyjaNeve, null, false);

        }

        private void cbNeme_Validated(object sender, EventArgs e)
        {
            if (cbNeme.Text.Length >= 2)
            {
                CímkeSzínBeállítás(lbNeme, true);
            }
            else
            {
                CímkeSzínBeállítás(lbNeme, false);
            }
        }

        private void tbAdóazonosító_Validated(object sender, EventArgs e)
        {
            if (Funkciók.AdóazonosítóEllenőrzése(tbAdóazonosító.Text, DateTime.Parse(tbSzületésDátum.Text)))
            {
                CímkeSzínBeállítás(lbAdóazonosító, true);

            }
            else
            {
                MessageBox.Show("Hibás adóazonosító, vagy születési dátum!", "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                CímkeSzínBeállítás(lbAdóazonosító, false);
            }
        }

        private void tbTAJSzám_Validated(object sender, EventArgs e)
        {
            if (Funkciók.TajszámEllenőrzés(tbTAJSzám.Text))
            {
                CímkeSzínBeállítás(lbTAJSzám, true);
            }
            else
            {
                CímkeSzínBeállítás(lbTAJSzám, false);
            }
        }

        private void cbFEOR_Validated(object sender, EventArgs e)
        {
            if (cbFEOR.Text != "")
            {
                CímkeSzínBeállítás(lbFEOR, true);
            }
            else
            {
                CímkeSzínBeállítás(lbFEOR, false);
            }
        }

        private void formSzemAdatok_Shown(object sender, EventArgs e)
        {

            #region Progressbar, comboBox-ok feltöltése
            this.Hide();

            ProgressBar pB = Application.OpenForms["formFelisz"].Controls["panelTopMenu"].Controls["folyamatJelző1"] as ProgressBar;
            pB.Visible = true;
            pB.Step = 14;
            pB.Value = 14;


            pB.PerformStep();
            cbVárosFeltöltés();

            pB.PerformStep();
            cbÁllampolgárságcbLakhelyOrszágFeltöltéscbSzületésiOrszág();

            pB.PerformStep();
            cbFoglakoztatásHelyeFeltöltés();

            pB.PerformStep();
            cbSzületésiHelyFeltöltés();

            pB.PerformStep();
            cbFEORFeltöltés();

            pB.PerformStep();
            cbIrszámFeltöltés();

            pB.Visible = false;

            tbAzonosítószám.Text = Adatbázis.AzonosítószámKövetkező().ToString();

            this.Show();
            #endregion

            //Dolgozó kiválasztása

            Form formSzemKi = new formMunkavállalóVálasztás();
            DialogResult dialogResult = formSzemKi.ShowDialog();


            if (dialogResult == DialogResult.Cancel || formMunkavállalóVálasztás.mód == "A") this.Close();
            if (formMunkavállalóVálasztás.mód == "M")
            {
                SzemélyiAdatokBetöltése();


            }
            if (formMunkavállalóVálasztás.mód == "T")
            {
                MunkavállalóTörlése(formMunkavállalóVálasztás.azon);
                this.Close();
            }

            if (formMunkavállalóVálasztás.mód == "N") tbAzonosítószám.Focus();

            //Alapértelmezett értékek
            cbMegVáltMunkFogy.SelectedIndex = 1;
            cbFöldAlattIonMunk.SelectedIndex = 1;
            cbFogyatékHozzá.SelectedIndex = 1;

            //Hozzátartozók betöltése
            HozzátartozókBetöltése(formMunkavállalóVálasztás.azon);
            //Hozzátartozók mezőinek validálása, mivel nem kötelező
            MezőkValidálása(gpHozzátartozó);


        }

        private void cbLakhelyOrszág_Validated(object sender, EventArgs e)
        {
            if ((cbLakhelyOrszág.SelectedItem as Országkód).Kód != "HU")
            {
                cbIrszám.Items.Clear();
                cbIrszám.DropDownStyle = ComboBoxStyle.DropDown;
                cbVáros.Items.Clear();
                cbVáros.DropDownStyle = ComboBoxStyle.DropDown;
                cbKözterület.Items.Clear();
                cbKözterület.DropDownStyle = ComboBoxStyle.DropDown;
            }
            else
            {
                cbIrszám.Items.Clear();
                cbIrszámFeltöltés();
                cbIrszám.DropDownStyle = ComboBoxStyle.DropDownList;

                cbVáros.Items.Clear();
                cbVárosFeltöltés();
                cbVáros.DropDownStyle = ComboBoxStyle.DropDownList;

                cbKözterület.Items.Clear();
                cbKözterület.DropDownStyle = ComboBoxStyle.DropDownList;

                tbKözterületJellege.Text = "";
                tbHázszám.Text = "";
            }
        }

        private bool MentésIndítható(Control kontroll)
        {

            foreach (var item in kontroll.Controls)
            {
                if (item is Label)
                {
                    Label lb = (Label)item;
                    if (lb.BackColor == Color.FromArgb(166, 66, 51))
                    {
                        return false;
                    }
                }

                if (kontroll.HasChildren)
                {
                    foreach (Control childControl in kontroll.Controls)
                    {
                        if (MentésIndítható(childControl) == false) return false;

                    }
                }
            }

            return true;

        }

        private void ÁltalánosSzemélyiAdatokMentés()
        {

            formMentésDialógus.MentésMódVálasztás();
            if (formMentésDialógus.mód == "MM") return;


            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Properties.Settings.Default.felisz_db_ConnectionString;
            myConnectionString = Adatbázis.MyConnectionString();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;



            try
            {
                conn.Open();




                string sql = "INSERT INTO SzemTorzs (" +
                    "SzekhelyTelephelyID, " +
                    "EngedelyKor, " +
                    "SzemAzon, " +
                    "VezNev, " +
                    "UtoNev1, " +
                    "UtoNev2, " +
                    "SzulVezNev, " +
                    "SzulUtoNev1, " +
                    "SzulUtoNev2, " +
                    "SzulDatum, " +
                    "SzulHely, " +
                    "SzulOrszag, " +
                    "Neme, " +
                    "LakOrszag, " +
                    "LakIrSzam, " +
                    "LakVaros, " +
                    "LakKozt, " +
                    "LakKoztJell, " +
                    "LakHazSz, " +
                    "LakEpul, " +
                    "LakLepcsH, " +
                    "LakEmelet, " +
                    "LakAjto, " +
                    "LakTavolsag, " +
                    "SzemErvTol, " +
                    "SzemErvIg, " +
                    "AdoAzonosito, " +
                    "TajSzam, " +
                    "AnyjaNeve, " +
                    "AllamPolg, " +
                    "MegvaltMunkFogy, " +
                    "FoldAlattIonMunk, " +
                    "Feor, " +
                    "RogzFelh, " +
                    "RogzDatum) " +
                    "VALUES (" +
                    "@SzekhelyTelephelyID, " +
                "@EngedelyKor, " +
                "@SzemAzon, " +
                "@VezNev, " +
                "@UtoNev1, " +
                "@UtoNev2, " +
                "@SzulVezNev, " +
                "@SzulUtoNev1, " +
                "@SzulUtoNev2, " +
                "@SzulDatum, " +
                "@SzulHely, " +
                "@SzulOrszag, " +
                "@Neme, " +
                "@LakOrszag, " +
                "@LakIrSzam, " +
                "@LakVaros, " +
                "@LakKozt, " +
                "@LakKoztJell, " +
                "@LakHazSz, " +
                "@LakEpul, " +
                "@LakLepcsH, " +
                "@LakEmelet, " +
                "@LakAjto, " +
                "@LakTavolsag, " +
                "@SzemErvTol, " +
                "@SzemErvIg, " +
                "@AdoAzonosito, " +
                "@TajSzam, " +
                "@AnyjaNeve, " +
                "@AllamPolg, " +
                "@MegvaltMunkFogy, " +
                "@FoldAlattIonMunk, " +
                "@Feor, " +
                "@RogzFelh, " +
                "@RogzDatum)";


                var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                SQLCommand.Parameters.Add("@SzekhelyTelephelyID", MySql.Data.MySqlClient.MySqlDbType.Int16);
                SQLCommand.Parameters["@SzekhelyTelephelyID"].Value = (cbFoglalkoztatásHelye.SelectedItem as FoglalkoztatásHelye).ID;


                SQLCommand.Parameters.Add("@EngedelyKor", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@EngedelyKor"].Value = tbEngedélykör.Text;


                SQLCommand.Parameters.Add("@SzemAzon", MySql.Data.MySqlClient.MySqlDbType.Int16);
                SQLCommand.Parameters["@SzemAzon"].Value = tbAzonosítószám.Text;

                SQLCommand.Parameters.Add("@VezNev", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@VezNev"].Value = tbVezetéknév.Text;

                SQLCommand.Parameters.Add("@UtoNev1", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@UtoNev1"].Value = tbUtónév1.Text;

                SQLCommand.Parameters.Add("@UtoNev2", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@UtoNev2"].Value = tbUtónév2.Text;

                SQLCommand.Parameters.Add("@SzulVezNev", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@SzulVezNev"].Value = tbSzülVezetéknév.Text;

                SQLCommand.Parameters.Add("@SzulUtoNev1", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@SzulUtoNev1"].Value = tbSzülUtónév1.Text;

                SQLCommand.Parameters.Add("@SzulUtoNev2", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@SzulUtoNev2"].Value = tbSzülUtónév2.Text;

                SQLCommand.Parameters.Add("@SzulDatum", MySql.Data.MySqlClient.MySqlDbType.Date);
                SQLCommand.Parameters["@SzulDatum"].Value = DateTime.Parse(tbSzületésDátum.Text);

                SQLCommand.Parameters.Add("@SzulHely", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@Szulhely"].Value = cbSzületésiHely.Text;

                SQLCommand.Parameters.Add("@SzulOrszag", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@SzulOrszag"].Value = (cbSzületésiOrszág.SelectedItem as Országkód).Kód;

                SQLCommand.Parameters.Add("@Neme", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@Neme"].Value = cbNeme.Text;

                SQLCommand.Parameters.Add("@LakOrszag", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@LakOrszag"].Value = (cbLakhelyOrszág.SelectedItem as Országkód).Kód;

                SQLCommand.Parameters.Add("@LakIrSzam", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@LakIrSzam"].Value = cbIrszám.Text;

                SQLCommand.Parameters.Add("@LakVaros", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@LakVaros"].Value = cbVáros.Text;

                SQLCommand.Parameters.Add("@LakKozt", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@LakKozt"].Value = cbKözterület.Text;

                SQLCommand.Parameters.Add("@LakKoztJell", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@LakKoztJell"].Value = tbKözterületJellege.Text;

                SQLCommand.Parameters.Add("@LakHazSz", MySql.Data.MySqlClient.MySqlDbType.Int16);
                SQLCommand.Parameters["@LakHazSz"].Value = tbHázszám.Text;

                SQLCommand.Parameters.Add("@LakEpul", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@LakEpul"].Value = tbÉpület.Text;

                SQLCommand.Parameters.Add("@LakLepcsH", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@LakLepcsH"].Value = tbLépcsőház.Text;

                SQLCommand.Parameters.Add("@LakEmelet", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@LakEmelet"].Value = tbEmelet.Text;

                SQLCommand.Parameters.Add("@LakAjto", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@LakAjto"].Value = tbAjtó.Text;

                SQLCommand.Parameters.Add("@LakTavolsag", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@LakTavolsag"].Value = tbTávolság.Text;

                SQLCommand.Parameters.Add("@SzemErvTol", MySql.Data.MySqlClient.MySqlDbType.Date);
                SQLCommand.Parameters["@SzemErvTol"].Value = DateTime.Now;

                SQLCommand.Parameters.Add("@SzemErvIg", MySql.Data.MySqlClient.MySqlDbType.Date);
                SQLCommand.Parameters["@SzemErvIg"].Value = new DateTime(2099, 1, 31);

                SQLCommand.Parameters.Add("@AdoAzonosito", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@AdoAzonosito"].Value = tbAdóazonosító.Text;

                SQLCommand.Parameters.Add("@TajSzam", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@TajSzam"].Value = tbTAJSzám.Text;

                SQLCommand.Parameters.Add("@Feor", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@Feor"].Value = (cbFEOR.SelectedItem as FEOR).Feor4;

                SQLCommand.Parameters.Add("@AnyjaNeve", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@AnyjaNeve"].Value = tbAnyjaNeve.Text;

                SQLCommand.Parameters.Add("@AllamPolg", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@AllamPolg"].Value = (cbÁllampolgárság.SelectedItem as Országkód).Kód;

                SQLCommand.Parameters.Add("@MegvaltMunkFogy", MySql.Data.MySqlClient.MySqlDbType.VarChar);
                SQLCommand.Parameters["@MegvaltMunkFogy"].Value = cbMegVáltMunkFogy.Text.Substring(0, 1);

                SQLCommand.Parameters.Add("@FoldAlattIonMunk", MySql.Data.MySqlClient.MySqlDbType.VarChar);
                SQLCommand.Parameters["@FoldAlattIonMunk"].Value = cbFöldAlattIonMunk.Text.Substring(0, 1);

                SQLCommand.Parameters.Add("@RogzFelh", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@RogzFelh"].Value = Properties.Settings.Default.utolsóFelhasználó;

                SQLCommand.Parameters.Add("@RogzDatum", MySql.Data.MySqlClient.MySqlDbType.Date);
                SQLCommand.Parameters["@RogzDatum"].Value = DateTime.Now;

                SQLCommand.ExecuteNonQuery();

                Funkciók.TopKonzolKiírás("Azonosítószám: " + tbAzonosítószám.Text + " Név: " + tbVezetéknév.Text + " " + tbUtónév1.Text + " " + tbUtónév2.Text + " általános személyi adatok mentve! " + DateTime.Now.ToString());

                //Amennyiben új rögzítés,úgy mostantól engedélyezük a további adatok felvitelét
                tlpHozzátartozók_New.Visible = true;
                

                SQLCommand.Dispose();
            }
            catch (Exception ex)
            {
                Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Adatbázis írási hiba (Személyi alapadatok)!---" + ex);
                MessageBox.Show("Adatbázis írási hiba (Személyi alapadatok)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            conn.Close();


            if (formMentésDialógus.mód == "MB") this.Close();
            if (formMentésDialógus.mód == "MF") formMunkavállalóVálasztás.mód = "M";


        }

        private void SzemélyiAdatokBetöltése()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Properties.Settings.Default.felisz_db_ConnectionString;
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            myConnectionString = Adatbázis.MyConnectionString();

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;




            try
            {
                conn.Open();




                string sql = "select * from SzemTorzs " +
                             "where SzemAzon='" + formMunkavállalóVálasztás.azon + "' " +
                             "and SzemTorzs.SzemErvIg='2099.01.31' ";

                /*string sql = "select * from SzemTorzs, CegTorzs " +
                           "where SzemAzon='" + formMunkavállalóVálasztás.azon + "' " +
                           "and SzemTorzs.SzekhelyTelephelyID=CegTorzs.ID " +
                           "and SzemTorzs.SzemErvIg='2099.01.31' " +
                           "and CegTorzs.CegErvIg='2099.01.31'";
                */

                var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);


                MySql.Data.MySqlClient.MySqlDataReader dataReader = SQLCommand.ExecuteReader();
                while (dataReader.Read())
                {


                    tbAzonosítószám.Text = dataReader.GetString(dataReader.GetOrdinal("SzemAzon"));
                    tbVezetéknév.Text = dataReader.GetString(dataReader.GetOrdinal("VezNev"));
                    tbUtónév1.Text = dataReader.GetString(dataReader.GetOrdinal("UtoNev1"));
                    tbUtónév2.Text = dataReader.GetString(dataReader.GetOrdinal("UtoNev2"));
                    tbSzülVezetéknév.Text = dataReader.GetString(dataReader.GetOrdinal("SzulVezNev"));
                    tbSzülUtónév1.Text = dataReader.GetString(dataReader.GetOrdinal("SzulUtoNev1"));
                    tbSzülUtónév2.Text = dataReader.GetString(dataReader.GetOrdinal("SzulUtoNev2"));
                    tbSzületésDátum.Text = dataReader.GetDateTime(dataReader.GetOrdinal("SzulDatum")).ToString("yyyy.MM.dd");
                    cbSzületésiHely.SelectedItem = dataReader.GetString(dataReader.GetOrdinal("SzulHely"));
                    cbSzületésiOrszág.SelectedItem = dataReader.GetString(dataReader.GetOrdinal("SzulOrszag"));
                    tbAnyjaNeve.Text = dataReader.GetString(dataReader.GetOrdinal("AnyjaNeve"));
                    cbNeme.SelectedItem = dataReader.GetString(dataReader.GetOrdinal("Neme"));

                    cbÁllampolgárság.SelectedItem = dataReader.GetString(dataReader.GetOrdinal("AllamPolg"));


                    cbFoglalkoztatásHelye.SelectedItem = dataReader.GetInt16(dataReader.GetOrdinal("SzekhelyTelephelyID"));
                    FoglalkoztatásHelye talalat = Adatbázis.foglalkoztatásHelyeList.Find(item => item.ID == dataReader.GetInt16(dataReader.GetOrdinal("SzekhelyTelephelyID")));
                    cbFoglalkoztatásHelye.SelectedIndex = cbFoglalkoztatásHelye.FindString(talalat.Megnevezés);

                    tbEngedélykör.Text = dataReader.GetString(dataReader.GetOrdinal("EngedelyKor"));

                    cbFEOR.Items.Add(dataReader.GetString(dataReader.GetOrdinal("Feor")));
                    string tempFeor = dataReader.GetString(dataReader.GetOrdinal("Feor")) + " - " + FeorLeírásLekérdezés(dataReader.GetString(dataReader.GetOrdinal("Feor")));
                    cbFEOR.Items.Add(tempFeor);
                    cbFEOR.SelectedItem = tempFeor;

                    tbAdóazonosító.Text = dataReader.GetString(dataReader.GetOrdinal("AdoAzonosito"));
                    tbTAJSzám.Text = dataReader.GetString(dataReader.GetOrdinal("TajSzam"));

                    if (dataReader.GetChar(dataReader.GetOrdinal("MegvaltMunkFogy")) == 'I') cbMegVáltMunkFogy.SelectedIndex = 0; else cbMegVáltMunkFogy.SelectedItem = 1;

                    if (dataReader.GetChar(dataReader.GetOrdinal("FoldAlattIonMunk")) == 'I') cbFöldAlattIonMunk.SelectedIndex = 0; else cbFöldAlattIonMunk.SelectedItem = 1;

                    cbLakhelyOrszág.SelectedItem = dataReader.GetString(dataReader.GetOrdinal("LakOrszag"));
                    cbIrszám.Text = dataReader.GetString(dataReader.GetOrdinal("LakirSzam"));

                    cbIrszám.Items.Add(dataReader.GetString(dataReader.GetOrdinal("LakIrSzam")));
                    cbIrszám.SelectedItem = dataReader.GetString(dataReader.GetOrdinal("LakIrSzam"));

                    cbVáros.Items.Add(dataReader.GetString(dataReader.GetOrdinal("LakVaros")));
                    cbVáros.SelectedItem = dataReader.GetString(dataReader.GetOrdinal("LakVaros"));

                    cbKözterület.Items.Add(dataReader.GetString(dataReader.GetOrdinal("LakKozt")));
                    cbKözterület.SelectedItem = dataReader.GetString(dataReader.GetOrdinal("LakKozt"));


                    tbKözterületJellege.Text = dataReader.GetString(dataReader.GetOrdinal("LakKoztJell"));
                    tbHázszám.Text = dataReader.GetString(dataReader.GetOrdinal("LakHazSz"));
                    tbÉpület.Text = dataReader.GetString(dataReader.GetOrdinal("LakEpul"));
                    tbLépcsőház.Text = dataReader.GetString(dataReader.GetOrdinal("LakLepcsH"));

                    tbEmelet.Text = dataReader.GetString(dataReader.GetOrdinal("LakEmelet"));
                    tbAjtó.Text = dataReader.GetString(dataReader.GetOrdinal("LakAjto"));



                    tbTávolság.Text = dataReader.GetString(dataReader.GetOrdinal("LakTavolsag"));

                }



                SQLCommand.Dispose();
            }
            catch (Exception ex)
            {
                Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Adatbázis olvasási hiba (Személyi alapadatok)!---" + ex);
                MessageBox.Show("Adatbázis olvasási hiba (Személyi alapadatok)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            conn.Close();

            tbAdóazonosító.Enabled = true;
            MezőkValidálása(tlpÁltalánosSzemélyiAdatok);

        }

        private string FeorLeírásLekérdezés(string feorSzám)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Properties.Settings.Default.felisz_db_ConnectionString;
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;

            string sql = "SELECT FEOR5 FROM FEOR WHERE FEOR4='" + feorSzám + "'";
            var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);



            try
            {
                conn.Open();
                MySql.Data.MySqlClient.MySqlDataReader dataReader = SQLCommand.ExecuteReader();
                dataReader.Read();
                string feorTemp = dataReader.GetString(0);
                conn.Close();
                return feorTemp;

            }
            catch (Exception ex)
            {
                Program.logger.Error("---Adatbázis olvasási hiba (FEOR)!---" + ex);
                MessageBox.Show("Adatbázis olvasási hiba (FEOR)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                conn.Close();
                return "#Hiba";
            }
        }

        private void MezőkValidálása(Control kontroll)
        {


            foreach (var item in kontroll.Controls)
            {
                if (item is Label)
                {
                    Label lb = (Label)item;
                    if (lb.Name == "") continue; //ha belekerülne véletlenül a scrollbar, hibát okozna ha ez nem lenne
                    if (lb.Name.Substring(0, 2) == "lb")
                    {
                        CímkeSzínBeállítás((Label)lb, true);
                    }
                }

                if (kontroll.HasChildren)
                {
                    foreach (Control childControl in kontroll.Controls)
                    {
                        MezőkValidálása(childControl);

                    }
                }
            }





        }

        private void ÁltalánosSzemélyiAdatokFrissítés()
        {
            formMentésDialógus.MentésMódVálasztás();
            if (formMentésDialógus.mód == "MM") return;


            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Properties.Settings.Default.felisz_db_ConnectionString;
            myConnectionString = Adatbázis.MyConnectionString();

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;

            try
            {
                conn.Open();

                string sql = "UPDATE SzemTorzs SET " +
                    "SzekhelyTelephelyID=@SzekhelyTelephelyID, " +
                    "EngedelyKor=@EngedelyKor, " +
                    "VezNev=@VezNev, " +
                    "UtoNev1=@UtoNev1, " +
                    "UtoNev2=@UtoNev2, " +
                    "SzulVezNev=@SzulVezNev, " +
                    "SzulUtoNev1=@SzulUtoNev1, " +
                    "SzulUtoNev2=@SzulUtoNev2, " +
                    "SzulDatum=@SzulDatum, " +
                    "SzulHely=@SzulHely, " +
                    "SzulOrszag=@SzulOrszag, " +
                    "Neme=@Neme, " +
                    "LakOrszag=@LakOrszag, " +
                    "LakIrSzam=@LakIrSzam, " +
                    "LakVaros=@LakVaros, " +
                    "LakKozt=@LakKozt, " +
                    "LakKoztJell=@LakKoztJell, " +
                    "LakHazSz=@LakHazSz, " +
                    "LakEpul=@LakEpul, " +
                    "LakLepcsH=@LakLepcsH, " +
                    "LakEmelet=@LakEmelet, " +
                    "LakAjto=@LakAjto, " +
                    "LakTavolsag=@LakTavolsag, " +
                    "SzemErvTol=@SzemErvTol, " +
                    "SzemErvIg=@SzemErvIg, " +
                    "AdoAzonosito=@AdoAzonosito, " +
                    "TajSzam=@TajSzam, " +
                    "AnyjaNeve=@AnyjaNeve, " +
                    "AllamPolg=@AllamPolg, " +
                    "MegvaltMunkFogy=@MegvaltMunkFogy, " +
                    "FoldAlattIonMunk=@FoldAlattIonMunk, " +
                    "Feor=@Feor, " +
                    "RogzFelh=@RogzFelh, " +
                    "RogzDatum=@RogzDatum " +
                    "WHERE SzemAzon='" + formMunkavállalóVálasztás.azon + "'";


                var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);


                SQLCommand.Parameters.Add("@SzekhelyTelephelyID", MySql.Data.MySqlClient.MySqlDbType.Int16);
                SQLCommand.Parameters["@SzekhelyTelephelyID"].Value = (cbFoglalkoztatásHelye.SelectedItem as FoglalkoztatásHelye).ID;


                SQLCommand.Parameters.Add("@EngedelyKor", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@EngedelyKor"].Value = tbEngedélykör.Text;

                SQLCommand.Parameters.Add("@VezNev", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@VezNev"].Value = tbVezetéknév.Text;

                SQLCommand.Parameters.Add("@UtoNev1", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@UtoNev1"].Value = tbUtónév1.Text;

                SQLCommand.Parameters.Add("@UtoNev2", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@UtoNev2"].Value = tbUtónév2.Text;

                SQLCommand.Parameters.Add("@SzulVezNev", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@SzulVezNev"].Value = tbSzülVezetéknév.Text;

                SQLCommand.Parameters.Add("@SzulUtoNev1", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@SzulUtoNev1"].Value = tbSzülUtónév1.Text;

                SQLCommand.Parameters.Add("@SzulUtoNev2", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@SzulUtoNev2"].Value = tbSzülUtónév2.Text;

                SQLCommand.Parameters.Add("@SzulDatum", MySql.Data.MySqlClient.MySqlDbType.Date);
                SQLCommand.Parameters["@SzulDatum"].Value = DateTime.Parse(tbSzületésDátum.Text);


                SQLCommand.Parameters.Add("@SzulHely", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@Szulhely"].Value = cbSzületésiHely.Text;

                SQLCommand.Parameters.Add("@SzulOrszag", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@SzulOrszag"].Value = (cbSzületésiOrszág.SelectedItem as Országkód).Kód;

                SQLCommand.Parameters.Add("@Neme", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@Neme"].Value = cbNeme.Text;

                SQLCommand.Parameters.Add("@LakOrszag", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@LakOrszag"].Value = (cbLakhelyOrszág.SelectedItem as Országkód).Kód;

                SQLCommand.Parameters.Add("@LakIrSzam", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@LakIrSzam"].Value = cbIrszám.Text;

                SQLCommand.Parameters.Add("@LakVaros", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@LakVaros"].Value = cbVáros.Text;

                SQLCommand.Parameters.Add("@LakKozt", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@LakKozt"].Value = cbKözterület.Text;

                SQLCommand.Parameters.Add("@LakKoztJell", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@LakKoztJell"].Value = tbKözterületJellege.Text;

                SQLCommand.Parameters.Add("@LakHazSz", MySql.Data.MySqlClient.MySqlDbType.Int16);
                SQLCommand.Parameters["@LakHazSz"].Value = tbHázszám.Text;

                SQLCommand.Parameters.Add("@LakEpul", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@LakEpul"].Value = tbÉpület.Text;

                SQLCommand.Parameters.Add("@LakLepcsH", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@LakLepcsH"].Value = tbLépcsőház.Text;

                SQLCommand.Parameters.Add("@LakEmelet", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@LakEmelet"].Value = tbEmelet.Text;

                SQLCommand.Parameters.Add("@LakAjto", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@LakAjto"].Value = tbAjtó.Text;

                SQLCommand.Parameters.Add("@LakTavolsag", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@LakTavolsag"].Value = tbTávolság.Text;

                SQLCommand.Parameters.Add("@SzemErvTol", MySql.Data.MySqlClient.MySqlDbType.Date);
                SQLCommand.Parameters["@SzemErvTol"].Value = DateTime.Now;

                SQLCommand.Parameters.Add("@SzemErvIg", MySql.Data.MySqlClient.MySqlDbType.Date);
                SQLCommand.Parameters["@SzemErvIg"].Value = new DateTime(2099, 1, 31);

                SQLCommand.Parameters.Add("@AdoAzonosito", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@AdoAzonosito"].Value = tbAdóazonosító.Text;

                SQLCommand.Parameters.Add("@TajSzam", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@TajSzam"].Value = tbTAJSzám.Text;

                SQLCommand.Parameters.Add("@AnyjaNeve", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@AnyjaNeve"].Value = tbAnyjaNeve.Text;

                SQLCommand.Parameters.Add("@AllamPolg", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@AllamPolg"].Value = (cbÁllampolgárság.SelectedItem as Országkód).Kód;

                SQLCommand.Parameters.Add("@MegvaltMunkFogy", MySql.Data.MySqlClient.MySqlDbType.VarChar);
                SQLCommand.Parameters["@MegvaltMunkFogy"].Value = cbMegVáltMunkFogy.Text.Substring(0, 1);

                SQLCommand.Parameters.Add("@FoldAlattIonMunk", MySql.Data.MySqlClient.MySqlDbType.VarChar);
                SQLCommand.Parameters["@FoldAlattIonMunk"].Value = cbFöldAlattIonMunk.Text.Substring(0, 1);

                SQLCommand.Parameters.Add("@Feor", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@Feor"].Value = cbFEOR.SelectedItem.ToString().Substring(0, 4);


                SQLCommand.Parameters.Add("@RogzFelh", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@RogzFelh"].Value = Properties.Settings.Default.utolsóFelhasználó;

                SQLCommand.Parameters.Add("@RogzDatum", MySql.Data.MySqlClient.MySqlDbType.Date);
                SQLCommand.Parameters["@RogzDatum"].Value = DateTime.Now;


                SQLCommand.ExecuteNonQuery();

                Funkciók.TopKonzolKiírás("Azonosítószám: " + tbAzonosítószám.Text + " Név: " + tbVezetéknév.Text + " " + tbUtónév1.Text + " " + tbUtónév2.Text + " általános személyi adatok frissítve! " + DateTime.Now.ToString());

                SQLCommand.Dispose();
            }
            catch (Exception ex)
            {
                Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Adatbázis írási hiba (Személyi alapadatok)!---" + ex);
                MessageBox.Show("Adatbázis írási hiba (Személyi alapadatok)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            conn.Close();



            if (formMentésDialógus.mód == "MB") this.Close();


        }

        private void tbSzülUtónév2_Validated(object sender, EventArgs e)
        {
            Funkciók.NévValidálás(lbSzülUtónév2, tbSzülUtónév2, null, true);
        }

        private void tbSzületésDátum_Validated(object sender, EventArgs e)
        {
            Funkciók.DátumValidálás(lbSzületésiDátum, tbSzületésDátum, tbAdóazonosító, lbAdóazonosító, false);

        }

        private void formSzemAdatok_KeyDown(object sender, KeyEventArgs e)
        {



            if (e.KeyCode == Keys.Insert)
            {

                if (tcSzemélyiAdatok.SelectedTab.Text == "Általános személyi adatok")
                {
                    if (MentésIndítható(tlpÁltalánosSzemélyiAdatok))
                    {
                        if (formMunkavállalóVálasztás.mód == "N") ÁltalánosSzemélyiAdatokMentés();
                        if (formMunkavállalóVálasztás.mód == "M") ÁltalánosSzemélyiAdatokFrissítés();

                    }
                    else
                    {
                        MessageBox.Show("A jelölt mezők kitöltése kötelező, illetve lehetséges hibákat tartalmazhatnak." + Environment.NewLine +
                                        "A mentés nem lehetséges!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }

                if (tcSzemélyiAdatok.SelectedTab.Text == "Hozzátartozók")
                {
                    if (MentésIndítható(tlpHozzátartozók_New))
                    {
                        if (formMunkavállalóVálasztás.mód == "M")
                        {
                            HozzátartozókMentés();
                            HozzátartozókBetöltése(int.Parse(tbAzonosítószám.Text));
                        }

                    }
                    else
                    {
                        MessageBox.Show("A jelölt mezők kitöltése kötelező, illetve lehetséges hibákat tartalmazhatnak." + Environment.NewLine +
                                        "A mentés nem lehetséges!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }


            }


        }

        private void HozzátartozókBetöltése(int SzemélyiAzon)
        {
            //if (tlpHozzátartozók.Visible == false) return;

            gpHozzátartozók.Visible = true;

            if (!Adatbázis.AdatbázisEllenőrzéseCég())
            {
                return;
            }


            string myConnectionString = Adatbázis.MyConnectionString();

            MySqlConnection conn;

            conn = new MySqlConnection(myConnectionString);
            conn.Open();


            string sql = @"SELECT VezNev, UtoNev1, UtoNev2, SzulDatum, Fogyatekos FROM SzemHozzaTart WHERE SzemAzon='" + SzemélyiAzon + "' ORDER BY VezNev, UtoNev1, UtoNev2";

            //public MySqlDataAdapter dataAdapter;



            try
            {
                MySqlDataAdapter dataAdapter;
                dataAdapter = new MySqlDataAdapter(sql, conn);
                DataTable dtRecord = new DataTable();
                dataAdapter.Fill(dtRecord);
                dgvHozzátartozók.DataSource = dtRecord;
                conn.Close();

                if (dgvHozzátartozók.Columns[0].HeaderText == "VezNev")
                {
                    for (int i = 0; i < dgvHozzátartozók.ColumnCount; i++)
                    {
                        switch (dgvHozzátartozók.Columns[i].HeaderText)
                        {

                            case "VezNev":
                                dgvHozzátartozók.Columns[i].HeaderText = "Vezetéknév";
                                dgvHozzátartozók.Columns[i].Width = 100;
                                break;
                            case "UtoNev1":
                                dgvHozzátartozók.Columns[i].HeaderText = "Utónév 1";
                                dgvHozzátartozók.Columns[i].Width = 100;
                                break;
                            case "UtoNev2":
                                dgvHozzátartozók.Columns[i].HeaderText = "Utónév 2";
                                dgvHozzátartozók.Columns[i].Width = 100;
                                break;
                            case "SzulDatum":
                                dgvHozzátartozók.Columns[i].HeaderText = "Születési dátum";
                                dgvHozzátartozók.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dgvHozzátartozók.Columns[i].Width = 70;
                                break;
                            case "Fogyatekos":
                                dgvHozzátartozók.Columns[i].HeaderText = "Fogyaték";
                                dgvHozzátartozók.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dgvHozzátartozók.Columns[i].Width = 70;
                                break;
                            default:
                                dgvHozzátartozók.Columns[i].HeaderText = "#HIÁNYZIK#";
                                dgvHozzátartozók.Columns[i].Width = 50;
                                break;
                        }


                    }
                }

            }
            catch (Exception ex)
            {

                Program.logger.Warn(Program.aktuálisCég + " " + Program.prefix + "---Sikertelen a hozzátartozói adatok betöltése!---" + ex);
                return;
            }

            gpHozzátartozók.Visible = false;

        }

        public static void ToolTippekBetöltése(Control controlSzuloNeve, ToolTip toolTipNeve)
        {

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Properties.Settings.Default.felisz_db_ConnectionString;
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;

            string sql = "SELECT * FROM ToolTip where ControlSzulo='" + controlSzuloNeve.Name + "'";
            var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);



            try
            {
                conn.Open();
                MySql.Data.MySqlClient.MySqlDataReader dataReader = SQLCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    ToolTipRekord toolTippek = new ToolTipRekord();
                    toolTippek.controlSzulo = dataReader.GetString(dataReader.GetOrdinal("ControlSzulo"));
                    toolTippek.controlNeve = dataReader.GetString(dataReader.GetOrdinal("ControlNeve"));
                    toolTippek.paragrafus = dataReader.GetInt16(dataReader.GetOrdinal("Paragrafus"));
                    toolTippek.paragrafusal = dataReader.GetString(dataReader.GetOrdinal("ParagrafusAl"));
                    toolTippek.egyediSzöveg = dataReader.GetString(dataReader.GetOrdinal("EgyediSzoveg"));
                    listToolTipRekords.Add(toolTippek);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                Program.logger.Error("---Adatbázis olvasási hiba (ToolTip)!---" + ex);
                MessageBox.Show("Adatbázis olvasási hiba (ToolTip)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                conn.Close();
            }

            //TEST
            ToolTippekBeállítása(controlSzuloNeve, toolTipNeve);

        }

        public static bool ToolTippekBeállítása(Control controlSzuloNeve, ToolTip toolTipNeve)
        {
            foreach (var item in controlSzuloNeve.Controls)
            {

                if (item is TextBox)
                {
                    TextBox tb = (TextBox)item;
                    ToolTipRekord toolTipTalálat = listToolTipRekords.Find(keres => keres.controlNeve == tb.Name);
                    if (toolTipTalálat != null)
                    {
                        if (toolTipTalálat.egyediSzöveg != "") toolTipNeve.SetToolTip(tb, toolTipTalálat.egyediSzöveg);
                        else toolTipNeve.SetToolTip(tb, MunkaTörvénykönyve.MTParagrafusLekérdezés(toolTipTalálat.paragrafus.ToString(), toolTipTalálat.paragrafusal));
                    }
                }

                if (item is ComboBox)
                {
                    ComboBox cb = (ComboBox)item;
                    ToolTipRekord toolTipTalálat = listToolTipRekords.Find(keres => keres.controlNeve == cb.Name);
                    if (toolTipTalálat != null)
                    {
                        if (toolTipTalálat.egyediSzöveg != "") toolTipNeve.SetToolTip(cb, toolTipTalálat.egyediSzöveg);
                        else toolTipNeve.SetToolTip(cb, MunkaTörvénykönyve.MTParagrafusLekérdezés(toolTipTalálat.paragrafus.ToString(), toolTipTalálat.paragrafusal));
                    }
                }


                if (controlSzuloNeve.HasChildren)
                {
                    foreach (Control childControl in controlSzuloNeve.Controls)
                    {
                        if (ToolTippekBeállítása(childControl, toolTipNeve) == false) return false;

                    }
                }
            }

            return true;

        }

        private void formSzemAdatok_Load(object sender, EventArgs e)
        {

            ToolTippekBetöltése(this, paragrafusTippek);

        }

        private void cbMegVáltMunkFogy_Validated(object sender, EventArgs e)
        {
            if (cbMegVáltMunkFogy.Text.Length > 0)
            {
                CímkeSzínBeállítás(lbMegVáltMunkFogy, true);
            }
            else
            {
                CímkeSzínBeállítás(lbMegVáltMunkFogy, false);
            }
        }

        private void cbFöldAlattIonMunk_Validated(object sender, EventArgs e)
        {
            if (cbFöldAlattIonMunk.Text.Length > 0)
            {
                CímkeSzínBeállítás(lbFöldAlattIon, true);
            }
            else
            {
                CímkeSzínBeállítás(lbFöldAlattIon, false);
            }
        }

        private void MunkavállalóTörlése(int SzemAzon)
        {




            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Properties.Settings.Default.felisz_db_ConnectionString;
            myConnectionString = Adatbázis.MyConnectionString();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;



            try
            {
                conn.Open();

                //Személyi adatok törlése
                string sql = "DELETE FROM SzemTorzs WHERE SzemAzon='" + SzemAzon.ToString() + "'";
                var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                SQLCommand.ExecuteNonQuery();

                //Hozzátartozók törlése
                sql = "DELETE FROM SzemHozzaTart WHERE SzemAzon='" + SzemAzon.ToString() + "'";
                SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                SQLCommand.ExecuteNonQuery();


                Funkciók.TopKonzolKiírás("Azonosítószám: " + tbAzonosítószám.Text + " Név: " + tbVezetéknév.Text + " " + tbUtónév1.Text + " " + tbUtónév2.Text + " munkavállaló véglegesen törölve! " + DateTime.Now.ToString());
                SQLCommand.Dispose();
            }
            catch (Exception ex)
            {
                Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Adatbázis írási hiba (Munkavállaló törlése)!---" + ex);
                MessageBox.Show("Adatbázis írási hiba (Munkavállaló törlése)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            conn.Close();


        }

        private void HozzátartozókMentés()
        {


            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Properties.Settings.Default.felisz_db_ConnectionString;
            myConnectionString = Adatbázis.MyConnectionString();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;



            try
            {
                conn.Open();




                string sql = "INSERT INTO SzemHozzaTart (" +
                    "SzemAzon, " +
                    "VezNev, " +
                    "UtoNev1, " +
                    "UtoNev2, " +
                    "SzulDatum, " +
                    "Fogyatekos, " +
                    "RogzFelh, " +
                    "RogzDatum) " +
                    "VALUES (" +
                    "@SzemAzon, " +
                    "@VezNev, " +
                    "@UtoNev1, " +
                    "@UtoNev2, " +
                    "@SzulDatum, " +
                    "@Fogyatekos, " +
                    "@RogzFelh, " +
                    "@RogzDatum)";


                var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                SQLCommand.Parameters.Add("@SzemAzon", MySql.Data.MySqlClient.MySqlDbType.Int16);
                SQLCommand.Parameters["@SzemAzon"].Value = tbAzonosítószám.Text;

                SQLCommand.Parameters.Add("@VezNev", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@VezNev"].Value = tbVezetéknévHozzátartozó.Text;

                SQLCommand.Parameters.Add("@UtoNev1", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@UtoNev1"].Value = tbUtónév1Hozzátartozó.Text;

                SQLCommand.Parameters.Add("@UtoNev2", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@UtoNev2"].Value = tbUtónév2Hozzátartozó.Text;

                SQLCommand.Parameters.Add("@SzulDatum", MySql.Data.MySqlClient.MySqlDbType.Date);
                SQLCommand.Parameters["@SzulDatum"].Value = DateTime.Parse(tbSzületésiDátumHozzátartozó.Text);

                SQLCommand.Parameters.Add("@Fogyatekos", MySql.Data.MySqlClient.MySqlDbType.VarChar);
                SQLCommand.Parameters["@Fogyatekos"].Value = cbFogyatékosságHozzátartozó.Text.Substring(0, 1);

                SQLCommand.Parameters.Add("@RogzFelh", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@RogzFelh"].Value = Properties.Settings.Default.utolsóFelhasználó;

                SQLCommand.Parameters.Add("@RogzDatum", MySql.Data.MySqlClient.MySqlDbType.Date);
                SQLCommand.Parameters["@RogzDatum"].Value = DateTime.Now;

                SQLCommand.ExecuteNonQuery();

                Funkciók.TopKonzolKiírás("Azonosítószám: " + tbAzonosítószám.Text + " Név: " + tbVezetéknév.Text + " " + tbUtónév1.Text + " " + tbUtónév2.Text + " hozzátartozója rögzítve! " + DateTime.Now.ToString());
                tbVezetéknévHozzátartozó.Text = "";
                tbUtónév1Hozzátartozó.Text = "";
                tbUtónév2Hozzátartozó.Text = "";
                tbSzületésiDátumHozzátartozó.Text = "";
                cbFogyatékosságHozzátartozó.Text = "";


                SQLCommand.Dispose();
            }
            catch (Exception ex)
            {
                Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Adatbázis írási hiba (Hozzátartozók)!---" + ex);
                MessageBox.Show("Adatbázis írási hiba (Hozzátartozók)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            conn.Close();





        }

        private void HozzátartozóTörlése(int SzemAzon)
        {




            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Properties.Settings.Default.felisz_db_ConnectionString;
            myConnectionString = Adatbázis.MyConnectionString();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;



            try
            {
                conn.Open();

                //Személyi adatok törlése
                string sql = "DELETE FROM SzemHozzaTart WHERE SzemAzon='" + SzemAzon.ToString() + "' " +
                    "AND VezNev='" + hozzáTartVezetéknév + "' " +
                    "AND UtoNev1='" + hozzáTartUtónév1 + "' " +
                    "AND UtoNev2='" + hozzáTartUtónév2 + "'";
                var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                SQLCommand.ExecuteNonQuery();


                Funkciók.TopKonzolKiírás("Azonosítószám: " + tbAzonosítószám.Text + " Név: " + tbVezetéknév.Text + " " + tbUtónév1.Text + " " + tbUtónév2.Text + " hozzátartozója törölve! " + DateTime.Now.ToString());
                SQLCommand.Dispose();
            }
            catch (Exception ex)
            {
                Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Adatbázis írási hiba (Hozzátartozó törlése)!---" + ex);
                MessageBox.Show("Adatbázis írási hiba (Hozzátartozó törlése)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            conn.Close();


        }

        private void btÁltalánosSzemAdatokMentés_Click(object sender, EventArgs e)
        {

            if (MentésIndítható(tlpÁltalánosSzemélyiAdatok))
            {
                if (formMunkavállalóVálasztás.mód == "M") ÁltalánosSzemélyiAdatokFrissítés();
                if (formMunkavállalóVálasztás.mód == "N") ÁltalánosSzemélyiAdatokMentés();
                //Kalkulált szabadság újraszámolása

            }
            else
            {
                MessageBox.Show("A jelölt mezők kitöltése kötelező, illetve lehetséges hibákat tartalmazhatnak." + Environment.NewLine +
                                "A mentés nem lehetséges!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void btHozzTartMentes_Click(object sender, EventArgs e)
        {
            if (formMunkavállalóVálasztás.mód == "N")
            {
                MessageBox.Show("Hozzátartozót addig nem lehet rögzíteni," + Environment.NewLine + "míg a személyi alapadatok nincsnenek elmentve!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            //Újra validálás mivel eddig nem figyeltük az üres mezőket
            Funkciók.NévValidálás(lbVezetéknévHozzátartozó, tbVezetéknévHozzátartozó, null, false);
            Funkciók.NévValidálás(lbUtónév1Hozzátartozó, tbUtónév1Hozzátartozó, null, false);
            Funkciók.DátumValidálás(lbSzületésiDátumHozzátartozó, tbSzületésiDátumHozzátartozó, null, null, false);
            if (cbFogyatékosságHozzátartozó.Text.Length == 0) CímkeSzínBeállítás(lbFogyatékosságHozzátartozó, false);


            if (MentésIndítható(tlpHozzátartozók))
            {
                if (formMunkavállalóVálasztás.mód == "M")
                {
                    HozzátartozókMentés();
                    HozzátartozókBetöltése(int.Parse(tbAzonosítószám.Text));
                    //Ez majf kijön! Törölni


                }
            }
            else
            {
                MessageBox.Show("A jelölt mezők kitöltése kötelező, illetve lehetséges hibákat tartalmazhatnak." + Environment.NewLine +
                                "A mentés nem lehetséges!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void tbHozzáVezetéknév_Validated_1(object sender, EventArgs e)
        {
            Funkciók.NévValidálás(lbVezetéknévHozzátartozó, tbVezetéknévHozzátartozó, null, true);
        }

        private void tbHozzáUtónév1_Validated_1(object sender, EventArgs e)
        {
            Funkciók.NévValidálás(lbUtónév1Hozzátartozó, tbUtónév1Hozzátartozó, null, true);
        }

        private void tbHozzáUtónév2_Validated_1(object sender, EventArgs e)
        {
            Funkciók.NévValidálás(lbUtónév2Hozzátartozó, tbUtónév2Hozzátartozó, null, true);
        }

        private void tbSzülDátumHozzá_Validated(object sender, EventArgs e)
        {
            Funkciók.DátumValidálás(lbSzületésiDátumHozzátartozó, tbSzületésiDátumHozzátartozó, null, null, true);
        }

        private void cbFogyatékHozzá_Validated_1(object sender, EventArgs e)
        {
            if (cbFogyatékosságHozzátartozó.Text.Length > 0)
            {
                CímkeSzínBeállítás(lbFogyatékosságHozzátartozó, true);
            }
            else
            {
                CímkeSzínBeállítás(lbFogyatékosságHozzátartozó, false);
            }
        }

        private void dgvHozzátartozó_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                btHozzátartozóTörlés.Visible = false;
                return;
            }

            btHozzátartozóTörlés.Visible = true;
            hozzáTartVezetéknév = dgvHozzátartozók[0, e.RowIndex].Value.ToString();
            hozzáTartUtónév1 = dgvHozzátartozók[1, e.RowIndex].Value.ToString();
            hozzáTartUtónév2 = dgvHozzátartozók[2, e.RowIndex].Value.ToString();
        }

        private void btHozzTartTörlés_Click_1(object sender, EventArgs e)
        {
            formFigyelmeztetésÁltalános figyelem = new formFigyelmeztetésÁltalános(
         "FIGYELEM! A hozzátartozó törlésére készül!" + Environment.NewLine +
         "Valóban ezt akarja!?",
         "Figyelem, a hozzátartozó törlésére készül!"
         );

            DialogResult válasz = figyelem.ShowDialog();
            if (válasz == DialogResult.OK)
            {
                HozzátartozóTörlése(formMunkavállalóVálasztás.azon);
                HozzátartozókBetöltése(formMunkavállalóVálasztás.azon);
                btHozzátartozóTörlés.Visible = false;
            }
            TTS.TTS_RSS_Resume();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbMegválltHatározatÉrv_Validated(object sender, EventArgs e)
        {
            Funkciók.DátumValidálás(lbFogyÁllapotKezdDátum, tbFogyÁllapotKezdDátum, null, null, false);
        }

        private void btTartózkodásiHelyMegnyit_Click(object sender, EventArgs e)
        {
            // gbTartózkodásiHely.Visible = !gbTartózkodásiHely.Visible;
            //GombMegnyitásBezárásVáltás(sender);
            KiegPanelekVezérlése(tlpOszlop3, tlpKiegGombok, sender);

        }



        private void btHozzátartozókMegnyit_Click(object sender, EventArgs e)
        {
            // gpHozzátartozó.Visible = !gpHozzátartozó.Visible;
            //GombMegnyitásBezárásVáltás(sender);
            KiegPanelekVezérlése(tlpOszlop3, tlpKiegGombok, sender);

        }

        private void btMegváltozottMunkaképességMegnyit_Click(object sender, EventArgs e)
        {
            //gbMegváltozottMunkaképesség.Visible = !gbMegváltozottMunkaképesség.Visible;
            //GombMegnyitásBezárásVáltás(sender);
            KiegPanelekVezérlése(tlpOszlop3, tlpKiegGombok, sender);
        }

        private void GombMegnyitásBezárásVáltás(object gomb)
        {
            Button temp = (Button)gomb;
            if (temp.Text == "MEGNYITÁS") temp.Text = "BEZÁRÁS";
            else temp.Text = "MEGNYITÁS";
        }

        private void btSzakszervezetMegnyit_Click(object sender, EventArgs e)
        {
            //gbSzakszervezet.Visible = !gbSzakszervezet.Visible;
            //GombMegnyitásBezárásVáltás(sender);
            KiegPanelekVezérlése(tlpOszlop3, tlpKiegGombok, sender);
        }

        private void KiegPanelekVezérlése(Control panel, Control gombPanel, object küldőGombNeve)
        {
            //Az oszloppanelen szereplő csoportok automatikus bezárása, csak a meghívott csoport megnyitása, illetve a 
            //HozzátartozókBetöltése gombok szövegének változatása
            //A gomb tag-jében tárolva a vezérelendő csoport




            foreach (var item in panel.Controls)
            {
                if (item is GroupBox)
                {
                    Button küldőGomb = (Button)küldőGombNeve;
                    GroupBox gb = (GroupBox)item;
                    if (gb.Name != küldőGomb.Tag.ToString()) gb.Visible = false;
                    else gb.Visible = true;
                    if (gb.Name == küldőGomb.Tag.ToString() && küldőGomb.Text == "BEZÁRÁS") gb.Visible = false;
                }

            }


            foreach (var item in gombPanel.Controls)
            {
                if (item is Button)
                {
                    Button küldőGomb = (Button)küldőGombNeve;
                    Button bt = (Button)item;
                    if (bt.Name == küldőGomb.Name && küldőGomb.Text != "BEZÁRÁS") bt.Text = "BEZÁRÁS";
                    else bt.Text = "MEGNYITÁS";
                }
            }




        }
    }

}
