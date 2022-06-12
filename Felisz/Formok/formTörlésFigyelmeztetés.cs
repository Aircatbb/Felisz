using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Felisz.Formok
{
    public partial class formTörlésFigyelmeztetés : Form
    {
        public formTörlésFigyelmeztetés()
        {
            InitializeComponent();
        }

        private void formTörlésFigyelmeztetés_Load(object sender, EventArgs e)
        {
            if (TTS.synthesizer != null) TTS.synthesizer.StopSpeakingAsync();
            TTS.SynthesizeToSpeaker("FIGYELEM! VÉGLEGESEN TÖRÖLNI KÉSZÜL A KIVÁLASZTOTT MUNKAVÁLLALÓT!");
            //TTS.TTS_StopAll();
            //TTS.TTS_Play("FIGYELEM! VÉGLEGESEN TÖRÖLNI KÉSZÜL A KIVÁLASZTOTT MUNKAVÁLLALÓT!",false);
            
        }

        private void btMegszakítás_Click(object sender, EventArgs e)
        {
            if (TTS.synthesizer != null) TTS.synthesizer.StopSpeakingAsync();
            formMunkavállalóVálasztás.mód = "A";
        }

        private void btTörlés_Click(object sender, EventArgs e)
        {
            if (TTS.synthesizer != null) TTS.synthesizer.StopSpeakingAsync();
            formMunkavállalóVálasztás.mód = "T";
        }
    }
}
