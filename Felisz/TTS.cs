using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Felisz
{
    class TTS
    {
        public static SpeechSynthesizer hang = new SpeechSynthesizer();

        public static void TTS_Beállítás()
        {
            if (Program.TTSEngedélyezve == false) return;
            hang.Rate = Program.TTSSebesség;
            hang.Volume = Program.TTSHangerő;

            var voice = hang.GetInstalledVoices();
            string hangName = voice[1].VoiceInfo.Name;
            string hangCulture = voice[1].VoiceInfo.Culture.ToString();
            string hangGender = voice[1].VoiceInfo.Gender.ToString();
            string hangAge = voice[1].VoiceInfo.Age.ToString();


            hang.SelectVoice(hangName);
        }

        public static void TTS_Play(string szöveg)
        {



            if (Program.TTSEngedélyezve == false) return;
            /*
            hang.Rate = 0;
             hang.Volume = 33;
             var voice = hang.GetInstalledVoices();
             string hangName = voice[1].VoiceInfo.Name;
             string hangCulture = voice[1].VoiceInfo.Culture.ToString();
             string hangGender = voice[1].VoiceInfo.Gender.ToString();
             string hangAge = voice[1].VoiceInfo.Age.ToString();
             hang.SelectVoice(hangName);
            */

            hang.SpeakAsync(TTS_SzövegKorrekció(szöveg));

        }

        public static string TTS_SzövegKorrekció(string szöveg)
        {
            string[,] korrigálandóSzöveg = new string[,]
            {
                { "nav", "nemzeti adó és vámhivatal" },
                { "sap", "esszápé" },
                { "orfk", "országos rendőrfőkapitányság" },
                { "leasing", "lízing" },
                { "tungsram", "tungszram" },
                { "continental", "kontinentál" },
                { "elon musk", "Ilon Maszk" },
                { "easyjet", "ízidzset" },
                { "chip", "csipp" },
                { "volkswagen", "folkszvágen" },
                { "§", "paragrafus" },
                { "e-kerékpár", "elektromos kerékpár" }
            };

            for (int i = 0; i < korrigálandóSzöveg.GetLength(0); i++)
            {
                szöveg = szöveg.ToLower().Replace(korrigálandóSzöveg[i, 0], korrigálandóSzöveg[i, 1]);
            }

            return szöveg;
        }

        public static void TTS_Stop()
        {
            hang.SpeakAsyncCancelAll();
        }

        public static string szám2Hónap(int hónap)
        {

            switch (hónap)
            {
                case 1:
                    return "Január";
                case 2:
                    return "Február";
                case 3:
                    return "Március";
                case 4:
                    return "Április";
                case 5:
                    return "Május";
                case 6:
                    return "Június";
                case 7:
                    return "Július";
                case 8:
                    return "Augusztus";
                case 9:
                    return "Szeptember";
                case 10:
                    return "Október";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    break;
            }

            return "";

        }

        public static string szám2Nap(int nap)
        {

            switch (nap)
            {
                case 1:
                    return "elseje";
                case 2:
                    return "másodika";
                case 3:
                    return "harmadika";
                case 4:
                    return "negyedike";
                case 5:
                    return "ötödike";
                case 6:
                    return "hatodika";
                case 7:
                    return "hetedike";
                case 8:
                    return "nyolcadika";
                case 9:
                    return "kilencedike";
                case 10:
                    return "tizedike";
                case 11:
                    return "tizenegyedike";
                case 12:
                    return "tizenkettedike";
                case 13:
                    return "tizenharmadika";
                case 14:
                    return "tizennegyedike";
                case 15:
                    return "tizenötödike";
                case 16:
                    return "tizenhatodika";
                case 17:
                    return "tizenhetedike";
                case 18:
                    return "tizennyolcadika";
                case 19:
                    return "tizenkilencedike";
                case 20:
                    return "huszadika";
                case 21:
                    return "huszonegyedike";
                case 22:
                    return "huszonkettedike";
                case 23:
                    return "huszonharmadika";
                case 24:
                    return "huszonnegyedike";
                case 25:
                    return "huszonötödike";
                case 26:
                    return "huszonhatodika";
                case 27:
                    return "huszonhetedike";
                case 28:
                    return "huszonnyolcadika";
                case 29:
                    return "huszonkilencedike";
                case 30:
                    return "harmincadika";
                case 31:
                    return "harmincegyedike";
                default:
                    break;

            }
            return "";

        }

        public static string név2Utónév(string név)
        {
            return név.Substring(név.IndexOf(" ") + 1);
        }
    }
}
