using System;
using System.Windows.Forms;

namespace Felisz
{
    public partial class formBejelentkezés : Form
    {
        public formBejelentkezés()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string jelszóDB = "";
            string felhasználónévDB = "";

            if (tbFelhasználó.Text == "" || tbJelszó.Text == "")
            {
                MessageBox.Show("Felhasználónév és a jelszó nem lehet üres!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Adatbázis.AdatbázisEllenőrzéseCég())
            {
                MessageBox.Show("Nincs adatbázis kapcsolat!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Adatbázis.MyConnectionString();

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            string sql = "SELECT FelhasznaloNev, Jelszo FROM Felhasznalok WHERE Aktiv=1 AND Felhasznalo=@felhasznalo";
            var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
            SQLCommand.Parameters.Add("@felhasznalo", MySql.Data.MySqlClient.MySqlDbType.String);
            SQLCommand.Parameters["@felhasznalo"].Value = tbFelhasználó.Text;


            try
            {
                MySql.Data.MySqlClient.MySqlDataReader dataReader = SQLCommand.ExecuteReader();


                if (dataReader.HasRows == false)
                {
                    Program.logger.Warn(Program.aktuálisCég + " " + Program.prefix + "---Sikertelen bejelentkezés (nem létező, vagy inaktív felhasználó)!---");
                    MessageBox.Show("Nem található a felhasználó vagy inaktív!" + Environment.NewLine +
                        "Kérem, próbálja meg újra!",
                        "Bejelentkezési hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }


                dataReader.Read();
                felhasználónévDB = dataReader.GetString(0);
                jelszóDB = dataReader.GetString(1);
                dataReader.Close();
                SQLCommand.Dispose();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Program.logger.Warn(Program.aktuálisCég + " " + Program.prefix + "---Sikertelen bejelentkezés!---" + ex);
                return;
            }
            conn.Close();


            try
            {
                if (Funkciók.Decrypt(jelszóDB) == tbJelszó.Text)
                {
                    Properties.Settings.Default.bejelentkezésiKisérlet = 1;
                    Properties.Settings.Default.utolsóFelhasználó = tbFelhasználó.Text;
                    Properties.Settings.Default.Save();
                    Program.aktuálisFelhasználó = tbFelhasználó.Text;
                    Program.aktuálisFelhasználóNév = felhasználónévDB;
                    Program.logger.Info(Program.aktuálisCég + " " + Program.prefix + "---Sikeres bejelentkezés!---Felhasználó: " + tbFelhasználó.Text + "---");
                    Program.jelszó = jelszóDB;
                    this.Close();
                }
                else
                {
                    Program.logger.Warn(Program.aktuálisCég + " " + Program.prefix + "---Sikertelen bejelentkezés (helytelen jelszó)!---Próbálkozás:" + Properties.Settings.Default.bejelentkezésiKisérlet + "---Felhasználó: " + tbFelhasználó.Text + "---");
                    Properties.Settings.Default.bejelentkezésiKisérlet++;
                    Properties.Settings.Default.Save();
                    if (Properties.Settings.Default.bejelentkezésiKisérlet < 5)
                    {
                        MessageBox.Show("Helytelen a megadott jelszó!" + Environment.NewLine +
                            "Kérem, próbálja meg újra!",
                            "Bejelentkezési hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }


                    if (Properties.Settings.Default.bejelentkezésiKisérlet == 5)
                    {
                        MessageBox.Show("Figyelem, a következő kisérletnél letiltásra kerül a felhasználó!" + Environment.NewLine +
                        "Kérem, próbálja meg újra!",
                        "Bejelentkezési hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                    if (Properties.Settings.Default.bejelentkezésiKisérlet == 6)
                    {
                        myConnectionString = Adatbázis.MyConnectionString();

                        conn = new MySql.Data.MySqlClient.MySqlConnection();
                        conn.ConnectionString = myConnectionString;
                        conn.Open();
                        sql = "UPDATE Felhasznalok SET Aktiv=0 WHERE Felhasznalo=@felhasznalo";
                        SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                        SQLCommand.Parameters.Add("@felhasznalo", MySql.Data.MySqlClient.MySqlDbType.String);
                        SQLCommand.Parameters["@felhasznalo"].Value = tbFelhasználó.Text;

                        SQLCommand.ExecuteNonQuery();
                        SQLCommand.Dispose();
                        conn.Close();

                        MessageBox.Show("A felhasználó letiltásra került!" + Environment.NewLine +
                        "Kérem, vegye fel a kapcsolatot az admnisztrátorral, vagy az ügyfélszolgálattal!",
                        "Bejelentkezési hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                        return;

                    }


                }


            }
            catch (Exception ex)
            {

                Program.logger.Warn(Program.aktuálisCég + " " + Program.prefix + "---Hiba a jelszó dekódolásánál!---Felhasználó: " + tbFelhasználó.Text + "---" + Environment.NewLine + ex);
                MessageBox.Show("Hiba a jelszó dekódolásánál!" + Environment.NewLine +
                        "Kérem, vegye fel a kapcsolatot az admnisztrátorral, vagy az ügyfélszolgálattal!",
                        "Bejelentkezési hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }


        }

        private void formBejelentkezés_Load(object sender, EventArgs e)
        {




            tbFelhasználó.Text = Properties.Settings.Default.utolsóFelhasználó;
            lbVerzió.Text = "Verzió: " + Application.ProductVersion + "." + Environment.NewLine +
                "Licenc érvényessége: " + Program.licÉrvényesség.ToShortDateString();
            lbCég.Text = "Cégazonosító: " + Program.aktuálisCég + Environment.NewLine +
                "Cégprefix: " + Program.prefix;
        }

        private void lbVerzió_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formBejelentkezés_FormClosed(object sender, FormClosedEventArgs e)
        {
            formFelisz.engedélyezve = true;
        }

        private void tbJelszó_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btBejelentkezés.PerformClick();
            }
        }


    }
}
