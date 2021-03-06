using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;



namespace Felisz
{

    public partial class formAlapbeállítások : Form
    {
        public string licDB = "---Üres---";
        public MySqlConnection conn;
        public string myConnectionString;
        public MySqlDataAdapter dataAdapter;
        public MySqlCommandBuilder cmdBuilder;
        public DataSet ds = new DataSet();
        public DataSet changes;

        public formAlapbeállítások()
        {
            InitializeComponent();
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

        private void btAktualizálás_Click(object sender, EventArgs e)
        {
            if (!Adatbázis.AdatbázisEllenőrzéseMain())
            {
                Console.WriteLine(Program.aktuálisCég + " " + Program.prefix + "---Nincs DB kapcsolat, licencaktualizálás meghiúsult!");
                return;
            }

            //DB-ben tárolt licenckód összevetése a megadott kóddal
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Adatbázis.MyConnectionString();

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            string sql = "SELECT Licenc, Aktiv FROM Licenc WHERE Aktiv=1 AND Licenc=@licenc";
            var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
            SQLCommand.Parameters.Add("@licenc", MySql.Data.MySqlClient.MySqlDbType.VarString);
            SQLCommand.Parameters["@licenc"].Value = tbLicenc.Text;



            try
            {
                MySql.Data.MySqlClient.MySqlDataReader dataReader = SQLCommand.ExecuteReader();


                if (dataReader.HasRows == false)
                {
                    Adatbázis.Naplózás("21", Program.aktuálisCég + " " + Program.prefix + "---A megadott licenckód nem létezik, vagy nem aktiv!");
                    //Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---A megadott licenckód nem létezik, vagy nem aktiv!");
                    MessageBox.Show("A megadott licenckód nem létezik, vagy nem aktiv!" + Environment.NewLine +
                        "Kérjük, vegye fel a kapcsolatot az ügyfélszolgálattal!",
                        "Licenc hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                dataReader.Close();
                SQLCommand.Dispose();

                sql = "UPDATE Licenc SET Aktiv=0 WHERE Licenc=@licenc";
                SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                SQLCommand.Parameters.Add("@licenc", MySql.Data.MySqlClient.MySqlDbType.VarString);
                //SQLCommand.Parameters["@licenc"].Value = Funkciók.LicencReg("", false);
                SQLCommand.Parameters["@licenc"].Value = Funkciók.RegistryRW("LicKey", "", false);



                SQLCommand.ExecuteNonQuery();
                SQLCommand.Dispose();

                sql = "UPDATE Licenc SET Aktiv=1 WHERE Licenc=@licenc";
                SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                SQLCommand.Parameters.Add("@licenc", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@licenc"].Value = tbLicenc.Text;



                SQLCommand.ExecuteNonQuery();
                SQLCommand.Dispose();

                //Funkciók.LicencReg(tbLicenc.Text, true);
                Funkciók.RegistryRW("LicKey", tbLicenc.Text, true);
                //Properties.Settings.Default.licencKódOLD = tbLicenc.Text;
                Properties.Settings.Default.Save();

                MessageBox.Show("Sikeres licenckód aktualizálás!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Adatbázis.Naplózás("23", Program.aktuálisCég + " " + Program.prefix + "---Sikeres licenckód aktualizálása!---");
                //Program.logger.Info(Program.aktuálisCég + " " + Program.prefix + "---Sikeres licenckód aktualizálása!---");
                tbLicenc.Text = "";

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Adatbázis.Naplózás("21", Program.aktuálisCég + " " + Program.prefix + "---Nem sikerült a licenckód aktualizálása!---" + ex);
                //Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Nem sikerült a licenckód aktualizálása!---" + ex);
                MessageBox.Show("Nem sikerült a licenckód ellenőrzése!" + Environment.NewLine +
                        "Kérjük, vegye fel a kapcsolatot az ügyfélszolgálattal!",
                        "Licenc hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }



            conn.Close();


        }



        private void formAlapbeállítások_Load(object sender, EventArgs e)
        {
            //Licenc
            tbLicenc.Text = Program.kódoltLic;

            //TTS
            //cbTTSEngedélyezve.Checked = Program.TTSEngedélyezve;
            if (Program.TTSEngedélyezve == "Yes") cbTTSEngedélyezve.Checked = true;
            else cbTTSEngedélyezve.Checked = false;
            
            /*
            trbHangerő.Value = Program.TTSHangerő;
            trbSebesség.Value = Program.TTSSebesség;



            var voice = TTS.hang.GetInstalledVoices();
            var nyelve = "";
            for (int i = 0; i < voice.Count; i++)
            {
                cbTTSNyelv.Items.Add(voice[i].VoiceInfo.Name + " / " + voice[i].VoiceInfo.Culture);
                if (voice[i].VoiceInfo.Name == Program.TTSNyelv) nyelve = voice[i].VoiceInfo.Culture.ToString();
            }

            cbTTSNyelv.SelectedIndex = cbTTSNyelv.FindStringExact(Program.TTSNyelv + " / " + nyelve);
            */

            //Fordítás és hang
            cbFordításNyelve.SelectedIndex = cbFordításNyelve.FindString(Program.fordításNyelve);
            cbTTS_Nyelv.SelectedIndex = cbTTS_Nyelv.FindString(Program.TTS_Nyelv.Substring(0,2).ToUpper());

            var test1 = Program.TTS_Nyelv.Substring(0, 2).ToUpper();
            var test2 = Program.fordításNyelve;
            trSp_Fordítás.Enabled = true;
            trSp_Beszéd.Enabled = true;


            //Változáslista
            rtbVáltozásLista.Text = Properties.Resources.VáltozásLista;

        }



        private void cbTTSEngedélyezve_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTTSEngedélyezve.Checked)
            {
                //Funkciók.TTSRegÍrás(true, Program.TTSHangerő, Program.TTSSebesség, Program.TTSNyelv);

                Funkciók.RegistryRW("TTSEnabled", "Yes", true);

                TTS.TTS_Beállítás();
            }
            else Funkciók.RegistryRW("TTSEnabled", "No", true);
            //Funkciók.TTSRegÍrás(false, Program.TTSHangerő, Program.TTSSebesség, Program.TTSNyelv);
            TTS.TTS_Beállítás();
        }


        private void trbSebesség_ValueChanged(object sender, EventArgs e)
        {
            /*
            Program.TTSSebesség = trbSebesség.Value;
            Funkciók.TTSRegÍrás(Program.TTSEngedélyezve, Program.TTSHangerő, Program.TTSSebesség, Program.TTSNyelv);
            TTS.TTS_Beállítás();
            */
        }

        private void trbHangerő_ValueChanged(object sender, EventArgs e)
        {
            /*
            Program.TTSHangerő = trbHangerő.Value;
            Funkciók.TTSRegÍrás(Program.TTSEngedélyezve, Program.TTSHangerő, Program.TTSSebesség, Program.TTSNyelv);
            TTS.TTS_Beállítás();
            */
        }

        private void rtbVáltozásLista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Csak a fejlesztés idejére, utána TÖRÖLNI!
            if (rtbVáltozásLista.Text.Substring(0, 7) == "Nyitott") rtbVáltozásLista.Text = Properties.Resources.VáltozásLista;
            else rtbVáltozásLista.Text = Properties.Resources.Teendők;

        }



        private void cbTTSNyelv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*
            Program.TTSNyelv = cbTTSNyelv.Text.Substring(0, cbTTSNyelv.Text.IndexOf(" / "));
            Funkciók.TTSRegÍrás(Program.TTSEngedélyezve, Program.TTSHangerő, Program.TTSSebesség, Program.TTSNyelv);
            TTS.hang.SpeakAsyncCancelAll();
            TTS.hangRSS.SpeakAsyncCancelAll();
            


            TTS.TTS_Beállítás();
            TTS.TTS_Play("A Felisz Aurora köszönti Önt!", false);
            */
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFordításNyelve_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Program.fordításNyelve = cbFordításNyelve.Text.Substring(0, 2);
            Funkciók.RegistryRW("TranslateTo", Program.fordításNyelve, true);




        }

        private void cbTTS_Nyelv_SelectionChangeCommitted(object sender, EventArgs e)
        {

            string[,] nyelvek = new string[,]{
                    {"DE", "de-DE"},
                    {"CS", "cs-CZ"},
                    {"EN", "en-US"},
                    {"ES", "es-ES"},
                    {"FR", "fr-FR"},
                    {"HR", "hr-HR"},
                    {"HU", "hu-HU"},
                    {"IT", "it-IT"},
                    {"NL", "nl-NL"},
                    {"PL", "pl-PL"},
                    {"RO", "ro-RO"},
                    {"RU", "ru-RU"},
                    {"SI", "sl-SI"},
                    {"SK", "sk-SK"},
                    {"SR", "sr-RS"},
                    {"SV", "sv-SE"},
                    {"UK", "uk-UA"}};


            

            for (int i = 0; i < nyelvek.Length; i++)
            {
                if (nyelvek[i,0]== cbTTS_Nyelv.Text.Substring(0, 2))
                {
                    Program.TTS_Nyelv = nyelvek[i, 1];
                    break;
                }
            }


            Funkciók.RegistryRW("TTSEnabled", "Yes", true);
            Funkciók.RegistryRW("TTSLanguage", Program.TTS_Nyelv, true);


            //Funkciók.TTSRegÍrás(Program.TTSEngedélyezve, Program.TTSHangerő, Program.TTSSebesség, Program.TTSNyelv);
            if (TTS.synthesizer != null) TTS.synthesizer.StopSpeakingAsync();


            //TTS.hang.SpeakAsyncCancelAll();
            //TTS.hangRSS.SpeakAsyncCancelAll();


            TTS.TTS_Beállítás();
            //TTS.TTS_Play("A Felisz Aurora köszönti Önt!", false);
            TTS.SynthesizeToSpeaker("A Felisz Aurora köszönti Önt!");
        }
    }
}
