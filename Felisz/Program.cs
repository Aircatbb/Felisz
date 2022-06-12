using System;
using System.Windows.Forms;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using Microsoft.CognitiveServices.Speech.Translation;

namespace Felisz
{
    static class Program
    {
        //Általános változók
        public static int aktuálisHáttér = 1;
        
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
        //TTS
        
        public static string TTSEngedélyezve = "No";
        public static int TTSHangerő = 33;
        public static int TTSSebesség = 0;
        //public static string TTSNyelv = "";

        //Fordítás nyelve és hang
        public static string fordításNyelve = "DE";
        public static string TTS_Nyelv = "hu-HU";

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
