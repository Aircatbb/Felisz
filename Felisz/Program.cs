using NLog;
using System;
using System.Windows.Forms;

namespace Felisz
{
    static class Program
    {
        //Általános változók
        public static int aktuálisHáttér = 1;
        //Logger
        public static Logger logger = LogManager.GetCurrentClassLogger();
        //Licenc változók
        public static string kódoltLic = "";
        public static string dekódoltLic = "";
        public static DateTime licÉrvényesség = new DateTime(1900, 01, 01);
        //Cég, felhasználó
        public static string aktuálisCég = "";
        public static string prefix = "";
        public static string jelszóLic = "";
        public static string jelszó = "";
        public static string aktuálisFelhasználó = "";
        public static string aktuálisFelhasználóNév = "";


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formFelisz());
        }
    }
}
