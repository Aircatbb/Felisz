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
            TTS.TTS_Stop();
            TTS.TTS_Play("FIGYELEM! VÉGLEGESEN TÖRÖLNI KÉSZÜL A KIVÁLASZTOTT MUNKAVÁLLALÓT!");
            //Funkciók.TTS("ACHTUNG! DER AUSGEWÄHLTE MITARBEITER WIRD DAUERHAFT GELÖSCHT!");
        }

        private void btMegszakítás_Click(object sender, EventArgs e)
        {
            TTS.hang.SpeakAsyncCancelAll();
            //this.DialogResult = DialogResult.Abort;
            formMunkavállalóVálasztás.mód = "A";
        }

        private void btTörlés_Click(object sender, EventArgs e)
        {
            TTS.hang.SpeakAsyncCancelAll();
            //this.DialogResult = DialogResult.Yes;
            formMunkavállalóVálasztás.mód = "T";
        }
    }
}
