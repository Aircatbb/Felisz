
namespace Felisz
{
    partial class formFelisz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFelisz));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btKijelentkezés = new System.Windows.Forms.Button();
            this.btJelszóVált = new System.Windows.Forms.Button();
            this.panelExportImportSubMenu = new System.Windows.Forms.Panel();
            this.btExportImportAdatokKezelese = new System.Windows.Forms.Button();
            this.btExportImport = new System.Windows.Forms.Button();
            this.panelHRSubMenu = new System.Windows.Forms.Panel();
            this.btHR = new System.Windows.Forms.Button();
            this.panelAdminSubMenu = new System.Windows.Forms.Panel();
            this.btAdmin = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.ADALogo = new System.Windows.Forms.PictureBox();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.lbStátusz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbVonalFüggőleges = new System.Windows.Forms.PictureBox();
            this.pbVonal = new System.Windows.Forms.PictureBox();
            this.llbRSS = new System.Windows.Forms.LinkLabel();
            this.lbFelhasználó = new System.Windows.Forms.Label();
            this.pbFormMinimize = new System.Windows.Forms.PictureBox();
            this.pbFormMaximize = new System.Windows.Forms.PictureBox();
            this.pbFormClose = new System.Windows.Forms.PictureBox();
            this.panelHáttér = new System.Windows.Forms.Panel();
            this.pictureScore = new System.Windows.Forms.PictureBox();
            this.timerHáttér = new System.Windows.Forms.Timer(this.components);
            this.timerRSS = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folyamatJelző1 = new Felisz.FolyamatJelző();
            this.btHRMT = new Felisz.MenüGombokNew();
            this.btHRKalkulator = new Felisz.MenüGombokNew();
            this.btHRUtikoltseg = new Felisz.MenüGombokNew();
            this.btHRStatisztikak = new Felisz.MenüGombokNew();
            this.btHRJelentkezok = new Felisz.MenüGombokNew();
            this.btHRFigyelmeztetesek = new Felisz.MenüGombokNew();
            this.btHRMunkaszerzodesModositasa = new Felisz.MenüGombokNew();
            this.btHRFelmondas = new Felisz.MenüGombokNew();
            this.btHRMunkaszerzodes = new Felisz.MenüGombokNew();
            this.btAdminFelhasznalok = new Felisz.MenüGombokNew();
            this.btAdminGlobalAdminBeallitasok = new Felisz.MenüGombokNew();
            this.btAdminAlapBeallitasok = new Felisz.MenüGombokNew();
            this.panelSideMenu.SuspendLayout();
            this.panelExportImportSubMenu.SuspendLayout();
            this.panelHRSubMenu.SuspendLayout();
            this.panelAdminSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADALogo)).BeginInit();
            this.panelTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVonalFüggőleges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).BeginInit();
            this.panelHáttér.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureScore)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelSideMenu.Controls.Add(this.btKijelentkezés);
            this.panelSideMenu.Controls.Add(this.btJelszóVált);
            this.panelSideMenu.Controls.Add(this.panelExportImportSubMenu);
            this.panelSideMenu.Controls.Add(this.btExportImport);
            this.panelSideMenu.Controls.Add(this.panelHRSubMenu);
            this.panelSideMenu.Controls.Add(this.btHR);
            this.panelSideMenu.Controls.Add(this.panelAdminSubMenu);
            this.panelSideMenu.Controls.Add(this.btAdmin);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(273, 1024);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btKijelentkezés
            // 
            this.btKijelentkezés.Dock = System.Windows.Forms.DockStyle.Top;
            this.btKijelentkezés.FlatAppearance.BorderSize = 0;
            this.btKijelentkezés.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKijelentkezés.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btKijelentkezés.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btKijelentkezés.Location = new System.Drawing.Point(0, 981);
            this.btKijelentkezés.Name = "btKijelentkezés";
            this.btKijelentkezés.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btKijelentkezés.Size = new System.Drawing.Size(273, 45);
            this.btKijelentkezés.TabIndex = 14;
            this.btKijelentkezés.Text = "KIJELENTKEZÉS";
            this.btKijelentkezés.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btKijelentkezés.UseVisualStyleBackColor = true;
            this.btKijelentkezés.Visible = false;
            this.btKijelentkezés.Click += new System.EventHandler(this.btKijelentkezés_Click);
            // 
            // btJelszóVált
            // 
            this.btJelszóVált.Dock = System.Windows.Forms.DockStyle.Top;
            this.btJelszóVált.FlatAppearance.BorderSize = 0;
            this.btJelszóVált.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btJelszóVált.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btJelszóVált.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btJelszóVált.Location = new System.Drawing.Point(0, 936);
            this.btJelszóVált.Name = "btJelszóVált";
            this.btJelszóVált.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btJelszóVált.Size = new System.Drawing.Size(273, 45);
            this.btJelszóVált.TabIndex = 13;
            this.btJelszóVált.Text = "Jelszóváltoztatás";
            this.btJelszóVált.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btJelszóVált.UseVisualStyleBackColor = true;
            this.btJelszóVált.Visible = false;
            this.btJelszóVált.Click += new System.EventHandler(this.btJelszóVált_Click);
            // 
            // panelExportImportSubMenu
            // 
            this.panelExportImportSubMenu.Controls.Add(this.btExportImportAdatokKezelese);
            this.panelExportImportSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExportImportSubMenu.Location = new System.Drawing.Point(0, 852);
            this.panelExportImportSubMenu.Name = "panelExportImportSubMenu";
            this.panelExportImportSubMenu.Size = new System.Drawing.Size(273, 84);
            this.panelExportImportSubMenu.TabIndex = 7;
            this.panelExportImportSubMenu.Visible = false;
            // 
            // btExportImportAdatokKezelese
            // 
            this.btExportImportAdatokKezelese.Dock = System.Windows.Forms.DockStyle.Top;
            this.btExportImportAdatokKezelese.FlatAppearance.BorderSize = 0;
            this.btExportImportAdatokKezelese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExportImportAdatokKezelese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btExportImportAdatokKezelese.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btExportImportAdatokKezelese.Location = new System.Drawing.Point(0, 0);
            this.btExportImportAdatokKezelese.Name = "btExportImportAdatokKezelese";
            this.btExportImportAdatokKezelese.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btExportImportAdatokKezelese.Size = new System.Drawing.Size(273, 40);
            this.btExportImportAdatokKezelese.TabIndex = 12;
            this.btExportImportAdatokKezelese.Text = "Adatok kezelése";
            this.btExportImportAdatokKezelese.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExportImportAdatokKezelese.UseVisualStyleBackColor = true;
            this.btExportImportAdatokKezelese.Visible = false;
            this.btExportImportAdatokKezelese.Click += new System.EventHandler(this.btFelhasználóAdatokKezelése_Click_1);
            // 
            // btExportImport
            // 
            this.btExportImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btExportImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btExportImport.FlatAppearance.BorderSize = 0;
            this.btExportImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExportImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btExportImport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btExportImport.Location = new System.Drawing.Point(0, 812);
            this.btExportImport.Name = "btExportImport";
            this.btExportImport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btExportImport.Size = new System.Drawing.Size(273, 40);
            this.btExportImport.TabIndex = 11;
            this.btExportImport.Text = "EXPORT \\ IMPORT";
            this.btExportImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExportImport.UseVisualStyleBackColor = false;
            this.btExportImport.Visible = false;
            this.btExportImport.Click += new System.EventHandler(this.btFelhasználó_Click);
            // 
            // panelHRSubMenu
            // 
            this.panelHRSubMenu.Controls.Add(this.btHRMT);
            this.panelHRSubMenu.Controls.Add(this.btHRKalkulator);
            this.panelHRSubMenu.Controls.Add(this.btHRUtikoltseg);
            this.panelHRSubMenu.Controls.Add(this.btHRStatisztikak);
            this.panelHRSubMenu.Controls.Add(this.btHRJelentkezok);
            this.panelHRSubMenu.Controls.Add(this.btHRFigyelmeztetesek);
            this.panelHRSubMenu.Controls.Add(this.btHRMunkaszerzodesModositasa);
            this.panelHRSubMenu.Controls.Add(this.btHRFelmondas);
            this.panelHRSubMenu.Controls.Add(this.btHRMunkaszerzodes);
            this.panelHRSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHRSubMenu.Location = new System.Drawing.Point(0, 435);
            this.panelHRSubMenu.Name = "panelHRSubMenu";
            this.panelHRSubMenu.Size = new System.Drawing.Size(273, 377);
            this.panelHRSubMenu.TabIndex = 5;
            this.panelHRSubMenu.Visible = false;
            // 
            // btHR
            // 
            this.btHR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHR.FlatAppearance.BorderSize = 0;
            this.btHR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btHR.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btHR.Location = new System.Drawing.Point(0, 390);
            this.btHR.Name = "btHR";
            this.btHR.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btHR.Size = new System.Drawing.Size(273, 45);
            this.btHR.TabIndex = 2;
            this.btHR.Text = "HR";
            this.btHR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHR.UseVisualStyleBackColor = true;
            this.btHR.Visible = false;
            this.btHR.Click += new System.EventHandler(this.btHR_Click);
            // 
            // panelAdminSubMenu
            // 
            this.panelAdminSubMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelAdminSubMenu.Controls.Add(this.btAdminFelhasznalok);
            this.panelAdminSubMenu.Controls.Add(this.btAdminGlobalAdminBeallitasok);
            this.panelAdminSubMenu.Controls.Add(this.btAdminAlapBeallitasok);
            this.panelAdminSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdminSubMenu.Location = new System.Drawing.Point(0, 240);
            this.panelAdminSubMenu.Name = "panelAdminSubMenu";
            this.panelAdminSubMenu.Size = new System.Drawing.Size(273, 150);
            this.panelAdminSubMenu.TabIndex = 3;
            this.panelAdminSubMenu.Visible = false;
            // 
            // btAdmin
            // 
            this.btAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAdmin.FlatAppearance.BorderSize = 0;
            this.btAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btAdmin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btAdmin.Location = new System.Drawing.Point(0, 200);
            this.btAdmin.Name = "btAdmin";
            this.btAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btAdmin.Size = new System.Drawing.Size(273, 40);
            this.btAdmin.TabIndex = 0;
            this.btAdmin.Text = "ADMIN";
            this.btAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdmin.UseVisualStyleBackColor = true;
            this.btAdmin.Visible = false;
            this.btAdmin.Click += new System.EventHandler(this.btAdmin_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Controls.Add(this.ADALogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(273, 200);
            this.panelLogo.TabIndex = 0;
            // 
            // ADALogo
            // 
            this.ADALogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ADALogo.Image = global::Felisz.Properties.Resources.Felisz;
            this.ADALogo.Location = new System.Drawing.Point(0, 0);
            this.ADALogo.Name = "ADALogo";
            this.ADALogo.Size = new System.Drawing.Size(200, 200);
            this.ADALogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ADALogo.TabIndex = 0;
            this.ADALogo.TabStop = false;
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelTopMenu.Controls.Add(this.folyamatJelző1);
            this.panelTopMenu.Controls.Add(this.lbStátusz);
            this.panelTopMenu.Controls.Add(this.label1);
            this.panelTopMenu.Controls.Add(this.pbVonalFüggőleges);
            this.panelTopMenu.Controls.Add(this.pbVonal);
            this.panelTopMenu.Controls.Add(this.llbRSS);
            this.panelTopMenu.Controls.Add(this.lbFelhasználó);
            this.panelTopMenu.Controls.Add(this.pbFormMinimize);
            this.panelTopMenu.Controls.Add(this.pbFormMaximize);
            this.panelTopMenu.Controls.Add(this.pbFormClose);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(273, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(1480, 73);
            this.panelTopMenu.TabIndex = 1;
            this.panelTopMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTopMenu_Paint);
            // 
            // lbStátusz
            // 
            this.lbStátusz.Font = new System.Drawing.Font("Arial Narrow", 8F);
            this.lbStátusz.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbStátusz.Location = new System.Drawing.Point(3, 52);
            this.lbStátusz.Name = "lbStátusz";
            this.lbStátusz.Size = new System.Drawing.Size(715, 14);
            this.lbStátusz.TabIndex = 8;
            this.lbStátusz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbStátusz.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(1018, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Névnap, születésnap, LOG2DB";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbVonalFüggőleges
            // 
            this.pbVonalFüggőleges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pbVonalFüggőleges.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbVonalFüggőleges.Location = new System.Drawing.Point(0, 0);
            this.pbVonalFüggőleges.Name = "pbVonalFüggőleges";
            this.pbVonalFüggőleges.Size = new System.Drawing.Size(1, 72);
            this.pbVonalFüggőleges.TabIndex = 5;
            this.pbVonalFüggőleges.TabStop = false;
            // 
            // pbVonal
            // 
            this.pbVonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pbVonal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbVonal.Location = new System.Drawing.Point(0, 72);
            this.pbVonal.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pbVonal.Name = "pbVonal";
            this.pbVonal.Size = new System.Drawing.Size(1480, 1);
            this.pbVonal.TabIndex = 4;
            this.pbVonal.TabStop = false;
            // 
            // llbRSS
            // 
            this.llbRSS.ActiveLinkColor = System.Drawing.Color.Silver;
            this.llbRSS.AutoSize = true;
            this.llbRSS.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.llbRSS.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llbRSS.LinkColor = System.Drawing.SystemColors.GrayText;
            this.llbRSS.Location = new System.Drawing.Point(5, 3);
            this.llbRSS.Name = "llbRSS";
            this.llbRSS.Size = new System.Drawing.Size(21, 20);
            this.llbRSS.TabIndex = 0;
            this.llbRSS.TabStop = true;
            this.llbRSS.Text = "---";
            this.llbRSS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRSS_LinkClicked);
            // 
            // lbFelhasználó
            // 
            this.lbFelhasználó.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFelhasználó.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lbFelhasználó.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbFelhasználó.Location = new System.Drawing.Point(1069, 3);
            this.lbFelhasználó.Name = "lbFelhasználó";
            this.lbFelhasználó.Size = new System.Drawing.Size(318, 20);
            this.lbFelhasználó.TabIndex = 3;
            this.lbFelhasználó.Text = "Felhasználó: ";
            this.lbFelhasználó.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbFormMinimize
            // 
            this.pbFormMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFormMinimize.BackColor = System.Drawing.Color.Transparent;
            this.pbFormMinimize.Image = global::Felisz.Properties.Resources.window_minimize;
            this.pbFormMinimize.Location = new System.Drawing.Point(1393, 3);
            this.pbFormMinimize.Name = "pbFormMinimize";
            this.pbFormMinimize.Size = new System.Drawing.Size(24, 24);
            this.pbFormMinimize.TabIndex = 2;
            this.pbFormMinimize.TabStop = false;
            this.pbFormMinimize.Click += new System.EventHandler(this.pbFormMinimize_Click);
            this.pbFormMinimize.MouseEnter += new System.EventHandler(this.pbFormMinimize_MouseEnter);
            this.pbFormMinimize.MouseLeave += new System.EventHandler(this.pbFormMinimize_MouseLeave);
            // 
            // pbFormMaximize
            // 
            this.pbFormMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFormMaximize.BackColor = System.Drawing.Color.Transparent;
            this.pbFormMaximize.Image = global::Felisz.Properties.Resources.window_maximize;
            this.pbFormMaximize.Location = new System.Drawing.Point(1423, 3);
            this.pbFormMaximize.Name = "pbFormMaximize";
            this.pbFormMaximize.Size = new System.Drawing.Size(24, 24);
            this.pbFormMaximize.TabIndex = 1;
            this.pbFormMaximize.TabStop = false;
            this.pbFormMaximize.Click += new System.EventHandler(this.pbFormMaximize_Click);
            this.pbFormMaximize.MouseEnter += new System.EventHandler(this.pbFormMaximize_MouseEnter);
            this.pbFormMaximize.MouseLeave += new System.EventHandler(this.pbFormMaximize_MouseLeave);
            // 
            // pbFormClose
            // 
            this.pbFormClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFormClose.Image = global::Felisz.Properties.Resources.window_close;
            this.pbFormClose.Location = new System.Drawing.Point(1453, 3);
            this.pbFormClose.Name = "pbFormClose";
            this.pbFormClose.Size = new System.Drawing.Size(24, 24);
            this.pbFormClose.TabIndex = 0;
            this.pbFormClose.TabStop = false;
            this.pbFormClose.Click += new System.EventHandler(this.pbFormClose_Click);
            this.pbFormClose.MouseEnter += new System.EventHandler(this.pbFormClose_MouseEnter);
            this.pbFormClose.MouseLeave += new System.EventHandler(this.pbFormClose_MouseLeave);
            // 
            // panelHáttér
            // 
            this.panelHáttér.AutoSize = true;
            this.panelHáttér.BackColor = System.Drawing.Color.Transparent;
            this.panelHáttér.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHáttér.Controls.Add(this.pictureScore);
            this.panelHáttér.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHáttér.Location = new System.Drawing.Point(273, 73);
            this.panelHáttér.Name = "panelHáttér";
            this.panelHáttér.Size = new System.Drawing.Size(1480, 951);
            this.panelHáttér.TabIndex = 1;
            // 
            // pictureScore
            // 
            this.pictureScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureScore.Location = new System.Drawing.Point(0, 0);
            this.pictureScore.Name = "pictureScore";
            this.pictureScore.Size = new System.Drawing.Size(1480, 951);
            this.pictureScore.TabIndex = 0;
            this.pictureScore.TabStop = false;
            // 
            // timerHáttér
            // 
            this.timerHáttér.Enabled = true;
            this.timerHáttér.Interval = 1000;
            this.timerHáttér.Tick += new System.EventHandler(this.timerHáttér_Tick);
            // 
            // timerRSS
            // 
            this.timerRSS.Interval = 8000;
            this.timerRSS.Tick += new System.EventHandler(this.timerRSS_Tick);
            // 
            // folyamatJelző1
            // 
            this.folyamatJelző1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.folyamatJelző1.Location = new System.Drawing.Point(1, 69);
            this.folyamatJelző1.Name = "folyamatJelző1";
            this.folyamatJelző1.Size = new System.Drawing.Size(1479, 3);
            this.folyamatJelző1.TabIndex = 9;
            this.folyamatJelző1.Visible = false;
            // 
            // btHRMT
            // 
            this.btHRMT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btHRMT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btHRMT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHRMT.FlatAppearance.BorderSize = 0;
            this.btHRMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHRMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btHRMT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btHRMT.Image = global::Felisz.Properties.Resources.ikon_Munka_Törvénykönyve;
            this.btHRMT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHRMT.Location = new System.Drawing.Point(0, 320);
            this.btHRMT.Name = "btHRMT";
            this.btHRMT.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btHRMT.Size = new System.Drawing.Size(273, 40);
            this.btHRMT.TabIndex = 11;
            this.btHRMT.Text = " Munka Törvénykönyve";
            this.btHRMT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHRMT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHRMT.UseVisualStyleBackColor = false;
            this.btHRMT.Visible = false;
            this.btHRMT.Click += new System.EventHandler(this.menüGombok1_Click);
            // 
            // btHRKalkulator
            // 
            this.btHRKalkulator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btHRKalkulator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btHRKalkulator.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHRKalkulator.FlatAppearance.BorderSize = 0;
            this.btHRKalkulator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHRKalkulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btHRKalkulator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btHRKalkulator.Image = global::Felisz.Properties.Resources.ikon_Kalkulátor;
            this.btHRKalkulator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHRKalkulator.Location = new System.Drawing.Point(0, 280);
            this.btHRKalkulator.Name = "btHRKalkulator";
            this.btHRKalkulator.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btHRKalkulator.Size = new System.Drawing.Size(273, 40);
            this.btHRKalkulator.TabIndex = 10;
            this.btHRKalkulator.Text = "  Kalkulátor";
            this.btHRKalkulator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHRKalkulator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHRKalkulator.UseVisualStyleBackColor = false;
            this.btHRKalkulator.Visible = false;
            this.btHRKalkulator.Click += new System.EventHandler(this.btHRKalkulátor_Click);
            // 
            // btHRUtikoltseg
            // 
            this.btHRUtikoltseg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btHRUtikoltseg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btHRUtikoltseg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHRUtikoltseg.FlatAppearance.BorderSize = 0;
            this.btHRUtikoltseg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHRUtikoltseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btHRUtikoltseg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btHRUtikoltseg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHRUtikoltseg.Location = new System.Drawing.Point(0, 240);
            this.btHRUtikoltseg.Name = "btHRUtikoltseg";
            this.btHRUtikoltseg.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btHRUtikoltseg.Size = new System.Drawing.Size(273, 40);
            this.btHRUtikoltseg.TabIndex = 9;
            this.btHRUtikoltseg.Text = "  Utiköltség";
            this.btHRUtikoltseg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHRUtikoltseg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHRUtikoltseg.UseVisualStyleBackColor = false;
            this.btHRUtikoltseg.Visible = false;
            // 
            // btHRStatisztikak
            // 
            this.btHRStatisztikak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btHRStatisztikak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btHRStatisztikak.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHRStatisztikak.FlatAppearance.BorderSize = 0;
            this.btHRStatisztikak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHRStatisztikak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btHRStatisztikak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btHRStatisztikak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHRStatisztikak.Location = new System.Drawing.Point(0, 200);
            this.btHRStatisztikak.Name = "btHRStatisztikak";
            this.btHRStatisztikak.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btHRStatisztikak.Size = new System.Drawing.Size(273, 40);
            this.btHRStatisztikak.TabIndex = 8;
            this.btHRStatisztikak.Text = "  Statisztikák";
            this.btHRStatisztikak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHRStatisztikak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHRStatisztikak.UseVisualStyleBackColor = false;
            this.btHRStatisztikak.Visible = false;
            // 
            // btHRJelentkezok
            // 
            this.btHRJelentkezok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btHRJelentkezok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btHRJelentkezok.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHRJelentkezok.FlatAppearance.BorderSize = 0;
            this.btHRJelentkezok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHRJelentkezok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btHRJelentkezok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btHRJelentkezok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHRJelentkezok.Location = new System.Drawing.Point(0, 160);
            this.btHRJelentkezok.Name = "btHRJelentkezok";
            this.btHRJelentkezok.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btHRJelentkezok.Size = new System.Drawing.Size(273, 40);
            this.btHRJelentkezok.TabIndex = 7;
            this.btHRJelentkezok.Text = "  Jelentkezők";
            this.btHRJelentkezok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHRJelentkezok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHRJelentkezok.UseVisualStyleBackColor = false;
            this.btHRJelentkezok.Visible = false;
            this.btHRJelentkezok.Click += new System.EventHandler(this.btHRJelentkezok_Click);
            // 
            // btHRFigyelmeztetesek
            // 
            this.btHRFigyelmeztetesek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btHRFigyelmeztetesek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btHRFigyelmeztetesek.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHRFigyelmeztetesek.FlatAppearance.BorderSize = 0;
            this.btHRFigyelmeztetesek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHRFigyelmeztetesek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btHRFigyelmeztetesek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btHRFigyelmeztetesek.Image = global::Felisz.Properties.Resources.ikon_Figyelmeztetés;
            this.btHRFigyelmeztetesek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHRFigyelmeztetesek.Location = new System.Drawing.Point(0, 120);
            this.btHRFigyelmeztetesek.Name = "btHRFigyelmeztetesek";
            this.btHRFigyelmeztetesek.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btHRFigyelmeztetesek.Size = new System.Drawing.Size(273, 40);
            this.btHRFigyelmeztetesek.TabIndex = 6;
            this.btHRFigyelmeztetesek.Text = "  Figyelmeztetés";
            this.btHRFigyelmeztetesek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHRFigyelmeztetesek.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHRFigyelmeztetesek.UseVisualStyleBackColor = false;
            this.btHRFigyelmeztetesek.Visible = false;
            // 
            // btHRMunkaszerzodesModositasa
            // 
            this.btHRMunkaszerzodesModositasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btHRMunkaszerzodesModositasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btHRMunkaszerzodesModositasa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHRMunkaszerzodesModositasa.FlatAppearance.BorderSize = 0;
            this.btHRMunkaszerzodesModositasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHRMunkaszerzodesModositasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btHRMunkaszerzodesModositasa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btHRMunkaszerzodesModositasa.Image = ((System.Drawing.Image)(resources.GetObject("btHRMunkaszerzodesModositasa.Image")));
            this.btHRMunkaszerzodesModositasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHRMunkaszerzodesModositasa.Location = new System.Drawing.Point(0, 80);
            this.btHRMunkaszerzodesModositasa.Name = "btHRMunkaszerzodesModositasa";
            this.btHRMunkaszerzodesModositasa.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btHRMunkaszerzodesModositasa.Size = new System.Drawing.Size(273, 40);
            this.btHRMunkaszerzodesModositasa.TabIndex = 5;
            this.btHRMunkaszerzodesModositasa.Text = "  Munkaszerződés módosítás";
            this.btHRMunkaszerzodesModositasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHRMunkaszerzodesModositasa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHRMunkaszerzodesModositasa.UseVisualStyleBackColor = false;
            this.btHRMunkaszerzodesModositasa.Visible = false;
            this.btHRMunkaszerzodesModositasa.Click += new System.EventHandler(this.btHRMunkaszerzodesModositasa_Click);
            // 
            // btHRFelmondas
            // 
            this.btHRFelmondas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btHRFelmondas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btHRFelmondas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHRFelmondas.FlatAppearance.BorderSize = 0;
            this.btHRFelmondas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHRFelmondas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btHRFelmondas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btHRFelmondas.Image = global::Felisz.Properties.Resources.ikon_Felmondás;
            this.btHRFelmondas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHRFelmondas.Location = new System.Drawing.Point(0, 40);
            this.btHRFelmondas.Name = "btHRFelmondas";
            this.btHRFelmondas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btHRFelmondas.Size = new System.Drawing.Size(273, 40);
            this.btHRFelmondas.TabIndex = 4;
            this.btHRFelmondas.Text = "  Felmondás";
            this.btHRFelmondas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHRFelmondas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHRFelmondas.UseVisualStyleBackColor = false;
            this.btHRFelmondas.Visible = false;
            this.btHRFelmondas.Click += new System.EventHandler(this.btHRMunkakörök_Click_1);
            // 
            // btHRMunkaszerzodes
            // 
            this.btHRMunkaszerzodes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btHRMunkaszerzodes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btHRMunkaszerzodes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHRMunkaszerzodes.FlatAppearance.BorderSize = 0;
            this.btHRMunkaszerzodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHRMunkaszerzodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btHRMunkaszerzodes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btHRMunkaszerzodes.Image = global::Felisz.Properties.Resources.ikon_Munkaszerződés;
            this.btHRMunkaszerzodes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHRMunkaszerzodes.Location = new System.Drawing.Point(0, 0);
            this.btHRMunkaszerzodes.Name = "btHRMunkaszerzodes";
            this.btHRMunkaszerzodes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btHRMunkaszerzodes.Size = new System.Drawing.Size(273, 40);
            this.btHRMunkaszerzodes.TabIndex = 3;
            this.btHRMunkaszerzodes.Text = " Munkaszerződés";
            this.btHRMunkaszerzodes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHRMunkaszerzodes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHRMunkaszerzodes.UseVisualStyleBackColor = false;
            this.btHRMunkaszerzodes.Visible = false;
            this.btHRMunkaszerzodes.Click += new System.EventHandler(this.btHRMunkaszerződés_Click);
            // 
            // btAdminFelhasznalok
            // 
            this.btAdminFelhasznalok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btAdminFelhasznalok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAdminFelhasznalok.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAdminFelhasznalok.FlatAppearance.BorderSize = 0;
            this.btAdminFelhasznalok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdminFelhasznalok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btAdminFelhasznalok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btAdminFelhasznalok.Image = global::Felisz.Properties.Resources.ikon_Felhasználók;
            this.btAdminFelhasznalok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdminFelhasznalok.Location = new System.Drawing.Point(0, 80);
            this.btAdminFelhasznalok.Name = "btAdminFelhasznalok";
            this.btAdminFelhasznalok.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btAdminFelhasznalok.Size = new System.Drawing.Size(273, 40);
            this.btAdminFelhasznalok.TabIndex = 0;
            this.btAdminFelhasznalok.Text = " Felhasználók";
            this.btAdminFelhasznalok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdminFelhasznalok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAdminFelhasznalok.UseVisualStyleBackColor = false;
            this.btAdminFelhasznalok.Visible = false;
            this.btAdminFelhasznalok.Click += new System.EventHandler(this.menüGombok1_Click_1);
            // 
            // btAdminGlobalAdminBeallitasok
            // 
            this.btAdminGlobalAdminBeallitasok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btAdminGlobalAdminBeallitasok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAdminGlobalAdminBeallitasok.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAdminGlobalAdminBeallitasok.FlatAppearance.BorderSize = 0;
            this.btAdminGlobalAdminBeallitasok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdminGlobalAdminBeallitasok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btAdminGlobalAdminBeallitasok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btAdminGlobalAdminBeallitasok.Image = global::Felisz.Properties.Resources.ikon_GlobalAdmin_beállítások;
            this.btAdminGlobalAdminBeallitasok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdminGlobalAdminBeallitasok.Location = new System.Drawing.Point(0, 40);
            this.btAdminGlobalAdminBeallitasok.Name = "btAdminGlobalAdminBeallitasok";
            this.btAdminGlobalAdminBeallitasok.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btAdminGlobalAdminBeallitasok.Size = new System.Drawing.Size(273, 40);
            this.btAdminGlobalAdminBeallitasok.TabIndex = 1;
            this.btAdminGlobalAdminBeallitasok.Text = " GlobalAdmin beállítások";
            this.btAdminGlobalAdminBeallitasok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdminGlobalAdminBeallitasok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAdminGlobalAdminBeallitasok.UseVisualStyleBackColor = false;
            this.btAdminGlobalAdminBeallitasok.Visible = false;
            this.btAdminGlobalAdminBeallitasok.Click += new System.EventHandler(this.btGlobalAdminbeállítások_Click);
            // 
            // btAdminAlapBeallitasok
            // 
            this.btAdminAlapBeallitasok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btAdminAlapBeallitasok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAdminAlapBeallitasok.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAdminAlapBeallitasok.FlatAppearance.BorderSize = 0;
            this.btAdminAlapBeallitasok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdminAlapBeallitasok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btAdminAlapBeallitasok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btAdminAlapBeallitasok.Image = global::Felisz.Properties.Resources.ikon_GlobalAdmin_beállítások;
            this.btAdminAlapBeallitasok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdminAlapBeallitasok.Location = new System.Drawing.Point(0, 0);
            this.btAdminAlapBeallitasok.Name = "btAdminAlapBeallitasok";
            this.btAdminAlapBeallitasok.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btAdminAlapBeallitasok.Size = new System.Drawing.Size(273, 40);
            this.btAdminAlapBeallitasok.TabIndex = 2;
            this.btAdminAlapBeallitasok.Text = " Alapbeállítások";
            this.btAdminAlapBeallitasok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdminAlapBeallitasok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAdminAlapBeallitasok.UseVisualStyleBackColor = false;
            this.btAdminAlapBeallitasok.Visible = false;
            this.btAdminAlapBeallitasok.Click += new System.EventHandler(this.btAdminAlapBeallitasok_Click);
            // 
            // formFelisz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1753, 1024);
            this.Controls.Add(this.panelHáttér);
            this.Controls.Add(this.panelTopMenu);
            this.Controls.Add(this.panelSideMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formFelisz";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ADA HRline";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formFelisz_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelExportImportSubMenu.ResumeLayout(false);
            this.panelHRSubMenu.ResumeLayout(false);
            this.panelAdminSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ADALogo)).EndInit();
            this.panelTopMenu.ResumeLayout(false);
            this.panelTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVonalFüggőleges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).EndInit();
            this.panelHáttér.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btAdmin;
        private System.Windows.Forms.Panel panelHRSubMenu;
        private System.Windows.Forms.Button btHR;
        private System.Windows.Forms.Panel panelAdminSubMenu;
        private System.Windows.Forms.Panel panelExportImportSubMenu;
        private System.Windows.Forms.Button btExportImportAdatokKezelese;
        private System.Windows.Forms.Button btExportImport;
        private System.Windows.Forms.Panel panelTopMenu;
        private System.Windows.Forms.Panel panelHáttér;
        private System.Windows.Forms.PictureBox pbFormClose;
        private System.Windows.Forms.PictureBox pbFormMinimize;
        private System.Windows.Forms.PictureBox pbFormMaximize;
        private MenüGombokNew btHRMunkaszerzodes;
        private MenüGombokNew btHRFelmondas;
        private MenüGombokNew btHRKalkulator;
        private MenüGombokNew btHRUtikoltseg;
        private MenüGombokNew btHRStatisztikak;
        private MenüGombokNew btHRJelentkezok;
        private MenüGombokNew btHRFigyelmeztetesek;
        private MenüGombokNew btHRMunkaszerzodesModositasa;
        private System.Windows.Forms.PictureBox ADALogo;
        private System.Windows.Forms.Label lbFelhasználó;
        private System.Windows.Forms.Timer timerHáttér;
        private System.Windows.Forms.PictureBox pictureScore;
        private System.Windows.Forms.Timer timerRSS;
        private System.Windows.Forms.LinkLabel llbRSS;
        private MenüGombokNew btAdminGlobalAdminBeallitasok;
        private MenüGombokNew btHRMT;
        private System.Windows.Forms.PictureBox pbVonal;
        private System.Windows.Forms.PictureBox pbVonalFüggőleges;
        private System.Windows.Forms.Label label1;
        private MenüGombokNew btAdminAlapBeallitasok;
        private System.Windows.Forms.Button btKijelentkezés;
        private System.Windows.Forms.Button btJelszóVált;
        private MenüGombokNew btAdminFelhasznalok;
        private System.Windows.Forms.Label lbStátusz;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private FolyamatJelző folyamatJelző1;
    }
}

