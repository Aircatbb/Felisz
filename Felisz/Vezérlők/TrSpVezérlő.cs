using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Felisz.Vezérlők
{



    class TrSpVezérlő : PictureBox
    {

        public Control TrNyelv { get; set; }
        public Control SpNyelv { get; set; }
        public Control mitMondjak { get; set; }
        public bool TTSállapot { get; set; }
        public bool TrVagySp { get; set; } // Fordítás vagy beszéd
        
        public TrSpVezérlő()
        {
            MouseEnter += TrSpVezérlő_MouseEnter;
            MouseLeave += TrSpVezérlő_MouseLeave;
            MouseClick += TrSpVezérlő_MouseClick;
            EnabledChanged += TrSpVezérlő_EnabledChanged;      


            this.BackColor = Color.FromArgb(30, 30, 30);
            this.Dock = DockStyle.Right;
            this.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.Margin = new Padding(0, 0, 0, 0);
            this.Size = new Size(24, 24);
            this.TTSállapot = false;
            this.Enabled = false;

          


        }

        private void TrSpVezérlő_EnabledChanged(object sender, EventArgs e)
        {
            if (this.TrVagySp)
                this.Image = (Image)Properties.Resources.ResourceManager.GetObject("TrSp");
            else this.Image = (Image)Properties.Resources.ResourceManager.GetObject("hang");
        }

        private void TrSpVezérlő_MouseClick(object sender, MouseEventArgs e)
        {


            if (e.Button == MouseButtons.Right)
            {
                if (TTS.hang.State == System.Speech.Synthesis.SynthesizerState.Paused)
                {
                    TTS.hang.Resume();
                }
                else
                {
                    if (TTS.hang.State == System.Speech.Synthesis.SynthesizerState.Speaking) TTS.hang.Pause();
                }
                return;
            }




            if (mitMondjak.Text == "") return;

            if (this.TTSállapot == false)
            {


                TTS.hang.SpeakAsyncCancelAll();
                TTS.hangRSS.SpeakAsyncCancelAll();
                TTS.TTS_Play(TTS.TTS_SzövegKorrekció(mitMondjak.Text), false);
                this.TTSállapot = true;
            }
            else
            {
                TTS.hang.Resume(); //különben pause marad az állapota
                TTS.hang.SpeakAsyncCancelAll();
                this.TTSállapot = false;
                var test = TTS.hang.State;
            }

        }

        private void TrSpVezérlő_MouseLeave(object sender, EventArgs e)
        {

            if (this.TTSállapot == false)
            {
                if(this.TrVagySp)
                this.Image = (Image)Properties.Resources.ResourceManager.GetObject("TrSp");
                else this.Image = (Image)Properties.Resources.ResourceManager.GetObject("hang");
            }
            else
            {
                
                if(this.TrVagySp)
                    this.Image = (Image)Properties.Resources.ResourceManager.GetObject("TrSp_Inv");
                else this.Image = (Image)Properties.Resources.ResourceManager.GetObject("hang_inv");
            }
        }

        private void TrSpVezérlő_MouseEnter(object sender, EventArgs e)
        {
            if(this.TrVagySp)
            this.Image = (Image)Properties.Resources.ResourceManager.GetObject("TrSp_Inv");
            else this.Image = (Image)Properties.Resources.ResourceManager.GetObject("hang_inv");

        }
    }
}
