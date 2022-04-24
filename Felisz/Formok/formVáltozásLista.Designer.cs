
namespace Felisz.Formok
{
    partial class formVáltozásLista
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
            this.lbVerzió = new System.Windows.Forms.Label();
            this.rtbVáltozásLista = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbVerzió
            // 
            this.lbVerzió.AutoSize = true;
            this.lbVerzió.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbVerzió.Location = new System.Drawing.Point(0, 0);
            this.lbVerzió.Name = "lbVerzió";
            this.lbVerzió.Size = new System.Drawing.Size(82, 13);
            this.lbVerzió.TabIndex = 0;
            this.lbVerzió.Text = "Jelenlegi verzió:";
            // 
            // rtbVáltozásLista
            // 
            this.rtbVáltozásLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbVáltozásLista.BackColor = System.Drawing.Color.White;
            this.rtbVáltozásLista.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbVáltozásLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rtbVáltozásLista.Location = new System.Drawing.Point(15, 19);
            this.rtbVáltozásLista.Margin = new System.Windows.Forms.Padding(6);
            this.rtbVáltozásLista.Name = "rtbVáltozásLista";
            this.rtbVáltozásLista.ReadOnly = true;
            this.rtbVáltozásLista.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbVáltozásLista.Size = new System.Drawing.Size(790, 314);
            this.rtbVáltozásLista.TabIndex = 2;
            this.rtbVáltozásLista.Text = "";
            // 
            // formVáltozásLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(823, 348);
            this.Controls.Add(this.rtbVáltozásLista);
            this.Controls.Add(this.lbVerzió);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formVáltozásLista";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Változáslista";
            this.Load += new System.EventHandler(this.formVáltozásLista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVerzió;
        private System.Windows.Forms.RichTextBox rtbVáltozásLista;
    }
}