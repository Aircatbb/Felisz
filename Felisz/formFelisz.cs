﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;



namespace Felisz
{
    public partial class formFelisz : Form
    {


        public static bool engedélyezve = false;

        public formFelisz()
        {
            InitializeComponent();
            DesignTestreszabása();

        }



        private void DesignTestreszabása()
        {
            panelAdminSubMenu.Visible = false;
            panelHRSubMenu.Visible = false;
            panelExportImportSubMenu.Visible = false;


        }

        private void AlmenükElrejtése()
        {
            if (panelHRSubMenu.Visible == true)
            {
                panelHRSubMenu.Visible = false;
            }

            if (panelAdminSubMenu.Visible == true)
            {
                panelAdminSubMenu.Visible = false;
            }

            if (panelExportImportSubMenu.Visible == true)
            {
                panelExportImportSubMenu.Visible = false;
            }
        }

        private void AlmenükLetiltásaMind()
        {
            panelAdminSubMenu.Enabled = false;
            btAdmin.Enabled = false;

            panelExportImportSubMenu.Enabled = false;
            btExportImportAdatokKezelese.Enabled = false;

            panelHRSubMenu.Enabled = false;
            btHR.Enabled = false;
        }

        private void AlmenükEngedélyezéseMind()
        {
            panelAdminSubMenu.Enabled = true;
            btAdmin.Enabled = true;

            panelExportImportSubMenu.Enabled = true;
            btExportImportAdatokKezelese.Enabled = true;

            panelHRSubMenu.Enabled = true;
            btHR.Enabled = true;
        }


