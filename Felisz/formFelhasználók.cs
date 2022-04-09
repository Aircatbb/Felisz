using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Felisz
{
    public partial class formFelhasználók : Form
    {
        public formFelhasználók()
        {
            InitializeComponent();
        }

        public MySqlConnection conn;
        public string myConnectionString;
        public MySqlDataAdapter dataAdapter;
        public MySqlCommandBuilder cmdBuilder;
        public DataSet ds = new DataSet();
        public DataSet changes;


        private void formFelhasználók_Load(object sender, EventArgs e)
        {
            DataGridFeltöltése();
        }

        private void DataGridFeltöltése()
        {
            if (!Adatbázis.AdatbázisEllenőrzéseCég())
            {
                MessageBox.Show("Nincs adatbázis kapcsolat!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            myConnectionString = Properties.Settings.Default.cég_db_ConnectionString;
            myConnectionString = myConnectionString.Replace("XXX", Program.prefix);
            myConnectionString = myConnectionString.Replace("YYY", Program.jelszóLic);
            myConnectionString = myConnectionString.Replace("ZZZ", Program.aktuálisCég + Program.prefix);

            conn = new MySqlConnection(myConnectionString);
            conn.Open();
            string sql = "SELECT * FROM Felhasznalok";


            try
            {
                dataAdapter = new MySqlDataAdapter(sql, conn);
                dataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];



                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    switch (dataGridView1.Columns[i].HeaderText)
                    {
                        case "ID":
                            dataGridView1.Columns[i].Visible = false;
                            break;
                        case "Jelszo":
                            dataGridView1.Columns[i].Visible = false;
                            break;
                        case "JelszoErv":
                            dataGridView1.Columns[i].HeaderText = "Jelszó érvényessége";
                            break;
                        case "ElsoBe":
                            dataGridView1.Columns[i].HeaderText = "Jelszómódosítás szükséges";
                            break;
                        case "Felhasznalo":
                            dataGridView1.Columns[i].HeaderText = "Felhasználó";
                            break;
                        case "FelhasznaloNev":
                            dataGridView1.Columns[i].HeaderText = "Felhasználónév";
                            break;
                        case "Aktiv":
                            dataGridView1.Columns[i].HeaderText = "Aktiv";
                            break;
                        case "EngedelyKor":
                            dataGridView1.Columns[i].HeaderText = "Engedélykörök";
                            break;
                        case "panelExportImportSubMenu":
                            dataGridView1.Columns[i].HeaderText = @"Export \ Import panel";
                            break;
                        case "btExportImport":
                            dataGridView1.Columns[i].HeaderText = @"Export \ Import menü";
                            break;
                        case "panelHRSubMenu":
                            dataGridView1.Columns[i].HeaderText = "HR panel";
                            break;
                        case "btHR":
                            dataGridView1.Columns[i].HeaderText = "HR menü";
                            break;
                        case "panelAdminSubMenu":
                            dataGridView1.Columns[i].HeaderText = "Admin panel";
                            break;
                        case "btAdmin":
                            dataGridView1.Columns[i].HeaderText = "Admin menü";
                            break;
                        case "btExportImportAdatokKezelese":
                            dataGridView1.Columns[i].HeaderText = @"Export \ Import Adatok kezelése";
                            break;
                        case "btHRMT":
                            dataGridView1.Columns[i].HeaderText = @"HR Munkatörvénykönyve";
                            break;
                        case "btHRKalkulator":
                            dataGridView1.Columns[i].HeaderText = "HR Kalkulátor";
                            break;
                        case "btHRUtikoltseg":
                            dataGridView1.Columns[i].HeaderText = "HR Utiköltség";
                            break;
                        case "btHRStatisztikak":
                            dataGridView1.Columns[i].HeaderText = "HR Statisztikák";
                            break;
                        case "btHRJelentkezok":
                            dataGridView1.Columns[i].HeaderText = "HR Jelentkezők";
                            break;
                        case "btHRFigyelmeztetesek":
                            dataGridView1.Columns[i].HeaderText = "HR Figyelmeztetések";
                            break;
                        case "btHRMunkaszerzodesModositasa":
                            dataGridView1.Columns[i].HeaderText = "HR Munkaszerződés módosítása";
                            break;
                        case "btHRFelmondas":
                            dataGridView1.Columns[i].HeaderText = "HR Felmondás";
                            break;
                        case "btHRMunkaszerzodes":
                            dataGridView1.Columns[i].HeaderText = "HR Munkaszerződés";
                            break;
                        case "btAdminFelhasznalok":
                            dataGridView1.Columns[i].HeaderText = "Admin Felhasználók";
                            break;
                        case "btAdminAlapBeallitasok":
                            dataGridView1.Columns[i].HeaderText = "Admin Alapbeállítások";
                            break;
                        case "btAdminGlobalAdminBeallitasok":
                            dataGridView1.Columns[i].HeaderText = "Admin Globaladmin beállítások";
                            break;

                        default:
                            dataGridView1.Columns[i].HeaderText = "#HIÁNYZIK#";
                            break;
                    }


                }




            }
            catch (Exception ex)
            {
                Program.logger.Warn(Program.aktuálisCég + " " + Program.prefix + "---Sikertelen a felhasználói adatok betöltése!---" + ex);
                return;
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmdBuilder = new MySqlCommandBuilder(dataAdapter);
            changes = ds.GetChanges();
            if (changes != null)
            {
                dataAdapter.Update(changes);
                ds.Clear();
                dataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }


        }

        private void btRegisztrálás_Click(object sender, EventArgs e)
        {

            if (!Adatbázis.AdatbázisEllenőrzéseCég())
            {
                MessageBox.Show("Nincs adatbázis kapcsolat!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            try
            {
                MySqlConnection conn;
                string myConnectionString = Properties.Settings.Default.cég_db_ConnectionString;
                myConnectionString = myConnectionString.Replace("XXX", Program.prefix);
                myConnectionString = myConnectionString.Replace("YYY", Program.jelszóLic);
                myConnectionString = myConnectionString.Replace("ZZZ", Program.aktuálisCég + Program.prefix);
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                if (tbFelhasználó.Text == "" || tbFelhasználónév.Text == "" || tbJelszó.Text == "")
                {
                    MessageBox.Show("A 'Felhasználó', 'Felhasználó neve', 'Jelszó' mezők kitöltése kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                if (tbFelhasználó.Text.Length > 25)
                {
                    MessageBox.Show("A felhasználó maximum 25 karakter lehet!!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                if (tbFelhasználónév.Text.Length > 50)
                {
                    MessageBox.Show("A felhasználó neve maximum 50 karakter lehet!!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                if (tbJelszó.Text.Length > 32)
                {
                    MessageBox.Show("A jelszó maximum 32 karakter lehet!!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }


                string jelszóEncrypt = Funkciók.Encrypt(tbJelszó.Text);
                DateTime érvDátum = DateTime.Now.Date.AddDays(Properties.Settings.Default.jelszóÉrvényesség);

                string sql = "INSERT INTO Felhasznalok (Felhasznalo, FelhasznaloNev, Jelszo, JelszoErv, ElsoBe, EngedelyKor, Aktiv)" +
                    " VALUES ('" + tbFelhasználó.Text + "', '" + tbFelhasználónév.Text + "', '" + jelszóEncrypt + "', '" + érvDátum.ToString("yyyy.MM.dd") + "', 1, '" + tbEngedélykör.Text + "', 1)";
                var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                SQLCommand.ExecuteNonQuery();
                SQLCommand.Dispose();
                conn.Close();

                tbFelhasználó.Text = "";
                tbFelhasználónév.Text = "";
                tbEngedélykör.Text = "";
                tbJelszó.Text = "";

                Program.logger.Info(Program.aktuálisCég + " " + Program.prefix + "---Felhasználó sikeresen regisztrálva!---Felhasználó: " + tbFelhasználó.Text + "---");
                MessageBox.Show("Felhasználó sikeresen regisztrálva!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Lista frissítése
                ds.Clear();
                dataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                return;
            }
            catch (Exception ex)
            {
                Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Nem sikerült a felhasználót regisztrálni az adatbázisba!---" + Environment.NewLine + ex);
                MessageBox.Show("Nem sikerült a felhasználót regisztrálni az adatbázisba!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
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
    }
}
