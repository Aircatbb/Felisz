using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Windows.Forms;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using Microsoft.CognitiveServices.Speech.Translation;

namespace Felisz
{
    class TTS
    {
        public static System.Speech.Synthesis.SpeechSynthesizer hang = new System.Speech.Synthesis.SpeechSynthesizer();
        public static System.Speech.Synthesis.SpeechSynthesizer hangRSS = new System.Speech.Synthesis.SpeechSynthesizer();

        public static bool TTS_Lejátszás = false;
        public static SpeechConfig configTTS = null;
        public static Microsoft.CognitiveServices.Speech.SpeechSynthesizer synthesizer = null;



        public static void TTS_Beállítás()
        {

            /*
            try
            {
                hang.SelectVoice(Program.TTSNyelv);
                hangRSS.SelectVoice(Program.TTSNyelv);
            }
            catch (Exception)
            {

                MessageBox.Show("Nem sikerült a TTS hang beállítása!" + Environment.NewLine +
                    "Kérem, ellenőrizze a beállításokat!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.TTSEngedélyezve = false;
                Funkciók.TTSRegÍrás(false, 0, 0, "");
                return;
            }

            */




            if (Program.TTSEngedélyezve == "No")
            {
                PictureBox icon = Application.OpenForms["formFelisz"].Controls["panelTopMenu"].Controls["pbTTSEngedélyezés"] as PictureBox;

                if (TTS.synthesizer != null) TTS.synthesizer.StopSpeakingAsync();

                //hang.SpeakAsyncCancelAll();
                //hangRSS.SpeakAsyncCancelAll();
                icon.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
                return;
            }
            //hang.Rate = Program.TTSSebesség;
            //hang.Volume = Program.TTSHangerő;

            //hangRSS.Rate = Program.TTSSebesség;
            //hangRSS.Volume = Program.TTSHangerő;




            /*
           string hangName = voice[1].VoiceInfo.Name;
           string hangCulture = voice[1].VoiceInfo.Culture.ToString();
           string hangGender = voice[1].VoiceInfo.Gender.ToString();
           string hangAge = voice[1].VoiceInfo.Age.ToString();
            */



            PictureBox pB = Application.OpenForms["formFelisz"].Controls["panelTopMenu"].Controls["pbTTSEngedélyezés"] as PictureBox;
            pB.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        }

        public static void TTS_Play_OLD(string szöveg, bool RSS)
        {
            /*
            if (Program.TTSEngedélyezve == false) return;

            if (RSS) hangRSS.SpeakAsync(TTS_SzövegKorrekció(szöveg));
            else hang.SpeakAsync(TTS_SzövegKorrekció(szöveg));
            */

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

        public static void TTS_StopAll()
        {
            hang.SpeakAsyncCancelAll();
            hangRSS.Pause();

        }

        public static void TTS_RSS_Resume()
        {
            hangRSS.Resume();
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

        async static Task RecognizeFromMic(SpeechConfig speechConfig)
        {
            string szöveg = "Test szöveg";


            var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
            var recognizer = new SpeechRecognizer(speechConfig, "hu-HU", audioConfig);


            Console.WriteLine("Beszé valamit waze!");
            var result = await recognizer.RecognizeOnceAsync();
            Console.WriteLine($"Én ezt értettem: " + result.Text);
            szöveg = result.Text;
            Console.WriteLine(szöveg);
        }


        public async static Task SynthesizeToSpeaker(string szöveg)
        {


            configTTS = SpeechConfig.FromSubscription(Funkciók.Decrypt("+IAKPB59mtSXPNFs4lexGcJD8G8TyhkmTNlXfQetCfR+8lKcmn3ba+bpk8HuyAj5pAuW6TXy9tOP32l5MD3SC8QxqiFeJAlEnxw+a2Ps6qk="), "westeurope");
            configTTS.SpeechSynthesisLanguage = Program.TTS_Nyelv;

            synthesizer = new Microsoft.CognitiveServices.Speech.SpeechSynthesizer(configTTS);
            synthesizer.SynthesisCompleted += Synthesizer_SynthesisCompleted;

            TTS.TTS_Lejátszás = true;


            await synthesizer.SpeakTextAsync(szöveg);
            //await synthesizer.StartSpeakingTextAsync(szöveg);
            //synthesizer.StopSpeakingAsync();



        }

        private static void Synthesizer_SynthesisCompleted(object sender, SpeechSynthesisEventArgs e)
        {
            TTS.TTS_Lejátszás = false;
            synthesizer.Dispose();
        }

        static async Task TranslateSpeechAsync()
        {
            var translationConfig =
                SpeechTranslationConfig.FromSubscription("72da4768518f4116a9cdc338f9c6f36a", "westeurope");

            var fromLanguage = "hu-HU";
            var toLanguages = new List<string> { "it", "fr", "de", "en" };
            translationConfig.SpeechRecognitionLanguage = fromLanguage;

            toLanguages.ForEach(translationConfig.AddTargetLanguage);

            var recognizer = new TranslationRecognizer(translationConfig);

            Console.Write($"Mondgyá valamit '{fromLanguage}' és ");
            Console.WriteLine($"lefordítom waze '{string.Join("', '", toLanguages)}'.\n");

            var result = await recognizer.RecognizeOnceAsync();
            if (result.Reason == ResultReason.TranslatedSpeech)
            {
                Console.WriteLine($"Eredeti: \"{result.Text}\":");
                foreach (var item in result.Translations)
                {

                    //Console.WriteLine($"Fordítás '{language}': {translation}");
                }
            }
        }




    }


}
