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
            if (Properties.Settings.Default.TTSEngedélyezve == false) return;
            hang.Rate = 0;
            hang.Volume = 33;

            var voice = hang.GetInstalledVoices();
            string hangName = voice[1].VoiceInfo.Name;
            string hangCulture = voice[1].VoiceInfo.Culture.ToString();
            string hangGender = voice[1].VoiceInfo.Gender.ToString();
            string hangAge = voice[1].VoiceInfo.Age.ToString();


            hang.SelectVoice(hangName);
        }

        public static void TTS_Play(string szöveg)
        {
            /*
             if (Properties.Settings.Default.TTSEngedélyezve == false) return;
             hang.Rate = 0;
             hang.Volume = 33;
             var voice = hang.GetInstalledVoices();
             string hangName = voice[1].VoiceInfo.Name;
             string hangCulture = voice[1].VoiceInfo.Culture.ToString();
             string hangGender = voice[1].VoiceInfo.Gender.ToString();
             string hangAge = voice[1].VoiceInfo.Age.ToString();



             hang.SelectVoice(hangName);
            */

            hang.SpeakAsync(szöveg);
        }

        public static string szám2Hónap(int hónap)
        {

            switch (hónap)
            {
                case 1:
                    return "Január";
                    break;
                case 2:
                    return "Február";
                    break;
                case 3:
                    return "Március";
                    break;
                case 4:
                    return "Április";
                    break;
                case 5:
                    return "Május";
                    break;
                case 6:
                    return "Június";
                    break;
                case 7:
                    return "Július";
                    break;
                case 8:
                    return "Augusztus";
                    break;
                case 9:
                    return "Szeptember";
                    break;
                case 10:
                    return "Október";
                    break;
                case 11:
                    return "November";
                    break;
                case 12:
                    return "December";
                    break;
                default:
                    return "";
                    break;
            }

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
                    return "";
                    break;

            }

        }

        public static string név2Utónév(string név)
        {
            return név.Substring(név.IndexOf(" ")+1);
        }
    }
}
