using HtmlAgilityPack;
using System;
using System.Collections.Generic;

namespace Felisz
{
    class VárosUtcanévImport
    {

        public static List<string> városok = new List<string>();
        public static List<IszVárosUtcaImport> városokutcák = new List<IszVárosUtcaImport>();
        public static bool VárosImport()
        {


            string irsz = "";
            string város = "";
            string utca = "";

            if (!Adatbázis.AdatbázisEllenőrzéseMain())
            {
                Adatbázis.Naplózás("21", "---Nincs DB (Main) kapcsolat, település és utcanév feltöltése meghiúsult!");
                //Program.logger.Error("---Nincs DB (Main) kapcsolat, település és utcanév feltöltése meghiúsult!");
                return false;
            }


            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Properties.Settings.Default.felisz_db_ConnectionString;
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();



            //Adatbázis törlése
            string sql = "TRUNCATE TABLE IszVarosUtca";
            var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

            try
            {
                SQLCommand.ExecuteNonQuery();
                Adatbázis.Naplózás("23", "---Település és utcanév DB törlése kész!");
                //Program.logger.Info("---Település és utcanév DB törlése kész!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Adatbázis.Naplózás("22", "---Hiba az település és utcanév tábla törlésekor!" + Environment.NewLine + ex.Message);
                //Program.logger.Error("---Hiba az település és utcanév tábla törlésekor!" + Environment.NewLine + ex.Message);
                return false;
            }


            var web = new HtmlWeb();

            for (int keres = 1000; keres <= 9999; keres++)
            {


                var url = "https://data2.openstreetmap.hu/irsz.php?tel=&ut=&irsz=" + keres;
                var htmlDoc = web.Load(url);
                string bodyText = htmlDoc.DocumentNode.SelectSingleNode(@"//body").InnerText;
                string[] tördelt = bodyText.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                if (tördelt.Length <= 45) continue;


                int sor = 0;
                while (tördelt[sor] != keres.ToString()) sor++;
                sor++;


                while (sor <= tördelt.Length)
                {



                    for (int i = 5; i < tördelt[sor].Length; i++)
                    {
                        if (tördelt[sor].Substring(i, 1).ToUpper() == tördelt[sor].Substring(i, 1))
                        {
                            irsz = tördelt[sor].Substring(0, 4);
                            város = tördelt[sor].Substring(4, i - 4);
                            //utca = tördelt[sor].Substring(i, tördelt[sor].Length - 6 - i);
                            utca = tördelt[sor].Substring(i, tördelt[sor].Length - i).Replace("Térkép", "").Replace("'", "");
                            Console.WriteLine(irsz + " " + város + " " + utca);
                            sql = @"INSERT INTO IszVarosUtca (IrSzam, Varos, Utca) VALUES ('" + irsz + "', '" + város + "', '" + utca + "')";
                            SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                            try
                            {
                                SQLCommand.ExecuteNonQuery();
                            }
                            catch (MySql.Data.MySqlClient.MySqlException ex)
                            {
                                Adatbázis.Naplózás("21", "---Hiba a település és utcanév tábla DB-be történő töltésekor!" + Environment.NewLine + ex.Message);
                                //Program.logger.Error("---Hiba a település és utcanév tábla DB-be történő töltésekor!" + Environment.NewLine + ex.Message);
                                return false;
                            }
                            break;
                        }

                    }
                    sor++;
                    if (tördelt[sor].Substring(0, 4) != keres.ToString()) break;

                }
            }




            /*
            
            var url = "https://data2.openstreetmap.hu/utcastat.php";
            var web = new HtmlWeb();
            var htmlDoc = web.Load(url);

            string bodyText = htmlDoc.DocumentNode.SelectSingleNode(@"//body").InnerText;


            string[] tördelt = bodyText.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            int sor = 0;
            while (tördelt[sor] != "Aba")
            {
                sor++;
            }

            while (sor < tördelt.Count())
            {
                if (tördelt[sor].Substring(0, 1).All(char.IsNumber) != true && tördelt[sor].Substring(0, 1) != " ")
                {
                    if (tördelt[sor].Length >= 9 && tördelt[sor].Substring(0, 9) == "Település") break;
                    városok.Add(tördelt[sor]);
                }
                sor++;
            }

            sor = 0;
            int tsor = 0;
            int számláló = 0;
            while (sor < városok.Count())
            {
                url = "https://data2.openstreetmap.hu/utcanev.php?utcanevek=" + városok[sor];
                htmlDoc = web.Load(url);
                bodyText = htmlDoc.DocumentNode.SelectSingleNode(@"//body").InnerText;
                tördelt = bodyText.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

                tsor = 0;
                while (tördelt[tsor] != "OSM id (JOSM link)")
                {
                    tsor++;
                }
                tsor++;

                számláló = 0;
                while (tsor < tördelt.Count())
                {


                    if (tördelt[tsor].Substring(0, 1) == " ") break;
                    IszVárosUtcaRecord r = new IszVárosUtcaRecord();
                    r.irányítószám = "9999";
                    r.város = városok[sor];
                    r.közterület = tördelt[tsor];
                    városokutcák.Add(r);
                    számláló++;

                    tsor = tsor + 3;
                    //Console.WriteLine(r.irányítószám + " " + r.város + " " + r.közterület);
                }
                Console.WriteLine(városok.Count() + " - " + sor.ToString());
                sor++;
            }


            */




            /*
            foreach (var item in városok)
            {
                
             

            
            }
            */

            Adatbázis.Naplózás("23", Program.aktuálisCég + " " + Program.prefix + "---Település és utcanév feltöltése DB - be kész!");
            //Program.logger.Info(Program.aktuálisCég + " " + Program.prefix + "---Település és utcanév feltöltése DB - be kész!");
            SQLCommand.Dispose();
            conn.Close();
            return true;
        }

    }
}
