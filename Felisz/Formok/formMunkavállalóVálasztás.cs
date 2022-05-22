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
        public static string mód = ""; //M-Módosítás, N-Új felvitel, T-Törlés, A-Megszakítás    
        public string myConnectionString;
        public MySqlConnection conn;
        public MySqlDataAdapter dataAdapter;

        public formMunkavállalóVálasztás()
        {
            InitializeComponent();
        }


        private void MunkavállalókBetöltése(string selName)
        {
            if (!Adatbázis.AdatbázisEllenőrzéseCég())
            {
                return;
            }



            myConnectionString = Adatbázis.MyConnectionString();



            conn = new MySqlConnection(myConnectionString);
            conn.Open();

            try
            {
                selName = selName.Substring(0, 1).ToUpper() + selName.Substring(1);
            }
            catch
            {
                selName = "";
            }



            string sql = @"SELECT SzemAzon, VezNev, UtoNev1, UtoNev2, LakIrSzam, LakVaros, LakKozt, LakKoztJell, LakHazSz FROM SzemTorzs " +
                          "WHERE VezNev LIKE '" + selName + "%' " +
                          "AND TOROL=0 " +
                          "AND ERVIG='2099-01-31' " +
                          "ORDER BY VezNev, UtoNev1, UtoNev2";

            try
            {
                dataAdapter = new MySqlDataAdapter(sql, conn);
                DataTable dtRecord = new DataTable();
                dataAdapter.Fill(dtRecord);
                this.dgvSelectEmploye.DataSource = dtRecord;
                conn.Close();

                if (dgvSelectEmploye.Columns[0].HeaderText == "SzemAzon")
                {
                    for (int i = 0; i < dgvSelectEmploye.ColumnCount; i++)
                    {
                        switch (dgvSelectEmploye.Columns[i].HeaderText)
                        {
                            case "SzemAzon":
                                dgvSelectEmploye.Columns[i].HeaderText = "Személyi azonosító";
                                dgvSelectEmploye.Columns[i].Width = 60;
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
                Adatbázis.Naplózás("21", Program.aktuálisCég + " " + Program.prefix + "---Sikertelen a dolgozói adatok betöltése!---" + ex);
                //Program.logger.Warn(Program.aktuálisCég + " " + Program.prefix + "---Sikertelen a dolgozói adatok betöltése!---" + ex);
                return;
            }


        }



        private void dgvSelectEmploye_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (rbTörlés.Checked == true)
            {
                mód = "T";
                formTörlésFigyelmeztetés formTF = new formTörlésFigyelmeztetés();
                DialogResult dr = formTF.ShowDialog();
                TTS.TTS_RSS_Resume();

            }
            if (rbMódosítás.Checked == true)
            {
                mód = "M";
                TextBox tbAzon = Application.OpenForms["formSzemAdatok"].Controls["gbSzemélyiAdatok"].Controls["tcSzemélyiAdatok"].Controls["tpÁltalánosSzemélyiAdatok"].Controls["tlpÁltalánosSzemélyiAdatok"].Controls["tlpOszlop1"].Controls["gbDolgozó"].Controls["tlpDolgozó"].Controls["tbAzonosítószám"] as TextBox;
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
                MunkavállalókBetöltése(formMunkavállalóVálasztásNévAlapján.selName);

            }


        }

        private void formMunkavállalóVálasztás_Load(object sender, EventArgs e)
        {
            MunkavállalókBetöltése("");
        }

        private void dgvSelectEmploye_DoubleClick(object sender, EventArgs e)
        {

            //this.DialogResult = DialogResult.OK;
        }

        private void rbÚjrögzítés_CheckedChanged(object sender, EventArgs e)
        {
            if (rbÚjrögzítés.Checked)
            {
                formMunkavállalóVálasztás.azon = 0;
                formMunkavállalóVálasztás.mód = "N";
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

