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



            if (tbVezetéknév.Text.Length >= 2 && !Funkciók.UtolsóKarakterSzóköz(tbVezetéknév) && !Funkciók.StringTartalmazSzámot(tbVezetéknév.Text))
            {
                CímkeSzínBeállítás(lbVezetéknév, true);
                if (tbSzülVezetéknév.Text == "") tbSzülVezetéknév.Text = tbVezetéknév.Text;
            }
            else
            {
                CímkeSzínBeállítás(lbVezetéknév, false);
            }
        }

        private void tbUtónév1_Validated(object sender, EventArgs e)
        {
            if (tbUtónév1.Text.Length >= 2 && !Funkciók.UtolsóKarakterSzóköz(tbUtónév1) && !Funkciók.StringTartalmazSzámot(tbUtónév1.Text))
            {
                CímkeSzínBeállítás(lbUtónév1, true);
                if (tbSzülUtónév1.Text == "") tbSzülUtónév1.Text = tbUtónév1.Text;
            }
            else
            {
                CímkeSzínBeállítás(lbUtónév1, false);
            }
        }

        private void tbSzülVezetéknév_Validated(object sender, EventArgs e)
        {
            if (tbSzülVezetéknév.Text.Length >= 2 && !Funkciók.UtolsóKarakterSzóköz(tbUtónév2) && !Funkciók.StringTartalmazSzámot(tbSzülVezetéknév.Text))
            {
                CímkeSzínBeállítás(lbSzülVezetéknév, true);
            }
            else
            {
                CímkeSzínBeállítás(lbSzülVezetéknév, false);
            }
        }

        private void tbSzülUtónév1_Validated(object sender, EventArgs e)
        {
            if (tbSzülUtónév1.Text.Length >= 2 && !Funkciók.UtolsóKarakterSzóköz(tbSzülUtónév1) && !Funkciók.StringTartalmazSzámot(tbSzülUtónév1.Text))
            {
                CímkeSzínBeállítás(lbSzülUtónév1, true);
            }
            else
            {
                CímkeSzínBeállítás(lbSzülUtónév1, false);
            }
        }

        private void tbUtónév2_Validated(object sender, EventArgs e)
        {
            if (!Funkciók.UtolsóKarakterSzóköz(tbUtónév2) && !Funkciók.StringTartalmazSzámot(tbUtónév2.Text))
            {
                CímkeSzínBeállítás(lbUtónév2, true);
                if (tbSzülUtónév2.Text == "") tbSzülUtónév2.Text = tbUtónév2.Text;
            }
            else
            {
                CímkeSzínBeállítás(lbUtónév2, false);
            }




        }

        private void lbIrszám_Validating(object sender, CancelEventArgs e)
        {
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
            if (tbAnyjaNeve.Text.Length >= 2 && !Funkciók.UtolsóKarakterSzóköz(tbAnyjaNeve) && !Funkciók.StringTartalmazSzámot(tbAnyjaNeve.Text))
            {
                CímkeSzínBeállítás(lbAnyjaNeve, true);
            }
            else
            {
                CímkeSzínBeállítás(lbAnyjaNeve, false);
            }
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
            //Form formSzemKi = new formSzemKiválaszt();
            DialogResult dialogResult = formSzemKi.ShowDialog();


            if (dialogResult == DialogResult.Cancel) this.Close();
            if (formMunkavállalóVálasztás.mód == "M") SzemélyiAdatokBetöltése();




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
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            myConnectionString = Adatbázis.MyConnectionString();




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

                SQLCommand.Parameters.Add("@AnyjaNeve", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@AnyjaNeve"].Value = tbAnyjaNeve.Text;

                SQLCommand.Parameters.Add("@AllamPolg", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@AllamPolg"].Value = (cbÁllampolgárság.SelectedItem as Országkód).Kód;

                SQLCommand.Parameters.Add("@Feor", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@Feor"].Value = (cbFEOR.SelectedItem as FEOR).Feor4;


                SQLCommand.Parameters.Add("@RogzFelh", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@RogzFelh"].Value = Properties.Settings.Default.utolsóFelhasználó;

                SQLCommand.Parameters.Add("@RogzDatum", MySql.Data.MySqlClient.MySqlDbType.Date);
                SQLCommand.Parameters["@RogzDatum"].Value = DateTime.Now;

                SQLCommand.ExecuteNonQuery();



                SQLCommand.Dispose();
            }
            catch (Exception ex)
            {
                Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Adatbázis írási hiba (Személyi alapadatok)!---" + ex);
                MessageBox.Show("Adatbázis írási hiba (Személyi alapadatok)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            conn.Close();

            Funkciók.TopKonzolKiírás("Azonosítószám: " + tbAzonosítószám.Text + " Név: " + tbVezetéknév.Text + " " + tbUtónév1.Text + " " + tbUtónév2.Text + " általános személyi adatok mentve! " + DateTime.Now.ToString());
            if (formMentésDialógus.mód == "MB") this.Close();
            if (formMentésDialógus.mód == "MF") formMunkavállalóVálasztás.mód = "M";

        }

        private void btAktualizálás_Click(object sender, EventArgs e)
        {



            if (MentésIndítható(tlpÁltalánosSzemélyiAdatok))
            {
                if (formMunkavállalóVálasztás.mód == "M") ÁltalánosSzemélyiAdatokFrissítés();
                if (formMunkavállalóVálasztás.mód == "N") ÁltalánosSzemélyiAdatokMentés();

            }
            else
            {
                MessageBox.Show("A jelölt mezők kitöltése kötelező, illetve lehetséges hibákat tartalmazhatnak." + Environment.NewLine +
                                "A mentés nem lehetséges!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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




                string sql = "select * from SzemTorzs where SzemAzon=" + formMunkavállalóVálasztás.azon;
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
                    tbEngedélykör.Text = dataReader.GetString(dataReader.GetOrdinal("EngedelyKor"));


                    cbFEOR.Items.Add(dataReader.GetString(dataReader.GetOrdinal("Feor")));
                    string tempFeor = dataReader.GetString(dataReader.GetOrdinal("Feor")) + " - " + FeorLeírásLekérdezés(dataReader.GetString(dataReader.GetOrdinal("Feor")));
                    cbFEOR.Items.Add(tempFeor);
                    cbFEOR.SelectedItem = tempFeor;

                    tbAdóazonosító.Text = dataReader.GetString(dataReader.GetOrdinal("AdoAzonosito"));
                    tbTAJSzám.Text = dataReader.GetString(dataReader.GetOrdinal("TajSzam"));
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
            ÁltalánosSzemélyiAdatokValidálása();

        }

        private void tbEmelet_Validated(object sender, EventArgs e)
        {
        }

        private void tbAjtó_Validated(object sender, EventArgs e)
        {
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

        private void ÁltalánosSzemélyiAdatokValidálása()
        {
            //Adatok betöltése után minden mező érvényességének beállítása, engedélyezése, mivel a mentés elött már validálva lettek.
            foreach (Control groupitem in tlpÁltalánosSzemélyiAdatok.Controls)
            {
                foreach (Control tlpitem in groupitem.Controls)
                {
                    foreach (Control item in tlpitem.Controls)
                    {
                        if (item.Name.Substring(0, 2) == "lb")
                        {
                            CímkeSzínBeállítás((Label)item, true);
                        }
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
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
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

                SQLCommand.Parameters.Add("@Feor", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@Feor"].Value = cbFEOR.SelectedItem.ToString().Substring(0, 4);


                SQLCommand.Parameters.Add("@RogzFelh", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@RogzFelh"].Value = Properties.Settings.Default.utolsóFelhasználó;

                SQLCommand.Parameters.Add("@RogzDatum", MySql.Data.MySqlClient.MySqlDbType.Date);
                SQLCommand.Parameters["@RogzDatum"].Value = DateTime.Now;


                SQLCommand.ExecuteNonQuery();



                SQLCommand.Dispose();
            }
            catch (Exception ex)
            {
                Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Adatbázis írási hiba (Személyi alapadatok)!---" + ex);
                MessageBox.Show("Adatbázis írási hiba (Személyi alapadatok)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            conn.Close();

            Funkciók.TopKonzolKiírás("Azonosítószám: " + tbAzonosítószám.Text + " Név: " + tbVezetéknév.Text + " " + tbUtónév1.Text + " " + tbUtónév2.Text + " általános személyi adatok mentve! " + DateTime.Now.ToString());

            if (formMentésDialógus.mód == "MB") this.Close();


        }

        private void tbSzülUtónév2_Validated(object sender, EventArgs e)
        {
            if (!Funkciók.UtolsóKarakterSzóköz(tbSzülUtónév2) && !Funkciók.StringTartalmazSzámot(tbSzülUtónév2.Text))
            {
                CímkeSzínBeállítás(lbSzülUtónév2, true);
            }
            else
            {
                CímkeSzínBeállítás(lbSzülUtónév2, false);
            }
        }



        private void tbSzületésDátum_Validated(object sender, EventArgs e)
        {




            if (Funkciók.DátumFormázás(tbSzületésDátum.Text).ToString("yyyy.MM.dd") != DateTime.MinValue.ToString("yyyy.MM.dd"))
            {
                tbSzületésDátum.Text = Funkciók.DátumFormázás(tbSzületésDátum.Text).ToString("yyyy.MM.dd");
                CímkeSzínBeállítás(lbSzületésiDátum, true);

                if (DateTime.Parse(tbSzületésDátum.Text) < DateTime.Now.AddYears(-16))
                {
                    tbAdóazonosító.Enabled = true; //az adószám ellőnrzése csak a szül. dátum megadásával lehetséges
                    CímkeSzínBeállítás(lbSzületésiDátum, true);

                }
                else
                {
                    if (DateTime.Parse(tbSzületésDátum.Text) <= DateTime.Now)
                    {
                        TTS.TTS_Stop();
                        TTS.TTS_Play("Figyelem! Kiskorúak foglalkoztatását a törvény bünteti!");
                        MessageBox.Show("Kiskorúak foglalkoztatását a törvény bünteti!" + Environment.NewLine +
                            "A 16. életévét betöltött de 18 évnél fiatalabb személy is" + Environment.NewLine +
                            "csupán törvényes képviselője hozzájárulása birtokában" + Environment.NewLine +
                            "köthet érvényesen munkaszerződést!"
                            , "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        tbAdóazonosító.Enabled = false;
                        CímkeSzínBeállítás(lbSzületésiDátum, false);
                    }
                }

                if (DateTime.Parse(tbSzületésDátum.Text) >= DateTime.Now) CímkeSzínBeállítás(lbSzületésiDátum, false);


            }
            else CímkeSzínBeállítás(lbSzületésiDátum, false);
        }

        private void formSzemAdatok_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Insert)
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


        }



        private void tcSzemélyiAdatok_Click(object sender, EventArgs e)
        {
            HozzátartozókBetöltése(formMunkavállalóVálasztás.azon);
        }

        private void HozzátartozókBetöltése(int SzemélyiAzon)
        {
            if (!Adatbázis.AdatbázisEllenőrzéseCég())
            {
                return;
            }


            string myConnectionString = Adatbázis.MyConnectionString();
                
            MySqlConnection conn;

            conn = new MySqlConnection(myConnectionString);
            conn.Open();


            string sql = @"SELECT VezNev, UtoNev1, UtoNev2, SzulDatum FROM SzemHozzaTart WHERE SzemAzon='" + SzemélyiAzon + "' ORDER BY VezNev, UtoNev1, UtoNev2";

            //public MySqlDataAdapter dataAdapter;



            try
            {
                MySqlDataAdapter dataAdapter;
                dataAdapter = new MySqlDataAdapter(sql, conn);
                DataTable dtRecord = new DataTable();
                dataAdapter.Fill(dtRecord);
                dgvHozzátartozó.DataSource = dtRecord;
                conn.Close();

                if (dgvHozzátartozó.Columns[0].HeaderText == "VezNev")
                {
                    for (int i = 0; i < dgvHozzátartozó.ColumnCount; i++)
                    {
                        switch (dgvHozzátartozó.Columns[i].HeaderText)
                        {

                            case "VezNev":
                                dgvHozzátartozó.Columns[i].HeaderText = "Vezetéknév";
                                dgvHozzátartozó.Columns[i].Width = 100;
                                break;
                            case "UtoNev1":
                                dgvHozzátartozó.Columns[i].HeaderText = "Utónév 1";
                                dgvHozzátartozó.Columns[i].Width = 100;
                                break;
                            case "UtoNev2":
                                dgvHozzátartozó.Columns[i].HeaderText = "Utónév 2";
                                dgvHozzátartozó.Columns[i].Width = 100;
                                break;
                            case "SzulDatum":
                                dgvHozzátartozó.Columns[i].HeaderText = "Születési dátum";
                                dgvHozzátartozó.Columns[i].Width = 100;
                                break;
                            default:
                                dgvHozzátartozó.Columns[i].HeaderText = "#HIÁNYZIK#";
                                dgvHozzátartozó.Columns[i].Width = 50;
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


        }
    }
}
