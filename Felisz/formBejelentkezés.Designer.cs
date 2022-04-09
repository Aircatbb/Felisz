
namespace Felisz
{
    partial class formBejelentkezés
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
            this.btBejelentkezés = new System.Windows.Forms.Button();
            this.tbJelszó = new System.Windows.Forms.MaskedTextBox();
            this.tbFelhasználó = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCég = new System.Windows.Forms.Label();
            this.lbVerzió = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBejelentkezés
            // 
            this.btBejelentkezés.BackColor = System.Drawing.Color.Transparent;
            this.btBejelentkezés.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btBejelentkezés.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btBejelentkezés.Location = new System.Drawing.Point(145, 94);
            this.btBejelentkezés.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btBejelentkezés.Name = "btBejelentkezés";
            this.btBejelentkezés.Size = new System.Drawing.Size(201, 32);
            this.btBejelentkezés.TabIndex = 1;
            this.btBejelentkezés.Text = "BEJELENTKEZÉS";
            this.btBejelentkezés.UseVisualStyleBackColor = false;
            this.btBejelentkezés.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbJelszó
            // 
            this.tbJelszó.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbJelszó.Location = new System.Drawing.Point(145, 45);
            this.tbJelszó.Name = "tbJelszó";
            this.tbJelszó.Size = new System.Drawing.Size(201, 26);
            this.tbJelszó.TabIndex = 0;
            this.tbJelszó.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbJelszó.UseSystemPasswordChar = true;
            this.tbJelszó.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbJelszó_KeyDown);
            // 
            // tbFelhasználó
            // 
            this.tbFelhasználó.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbFelhasználó.Location = new System.Drawing.Point(145, 14);
            this.tbFelhasználó.Name = "tbFelhasználó";
            this.tbFelhasználó.Size = new System.Drawing.Size(201, 26);
            this.tbFelhasználó.TabIndex = 3;
            this.tbFelhasználó.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.Location = new System.Drawing.Point(145, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "KILÉPÉS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "FELHASZNÁLÓNÉV:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "JELSZÓ:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.MaximumSize = new System.Drawing.Size(427, 236);
            this.panel1.MinimumSize = new System.Drawing.Size(427, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 236);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCég);
            this.groupBox1.Controls.Add(this.lbVerzió);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbFelhasználó);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbJelszó);
            this.groupBox1.Controls.Add(this.btBejelentkezés);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 236);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FELISZ";
            // 
            // lbCég
            // 
            this.lbCég.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCég.Font = new System.Drawing.Font("Arial Narrow", 8F);
            this.lbCég.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbCég.Location = new System.Drawing.Point(3, 194);
            this.lbCég.Name = "lbCég";
            this.lbCég.Size = new System.Drawing.Size(155, 39);
            this.lbCég.TabIndex = 8;
            this.lbCég.Text = "-";
            this.lbCég.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbVerzió
            // 
            this.lbVerzió.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVerzió.Font = new System.Drawing.Font("Arial Narrow", 8F);
            this.lbVerzió.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbVerzió.Location = new System.Drawing.Point(253, 194);
            this.lbVerzió.Name = "lbVerzió";
            this.lbVerzió.Size = new System.Drawing.Size(171, 39);
            this.lbVerzió.TabIndex = 7;
            this.lbVerzió.Text = "-";
            this.lbVerzió.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lbVerzió.Click += new System.EventHandler(this.lbVerzió_Click);
            // 
            // formBejelentkezés
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(452, 264);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(500, 300);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formBejelentkezés";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bejelentkezés";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.formBejelentkezés_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBejelentkezés;
        private System.Windows.Forms.MaskedTextBox tbJelszó;
        private System.Windows.Forms.TextBox tbFelhasználó;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbVerzió;
        private System.Windows.Forms.Label lbCég;
    }
}