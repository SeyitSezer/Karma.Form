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
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.DesktopTab = new DevExpress.XtraTab.XtraTabPage();
            this.karmaPanel1 = new KarmaObjects.KarmaPanel(this.components);
            this.MainBarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.StatusBar = new DevExpress.XtraBars.Bar();
            this.MainMenu = new DevExpress.XtraBars.Bar();
            this.MnuSistem = new DevExpress.XtraBars.BarSubItem();
            this.MnuGenelAyar = new DevExpress.XtraBars.BarButtonItem();
            this.MnuBildirimAyar = new DevExpress.XtraBars.BarButtonItem();
            this.MnuKullanici = new DevExpress.XtraBars.BarSubItem();
            this.MnuUserSettings = new DevExpress.XtraBars.BarButtonItem();
            this.MnuCikis = new DevExpress.XtraBars.BarButtonItem();
            this.MnuIslemler = new DevExpress.XtraBars.BarSubItem();
            this.MnuStokYonetimi = new DevExpress.XtraBars.BarSubItem();
            this.MnuStoklar = new DevExpress.XtraBars.BarButtonItem();
            this.MnuStokBakiye = new DevExpress.XtraBars.BarButtonItem();
            this.MnuStokSayim = new DevExpress.XtraBars.BarButtonItem();
            this.MnuOlcuBrTanim = new DevExpress.XtraBars.BarButtonItem();
            this.MnuFiyatTanim = new DevExpress.XtraBars.BarButtonItem();
            this.MnuFiyatYonetimi = new DevExpress.XtraBars.BarButtonItem();
            this.MnuCariYonetim = new DevExpress.XtraBars.BarSubItem();
            this.MnuCariTanim = new DevExpress.XtraBars.BarButtonItem();
            this.MnuCariBakiyeIslem = new DevExpress.XtraBars.BarButtonItem();
            this.MnuCariVirman = new DevExpress.XtraBars.BarButtonItem();
            this.MnuCariRiskYonetim = new DevExpress.XtraBars.BarButtonItem();
            this.MnuCariFiyatlandirma = new DevExpress.XtraBars.BarButtonItem();
            this.MnuFinansYonetim = new DevExpress.XtraBars.BarSubItem();
            this.MnuNakitIslemleri = new DevExpress.XtraBars.BarButtonItem();
            this.MnuBankaIslem = new DevExpress.XtraBars.BarButtonItem();
            this.MnuKrediKarti = new DevExpress.XtraBars.BarButtonItem();
            this.MnuCekSenet = new DevExpress.XtraBars.BarButtonItem();
            this.MnuKasaTanim = new DevExpress.XtraBars.BarButtonItem();
            this.MnuBankaHesapTanim = new DevExpress.XtraBars.BarButtonItem();
            this.MnuSatisYonetim = new DevExpress.XtraBars.BarSubItem();
            this.MnuSatisFat = new DevExpress.XtraBars.BarButtonItem();
            this.MnuSevkIrs = new DevExpress.XtraBars.BarButtonItem();
            this.MnuMusteriSiparis = new DevExpress.XtraBars.BarButtonItem();
            this.MnuSatisTeklif = new DevExpress.XtraBars.BarButtonItem();
            this.MnuSatinAlmaYonetim = new DevExpress.XtraBars.BarSubItem();
            this.MnuAlisFat = new DevExpress.XtraBars.BarButtonItem();
            this.MnuAlisIrs = new DevExpress.XtraBars.BarButtonItem();
            this.MnuSatinAlmaSiparis = new DevExpress.XtraBars.BarButtonItem();
            this.MnuSatinAlmaTeklif = new DevExpress.XtraBars.BarButtonItem();
            this.MnuSatinAlmaTalep = new DevExpress.XtraBars.BarButtonItem();
            this.MnuRaporlar = new DevExpress.XtraBars.BarSubItem();
            this.MnuStokRapor = new DevExpress.XtraBars.BarSubItem();
            this.MnuCariRapor = new DevExpress.XtraBars.BarSubItem();
            this.MnuFinansalRapor = new DevExpress.XtraBars.BarSubItem();
            this.MnuSatisRapor = new DevExpress.XtraBars.BarSubItem();
            this.MnuSatinalmaRapor = new DevExpress.XtraBars.BarSubItem();
            this.MnuYonetselRaporlar = new DevExpress.XtraBars.BarSubItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.MnuStokTransfer = new DevExpress.XtraBars.BarButtonItem();
            this.MnuKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.MnuSil = new DevExpress.XtraBars.BarButtonItem();
            this.MnuYeniKayit = new DevExpress.XtraBars.BarButtonItem();
            this.MainTabControl = new KarmaObjects.KarmaTab(this.components);
            this.AppMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.DesktopTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karmaPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTabControl)).BeginInit();
            this.MainTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1120, 566);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // DesktopTab
            // 
            this.DesktopTab.Controls.Add(this.karmaPanel1);
            this.DesktopTab.Name = "DesktopTab";
            this.DesktopTab.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.DesktopTab.Size = new System.Drawing.Size(1214, 531);
            this.DesktopTab.Text = "Ana Sayfa";
            // 
            // karmaPanel1
            // 
            this.karmaPanel1.AllowTouchScroll = true;
            this.karmaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.karmaPanel1.InvertTouchScroll = true;
            this.karmaPanel1.KarmaChildPanels = null;
            this.karmaPanel1.KarmaColumnNames = null;
            this.karmaPanel1.KarmaGridControl = null;
            this.karmaPanel1.KarmaMasterButton = null;
            this.karmaPanel1.KarmaMasterTextBox = null;
            this.karmaPanel1.KarmaTableName = null;
            this.karmaPanel1.Location = new System.Drawing.Point(0, 0);
            this.karmaPanel1.Name = "karmaPanel1";
            this.karmaPanel1.Size = new System.Drawing.Size(1214, 531);
            this.karmaPanel1.TabIndex = 0;
            // 
            // MainBarManager
            // 
            this.MainBarManager.AllowCustomization = false;
            this.MainBarManager.AllowQuickCustomization = false;
            this.MainBarManager.AllowShowToolbarsPopup = false;
            this.MainBarManager.AutoSaveInRegistry = true;
            this.MainBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.StatusBar,
            this.MainMenu});
            this.MainBarManager.DockControls.Add(this.barDockControlTop);
            this.MainBarManager.DockControls.Add(this.barDockControlBottom);
            this.MainBarManager.DockControls.Add(this.barDockControlLeft);
            this.MainBarManager.DockControls.Add(this.barDockControlRight);
            this.MainBarManager.Form = this;
            this.MainBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MnuSistem,
            this.MnuGenelAyar,
            this.MnuBildirimAyar,
            this.MnuKullanici,
            this.MnuCikis,
            this.MnuIslemler,
            this.MnuStokYonetimi,
            this.MnuCariYonetim,
            this.MnuFinansYonetim,
            this.MnuSatisYonetim,
            this.MnuSatinAlmaYonetim,
            this.MnuRaporlar,
            this.MnuStokRapor,
            this.MnuCariRapor,
            this.MnuFinansalRapor,
            this.MnuSatisRapor,
            this.MnuSatinalmaRapor,
            this.MnuYonetselRaporlar,
            this.MnuStoklar,
            this.MnuStokBakiye,
            this.MnuStokSayim,
            this.MnuOlcuBrTanim,
            this.MnuFiyatTanim,
            this.MnuStokTransfer,
            this.MnuCariTanim,
            this.MnuCariBakiyeIslem,
            this.MnuCariVirman,
            this.MnuCariRiskYonetim,
            this.MnuCariFiyatlandirma,
            this.MnuNakitIslemleri,
            this.MnuBankaIslem,
            this.MnuKrediKarti,
            this.MnuCekSenet,
            this.MnuKasaTanim,
            this.MnuBankaHesapTanim,
            this.MnuSatisFat,
            this.MnuSevkIrs,
            this.MnuMusteriSiparis,
            this.MnuSatisTeklif,
            this.MnuAlisFat,
            this.MnuAlisIrs,
            this.MnuSatinAlmaSiparis,
            this.MnuSatinAlmaTeklif,
            this.MnuSatinAlmaTalep,
            this.MnuFiyatYonetimi,
            this.MnuKaydet,
            this.MnuSil,
            this.MnuYeniKayit,
            this.MnuUserSettings});
            this.MainBarManager.MainMenu = this.MainMenu;
            this.MainBarManager.MaxItemId = 54;
            this.MainBarManager.StatusBar = this.StatusBar;
            // 
            // StatusBar
            // 
            this.StatusBar.BarName = "Bildirim Paneli";
            this.StatusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.StatusBar.DockCol = 0;
            this.StatusBar.DockRow = 0;
            this.StatusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.StatusBar.OptionsBar.AllowQuickCustomization = false;
            this.StatusBar.OptionsBar.DisableCustomization = true;
            this.StatusBar.OptionsBar.DrawDragBorder = false;
            this.StatusBar.OptionsBar.UseWholeRow = true;
            this.StatusBar.Text = "Bildirim Paneli";
            // 
            // MainMenu
            // 
            this.MainMenu.BarName = "Ana Menü";
            this.MainMenu.DockCol = 0;
            this.MainMenu.DockRow = 0;
            this.MainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.MainMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuSistem),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuIslemler),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuRaporlar)});
            this.MainMenu.OptionsBar.DisableCustomization = true;
            this.MainMenu.OptionsBar.MultiLine = true;
            this.MainMenu.OptionsBar.UseWholeRow = true;
            this.MainMenu.Text = "Ana Menü";
            // 
            // MnuSistem
            // 
            this.MnuSistem.Caption = "Sistem";
            this.MnuSistem.Id = 3;
            this.MnuSistem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuGenelAyar),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuBildirimAyar),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuKullanici),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuCikis)});
            this.MnuSistem.Name = "MnuSistem";
            this.MnuSistem.Size = new System.Drawing.Size(100, 0);
            // 
            // MnuGenelAyar
            // 
            this.MnuGenelAyar.Caption = "Genel Ayarlar";
            this.MnuGenelAyar.Id = 4;
            this.MnuGenelAyar.Name = "MnuGenelAyar";
            // 
            // MnuBildirimAyar
            // 
            this.MnuBildirimAyar.Caption = "Bildirim Ayarları";
            this.MnuBildirimAyar.Id = 5;
            this.MnuBildirimAyar.Name = "MnuBildirimAyar";
            // 
            // MnuKullanici
            // 
            this.MnuKullanici.Caption = "Kullanıcı İşlemleri";
            this.MnuKullanici.Id = 6;
            this.MnuKullanici.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuUserSettings)});
            this.MnuKullanici.Name = "MnuKullanici";
            // 
            // MnuUserSettings
            // 
            this.MnuUserSettings.Caption = "Kullanıcı Tercihleri";
            this.MnuUserSettings.Id = 52;
            this.MnuUserSettings.Name = "MnuUserSettings";
            this.MnuUserSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MnuUserSettings_ItemClick);
            // 
            // MnuCikis
            // 
            this.MnuCikis.Caption = "Çıkış";
            this.MnuCikis.Id = 7;
            this.MnuCikis.Name = "MnuCikis";
            // 
            // MnuIslemler
            // 
            this.MnuIslemler.Caption = "İşlemler";
            this.MnuIslemler.Id = 8;
            this.MnuIslemler.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuStokYonetimi),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuCariYonetim),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuFinansYonetim),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuSatisYonetim),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuSatinAlmaYonetim)});
            this.MnuIslemler.Name = "MnuIslemler";
            this.MnuIslemler.Size = new System.Drawing.Size(100, 0);
            // 
            // MnuStokYonetimi
            // 
            this.MnuStokYonetimi.Caption = "Stok Yönetimi";
            this.MnuStokYonetimi.Id = 9;
            this.MnuStokYonetimi.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuStoklar),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuStokBakiye),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuStokSayim),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuOlcuBrTanim),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuFiyatTanim),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuFiyatYonetimi)});
            this.MnuStokYonetimi.Name = "MnuStokYonetimi";
            // 
            // MnuStoklar
            // 
            this.MnuStoklar.Caption = "Stoklar";
            this.MnuStoklar.Id = 21;
            this.MnuStoklar.Name = "MnuStoklar";
            this.MnuStoklar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MnuStoklar_ItemClick);
            // 
            // MnuStokBakiye
            // 
            this.MnuStokBakiye.Caption = "Stok Bakiye İşlemleri";
            this.MnuStokBakiye.Id = 22;
            this.MnuStokBakiye.Name = "MnuStokBakiye";
            // 
            // MnuStokSayim
            // 
            this.MnuStokSayim.Caption = "Stok Sayım İşlemleri";
            this.MnuStokSayim.Id = 23;
            this.MnuStokSayim.Name = "MnuStokSayim";
            // 
            // MnuOlcuBrTanim
            // 
            this.MnuOlcuBrTanim.Caption = "Stok Ölçü Birim Tanımları";
            this.MnuOlcuBrTanim.Id = 24;
            this.MnuOlcuBrTanim.Name = "MnuOlcuBrTanim";
            // 
            // MnuFiyatTanim
            // 
            this.MnuFiyatTanim.Caption = "Fiyat Tip Tanımları";
            this.MnuFiyatTanim.Id = 25;
            this.MnuFiyatTanim.Name = "MnuFiyatTanim";
            // 
            // MnuFiyatYonetimi
            // 
            this.MnuFiyatYonetimi.Caption = "Stok Fiyat Yönetimi";
            this.MnuFiyatYonetimi.Id = 48;
            this.MnuFiyatYonetimi.Name = "MnuFiyatYonetimi";
            // 
            // MnuCariYonetim
            // 
            this.MnuCariYonetim.Caption = "Cari Yönetimi";
            this.MnuCariYonetim.Id = 10;
            this.MnuCariYonetim.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuCariTanim),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuCariBakiyeIslem),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuCariVirman),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuCariRiskYonetim),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuCariFiyatlandirma)});
            this.MnuCariYonetim.Name = "MnuCariYonetim";
            // 
            // MnuCariTanim
            // 
            this.MnuCariTanim.Caption = "Cari Tanımları";
            this.MnuCariTanim.Id = 27;
            this.MnuCariTanim.Name = "MnuCariTanim";
            // 
            // MnuCariBakiyeIslem
            // 
            this.MnuCariBakiyeIslem.Caption = "Cari Bakiye İşlemleri";
            this.MnuCariBakiyeIslem.Id = 28;
            this.MnuCariBakiyeIslem.Name = "MnuCariBakiyeIslem";
            // 
            // MnuCariVirman
            // 
            this.MnuCariVirman.Caption = "Cari Virmanlama";
            this.MnuCariVirman.Id = 29;
            this.MnuCariVirman.Name = "MnuCariVirman";
            // 
            // MnuCariRiskYonetim
            // 
            this.MnuCariRiskYonetim.Caption = "Cari Risk Yönetimi";
            this.MnuCariRiskYonetim.Id = 30;
            this.MnuCariRiskYonetim.Name = "MnuCariRiskYonetim";
            // 
            // MnuCariFiyatlandirma
            // 
            this.MnuCariFiyatlandirma.Caption = "Cari Fiyatlandırma Yönetimi";
            this.MnuCariFiyatlandirma.Id = 31;
            this.MnuCariFiyatlandirma.Name = "MnuCariFiyatlandirma";
            // 
            // MnuFinansYonetim
            // 
            this.MnuFinansYonetim.Caption = "Finans Yönetimi";
            this.MnuFinansYonetim.Id = 11;
            this.MnuFinansYonetim.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuNakitIslemleri),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuBankaIslem),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuKrediKarti),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuCekSenet),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuKasaTanim),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuBankaHesapTanim)});
            this.MnuFinansYonetim.Name = "MnuFinansYonetim";
            // 
            // MnuNakitIslemleri
            // 
            this.MnuNakitIslemleri.Caption = "Nakit İşlemleri";
            this.MnuNakitIslemleri.Id = 32;
            this.MnuNakitIslemleri.Name = "MnuNakitIslemleri";
            // 
            // MnuBankaIslem
            // 
            this.MnuBankaIslem.Caption = "Banka İşlemleri";
            this.MnuBankaIslem.Id = 33;
            this.MnuBankaIslem.Name = "MnuBankaIslem";
            // 
            // MnuKrediKarti
            // 
            this.MnuKrediKarti.Caption = "Kredi Kartı İşlemleri";
            this.MnuKrediKarti.Id = 34;
            this.MnuKrediKarti.Name = "MnuKrediKarti";
            // 
            // MnuCekSenet
            // 
            this.MnuCekSenet.Caption = "Çek - Senet İşlemleri";
            this.MnuCekSenet.Id = 35;
            this.MnuCekSenet.Name = "MnuCekSenet";
            // 
            // MnuKasaTanim
            // 
            this.MnuKasaTanim.Caption = "Nakit Kasa Tanımları";
            this.MnuKasaTanim.Id = 36;
            this.MnuKasaTanim.Name = "MnuKasaTanim";
            // 
            // MnuBankaHesapTanim
            // 
            this.MnuBankaHesapTanim.Caption = "Banka Hesap Tanımları";
            this.MnuBankaHesapTanim.Id = 37;
            this.MnuBankaHesapTanim.Name = "MnuBankaHesapTanim";
            // 
            // MnuSatisYonetim
            // 
            this.MnuSatisYonetim.Caption = "Satış Yönetimi";
            this.MnuSatisYonetim.Id = 12;
            this.MnuSatisYonetim.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuSatisFat),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuSevkIrs),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuMusteriSiparis),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuSatisTeklif)});
            this.MnuSatisYonetim.Name = "MnuSatisYonetim";
            // 
            // MnuSatisFat
            // 
            this.MnuSatisFat.Caption = "Satış Faturası";
            this.MnuSatisFat.Id = 38;
            this.MnuSatisFat.Name = "MnuSatisFat";
            // 
            // MnuSevkIrs
            // 
            this.MnuSevkIrs.Caption = "Sevk İrsaliyesi";
            this.MnuSevkIrs.Id = 39;
            this.MnuSevkIrs.Name = "MnuSevkIrs";
            // 
            // MnuMusteriSiparis
            // 
            this.MnuMusteriSiparis.Caption = "Müşteri Siparişi";
            this.MnuMusteriSiparis.Id = 40;
            this.MnuMusteriSiparis.Name = "MnuMusteriSiparis";
            // 
            // MnuSatisTeklif
            // 
            this.MnuSatisTeklif.Caption = "Satış Teklifi";
            this.MnuSatisTeklif.Id = 41;
            this.MnuSatisTeklif.Name = "MnuSatisTeklif";
            // 
            // MnuSatinAlmaYonetim
            // 
            this.MnuSatinAlmaYonetim.Caption = "Satın Alma Yönetimi";
            this.MnuSatinAlmaYonetim.Id = 13;
            this.MnuSatinAlmaYonetim.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuAlisFat),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuAlisIrs),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuSatinAlmaSiparis),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuSatinAlmaTeklif),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuSatinAlmaTalep)});
            this.MnuSatinAlmaYonetim.Name = "MnuSatinAlmaYonetim";
            // 
            // MnuAlisFat
            // 
            this.MnuAlisFat.Caption = "Alış Faturası";
            this.MnuAlisFat.Id = 42;
            this.MnuAlisFat.Name = "MnuAlisFat";
            // 
            // MnuAlisIrs
            // 
            this.MnuAlisIrs.Caption = "Alış İrsaliyesi";
            this.MnuAlisIrs.Id = 43;
            this.MnuAlisIrs.Name = "MnuAlisIrs";
            // 
            // MnuSatinAlmaSiparis
            // 
            this.MnuSatinAlmaSiparis.Caption = "Satın Alma Siparişi";
            this.MnuSatinAlmaSiparis.Id = 44;
            this.MnuSatinAlmaSiparis.Name = "MnuSatinAlmaSiparis";
            // 
            // MnuSatinAlmaTeklif
            // 
            this.MnuSatinAlmaTeklif.Caption = "Satın Alma Teklifi";
            this.MnuSatinAlmaTeklif.Id = 45;
            this.MnuSatinAlmaTeklif.Name = "MnuSatinAlmaTeklif";
            // 
            // MnuSatinAlmaTalep
            // 
            this.MnuSatinAlmaTalep.Caption = "Satın Alma Talebi";
            this.MnuSatinAlmaTalep.Id = 46;
            this.MnuSatinAlmaTalep.Name = "MnuSatinAlmaTalep";
            // 
            // MnuRaporlar
            // 
            this.MnuRaporlar.Caption = "Raporlar";
            this.MnuRaporlar.Id = 14;
            this.MnuRaporlar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuStokRapor),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuCariRapor),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuFinansalRapor),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuSatisRapor),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuSatinalmaRapor),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuYonetselRaporlar)});
            this.MnuRaporlar.Name = "MnuRaporlar";
            this.MnuRaporlar.Size = new System.Drawing.Size(100, 0);
            // 
            // MnuStokRapor
            // 
            this.MnuStokRapor.Caption = "Stok Raporları";
            this.MnuStokRapor.Id = 15;
            this.MnuStokRapor.Name = "MnuStokRapor";
            // 
            // MnuCariRapor
            // 
            this.MnuCariRapor.Caption = "Cari Raporları";
            this.MnuCariRapor.Id = 16;
            this.MnuCariRapor.Name = "MnuCariRapor";
            // 
            // MnuFinansalRapor
            // 
            this.MnuFinansalRapor.Caption = "Finansal Raporlar";
            this.MnuFinansalRapor.Id = 17;
            this.MnuFinansalRapor.Name = "MnuFinansalRapor";
            // 
            // MnuSatisRapor
            // 
            this.MnuSatisRapor.Caption = "Satış Raporları";
            this.MnuSatisRapor.Id = 18;
            this.MnuSatisRapor.Name = "MnuSatisRapor";
            // 
            // MnuSatinalmaRapor
            // 
            this.MnuSatinalmaRapor.Caption = "Satın Alma Raporları";
            this.MnuSatinalmaRapor.Id = 19;
            this.MnuSatinalmaRapor.Name = "MnuSatinalmaRapor";
            // 
            // MnuYonetselRaporlar
            // 
            this.MnuYonetselRaporlar.Caption = "Yönetsel Raporlar";
            this.MnuYonetselRaporlar.Id = 20;
            this.MnuYonetselRaporlar.Name = "MnuYonetselRaporlar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.MainBarManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1216, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 580);
            this.barDockControlBottom.Manager = this.MainBarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1216, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.MainBarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 560);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1216, 20);
            this.barDockControlRight.Manager = this.MainBarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 560);
            // 
            // MnuStokTransfer
            // 
            this.MnuStokTransfer.Caption = "Stok Transfer İşlemleri";
            this.MnuStokTransfer.Id = 26;
            this.MnuStokTransfer.Name = "MnuStokTransfer";
            // 
            // MnuKaydet
            // 
            this.MnuKaydet.Caption = "Kaydet";
            this.MnuKaydet.Id = 49;
            this.MnuKaydet.Name = "MnuKaydet";
            // 
            // MnuSil
            // 
            this.MnuSil.Caption = "Sil";
            this.MnuSil.Id = 50;
            this.MnuSil.Name = "MnuSil";
            // 
            // MnuYeniKayit
            // 
            this.MnuYeniKayit.Caption = "Yeni Kayıt";
            this.MnuYeniKayit.Id = 51;
            this.MnuYeniKayit.Name = "MnuYeniKayit";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainTabControl.Appearance.Options.UseBackColor = true;
            this.MainTabControl.AppearancePage.Header.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.MainTabControl.AppearancePage.Header.Options.UseFont = true;
            this.MainTabControl.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.OrangeRed;
            this.MainTabControl.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.MainTabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.KarmaCloseButtonMessageActive = true;
            this.MainTabControl.Location = new System.Drawing.Point(0, 20);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedTabPage = this.DesktopTab;
            this.MainTabControl.Size = new System.Drawing.Size(1216, 560);
            this.MainTabControl.TabIndex = 2;
            this.MainTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.DesktopTab});
            // 
            // AppMenu
            // 
            this.AppMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuSistem),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuIslemler),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuRaporlar)});
            this.AppMenu.Name = "AppMenu";
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 602);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.EnableAcrylicAccent = true;
            this.Font = new System.Drawing.Font("Roboto", 9F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Name = "MainForm";
            this.Text = "Karma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DesktopTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.karmaPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTabControl)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Timer MainTimer;
        private KarmaObjects.KarmaTab MainTabControl;
        private DevExpress.XtraTab.XtraTabPage DesktopTab;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu AppMenu;
        private DevExpress.XtraBars.BarManager MainBarManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem MnuSistem;
        private DevExpress.XtraBars.BarButtonItem MnuGenelAyar;
        private DevExpress.XtraBars.BarButtonItem MnuBildirimAyar;
        private DevExpress.XtraBars.BarButtonItem MnuCikis;
        private DevExpress.XtraBars.Bar StatusBar;
        private DevExpress.XtraBars.Bar MainMenu;
        private DevExpress.XtraBars.BarSubItem MnuIslemler;
        private DevExpress.XtraBars.BarSubItem MnuStokYonetimi;
        private DevExpress.XtraBars.BarSubItem MnuCariYonetim;
        private DevExpress.XtraBars.BarSubItem MnuFinansYonetim;
        private DevExpress.XtraBars.BarSubItem MnuSatisYonetim;
        private DevExpress.XtraBars.BarSubItem MnuSatinAlmaYonetim;
        private DevExpress.XtraBars.BarSubItem MnuRaporlar;
        private DevExpress.XtraBars.BarSubItem MnuStokRapor;
        private DevExpress.XtraBars.BarSubItem MnuCariRapor;
        private DevExpress.XtraBars.BarSubItem MnuFinansalRapor;
        private DevExpress.XtraBars.BarSubItem MnuSatisRapor;
        private DevExpress.XtraBars.BarSubItem MnuSatinalmaRapor;
        private DevExpress.XtraBars.BarSubItem MnuYonetselRaporlar;
        private DevExpress.XtraBars.BarButtonItem MnuStoklar;
        private DevExpress.XtraBars.BarButtonItem MnuStokBakiye;
        private DevExpress.XtraBars.BarButtonItem MnuStokSayim;
        private DevExpress.XtraBars.BarButtonItem MnuOlcuBrTanim;
        private DevExpress.XtraBars.BarButtonItem MnuFiyatTanim;
        private DevExpress.XtraBars.BarButtonItem MnuStokTransfer;
        private DevExpress.XtraBars.BarButtonItem MnuFiyatYonetimi;
        private DevExpress.XtraBars.BarButtonItem MnuCariTanim;
        private DevExpress.XtraBars.BarButtonItem MnuCariBakiyeIslem;
        private DevExpress.XtraBars.BarButtonItem MnuCariVirman;
        private DevExpress.XtraBars.BarButtonItem MnuCariRiskYonetim;
        private DevExpress.XtraBars.BarButtonItem MnuCariFiyatlandirma;
        private DevExpress.XtraBars.BarButtonItem MnuNakitIslemleri;
        private DevExpress.XtraBars.BarButtonItem MnuBankaIslem;
        private DevExpress.XtraBars.BarButtonItem MnuKrediKarti;
        private DevExpress.XtraBars.BarButtonItem MnuCekSenet;
        private DevExpress.XtraBars.BarButtonItem MnuKasaTanim;
        private DevExpress.XtraBars.BarButtonItem MnuBankaHesapTanim;
        private DevExpress.XtraBars.BarButtonItem MnuSatisFat;
        private DevExpress.XtraBars.BarButtonItem MnuSevkIrs;
        private DevExpress.XtraBars.BarButtonItem MnuMusteriSiparis;
        private DevExpress.XtraBars.BarButtonItem MnuSatisTeklif;
        private DevExpress.XtraBars.BarButtonItem MnuAlisFat;
        private DevExpress.XtraBars.BarButtonItem MnuAlisIrs;
        private DevExpress.XtraBars.BarButtonItem MnuSatinAlmaSiparis;
        private DevExpress.XtraBars.BarButtonItem MnuSatinAlmaTeklif;
        private DevExpress.XtraBars.BarButtonItem MnuSatinAlmaTalep;
        private DevExpress.XtraBars.BarButtonItem MnuKaydet;
        private DevExpress.XtraBars.BarButtonItem MnuSil;
        private DevExpress.XtraBars.BarButtonItem MnuYeniKayit;
        private KarmaObjects.KarmaPanel karmaPanel1;
        private DevExpress.XtraBars.BarButtonItem MnuUserSettings;
        private DevExpress.XtraBars.BarSubItem MnuKullanici;
    }
}

