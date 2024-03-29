﻿namespace Karma_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.DesktopTab = new DevExpress.XtraTab.XtraTabPage();
            this.MainBarManager = new DevExpress.XtraBars.BarManager(this.components);
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
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.StatusServerName = new DevExpress.XtraBars.BarStaticItem();
            this.AppVersion = new DevExpress.XtraBars.BarStaticItem();
            this.SelectTheme = new DevExpress.XtraBars.SkinBarSubItem();
            this.ThemeColor = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.NotifyButton = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.MnuStokTransfer = new DevExpress.XtraBars.BarButtonItem();
            this.MnuKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.MnuSil = new DevExpress.XtraBars.BarButtonItem();
            this.MnuYeniKayit = new DevExpress.XtraBars.BarButtonItem();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.AppMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.MainTabControl = new KarmaObjects.KarmaTab(this.components);
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.GenelAlert = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.BildirimList = new DevExpress.XtraEditors.TileControl();
            this.BildirimGroup = new DevExpress.XtraEditors.TileGroup();
            this.Timer1Sn = new System.Windows.Forms.Timer(this.components);
            this.StatusUser = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.MainBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTabControl)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1120, 566);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 15000;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // DesktopTab
            // 
            this.DesktopTab.Name = "DesktopTab";
            this.DesktopTab.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.DesktopTab.Size = new System.Drawing.Size(1214, 527);
            this.DesktopTab.Text = "Ana Sayfa";
            // 
            // MainBarManager
            // 
            this.MainBarManager.AllowCustomization = false;
            this.MainBarManager.AllowQuickCustomization = false;
            this.MainBarManager.AllowShowToolbarsPopup = false;
            this.MainBarManager.AutoSaveInRegistry = true;
            this.MainBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.MainMenu,
            this.bar1});
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
            this.MnuUserSettings,
            this.StatusServerName,
            this.AppVersion,
            this.SelectTheme,
            this.ThemeColor,
            this.barToolbarsListItem1,
            this.NotifyButton,
            this.StatusUser});
            this.MainBarManager.MainMenu = this.MainMenu;
            this.MainBarManager.MaxItemId = 63;
            this.MainBarManager.StatusBar = this.bar1;
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
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
            this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.StatusServerName),
            new DevExpress.XtraBars.LinkPersistInfo(this.AppVersion),
            new DevExpress.XtraBars.LinkPersistInfo(this.SelectTheme),
            new DevExpress.XtraBars.LinkPersistInfo(this.ThemeColor),
            new DevExpress.XtraBars.LinkPersistInfo(this.NotifyButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.StatusUser)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 3";
            // 
            // StatusServerName
            // 
            this.StatusServerName.Caption = "Bağlandı";
            this.StatusServerName.Id = 54;
            this.StatusServerName.Name = "StatusServerName";
            this.StatusServerName.Size = new System.Drawing.Size(250, 0);
            this.StatusServerName.Width = 250;
            // 
            // AppVersion
            // 
            this.AppVersion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.AppVersion.Caption = "Version";
            this.AppVersion.Id = 55;
            this.AppVersion.Name = "AppVersion";
            // 
            // SelectTheme
            // 
            this.SelectTheme.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.SelectTheme.Caption = "Tema";
            this.SelectTheme.Id = 58;
            this.SelectTheme.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.SelectTheme.ImageOptions.AllowStubGlyph = DevExpress.Utils.DefaultBoolean.False;
            this.SelectTheme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SelectTheme.ImageOptions.Image")));
            this.SelectTheme.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("SelectTheme.ImageOptions.LargeImage")));
            this.SelectTheme.Name = "SelectTheme";
            this.SelectTheme.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.SelectTheme.Size = new System.Drawing.Size(80, 0);
            // 
            // ThemeColor
            // 
            this.ThemeColor.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.ThemeColor.Description = "Renk düzeni";
            this.ThemeColor.Id = 59;
            this.ThemeColor.Name = "ThemeColor";
            this.ThemeColor.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // NotifyButton
            // 
            this.NotifyButton.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.NotifyButton.Caption = "0";
            this.NotifyButton.Id = 61;
            this.NotifyButton.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.NotifyButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NotifyButton.ImageOptions.SvgImage")));
            this.NotifyButton.Name = "NotifyButton";
            this.NotifyButton.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.NotifyButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NotifyButton_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.MainBarManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1216, 23);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 577);
            this.barDockControlBottom.Manager = this.MainBarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1216, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 23);
            this.barDockControlLeft.Manager = this.MainBarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 554);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1216, 23);
            this.barDockControlRight.Manager = this.MainBarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 554);
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
            // barToolbarsListItem1
            // 
            this.barToolbarsListItem1.Caption = "barToolbarsListItem1";
            this.barToolbarsListItem1.Id = 60;
            this.barToolbarsListItem1.Name = "barToolbarsListItem1";
            // 
            // AppMenu
            // 
            this.AppMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuSistem),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuIslemler),
            new DevExpress.XtraBars.LinkPersistInfo(this.MnuRaporlar)});
            this.AppMenu.Name = "AppMenu";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainTabControl.Appearance.Options.UseBackColor = true;
            this.MainTabControl.AppearancePage.Header.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.MainTabControl.AppearancePage.Header.Options.UseFont = true;
            this.MainTabControl.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.PowderBlue;
            this.MainTabControl.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.MainTabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.KarmaCloseButton = false;
            this.MainTabControl.KarmaCloseButtonMessageActive = true;
            this.MainTabControl.Location = new System.Drawing.Point(0, 23);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.PaintStyleName = "Skin";
            this.MainTabControl.SelectedTabPage = this.DesktopTab;
            this.MainTabControl.Size = new System.Drawing.Size(1216, 554);
            this.MainTabControl.TabIndex = 2;
            this.MainTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.DesktopTab});
            this.MainTabControl.TabPageWidth = 100;
            this.MainTabControl.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.True;
            this.MainTabControl.Transition.EasingMode = DevExpress.Data.Utils.EasingMode.EaseInOut;
            this.MainTabControl.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.MainTabControl_SelectedPageChanged);
            // 
            // tileItem1
            // 
            this.tileItem1.Name = "tileItem1";
            // 
            // GenelAlert
            // 
            this.GenelAlert.ControlBoxPosition = DevExpress.XtraBars.Alerter.AlertFormControlBoxPosition.Right;
            this.GenelAlert.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Slow;
            this.GenelAlert.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideVertical;
            // 
            // tileControl1
            // 
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tileControl1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tileControl1.IndentBetweenItems = 5;
            this.tileControl1.Location = new System.Drawing.Point(1216, 23);
            this.tileControl1.MaxId = 4;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.OptionsAdaptiveLayout.ItemMinSize = new System.Drawing.Size(120, 50);
            this.tileControl1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileControl1.RowCount = 50;
            this.tileControl1.Size = new System.Drawing.Size(0, 554);
            this.tileControl1.TabIndex = 8;
            this.tileControl1.Text = "tileControl1";
            // 
            // BildirimList
            // 
            this.BildirimList.AllowDrag = false;
            this.BildirimList.AllowDragTilesBetweenGroups = false;
            this.BildirimList.AllowSmoothScrolling = false;
            this.BildirimList.Dock = System.Windows.Forms.DockStyle.Right;
            this.BildirimList.Groups.Add(this.BildirimGroup);
            this.BildirimList.IndentBetweenGroups = 0;
            this.BildirimList.Location = new System.Drawing.Point(1166, 23);
            this.BildirimList.MaxId = 3;
            this.BildirimList.Name = "BildirimList";
            this.BildirimList.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BildirimList.Size = new System.Drawing.Size(50, 554);
            this.BildirimList.TabIndex = 14;
            this.BildirimList.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.NotifyButtonClick);
            // 
            // BildirimGroup
            // 
            this.BildirimGroup.Name = "BildirimGroup";
            // 
            // Timer1Sn
            // 
            this.Timer1Sn.Enabled = true;
            this.Timer1Sn.Interval = 1000;
            this.Timer1Sn.Tick += new System.EventHandler(this.Timer1Sn_Tick);
            // 
            // StatusUser
            // 
            this.StatusUser.Caption = "Administrator";
            this.StatusUser.Id = 62;
            this.StatusUser.Name = "StatusUser";
            this.StatusUser.Size = new System.Drawing.Size(100, 0);
            this.StatusUser.Width = 100;
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
            this.Controls.Add(this.BildirimList);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.tileControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.EnableAcrylicAccent = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Name = "MainForm";
            this.Text = "Karma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.tileControl1, 0);
            this.Controls.SetChildIndex(this.MainTabControl, 0);
            this.Controls.SetChildIndex(this.BildirimList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MainBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTabControl)).EndInit();
            this.MainTabControl.ResumeLayout(false);
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
        private DevExpress.XtraBars.BarButtonItem MnuUserSettings;
        private DevExpress.XtraBars.BarSubItem MnuKullanici;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarStaticItem StatusServerName;
        private DevExpress.XtraBars.BarStaticItem AppVersion;
        private DevExpress.XtraBars.SkinBarSubItem SelectTheme;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem ThemeColor;
        private DevExpress.XtraBars.Alerter.AlertControl GenelAlert;
        private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;
        private DevExpress.XtraBars.BarButtonItem NotifyButton;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileControl BildirimList;
        private DevExpress.XtraEditors.TileGroup BildirimGroup;
        private System.Windows.Forms.Timer Timer1Sn;
        private DevExpress.XtraBars.BarStaticItem StatusUser;
    }
}

