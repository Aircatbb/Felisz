using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Felisz.Formok
{

    

    public partial class formMunkavállalóVálasztás : Form

    {
        public static int azon = 0;
        public static string mód = ""; //M-Módosítás, N-Új felvitel    
        public string myConnectionString;
        public MySqlConnection conn;
        public MySqlDataAdapter dataAdapter;

        public formMunkavállalóVálasztás()
        {
            InitializeComponent();
        }


        private void CégVálaszt(string selName)
        {
            if (!Adatbázis.AdatbázisEllenőrzéseCég())
            {
                return;
            }

            /*
            string sql = "SELECT FelhasznaloNev, Jelszo FROM Felhasznalok WHERE Aktiv=1 AND Felhasznalo=@felhasznalo";
            var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
            SQLCommand.Parameters.Add("@felhasznalo", MySql.Data.MySqlClient.MySqlDbType.String);
            SQLCommand.Parameters["@felhasznalo"].Value = tbFelhasználó.Text;
            



            cmdBuilder = new MySqlCommandBuilder(dataAdapter);
            changes = ds.GetChanges();
            if (changes != null)
            {
                dataAdapter.Update(changes);
                ds.Clear();
                dataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
             
             */


            myConnectionString = Properties.Settings.Default.cég_db_ConnectionString;
            myConnectionString = myConnectionString.Replace("XXX", Program.prefix);
            myConnectionString = myConnectionString.Replace("YYY", Program.jelszóLic);
            myConnectionString = myConnectionString.Replace("ZZZ", Program.aktuálisCég + Program.prefix);



            conn = new MySqlConnection(myConnectionString);
            conn.Open();
            //string sql = @"SELECT SzemAzon, VezNev, UtoNev1, UtoNev2, LakOrszag, LakIrSzam, LakVaros, LakKozt, LakKoztJell, LakHazSz FROM SzemTorzs WHERE VezNev LIKE '" + selName + "%'";

            //string sql = @"SELECT SzemAzon, VezNev, UtoNev1, UtoNev2, LakOrszag, LakIrSzam, LakVaros, LakKozt, LakKoztJell, LakHazSz FROM SzemTorzs WHERE VezNev LIKE 'Bo%'";
            //string sql = @"SELECT SzemAzon, VezNev, UtoNev1, UtoNev2, LakOrszag, LakIrSzam, LakVaros, LakKozt, LakKoztJell, LakHazSz FROM SzemTorzs WHERE VezNev LIKE 'Bo%'";

            try
            {
                selName = selName.Substring(0, 1).ToUpper() + selName.Substring(1);
            }
            catch
            {
                selName = "";
            }



            string sql = @"SELECT SzemAzon, VezNev, UtoNev1, UtoNev2, LakIrSzam, LakVaros, LakKozt, LakKoztJell, LakHazSz FROM SzemTorzs WHERE VezNev LIKE '" + selName + "%' ORDER BY VezNev, UtoNev1, UtoNev2";

            try
            {
                dataAdapter = new MySqlDataAdapter(sql, conn);
                DataTable dtRecord = new DataTable();
                dataAdapter.Fill(dtRecord);
                this.dgvSelectEmploye.DataSource = dtRecord;
                conn.Close();

                if (dgvSelectEmploye.Columns[0].HeaderText=="SzemAzon")
                {
                    for (int i = 0; i < dgvSelectEmploye.ColumnCount; i++)
                    {
                        switch (dgvSelectEmploye.Columns[i].HeaderText)
                        {
                            case "SzemAzon":
                                dgvSelectEmploye.Columns[i].HeaderText = "Személyi azonosító";
                                dgvSelectEmploye.Columns[i].Width=60;
                                break;
                            case "VezNev":
                                dgvSelectEmploye.Columns[i].HeaderText = "Vezetéknév";
                                dgvSelectEmploye.Columns[i].Width = 100;
                                break;
                            case "UtoNev1":
                                dgvSelectEmploye.Columns[i].HeaderText = "Utónév 1";
                                dgvSelectEmploye.Columns[i].Width = 100;
                                break;
                            case "UtoNev2":
                                dgvSelectEmploye.Columns[i].HeaderText = "Utónév 2";
                                dgvSelectEmploye.Columns[i].Width = 100;
                                break;
                            case "LakOrszag":
                                dgvSelectEmploye.Columns[i].HeaderText = "Lakhely orszag";
                                dgvSelectEmploye.Columns[i].Width = 50;
                                break;
                            case "LakIrSzam":
                                dgvSelectEmploye.Columns[i].HeaderText = "Lakhely Irsz.";
                                dgvSelectEmploye.Columns[i].Width = 50;
                                break;
                            case "LakVaros":
                                dgvSelectEmploye.Columns[i].HeaderText = "Lakhely Város";
                                dgvSelectEmploye.Columns[i].Width = 100;
                                break;
                            case "LakKozt":
                                dgvSelectEmploye.Columns[i].HeaderText = "Lakhely közterület";
                                dgvSelectEmploye.Columns[i].Width = 100;
                                break;
                            case "LakKoztJell":
                                dgvSelectEmploye.Columns[i].HeaderText = "Lakhely közt. jell.";
                                dgvSelectEmploye.Columns[i].Width = 60;
                                break;
                            case "LakHazSz":
                                dgvSelectEmploye.Columns[i].HeaderText = "Lakhely házszám";
                                dgvSelectEmploye.Columns[i].Width = 50;
                                break;
                            default:
                                dgvSelectEmploye.Columns[i].HeaderText = "#HIÁNYZIK#";
                                dgvSelectEmploye.Columns[i].Width = 50;
                                break;
                        }


                    }
                }

            }
            catch (Exception ex)
            {

                Program.logger.Warn(Program.aktuálisCég + " " + Program.prefix + "---Sikertelen a dolgozói adatok betöltése!---" + ex);
                return;
            }


        }



        private void dgvSelectEmploye_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (rbMódosítás.Checked == true)
            {
                mód = "M";
                TextBox tbAzon = Application.OpenForms["formSzemAdatok"].Controls["gbSzemélyiAdatok"].Controls["tcSzemélyiAdatok"].Controls["tpÁltalánosSzemélyiAdatok"].Controls["tlpÁltalánosSzemélyiAdatok"].Controls["gbDolgozó"].Controls["tlpDolgozó"].Controls["tbAzonosítószám"] as TextBox;
                tbAzon.Enabled = false;
            }
            if (rbÚjrögzítés.Checked == true) mód = "N";
            formMunkavállalóVálasztás.azon = (int)dgvSelectEmploye.Rows[e.RowIndex].Cells[0].Value;

            this.DialogResult = DialogResult.OK;

        }

        private void dgvSelectEmploye_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                formMunkavállalóVálasztásNévAlapján ns = new formMunkavállalóVálasztásNévAlapján();
                DialogResult nsDialog = ns.ShowDialog();
                CégVálaszt(formMunkavállalóVálasztásNévAlapján.selName);

            }


        }

        private void formMunkavállalóVálasztás_Load(object sender, EventArgs e)
        {
            CégVálaszt("");
        }

        private void dgvSelectEmploye_DoubleClick(object sender, EventArgs e)
        {
            
            //this.DialogResult = DialogResult.OK;
        }

        private void rbÚjrögzítés_CheckedChanged(object sender, EventArgs e)
        {
            if(rbÚjrögzítés.Checked)
            {
                formMunkavállalóVálasztás.azon = 0;
                formMunkavállalóVálasztás.mód = "N";
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

