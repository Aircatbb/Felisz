
namespace Felisz
{
    partial class formAlapbeállítások
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAlapbeállítások));
            this.pbFormClose = new System.Windows.Forms.PictureBox();
            this.gbLicenc = new System.Windows.Forms.GroupBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.tbLicenc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btAktualizálás = new System.Windows.Forms.Button();
            this.gbBeszédaszisztens = new System.Windows.Forms.GroupBox();
            this.trbSebesség = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trbHangerő = new System.Windows.Forms.TrackBar();
            this.cbTTSEngedélyezve = new System.Windows.Forms.CheckBox();
            this.btCégMódosítás = new System.Windows.Forms.Button();
            this.gbVáltozásLista1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbVáltozásLista = new System.Windows.Forms.RichTextBox();
            this.ttsPlay1 = new Felisz.Vezérlők.TTSPlay();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).BeginInit();
            this.gbLicenc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.gbBeszédaszisztens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSebesség)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbHangerő)).BeginInit();
            this.gbVáltozásLista1.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ttsPlay1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFormClose
            // 
            this.pbFormClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFormClose.Image = global::Felisz.Properties.Resources.window_close;
            this.pbFormClose.Location = new System.Drawing.Point(1626, 0);
            this.pbFormClose.Name = "pbFormClose";
            this.pbFormClose.Size = new System.Drawing.Size(24, 24);
            this.pbFormClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFormClose.TabIndex = 12;
            this.pbFormClose.TabStop = false;
            this.pbFormClose.Click += new System.EventHandler(this.pbFormClose_Click);
            this.pbFormClose.MouseEnter += new System.EventHandler(this.pbFormClose_MouseEnter);
            this.pbFormClose.MouseLeave += new System.EventHandler(this.pbFormClose_MouseLeave);
            // 
            // gbLicenc
            // 
            this.gbLicenc.Controls.Add(this.pbClose);
            this.gbLicenc.Controls.Add(this.tbLicenc);
            this.gbLicenc.Controls.Add(this.label2);
            this.gbLicenc.Controls.Add(this.btAktualizálás);
            this.gbLicenc.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbLicenc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gbLicenc.Location = new System.Drawing.Point(0, 0);
            this.gbLicenc.Name = "gbLicenc";
            this.gbLicenc.Size = new System.Drawing.Size(1647, 61);
            this.gbLicenc.TabIndex = 13;
            this.gbLicenc.TabStop = false;
            this.gbLicenc.Text = "Licenc aktualizálás";
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Image = global::Felisz.Properties.Resources.window_close;
            this.pbClose.Location = new System.Drawing.Point(1626, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(24, 24);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbClose.TabIndex = 11;
            this.pbClose.TabStop = false;
            // 
            // tbLicenc
            // 
            this.tbLicenc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbLicenc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLicenc.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbLicenc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbLicenc.Location = new System.Drawing.Point(82, 19);
            this.tbLicenc.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tbLicenc.Name = "tbLicenc";
            this.tbLicenc.Size = new System.Drawing.Size(612, 26);
            this.tbLicenc.TabIndex = 3;
            this.tbLicenc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Licenckód";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btAktualizálás
            // 
            this.btAktualizálás.BackColor = System.Drawing.Color.Transparent;
            this.btAktualizálás.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btAktualizálás.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btAktualizálás.Location = new System.Drawing.Point(700, 19);
            this.btAktualizálás.Name = "btAktualizálás";
            this.btAktualizálás.Size = new System.Drawing.Size(102, 26);
            this.btAktualizálás.TabIndex = 4;
            this.btAktualizálás.Text = "AKTUALIZÁLÁS";
            this.btAktualizálás.UseVisualStyleBackColor = false;
            this.btAktualizálás.Click += new System.EventHandler(this.btAktualizálás_Click);
            // 
            // gbBeszédaszisztens
            // 
            this.gbBeszédaszisztens.Controls.Add(this.trbSebesség);
            this.gbBeszédaszisztens.Controls.Add(this.label3);
            this.gbBeszédaszisztens.Controls.Add(this.label1);
            this.gbBeszédaszisztens.Controls.Add(this.trbHangerő);
            this.gbBeszédaszisztens.Controls.Add(this.cbTTSEngedélyezve);
            this.gbBeszédaszisztens.Controls.Add(this.btCégMódosítás);
            this.gbBeszédaszisztens.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbBeszédaszisztens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gbBeszédaszisztens.Location = new System.Drawing.Point(0, 61);
            this.gbBeszédaszisztens.Name = "gbBeszédaszisztens";
            this.gbBeszédaszisztens.Size = new System.Drawing.Size(1647, 129);
            this.gbBeszédaszisztens.TabIndex = 14;
            this.gbBeszédaszisztens.TabStop = false;
            this.gbBeszédaszisztens.Text = "Beszédaszisztens";
            // 
            // trbSebesség
            // 
            this.trbSebesség.LargeChange = 1;
            this.trbSebesség.Location = new System.Drawing.Point(91, 81);
            this.trbSebesség.Maximum = 5;
            this.trbSebesség.Minimum = -5;
            this.trbSebesség.Name = "trbSebesség";
            this.trbSebesség.Size = new System.Drawing.Size(147, 45);
            this.trbSebesség.TabIndex = 19;
            this.trbSebesség.Value = -5;
            this.trbSebesség.ValueChanged += new System.EventHandler(this.trbSebesség_ValueChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hangerő";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sebesség";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbHangerő
            // 
            this.trbHangerő.Location = new System.Drawing.Point(91, 49);
            this.trbHangerő.Maximum = 100;
            this.trbHangerő.Name = "trbHangerő";
            this.trbHangerő.Size = new System.Drawing.Size(147, 45);
            this.trbHangerő.SmallChange = 5;
            this.trbHangerő.TabIndex = 16;
            this.trbHangerő.TickFrequency = 10;
            this.trbHangerő.ValueChanged += new System.EventHandler(this.trbHangerő_ValueChanged);
            // 
            // cbTTSEngedélyezve
            // 
            this.cbTTSEngedélyezve.AutoSize = true;
            this.cbTTSEngedélyezve.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbTTSEngedélyezve.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.cbTTSEngedélyezve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbTTSEngedélyezve.Location = new System.Drawing.Point(12, 19);
            this.cbTTSEngedélyezve.Name = "cbTTSEngedélyezve";
            this.cbTTSEngedélyezve.Size = new System.Drawing.Size(226, 24);
            this.cbTTSEngedélyezve.TabIndex = 15;
            this.cbTTSEngedélyezve.Text = "Beszédaszisztens bekapcsolása";
            this.cbTTSEngedélyezve.UseVisualStyleBackColor = true;
            this.cbTTSEngedélyezve.CheckedChanged += new System.EventHandler(this.cbTTSEngedélyezve_CheckedChanged);
            // 
            // btCégMódosítás
            // 
            this.btCégMódosítás.BackColor = System.Drawing.Color.Transparent;
            this.btCégMódosítás.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btCégMódosítás.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btCégMódosítás.Location = new System.Drawing.Point(1382, 302);
            this.btCégMódosítás.Name = "btCégMódosítás";
            this.btCégMódosítás.Size = new System.Drawing.Size(102, 26);
            this.btCégMódosítás.TabIndex = 4;
            this.btCégMódosítás.Text = "MÓDOSÍTÁS";
            this.btCégMódosítás.UseVisualStyleBackColor = false;
            // 
            // gbVáltozásLista1
            // 
            this.gbVáltozásLista1.Controls.Add(this.tableLayoutPanel12);
            this.gbVáltozásLista1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbVáltozásLista1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gbVáltozásLista1.Location = new System.Drawing.Point(0, 190);
            this.gbVáltozásLista1.Name = "gbVáltozásLista1";
            this.gbVáltozásLista1.Size = new System.Drawing.Size(1647, 616);
            this.gbVáltozásLista1.TabIndex = 15;
            this.gbVáltozásLista1.TabStop = false;
            this.gbVáltozásLista1.Text = "Változáslista";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Controls.Add(this.rtbVáltozásLista, 0, 3);
            this.tableLayoutPanel12.Controls.Add(this.ttsPlay1, 0, 2);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 4;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(799, 334);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // rtbVáltozásLista
            // 
            this.rtbVáltozásLista.Location = new System.Drawing.Point(3, 23);
            this.rtbVáltozásLista.Name = "rtbVáltozásLista";
            this.rtbVáltozásLista.Size = new System.Drawing.Size(790, 260);
            this.rtbVáltozásLista.TabIndex = 12;
            this.rtbVáltozásLista.Text = "";
            this.rtbVáltozásLista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rtbVáltozásLista_MouseDoubleClick);
            // 
            // ttsPlay1
            // 
            this.ttsPlay1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ttsPlay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ttsPlay1.Image = ((System.Drawing.Image)(resources.GetObject("ttsPlay1.Image")));
            this.ttsPlay1.Location = new System.Drawing.Point(775, 0);
            this.ttsPlay1.Margin = new System.Windows.Forms.Padding(0);
            this.ttsPlay1.mitMondjak = this.rtbVáltozásLista;
            this.ttsPlay1.Name = "ttsPlay1";
            this.ttsPlay1.Size = new System.Drawing.Size(24, 20);
            this.ttsPlay1.TabIndex = 13;
            this.ttsPlay1.TabStop = false;
            this.ttsPlay1.TTSállapot = false;
            // 
            // formAlapbeállítások
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1647, 1000);
            this.Controls.Add(this.gbVáltozásLista1);
            this.Controls.Add(this.gbBeszédaszisztens);
            this.Controls.Add(this.gbLicenc);
            this.Controls.Add(this.pbFormClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAlapbeállítások";
            this.Text = "formAlapbeállítások";
            this.Load += new System.EventHandler(this.formAlapbeállítások_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).EndInit();
            this.gbLicenc.ResumeLayout(false);
            this.gbLicenc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.gbBeszédaszisztens.ResumeLayout(false);
            this.gbBeszédaszisztens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSebesség)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbHangerő)).EndInit();
            this.gbVáltozásLista1.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ttsPlay1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFormClose;
        private System.Windows.Forms.GroupBox gbLicenc;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.TextBox tbLicenc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAktualizálás;
        private System.Windows.Forms.GroupBox gbBeszédaszisztens;
        private System.Windows.Forms.Button btCégMódosítás;
        private System.Windows.Forms.CheckBox cbTTSEngedélyezve;
        private System.Windows.Forms.GroupBox gbVáltozásLista1;
        private System.Windows.Forms.TrackBar trbSebesség;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trbHangerő;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.RichTextBox rtbVáltozásLista;
        private Vezérlők.TTSPlay ttsPlay1;
    }
}