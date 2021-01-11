namespace Karma_Form
{
    partial class MainForm
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.sistemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasarımAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işyeriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cariİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satınAlmaYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finansYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bildirimYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusBar = new System.Windows.Forms.StatusStrip();
            this.MainTabControl = new KarmaObjects.KarmaTab(this.components);
            this.DesktopTab = new DevExpress.XtraTab.XtraTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnToolCari = new KarmaObjects.KarmaButton(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.MnuRadial = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTabControl)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.DesktopTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MnuRadial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemToolStripMenuItem,
            this.işlemlerToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1174, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // sistemToolStripMenuItem
            // 
            this.sistemToolStripMenuItem.AutoSize = false;
            this.sistemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcılarToolStripMenuItem,
            this.sistemAyarlarıToolStripMenuItem,
            this.tasarımAyarlarıToolStripMenuItem,
            this.işyeriYönetimiToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.sistemToolStripMenuItem.Name = "sistemToolStripMenuItem";
            this.sistemToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.sistemToolStripMenuItem.Text = "Sistem";
            this.sistemToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kullanıcılarToolStripMenuItem
            // 
            this.kullanıcılarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.kullanıcılarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.kullanıcılarToolStripMenuItem.Name = "kullanıcılarToolStripMenuItem";
            this.kullanıcılarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kullanıcılarToolStripMenuItem.Text = "Kullanıcılar";
            // 
            // sistemAyarlarıToolStripMenuItem
            // 
            this.sistemAyarlarıToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.sistemAyarlarıToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sistemAyarlarıToolStripMenuItem.Name = "sistemAyarlarıToolStripMenuItem";
            this.sistemAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sistemAyarlarıToolStripMenuItem.Text = "Sistem Ayarları";
            // 
            // tasarımAyarlarıToolStripMenuItem
            // 
            this.tasarımAyarlarıToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tasarımAyarlarıToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tasarımAyarlarıToolStripMenuItem.Name = "tasarımAyarlarıToolStripMenuItem";
            this.tasarımAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tasarımAyarlarıToolStripMenuItem.Text = "Tasarım Ayarları";
            // 
            // işyeriYönetimiToolStripMenuItem
            // 
            this.işyeriYönetimiToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.işyeriYönetimiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.işyeriYönetimiToolStripMenuItem.Name = "işyeriYönetimiToolStripMenuItem";
            this.işyeriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.işyeriYönetimiToolStripMenuItem.Text = "İşyeri Yönetimi";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.çıkışToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.AutoSize = false;
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cariİşlemleriToolStripMenuItem,
            this.stokİşlemleriToolStripMenuItem,
            this.satışYönetimiToolStripMenuItem,
            this.satınAlmaYönetimiToolStripMenuItem,
            this.finansYönetimiToolStripMenuItem,
            this.bildirimYönetimiToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            this.işlemlerToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cariİşlemleriToolStripMenuItem
            // 
            this.cariİşlemleriToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cariİşlemleriToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cariİşlemleriToolStripMenuItem.Name = "cariİşlemleriToolStripMenuItem";
            this.cariİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cariİşlemleriToolStripMenuItem.Text = "Cari Yönetimi";
            // 
            // stokİşlemleriToolStripMenuItem
            // 
            this.stokİşlemleriToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.stokİşlemleriToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.stokİşlemleriToolStripMenuItem.Name = "stokİşlemleriToolStripMenuItem";
            this.stokİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.stokİşlemleriToolStripMenuItem.Text = "Stok Yönetimi";
            // 
            // satışYönetimiToolStripMenuItem
            // 
            this.satışYönetimiToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.satışYönetimiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.satışYönetimiToolStripMenuItem.Name = "satışYönetimiToolStripMenuItem";
            this.satışYönetimiToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.satışYönetimiToolStripMenuItem.Text = "Satış Yönetimi";
            // 
            // satınAlmaYönetimiToolStripMenuItem
            // 
            this.satınAlmaYönetimiToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.satınAlmaYönetimiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.satınAlmaYönetimiToolStripMenuItem.Name = "satınAlmaYönetimiToolStripMenuItem";
            this.satınAlmaYönetimiToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.satınAlmaYönetimiToolStripMenuItem.Text = "Satın Alma Yönetimi";
            // 
            // finansYönetimiToolStripMenuItem
            // 
            this.finansYönetimiToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.finansYönetimiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.finansYönetimiToolStripMenuItem.Name = "finansYönetimiToolStripMenuItem";
            this.finansYönetimiToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.finansYönetimiToolStripMenuItem.Text = "Finans Yönetimi";
            // 
            // bildirimYönetimiToolStripMenuItem
            // 
            this.bildirimYönetimiToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.bildirimYönetimiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bildirimYönetimiToolStripMenuItem.Name = "bildirimYönetimiToolStripMenuItem";
            this.bildirimYönetimiToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.bildirimYönetimiToolStripMenuItem.Text = "Bildirim Yönetimi";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.AutoSize = false;
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            this.raporlarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.AutoSize = false;
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            this.yardımToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainStatusBar
            // 
            this.MainStatusBar.Location = new System.Drawing.Point(0, 613);
            this.MainStatusBar.Name = "MainStatusBar";
            this.MainStatusBar.Size = new System.Drawing.Size(1174, 22);
            this.MainStatusBar.TabIndex = 1;
            this.MainStatusBar.Text = "statusStrip1";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainTabControl.Appearance.Options.UseBackColor = true;
            this.MainTabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 24);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedTabPage = this.DesktopTab;
            this.MainTabControl.Size = new System.Drawing.Size(1174, 589);
            this.MainTabControl.TabIndex = 2;
            this.MainTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.DesktopTab});
            // 
            // DesktopTab
            // 
            this.DesktopTab.Controls.Add(this.panel1);
            this.DesktopTab.Name = "DesktopTab";
            this.DesktopTab.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.DesktopTab.Size = new System.Drawing.Size(1172, 566);
            this.DesktopTab.Text = "Masaüstü";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnToolCari);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 566);
            this.panel1.TabIndex = 0;
            // 
            // BtnToolCari
            // 
            this.BtnToolCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToolCari.Image = global::Karma_Form.Properties.Resources.user_silhouette;
            this.BtnToolCari.Location = new System.Drawing.Point(15, 15);
            this.BtnToolCari.Name = "BtnToolCari";
            this.BtnToolCari.Size = new System.Drawing.Size(50, 50);
            this.BtnToolCari.TabIndex = 1;
            this.BtnToolCari.TasinabilirMi = true;
            this.BtnToolCari.UseVisualStyleBackColor = true;
            this.BtnToolCari.Click += new System.EventHandler(this.BtnToolCari_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1120, 566);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // MnuRadial
            // 
            this.MnuRadial.AutoExpand = true;
            this.MnuRadial.BorderColor = System.Drawing.Color.Orange;
            this.MnuRadial.ButtonRadius = 10;
            this.MnuRadial.InnerRadius = 20;
            this.MnuRadial.ItemAutoSize = DevExpress.XtraBars.Ribbon.RadialMenuItemAutoSize.Spring;
            this.MnuRadial.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5)});
            this.MnuRadial.Manager = this.barManager1;
            this.MnuRadial.Name = "MnuRadial";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Cari Kartları";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.barButtonItem2.Caption = "Cari Hareketleri";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Cari Borçlandırma";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Cari Alacaklandırma";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5});
            this.barManager1.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1174, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 635);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1174, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 635);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1174, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 635);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Cari Bakiye İşlemleri";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 635);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.MainStatusBar);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Karma";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTabControl)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.DesktopTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MnuRadial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.StatusStrip MainStatusBar;
        private System.Windows.Forms.ToolStripMenuItem sistemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private KarmaObjects.KarmaTab MainTabControl;
        private DevExpress.XtraTab.XtraTabPage DesktopTab;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.ToolStripMenuItem kullanıcılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasarımAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cariİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satınAlmaYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finansYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bildirimYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işyeriYönetimiToolStripMenuItem;
        private System.Windows.Forms.Timer MainTimer;
        private DevExpress.XtraBars.Ribbon.RadialMenu MnuRadial;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private System.Windows.Forms.Panel panel1;
        private KarmaObjects.KarmaButton BtnToolCari;
    }
}

