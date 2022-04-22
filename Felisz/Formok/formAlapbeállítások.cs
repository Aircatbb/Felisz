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
                Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Nincs DB kapcsolat, licencaktualizálás meghiúsult!");
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
                    Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---A megadott licenckód nem létezik, vagy nem aktiv!");
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
                SQLCommand.Parameters["@licenc"].Value = Funkciók.LicencReg("", false);
                //SQLCommand.Parameters["@licenc"].Value = Properties.Settings.Default.licencKódOLD;



                SQLCommand.ExecuteNonQuery();
                SQLCommand.Dispose();

                sql = "UPDATE Licenc SET Aktiv=1 WHERE Licenc=@licenc";
                SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                SQLCommand.Parameters.Add("@licenc", MySql.Data.MySqlClient.MySqlDbType.VarString);
                SQLCommand.Parameters["@licenc"].Value = tbLicenc.Text;



                SQLCommand.ExecuteNonQuery();
                SQLCommand.Dispose();

                Funkciók.LicencReg(tbLicenc.Text, true);
                //Properties.Settings.Default.licencKódOLD = tbLicenc.Text;
                Properties.Settings.Default.Save();

                MessageBox.Show("Sikeres licenckód aktualizálás!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.logger.Info(Program.aktuálisCég + " " + Program.prefix + "---Sikeres licenckód aktualizálása!---");
                tbLicenc.Text = "";

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Nem sikerült a licenckód aktualizálása!---" + ex);
                MessageBox.Show("Nem sikerült a licenckód ellenőrzése!" + Environment.NewLine +
                        "Kérjük, vegye fel a kapcsolatot az ügyfélszolgálattal!",
                        "Licenc hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }



            conn.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void formAlapbeállítások_Load(object sender, EventArgs e)
        {
            //Licenc
            tbLicenc.Text = Program.kódoltLic;
            //TTS
            cbTTSEngedélyezve.Checked = Program.TTSEngedélyezve;
            trbHangerő.Value = Program.TTSHangerő;
            trbSebesség.Value = Program.TTSSebesség; 
            //Változáslista
            rtbVáltozásLista.Text = Properties.Resources.VáltozásLista;

        }

  

        private void cbTTSEngedélyezve_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTTSEngedélyezve.Checked)
            {
                Funkciók.TTSRegÍrás(true, Program.TTSHangerő, Program.TTSSebesség);
                TTS.TTS_Beállítás();
            }
            else Funkciók.TTSRegÍrás(false, Program.TTSHangerő, Program.TTSSebesség);
            TTS.TTS_Beállítás();
        }


        private void trbSebesség_ValueChanged(object sender, EventArgs e)
        {

            Program.TTSSebesség = trbSebesség.Value;
            Funkciók.TTSRegÍrás(Program.TTSEngedélyezve, Program.TTSHangerő,  Program.TTSSebesség);
            TTS.TTS_Beállítás();
        }

        private void trbHangerő_ValueChanged(object sender, EventArgs e)
        {
            Program.TTSHangerő = trbHangerő.Value;
            Funkciók.TTSRegÍrás(Program.TTSEngedélyezve, Program.TTSHangerő, Program.TTSSebesség);
            TTS.TTS_Beállítás();
        }

      
    }
}
