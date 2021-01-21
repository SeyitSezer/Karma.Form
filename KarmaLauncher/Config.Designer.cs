namespace KarmaLauncher
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.GrdVTBilgi = new DevExpress.XtraEditors.GroupControl();
            this.BtnCheckDBConnect = new KarmaObjects.KarmaButton(this.components);
            this.karmaLabel5 = new KarmaObjects.KarmaLabel();
            this.karmaLabel6 = new KarmaObjects.KarmaLabel();
            this.karmaLabel7 = new KarmaObjects.KarmaLabel();
            this.VTDatabase = new KarmaObjects.KarmaTextBox(this.components);
            this.VTPassword = new KarmaObjects.KarmaTextBox(this.components);
            this.VTUserName = new KarmaObjects.KarmaTextBox(this.components);
            this.VTServer = new KarmaObjects.KarmaTextBox(this.components);
            this.karmaLabel8 = new KarmaObjects.KarmaLabel();
            this.GrdOndalik = new DevExpress.XtraEditors.GroupControl();
            this.karmaLabel1 = new KarmaObjects.KarmaLabel();
            this.karmaLabel2 = new KarmaObjects.KarmaLabel();
            this.karmaLabel3 = new KarmaObjects.KarmaLabel();
            this.DGTutar = new KarmaObjects.KarmaTextBox(this.components);
            this.DGFiyat = new KarmaObjects.KarmaTextBox(this.components);
            this.DGMiktar = new KarmaObjects.KarmaTextBox(this.components);
            this.DGGenel = new KarmaObjects.KarmaTextBox(this.components);
            this.karmaLabel4 = new KarmaObjects.KarmaLabel();
            this.GrpLicense = new DevExpress.XtraEditors.GroupControl();
            this.BtnLisansla = new KarmaObjects.KarmaButton(this.components);
            this.LicenseNumber = new KarmaObjects.KarmaTextBox(this.components);
            this.karmaLabel12 = new KarmaObjects.KarmaLabel();
            this.karmaPanel1 = new KarmaObjects.KarmaPanel(this.components);
            this.BtnKaydet = new KarmaObjects.KarmaButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrdVTBilgi)).BeginInit();
            this.GrdVTBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdOndalik)).BeginInit();
            this.GrdOndalik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrpLicense)).BeginInit();
            this.GrpLicense.SuspendLayout();
            this.karmaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrdVTBilgi
            // 
            this.GrdVTBilgi.AllowTouchScroll = true;
            this.GrdVTBilgi.Controls.Add(this.BtnCheckDBConnect);
            this.GrdVTBilgi.Controls.Add(this.karmaLabel5);
            this.GrdVTBilgi.Controls.Add(this.karmaLabel6);
            this.GrdVTBilgi.Controls.Add(this.karmaLabel7);
            this.GrdVTBilgi.Controls.Add(this.VTDatabase);
            this.GrdVTBilgi.Controls.Add(this.VTPassword);
            this.GrdVTBilgi.Controls.Add(this.VTUserName);
            this.GrdVTBilgi.Controls.Add(this.VTServer);
            this.GrdVTBilgi.Controls.Add(this.karmaLabel8);
            this.GrdVTBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrdVTBilgi.FireScrollEventOnMouseWheel = true;
            this.GrdVTBilgi.Location = new System.Drawing.Point(0, 0);
            this.GrdVTBilgi.Name = "GrdVTBilgi";
            this.GrdVTBilgi.Size = new System.Drawing.Size(375, 172);
            this.GrdVTBilgi.TabIndex = 1;
            this.GrdVTBilgi.Text = "Veritabanı Bağlantı Ayarları";
            // 
            // BtnCheckDBConnect
            // 
            this.BtnCheckDBConnect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCheckDBConnect.ImageOptions.Image")));
            this.BtnCheckDBConnect.Location = new System.Drawing.Point(243, 142);
            this.BtnCheckDBConnect.Name = "BtnCheckDBConnect";
            this.BtnCheckDBConnect.Size = new System.Drawing.Size(120, 24);
            this.BtnCheckDBConnect.TabIndex = 18;
            this.BtnCheckDBConnect.TasinabilirMi = false;
            this.BtnCheckDBConnect.Text = "Bağlantıyı Sına";
            this.BtnCheckDBConnect.Click += new System.EventHandler(this.BtnCheckDBConnect_Click);
            // 
            // karmaLabel5
            // 
            this.karmaLabel5.AutoSize = true;
            this.karmaLabel5.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel5.KarmaFocusControl = null;
            this.karmaLabel5.Location = new System.Drawing.Point(12, 117);
            this.karmaLabel5.Name = "karmaLabel5";
            this.karmaLabel5.ReadOnly = false;
            this.karmaLabel5.Size = new System.Drawing.Size(63, 14);
            this.karmaLabel5.TabIndex = 17;
            this.karmaLabel5.Text = "Veritabanı";
            // 
            // karmaLabel6
            // 
            this.karmaLabel6.AutoSize = true;
            this.karmaLabel6.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel6.KarmaFocusControl = null;
            this.karmaLabel6.Location = new System.Drawing.Point(12, 91);
            this.karmaLabel6.Name = "karmaLabel6";
            this.karmaLabel6.ReadOnly = false;
            this.karmaLabel6.Size = new System.Drawing.Size(31, 14);
            this.karmaLabel6.TabIndex = 16;
            this.karmaLabel6.Text = "Şifre";
            // 
            // karmaLabel7
            // 
            this.karmaLabel7.AutoSize = true;
            this.karmaLabel7.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel7.KarmaFocusControl = null;
            this.karmaLabel7.Location = new System.Drawing.Point(12, 65);
            this.karmaLabel7.Name = "karmaLabel7";
            this.karmaLabel7.ReadOnly = false;
            this.karmaLabel7.Size = new System.Drawing.Size(75, 14);
            this.karmaLabel7.TabIndex = 15;
            this.karmaLabel7.Text = "Kullanıcı Adı";
            // 
            // VTDatabase
            // 
            this.VTDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.VTDatabase.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.VTDatabase.KarmaFieldType = KarmaObjects.KarmaFieldTypes.String;
            this.VTDatabase.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.Miktar;
            this.VTDatabase.KarmaPasswordTextBox = false;
            this.VTDatabase.Location = new System.Drawing.Point(159, 115);
            this.VTDatabase.Name = "VTDatabase";
            this.VTDatabase.ReadOnly = false;
            this.VTDatabase.Size = new System.Drawing.Size(204, 20);
            this.VTDatabase.TabIndex = 14;
            // 
            // VTPassword
            // 
            this.VTPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.VTPassword.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.VTPassword.KarmaFieldType = KarmaObjects.KarmaFieldTypes.String;
            this.VTPassword.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.Miktar;
            this.VTPassword.KarmaPasswordTextBox = true;
            this.VTPassword.Location = new System.Drawing.Point(159, 89);
            this.VTPassword.Name = "VTPassword";
            this.VTPassword.ReadOnly = false;
            this.VTPassword.Size = new System.Drawing.Size(204, 20);
            this.VTPassword.TabIndex = 13;
            // 
            // VTUserName
            // 
            this.VTUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.VTUserName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.VTUserName.KarmaFieldType = KarmaObjects.KarmaFieldTypes.String;
            this.VTUserName.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.Miktar;
            this.VTUserName.KarmaPasswordTextBox = false;
            this.VTUserName.Location = new System.Drawing.Point(159, 63);
            this.VTUserName.Name = "VTUserName";
            this.VTUserName.ReadOnly = false;
            this.VTUserName.Size = new System.Drawing.Size(204, 20);
            this.VTUserName.TabIndex = 12;
            // 
            // VTServer
            // 
            this.VTServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.VTServer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.VTServer.KarmaFieldType = KarmaObjects.KarmaFieldTypes.String;
            this.VTServer.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.Miktar;
            this.VTServer.KarmaPasswordTextBox = false;
            this.VTServer.Location = new System.Drawing.Point(159, 37);
            this.VTServer.Name = "VTServer";
            this.VTServer.ReadOnly = false;
            this.VTServer.Size = new System.Drawing.Size(204, 20);
            this.VTServer.TabIndex = 11;
            // 
            // karmaLabel8
            // 
            this.karmaLabel8.AutoSize = true;
            this.karmaLabel8.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel8.KarmaFocusControl = null;
            this.karmaLabel8.Location = new System.Drawing.Point(12, 39);
            this.karmaLabel8.Name = "karmaLabel8";
            this.karmaLabel8.ReadOnly = false;
            this.karmaLabel8.Size = new System.Drawing.Size(40, 14);
            this.karmaLabel8.TabIndex = 10;
            this.karmaLabel8.Text = "Server";
            // 
            // GrdOndalik
            // 
            this.GrdOndalik.AllowTouchScroll = true;
            this.GrdOndalik.Controls.Add(this.karmaLabel1);
            this.GrdOndalik.Controls.Add(this.karmaLabel2);
            this.GrdOndalik.Controls.Add(this.karmaLabel3);
            this.GrdOndalik.Controls.Add(this.DGTutar);
            this.GrdOndalik.Controls.Add(this.DGFiyat);
            this.GrdOndalik.Controls.Add(this.DGMiktar);
            this.GrdOndalik.Controls.Add(this.DGGenel);
            this.GrdOndalik.Controls.Add(this.karmaLabel4);
            this.GrdOndalik.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrdOndalik.FireScrollEventOnMouseWheel = true;
            this.GrdOndalik.Location = new System.Drawing.Point(0, 172);
            this.GrdOndalik.Name = "GrdOndalik";
            this.GrdOndalik.Size = new System.Drawing.Size(375, 152);
            this.GrdOndalik.TabIndex = 2;
            this.GrdOndalik.Text = "Ondalık Ayarları";
            // 
            // karmaLabel1
            // 
            this.karmaLabel1.AutoSize = true;
            this.karmaLabel1.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel1.KarmaFocusControl = null;
            this.karmaLabel1.Location = new System.Drawing.Point(12, 117);
            this.karmaLabel1.Name = "karmaLabel1";
            this.karmaLabel1.ReadOnly = false;
            this.karmaLabel1.Size = new System.Drawing.Size(36, 14);
            this.karmaLabel1.TabIndex = 17;
            this.karmaLabel1.Text = "Tutar";
            // 
            // karmaLabel2
            // 
            this.karmaLabel2.AutoSize = true;
            this.karmaLabel2.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel2.KarmaFocusControl = null;
            this.karmaLabel2.Location = new System.Drawing.Point(12, 91);
            this.karmaLabel2.Name = "karmaLabel2";
            this.karmaLabel2.ReadOnly = false;
            this.karmaLabel2.Size = new System.Drawing.Size(34, 14);
            this.karmaLabel2.TabIndex = 16;
            this.karmaLabel2.Text = "Fiyat";
            // 
            // karmaLabel3
            // 
            this.karmaLabel3.AutoSize = true;
            this.karmaLabel3.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel3.KarmaFocusControl = null;
            this.karmaLabel3.Location = new System.Drawing.Point(12, 65);
            this.karmaLabel3.Name = "karmaLabel3";
            this.karmaLabel3.ReadOnly = false;
            this.karmaLabel3.Size = new System.Drawing.Size(41, 14);
            this.karmaLabel3.TabIndex = 15;
            this.karmaLabel3.Text = "Miktar";
            // 
            // DGTutar
            // 
            this.DGTutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DGTutar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.DGTutar.KarmaFieldType = KarmaObjects.KarmaFieldTypes.Numeric;
            this.DGTutar.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.TamSayi;
            this.DGTutar.KarmaPasswordTextBox = false;
            this.DGTutar.Location = new System.Drawing.Point(159, 115);
            this.DGTutar.Name = "DGTutar";
            this.DGTutar.ReadOnly = false;
            this.DGTutar.Size = new System.Drawing.Size(204, 20);
            this.DGTutar.TabIndex = 14;
            this.DGTutar.Text = "3";
            // 
            // DGFiyat
            // 
            this.DGFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DGFiyat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.DGFiyat.KarmaFieldType = KarmaObjects.KarmaFieldTypes.Numeric;
            this.DGFiyat.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.TamSayi;
            this.DGFiyat.KarmaPasswordTextBox = false;
            this.DGFiyat.Location = new System.Drawing.Point(159, 89);
            this.DGFiyat.Name = "DGFiyat";
            this.DGFiyat.ReadOnly = false;
            this.DGFiyat.Size = new System.Drawing.Size(204, 20);
            this.DGFiyat.TabIndex = 13;
            this.DGFiyat.Text = "2";
            // 
            // DGMiktar
            // 
            this.DGMiktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DGMiktar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.DGMiktar.KarmaFieldType = KarmaObjects.KarmaFieldTypes.Numeric;
            this.DGMiktar.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.TamSayi;
            this.DGMiktar.KarmaPasswordTextBox = false;
            this.DGMiktar.Location = new System.Drawing.Point(159, 63);
            this.DGMiktar.Name = "DGMiktar";
            this.DGMiktar.ReadOnly = false;
            this.DGMiktar.Size = new System.Drawing.Size(204, 20);
            this.DGMiktar.TabIndex = 12;
            this.DGMiktar.Text = "2";
            // 
            // DGGenel
            // 
            this.DGGenel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DGGenel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.DGGenel.KarmaFieldType = KarmaObjects.KarmaFieldTypes.Numeric;
            this.DGGenel.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.TamSayi;
            this.DGGenel.KarmaPasswordTextBox = false;
            this.DGGenel.Location = new System.Drawing.Point(159, 37);
            this.DGGenel.Name = "DGGenel";
            this.DGGenel.ReadOnly = false;
            this.DGGenel.Size = new System.Drawing.Size(204, 20);
            this.DGGenel.TabIndex = 11;
            this.DGGenel.Text = "2";
            // 
            // karmaLabel4
            // 
            this.karmaLabel4.AutoSize = true;
            this.karmaLabel4.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel4.KarmaFocusControl = null;
            this.karmaLabel4.Location = new System.Drawing.Point(12, 39);
            this.karmaLabel4.Name = "karmaLabel4";
            this.karmaLabel4.ReadOnly = false;
            this.karmaLabel4.Size = new System.Drawing.Size(37, 14);
            this.karmaLabel4.TabIndex = 10;
            this.karmaLabel4.Text = "Genel";
            // 
            // GrpLicense
            // 
            this.GrpLicense.AllowTouchScroll = true;
            this.GrpLicense.Controls.Add(this.BtnLisansla);
            this.GrpLicense.Controls.Add(this.LicenseNumber);
            this.GrpLicense.Controls.Add(this.karmaLabel12);
            this.GrpLicense.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrpLicense.FireScrollEventOnMouseWheel = true;
            this.GrpLicense.Location = new System.Drawing.Point(0, 324);
            this.GrpLicense.Name = "GrpLicense";
            this.GrpLicense.Size = new System.Drawing.Size(375, 104);
            this.GrpLicense.TabIndex = 3;
            this.GrpLicense.Text = "Lisans İşlemleri";
            // 
            // BtnLisansla
            // 
            this.BtnLisansla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLisansla.ImageOptions.Image")));
            this.BtnLisansla.Location = new System.Drawing.Point(243, 65);
            this.BtnLisansla.Name = "BtnLisansla";
            this.BtnLisansla.Size = new System.Drawing.Size(120, 24);
            this.BtnLisansla.TabIndex = 18;
            this.BtnLisansla.TasinabilirMi = false;
            this.BtnLisansla.Text = "Lisansla";
            // 
            // LicenseNumber
            // 
            this.LicenseNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LicenseNumber.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.LicenseNumber.KarmaFieldType = KarmaObjects.KarmaFieldTypes.String;
            this.LicenseNumber.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.Miktar;
            this.LicenseNumber.KarmaPasswordTextBox = false;
            this.LicenseNumber.Location = new System.Drawing.Point(159, 37);
            this.LicenseNumber.Name = "LicenseNumber";
            this.LicenseNumber.ReadOnly = false;
            this.LicenseNumber.Size = new System.Drawing.Size(204, 20);
            this.LicenseNumber.TabIndex = 11;
            // 
            // karmaLabel12
            // 
            this.karmaLabel12.AutoSize = true;
            this.karmaLabel12.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel12.KarmaFocusControl = null;
            this.karmaLabel12.Location = new System.Drawing.Point(12, 39);
            this.karmaLabel12.Name = "karmaLabel12";
            this.karmaLabel12.ReadOnly = false;
            this.karmaLabel12.Size = new System.Drawing.Size(98, 14);
            this.karmaLabel12.TabIndex = 10;
            this.karmaLabel12.Text = "Lisans Numarası";
            // 
            // karmaPanel1
            // 
            this.karmaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.karmaPanel1.Controls.Add(this.BtnKaydet);
            this.karmaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.karmaPanel1.KarmaColumnNames = null;
            this.karmaPanel1.KarmaMasterButton = null;
            this.karmaPanel1.KarmaMasterTextBox = null;
            this.karmaPanel1.KarmaTableName = null;
            this.karmaPanel1.Location = new System.Drawing.Point(0, 428);
            this.karmaPanel1.Name = "karmaPanel1";
            this.karmaPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.karmaPanel1.Size = new System.Drawing.Size(375, 45);
            this.karmaPanel1.TabIndex = 4;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(186, 3);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(184, 37);
            this.BtnKaydet.TabIndex = 22;
            this.BtnKaydet.TasinabilirMi = false;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // Config
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 473);
            this.Controls.Add(this.karmaPanel1);
            this.Controls.Add(this.GrpLicense);
            this.Controls.Add(this.GrdOndalik);
            this.Controls.Add(this.GrdVTBilgi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Yapılandırma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Config_FormClosing);
            this.Shown += new System.EventHandler(this.Config_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.GrdVTBilgi)).EndInit();
            this.GrdVTBilgi.ResumeLayout(false);
            this.GrdVTBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdOndalik)).EndInit();
            this.GrdOndalik.ResumeLayout(false);
            this.GrdOndalik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrpLicense)).EndInit();
            this.GrpLicense.ResumeLayout(false);
            this.GrpLicense.PerformLayout();
            this.karmaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GrdVTBilgi;
        private KarmaObjects.KarmaButton BtnCheckDBConnect;
        private KarmaObjects.KarmaLabel karmaLabel5;
        private KarmaObjects.KarmaLabel karmaLabel6;
        private KarmaObjects.KarmaLabel karmaLabel7;
        private KarmaObjects.KarmaTextBox VTDatabase;
        private KarmaObjects.KarmaTextBox VTPassword;
        private KarmaObjects.KarmaTextBox VTUserName;
        private KarmaObjects.KarmaTextBox VTServer;
        private KarmaObjects.KarmaLabel karmaLabel8;
        private DevExpress.XtraEditors.GroupControl GrdOndalik;
        private KarmaObjects.KarmaLabel karmaLabel1;
        private KarmaObjects.KarmaLabel karmaLabel2;
        private KarmaObjects.KarmaLabel karmaLabel3;
        private KarmaObjects.KarmaTextBox DGTutar;
        private KarmaObjects.KarmaTextBox DGFiyat;
        private KarmaObjects.KarmaTextBox DGMiktar;
        private KarmaObjects.KarmaTextBox DGGenel;
        private KarmaObjects.KarmaLabel karmaLabel4;
        private DevExpress.XtraEditors.GroupControl GrpLicense;
        private KarmaObjects.KarmaButton BtnLisansla;
        private KarmaObjects.KarmaTextBox LicenseNumber;
        private KarmaObjects.KarmaLabel karmaLabel12;
        private KarmaObjects.KarmaPanel karmaPanel1;
        private KarmaObjects.KarmaButton BtnKaydet;
    }
}