﻿namespace KarmaLauncher
{
    partial class Launcher
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.karmaPanel1 = new KarmaObjects.KarmaPanel(this.components);
            this.Yil = new KarmaObjects.KarmaComboBox();
            this.Sirket = new KarmaObjects.KarmaComboBox();
            this.Password = new KarmaObjects.KarmaTextBox(this.components);
            this.UserName = new KarmaObjects.KarmaTextBox(this.components);
            this.BtnGiris = new KarmaObjects.KarmaButton(this.components);
            this.karmaLabel4 = new KarmaObjects.KarmaLabel();
            this.karmaLabel3 = new KarmaObjects.KarmaLabel();
            this.karmaLabel2 = new KarmaObjects.KarmaLabel();
            this.karmaLabel1 = new KarmaObjects.KarmaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karmaPanel1)).BeginInit();
            this.karmaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Yil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sirket.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::KarmaLauncher.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // karmaPanel1
            // 
            this.karmaPanel1.Controls.Add(this.Yil);
            this.karmaPanel1.Controls.Add(this.Sirket);
            this.karmaPanel1.Controls.Add(this.Password);
            this.karmaPanel1.Controls.Add(this.UserName);
            this.karmaPanel1.Controls.Add(this.BtnGiris);
            this.karmaPanel1.Controls.Add(this.karmaLabel4);
            this.karmaPanel1.Controls.Add(this.karmaLabel3);
            this.karmaPanel1.Controls.Add(this.karmaLabel2);
            this.karmaPanel1.Controls.Add(this.karmaLabel1);
            this.karmaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.karmaPanel1.KarmaChildPanels = null;
            this.karmaPanel1.KarmaColumnNames = null;
            this.karmaPanel1.KarmaGridControl = null;
            this.karmaPanel1.KarmaMasterButton = null;
            this.karmaPanel1.KarmaMasterTextBox = null;
            this.karmaPanel1.KarmaSecTextBox = null;
            this.karmaPanel1.KarmaTableName = null;
            this.karmaPanel1.Location = new System.Drawing.Point(182, 0);
            this.karmaPanel1.Name = "karmaPanel1";
            this.karmaPanel1.ShowCaption = false;
            this.karmaPanel1.Size = new System.Drawing.Size(366, 192);
            this.karmaPanel1.TabIndex = 2;
            // 
            // Yil
            // 
            this.Yil.EnterMoveNextControl = true;
            this.Yil.KarmaFieldName = null;
            this.Yil.KarmaFieldType = KarmaObjects.KarmaFieldTypes.String;
            this.Yil.KarmaLookupDisplayField = "GosterTarih";
            this.Yil.KarmaLookupFilter = null;
            this.Yil.KarmaLookUpTable = "tblCalismaYili";
            this.Yil.KarmaLookupValueField = "CalismaYili";
            this.Yil.KarmaMasterFieldName = "SirketKodu";
            this.Yil.KarmaMasterObject = this.Sirket;
            this.Yil.KarmaValueType = KarmaObjects.KarmaValueTypes.Lookup;
            this.Yil.Location = new System.Drawing.Point(127, 152);
            this.Yil.Name = "Yil";
            this.Yil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Yil.Size = new System.Drawing.Size(227, 20);
            this.Yil.TabIndex = 4;
            // 
            // Sirket
            // 
            this.Sirket.EnterMoveNextControl = true;
            this.Sirket.KarmaFieldName = null;
            this.Sirket.KarmaFieldType = KarmaObjects.KarmaFieldTypes.String;
            this.Sirket.KarmaLookupDisplayField = "Unvan";
            this.Sirket.KarmaLookupFilter = null;
            this.Sirket.KarmaLookUpTable = "tblSirket";
            this.Sirket.KarmaLookupValueField = "SirketKodu";
            this.Sirket.KarmaMasterFieldName = null;
            this.Sirket.KarmaMasterObject = null;
            this.Sirket.KarmaValueType = KarmaObjects.KarmaValueTypes.Lookup;
            this.Sirket.Location = new System.Drawing.Point(127, 125);
            this.Sirket.Name = "Sirket";
            this.Sirket.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Sirket.Size = new System.Drawing.Size(227, 20);
            this.Sirket.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Password.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Password.KarmaFieldName = null;
            this.Password.KarmaFieldType = KarmaObjects.KarmaFieldTypes.String;
            this.Password.KarmaGuideColumnName = null;
            this.Password.KarmaGuideFields = null;
            this.Password.KarmaGuideFilter = null;
            this.Password.KarmaGuideName = null;
            this.Password.KarmaGuideTableName = null;
            this.Password.KarmaIsRequired = false;
            this.Password.KarmaLastEdit = false;
            this.Password.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.TamSayi;
            this.Password.KarmaPasswordTextBox = true;
            this.Password.Location = new System.Drawing.Point(127, 37);
            this.Password.Name = "Password";
            this.Password.ReadOnly = false;
            this.Password.Size = new System.Drawing.Size(227, 24);
            this.Password.TabIndex = 1;
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.UserName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.UserName.KarmaFieldName = null;
            this.UserName.KarmaFieldType = KarmaObjects.KarmaFieldTypes.String;
            this.UserName.KarmaGuideColumnName = null;
            this.UserName.KarmaGuideFields = null;
            this.UserName.KarmaGuideFilter = null;
            this.UserName.KarmaGuideName = null;
            this.UserName.KarmaGuideTableName = null;
            this.UserName.KarmaIsRequired = false;
            this.UserName.KarmaLastEdit = false;
            this.UserName.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.TamSayi;
            this.UserName.KarmaPasswordTextBox = false;
            this.UserName.Location = new System.Drawing.Point(127, 10);
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = false;
            this.UserName.Size = new System.Drawing.Size(227, 24);
            this.UserName.TabIndex = 0;
            // 
            // BtnGiris
            // 
            this.BtnGiris.Appearance.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold);
            this.BtnGiris.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnGiris.Appearance.Options.UseFont = true;
            this.BtnGiris.Appearance.Options.UseForeColor = true;
            this.BtnGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGiris.ImageOptions.Image")));
            this.BtnGiris.KarmaButtonType = KarmaObjects.KarmaButtonTypes.Özel;
            this.BtnGiris.KarmaMasterPanel = null;
            this.BtnGiris.KarmaMasterTextBox = null;
            this.BtnGiris.Location = new System.Drawing.Point(234, 67);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(120, 49);
            this.BtnGiris.TabIndex = 2;
            this.BtnGiris.TasinabilirMi = false;
            this.BtnGiris.Text = "Giriş";
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // karmaLabel4
            // 
            this.karmaLabel4.AutoSize = true;
            this.karmaLabel4.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel4.KarmaFocusControl = null;
            this.karmaLabel4.Location = new System.Drawing.Point(3, 155);
            this.karmaLabel4.Name = "karmaLabel4";
            this.karmaLabel4.ReadOnly = false;
            this.karmaLabel4.Size = new System.Drawing.Size(71, 14);
            this.karmaLabel4.TabIndex = 13;
            this.karmaLabel4.Text = "Çalışma Yılı";
            this.karmaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // karmaLabel3
            // 
            this.karmaLabel3.AutoSize = true;
            this.karmaLabel3.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel3.KarmaFocusControl = null;
            this.karmaLabel3.Location = new System.Drawing.Point(3, 128);
            this.karmaLabel3.Name = "karmaLabel3";
            this.karmaLabel3.ReadOnly = false;
            this.karmaLabel3.Size = new System.Drawing.Size(87, 14);
            this.karmaLabel3.TabIndex = 12;
            this.karmaLabel3.Text = "Çalışılan Şirket";
            this.karmaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // karmaLabel2
            // 
            this.karmaLabel2.AutoSize = true;
            this.karmaLabel2.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel2.KarmaFocusControl = null;
            this.karmaLabel2.Location = new System.Drawing.Point(3, 40);
            this.karmaLabel2.Name = "karmaLabel2";
            this.karmaLabel2.ReadOnly = false;
            this.karmaLabel2.Size = new System.Drawing.Size(31, 14);
            this.karmaLabel2.TabIndex = 11;
            this.karmaLabel2.Text = "Şifre";
            this.karmaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // karmaLabel1
            // 
            this.karmaLabel1.AutoSize = true;
            this.karmaLabel1.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel1.KarmaFocusControl = null;
            this.karmaLabel1.Location = new System.Drawing.Point(3, 13);
            this.karmaLabel1.Name = "karmaLabel1";
            this.karmaLabel1.ReadOnly = false;
            this.karmaLabel1.Size = new System.Drawing.Size(75, 14);
            this.karmaLabel1.TabIndex = 10;
            this.karmaLabel1.Text = "Kullanıcı Adı";
            this.karmaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Launcher
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 192);
            this.Controls.Add(this.karmaPanel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Launcher";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karma.Form - Launcher";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.karmaPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karmaPanel1)).EndInit();
            this.karmaPanel1.ResumeLayout(false);
            this.karmaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Yil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sirket.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private KarmaObjects.KarmaPanel karmaPanel1;
        private KarmaObjects.KarmaComboBox Yil;
        private KarmaObjects.KarmaComboBox Sirket;
        private KarmaObjects.KarmaTextBox Password;
        private KarmaObjects.KarmaTextBox UserName;
        private KarmaObjects.KarmaButton BtnGiris;
        private KarmaObjects.KarmaLabel karmaLabel4;
        private KarmaObjects.KarmaLabel karmaLabel3;
        private KarmaObjects.KarmaLabel karmaLabel2;
        private KarmaObjects.KarmaLabel karmaLabel1;
    }
}

