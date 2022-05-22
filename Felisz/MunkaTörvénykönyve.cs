using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Felisz
{
    class MunkaTörvénykönyve
    {

        
        public static List<MTRecord> törvények = new List<MTRecord>();
        

        public static bool MTFrissítése()
        {

            törvények.Clear();

            var url = Properties.Settings.Default.MTUrl;
            var web = new HtmlWeb();
            var htmlDoc = web.Load(url);

            string bodyText = htmlDoc.DocumentNode.SelectSingleNode(@"//body").InnerText;

            bodyText = bodyText.Replace("&#167;", "§");
            bodyText = bodyText.Replace("&nbsp;*&nbsp;", "");
            bodyText = bodyText.Replace("&#8222;", "/");
            bodyText = bodyText.Replace("&#8221;", "/");
            bodyText = bodyText.Replace("&#8722;", "-");





            string[] tördelt = bodyText.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            int sor = 0;
            bool töröl = true;
            bool összefűzEng = true;
            string törvényNr = "1";
            string törvényNrAl = "";
            string törvényTemp = "";
            string temp = "";
            string fejezetOld = "I";
            string fejezetNew = "I";



            while (sor < tördelt.Count())
            {
                //Első paragrafusig nem kell semmi...
                if (tördelt[sor].Substring(0, 4) == "1. §") töröl = false;
                if (töröl == false)
                {
                    törvényTemp += tördelt[sor] + System.Environment.NewLine;
                    sor++;
                    while (!(tördelt[sor] + "       ").Substring(0, 7).Contains(". §"))
                    {
                        temp = "          " + tördelt[sor];
                        if (temp.Substring(temp.Length - 9, temp.Length - (temp.Length - 9)) == ". fejezet" || temp.Substring(temp.Length - 10, temp.Length - (temp.Length - 10)) == ". fejezet*")
                        {
                            fejezetNew = tördelt[sor].Substring(0, tördelt[sor].IndexOf(". fejezet"));
                        }

                        // Fejezetekre nincsen szükség, átugorhatjuk (számmal kezdődik és nem tartalmazza a ". §" string-et)
                        if (tördelt[sor].Substring(0, 1).All(char.IsNumber) && !(tördelt[sor] + "       ").Substring(0, 7).Contains(". §"))
                        {
                            összefűzEng = false;
                        }
                        else
                        {
                            összefűzEng = true;
                        }

                        // Fejezet fejléc kihagyása
                        temp = "          " + tördelt[sor];
                        if (temp.Substring(temp.Length - 9, temp.Length - (temp.Length - 9)) == ". fejezet" || temp.Substring(temp.Length - 10, temp.Length - (temp.Length - 10)) == ". fejezet*")
                        {
                            összefűzEng = false;
                            sor++; //Mindig két törlendő sor van
                        }

                        // Rész fejléc kihagyása
                        temp = "          " + tördelt[sor];
                        if (temp.Substring(temp.Length - 4, temp.Length - (temp.Length - 4)) == "RÉSZ")
                        {
                            összefűzEng = false;
                            sor++; //Mindig két törlendő sor van
                        }

                        //Itt a vége
                        if ((tördelt[sor] + "          ").Substring(0, 10) == "Kihirdetve") break;

                        // Összefűzés
                        if (összefűzEng) törvényTemp += tördelt[sor] + System.Environment.NewLine;
                        sor++;
                        if (sor == tördelt.Count()) break;
                    }

                    // Paragrafus száma
                    törvényNr = törvényTemp.Substring(0, törvényTemp.IndexOf('§') - 2);
                    if (törvényNr.Contains("/"))
                    {
                        törvényNrAl = törvényTemp.Substring(törvényNr.Length - 1, 1);
                        törvényNr = törvényTemp.Substring(0, törvényTemp.IndexOf('§') - 4);

                    }
                    else
                    {
                        törvényNrAl = "";
                    }


                    MTRecord r = new MTRecord();
                    r.törvénySzöveg = törvényTemp;
                    r.törvényNr = törvényNr;
                    r.törvényNrAl = törvényNrAl;
                    r.fejezet = fejezetOld;
                    törvények.Add(r);
                    törvényTemp = "";
                    fejezetOld = fejezetNew;

                    // Vége...
                    if ((tördelt[sor] + "          ").Substring(0, 10) == "Kihirdetve") break;
                }
                else
                {
                    sor++;
                }

            }
            Adatbázis.Naplózás("23", Program.aktuálisCég + " " + Program.prefix + "---MT letöltése és tördelése kész!");
            //Program.logger.Info(Program.aktuálisCég + " " + Program.prefix + "---MT letöltése és tördelése kész!");

            if (!Adatbázis.AdatbázisEllenőrzéseMain())
            {
                Adatbázis.Naplózás("21", Program.aktuálisCég + " " + Program.prefix + "---Nincs DB kapcsolat, MT feltöltése meghiúsult!");
                //Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Nincs DB kapcsolat, MT feltöltése meghiúsult!");
                return false;
            }



            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Properties.Settings.Default.felisz_db_ConnectionString;
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            //Adatbázis törlése
            string sql = "TRUNCATE TABLE MT";
            var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

            try
            {
                SQLCommand.ExecuteNonQuery();
                Adatbázis.Naplózás("23", Program.aktuálisCég + " " + Program.prefix + "---MT DB törlése kész!");
                //Program.logger.Info(Program.aktuálisCég + " " + Program.prefix + "---MT DB törlése kész!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Adatbázis.Naplózás("21", Program.aktuálisCég + " " + Program.prefix + "---Hiba az MT tábla törlésekor!" + Environment.NewLine + ex.Message);
                //Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Hiba az MT tábla törlésekor!" + Environment.NewLine + ex.Message);
                return false;
            }


            foreach (var item in törvények)
            {
                /*
                   string fejezet = item.fejezet;
                   string parag = item.törvényNr;
                   string paragAl = item.törvényNrAl;
                   string torvy = item.törvénySzöveg;
                */
                sql = @"INSERT INTO MT (Fejezet, Paragrafus, ParagrafusAl, Torveny) VALUES ('" + item.fejezet + "', '" + item.törvényNr + "', '" + item.törvényNrAl + "', '" + item.törvénySzöveg + "')";
                SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                try
                {
                    SQLCommand.ExecuteNonQuery();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    Adatbázis.Naplózás("21", Program.aktuálisCég + " " + Program.prefix + "---Hiba az MT tábla DB-be történő töltésekor!" + Environment.NewLine + ex.Message);
                    //Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Hiba az MT tábla DB-be történő töltésekor!" + Environment.NewLine + ex.Message);
                    return false;
                }


            }
            Adatbázis.Naplózás("23", Program.aktuálisCég + " " + Program.prefix + "---MT feltöltése DB - be kész!");
            //Program.logger.Info(Program.aktuálisCég + " " + Program.prefix + "---MT feltöltése DB - be kész!");
            SQLCommand.Dispose();
            conn.Close();
            return true;
        }

        public static bool MTBetöltése()
        {
            if (!Adatbázis.AdatbázisEllenőrzéseMain())
            {
                Adatbázis.Naplózás("21", Program.aktuálisCég + " " + Program.prefix + "---Nincs DB kapcsolat, MT feltöltése meghiúsult!");
                //Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Nincs DB kapcsolat, MT feltöltése meghiúsult!");
                return false;
            }

            törvények.Clear();

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Properties.Settings.Default.felisz_db_ConnectionString;
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            string sql = "SELECT * FROM MT";
            var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

            try
            {
                MySql.Data.MySqlClient.MySqlDataReader dataReader = SQLCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    MTRecord r = new MTRecord();
                    r.fejezet = dataReader.GetString(0);
                    r.törvényNr = dataReader.GetString(1);
                    r.törvényNrAl = dataReader.GetString(2);
                    r.törvénySzöveg = dataReader.GetString(3);
                    törvények.Add(r);
                }
                dataReader.Close();
                SQLCommand.Dispose();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Adatbázis.Naplózás("21", Program.aktuálisCég + " " + Program.prefix + "---Hiba az MT betöltésekor!" + Environment.NewLine + ex.Message);
                //Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Hiba az MT betöltésekor!" + Environment.NewLine + ex.Message);
                return false;
            }

            Adatbázis.Naplózás("23", Program.aktuálisCég + " " + Program.prefix + "---Sikeres MT betöltés!");
            //Program.logger.Info(Program.aktuálisCég + " " + Program.prefix + "---Sikeres MT betöltés!");
            conn.Close();
            return true;
        }

        public static string MTParagrafusLekérdezés(string paragrafus, string paragrafusal)
        {
            MTRecord talalat = törvények.Find(item => item.törvényNr == paragrafus && item.törvényNrAl == paragrafusal);
            return talalat.törvénySzöveg;
        }

        

    }
}
