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

        public string TrMentett { get; set; } //Fordítás után az eredeti magyar szöveg
        public String TrNyelv { get; set; } //Nyelv amire fordítva lett
        public Control mitMondjak { get; set; } //Fordítandó, vagy felolvasandó szöveget tartalmazó controll
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
            this.TrNyelv = "HU";
            this.TrMentett = "";




        }

        private void TrSpVezérlő_EnabledChanged(object sender, EventArgs e)
        {
            if (this.TrVagySp)
                this.Image = (Image)Properties.Resources.ResourceManager.GetObject("TrSp");
            else this.Image = (Image)Properties.Resources.ResourceManager.GetObject("hang");
        }

        private void TrSpVezérlő_MouseClick(object sender, MouseEventArgs e)
        {
            TrSpVezérlő temp = (TrSpVezérlő)sender;
            if (temp.TrVagySp)
            {
                
                if (temp.TrMentett == "") temp.TrMentett = temp.mitMondjak.Text;
                

                var task = Funkciók.Fordítás(temp.TrMentett, Program.fordításNyelve);
                task.Wait();

                temp.mitMondjak.Text = task.Result;
                temp.TrNyelv = Program.fordításNyelve;

            }

            else
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



                    if (TTS.synthesizer != null) TTS.synthesizer.StopSpeakingAsync();
                    TTS.SynthesizeToSpeaker(TTS.TTS_SzövegKorrekció(mitMondjak.Text));
                    //TTS.hang.SpeakAsyncCancelAll();
                    //TTS.hangRSS.SpeakAsyncCancelAll();
                    //TTS.TTS_Play(TTS.TTS_SzövegKorrekció(mitMondjak.Text), false);
                    //this.TTSállapot = true;
                }
                else
                {

                    //TTS.hang.Resume(); //különben pause marad az állapota
                    //TTS.hang.SpeakAsyncCancelAll();
                    //this.TTSállapot = false;
                    //var test = TTS.hang.State;
                }

            }
        }

        private void TrSpVezérlő_MouseLeave(object sender, EventArgs e)
        {

            if (this.TTSállapot == false)
            {
                if (this.TrVagySp)
                    this.Image = (Image)Properties.Resources.ResourceManager.GetObject("TrSp");
                else this.Image = (Image)Properties.Resources.ResourceManager.GetObject("hang");
            }
            else
            {

                if (this.TrVagySp)
                    this.Image = (Image)Properties.Resources.ResourceManager.GetObject("TrSp_Inv");
                else this.Image = (Image)Properties.Resources.ResourceManager.GetObject("hang_inv");
            }
        }

        private void TrSpVezérlő_MouseEnter(object sender, EventArgs e)
        {
            if (this.TrVagySp)
                this.Image = (Image)Properties.Resources.ResourceManager.GetObject("TrSp_Inv");
            else this.Image = (Image)Properties.Resources.ResourceManager.GetObject("hang_inv");

        }
    }
}
