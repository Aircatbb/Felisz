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
    public partial class formSzemKiválaszt : Form
    {

        public MySqlConnection conn;
        public string myConnectionString;
        public MySqlDataAdapter dataAdapter;
        public MySqlCommandBuilder cmdBuilder;
        public DataSet ds = new DataSet();
        public DataSet changes;

        public static int szemAzon { get; set; }

        public formSzemKiválaszt()
        {
            InitializeComponent();
        }

        private void pbFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridFeltöltése()
        {
            if (!Adatbázis.AdatbázisEllenőrzéseCég())
            {
                return;
            }

            myConnectionString = Properties.Settings.Default.cég_db_ConnectionString;
            myConnectionString = myConnectionString.Replace("XXX", Program.prefix);
            myConnectionString = myConnectionString.Replace("YYY", Program.jelszóLic);
            myConnectionString = myConnectionString.Replace("ZZZ", Program.aktuálisCég + Program.prefix);

            conn = new MySqlConnection(myConnectionString);
            conn.Open();
            string sql = "SELECT SzemAzon, VezNev, UtoNev1, UtoNev2, LakOrszag, LakIrSzam, LakVaros, LakKozt, LakKoztJell, LakHazSz FROM SzemTorzs";


            try
            {
                dataAdapter = new MySqlDataAdapter(sql, conn);
                dataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];



                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    switch (dataGridView1.Columns[i].HeaderText)
                    {
                        case "SzemAzon":
                            dataGridView1.Columns[i].HeaderText = "Személyi azonosító";
                            break;
                        case "VezNev":
                            dataGridView1.Columns[i].HeaderText = "Vezetéknév";
                            break;
                        case "UtoNev1":
                            dataGridView1.Columns[i].HeaderText = "Utonév 1";
                            break;
                        case "UtoNev2":
                            dataGridView1.Columns[i].HeaderText = "Utonév 2";
                            break;
                        case "LakOrszag":
                            dataGridView1.Columns[i].HeaderText = "Lakhely orszag";
                            break;
                        case "LakIrSzam":
                            dataGridView1.Columns[i].HeaderText = "Lakhely Irsz.";
                            break;
                        case "LakVaros":
                            dataGridView1.Columns[i].HeaderText = "Lakhely Város";
                            break;
                        case "LakKozt":
                            dataGridView1.Columns[i].HeaderText = "Lakhely közterület";
                            break;
                        case "LakKoztJell":
                            dataGridView1.Columns[i].HeaderText = "Lakhely közt. jell.";
                            break;
                        case "LakHazSz":
                            dataGridView1.Columns[i].HeaderText = "Lakhely házszám";
                            break;
                        default:
                            dataGridView1.Columns[i].HeaderText = "#HIÁNYZIK#";
                            break;
                    }


                }
            }
            catch (Exception ex)
            {
                Program.logger.Warn(Program.aktuálisCég + " " + Program.prefix + "---Sikertelen a dolgozói adatok betöltése!---" + ex);
                return;
            }
            conn.Close();
        }

        private void formSzemKiválaszt_Load(object sender, EventArgs e)
        {
            DataGridFeltöltése();
        }

        private void btMódosítás_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btKilépés_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;

        }

        private void btRögzítés_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            formSzemKiválaszt.szemAzon = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
        }
    }
}
