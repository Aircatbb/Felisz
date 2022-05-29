using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Felisz
{
    class Adatbázis
    {
        public static List<Országkód> országKódokList = new List<Országkód>();
        public static List<IszVárosUtca> iszVárosUtcaList = new List<IszVárosUtca>();
        public static List<IszVárosUtca> csakVárosList = new List<IszVárosUtca>();
        public static List<IszVárosUtca> csakIrszámList = new List<IszVárosUtca>();
        public static List<FoglalkoztatásHelye> foglalkoztatásHelyeList = new List<FoglalkoztatásHelye>();
        public static List<FEOR> FEORList = new List<FEOR>();
        public static List<Standard> JogviszonyFormák = new List<Standard>();
        public static List<Standard> NyugdíjTípusok = new List<Standard>();
        public static List<Standard> IskolaiVégzettség = new List<Standard>();
        public static List<Standard> SzámlavezetőBankok = new List<Standard>();

        public static string MyConnectionString()
        {
            string temp = Properties.Settings.Default.cég_db_ConnectionString;
            temp = temp.Replace("XXX", Program.prefix);
            temp = temp.Replace("YYY", Program.jelszóLic);
            temp = temp.Replace("ZZZ", Program.aktuálisCég + Program.prefix);
            return temp;
        }

        public static bool AdatbázisEllenőrzéseMain()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Properties.Settings.Default.felisz_db_ConnectionString;
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;

            try
            {
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Adatbázis.Naplózás("21", Program.aktuálisCég + " " + Program.prefix + "---Adatbáziskapcsolódási hiba (main)!" + Environment.NewLine + ex.Message);
                //Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Adatbáziskapcsolódási hiba (main)!" + Environment.NewLine + ex.Message);
                return false;
            }

            conn.Close();
            return true;
        }

        public static bool AdatbázisEllenőrzéseCég()
        {

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Properties.Settings.Default.cég_db_ConnectionString;


            myConnectionString = Adatbázis.MyConnectionString();

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;

            try
            {
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Adatbázis.Naplózás("21", Program.aktuálisCég + " " + Program.prefix + "---Adatbáziskapcsolódási hiba (cég)!" + Environment.NewLine + ex.Message);
                //Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Adatbáziskapcsolódási hiba (cég)!" + Environment.NewLine + ex.Message);
                return false;
            }

            conn.Close();
            return true;
        }

        public static bool AntiSQLinjectionTest(string input)
        {

            Regex r = new Regex(@"^(?=.*?[ˇ^˘°˛`÷¨˙´' #?!@$%^&*-+()/:;<=>_|{}])");
            var fg = r.IsMatch(input);
            if (r.IsMatch(input) != true) return false;


            return true;
        }

        public static void SzemAdatok_AdatokMemóriábaOlvasása()
        {

            //Jogviszonyformák
            JogviszonyFormák.Add(new Standard { Kód = "1", Megnevezés = "Munkaviszony" });
            JogviszonyFormák.Add(new Standard { Kód = "2", Megnevezés = "Közszolgálati jogviszony" });
            JogviszonyFormák.Add(new Standard { Kód = "3", Megnevezés = "Közalkalmazotti jogviszony" });
            JogviszonyFormák.Add(new Standard { Kód = "4", Megnevezés = "Bírósági és igazságügyi jogviszony" });
            JogviszonyFormák.Add(new Standard { Kód = "5", Megnevezés = "Ügyészségi szolgálati viszony" });
            JogviszonyFormák.Add(new Standard { Kód = "6", Megnevezés = "Fegyveres és rendvédelmi szervek hivatásos és szerződéses állományú szolgálati jogviszony" });
            JogviszonyFormák.Add(new Standard { Kód = "7", Megnevezés = "Bedolgozói jogviszony" });
            JogviszonyFormák.Add(new Standard { Kód = "8", Megnevezés = "Hivatásos nevelő szülői jogviszony" });
            JogviszonyFormák.Add(new Standard { Kód = "9", Megnevezés = "Szövetkezeti tag munkaviszony jellegű munkavégzésre irányuló jogviszony" });
            JogviszonyFormák.Add(new Standard { Kód = "10", Megnevezés = "Foglalkoztatásra irányuló egyéb jogviszony" });

            //Nyugdíjtípusok
            NyugdíjTípusok.Add(new Standard { Kód = "1", Megnevezés = "Teljes nyugdíj" });
            NyugdíjTípusok.Add(new Standard { Kód = "2", Megnevezés = "Résznyugdíj" });
            NyugdíjTípusok.Add(new Standard { Kód = "3", Megnevezés = "Nők kedvezményes nyugdíja" });
            NyugdíjTípusok.Add(new Standard { Kód = "4", Megnevezés = "Özvegyi nyugdíj" });

            //Legmagasabb Iskolai Végzettség
            IskolaiVégzettség.Add(new Standard { Kód = "1", Megnevezés = "Alapfokú (általános)" });
            IskolaiVégzettség.Add(new Standard { Kód = "2", Megnevezés = "Szakiskola (szakmunkásképző)" });
            IskolaiVégzettség.Add(new Standard { Kód = "3", Megnevezés = "Szakközépiskola" });
            IskolaiVégzettség.Add(new Standard { Kód = "4", Megnevezés = "Szakközépiskola + Technikum" });
            IskolaiVégzettség.Add(new Standard { Kód = "5", Megnevezés = "Gimnázium (végzettség érettségi)" });
            IskolaiVégzettség.Add(new Standard { Kód = "6", Megnevezés = "Szakmajegyzék(OKJ)" });
            IskolaiVégzettség.Add(new Standard { Kód = "7", Megnevezés = "Főiskola" });
            IskolaiVégzettség.Add(new Standard { Kód = "8", Megnevezés = "Egyetem" });


            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Properties.Settings.Default.felisz_db_ConnectionString;
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;

            #region Számlavezető bankok
            string sql = "SELECT * FROM Bankok";
            var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySql.Data.MySqlClient.MySqlDataReader dataReader = SQLCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Standard item = new Standard();
                    item.Kód = dataReader.GetString(0);
                    item.Megnevezés = dataReader.GetString(2);
                    SzámlavezetőBankok.Add(item);
                }
            }
            catch (Exception ex)
            {
                Adatbázis.Naplózás("21", Program.aktuálisCég + " " + Program.prefix + "---Adatbázis olvasási hiba (számlavezető bankok)!---" + ex);
                MessageBox.Show("Adatbázis olvasási hiba (számlavezető bankok)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            conn.Close();
            #endregion


            #region Országkódok
            sql = "SELECT * FROM OrszagKod";
            SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySql.Data.MySqlClient.MySqlDataReader dataReader = SQLCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Országkód item = new Országkód();
                    item.Kód = dataReader.GetString(0);
                    item.Ország = dataReader.GetString(1);
                    országKódokList.Add(item);
                }
            }
            catch (Exception ex)
            {
                Adatbázis.Naplózás("21", Program.aktuálisCég + " " + Program.prefix + "---Adatbázis olvasási hiba (országkódok)!---" + ex);
                //Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Adatbázis olvasási hiba (országkódok)!---" + ex);
                MessageBox.Show("Adatbázis olvasási hiba (országkódok)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            conn.Close();
            #endregion

            #region Irszám, város, utca
            sql = "SELECT * FROM IszVarosUtca ORDER BY IRSZAM";
            SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySql.Data.MySqlClient.MySqlDataReader dataReader = SQLCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    IszVárosUtca item = new IszVárosUtca();
                    item.Irsz = dataReader.GetString(1);
                    item.Város = dataReader.GetString(2);
                    item.Utca = dataReader.GetString(3);
                    iszVárosUtcaList.Add(item);

                }
                dataReader.Close();
                SQLCommand.Dispose();
            }
            catch (Exception ex)
            {
                Adatbázis.Naplózás("21", Program.aktuálisCég + " " + Program.prefix + "---Adatbázis olvasási hiba (Címek)!---" + ex);
                //Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Adatbázis olvasási hiba (Címek)!---" + ex);
                MessageBox.Show("Adatbázis olvasási hiba (Címek)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            conn.Close();
            #endregion

            #region FEOR
            sql = "SELECT * FROM FEOR ORDER BY FEOR4";
            SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySql.Data.MySqlClient.MySqlDataReader dataReader = SQLCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    FEOR item = new FEOR();
                    item.Feor4 = dataReader.GetString(3);
                    item.Megnevezés = dataReader.GetString(4);
                    FEORList.Add(item);
                }
                dataReader.Close();
                SQLCommand.Dispose();
            }
            catch (Exception ex)
            {
                Adatbázis.Naplózás("21", Program.aktuálisCég + " " + Program.prefix + "---Adatbázis olvasási hiba (FEOR)!---" + ex);
                //Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Adatbázis olvasási hiba (FEOR)!---" + ex);
                MessageBox.Show("Adatbázis olvasási hiba (FEOR)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            conn.Close();
            #endregion

            #region Csak Irszám
            string elozo = "";
            for (int i = 0; i < Adatbázis.iszVárosUtcaList.Count; i++)
            {
                IszVárosUtca item = new IszVárosUtca();
                item.Irsz = Adatbázis.iszVárosUtcaList[i].Irsz;
                item.Város = Adatbázis.iszVárosUtcaList[i].Város;
                if (elozo != item.Irsz)
                {
                    //Adatbázis.csakIrszámList.Add(item);
                    Adatbázis.csakVárosList.Add(item);
                }
                elozo = item.Irsz;
            }
            #endregion

            #region Csak Város
            /*
            elozo = "";
            for (int i = 0; i < Adatbázis.iszVárosUtcaList.Count; i++)
            {
                IszVárosUtca item = new IszVárosUtca();
                item.Irsz = Adatbázis.iszVárosUtcaList[i].Irsz;
                item.Város = Adatbázis.iszVárosUtcaList[i].Város;
                if (elozo != item.Irsz)
                {
                    Adatbázis.csakVárosList.Add(item);
                }
                elozo = item.Irsz;
            }
            */
            #endregion

            #region Foglalkoztató
            myConnectionString = Adatbázis.MyConnectionString();

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;

            sql = "SELECT * FROM CegTorzs order by ID";
            SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySql.Data.MySqlClient.MySqlDataReader dataReader = SQLCommand.ExecuteReader();
                while (dataReader.Read())
                {

                    FoglalkoztatásHelye item = new FoglalkoztatásHelye();


                    if (!dataReader.GetBoolean(dataReader.GetOrdinal("SzekhelyTelephely")))
                    {
                        item.ID = dataReader.GetInt16(dataReader.GetOrdinal("ID"));
                        item.FoglalkoztatóNeve = dataReader.GetString(dataReader.GetOrdinal("Neve"));
                        item.Irsz = dataReader.GetString(dataReader.GetOrdinal("SzekhelyIrsz"));
                        item.Város = dataReader.GetString(dataReader.GetOrdinal("SzekhelyVaros"));
                        item.Közterület = dataReader.GetString(dataReader.GetOrdinal("SzekhelyKozt"));
                        item.KözterületJellege = dataReader.GetString(dataReader.GetOrdinal("SzekhelyKoztJell"));
                        item.Házszám = dataReader.GetString(dataReader.GetOrdinal("SzekhelyHazSz"));
                        item.Megnevezés = item.Irsz + " " + item.Város + " " + item.Közterület + " " + item.KözterületJellege + " " + item.Házszám + ".";
                        foglalkoztatásHelyeList.Add(item);
                    }
                    else
                    {
                        item.ID = dataReader.GetInt16(dataReader.GetOrdinal("ID"));
                        item.FoglalkoztatóNeve = dataReader.GetString(dataReader.GetOrdinal("Neve"));
                        item.Irsz = dataReader.GetString(dataReader.GetOrdinal("TelepIrsz"));
                        item.Város = dataReader.GetString(dataReader.GetOrdinal("TelepVaros"));
                        item.Közterület = dataReader.GetString(dataReader.GetOrdinal("TelepKozt"));
                        item.KözterületJellege = dataReader.GetString(dataReader.GetOrdinal("TelepKoztJell"));
                        item.Házszám = dataReader.GetString(dataReader.GetOrdinal("TelepHazSz"));
                        item.Megnevezés = item.Irsz + " " + item.Város + " " + item.Közterület + " " + item.KözterületJellege + " " + item.Házszám + ".";
                        foglalkoztatásHelyeList.Add(item);
                    }



                }
                dataReader.Close();
                SQLCommand.Dispose();
            }
            catch (Exception ex)
            {
                Adatbázis.Naplózás("21", Program.aktuálisCég + " " + Program.prefix + "---Adatbázis olvasási hiba (Foglalkoztató)!---" + ex);
                //Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Adatbázis olvasási hiba (Foglalkoztató)!---" + ex);
                MessageBox.Show("Adatbázis olvasási hiba (Foglalkoztató)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            conn.Close();
            #endregion
        }

        public static bool AzonosítószámSzabad(int azonosítószám)
        {

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Adatbázis.MyConnectionString();

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;


            string sql = "SELECT SzemAzon FROM SzemTorzs WHERE SzemAzon=@azonosítószám";
            var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
            SQLCommand.Parameters.Add("@azonosítóSzám", MySql.Data.MySqlClient.MySqlDbType.VarString);
            SQLCommand.Parameters["@azonosítóSzám"].Value = azonosítószám;

            try
            {
                conn.Open();
                MySql.Data.MySqlClient.MySqlDataReader dataReader = SQLCommand.ExecuteReader();
                if (dataReader.Read())
                {
                    MessageBox.Show("Azonosítószám már foglalt!", "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Adatbázis.Naplózás("21", Program.aktuálisCég + " " + Program.prefix + "---Adatbázis olvasási hiba (Szabad azonosítószám)!---" + ex);
                //Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Adatbázis olvasási hiba (Szabad azonosítószám)!---" + ex);
                MessageBox.Show("Adatbázis olvasási hiba (Szabad azonosítószám)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            conn.Close();
            return true;
        }

        public static int AzonosítószámKövetkező()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Adatbázis.MyConnectionString();

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;


            string sql = "SELECT SzemAzon FROM SzemTorzs ORDER BY SzemAzon DESC LIMIT 1";
            var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySql.Data.MySqlClient.MySqlDataReader dataReader = SQLCommand.ExecuteReader();

                if (dataReader.Read()) return dataReader.GetInt32(0) + 1;

            }
            catch (Exception ex)
            {
                Adatbázis.Naplózás("21", Program.aktuálisCég + " " + Program.prefix + "---Adatbázis olvasási hiba (Következő azonosítószám)!---" + ex);
                //Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Adatbázis olvasási hiba (Következő azonosítószám)!---" + ex);
                MessageBox.Show("Adatbázis olvasási hiba (Következő azonosítószám)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return 0;
            }
            conn.Close();
            return 1;
        }

        public static void Naplózás(string szint, string bejegyzés)
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy.MM.dd") + " " + szint + " " + bejegyzés);
            //Egyes szint -> Justice-nak naplóz, kettes szint céges naplózás
            if (szint.StartsWith("1")) Adatbázis.NaplóÍrásJustice(szint.Substring(szint.Length - 1, 1), bejegyzés);
            if (szint.StartsWith("2")) Adatbázis.NaplóÍrásAurora(szint.Substring(szint.Length - 1, 1), bejegyzés);

        }

        public static void NaplóÍrásJustice(string szint, string bejegyzés)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Properties.Settings.Default.felisz_db_ConnectionString;
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            string sql = "INSERT INTO JusticeLog (DatumIdo, Bejegyzes, Szint, Feldolgozva) " +
                         "VALUES (@datum, @bejegyzes, @szint, 0)";


            var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
            SQLCommand.Parameters.Add("@datum", MySql.Data.MySqlClient.MySqlDbType.DateTime);
            SQLCommand.Parameters["@datum"].Value = DateTime.Now;

            SQLCommand.Parameters.Add("@bejegyzes", MySql.Data.MySqlClient.MySqlDbType.String);
            SQLCommand.Parameters["@bejegyzes"].Value = bejegyzés;

            SQLCommand.Parameters.Add("@szint", MySql.Data.MySqlClient.MySqlDbType.String);
            SQLCommand.Parameters["@szint"].Value = szint;

            SQLCommand.ExecuteNonQuery();

            conn.Close();

        }

        public static void NaplóÍrásAurora(string szint, string bejegyzés)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Adatbázis.MyConnectionString();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            string sql = "INSERT INTO AuroraLog (AdoSzam, DatumIdo, Bejegyzes, Szint) " +
                         "VALUES (@adoszam, @datum, @bejegyzes, @szint)";


            var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
            SQLCommand.Parameters.Add("@adoszam", MySql.Data.MySqlClient.MySqlDbType.String);
            SQLCommand.Parameters["@adoszam"].Value = Program.aktuálisCég;

            SQLCommand.Parameters.Add("@datum", MySql.Data.MySqlClient.MySqlDbType.DateTime);
            SQLCommand.Parameters["@datum"].Value = DateTime.Now;

            SQLCommand.Parameters.Add("@bejegyzes", MySql.Data.MySqlClient.MySqlDbType.String);
            SQLCommand.Parameters["@bejegyzes"].Value = bejegyzés;

            SQLCommand.Parameters.Add("@szint", MySql.Data.MySqlClient.MySqlDbType.String);
            SQLCommand.Parameters["@szint"].Value = szint;

            SQLCommand.ExecuteNonQuery();

            conn.Close();

        }





    }
}
