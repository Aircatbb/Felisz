using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace Felisz
{
    class Funkciók
    {
        private static void CímkeSzínBeállítás(Label címke, bool engedélyezve)
        {
            if (engedélyezve == true)
            {
                címke.BackColor = Color.FromArgb(30, 30, 30);
                címke.ForeColor = Color.FromArgb(200, 200, 200);
            }
            else
            {
                címke.BackColor = Color.FromArgb(166, 66, 51);
                címke.ForeColor = Color.White;
            }
        }

        public static void DátumValidálás(Label címke, TextBox textboxneve, TextBox adóazon, Label adóazonCimke, bool üresEngedélyezve)
        {

            if (Funkciók.DátumFormázás(textboxneve.Text).ToString("yyyy.MM.dd") != DateTime.MinValue.ToString("yyyy.MM.dd"))
            {
                textboxneve.Text = Funkciók.DátumFormázás(textboxneve.Text).ToString("yyyy.MM.dd");
                CímkeSzínBeállítás(címke, true);

                if (adóazon != null)
                {
                    if (DateTime.Parse(textboxneve.Text) < DateTime.Now.AddYears(-16))
                    {
                        adóazon.Enabled = true; //az adószám ellőnrzése csak a szül. dátum megadásával lehetséges
                        CímkeSzínBeállítás(címke, true);
                        CímkeSzínBeállítás(adóazonCimke, false);

                    }
                    else
                    {
                        if (DateTime.Parse(textboxneve.Text) <= DateTime.Now)
                        {
                            TTS.TTS_StopAll();
                            TTS.TTS_Play("Figyelem! Kiskorúak foglalkoztatását a törvény bünteti!", false);
                            MessageBox.Show("Kiskorúak foglalkoztatását a törvény bünteti!" + Environment.NewLine +
                                "A 16. életévét betöltött de 18 évnél fiatalabb személy is" + Environment.NewLine +
                                "csupán törvényes képviselője hozzájárulása birtokában" + Environment.NewLine +
                                "köthet érvényesen munkaszerződést!"
                                , "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            adóazon.Enabled = false;
                            CímkeSzínBeállítás(címke, false);
                            TTS.TTS_RSS_Resume();

                        }
                    }

                }


                if (DateTime.Parse(textboxneve.Text) >= DateTime.Now) CímkeSzínBeállítás(címke, false);


            }
            else
            {
                CímkeSzínBeállítás(címke, false);
                if (üresEngedélyezve && textboxneve.Text == "") CímkeSzínBeállítás(címke, true);
                if (adóazon != null) adóazon.Enabled = false;
            }
        }

        public static void NévValidálás(Label címkeneve, TextBox textboxneve, TextBox együttMódosítandótb, bool üresEngedélyezve)
        {
            if (üresEngedélyezve == false && textboxneve.Text.Length >= 2) üresEngedélyezve = true;

            if (üresEngedélyezve && !Funkciók.UtolsóKarakterSzóköz(textboxneve) && !Funkciók.StringTartalmazSzámot(textboxneve.Text))
            {
                CímkeSzínBeállítás(címkeneve, true);
                if (együttMódosítandótb != null) if (együttMódosítandótb.Text == "") együttMódosítandótb.Text = textboxneve.Text;
            }
            else
            {
                CímkeSzínBeállítás(címkeneve, false);
            }

        }

        public static string licDB = "---Üres---";

        public static void TopKonzolKiírás(string szöveg)
        {
            Label konzol = Application.OpenForms["formFelisz"].Controls["panelTopMenu"].Controls["lbStátusz"] as Label;
            konzol.Text = szöveg;
            konzol.Visible = true;
        }

        public static string LicencReg(string licenc, bool RW)
        {
            RegistryKey licKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Felisz\\Felisz", true);

            if (RW)
            {

                licKey.SetValue("LicKey", licenc);
                licKey.Close();
                return "";
            }
            else
            {
                if (Registry.GetValue(licKey.ToString(), "LicKey", null) != null)
                {
                    Program.kódoltLic = licKey.GetValue("Lickey").ToString();
                    return licKey.GetValue("Lickey").ToString();
                }
                return "";
            }


        }

        public static void TTSRegÍrás(bool engedélyezve, int beszHangerő, int beszSebesség, string beszNyelv)
        {
            RegistryKey TTSKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Felisz\\Felisz\\", true);

            TTSKey.SetValue("TTSEnabled", engedélyezve);
            Program.TTSEngedélyezve = engedélyezve;


            TTSKey.SetValue("TTSVolume", beszHangerő);
            Program.TTSHangerő = beszHangerő;

            TTSKey.SetValue("TTSSpeed", beszSebesség);
            Program.TTSSebesség = beszSebesség;

            TTSKey.SetValue("TTSLanguage", beszNyelv);
            Program.TTSNyelv = beszNyelv;



            TTSKey.Close();
        }

        public static void TTSRegOlvasás()
        {
            RegistryKey TTSKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Felisz\\Felisz\\", true);


            //Engedélyezés
            if (Registry.GetValue(TTSKey.ToString(), "TTSEnabled", null) == null)
            {
                TTSKey.SetValue("TTSEnabled", false);
                Program.TTSEngedélyezve = false;
            }

            if (TTSKey.GetValue("TTSEnabled").ToString() == "True")
            {
                Program.TTSEngedélyezve = true;
            }
            else
            {
                Program.TTSEngedélyezve = false;
            }

            //Hangerő
            if (Registry.GetValue(TTSKey.ToString(), "TTSVolume", null) == null)
            {
                TTSKey.SetValue("TTSVolume", 33);
                Program.TTSHangerő = 33;
            }

            Program.TTSHangerő = int.Parse(TTSKey.GetValue("TTSVolume").ToString());

            //Sebesség
            if (Registry.GetValue(TTSKey.ToString(), "TTSSpeed", null) == null)
            {
                TTSKey.SetValue("TTSSpeed", 0);
                Program.TTSSebesség = 0;
            }

            Program.TTSSebesség = int.Parse(TTSKey.GetValue("TTSSPeed").ToString());

            //Nyelv
            if (Registry.GetValue(TTSKey.ToString(), "TTSLanguage", null) == null)
            {

                //Amennyiben van magyar nyelv telepítve, úgy annak kiválasztása, ellenkező esetben az első találat
                string nyelv = "";
                bool találat = false;
                var voice = TTS.hang.GetInstalledVoices();
                for (int i = 0; i < voice.Count; i++)
                {
                    if (voice[i].VoiceInfo.Culture.ToString() == "shu-HU")
                    {
                        nyelv = voice[i].VoiceInfo.Name;
                        találat = true;
                        break;
                    }
                }

                if (találat)
                {
                    TTSKey.SetValue("TTSLanguage", nyelv);
                    Program.TTSNyelv = nyelv;
                }
                else
                {
                    TTSKey.SetValue("TTSLanguage", voice[0].VoiceInfo.Name);
                    Program.TTSNyelv = voice[0].VoiceInfo.Name;
                    Program.TTSEngedélyezve = false;
                    TTSKey.SetValue("TTSEnabled", false);
                }
            }

            Program.TTSNyelv = TTSKey.GetValue("TTSLanguage").ToString();


            TTSKey.Close();





        }

        public static void VerzióVáltozásLog()
        {
            string verJelenlegi = Assembly.GetEntryAssembly().GetName().Version.ToString();


            RegistryKey verKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Felisz\\Felisz\\", true);



            if (Registry.GetValue(verKey.ToString(), "Version", null) == null)
            {
                Formok.formVáltozásLista vv = new Formok.formVáltozásLista();
                vv.ShowDialog();
                verKey.SetValue("Version", verJelenlegi);
                verKey.Close();
                return;
            }


            if ((string)Registry.GetValue(verKey.ToString(), "Version", "") != verJelenlegi)
            {
                Formok.formVáltozásLista vv = new Formok.formVáltozásLista();
                vv.ShowDialog();
            }

            verKey.SetValue("Version", verJelenlegi);
            verKey.Close();
        }

        public static bool UtolsóKarakterSzóköz(TextBox mező)
        {
            if (mező.Text.Length == 0) return false;
            if (mező.Text.Substring(mező.Text.Length - 1, 1) == " ") return true;
            return false;
        }

        public static DateTime DátumFormázás(string beDátum)
        {
            try
            {
                Regex rgx = new Regex("[^0-9]");
                string tempDate = rgx.Replace(beDátum, "");
                return new DateTime(int.Parse(tempDate.Substring(0, 4)), int.Parse(tempDate.Substring(4, 2)), int.Parse(tempDate.Substring(6, 2)));
            }
            catch (Exception)
            {
                return DateTime.MinValue;
            }
        }

        public static bool StringTartalmazSzámot(string szöveg)
        {
            if (szöveg.Any(char.IsDigit)) return true;
            return false;
        }

        public static DialogResult InputBox(string fejléc, string szöveg, ref string érték)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = fejléc;
            label.Text = szöveg;
            textBox.Text = érték;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Bezárás";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            érték = textBox.Text;
            return dialogResult;
        }

        public static DialogResult InputBoxLicenc(string fejléc, string szöveg, ref string licenc, ref string prefix)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox1 = new TextBox();
            TextBox textBox2 = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = fejléc;
            label.Text = szöveg;
            textBox1.Text = licenc;
            textBox2.Text = prefix;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Bezárás";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox1.SetBounds(12, 36, 372, 20);
            textBox2.SetBounds(12, 72, 372, 20);

            buttonOk.SetBounds(228, 108, 75, 23);
            buttonCancel.SetBounds(309, 108, 75, 23);

            label.AutoSize = true;
            textBox1.Anchor = textBox1.Anchor | AnchorStyles.Right;
            textBox2.Anchor = textBox2.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 143);
            form.Controls.AddRange(new Control[] { label, textBox1, textBox2, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            licenc = textBox1.Text;
            prefix = textBox2.Text;
            return dialogResult;
        }

        public static DialogResult InputBoxJelszóVált(ref string jelenlegiJelszó, ref string újJelszó, ref string újJelszóIsm)
        {
            Form form = new Form();
            Label label = new Label();

            MaskedTextBox textBox1 = new MaskedTextBox();
            textBox1.UseSystemPasswordChar = true;
            MaskedTextBox textBox2 = new MaskedTextBox();
            textBox2.UseSystemPasswordChar = true;
            MaskedTextBox textBox3 = new MaskedTextBox();
            textBox3.UseSystemPasswordChar = true;
            Label lbJelenlegi = new Label();
            Label lbÚj = new Label();
            Label lbÚjism = new Label();

            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = "Jelszóváltoztatás";
            label.Text = "Kérem, adja meg jelenlegi, majd az új jelszavát!" + Environment.NewLine +
                "(Tartalmaznia kell kis-, nagybetüt, számot és szimbólumot!" + Environment.NewLine +
                "Hossza minimum 8, maximum 32 karakter!)";
            //textBox1.Text = jelenlegiJelszó;
            //textBox2.Text = újJelszó;
            //textBox3.Text = újJelszóIsm;
            lbJelenlegi.Text = jelenlegiJelszó;
            lbÚj.Text = újJelszó;
            lbÚjism.Text = újJelszóIsm;

            buttonOk.Text = "Változtatás";
            buttonCancel.Text = "Megszakít";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);

            lbJelenlegi.SetBounds(12, 72, 372, 20);
            textBox1.SetBounds(12, 92, 372, 20);

            lbÚj.SetBounds(12, 122, 372, 20);
            textBox2.SetBounds(12, 142, 372, 20);

            lbÚjism.SetBounds(12, 172, 372, 20);
            textBox3.SetBounds(12, 192, 372, 20);

            buttonOk.SetBounds(228, 228, 75, 23);
            buttonCancel.SetBounds(309, 228, 75, 23);

            label.AutoSize = true;
            textBox1.Anchor = textBox1.Anchor | AnchorStyles.Right;
            textBox2.Anchor = textBox2.Anchor | AnchorStyles.Right;
            textBox3.Anchor = textBox3.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 264);
            form.Controls.AddRange(new Control[] { label, lbJelenlegi, textBox1, lbÚj, textBox2, lbÚjism, textBox3, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            form.BringToFront();

            DialogResult dialogResult = form.ShowDialog();

            jelenlegiJelszó = textBox1.Text;
            újJelszó = textBox2.Text;
            újJelszóIsm = textBox3.Text;
            return dialogResult;
        }

        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "xs~7$(uK2J}8K[tS";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        public static string Encrypt(string clearText)
        {
            string EncryptionKey = "xs~7$(uK2J}8K[tS";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;

        }

        public static bool LicencEllenőrzés()
        {

            string licID = "";

            //Lokális licenckód ellenőrzése
            try
            {
                Program.dekódoltLic = Funkciók.Decrypt(Funkciók.LicencReg("", false));
                //Program.dekódoltLic = Funkciók.Decrypt(Properties.Settings.Default.licencKódOLD);
                Program.licÉrvényesség = new DateTime(int.Parse(Program.dekódoltLic.Substring(0, 4)), int.Parse(Program.dekódoltLic.Substring(4, 2)), int.Parse(Program.dekódoltLic.Substring(6, 2)));
                Program.aktuálisCég = Program.dekódoltLic.Substring(24, 5);
                Program.prefix = Program.dekódoltLic.Substring(29, Program.dekódoltLic.Length - 29);
                Program.jelszóLic = Program.dekódoltLic.Substring(8, 16);
                if (!Adatbázis.AdatbázisEllenőrzéseCég()) return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Érvénytelen a lokálisan tárolt licenckód!" + Environment.NewLine +
                    "Kérem ellenőrizze az ADMIN felületen!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Program.logger.Error("Érvénytelen a lokálisan tárolt licenckód! ");
                return false;
            }

            if (!Adatbázis.AdatbázisEllenőrzéseMain())
            {
                Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Nincs DB kapcsolat, licencellenőrzés meghiúsult!");
                return false;
            }

            //DB-ben tárolt licenckód letöltése
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Adatbázis.MyConnectionString();

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            string sql = "SELECT Licenc, ID FROM Licenc WHERE Aktiv=1 AND Licenc=@licKód";
            var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
            SQLCommand.Parameters.Add("@licKód", MySql.Data.MySqlClient.MySqlDbType.VarString);
            SQLCommand.Parameters["@licKód"].Value = Funkciók.LicencReg("", false);
            //SQLCommand.Parameters["@licKód"].Value = Properties.Settings.Default.licencKódOLD;


            try
            {
                MySql.Data.MySqlClient.MySqlDataReader dataReader = SQLCommand.ExecuteReader();


                if (dataReader.HasRows == false)
                {
                    Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---A megadott licenckód nem aktív!---");
                    MessageBox.Show("A megadott licenckód nem aktív!" + Environment.NewLine +
                        "Kérjük, vegye fel a kapcsolatot az ügyfélszolgálattal!",
                        "Licenc hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;
                }


                dataReader.Read();
                licDB = dataReader.GetString(0);
                licID = dataReader.GetString(1);
                dataReader.Close();
                SQLCommand.Dispose();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Nem sikerült a licenckód ellenőrzése!---" + ex);
                MessageBox.Show("Nem sikerült a licenckód ellenőrzése!" + Environment.NewLine +
                        "Kérjük, vegye fel a kapcsolatot az ügyfélszolgálattal!",
                        "Licenc hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            conn.Close();

            //Lokális és DB-ben tárolt licenc összevetése
            if (Funkciók.LicencReg("", false) != licDB)
            //if (Properties.Settings.Default.licencKódOLD != licDB)
            {
                Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Nem egyeznek a licenckódok!");
                MessageBox.Show("Nem egyeznek a licenckódok!" + Environment.NewLine +
                        "Kérjük, vegye fel a kapcsolatot az ügyfélszolgálattal!",
                        "Licenc hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }



            //Érvényességi idő ellenőrzése
            if (Program.licÉrvényesség < DateTime.Today)
            {
                MessageBox.Show("A LICENC ÉRVÉNYESSÉGE LEJÁRT!" + Environment.NewLine + Environment.NewLine +
                        "Kérem adja meg az új licenckódot az ADMIN menüben, vagy vegye fel a kapcsolatot az ügyfélszolgálattal!" + Environment.NewLine + Environment.NewLine +
                        "Ügyfélszolgálat" + Environment.NewLine +
                        "Telefon: " + Properties.Settings.Default.ügyfélSzolgTel + Environment.NewLine +
                        "E-Mail: " + Properties.Settings.Default.ügyfélSzolgEmail, "Lejárt licenckód", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Lejárt a licenc!");


                //Licenc deaktiválása a DB-ben
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                sql = "UPDATE Licenc SET Aktiv=0 Where ID=" + licID;
                SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                SQLCommand.ExecuteNonQuery();
                SQLCommand.Dispose();
                conn.Close();
                Program.logger.Warn(Program.aktuálisCég + " " + Program.prefix + "---Lejárt licenc deaktiválva!");

                return false;
            }


            Program.logger.Info(Program.aktuálisCég + " " + Program.prefix + "---Sikeres licenc ellenőrzés!");
            return true;
        }

        public static void LicencAktiválás()
        {
            //Aktiválás üres licenckód esetén
            //Properties.Settings.Default.Reset();
            if (Funkciók.LicencReg("", false) == "")
            //if (Properties.Settings.Default.licencKódOLD == "")
            {
                if (MessageBox.Show("A PROGRAMOT HASZNÁLAT ELÖTT AKTIVÁLNI KELL!" + Environment.NewLine + Environment.NewLine +
                    "Amennyiben rendelkezik érvényes licenckóddal, nyomja meg az 'Igen' gombot, ellenkező esetben a 'nem' gombbal kiléphet." + Environment.NewLine + Environment.NewLine +
                    "Ügyfélszolgálat" + Environment.NewLine +
                    "Telefon: " + Properties.Settings.Default.ügyfélSzolgTel + Environment.NewLine +
                    "E-Mail: " + Properties.Settings.Default.ügyfélSzolgEmail, "Aktiválás szükséges", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
                {
                    Program.logger.Error("Nincs megadva licenckód!");
                    Application.Exit();
                }


                bool aktiválásOK = false;
                while (aktiválásOK == false)
                {
                    string licencKód = "Licenckód";
                    string prefix = "Prefix";
                    if (Funkciók.InputBoxLicenc("Aktiválás", "Kérem adja meg a licenckódot:", ref licencKód, ref prefix) == DialogResult.OK)
                    {
                        try
                        {
                            Program.dekódoltLic = Funkciók.Decrypt(licencKód);
                            Program.licÉrvényesség = new DateTime(int.Parse(Program.dekódoltLic.Substring(0, 4)), int.Parse(Program.dekódoltLic.Substring(4, 2)), int.Parse(Program.dekódoltLic.Substring(6, 2)));
                            Program.aktuálisCég = Program.dekódoltLic.Substring(24, 5);
                            Program.prefix = Program.dekódoltLic.Substring(29, Program.dekódoltLic.Length - 29);

                            if (Program.prefix == prefix)
                            {
                                Funkciók.LicencReg(licencKód, true);
                                //Properties.Settings.Default.licencKódOLD = licencKód;
                                //Properties.Settings.Default.Save();
                                aktiválásOK = true;

                                Program.logger.Info(Program.aktuálisCég + " " + Program.prefix + "---Sikeres licenec aktiválás!---" + Program.aktuálisCég + " " + Program.prefix + "---");
                                MessageBox.Show("Sikeres licenc aktiválás!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                MessageBox.Show("Érvénytelen prefix!" + Environment.NewLine +
                                "Kérem próbálja meg újra!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                Program.logger.Warn("Érvénytelen prefix az aktiváláskor! ");
                            }

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Érvénytelen licenckód!" + Environment.NewLine +
                                "Kérem próbálja meg újra!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            Program.logger.Warn("Érvénytelen licenckód az aktiváláskor!");
                        }

                    }
                    else
                    {
                        Program.logger.Error("Licenckód megadása megszakítva!");
                        Application.Exit();
                        Environment.Exit(0);
                    }

                }
            }

        }

        public static bool MenüJogosultságok(string felhasznalo, ref List<string> Jogosultságok)
        {

            if (Adatbázis.AdatbázisEllenőrzéseCég() == false) return false;
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Adatbázis.MyConnectionString();

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            string sql = "SELECT * FROM Felhasznalok WHERE felhasznalo=@felhasznalo";
            var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

            SQLCommand.Parameters.Add("@felhasznalo", MySql.Data.MySqlClient.MySqlDbType.String);
            SQLCommand.Parameters["@felhasznalo"].Value = felhasznalo;



            try
            {
                MySql.Data.MySqlClient.MySqlDataReader dataReader = SQLCommand.ExecuteReader();
                dataReader.Read();

                for (int i = dataReader.GetOrdinal("Aktiv") + 1; i < dataReader.FieldCount; i++)
                {
                    if (dataReader.GetBoolean(i))
                    {
                        Jogosultságok.Add(dataReader.GetName(i));
                    }
                }
                dataReader.Close();
                SQLCommand.Dispose();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Nem sikerült a jogosultságokat beolvasni az adatbázisból!---" + ex);
                return false;
            }
            conn.Close();


            return true;
        }

        public static bool DátumEllenőrzés()
        {


            try
            {
                var myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");
                var response = myHttpWebRequest.GetResponse();
                string todaysDates = response.Headers["date"];
                var helyiDátumIdő = DateTime.ParseExact(todaysDates, "ddd, dd MMM yyyy HH:mm:ss 'GMT'", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.AssumeUniversal);
                var lokálisDátumIdő = DateTime.Now;
                int különbség = (int)(lokálisDátumIdő - helyiDátumIdő).TotalDays;

                if (Math.Abs(különbség) < 1)
                {
                    Program.logger.Info(Program.aktuálisCég + " " + Program.prefix + "---Dátumellenőrzés rendben");
                    return true;
                }

                Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Hibás a lokális dátumbeállítás!");
                MessageBox.Show("A dátumbeállítás nem megfelelő, kérem ellenőrizze!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            catch (Exception ex)
            {
                Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Online dátumellenőrzés sikertelen!---" + Environment.NewLine + ex);
                MessageBox.Show("Online dátumellenőrzés sikertelen!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;

            }

        }

        public static bool JelszóMódosítás(bool első)
        {
            string jelenlegiJelszó = "Jelenlegi jelszó";
            string újJelszó = "Új jelszó";
            string úJJelszóIsm = "Új jelszó ismételten";
            if (Funkciók.InputBoxJelszóVált(ref jelenlegiJelszó, ref újJelszó, ref úJJelszóIsm) == DialogResult.OK)
            {
                // Ha nem egyezik a régi jelszó
                if (jelenlegiJelszó != Funkciók.Decrypt(Program.jelszó))
                {
                    MessageBox.Show("A jelenlegi jelszó nem egyezik!" + Environment.NewLine +
                        "Kérem, próbálja meg újra!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;
                }
                // Ha nem egyezik az új jelszó
                if (újJelszó != úJJelszóIsm)
                {
                    MessageBox.Show("A megadott jelszavak nem egyeznek!" + Environment.NewLine +
                        "Kérem, próbálja meg újra!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;
                }

                //Ha nem felel meg a követelményeknek
                Regex r = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[~ˇ^˘°˛`§÷×äđĐłŁß¤¨˙´' #?!@$%^&*-+,.()/:;<=>_|{}]).{8,32}$");

                if (r.IsMatch(újJelszó) != true)
                {
                    MessageBox.Show("Az új jelszó nem felel meg a követelményeknek!" + Environment.NewLine +
                        "(Tartalmaznia kell kis-, nagybetüt, számot és szimbólumot!" + Environment.NewLine +
                    "Hossza minimum 8, maximum 32 karakter!)" + Environment.NewLine +
                        "Kérem, próbálja meg újra!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;
                }

                try
                {
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = Adatbázis.MyConnectionString();
                    conn = new MySql.Data.MySqlClient.MySqlConnection();
                    conn.ConnectionString = myConnectionString;
                    conn.Open();



                    DateTime érvDátum = DateTime.Now.AddDays(Properties.Settings.Default.jelszóÉrvényesség);

                    //string sql = "UPDATE Felhasznalok SET Jelszo='" + Funkciók.Encrypt(újJelszó) + "', ElsoBe=0, JelszoErv='" + érvDátum.ToString("yyyy.MM.dd") + "' Where Felhasznalo='" + Program.aktuálisFelhasználó + "' AND Aktiv=1";
                    string sql = "UPDATE Felhasznalok SET Jelszo=@jelszo, ElsoBe=0, JelszoErv='" + érvDátum.ToString("yyyy.MM.dd") + "' Where Felhasznalo=@felhasznalo AND Aktiv=1";
                    var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                    SQLCommand.Parameters.Add("@jelszo", MySql.Data.MySqlClient.MySqlDbType.VarString);
                    SQLCommand.Parameters["@jelszo"].Value = Funkciók.Encrypt(újJelszó);
                    SQLCommand.Parameters.Add("@felhasznalo", MySql.Data.MySqlClient.MySqlDbType.VarString);
                    SQLCommand.Parameters["@felhasznalo"].Value = Program.aktuálisFelhasználó;



                    SQLCommand.ExecuteNonQuery();
                    SQLCommand.Dispose();
                    conn.Close();
                    Program.logger.Info(Program.aktuálisCég + " " + Program.prefix + "---Sikeres jelszómódosítás!---" + Program.aktuálisFelhasználó + "---");
                    MessageBox.Show("Sikeres jelszómódosítás!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (Exception ex)
                {
                    Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Nem sikerült a jelszómódosítás írása az adatbázisba!---" + Environment.NewLine + ex);
                    MessageBox.Show("Nem sikerült a jelszómódosítás írása az adatbázisba!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;
                }

            }
            if (első == true) //Amenyiben az első bejelentkezéskori jelszóváltoztatás történik, úgy ne engedlye bezárni
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool JelszóÉrvényességEllenőrzése()
        {


            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = Adatbázis.MyConnectionString();

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            string sql = "SELECT ElsoBe, JelszoErv FROM Felhasznalok WHERE Aktiv=1 AND Felhasznalo=@felhasznalo";
            var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
            SQLCommand.Parameters.Add("@felhasznalo", MySql.Data.MySqlClient.MySqlDbType.String);
            SQLCommand.Parameters["@felhasznalo"].Value = Program.aktuálisFelhasználó;


            bool elsőBe = true;
            DateTime jelszóÉrv;
            try
            {
                MySql.Data.MySqlClient.MySqlDataReader dataReader = SQLCommand.ExecuteReader();
                dataReader.Read();
                elsőBe = dataReader.GetBoolean(0);
                jelszóÉrv = dataReader.GetDateTime(1);
                dataReader.Close();
                SQLCommand.Dispose();
                conn.Close();


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Program.logger.Error(Program.aktuálisCég + " " + Program.prefix + "---Sikertelen elsőbejelentkezés ellenőrzés (DB)!---" + ex);
                return true;
            }

            if (elsőBe == true)
            {

                MessageBox.Show("Első bejelentkezéskor a jelszót módosítani kell!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            if (jelszóÉrv.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("A jelszó érvényessége lejárt, kérem módosítsa!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }


            return false;


        }

        public static bool TajszámEllenőrzés(string tajszám)
        {
            try
            {
                int sz1 = int.Parse(tajszám.Substring(0, 1)) * 3;
                int sz2 = int.Parse(tajszám.Substring(1, 1)) * 7;
                int sz3 = int.Parse(tajszám.Substring(2, 1)) * 3;
                int sz4 = int.Parse(tajszám.Substring(3, 1)) * 7;
                int sz5 = int.Parse(tajszám.Substring(4, 1)) * 3;
                int sz6 = int.Parse(tajszám.Substring(5, 1)) * 7;
                int sz7 = int.Parse(tajszám.Substring(6, 1)) * 3;
                int sz8 = int.Parse(tajszám.Substring(7, 1)) * 7;
                int cvd = (sz1 + sz2 + sz3 + sz4 + sz5 + sz6 + sz7 + sz8) % 10;
                if (cvd == int.Parse(tajszám.Substring(8, 1))) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool AdószámEllenőrzés(string adószám)
        {
            try
            {
                int sz1 = int.Parse(adószám.Substring(0, 1)) * 9;
                int sz2 = int.Parse(adószám.Substring(1, 1)) * 7;
                int sz3 = int.Parse(adószám.Substring(2, 1)) * 3;
                int sz4 = int.Parse(adószám.Substring(3, 1)) * 1;
                int sz5 = int.Parse(adószám.Substring(4, 1)) * 9;
                int sz6 = int.Parse(adószám.Substring(5, 1)) * 7;
                int sz7 = int.Parse(adószám.Substring(6, 1)) * 3;
                int cvd = (10 - ((sz1 + sz2 + sz3 + sz4 + sz5 + sz6 + sz7) % 10)) % 10;
                if (cvd != int.Parse(adószám.Substring(7, 1))) return false;
                if (int.Parse(adószám.Substring(9, 1)) < 1 || int.Parse(adószám.Substring(9, 1)) > 5) return false;


                if ((int.Parse(adószám.Substring(11, 2)) < 2 ||
                    int.Parse(adószám.Substring(11, 2)) > 44 ||
                    int.Parse(adószám.Substring(11, 2)) == 21) &&
                    int.Parse(adószám.Substring(11, 2)) != 51) return false;

                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }

        public static bool AdóazonosítóEllenőrzése(string adóAzonosító, DateTime szülDátum)
        {
            try
            {
                if (adóAzonosító.Substring(0, 1) != "8") return false;
                DateTime kezdDatum = new DateTime(1867, 1, 1);
                int eltelNapok = (szülDátum - kezdDatum).Days;
                int sz1 = int.Parse(adóAzonosító.Substring(0, 1)) * 1;
                int sz2 = int.Parse(adóAzonosító.Substring(1, 1)) * 2;
                int sz3 = int.Parse(adóAzonosító.Substring(2, 1)) * 3;
                int sz4 = int.Parse(adóAzonosító.Substring(3, 1)) * 4;
                int sz5 = int.Parse(adóAzonosító.Substring(4, 1)) * 5;
                int sz6 = int.Parse(adóAzonosító.Substring(5, 1)) * 6;
                int sz7 = int.Parse(adóAzonosító.Substring(6, 1)) * 7;
                int sz8 = int.Parse(adóAzonosító.Substring(7, 1)) * 8;
                int sz9 = int.Parse(adóAzonosító.Substring(8, 1)) * 9;
                int cvd = (sz1 + sz2 + sz3 + sz4 + sz5 + sz6 + sz7 + sz8 + sz9) % 11;
                string adóCheck = "8" + eltelNapok.ToString() + adóAzonosító.Substring(6, 1) + adóAzonosító.Substring(7, 1) + adóAzonosító.Substring(8, 1) + cvd.ToString();
                if (adóAzonosító == adóCheck) return true;

                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static bool CégjegyzékszámEllenőrzése(string cégjegyzékszám)
        {
            try
            {
                if (int.Parse(cégjegyzékszám.Substring(0, 2)) < 1 || int.Parse(cégjegyzékszám.Substring(0, 2)) > 20) return false;
                if (int.Parse(cégjegyzékszám.Substring(0, 2)) < 1 || int.Parse(cégjegyzékszám.Substring(0, 2)) > 20) return false;
                if (int.Parse(cégjegyzékszám.Substring(3, 2)) < 1 || int.Parse(cégjegyzékszám.Substring(3, 2)) > 23) return false;
                if (cégjegyzékszám.Substring(2, 1) != "-" || cégjegyzékszám.Substring(5, 1) != "-") return false;
                if (cégjegyzékszám.Length != 12) return false;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool SzámlaszámEllenőrzés(string számlaSzám)
        {
            int tol = 0;

            try
            {
                while (tol < 19)
                {
                    int sz1 = int.Parse(számlaSzám.Substring(tol + 0, 1)) * 9;
                    int sz2 = int.Parse(számlaSzám.Substring(tol + 1, 1)) * 7;
                    int sz3 = int.Parse(számlaSzám.Substring(tol + 2, 1)) * 3;
                    int sz4 = int.Parse(számlaSzám.Substring(tol + 3, 1)) * 1;
                    int sz5 = int.Parse(számlaSzám.Substring(tol + 4, 1)) * 9;
                    int sz6 = int.Parse(számlaSzám.Substring(tol + 5, 1)) * 7;
                    int sz7 = int.Parse(számlaSzám.Substring(tol + 6, 1)) * 3;
                    int sz8 = int.Parse(számlaSzám.Substring(tol + 7, 1)) * 1;
                    int cvd = (sz1 + sz2 + sz3 + sz4 + sz5 + sz6 + sz7 + sz8) % 10;
                    if (cvd != 0) return false;
                    tol = tol + 9;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }

        public static bool GoogleMapsTávolság(string cím1, string cím2, ref string távolság)
        {
            try
            {
                string url = "https://maps.googleapis.com/maps/api/distancematrix/xml?origins=" + cím1 + "&destinations=" + cím2 + "&key=" + Properties.Settings.Default.GoogleMapsAPI;
                WebRequest request = WebRequest.Create(url);
                WebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                DataSet dsResult = new DataSet();
                dsResult.ReadXml(reader);
                //var idő = dsResult.Tables["duration"].Rows[0]["text"].ToString();
                távolság = dsResult.Tables["distance"]?.Rows[0]["text"].ToString();
                return true;
            }
            catch (Exception)
            {
                return false;
            }





        }

        public static int SzabadságJogosultságKalkulátor(int azonosító)
        {



            int gyerekekSzáma = 0;
            int szabadság = 20;


            #region Hozzátartozó adatai, szabi számítás


            try
            {
                MySql.Data.MySqlClient.MySqlConnection conn;
                string myConnectionString = Adatbázis.MyConnectionString();
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;


                string sql = "SELECT SzulDatum, Fogyatekos FROM SzemHozzaTart WHERE SzemAzon='" + azonosító + "' ";
                var SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                conn.Open();
                MySql.Data.MySqlClient.MySqlDataReader dataReader = SQLCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    if (dataReader.GetDateTime(dataReader.GetOrdinal("SzulDatum")) > DateTime.Now.AddYears(-16))
                    {
                        gyerekekSzáma++;
                        if (dataReader.GetString(dataReader.GetOrdinal("Fogyatekos")) == "I") szabadság += 2;
                    }

                }



                switch (gyerekekSzáma)
                {
                    case int n when (n == 0):
                        break;
                    case int n when (n > 0 && n < 3):
                        szabadság += gyerekekSzáma * 2;
                        break;
                    case int n when (n >= 3):
                        szabadság += 7;
                        break;
                    default:
                        break;
                }
                dataReader.Close();

                #endregion

                #region Megváltozott munkaképesség és föld alatti munkavégzés, szül. dátum





                sql = "SELECT SzulDatum, MegvaltMunkFogy, FoldAlattIonMunk FROM SzemTorzs " +
                    "WHERE SzemAzon='" + azonosító + "' " +
                    "AND SzemErvIg='2099-01-31'";
                SQLCommand = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                dataReader = SQLCommand.ExecuteReader();



                dataReader.Read();

                //var test = dataReader.GetDateTime(dataReader.GetOrdinal("SzulDatum"));
                if (dataReader.GetString(dataReader.GetOrdinal("MegvaltMunkFogy")) == "I") szabadság += 5;
                if (dataReader.GetString(dataReader.GetOrdinal("FoldAlattIonMunk")) == "I") szabadság += 5;


                #endregion

                #region Alapszabadság számítása
                switch (DateTime.Now.Year - dataReader.GetDateTime(dataReader.GetOrdinal("SzulDatum")).Year)
                {
                    case int n when (n < 19):
                        szabadság += 5;
                        break;
                    case int n when (n < 25):
                        break;
                    case int n when (n >= 25 && n < 28):
                        szabadság += 1;
                        break;
                    case int n when (n >= 28 && n < 31):
                        szabadság += 2;
                        break;
                    case int n when (n >= 31 && n < 33):
                        szabadság += 3;
                        break;
                    case int n when (n >= 33 && n < 35):
                        szabadság += 4;
                        break;
                    case int n when (n >= 35 && n < 37):
                        szabadság += 5;
                        break;
                    case int n when (n >= 37 && n < 39):
                        szabadság += 6;
                        break;
                    case int n when (n >= 39 && n < 41):
                        szabadság += 7;
                        break;
                    case int n when (n >= 41 && n < 43):
                        szabadság += 8;
                        break;
                    case int n when (n >= 43 && n < 45):
                        szabadság += 9;
                        break;
                    case int n when (n >= 45):
                        szabadság += 10;
                        break;
                    default:
                        break;
                }

                dataReader.Close();
                conn.Close();


                #endregion




                return szabadság;



            }
            catch (Exception ex)
            {
                Program.logger.Error("---Adatbázis olvasási hiba (Szabadság jogosultság)!---" + ex);
                MessageBox.Show("Adatbázis olvasási hiba (Szabadság jogosultság)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return 0;
            }



        }

        


    }
}
