
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
            this.pbFormClose = new System.Windows.Forms.PictureBox();
            this.gbLicenc = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbLicenc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btAktualizálás = new System.Windows.Forms.Button();
            this.gbCégadatok = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCégMódosítás = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).BeginInit();
            this.gbLicenc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbCégadatok.SuspendLayout();
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
            this.gbLicenc.Controls.Add(this.pictureBox1);
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Felisz.Properties.Resources.window_close;
            this.pictureBox1.Location = new System.Drawing.Point(1626, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // tbLicenc
            // 
            this.tbLicenc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbLicenc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLicenc.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbLicenc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbLicenc.Location = new System.Drawing.Point(95, 20);
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
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Új licenckód";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btAktualizálás
            // 
            this.btAktualizálás.BackColor = System.Drawing.Color.Transparent;
            this.btAktualizálás.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btAktualizálás.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btAktualizálás.Location = new System.Drawing.Point(713, 20);
            this.btAktualizálás.Name = "btAktualizálás";
            this.btAktualizálás.Size = new System.Drawing.Size(102, 26);
            this.btAktualizálás.TabIndex = 4;
            this.btAktualizálás.Text = "AKTUALIZÁLÁS";
            this.btAktualizálás.UseVisualStyleBackColor = false;
            this.btAktualizálás.Click += new System.EventHandler(this.btAktualizálás_Click);
            // 
            // gbCégadatok
            // 
            this.gbCégadatok.Controls.Add(this.textBox1);
            this.gbCégadatok.Controls.Add(this.label1);
            this.gbCégadatok.Controls.Add(this.btCégMódosítás);
            this.gbCégadatok.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCégadatok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gbCégadatok.Location = new System.Drawing.Point(0, 61);
            this.gbCégadatok.Name = "gbCégadatok";
            this.gbCégadatok.Size = new System.Drawing.Size(1647, 531);
            this.gbCégadatok.TabIndex = 14;
            this.gbCégadatok.TabStop = false;
            this.gbCégadatok.Text = "Cégadatok";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox1.Location = new System.Drawing.Point(95, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(612, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Új licenckód";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // formAlapbeállítások
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1647, 1000);
            this.Controls.Add(this.gbCégadatok);
            this.Controls.Add(this.gbLicenc);
            this.Controls.Add(this.pbFormClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAlapbeállítások";
            this.Text = "formAlapbeállítások";
            this.Load += new System.EventHandler(this.formAlapbeállítások_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).EndInit();
            this.gbLicenc.ResumeLayout(false);
            this.gbLicenc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbCégadatok.ResumeLayout(false);
            this.gbCégadatok.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFormClose;
        private System.Windows.Forms.GroupBox gbLicenc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbLicenc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAktualizálás;
        private System.Windows.Forms.GroupBox gbCégadatok;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCégMódosítás;
    }
}