        private void AlmenükMegjelenítése(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                AlmenükElrejtése();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btAdminAdatokKezelése_Click(object sender, EventArgs e)
        {
            alprogramMegnyitása(new formGlobalAdmin());
        }

        private void btHRSzemélyek_Click(object sender, EventArgs e)
        {
            AlmenükElrejtése();
        }

        private void btHRMunkakörök_Click(object sender, EventArgs e)
        {
            AlmenükElrejtése();
        }

        private void btHRMunkaidő_Click(object sender, EventArgs e)
        {
            AlmenükElrejtése();
        }

        private void btHRFigyelmeztetések_Click(object sender, EventArgs e)
        {
            AlmenükElrejtése();
        }

        private void btHRJelentkezők_Click(object sender, EventArgs e)
        {
            AlmenükElrejtése();
        }

        private void btHRKimutatások_Click(object sender, EventArgs e)
        {
            AlmenükElrejtése();
        }

        private void btHRUtiköltségElszámolás_Click(object sender, EventArgs e)
        {
            AlmenükElrejtése();
        }

        private void btHRNettóBruttóKalkulátor_Click(object sender, EventArgs e)
        {
            AlmenükElrejtése();
        }


        private void btAdmin_Click(object sender, EventArgs e)
        {
            AlmenükMegjelenítése(panelAdminSubMenu);
        }

        private void btHR_Click(object sender, EventArgs e)
        {
            AlmenükMegjelenítése(panelHRSubMenu);
        }

        private void btFelhasználó_Click(object sender, EventArgs e)
        {
            AlmenükMegjelenítése(panelExportImportSubMenu);
        }

        private void btFelhasználóAdatokKezelése_Click_1(object sender, EventArgs e)
        {
            AlmenükElrejtése();
        }



        private void pbFormClose_MouseEnter(object sender, EventArgs e)
        {
            pbFormClose.BackColor = Color.Gray;
        }

        private void pbFormClose_MouseLeave(object sender, EventArgs e)
        {
            pbFormClose.BackColor = Color.Transparent;
        }

        private void pbFormMaximize_MouseEnter(object sender, EventArgs e)
        {
            pbFormMaximize.BackColor = Color.Gray;
        }

        private void pbFormMaximize_MouseLeave(object sender, EventArgs e)
        {
            pbFormMaximize.BackColor = Color.Transparent;
        }

        private void pbFormMinimize_MouseEnter(object sender, EventArgs e)
        {
            pbFormMinimize.BackColor = Color.Gray;
        }

        private void pbFormMinimize_MouseLeave(object sender, EventArgs e)
        {
            pbFormMinimize.BackColor = Color.Transparent;
        }

        private void pbFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbFormMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pbFormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void timerHáttér_Tick(object sender, EventArgs e)
        {
            Program.aktuálisHáttér = DateTime.Now.Second;
            ScoreHáttérFrissítése();
        }


        private Form aktivForm = null;
        private void alprogramMegnyitása(Form childForm)
        {
            if (aktivForm != null) aktivForm.Close();
            aktivForm = childForm;
            childForm.TopLevel = false;

            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelHáttér.Controls.Add(childForm);
            panelHáttér.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void btHRMunkaszerződés_Click(object sender, EventArgs e)
        {
            alprogramMegnyitása(new Formok.formSzemAdatok());

        }

        private void btHRMunkakörök_Click_1(object sender, EventArgs e)
        {
            alprogramMegnyitása(new formBejelentkezés());

        }

        private void ScoreHáttérFrissítése()
        {
            //Score háttérkép aktualizálása
            switch (Program.aktuálisHáttér)

            {
                case int n when (n >= 0 && n <= 8):
                    pictureScore.BackgroundImage = Properties.Resources.Cloud1;
                    break;
                case int n when (n >= 9 && n <= 15):
                    pictureScore.BackgroundImage = Properties.Resources.Cloud2;
                    break;
                case int n when (n >= 16 && n <= 22):
                    pictureScore.BackgroundImage = Properties.Resources.Cloud3;
                    break;
                case int n when (n >= 23 && n <= 29):
                    pictureScore.BackgroundImage = Properties.Resources.Cloud4;
                    break;
                case int n when (n >= 30 && n <= 37):
                    pictureScore.BackgroundImage = Properties.Resources.Cloud5;
                    break;
                case int n when (n >= 38 && n <= 45):
                    pictureScore.BackgroundImage = Properties.Resources.Cloud6;
                    break;
                case int n when (n >= 46 && n <= 53):
                    pictureScore.BackgroundImage = Properties.Resources.Cloud7;
                    break;
                case int n when (n >= 54 && n <= 60):
                    pictureScore.BackgroundImage = Properties.Resources.Cloud8;
                    break;
            }

        }

        private void formFelisz_Load(object sender, EventArgs e)
        {
            Inicializálás();
            Program.logger.Info("Program inicializálása kész");

        }

        private void Inicializálás()
        {

            //TEST
            




            //Score frissítés (timer) indítása
            ScoreHáttérFrissítése();

            //RSS beolvasás indítása
            timerRSS_Tick(null, null);




            //Licenc és jogosultság
            Funkciók.LicencAktiválás(); //Amenyiben nem lenne még aktiválva a program

            //Licenckód ellenőrzése
            if (Funkciók.LicencEllenőrzés() != true) MenükLetiltása();

            //Dátum ellenőrzése
            if (Funkciók.DátumEllenőrzés() != true) MenükLetiltása();

            //MT betöltése
            if (!MunkaTörvénykönyve.MTBetöltése()) MessageBox.Show("Hiba történt a Munka Törvénykönyve betöltésekor," + Environment.NewLine + "ennélkül a program csak csökkentett módban működik!", "Hiba");

            //Országkódok, Irszám, Város, Utca DB betöltése a memóriába
            Thread threadOIVU_DB_Betöltés = new Thread(new ThreadStart(Adatbázis.SzemAdatok_AdatokMemóriábaOlvasása));
            threadOIVU_DB_Betöltés.Start();

            //Bejelentkezés
            Form form = new formBejelentkezés();
            DialogResult dialogResult = form.ShowDialog();
            if (Program.aktuálisFelhasználó == "") Application.Exit();
            //Jelszó módosítás szükséges (pl. első belépés (adatbázisban ElsoBe=true), vagy egyszerűen a felhasználó jelszóváltoztatásának kikényszerítése)
            if (Funkciók.JelszóÉrvényességEllenőrzése() == true)
            {
                int cnt = 0;
                while (Funkciók.JelszóMódosítás(true) != true)
                {
                    cnt++;
                    if (cnt >= 3)
                    {
                        Application.Exit();
                        Environment.Exit(69);
                    }
                }
            }




            //Menük láthatóságának beállítása a jogosultságok alapján
            #region Menük láthatóságának beállítása a jogosultságok alapján
            btKijelentkezés.Visible = true;
            btJelszóVált.Visible = true;

            List<String> Jogosultságok = new List<string>();
            Funkciók.MenüJogosultságok(Program.aktuálisFelhasználó, ref Jogosultságok);


            Control[] btJog;
            foreach (string jogGomb in Jogosultságok)
            {
                btJog = this.Controls.Find(jogGomb, true);
                btJog[0].Visible = true;
            }

            //HR menü méretének beállítása
            int countHR = 0;
            foreach (Control item in panelHRSubMenu.Controls)
            {
                if (item.Name.Contains("btHR") && item.Visible == true)
                {
                    countHR++;
                }
            }
            panelHRSubMenu.Height = countHR * 40;

            //Admin menü méretének beállítása
            int countAdmin = 0;
            foreach (Control item in panelAdminSubMenu.Controls)
            {
                if (item.Name.Contains("btAdmin") && item.Visible == true)
                {
                    countAdmin++;
                }
            }
            panelAdminSubMenu.Height = countAdmin * 40;

            //Export \ Import menü méretének beállítása
            int countExpImp = 0;
            foreach (Control item in panelExportImportSubMenu.Controls)
            {
                if (item.Name.Contains("btExportImport") && item.Visible == true)
                {
                    countExpImp++;
                }
            }
            panelExportImportSubMenu.Height = countExpImp * 40;

            #endregion


            //lbFelhasználó.Text = "Felhasználó: " +  Environment.UserDomainName + @"\" + Environment.UserName;
            lbFelhasználó.Text = "Felhasználó: " + Program.aktuálisFelhasználóNév;


            //Verzóváltozás értesítés
            Funkciók.VerzióVáltozásLog();

        }

        private void MenükLetiltása()
        {
            btHR.Enabled = false;
            panelHRSubMenu.Enabled = false;
            btExportImport.Enabled = false;
            panelExportImportSubMenu.Enabled = false;
        }

        private void timerRSS_Tick(object sender, EventArgs e)
        {


            if (Properties.Settings.Default.RSSUrl == "")
            {
                timerHáttér.Enabled = false;
            }
            RSSPost rs = null;
            rs = RSSFeed.RSSPostLekérése();

            if (rs != null)
            {
                llbRSS.Text = rs.Cím.ToString().Trim(' ');
                llbRSS.Links.Clear();
                llbRSS.Links.Add(0, rs.Cím.Length, rs.Url);
            }
            else
            {
                llbRSS.Text = "";
            }

        }

        private void llbRSS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void btGlobalAdminbeállítások_Click(object sender, EventArgs e)
        {
            alprogramMegnyitása(new formGlobalAdmin());
        }

        private void menüGombok1_Click(object sender, EventArgs e)
        {
            alprogramMegnyitása(new formMunkaTörvénykönyve());
        }

        private void panelTopMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btHRKalkulátor_Click(object sender, EventArgs e)
        {
            alprogramMegnyitása(new formKalkulátor());
        }

        private void btKijelentkezés_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btHRJelentkezok_Click(object sender, EventArgs e)
        {

        }

        private void btJelszóVált_Click(object sender, EventArgs e)
        {
            if (Funkciók.JelszóMódosítás(false) != true) btJelszóVált.PerformClick();


        }

        private void btAdminAlapBeallitasok_Click(object sender, EventArgs e)
        {
            alprogramMegnyitása(new formAlapbeállítások());
        }

        private void menüGombok1_Click_1(object sender, EventArgs e)
        {
            alprogramMegnyitása(new formFelhasználók());
        }

        private void btHRMunkaszerzodesModositasa_Click(object sender, EventArgs e)
        {

        }
    }

}