
namespace Felisz.Formok
{
    partial class formMentésDialógus
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
            this.btMeBe = new System.Windows.Forms.Button();
            this.btMeFo = new System.Windows.Forms.Button();
            this.btMeMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMeBe
            // 
            this.btMeBe.BackColor = System.Drawing.Color.Transparent;
            this.btMeBe.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btMeBe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btMeBe.Location = new System.Drawing.Point(12, 12);
            this.btMeBe.Name = "btMeBe";
            this.btMeBe.Size = new System.Drawing.Size(95, 45);
            this.btMeBe.TabIndex = 5;
            this.btMeBe.Text = "MENTÉS és BEZÁRÁS";
            this.btMeBe.UseVisualStyleBackColor = false;
            this.btMeBe.Click += new System.EventHandler(this.btMeBe_Click);
            // 
            // btMeFo
            // 
            this.btMeFo.BackColor = System.Drawing.Color.Transparent;
            this.btMeFo.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btMeFo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btMeFo.Location = new System.Drawing.Point(113, 12);
            this.btMeFo.Name = "btMeFo";
            this.btMeFo.Size = new System.Drawing.Size(95, 45);
            this.btMeFo.TabIndex = 6;
            this.btMeFo.Text = "MENTÉS és FOLYTATÁS";
            this.btMeFo.UseVisualStyleBackColor = false;
            this.btMeFo.Click += new System.EventHandler(this.btMeFo_Click);
            // 
            // btMeMe
            // 
            this.btMeMe.BackColor = System.Drawing.Color.Transparent;
            this.btMeMe.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btMeMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btMeMe.Location = new System.Drawing.Point(214, 12);
            this.btMeMe.Name = "btMeMe";
            this.btMeMe.Size = new System.Drawing.Size(95, 45);
            this.btMeMe.TabIndex = 8;
            this.btMeMe.Text = "MENTÉS MEGSZAKÍTÁSA";
            this.btMeMe.UseVisualStyleBackColor = false;
            this.btMeMe.Click += new System.EventHandler(this.btMeMe_Click);
            // 
            // formMentésDialógus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(321, 69);
            this.Controls.Add(this.btMeMe);
            this.Controls.Add(this.btMeFo);
            this.Controls.Add(this.btMeBe);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formMentésDialógus";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mentés";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMeBe;
        private System.Windows.Forms.Button btMeFo;
        private System.Windows.Forms.Button btMeMe;
    }
}