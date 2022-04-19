using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Felisz.Vezérlők
{



    class TTSPlay : PictureBox
    {


        public Control mitMondjak { get; set; }
        public bool TTSállapot { get; set; }
        public TTSPlay()
        {
            MouseEnter += TTSPlay_MouseEnter;
            MouseLeave += TTSPlay_MouseLeave;
            MouseClick += TTSPlay_MouseClick;


            this.BackColor = Color.FromArgb(30, 30, 30);
            this.Dock = DockStyle.Right;

            this.Image = (Image)Properties.Resources.ResourceManager.GetObject("hang");

            this.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.Margin = new Padding(0, 0, 0, 0);
            this.Size = new Size(24, 24);
            this.TTSállapot = false;

        }



        private void TTSPlay_MouseClick(object sender, MouseEventArgs e)
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
                TTS.TTS_Play(TTS.TTS_SzövegKorrekció(mitMondjak.Text));
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

        private void TTSPlay_MouseLeave(object sender, EventArgs e)
        {
            if (this.TTSállapot == false)
            {
                this.Image = (Image)Properties.Resources.ResourceManager.GetObject("hang");
            }
            else
            {
                this.Image = (Image)Properties.Resources.ResourceManager.GetObject("hang_inv");
            }
        }

        private void TTSPlay_MouseEnter(object sender, EventArgs e)
        {
            this.Image = (Image)Properties.Resources.ResourceManager.GetObject("hang_inv");
        }
    }
}
