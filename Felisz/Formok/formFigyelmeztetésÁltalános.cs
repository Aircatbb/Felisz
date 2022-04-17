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
    public partial class formFigyelmeztetésÁltalános : Form
    {
        private string figySzöveg = "";
        private string figyTTS = "";

        public formFigyelmeztetésÁltalános(string figyelmeztetésSzövege, string ttsSzöveg)
        {
            InitializeComponent();
            figySzöveg = figyelmeztetésSzövege;
            figyTTS = ttsSzöveg;

        }

        private void btMegszakítás_Click(object sender, EventArgs e)
        {
            TTS.TTS_Stop();
            this.DialogResult = DialogResult.Abort;

        }

        private void btTörlés_Click(object sender, EventArgs e)
        {
            TTS.TTS_Stop();
            this.DialogResult = DialogResult.OK;
        }

        private void formTörlésFigyelmeztetésÁltalános_Load(object sender, EventArgs e)
        {
            tbFigyelmeztetés.Text = figySzöveg;
            tbFigyelmeztetés.Height = tbFigyelmeztetés.Lines.Count() * 23;
            this.Height = 100 + (tbFigyelmeztetés.Lines.Count() * 23);
            TTS.TTS_Stop();
            TTS.TTS_Play(figyTTS);
        }
    }
}
