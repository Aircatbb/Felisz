
namespace Felisz
{
    partial class formMunkaTörvénykönyve
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btMTKeresés = new System.Windows.Forms.Button();
            this.tbMTKeresés = new System.Windows.Forms.TextBox();
            this.lbMTKeresésKifejezés = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btKeresésParagrafus = new System.Windows.Forms.Button();
            this.tbMTKeresésParagrafus = new System.Windows.Forms.TextBox();
            this.tbTalálatokSzáma = new System.Windows.Forms.TextBox();
            this.btMásolásVágólapra = new System.Windows.Forms.Button();
            this.lbTalálatokSzáma = new System.Windows.Forms.Label();
            this.rtTalálat = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbFormClose = new System.Windows.Forms.PictureBox();
            this.btStop = new System.Windows.Forms.Button();
            this.btPlay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btMTKeresés
            // 
            this.btMTKeresés.BackColor = System.Drawing.Color.Transparent;
            this.btMTKeresés.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btMTKeresés.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btMTKeresés.Location = new System.Drawing.Point(297, 7);
            this.btMTKeresés.Name = "btMTKeresés";
            this.btMTKeresés.Size = new System.Drawing.Size(96, 22);
            this.btMTKeresés.TabIndex = 3;
            this.btMTKeresés.Text = "KERESÉS";
            this.btMTKeresés.UseVisualStyleBackColor = false;
            this.btMTKeresés.Click += new System.EventHandler(this.btMTKeresés_Click);
            // 
            // tbMTKeresés
            // 
            this.tbMTKeresés.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbMTKeresés.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMTKeresés.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbMTKeresés.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbMTKeresés.Location = new System.Drawing.Point(71, 7);
            this.tbMTKeresés.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tbMTKeresés.Name = "tbMTKeresés";
            this.tbMTKeresés.Size = new System.Drawing.Size(220, 26);
            this.tbMTKeresés.TabIndex = 2;
            this.tbMTKeresés.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMTKeresés_KeyDown);
            // 
            // lbMTKeresésKifejezés
            // 
            this.lbMTKeresésKifejezés.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lbMTKeresésKifejezés.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lbMTKeresésKifejezés.Location = new System.Drawing.Point(-4, 6);
            this.lbMTKeresésKifejezés.Margin = new System.Windows.Forms.Padding(3);
            this.lbMTKeresésKifejezés.Name = "lbMTKeresésKifejezés";
            this.lbMTKeresésKifejezés.Size = new System.Drawing.Size(72, 26);
            this.lbMTKeresésKifejezés.TabIndex = 5;
            this.lbMTKeresésKifejezés.Text = "Kifejezés";
            this.lbMTKeresésKifejezés.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btPlay);
            this.panel1.Controls.Add(this.btStop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btKeresésParagrafus);
            this.panel1.Controls.Add(this.tbMTKeresésParagrafus);
            this.panel1.Controls.Add(this.tbTalálatokSzáma);
            this.panel1.Controls.Add(this.btMásolásVágólapra);
            this.panel1.Controls.Add(this.lbMTKeresésKifejezés);
            this.panel1.Controls.Add(this.lbTalálatokSzáma);
            this.panel1.Controls.Add(this.btMTKeresés);
            this.panel1.Controls.Add(this.rtTalálat);
            this.panel1.Controls.Add(this.tbMTKeresés);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 1000);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(-4, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Paragrafus";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btKeresésParagrafus
            // 
            this.btKeresésParagrafus.BackColor = System.Drawing.Color.Transparent;
            this.btKeresésParagrafus.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btKeresésParagrafus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btKeresésParagrafus.Location = new System.Drawing.Point(297, 39);
            this.btKeresésParagrafus.Name = "btKeresésParagrafus";
            this.btKeresésParagrafus.Size = new System.Drawing.Size(96, 22);
            this.btKeresésParagrafus.TabIndex = 11;
            this.btKeresésParagrafus.Text = "KERESÉS";
            this.btKeresésParagrafus.UseVisualStyleBackColor = false;
            this.btKeresésParagrafus.Click += new System.EventHandler(this.btKeresésParagrafus_Click);
            // 
            // tbMTKeresésParagrafus
            // 
            this.tbMTKeresésParagrafus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbMTKeresésParagrafus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMTKeresésParagrafus.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbMTKeresésParagrafus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbMTKeresésParagrafus.Location = new System.Drawing.Point(71, 39);
            this.tbMTKeresésParagrafus.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tbMTKeresésParagrafus.Name = "tbMTKeresésParagrafus";
            this.tbMTKeresésParagrafus.Size = new System.Drawing.Size(220, 26);
            this.tbMTKeresésParagrafus.TabIndex = 10;
            this.tbMTKeresésParagrafus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMTKeresésParagrafus_KeyDown);
            // 
            // tbTalálatokSzáma
            // 
            this.tbTalálatokSzáma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbTalálatokSzáma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTalálatokSzáma.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbTalálatokSzáma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbTalálatokSzáma.Location = new System.Drawing.Point(117, 583);
            this.tbTalálatokSzáma.Name = "tbTalálatokSzáma";
            this.tbTalálatokSzáma.Size = new System.Drawing.Size(35, 26);
            this.tbTalálatokSzáma.TabIndex = 9;
            this.tbTalálatokSzáma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btMásolásVágólapra
            // 
            this.btMásolásVágólapra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMásolásVágólapra.BackColor = System.Drawing.Color.Transparent;
            this.btMásolásVágólapra.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btMásolásVágólapra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btMásolásVágólapra.Location = new System.Drawing.Point(539, 7);
            this.btMásolásVágólapra.Name = "btMásolásVágólapra";
            this.btMásolásVágólapra.Size = new System.Drawing.Size(160, 22);
            this.btMásolásVágólapra.TabIndex = 6;
            this.btMásolásVágólapra.Text = "MÁSOLÁS A VÁGÓLAPRA";
            this.btMásolásVágólapra.UseVisualStyleBackColor = false;
            this.btMásolásVágólapra.Click += new System.EventHandler(this.btMásolásVágólapra_Click);
            // 
            // lbTalálatokSzáma
            // 
            this.lbTalálatokSzáma.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lbTalálatokSzáma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lbTalálatokSzáma.Location = new System.Drawing.Point(-4, 582);
            this.lbTalálatokSzáma.Margin = new System.Windows.Forms.Padding(3);
            this.lbTalálatokSzáma.Name = "lbTalálatokSzáma";
            this.lbTalálatokSzáma.Size = new System.Drawing.Size(115, 26);
            this.lbTalálatokSzáma.TabIndex = 8;
            this.lbTalálatokSzáma.Text = "Találatok száma:";
            this.lbTalálatokSzáma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtTalálat
            // 
            this.rtTalálat.Location = new System.Drawing.Point(0, 70);
            this.rtTalálat.Name = "rtTalálat";
            this.rtTalálat.Size = new System.Drawing.Size(699, 506);
            this.rtTalálat.TabIndex = 7;
            this.rtTalálat.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pbFormClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(702, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(945, 1000);
            this.panel3.TabIndex = 9;
            // 
            // pbFormClose
            // 
            this.pbFormClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFormClose.Image = global::Felisz.Properties.Resources.window_close;
            this.pbFormClose.Location = new System.Drawing.Point(924, 0);
            this.pbFormClose.Name = "pbFormClose";
            this.pbFormClose.Size = new System.Drawing.Size(24, 24);
            this.pbFormClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFormClose.TabIndex = 10;
            this.pbFormClose.TabStop = false;
            this.pbFormClose.Click += new System.EventHandler(this.pbFormClose_Click);
            this.pbFormClose.MouseEnter += new System.EventHandler(this.pbFormClose_MouseEnter);
            this.pbFormClose.MouseLeave += new System.EventHandler(this.pbFormClose_MouseLeave);
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.Color.Transparent;
            this.btStop.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btStop.Location = new System.Drawing.Point(629, 41);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(70, 22);
            this.btStop.TabIndex = 13;
            this.btStop.Text = "STOP";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btPlay
            // 
            this.btPlay.BackColor = System.Drawing.Color.Transparent;
            this.btPlay.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btPlay.Location = new System.Drawing.Point(539, 41);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(70, 22);
            this.btPlay.TabIndex = 14;
            this.btPlay.Text = "PLAY";
            this.btPlay.UseVisualStyleBackColor = false;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // formMunkaTörvénykönyve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1647, 1000);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMunkaTörvénykönyve";
            this.Text = "formMunkaTörvénykönyve";
            this.Load += new System.EventHandler(this.formMunkaTörvénykönyve_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbMTKeresés;
        private System.Windows.Forms.Button btMTKeresés;
        private System.Windows.Forms.Label lbMTKeresésKifejezés;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtTalálat;
        private System.Windows.Forms.TextBox tbTalálatokSzáma;
        private System.Windows.Forms.Label lbTalálatokSzáma;
        private System.Windows.Forms.Button btMásolásVágólapra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btKeresésParagrafus;
        private System.Windows.Forms.TextBox tbMTKeresésParagrafus;
        private System.Windows.Forms.PictureBox pbFormClose;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btStop;
    }
}