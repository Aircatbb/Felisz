
namespace Felisz.Formok
{
    partial class formFigyelmeztetésÁltalános
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
            this.btMegszakítás = new System.Windows.Forms.Button();
            this.btTörlés = new System.Windows.Forms.Button();
            this.tbFigyelmeztetés = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btMegszakítás
            // 
            this.btMegszakítás.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btMegszakítás.BackColor = System.Drawing.Color.YellowGreen;
            this.btMegszakítás.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btMegszakítás.FlatAppearance.BorderSize = 0;
            this.btMegszakítás.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMegszakítás.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btMegszakítás.ForeColor = System.Drawing.Color.White;
            this.btMegszakítás.Location = new System.Drawing.Point(403, 68);
            this.btMegszakítás.Margin = new System.Windows.Forms.Padding(3, 3, 22, 3);
            this.btMegszakítás.Name = "btMegszakítás";
            this.btMegszakítás.Size = new System.Drawing.Size(102, 26);
            this.btMegszakítás.TabIndex = 11;
            this.btMegszakítás.Text = "MEGSZAKÍTÁS";
            this.btMegszakítás.UseVisualStyleBackColor = false;
            this.btMegszakítás.Click += new System.EventHandler(this.btMegszakítás_Click);
            // 
            // btTörlés
            // 
            this.btTörlés.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btTörlés.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.btTörlés.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btTörlés.FlatAppearance.BorderSize = 0;
            this.btTörlés.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTörlés.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btTörlés.ForeColor = System.Drawing.Color.White;
            this.btTörlés.Location = new System.Drawing.Point(12, 68);
            this.btTörlés.Margin = new System.Windows.Forms.Padding(3, 3, 22, 3);
            this.btTörlés.Name = "btTörlés";
            this.btTörlés.Size = new System.Drawing.Size(102, 26);
            this.btTörlés.TabIndex = 12;
            this.btTörlés.Text = "TÖRLÉS";
            this.btTörlés.UseVisualStyleBackColor = false;
            this.btTörlés.Click += new System.EventHandler(this.btTörlés_Click);
            // 
            // tbFigyelmeztetés
            // 
            this.tbFigyelmeztetés.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.tbFigyelmeztetés.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFigyelmeztetés.ForeColor = System.Drawing.Color.White;
            this.tbFigyelmeztetés.Location = new System.Drawing.Point(12, 12);
            this.tbFigyelmeztetés.Multiline = true;
            this.tbFigyelmeztetés.Name = "tbFigyelmeztetés";
            this.tbFigyelmeztetés.ReadOnly = true;
            this.tbFigyelmeztetés.Size = new System.Drawing.Size(493, 50);
            this.tbFigyelmeztetés.TabIndex = 13;
            this.tbFigyelmeztetés.TabStop = false;
            this.tbFigyelmeztetés.Text = "FIGYELEM!\r\n";
            this.tbFigyelmeztetés.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // formFigyelmeztetésÁltalános
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(517, 106);
            this.Controls.Add(this.btMegszakítás);
            this.Controls.Add(this.btTörlés);
            this.Controls.Add(this.tbFigyelmeztetés);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formFigyelmeztetésÁltalános";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Figyelem!";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.formTörlésFigyelmeztetésÁltalános_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMegszakítás;
        private System.Windows.Forms.Button btTörlés;
        private System.Windows.Forms.TextBox tbFigyelmeztetés;
    }
}