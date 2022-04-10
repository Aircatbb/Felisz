
namespace Felisz.Formok
{
    partial class formTörlésFigyelmeztetés
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btTörlés = new System.Windows.Forms.Button();
            this.btMegszakítás = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(493, 106);
            this.textBox1.TabIndex = 10;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "FIGYELEM! VÉGLEGESEN TÖRÖLNI KÉSZÜL A KIVÁLASZTOTT MUNKAVÁLLALÓT!\r\n\r\nAmennyiben m" +
    "egerősíti a törlést, úgy a munkavállaló minden rögzített adata törlödik az adatb" +
    "ázisból! Valóban törölni kívánja?\r\n\r\n";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btTörlés
            // 
            this.btTörlés.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.btTörlés.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btTörlés.FlatAppearance.BorderSize = 0;
            this.btTörlés.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTörlés.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btTörlés.ForeColor = System.Drawing.Color.White;
            this.btTörlés.Location = new System.Drawing.Point(12, 158);
            this.btTörlés.Margin = new System.Windows.Forms.Padding(3, 3, 22, 3);
            this.btTörlés.Name = "btTörlés";
            this.btTörlés.Size = new System.Drawing.Size(102, 26);
            this.btTörlés.TabIndex = 2;
            this.btTörlés.Text = "TÖRLÉS";
            this.btTörlés.UseVisualStyleBackColor = false;
            this.btTörlés.Click += new System.EventHandler(this.btTörlés_Click);
            // 
            // btMegszakítás
            // 
            this.btMegszakítás.BackColor = System.Drawing.Color.YellowGreen;
            this.btMegszakítás.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btMegszakítás.FlatAppearance.BorderSize = 0;
            this.btMegszakítás.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMegszakítás.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btMegszakítás.ForeColor = System.Drawing.Color.White;
            this.btMegszakítás.Location = new System.Drawing.Point(403, 158);
            this.btMegszakítás.Margin = new System.Windows.Forms.Padding(3, 3, 22, 3);
            this.btMegszakítás.Name = "btMegszakítás";
            this.btMegszakítás.Size = new System.Drawing.Size(102, 26);
            this.btMegszakítás.TabIndex = 1;
            this.btMegszakítás.Text = "MEGSZAKÍTÁS";
            this.btMegszakítás.UseVisualStyleBackColor = false;
            this.btMegszakítás.Click += new System.EventHandler(this.btMegszakítás_Click);
            // 
            // formTörlésFigyelmeztetés
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(517, 196);
            this.Controls.Add(this.btMegszakítás);
            this.Controls.Add(this.btTörlés);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formTörlésFigyelmeztetés";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Figyelem!";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.formTörlésFigyelmeztetés_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btTörlés;
        private System.Windows.Forms.Button btMegszakítás;
    }
}