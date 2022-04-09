
namespace Felisz.Formok
{
    partial class formMunkavállalóVálasztásNévAlapján
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
            this.tbNév = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbNév
            // 
            this.tbNév.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNév.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNév.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNév.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.tbNév.Location = new System.Drawing.Point(0, 0);
            this.tbNév.Margin = new System.Windows.Forms.Padding(2);
            this.tbNév.Name = "tbNév";
            this.tbNév.Size = new System.Drawing.Size(252, 22);
            this.tbNév.TabIndex = 6;
            this.tbNév.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNév.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNév_KeyDown);
            // 
            // formMunkavállalóVálasztásNévAlapján
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(252, 22);
            this.Controls.Add(this.tbNév);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formMunkavállalóVálasztásNévAlapján";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keresés név alapján";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNév;
    }
}