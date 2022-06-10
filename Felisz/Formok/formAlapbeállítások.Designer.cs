
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
            this.btCégMódosítás = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.trbSebesség = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trbHangerő = new System.Windows.Forms.TrackBar();
            this.cbTTSEngedélyezve = new System.Windows.Forms.CheckBox();
            this.cbTTSNyelv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbFordításNyelve = new System.Windows.Forms.Label();
            this.cbFordításNyelve = new System.Windows.Forms.ComboBox();
            this.gbVáltozásLista1 = new System.Windows.Forms.GroupBox();
            this.rtbVáltozásLista = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.trSpFordítás = new Felisz.Vezérlők.TrSpVezérlő();
            this.trSpBeszéd = new Felisz.Vezérlők.TrSpVezérlő();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).BeginInit();
            this.gbLicenc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.gbBeszédaszisztens.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSebesség)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbHangerő)).BeginInit();
            this.gbVáltozásLista1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trSpFordítás)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trSpBeszéd)).BeginInit();
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
            this.gbLicenc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLicenc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gbLicenc.Location = new System.Drawing.Point(1, 1);
            this.gbLicenc.Margin = new System.Windows.Forms.Padding(1);
            this.gbLicenc.Name = "gbLicenc";
            this.gbLicenc.Size = new System.Drawing.Size(821, 61);
            this.gbLicenc.TabIndex = 13;
            this.gbLicenc.TabStop = false;
            this.gbLicenc.Text = "Licenc aktualizálás";
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Image = global::Felisz.Properties.Resources.window_close;
            this.pbClose.Location = new System.Drawing.Point(799, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(24, 24);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbClose.TabIndex = 11;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // tbLicenc
            // 
            this.tbLicenc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLicenc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbLicenc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLicenc.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tbLicenc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbLicenc.Location = new System.Drawing.Point(82, 19);
            this.tbLicenc.Name = "tbLicenc";
            this.tbLicenc.Size = new System.Drawing.Size(611, 26);
            this.tbLicenc.TabIndex = 3;
            this.tbLicenc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btAktualizálás.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAktualizálás.BackColor = System.Drawing.Color.Transparent;
            this.btAktualizálás.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.btAktualizálás.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btAktualizálás.Location = new System.Drawing.Point(699, 19);
            this.btAktualizálás.Name = "btAktualizálás";
            this.btAktualizálás.Size = new System.Drawing.Size(102, 26);
            this.btAktualizálás.TabIndex = 4;
            this.btAktualizálás.Text = "AKTUALIZÁLÁS";
            this.btAktualizálás.UseVisualStyleBackColor = false;
            this.btAktualizálás.Click += new System.EventHandler(this.btAktualizálás_Click);
            // 
            // gbBeszédaszisztens
            // 
            this.gbBeszédaszisztens.Controls.Add(this.btCégMódosítás);
            this.gbBeszédaszisztens.Controls.Add(this.tableLayoutPanel2);
            this.gbBeszédaszisztens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gbBeszédaszisztens.Location = new System.Drawing.Point(1, 64);
            this.gbBeszédaszisztens.Margin = new System.Windows.Forms.Padding(1);
            this.gbBeszédaszisztens.Name = "gbBeszédaszisztens";
            this.gbBeszédaszisztens.Size = new System.Drawing.Size(821, 151);
            this.gbBeszédaszisztens.TabIndex = 14;
            this.gbBeszédaszisztens.TabStop = false;
            this.gbBeszédaszisztens.Text = "Beszédaszisztens";
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.trbSebesség, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.trbHangerő, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbTTSEngedélyezve, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbTTSNyelv, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbFordításNyelve, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbFordításNyelve, 2, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(815, 132);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // trbSebesség
            // 
            this.trbSebesség.LargeChange = 1;
            this.trbSebesség.Location = new System.Drawing.Point(307, 3);
            this.trbSebesség.Maximum = 5;
            this.trbSebesség.Minimum = -5;
            this.trbSebesség.Name = "trbSebesség";
            this.trbSebesség.Size = new System.Drawing.Size(172, 27);
            this.trbSebesség.TabIndex = 19;
            this.trbSebesség.Value = -5;
            this.trbSebesség.ValueChanged += new System.EventHandler(this.trbSebesség_ValueChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label3.Location = new System.Drawing.Point(228, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hangerő";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(228, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sebesség";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbHangerő
            // 
            this.trbHangerő.Location = new System.Drawing.Point(307, 36);
            this.trbHangerő.Maximum = 100;
            this.trbHangerő.Name = "trbHangerő";
            this.trbHangerő.Size = new System.Drawing.Size(172, 27);
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
            this.cbTTSEngedélyezve.Location = new System.Drawing.Point(3, 3);
            this.cbTTSEngedélyezve.Name = "cbTTSEngedélyezve";
            this.cbTTSEngedélyezve.Size = new System.Drawing.Size(219, 24);
            this.cbTTSEngedélyezve.TabIndex = 15;
            this.cbTTSEngedélyezve.Text = "Beszédaszisztens bekapcsolva";
            this.cbTTSEngedélyezve.UseVisualStyleBackColor = true;
            this.cbTTSEngedélyezve.CheckedChanged += new System.EventHandler(this.cbTTSEngedélyezve_CheckedChanged);
            // 
            // cbTTSNyelv
            // 
            this.cbTTSNyelv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTTSNyelv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTTSNyelv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbTTSNyelv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTTSNyelv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTTSNyelv.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.cbTTSNyelv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbTTSNyelv.FormattingEnabled = true;
            this.cbTTSNyelv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbTTSNyelv.Location = new System.Drawing.Point(304, 69);
            this.cbTTSNyelv.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cbTTSNyelv.Name = "cbTTSNyelv";
            this.cbTTSNyelv.Size = new System.Drawing.Size(175, 28);
            this.cbTTSNyelv.TabIndex = 37;
            this.cbTTSNyelv.SelectionChangeCommitted += new System.EventHandler(this.cbTTSNyelv_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label4.Location = new System.Drawing.Point(228, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nyelv";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFordításNyelve
            // 
            this.lbFordításNyelve.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lbFordításNyelve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lbFordításNyelve.Location = new System.Drawing.Point(228, 102);
            this.lbFordításNyelve.Margin = new System.Windows.Forms.Padding(3);
            this.lbFordításNyelve.Name = "lbFordításNyelve";
            this.lbFordításNyelve.Size = new System.Drawing.Size(73, 25);
            this.lbFordításNyelve.TabIndex = 38;
            this.lbFordításNyelve.Text = "Fordítás nyelve";
            this.lbFordításNyelve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbFordításNyelve
            // 
            this.cbFordításNyelve.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbFordításNyelve.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFordításNyelve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbFordításNyelve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFordításNyelve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFordításNyelve.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.cbFordításNyelve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbFordításNyelve.FormattingEnabled = true;
            this.cbFordításNyelve.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbFordításNyelve.IntegralHeight = false;
            this.cbFordításNyelve.Items.AddRange(new object[] {
            "CS - Cseh ",
            "DE - Német",
            "EN - Angol",
            "ES - Spanyol",
            "FR - Francia",
            "HR - Horvát",
            "IT - Olasz",
            "NL - Holland",
            "PL - Lengyel",
            "RO - Román",
            "RU - Orosz",
            "SE - Svéd",
            "SI - Szlovén",
            "SK - Szlovák",
            "SR - Szerb",
            "UK - Ukrán"});
            this.cbFordításNyelve.Location = new System.Drawing.Point(304, 102);
            this.cbFordításNyelve.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cbFordításNyelve.Name = "cbFordításNyelve";
            this.cbFordításNyelve.Size = new System.Drawing.Size(175, 28);
            this.cbFordításNyelve.Sorted = true;
            this.cbFordításNyelve.TabIndex = 39;
            this.cbFordításNyelve.SelectionChangeCommitted += new System.EventHandler(this.cbFordításNyelve_SelectionChangeCommitted);
            // 
            // gbVáltozásLista1
            // 
            this.gbVáltozásLista1.Controls.Add(this.rtbVáltozásLista);
            this.gbVáltozásLista1.Controls.Add(this.tableLayoutPanel3);
            this.gbVáltozásLista1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gbVáltozásLista1.Location = new System.Drawing.Point(1, 217);
            this.gbVáltozásLista1.Margin = new System.Windows.Forms.Padding(1);
            this.gbVáltozásLista1.Name = "gbVáltozásLista1";
            this.gbVáltozásLista1.Size = new System.Drawing.Size(821, 413);
            this.gbVáltozásLista1.TabIndex = 15;
            this.gbVáltozásLista1.TabStop = false;
            this.gbVáltozásLista1.Text = "Változáslista";
            // 
            // rtbVáltozásLista
            // 
            this.rtbVáltozásLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbVáltozásLista.Location = new System.Drawing.Point(3, 40);
            this.rtbVáltozásLista.Name = "rtbVáltozásLista";
            this.rtbVáltozásLista.Size = new System.Drawing.Size(815, 260);
            this.rtbVáltozásLista.TabIndex = 12;
            this.rtbVáltozásLista.Text = "";
            this.rtbVáltozásLista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rtbVáltozásLista_MouseDoubleClick);
            this.rtbVáltozásLista.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtbVáltozásLista_MouseDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 791F));
            this.tableLayoutPanel3.Controls.Add(this.trSpFordítás, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.trSpBeszéd, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(815, 24);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbLicenc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbVáltozásLista1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbBeszédaszisztens, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1647, 756);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // trSpFordítás
            // 
            this.trSpFordítás.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.trSpFordítás.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.trSpFordítás.Enabled = false;
            this.trSpFordítás.Image = ((System.Drawing.Image)(resources.GetObject("trSpFordítás.Image")));
            this.trSpFordítás.Location = new System.Drawing.Point(0, 0);
            this.trSpFordítás.Margin = new System.Windows.Forms.Padding(0);
            this.trSpFordítás.mitMondjak = this.rtbVáltozásLista;
            this.trSpFordítás.Name = "trSpFordítás";
            this.trSpFordítás.Size = new System.Drawing.Size(24, 24);
            this.trSpFordítás.TabIndex = 14;
            this.trSpFordítás.TabStop = false;
            this.trSpFordítás.TrMentett = "";
            this.trSpFordítás.TrNyelv = "HU";
            this.trSpFordítás.TrVagySp = true;
            this.trSpFordítás.TTSállapot = false;
            // 
            // trSpBeszéd
            // 
            this.trSpBeszéd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.trSpBeszéd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.trSpBeszéd.Enabled = false;
            this.trSpBeszéd.Image = ((System.Drawing.Image)(resources.GetObject("trSpBeszéd.Image")));
            this.trSpBeszéd.Location = new System.Drawing.Point(24, 0);
            this.trSpBeszéd.Margin = new System.Windows.Forms.Padding(0);
            this.trSpBeszéd.mitMondjak = this.rtbVáltozásLista;
            this.trSpBeszéd.Name = "trSpBeszéd";
            this.trSpBeszéd.Size = new System.Drawing.Size(24, 24);
            this.trSpBeszéd.TabIndex = 13;
            this.trSpBeszéd.TabStop = false;
            this.trSpBeszéd.TrMentett = "";
            this.trSpBeszéd.TrNyelv = "HU";
            this.trSpBeszéd.TrVagySp = false;
            this.trSpBeszéd.TTSállapot = false;
            // 
            // formAlapbeállítások
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1647, 756);
            this.Controls.Add(this.tableLayoutPanel1);
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSebesség)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbHangerő)).EndInit();
            this.gbVáltozásLista1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trSpFordítás)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trSpBeszéd)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTTSNyelv;
        private System.Windows.Forms.Label lbFordításNyelve;
        private System.Windows.Forms.ComboBox cbFordításNyelve;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RichTextBox rtbVáltozásLista;
        private Vezérlők.TrSpVezérlő trSpFordítás;
        private Vezérlők.TrSpVezérlő trSpBeszéd;
    }
}