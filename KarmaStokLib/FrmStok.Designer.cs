namespace KarmaStokLib
{
    partial class FrmStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStok));
            this.karmaTab1 = new KarmaObjects.KarmaTab(this.components);
            this.PgeStokList = new DevExpress.XtraTab.XtraTabPage();
            this.GrdStoklar = new KarmaObjects.KarmaGrid();
            this.ViewStoklar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PgeStokIslem = new DevExpress.XtraTab.XtraTabPage();
            this.karmaTab2 = new KarmaObjects.KarmaTab(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PnlStokGrup = new KarmaObjects.KarmaPanel(this.components);
            this.GrdStokGrup = new KarmaObjects.KarmaGrid();
            this.ViewStokGrup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.karmaPanel5 = new KarmaObjects.KarmaPanel(this.components);
            this.GrupDeger = new KarmaObjects.KarmaComboBox();
            this.GrupKodu = new KarmaObjects.KarmaComboBox();
            this.karmaLabel9 = new KarmaObjects.KarmaLabel();
            this.karmaLabel10 = new KarmaObjects.KarmaLabel();
            this.karmaButton3 = new KarmaObjects.KarmaButton(this.components);
            this.StokKodu = new KarmaObjects.KarmaTextBox(this.components);
            this.PnlStokFiyat = new KarmaObjects.KarmaPanel(this.components);
            this.GrdStokFiyat = new KarmaObjects.KarmaGrid();
            this.ViewStokFiyat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.karmaPanel1 = new KarmaObjects.KarmaPanel(this.components);
            this.FiyatKodu = new KarmaObjects.KarmaComboBox();
            this.karmaLabel8 = new KarmaObjects.KarmaLabel();
            this.karmaLabel7 = new KarmaObjects.KarmaLabel();
            this.karmaButton2 = new KarmaObjects.KarmaButton(this.components);
            this.Fiyat = new KarmaObjects.KarmaTextBox(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PnlStokPlan = new KarmaObjects.KarmaPanel(this.components);
            this.KritikStokUyar = new KarmaObjects.KarmaCheck();
            this.karmaLabel23 = new KarmaObjects.KarmaLabel();
            this.SatisSipDahil = new KarmaObjects.KarmaCheck();
            this.karmaLabel22 = new KarmaObjects.KarmaLabel();
            this.AlisSipDahil = new KarmaObjects.KarmaCheck();
            this.karmaLabel21 = new KarmaObjects.KarmaLabel();
            this.MaxStok = new KarmaObjects.KarmaTextBox(this.components);
            this.karmaLabel20 = new KarmaObjects.KarmaLabel();
            this.MaxStokTakibi = new KarmaObjects.KarmaCheck();
            this.MinStokTakibi = new KarmaObjects.KarmaCheck();
            this.karmaLabel18 = new KarmaObjects.KarmaLabel();
            this.karmaLabel19 = new KarmaObjects.KarmaLabel();
            this.MinStok = new KarmaObjects.KarmaTextBox(this.components);
            this.karmaLabel17 = new KarmaObjects.KarmaLabel();
            this.PnlStokAyar = new KarmaObjects.KarmaPanel(this.components);
            this.TalepYok = new KarmaObjects.KarmaCheck();
            this.TeklifYok = new KarmaObjects.KarmaCheck();
            this.SiparisYok = new KarmaObjects.KarmaCheck();
            this.AlisYapilmaz = new KarmaObjects.KarmaCheck();
            this.SatisYapilmaz = new KarmaObjects.KarmaCheck();
            this.PasifStok = new KarmaObjects.KarmaCheck();
            this.karmaLabel16 = new KarmaObjects.KarmaLabel();
            this.karmaLabel15 = new KarmaObjects.KarmaLabel();
            this.karmaLabel14 = new KarmaObjects.KarmaLabel();
            this.karmaLabel13 = new KarmaObjects.KarmaLabel();
            this.karmaLabel12 = new KarmaObjects.KarmaLabel();
            this.karmaLabel11 = new KarmaObjects.KarmaLabel();
            this.PnlStokMas = new KarmaObjects.KarmaPanel(this.components);
            this.karmaButton1 = new KarmaObjects.KarmaButton(this.components);
            this.StokAciklama = new KarmaObjects.KarmaTextBox(this.components);
            this.SKdv = new KarmaObjects.KarmaComboBox();
            this.AKdv = new KarmaObjects.KarmaComboBox();
            this.OlcuBr = new KarmaObjects.KarmaComboBox();
            this.karmaLabel6 = new KarmaObjects.KarmaLabel();
            this.StokAdi = new KarmaObjects.KarmaTextBox(this.components);
            this.karmaLabel5 = new KarmaObjects.KarmaLabel();
            this.karmaLabel4 = new KarmaObjects.KarmaLabel();
            this.karmaLabel3 = new KarmaObjects.KarmaLabel();
            this.karmaLabel2 = new KarmaObjects.KarmaLabel();
            this.karmaLabel1 = new KarmaObjects.KarmaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.karmaTab1)).BeginInit();
            this.karmaTab1.SuspendLayout();
            this.PgeStokList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdStoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStoklar)).BeginInit();
            this.PgeStokIslem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karmaTab2)).BeginInit();
            this.karmaTab2.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnlStokGrup)).BeginInit();
            this.PnlStokGrup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdStokGrup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStokGrup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karmaPanel5)).BeginInit();
            this.karmaPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrupDeger.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlStokFiyat)).BeginInit();
            this.PnlStokFiyat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdStokFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStokFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karmaPanel1)).BeginInit();
            this.karmaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FiyatKodu.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnlStokPlan)).BeginInit();
            this.PnlStokPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KritikStokUyar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatisSipDahil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlisSipDahil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxStokTakibi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinStokTakibi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlStokAyar)).BeginInit();
            this.PnlStokAyar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TalepYok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeklifYok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SiparisYok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlisYapilmaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatisYapilmaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasifStok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlStokMas)).BeginInit();
            this.PnlStokMas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SKdv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AKdv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OlcuBr.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // karmaTab1
            // 
            this.karmaTab1.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.OrangeRed;
            this.karmaTab1.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.karmaTab1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.karmaTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.karmaTab1.KarmaCloseButton = false;
            this.karmaTab1.KarmaCloseButtonMessageActive = false;
            this.karmaTab1.Location = new System.Drawing.Point(0, 0);
            this.karmaTab1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.karmaTab1.Name = "karmaTab1";
            this.karmaTab1.SelectedTabPage = this.PgeStokList;
            this.karmaTab1.Size = new System.Drawing.Size(1156, 664);
            this.karmaTab1.TabIndex = 16;
            this.karmaTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PgeStokList,
            this.PgeStokIslem});
            // 
            // PgeStokList
            // 
            this.PgeStokList.Controls.Add(this.GrdStoklar);
            this.PgeStokList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PgeStokList.Name = "PgeStokList";
            this.PgeStokList.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.PgeStokList.Size = new System.Drawing.Size(1154, 639);
            this.PgeStokList.Text = "Stok Listesi";
            // 
            // GrdStoklar
            // 
            this.GrdStoklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdStoklar.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.GrdStoklar.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.GrdStoklar.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.GrdStoklar.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.GrdStoklar.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.GrdStoklar.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrdStoklar.EmbeddedNavigator.TextStringFormat = "{1} Kayıttan {0}. kayıt";
            this.GrdStoklar.Font = new System.Drawing.Font("Roboto", 9F);
            this.GrdStoklar.KarmaAddSirketWhere = false;
            this.GrdStoklar.KarmaAddYilWhere = false;
            this.GrdStoklar.KarmaSQLCalistir = true;
            this.GrdStoklar.KarmaSQLText = "SELECT * FROM tblStok";
            this.GrdStoklar.Location = new System.Drawing.Point(0, 0);
            this.GrdStoklar.MainView = this.ViewStoklar;
            this.GrdStoklar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrdStoklar.Name = "GrdStoklar";
            this.GrdStoklar.Size = new System.Drawing.Size(1154, 639);
            this.GrdStoklar.TabIndex = 0;
            this.GrdStoklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewStoklar});
            this.GrdStoklar.DoubleClick += new System.EventHandler(this.GrdStoklar_DoubleClick);
            // 
            // ViewStoklar
            // 
            this.ViewStoklar.Appearance.Preview.Font = new System.Drawing.Font("Roboto", 9F);
            this.ViewStoklar.Appearance.Preview.Options.UseFont = true;
            this.ViewStoklar.Appearance.Row.Font = new System.Drawing.Font("Roboto", 9F);
            this.ViewStoklar.Appearance.Row.Options.UseFont = true;
            this.ViewStoklar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.ViewStoklar.DetailHeight = 377;
            this.ViewStoklar.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.ViewStoklar.GridControl = this.GrdStoklar;
            this.ViewStoklar.GroupPanelText = "Gruplamak için sütunu sürükleyip buraya bırakın";
            this.ViewStoklar.IndicatorWidth = 50;
            this.ViewStoklar.Name = "ViewStoklar";
            this.ViewStoklar.OptionsBehavior.Editable = false;
            this.ViewStoklar.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.ViewStoklar.OptionsFind.AlwaysVisible = true;
            this.ViewStoklar.OptionsFind.FindDelay = 100;
            this.ViewStoklar.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.ViewStoklar.OptionsFind.FindNullPrompt = "Aramak için buraya yazın";
            this.ViewStoklar.OptionsFind.ShowFindButton = false;
            this.ViewStoklar.OptionsMenu.EnableColumnMenu = false;
            this.ViewStoklar.OptionsMenu.EnableGroupPanelMenu = false;
            this.ViewStoklar.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Fast;
            this.ViewStoklar.OptionsView.ColumnAutoWidth = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 87;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Stok Kodu";
            this.gridColumn2.FieldName = "StokKodu";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 87;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Stok Adı";
            this.gridColumn3.FieldName = "StokAdi";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 87;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "KDV Oranı(Alış)";
            this.gridColumn4.FieldName = "AlisKDVOrani";
            this.gridColumn4.MinWidth = 23;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 87;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ölçü Birimi";
            this.gridColumn5.FieldName = "OlcuBr";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 87;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "KDV Oranı(Satış)";
            this.gridColumn6.FieldName = "SatisKDVOrani";
            this.gridColumn6.MinWidth = 23;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 87;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Açıklama";
            this.gridColumn7.FieldName = "Aciklama";
            this.gridColumn7.MinWidth = 23;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 87;
            // 
            // PgeStokIslem
            // 
            this.PgeStokIslem.Controls.Add(this.karmaTab2);
            this.PgeStokIslem.Controls.Add(this.PnlStokMas);
            this.PgeStokIslem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PgeStokIslem.Name = "PgeStokIslem";
            this.PgeStokIslem.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.PgeStokIslem.Size = new System.Drawing.Size(1154, 639);
            this.PgeStokIslem.Text = "Stok Bilgisi";
            // 
            // karmaTab2
            // 
            this.karmaTab2.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.karmaTab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.karmaTab2.KarmaCloseButton = false;
            this.karmaTab2.KarmaCloseButtonMessageActive = true;
            this.karmaTab2.Location = new System.Drawing.Point(0, 218);
            this.karmaTab2.Name = "karmaTab2";
            this.karmaTab2.SelectedTabPage = this.xtraTabPage1;
            this.karmaTab2.Size = new System.Drawing.Size(1154, 421);
            this.karmaTab2.TabIndex = 1;
            this.karmaTab2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.tableLayoutPanel1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabPage1.Size = new System.Drawing.Size(1152, 396);
            this.xtraTabPage1.Text = "Fiyat ve Grup Bilgileri";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PnlStokGrup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PnlStokFiyat, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1152, 396);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // PnlStokGrup
            // 
            this.PnlStokGrup.Controls.Add(this.GrdStokGrup);
            this.PnlStokGrup.Controls.Add(this.karmaPanel5);
            this.PnlStokGrup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlStokGrup.KarmaAddSirketWhere = false;
            this.PnlStokGrup.KarmaAddYilWhere = false;
            this.PnlStokGrup.KarmaColumnNames = null;
            this.PnlStokGrup.KarmaGridControl = null;
            this.PnlStokGrup.KarmaMasterButton = null;
            this.PnlStokGrup.KarmaMasterTextBox = null;
            this.PnlStokGrup.KarmaSecTextBox = null;
            this.PnlStokGrup.KarmaTableName = null;
            this.PnlStokGrup.Location = new System.Drawing.Point(384, 3);
            this.PnlStokGrup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PnlStokGrup.Name = "PnlStokGrup";
            this.PnlStokGrup.Size = new System.Drawing.Size(372, 390);
            this.PnlStokGrup.TabIndex = 5;
            this.PnlStokGrup.Text = "Grup Bilgileri";
            // 
            // GrdStokGrup
            // 
            this.GrdStokGrup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdStokGrup.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrdStokGrup.KarmaAddSirketWhere = false;
            this.GrdStokGrup.KarmaAddYilWhere = false;
            this.GrdStokGrup.KarmaSQLCalistir = false;
            this.GrdStokGrup.KarmaSQLText = null;
            this.GrdStokGrup.Location = new System.Drawing.Point(2, 90);
            this.GrdStokGrup.MainView = this.ViewStokGrup;
            this.GrdStokGrup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrdStokGrup.Name = "GrdStokGrup";
            this.GrdStokGrup.Size = new System.Drawing.Size(368, 298);
            this.GrdStokGrup.TabIndex = 1;
            this.GrdStokGrup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewStokGrup});
            // 
            // ViewStokGrup
            // 
            this.ViewStokGrup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13});
            this.ViewStokGrup.DetailHeight = 377;
            this.ViewStokGrup.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.ViewStokGrup.GridControl = this.GrdStokGrup;
            this.ViewStokGrup.GroupPanelText = "Gruplamak için sütunu sürükleyip buraya bırakın";
            this.ViewStokGrup.IndicatorWidth = 50;
            this.ViewStokGrup.Name = "ViewStokGrup";
            this.ViewStokGrup.OptionsBehavior.Editable = false;
            this.ViewStokGrup.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.ViewStokGrup.OptionsCustomization.AllowGroup = false;
            this.ViewStokGrup.OptionsFind.AlwaysVisible = true;
            this.ViewStokGrup.OptionsFind.FindDelay = 100;
            this.ViewStokGrup.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.ViewStokGrup.OptionsFind.FindNullPrompt = "Aramak için buraya yazın";
            this.ViewStokGrup.OptionsFind.ShowFindButton = false;
            this.ViewStokGrup.OptionsMenu.EnableColumnMenu = false;
            this.ViewStokGrup.OptionsMenu.EnableGroupPanelMenu = false;
            this.ViewStokGrup.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Fast;
            this.ViewStokGrup.OptionsView.ColumnAutoWidth = false;
            this.ViewStokGrup.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Değeri";
            this.gridColumn10.FieldName = "Deger";
            this.gridColumn10.MinWidth = 23;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Width = 150;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Değeri";
            this.gridColumn11.DisplayFormat.FormatString = "N2";
            this.gridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn11.FieldName = "DegerDetay";
            this.gridColumn11.MinWidth = 23;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            this.gridColumn11.Width = 248;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Grup Kodu";
            this.gridColumn12.FieldName = "GrupKodu";
            this.gridColumn12.Name = "gridColumn12";
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Grup Kodu";
            this.gridColumn13.FieldName = "GrupAciklama";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 0;
            // 
            // karmaPanel5
            // 
            this.karmaPanel5.Controls.Add(this.GrupDeger);
            this.karmaPanel5.Controls.Add(this.karmaLabel9);
            this.karmaPanel5.Controls.Add(this.karmaLabel10);
            this.karmaPanel5.Controls.Add(this.karmaButton3);
            this.karmaPanel5.Controls.Add(this.GrupKodu);
            this.karmaPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.karmaPanel5.KarmaAddSirketWhere = false;
            this.karmaPanel5.KarmaAddYilWhere = false;
            this.karmaPanel5.KarmaColumnNames = null;
            this.karmaPanel5.KarmaGridControl = this.GrdStokGrup;
            this.karmaPanel5.KarmaMasterButton = null;
            this.karmaPanel5.KarmaMasterTextBox = this.StokKodu;
            this.karmaPanel5.KarmaSecTextBox = this.GrupKodu;
            this.karmaPanel5.KarmaTableName = "tblStokGrup";
            this.karmaPanel5.Location = new System.Drawing.Point(2, 23);
            this.karmaPanel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.karmaPanel5.Name = "karmaPanel5";
            this.karmaPanel5.ShowCaption = false;
            this.karmaPanel5.Size = new System.Drawing.Size(368, 67);
            this.karmaPanel5.TabIndex = 0;
            // 
            // GrupDeger
            // 
            this.GrupDeger.EnterMoveNextControl = true;
            this.GrupDeger.KarmaAddSirketWhere = false;
            this.GrupDeger.KarmaAddYilWhere = false;
            this.GrupDeger.KarmaFieldName = "Deger";
            this.GrupDeger.KarmaFieldType = KarmaObjects.KarmaFieldTypes.String;
            this.GrupDeger.KarmaLookupDisplayField = "DegerDetay";
            this.GrupDeger.KarmaLookupFilter = null;
            this.GrupDeger.KarmaLookUpTable = "tblStokGrupDetay";
            this.GrupDeger.KarmaLookupValueField = "Deger";
            this.GrupDeger.KarmaMasterFieldName = "GrupKodu";
            this.GrupDeger.KarmaMasterObject = this.GrupKodu;
            this.GrupDeger.KarmaValueType = KarmaObjects.KarmaValueTypes.Lookup;
            this.GrupDeger.Location = new System.Drawing.Point(194, 34);
            this.GrupDeger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrupDeger.Name = "GrupDeger";
            this.GrupDeger.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrupDeger.Properties.Appearance.Options.UseFont = true;
            this.GrupDeger.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GrupDeger.Properties.NullText = "Seçim Yapılmamış";
            this.GrupDeger.Size = new System.Drawing.Size(120, 24);
            this.GrupDeger.TabIndex = 23;
            // 
            // GrupKodu
            // 
            this.GrupKodu.EnterMoveNextControl = true;
            this.GrupKodu.KarmaAddSirketWhere = false;
            this.GrupKodu.KarmaAddYilWhere = false;
            this.GrupKodu.KarmaFieldName = "GrupKodu";
            this.GrupKodu.KarmaFieldType = KarmaObjects.KarmaFieldTypes.String;
            this.GrupKodu.KarmaLookupDisplayField = "GrupAciklama";
            this.GrupKodu.KarmaLookupFilter = null;
            this.GrupKodu.KarmaLookUpTable = "tblStokGrupTanim";
            this.GrupKodu.KarmaLookupValueField = "GrupKodu";
            this.GrupKodu.KarmaMasterFieldName = null;
            this.GrupKodu.KarmaMasterObject = null;
            this.GrupKodu.KarmaValueType = KarmaObjects.KarmaValueTypes.Lookup;
            this.GrupKodu.Location = new System.Drawing.Point(10, 34);
            this.GrupKodu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrupKodu.Name = "GrupKodu";
            this.GrupKodu.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrupKodu.Properties.Appearance.Options.UseFont = true;
            this.GrupKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GrupKodu.Properties.NullText = "Seçim Yapılmamış";
            this.GrupKodu.Size = new System.Drawing.Size(180, 24);
            this.GrupKodu.TabIndex = 0;
            // 
            // karmaLabel9
            // 
            this.karmaLabel9.AutoSize = true;
            this.karmaLabel9.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel9.KarmaFocusControl = null;
            this.karmaLabel9.Location = new System.Drawing.Point(191, 17);
            this.karmaLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.karmaLabel9.Name = "karmaLabel9";
            this.karmaLabel9.ReadOnly = false;
            this.karmaLabel9.Size = new System.Drawing.Size(70, 14);
            this.karmaLabel9.TabIndex = 21;
            this.karmaLabel9.Text = "Grup Değeri";
            // 
            // karmaLabel10
            // 
            this.karmaLabel10.AutoSize = true;
            this.karmaLabel10.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel10.KarmaFocusControl = null;
            this.karmaLabel10.Location = new System.Drawing.Point(10, 17);
            this.karmaLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.karmaLabel10.Name = "karmaLabel10";
            this.karmaLabel10.ReadOnly = false;
            this.karmaLabel10.Size = new System.Drawing.Size(56, 14);
            this.karmaLabel10.TabIndex = 20;
            this.karmaLabel10.Text = "Grup Tipi";
            // 
            // karmaButton3
            // 
            this.karmaButton3.Appearance.ForeColor = System.Drawing.Color.White;
            this.karmaButton3.Appearance.Options.UseForeColor = true;
            this.karmaButton3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.karmaButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("karmaButton3.ImageOptions.SvgImage")));
            this.karmaButton3.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.karmaButton3.KarmaButtonType = KarmaObjects.KarmaButtonTypes.Topluİşlem;
            this.karmaButton3.KarmaMasterPanel = this.karmaPanel5;
            this.karmaButton3.KarmaMasterTextBox = null;
            this.karmaButton3.Location = new System.Drawing.Point(318, 34);
            this.karmaButton3.Margin = new System.Windows.Forms.Padding(0);
            this.karmaButton3.Name = "karmaButton3";
            this.karmaButton3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.karmaButton3.Size = new System.Drawing.Size(36, 25);
            this.karmaButton3.TabIndex = 19;
            this.karmaButton3.TasinabilirMi = false;
            this.karmaButton3.Text = "Kayıt :";
            // 
            // StokKodu
            // 
            this.StokKodu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.StokKodu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.StokKodu.KarmaAddSirketWhere = false;
            this.StokKodu.KarmaAddYilWhere = false;
            this.StokKodu.KarmaFieldName = "StokKodu";
            this.StokKodu.KarmaFieldType = KarmaObjects.KarmaFieldTypes.Guide;
            this.StokKodu.KarmaGuideColumnName = "StokKodu";
            this.StokKodu.KarmaGuideFields = "StokKodu, StokAdi, OlcuBr, AlisKDVOrani, SatisKDVOrani, Aciklama";
            this.StokKodu.KarmaGuideFilter = null;
            this.StokKodu.KarmaGuideName = "Stok Rehberi";
            this.StokKodu.KarmaGuideTableName = "tblStok";
            this.StokKodu.KarmaIsRequired = false;
            this.StokKodu.KarmaLastEdit = false;
            this.StokKodu.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.TamSayi;
            this.StokKodu.KarmaPasswordTextBox = false;
            this.StokKodu.Location = new System.Drawing.Point(143, 26);
            this.StokKodu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StokKodu.Name = "StokKodu";
            this.StokKodu.ReadOnly = false;
            this.StokKodu.Size = new System.Drawing.Size(287, 24);
            this.StokKodu.TabIndex = 1;
            this.StokKodu.Leave += new System.EventHandler(this.karmaTextBox1_Leave);
            // 
            // PnlStokFiyat
            // 
            this.PnlStokFiyat.Controls.Add(this.GrdStokFiyat);
            this.PnlStokFiyat.Controls.Add(this.karmaPanel1);
            this.PnlStokFiyat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlStokFiyat.KarmaAddSirketWhere = false;
            this.PnlStokFiyat.KarmaAddYilWhere = false;
            this.PnlStokFiyat.KarmaColumnNames = null;
            this.PnlStokFiyat.KarmaGridControl = null;
            this.PnlStokFiyat.KarmaMasterButton = null;
            this.PnlStokFiyat.KarmaMasterTextBox = null;
            this.PnlStokFiyat.KarmaSecTextBox = null;
            this.PnlStokFiyat.KarmaTableName = null;
            this.PnlStokFiyat.Location = new System.Drawing.Point(4, 3);
            this.PnlStokFiyat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PnlStokFiyat.Name = "PnlStokFiyat";
            this.PnlStokFiyat.Size = new System.Drawing.Size(372, 390);
            this.PnlStokFiyat.TabIndex = 4;
            this.PnlStokFiyat.Text = "Fiyat Bilgileri";
            // 
            // GrdStokFiyat
            // 
            this.GrdStokFiyat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdStokFiyat.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrdStokFiyat.KarmaAddSirketWhere = false;
            this.GrdStokFiyat.KarmaAddYilWhere = false;
            this.GrdStokFiyat.KarmaSQLCalistir = false;
            this.GrdStokFiyat.KarmaSQLText = null;
            this.GrdStokFiyat.Location = new System.Drawing.Point(2, 90);
            this.GrdStokFiyat.MainView = this.ViewStokFiyat;
            this.GrdStokFiyat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrdStokFiyat.Name = "GrdStokFiyat";
            this.GrdStokFiyat.Size = new System.Drawing.Size(368, 298);
            this.GrdStokFiyat.TabIndex = 1;
            this.GrdStokFiyat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewStokFiyat});
            // 
            // ViewStokFiyat
            // 
            this.ViewStokFiyat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn14});
            this.ViewStokFiyat.DetailHeight = 377;
            this.ViewStokFiyat.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.ViewStokFiyat.GridControl = this.GrdStokFiyat;
            this.ViewStokFiyat.GroupPanelText = "Gruplamak için sütunu sürükleyip buraya bırakın";
            this.ViewStokFiyat.IndicatorWidth = 50;
            this.ViewStokFiyat.Name = "ViewStokFiyat";
            this.ViewStokFiyat.OptionsBehavior.Editable = false;
            this.ViewStokFiyat.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.ViewStokFiyat.OptionsCustomization.AllowGroup = false;
            this.ViewStokFiyat.OptionsFind.AlwaysVisible = true;
            this.ViewStokFiyat.OptionsFind.FindDelay = 100;
            this.ViewStokFiyat.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.ViewStokFiyat.OptionsFind.FindNullPrompt = "Aramak için buraya yazın";
            this.ViewStokFiyat.OptionsFind.ShowFindButton = false;
            this.ViewStokFiyat.OptionsMenu.EnableColumnMenu = false;
            this.ViewStokFiyat.OptionsMenu.EnableGroupPanelMenu = false;
            this.ViewStokFiyat.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Fast;
            this.ViewStokFiyat.OptionsView.ColumnAutoWidth = false;
            this.ViewStokFiyat.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Fiyat Kodu";
            this.gridColumn8.FieldName = "FiyatKodu";
            this.gridColumn8.MinWidth = 23;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Width = 150;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Fiyat";
            this.gridColumn9.DisplayFormat.FormatString = "N2";
            this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn9.FieldName = "Fiyat";
            this.gridColumn9.MinWidth = 23;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            this.gridColumn9.Width = 248;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Fiyat Kodu";
            this.gridColumn14.FieldName = "FiyatAciklama";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 0;
            // 
            // karmaPanel1
            // 
            this.karmaPanel1.Controls.Add(this.FiyatKodu);
            this.karmaPanel1.Controls.Add(this.karmaLabel8);
            this.karmaPanel1.Controls.Add(this.karmaLabel7);
            this.karmaPanel1.Controls.Add(this.karmaButton2);
            this.karmaPanel1.Controls.Add(this.Fiyat);
            this.karmaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.karmaPanel1.KarmaAddSirketWhere = false;
            this.karmaPanel1.KarmaAddYilWhere = false;
            this.karmaPanel1.KarmaColumnNames = null;
            this.karmaPanel1.KarmaGridControl = this.GrdStokFiyat;
            this.karmaPanel1.KarmaMasterButton = null;
            this.karmaPanel1.KarmaMasterTextBox = this.StokKodu;
            this.karmaPanel1.KarmaSecTextBox = this.FiyatKodu;
            this.karmaPanel1.KarmaTableName = "tblStokFiyat";
            this.karmaPanel1.Location = new System.Drawing.Point(2, 23);
            this.karmaPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.karmaPanel1.Name = "karmaPanel1";
            this.karmaPanel1.ShowCaption = false;
            this.karmaPanel1.Size = new System.Drawing.Size(368, 67);
            this.karmaPanel1.TabIndex = 0;
            // 
            // FiyatKodu
            // 
            this.FiyatKodu.EnterMoveNextControl = true;
            this.FiyatKodu.KarmaAddSirketWhere = false;
            this.FiyatKodu.KarmaAddYilWhere = false;
            this.FiyatKodu.KarmaFieldName = "FiyatKodu";
            this.FiyatKodu.KarmaFieldType = KarmaObjects.KarmaFieldTypes.String;
            this.FiyatKodu.KarmaLookupDisplayField = "FiyatAciklama";
            this.FiyatKodu.KarmaLookupFilter = null;
            this.FiyatKodu.KarmaLookUpTable = "tblFiyatTanim";
            this.FiyatKodu.KarmaLookupValueField = "FiyatKodu";
            this.FiyatKodu.KarmaMasterFieldName = null;
            this.FiyatKodu.KarmaMasterObject = null;
            this.FiyatKodu.KarmaValueType = KarmaObjects.KarmaValueTypes.Lookup;
            this.FiyatKodu.Location = new System.Drawing.Point(13, 34);
            this.FiyatKodu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FiyatKodu.Name = "FiyatKodu";
            this.FiyatKodu.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FiyatKodu.Properties.Appearance.Options.UseFont = true;
            this.FiyatKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FiyatKodu.Properties.NullText = "";
            this.FiyatKodu.Size = new System.Drawing.Size(180, 24);
            this.FiyatKodu.TabIndex = 23;
            // 
            // karmaLabel8
            // 
            this.karmaLabel8.AutoSize = true;
            this.karmaLabel8.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel8.KarmaFocusControl = null;
            this.karmaLabel8.Location = new System.Drawing.Point(198, 17);
            this.karmaLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.karmaLabel8.Name = "karmaLabel8";
            this.karmaLabel8.ReadOnly = false;
            this.karmaLabel8.Size = new System.Drawing.Size(34, 14);
            this.karmaLabel8.TabIndex = 21;
            this.karmaLabel8.Text = "Fiyat";
            // 
            // karmaLabel7
            // 
            this.karmaLabel7.AutoSize = true;
            this.karmaLabel7.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel7.KarmaFocusControl = null;
            this.karmaLabel7.Location = new System.Drawing.Point(10, 17);
            this.karmaLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.karmaLabel7.Name = "karmaLabel7";
            this.karmaLabel7.ReadOnly = false;
            this.karmaLabel7.Size = new System.Drawing.Size(66, 14);
            this.karmaLabel7.TabIndex = 20;
            this.karmaLabel7.Text = "Fiyat Kodu";
            // 
            // karmaButton2
            // 
            this.karmaButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.karmaButton2.Appearance.Options.UseForeColor = true;
            this.karmaButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.karmaButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("karmaButton2.ImageOptions.SvgImage")));
            this.karmaButton2.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.karmaButton2.KarmaButtonType = KarmaObjects.KarmaButtonTypes.Topluİşlem;
            this.karmaButton2.KarmaMasterPanel = this.karmaPanel1;
            this.karmaButton2.KarmaMasterTextBox = this.Fiyat;
            this.karmaButton2.Location = new System.Drawing.Point(322, 34);
            this.karmaButton2.Margin = new System.Windows.Forms.Padding(0);
            this.karmaButton2.Name = "karmaButton2";
            this.karmaButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.karmaButton2.Size = new System.Drawing.Size(36, 25);
            this.karmaButton2.TabIndex = 19;
            this.karmaButton2.TasinabilirMi = false;
            this.karmaButton2.Text = "Kayıt :";
            // 
            // Fiyat
            // 
            this.Fiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Fiyat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Fiyat.KarmaAddSirketWhere = false;
            this.Fiyat.KarmaAddYilWhere = false;
            this.Fiyat.KarmaFieldName = "Fiyat";
            this.Fiyat.KarmaFieldType = KarmaObjects.KarmaFieldTypes.Numeric;
            this.Fiyat.KarmaGuideColumnName = null;
            this.Fiyat.KarmaGuideFields = null;
            this.Fiyat.KarmaGuideFilter = null;
            this.Fiyat.KarmaGuideName = null;
            this.Fiyat.KarmaGuideTableName = null;
            this.Fiyat.KarmaIsRequired = false;
            this.Fiyat.KarmaLastEdit = false;
            this.Fiyat.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.Fiyat;
            this.Fiyat.KarmaPasswordTextBox = false;
            this.Fiyat.Location = new System.Drawing.Point(198, 34);
            this.Fiyat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.ReadOnly = false;
            this.Fiyat.Size = new System.Drawing.Size(120, 24);
            this.Fiyat.TabIndex = 1;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.tableLayoutPanel2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabPage2.Size = new System.Drawing.Size(1152, 396);
            this.xtraTabPage2.Text = "Kontrol ve Ayarlar";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.PnlStokPlan, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.PnlStokAyar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1152, 396);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // PnlStokPlan
            // 
            this.PnlStokPlan.Controls.Add(this.KritikStokUyar);
            this.PnlStokPlan.Controls.Add(this.karmaLabel23);
            this.PnlStokPlan.Controls.Add(this.SatisSipDahil);
            this.PnlStokPlan.Controls.Add(this.karmaLabel22);
            this.PnlStokPlan.Controls.Add(this.AlisSipDahil);
            this.PnlStokPlan.Controls.Add(this.karmaLabel21);
            this.PnlStokPlan.Controls.Add(this.MaxStok);
            this.PnlStokPlan.Controls.Add(this.karmaLabel20);
            this.PnlStokPlan.Controls.Add(this.MaxStokTakibi);
            this.PnlStokPlan.Controls.Add(this.MinStokTakibi);
            this.PnlStokPlan.Controls.Add(this.karmaLabel18);
            this.PnlStokPlan.Controls.Add(this.karmaLabel19);
            this.PnlStokPlan.Controls.Add(this.MinStok);
            this.PnlStokPlan.Controls.Add(this.karmaLabel17);
            this.PnlStokPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlStokPlan.KarmaAddSirketWhere = false;
            this.PnlStokPlan.KarmaAddYilWhere = false;
            this.PnlStokPlan.KarmaColumnNames = null;
            this.PnlStokPlan.KarmaGridControl = null;
            this.PnlStokPlan.KarmaMasterButton = null;
            this.PnlStokPlan.KarmaMasterTextBox = this.StokKodu;
            this.PnlStokPlan.KarmaSecTextBox = null;
            this.PnlStokPlan.KarmaTableName = "tblStokPlan";
            this.PnlStokPlan.Location = new System.Drawing.Point(383, 3);
            this.PnlStokPlan.Name = "PnlStokPlan";
            this.PnlStokPlan.Size = new System.Drawing.Size(374, 390);
            this.PnlStokPlan.TabIndex = 8;
            this.PnlStokPlan.Text = "Kontrol Seçenekleri";
            // 
            // KritikStokUyar
            // 
            this.KritikStokUyar.EnterMoveNextControl = true;
            this.KritikStokUyar.KarmaCheckedText = "Evet";
            this.KritikStokUyar.KarmaCheckedValue = "true";
            this.KritikStokUyar.KarmaFieldName = "KritikStokUyar";
            this.KritikStokUyar.KarmaIsRequired = false;
            this.KritikStokUyar.KarmaUnCheckedText = "Hayır";
            this.KritikStokUyar.KarmaUnCheckedValue = "false";
            this.KritikStokUyar.Location = new System.Drawing.Point(239, 225);
            this.KritikStokUyar.Name = "KritikStokUyar";
            this.KritikStokUyar.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 11F);
            this.KritikStokUyar.Properties.Appearance.Options.UseFont = true;
            this.KritikStokUyar.Properties.OffText = "Hayır";
            this.KritikStokUyar.Properties.OnText = "Evet";
            this.KritikStokUyar.Properties.ValueOff = "false";
            this.KritikStokUyar.Properties.ValueOn = "true";
            this.KritikStokUyar.Size = new System.Drawing.Size(130, 22);
            this.KritikStokUyar.TabIndex = 21;
            // 
            // karmaLabel23
            // 
            this.karmaLabel23.AutoSize = true;
            this.karmaLabel23.Font = new System.Drawing.Font("Roboto", 11F);
            this.karmaLabel23.KarmaFocusControl = null;
            this.karmaLabel23.Location = new System.Drawing.Point(8, 227);
            this.karmaLabel23.Name = "karmaLabel23";
            this.karmaLabel23.ReadOnly = false;
            this.karmaLabel23.Size = new System.Drawing.Size(140, 18);
            this.karmaLabel23.TabIndex = 20;
            this.karmaLabel23.Text = "Kritik Stok Bildirimi";
            // 
            // SatisSipDahil
            // 
            this.SatisSipDahil.EnterMoveNextControl = true;
            this.SatisSipDahil.KarmaCheckedText = "Evet";
            this.SatisSipDahil.KarmaCheckedValue = "true";
            this.SatisSipDahil.KarmaFieldName = "SatisSipDahil";
            this.SatisSipDahil.KarmaIsRequired = false;
            this.SatisSipDahil.KarmaUnCheckedText = "Hayır";
            this.SatisSipDahil.KarmaUnCheckedValue = "false";
            this.SatisSipDahil.Location = new System.Drawing.Point(239, 197);
            this.SatisSipDahil.Name = "SatisSipDahil";
            this.SatisSipDahil.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 11F);
            this.SatisSipDahil.Properties.Appearance.Options.UseFont = true;
            this.SatisSipDahil.Properties.OffText = "Hayır";
            this.SatisSipDahil.Properties.OnText = "Evet";
            this.SatisSipDahil.Properties.ValueOff = "false";
            this.SatisSipDahil.Properties.ValueOn = "true";
            this.SatisSipDahil.Size = new System.Drawing.Size(130, 22);
            this.SatisSipDahil.TabIndex = 19;
            // 
            // karmaLabel22
            // 
            this.karmaLabel22.AutoSize = true;
            this.karmaLabel22.Font = new System.Drawing.Font("Roboto", 11F);
            this.karmaLabel22.KarmaFocusControl = null;
            this.karmaLabel22.Location = new System.Drawing.Point(8, 199);
            this.karmaLabel22.Name = "karmaLabel22";
            this.karmaLabel22.ReadOnly = false;
            this.karmaLabel22.Size = new System.Drawing.Size(176, 18);
            this.karmaLabel22.TabIndex = 18;
            this.karmaLabel22.Text = "Bak. Sipariş Dahil(Satıcı)";
            // 
            // AlisSipDahil
            // 
            this.AlisSipDahil.EnterMoveNextControl = true;
            this.AlisSipDahil.KarmaCheckedText = "Evet";
            this.AlisSipDahil.KarmaCheckedValue = "true";
            this.AlisSipDahil.KarmaFieldName = "AlisSipDahil";
            this.AlisSipDahil.KarmaIsRequired = false;
            this.AlisSipDahil.KarmaUnCheckedText = "Hayır";
            this.AlisSipDahil.KarmaUnCheckedValue = "false";
            this.AlisSipDahil.Location = new System.Drawing.Point(239, 169);
            this.AlisSipDahil.Name = "AlisSipDahil";
            this.AlisSipDahil.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 11F);
            this.AlisSipDahil.Properties.Appearance.Options.UseFont = true;
            this.AlisSipDahil.Properties.OffText = "Hayır";
            this.AlisSipDahil.Properties.OnText = "Evet";
            this.AlisSipDahil.Properties.ValueOff = "false";
            this.AlisSipDahil.Properties.ValueOn = "true";
            this.AlisSipDahil.Size = new System.Drawing.Size(130, 22);
            this.AlisSipDahil.TabIndex = 17;
            // 
            // karmaLabel21
            // 
            this.karmaLabel21.AutoSize = true;
            this.karmaLabel21.Font = new System.Drawing.Font("Roboto", 11F);
            this.karmaLabel21.KarmaFocusControl = null;
            this.karmaLabel21.Location = new System.Drawing.Point(8, 171);
            this.karmaLabel21.Name = "karmaLabel21";
            this.karmaLabel21.ReadOnly = false;
            this.karmaLabel21.Size = new System.Drawing.Size(190, 18);
            this.karmaLabel21.TabIndex = 16;
            this.karmaLabel21.Text = "Bak. Sipariş Dahil(Müşteri)";
            // 
            // MaxStok
            // 
            this.MaxStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MaxStok.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.MaxStok.KarmaAddSirketWhere = false;
            this.MaxStok.KarmaAddYilWhere = false;
            this.MaxStok.KarmaFieldName = "MaxStok";
            this.MaxStok.KarmaFieldType = KarmaObjects.KarmaFieldTypes.Numeric;
            this.MaxStok.KarmaGuideColumnName = null;
            this.MaxStok.KarmaGuideFields = null;
            this.MaxStok.KarmaGuideFilter = null;
            this.MaxStok.KarmaGuideName = null;
            this.MaxStok.KarmaGuideTableName = null;
            this.MaxStok.KarmaIsRequired = false;
            this.MaxStok.KarmaLastEdit = false;
            this.MaxStok.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.Miktar;
            this.MaxStok.KarmaPasswordTextBox = false;
            this.MaxStok.Location = new System.Drawing.Point(239, 139);
            this.MaxStok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaxStok.Name = "MaxStok";
            this.MaxStok.ReadOnly = false;
            this.MaxStok.Size = new System.Drawing.Size(129, 24);
            this.MaxStok.TabIndex = 15;
            // 
            // karmaLabel20
            // 
            this.karmaLabel20.AutoSize = true;
            this.karmaLabel20.Font = new System.Drawing.Font("Roboto", 11F);
            this.karmaLabel20.KarmaFocusControl = null;
            this.karmaLabel20.Location = new System.Drawing.Point(8, 141);
            this.karmaLabel20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.karmaLabel20.Name = "karmaLabel20";
            this.karmaLabel20.ReadOnly = false;
            this.karmaLabel20.Size = new System.Drawing.Size(119, 18);
            this.karmaLabel20.TabIndex = 14;
            this.karmaLabel20.Text = "Maksimum Stok";
            // 
            // MaxStokTakibi
            // 
            this.MaxStokTakibi.EnterMoveNextControl = true;
            this.MaxStokTakibi.KarmaCheckedText = "Evet";
            this.MaxStokTakibi.KarmaCheckedValue = "true";
            this.MaxStokTakibi.KarmaFieldName = "MaxStokTakibi";
            this.MaxStokTakibi.KarmaIsRequired = false;
            this.MaxStokTakibi.KarmaUnCheckedText = "Hayır";
            this.MaxStokTakibi.KarmaUnCheckedValue = "false";
            this.MaxStokTakibi.Location = new System.Drawing.Point(239, 81);
            this.MaxStokTakibi.Name = "MaxStokTakibi";
            this.MaxStokTakibi.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 11F);
            this.MaxStokTakibi.Properties.Appearance.Options.UseFont = true;
            this.MaxStokTakibi.Properties.OffText = "Hayır";
            this.MaxStokTakibi.Properties.OnText = "Evet";
            this.MaxStokTakibi.Properties.ValueOff = "false";
            this.MaxStokTakibi.Properties.ValueOn = "true";
            this.MaxStokTakibi.Size = new System.Drawing.Size(130, 22);
            this.MaxStokTakibi.TabIndex = 13;
            // 
            // MinStokTakibi
            // 
            this.MinStokTakibi.EnterMoveNextControl = true;
            this.MinStokTakibi.KarmaCheckedText = "Evet";
            this.MinStokTakibi.KarmaCheckedValue = "true";
            this.MinStokTakibi.KarmaFieldName = "MinStokTakibi";
            this.MinStokTakibi.KarmaIsRequired = false;
            this.MinStokTakibi.KarmaUnCheckedText = "Hayır";
            this.MinStokTakibi.KarmaUnCheckedValue = "false";
            this.MinStokTakibi.Location = new System.Drawing.Point(239, 53);
            this.MinStokTakibi.Name = "MinStokTakibi";
            this.MinStokTakibi.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 11F);
            this.MinStokTakibi.Properties.Appearance.Options.UseFont = true;
            this.MinStokTakibi.Properties.OffText = "Hayır";
            this.MinStokTakibi.Properties.OnText = "Evet";
            this.MinStokTakibi.Properties.ValueOff = "false";
            this.MinStokTakibi.Properties.ValueOn = "true";
            this.MinStokTakibi.Size = new System.Drawing.Size(130, 22);
            this.MinStokTakibi.TabIndex = 12;
            // 
            // karmaLabel18
            // 
            this.karmaLabel18.AutoSize = true;
            this.karmaLabel18.Font = new System.Drawing.Font("Roboto", 11F);
            this.karmaLabel18.KarmaFocusControl = null;
            this.karmaLabel18.Location = new System.Drawing.Point(8, 83);
            this.karmaLabel18.Name = "karmaLabel18";
            this.karmaLabel18.ReadOnly = false;
            this.karmaLabel18.Size = new System.Drawing.Size(130, 18);
            this.karmaLabel18.TabIndex = 11;
            this.karmaLabel18.Text = "Maks. Stok Takibi";
            // 
            // karmaLabel19
            // 
            this.karmaLabel19.AutoSize = true;
            this.karmaLabel19.Font = new System.Drawing.Font("Roboto", 11F);
            this.karmaLabel19.KarmaFocusControl = null;
            this.karmaLabel19.Location = new System.Drawing.Point(8, 55);
            this.karmaLabel19.Name = "karmaLabel19";
            this.karmaLabel19.ReadOnly = false;
            this.karmaLabel19.Size = new System.Drawing.Size(119, 18);
            this.karmaLabel19.TabIndex = 10;
            this.karmaLabel19.Text = "Min. Stok Takibi";
            // 
            // MinStok
            // 
            this.MinStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MinStok.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.MinStok.KarmaAddSirketWhere = false;
            this.MinStok.KarmaAddYilWhere = false;
            this.MinStok.KarmaFieldName = "MinStok";
            this.MinStok.KarmaFieldType = KarmaObjects.KarmaFieldTypes.Numeric;
            this.MinStok.KarmaGuideColumnName = null;
            this.MinStok.KarmaGuideFields = null;
            this.MinStok.KarmaGuideFilter = null;
            this.MinStok.KarmaGuideName = null;
            this.MinStok.KarmaGuideTableName = null;
            this.MinStok.KarmaIsRequired = false;
            this.MinStok.KarmaLastEdit = false;
            this.MinStok.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.Miktar;
            this.MinStok.KarmaPasswordTextBox = false;
            this.MinStok.Location = new System.Drawing.Point(239, 109);
            this.MinStok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinStok.Name = "MinStok";
            this.MinStok.ReadOnly = false;
            this.MinStok.Size = new System.Drawing.Size(129, 24);
            this.MinStok.TabIndex = 9;
            // 
            // karmaLabel17
            // 
            this.karmaLabel17.AutoSize = true;
            this.karmaLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.karmaLabel17.KarmaFocusControl = null;
            this.karmaLabel17.Location = new System.Drawing.Point(8, 111);
            this.karmaLabel17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.karmaLabel17.Name = "karmaLabel17";
            this.karmaLabel17.ReadOnly = false;
            this.karmaLabel17.Size = new System.Drawing.Size(108, 18);
            this.karmaLabel17.TabIndex = 8;
            this.karmaLabel17.Text = "Minimum Stok";
            // 
            // PnlStokAyar
            // 
            this.PnlStokAyar.Controls.Add(this.TalepYok);
            this.PnlStokAyar.Controls.Add(this.TeklifYok);
            this.PnlStokAyar.Controls.Add(this.SiparisYok);
            this.PnlStokAyar.Controls.Add(this.AlisYapilmaz);
            this.PnlStokAyar.Controls.Add(this.SatisYapilmaz);
            this.PnlStokAyar.Controls.Add(this.PasifStok);
            this.PnlStokAyar.Controls.Add(this.karmaLabel16);
            this.PnlStokAyar.Controls.Add(this.karmaLabel15);
            this.PnlStokAyar.Controls.Add(this.karmaLabel14);
            this.PnlStokAyar.Controls.Add(this.karmaLabel13);
            this.PnlStokAyar.Controls.Add(this.karmaLabel12);
            this.PnlStokAyar.Controls.Add(this.karmaLabel11);
            this.PnlStokAyar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlStokAyar.KarmaAddSirketWhere = false;
            this.PnlStokAyar.KarmaAddYilWhere = false;
            this.PnlStokAyar.KarmaColumnNames = null;
            this.PnlStokAyar.KarmaGridControl = null;
            this.PnlStokAyar.KarmaMasterButton = null;
            this.PnlStokAyar.KarmaMasterTextBox = this.StokKodu;
            this.PnlStokAyar.KarmaSecTextBox = null;
            this.PnlStokAyar.KarmaTableName = "tblStokAyar";
            this.PnlStokAyar.Location = new System.Drawing.Point(3, 3);
            this.PnlStokAyar.Name = "PnlStokAyar";
            this.PnlStokAyar.Size = new System.Drawing.Size(374, 390);
            this.PnlStokAyar.TabIndex = 7;
            this.PnlStokAyar.Text = "Stok Ayarları";
            // 
            // TalepYok
            // 
            this.TalepYok.EnterMoveNextControl = true;
            this.TalepYok.KarmaCheckedText = "Evet";
            this.TalepYok.KarmaCheckedValue = "true";
            this.TalepYok.KarmaFieldName = "TalepYok";
            this.TalepYok.KarmaIsRequired = false;
            this.TalepYok.KarmaUnCheckedText = "Hayır";
            this.TalepYok.KarmaUnCheckedValue = "false";
            this.TalepYok.Location = new System.Drawing.Point(239, 193);
            this.TalepYok.Name = "TalepYok";
            this.TalepYok.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 11F);
            this.TalepYok.Properties.Appearance.Options.UseFont = true;
            this.TalepYok.Properties.OffText = "Hayır";
            this.TalepYok.Properties.OnText = "Evet";
            this.TalepYok.Properties.ValueOff = "false";
            this.TalepYok.Properties.ValueOn = "true";
            this.TalepYok.Size = new System.Drawing.Size(130, 22);
            this.TalepYok.TabIndex = 11;
            // 
            // TeklifYok
            // 
            this.TeklifYok.EnterMoveNextControl = true;
            this.TeklifYok.KarmaCheckedText = "Evet";
            this.TeklifYok.KarmaCheckedValue = "true";
            this.TeklifYok.KarmaFieldName = "TeklifYok";
            this.TeklifYok.KarmaIsRequired = false;
            this.TeklifYok.KarmaUnCheckedText = "Hayır";
            this.TeklifYok.KarmaUnCheckedValue = "false";
            this.TeklifYok.Location = new System.Drawing.Point(239, 165);
            this.TeklifYok.Name = "TeklifYok";
            this.TeklifYok.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 11F);
            this.TeklifYok.Properties.Appearance.Options.UseFont = true;
            this.TeklifYok.Properties.OffText = "Hayır";
            this.TeklifYok.Properties.OnText = "Evet";
            this.TeklifYok.Properties.ValueOff = "false";
            this.TeklifYok.Properties.ValueOn = "true";
            this.TeklifYok.Size = new System.Drawing.Size(130, 22);
            this.TeklifYok.TabIndex = 10;
            // 
            // SiparisYok
            // 
            this.SiparisYok.EnterMoveNextControl = true;
            this.SiparisYok.KarmaCheckedText = "Evet";
            this.SiparisYok.KarmaCheckedValue = "true";
            this.SiparisYok.KarmaFieldName = "SiparisYok";
            this.SiparisYok.KarmaIsRequired = false;
            this.SiparisYok.KarmaUnCheckedText = "Hayır";
            this.SiparisYok.KarmaUnCheckedValue = "false";
            this.SiparisYok.Location = new System.Drawing.Point(239, 137);
            this.SiparisYok.Name = "SiparisYok";
            this.SiparisYok.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 11F);
            this.SiparisYok.Properties.Appearance.Options.UseFont = true;
            this.SiparisYok.Properties.OffText = "Hayır";
            this.SiparisYok.Properties.OnText = "Evet";
            this.SiparisYok.Properties.ValueOff = "false";
            this.SiparisYok.Properties.ValueOn = "true";
            this.SiparisYok.Size = new System.Drawing.Size(130, 22);
            this.SiparisYok.TabIndex = 9;
            // 
            // AlisYapilmaz
            // 
            this.AlisYapilmaz.EnterMoveNextControl = true;
            this.AlisYapilmaz.KarmaCheckedText = "Evet";
            this.AlisYapilmaz.KarmaCheckedValue = "true";
            this.AlisYapilmaz.KarmaFieldName = "AlisYapilmaz";
            this.AlisYapilmaz.KarmaIsRequired = false;
            this.AlisYapilmaz.KarmaUnCheckedText = "Hayır";
            this.AlisYapilmaz.KarmaUnCheckedValue = "false";
            this.AlisYapilmaz.Location = new System.Drawing.Point(239, 109);
            this.AlisYapilmaz.Name = "AlisYapilmaz";
            this.AlisYapilmaz.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 11F);
            this.AlisYapilmaz.Properties.Appearance.Options.UseFont = true;
            this.AlisYapilmaz.Properties.OffText = "Hayır";
            this.AlisYapilmaz.Properties.OnText = "Evet";
            this.AlisYapilmaz.Properties.ValueOff = "false";
            this.AlisYapilmaz.Properties.ValueOn = "true";
            this.AlisYapilmaz.Size = new System.Drawing.Size(130, 22);
            this.AlisYapilmaz.TabIndex = 8;
            // 
            // SatisYapilmaz
            // 
            this.SatisYapilmaz.EnterMoveNextControl = true;
            this.SatisYapilmaz.KarmaCheckedText = "Evet";
            this.SatisYapilmaz.KarmaCheckedValue = "true";
            this.SatisYapilmaz.KarmaFieldName = "SatisYapilmaz";
            this.SatisYapilmaz.KarmaIsRequired = false;
            this.SatisYapilmaz.KarmaUnCheckedText = "Hayır";
            this.SatisYapilmaz.KarmaUnCheckedValue = "false";
            this.SatisYapilmaz.Location = new System.Drawing.Point(239, 81);
            this.SatisYapilmaz.Name = "SatisYapilmaz";
            this.SatisYapilmaz.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 11F);
            this.SatisYapilmaz.Properties.Appearance.Options.UseFont = true;
            this.SatisYapilmaz.Properties.OffText = "Hayır";
            this.SatisYapilmaz.Properties.OnText = "Evet";
            this.SatisYapilmaz.Properties.ValueOff = "false";
            this.SatisYapilmaz.Properties.ValueOn = "true";
            this.SatisYapilmaz.Size = new System.Drawing.Size(130, 22);
            this.SatisYapilmaz.TabIndex = 7;
            // 
            // PasifStok
            // 
            this.PasifStok.EnterMoveNextControl = true;
            this.PasifStok.KarmaCheckedText = "Evet";
            this.PasifStok.KarmaCheckedValue = "true";
            this.PasifStok.KarmaFieldName = "PasifStok";
            this.PasifStok.KarmaIsRequired = false;
            this.PasifStok.KarmaUnCheckedText = "Hayır";
            this.PasifStok.KarmaUnCheckedValue = "false";
            this.PasifStok.Location = new System.Drawing.Point(239, 53);
            this.PasifStok.Name = "PasifStok";
            this.PasifStok.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 11F);
            this.PasifStok.Properties.Appearance.Options.UseFont = true;
            this.PasifStok.Properties.OffText = "Hayır";
            this.PasifStok.Properties.OnText = "Evet";
            this.PasifStok.Properties.ValueOff = "false";
            this.PasifStok.Properties.ValueOn = "true";
            this.PasifStok.Size = new System.Drawing.Size(130, 22);
            this.PasifStok.TabIndex = 6;
            // 
            // karmaLabel16
            // 
            this.karmaLabel16.AutoSize = true;
            this.karmaLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.karmaLabel16.KarmaFocusControl = null;
            this.karmaLabel16.Location = new System.Drawing.Point(8, 195);
            this.karmaLabel16.Name = "karmaLabel16";
            this.karmaLabel16.ReadOnly = false;
            this.karmaLabel16.Size = new System.Drawing.Size(101, 18);
            this.karmaLabel16.TabIndex = 5;
            this.karmaLabel16.Text = "Talebe Kapalı";
            // 
            // karmaLabel15
            // 
            this.karmaLabel15.AutoSize = true;
            this.karmaLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.karmaLabel15.KarmaFocusControl = null;
            this.karmaLabel15.Location = new System.Drawing.Point(8, 167);
            this.karmaLabel15.Name = "karmaLabel15";
            this.karmaLabel15.ReadOnly = false;
            this.karmaLabel15.Size = new System.Drawing.Size(101, 18);
            this.karmaLabel15.TabIndex = 4;
            this.karmaLabel15.Text = "Teklife Kapalı";
            // 
            // karmaLabel14
            // 
            this.karmaLabel14.AutoSize = true;
            this.karmaLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.karmaLabel14.KarmaFocusControl = null;
            this.karmaLabel14.Location = new System.Drawing.Point(8, 137);
            this.karmaLabel14.Name = "karmaLabel14";
            this.karmaLabel14.ReadOnly = false;
            this.karmaLabel14.Size = new System.Drawing.Size(110, 18);
            this.karmaLabel14.TabIndex = 3;
            this.karmaLabel14.Text = "Siparişe Kapalı";
            // 
            // karmaLabel13
            // 
            this.karmaLabel13.AutoSize = true;
            this.karmaLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.karmaLabel13.KarmaFocusControl = null;
            this.karmaLabel13.Location = new System.Drawing.Point(8, 109);
            this.karmaLabel13.Name = "karmaLabel13";
            this.karmaLabel13.ReadOnly = false;
            this.karmaLabel13.Size = new System.Drawing.Size(88, 18);
            this.karmaLabel13.TabIndex = 2;
            this.karmaLabel13.Text = "Alışa Kapalı";
            // 
            // karmaLabel12
            // 
            this.karmaLabel12.AutoSize = true;
            this.karmaLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.karmaLabel12.KarmaFocusControl = null;
            this.karmaLabel12.Location = new System.Drawing.Point(8, 81);
            this.karmaLabel12.Name = "karmaLabel12";
            this.karmaLabel12.ReadOnly = false;
            this.karmaLabel12.Size = new System.Drawing.Size(97, 18);
            this.karmaLabel12.TabIndex = 1;
            this.karmaLabel12.Text = "Satışa Kapalı";
            // 
            // karmaLabel11
            // 
            this.karmaLabel11.AutoSize = true;
            this.karmaLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.karmaLabel11.KarmaFocusControl = null;
            this.karmaLabel11.Location = new System.Drawing.Point(8, 53);
            this.karmaLabel11.Name = "karmaLabel11";
            this.karmaLabel11.ReadOnly = false;
            this.karmaLabel11.Size = new System.Drawing.Size(78, 18);
            this.karmaLabel11.TabIndex = 0;
            this.karmaLabel11.Text = "Pasif Stok";
            // 
            // PnlStokMas
            // 
            this.PnlStokMas.Controls.Add(this.karmaButton1);
            this.PnlStokMas.Controls.Add(this.StokAciklama);
            this.PnlStokMas.Controls.Add(this.SKdv);
            this.PnlStokMas.Controls.Add(this.AKdv);
            this.PnlStokMas.Controls.Add(this.OlcuBr);
            this.PnlStokMas.Controls.Add(this.karmaLabel6);
            this.PnlStokMas.Controls.Add(this.StokAdi);
            this.PnlStokMas.Controls.Add(this.karmaLabel5);
            this.PnlStokMas.Controls.Add(this.karmaLabel4);
            this.PnlStokMas.Controls.Add(this.karmaLabel3);
            this.PnlStokMas.Controls.Add(this.karmaLabel2);
            this.PnlStokMas.Controls.Add(this.StokKodu);
            this.PnlStokMas.Controls.Add(this.karmaLabel1);
            this.PnlStokMas.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlStokMas.KarmaAddSirketWhere = false;
            this.PnlStokMas.KarmaAddYilWhere = false;
            this.PnlStokMas.KarmaColumnNames = null;
            this.PnlStokMas.KarmaGridControl = this.GrdStoklar;
            this.PnlStokMas.KarmaMasterButton = null;
            this.PnlStokMas.KarmaMasterTextBox = this.StokKodu;
            this.PnlStokMas.KarmaSecTextBox = null;
            this.PnlStokMas.KarmaTableName = "tblStok";
            this.PnlStokMas.Location = new System.Drawing.Point(0, 0);
            this.PnlStokMas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PnlStokMas.Name = "PnlStokMas";
            this.PnlStokMas.Size = new System.Drawing.Size(1154, 218);
            this.PnlStokMas.TabIndex = 0;
            this.PnlStokMas.Text = "Genel Bilgiler";
            // 
            // karmaButton1
            // 
            this.karmaButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.karmaButton1.Appearance.Options.UseForeColor = true;
            this.karmaButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.karmaButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("karmaButton1.ImageOptions.SvgImage")));
            this.karmaButton1.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.karmaButton1.KarmaButtonType = KarmaObjects.KarmaButtonTypes.Topluİşlem;
            this.karmaButton1.KarmaMasterPanel = this.PnlStokMas;
            this.karmaButton1.KarmaMasterTextBox = this.StokAciklama;
            this.karmaButton1.Location = new System.Drawing.Point(434, 163);
            this.karmaButton1.Margin = new System.Windows.Forms.Padding(0);
            this.karmaButton1.Name = "karmaButton1";
            this.karmaButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.karmaButton1.Size = new System.Drawing.Size(36, 25);
            this.karmaButton1.TabIndex = 18;
            this.karmaButton1.TasinabilirMi = false;
            this.karmaButton1.Text = "Kayıt :";
            // 
            // StokAciklama
            // 
            this.StokAciklama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.StokAciklama.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.StokAciklama.KarmaAddSirketWhere = false;
            this.StokAciklama.KarmaAddYilWhere = false;
            this.StokAciklama.KarmaFieldName = "Aciklama";
            this.StokAciklama.KarmaFieldType = KarmaObjects.KarmaFieldTypes.String;
            this.StokAciklama.KarmaGuideColumnName = null;
            this.StokAciklama.KarmaGuideFields = null;
            this.StokAciklama.KarmaGuideFilter = null;
            this.StokAciklama.KarmaGuideName = null;
            this.StokAciklama.KarmaGuideTableName = null;
            this.StokAciklama.KarmaIsRequired = false;
            this.StokAciklama.KarmaLastEdit = true;
            this.StokAciklama.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.TamSayi;
            this.StokAciklama.KarmaPasswordTextBox = false;
            this.StokAciklama.Location = new System.Drawing.Point(143, 163);
            this.StokAciklama.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StokAciklama.Name = "StokAciklama";
            this.StokAciklama.ReadOnly = false;
            this.StokAciklama.Size = new System.Drawing.Size(287, 24);
            this.StokAciklama.TabIndex = 12;
            // 
            // SKdv
            // 
            this.SKdv.EnterMoveNextControl = true;
            this.SKdv.KarmaAddSirketWhere = false;
            this.SKdv.KarmaAddYilWhere = false;
            this.SKdv.KarmaFieldName = "SatisKDVOrani";
            this.SKdv.KarmaFieldType = KarmaObjects.KarmaFieldTypes.Numeric;
            this.SKdv.KarmaLookupDisplayField = "Aciklama";
            this.SKdv.KarmaLookupFilter = null;
            this.SKdv.KarmaLookUpTable = "tblKDVTanim";
            this.SKdv.KarmaLookupValueField = "KDVKodu";
            this.SKdv.KarmaMasterFieldName = null;
            this.SKdv.KarmaMasterObject = null;
            this.SKdv.KarmaValueType = KarmaObjects.KarmaValueTypes.Lookup;
            this.SKdv.Location = new System.Drawing.Point(143, 136);
            this.SKdv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SKdv.Name = "SKdv";
            this.SKdv.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SKdv.Properties.Appearance.Options.UseFont = true;
            this.SKdv.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SKdv.Properties.NullText = "";
            this.SKdv.Size = new System.Drawing.Size(117, 24);
            this.SKdv.TabIndex = 11;
            // 
            // AKdv
            // 
            this.AKdv.EnterMoveNextControl = true;
            this.AKdv.KarmaAddSirketWhere = false;
            this.AKdv.KarmaAddYilWhere = false;
            this.AKdv.KarmaFieldName = "AlisKDVOrani";
            this.AKdv.KarmaFieldType = KarmaObjects.KarmaFieldTypes.Numeric;
            this.AKdv.KarmaLookupDisplayField = "Aciklama";
            this.AKdv.KarmaLookupFilter = null;
            this.AKdv.KarmaLookUpTable = "tblKDVTanim";
            this.AKdv.KarmaLookupValueField = "KDVKodu";
            this.AKdv.KarmaMasterFieldName = null;
            this.AKdv.KarmaMasterObject = null;
            this.AKdv.KarmaValueType = KarmaObjects.KarmaValueTypes.Lookup;
            this.AKdv.Location = new System.Drawing.Point(143, 109);
            this.AKdv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AKdv.Name = "AKdv";
            this.AKdv.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AKdv.Properties.Appearance.Options.UseFont = true;
            this.AKdv.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AKdv.Properties.NullText = "";
            this.AKdv.Size = new System.Drawing.Size(117, 24);
            this.AKdv.TabIndex = 10;
            // 
            // OlcuBr
            // 
            this.OlcuBr.EnterMoveNextControl = true;
            this.OlcuBr.KarmaAddSirketWhere = false;
            this.OlcuBr.KarmaAddYilWhere = false;
            this.OlcuBr.KarmaFieldName = "OlcuBr";
            this.OlcuBr.KarmaFieldType = KarmaObjects.KarmaFieldTypes.String;
            this.OlcuBr.KarmaLookupDisplayField = null;
            this.OlcuBr.KarmaLookupFilter = null;
            this.OlcuBr.KarmaLookUpTable = null;
            this.OlcuBr.KarmaLookupValueField = null;
            this.OlcuBr.KarmaMasterFieldName = null;
            this.OlcuBr.KarmaMasterObject = null;
            this.OlcuBr.KarmaValueType = KarmaObjects.KarmaValueTypes.ItemIndex;
            this.OlcuBr.Location = new System.Drawing.Point(143, 82);
            this.OlcuBr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OlcuBr.Name = "OlcuBr";
            this.OlcuBr.Properties.Appearance.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OlcuBr.Properties.Appearance.Options.UseFont = true;
            this.OlcuBr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.OlcuBr.Properties.NullText = "";
            this.OlcuBr.Size = new System.Drawing.Size(117, 24);
            this.OlcuBr.TabIndex = 9;
            // 
            // karmaLabel6
            // 
            this.karmaLabel6.AutoSize = true;
            this.karmaLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.karmaLabel6.KarmaFocusControl = null;
            this.karmaLabel6.Location = new System.Drawing.Point(12, 168);
            this.karmaLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.karmaLabel6.Name = "karmaLabel6";
            this.karmaLabel6.ReadOnly = false;
            this.karmaLabel6.Size = new System.Drawing.Size(70, 18);
            this.karmaLabel6.TabIndex = 8;
            this.karmaLabel6.Text = "Açıklama";
            // 
            // StokAdi
            // 
            this.StokAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.StokAdi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.StokAdi.KarmaAddSirketWhere = false;
            this.StokAdi.KarmaAddYilWhere = false;
            this.StokAdi.KarmaFieldName = "StokAdi";
            this.StokAdi.KarmaFieldType = KarmaObjects.KarmaFieldTypes.String;
            this.StokAdi.KarmaGuideColumnName = null;
            this.StokAdi.KarmaGuideFields = null;
            this.StokAdi.KarmaGuideFilter = null;
            this.StokAdi.KarmaGuideName = null;
            this.StokAdi.KarmaGuideTableName = null;
            this.StokAdi.KarmaIsRequired = false;
            this.StokAdi.KarmaLastEdit = false;
            this.StokAdi.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.TamSayi;
            this.StokAdi.KarmaPasswordTextBox = false;
            this.StokAdi.Location = new System.Drawing.Point(143, 54);
            this.StokAdi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StokAdi.Name = "StokAdi";
            this.StokAdi.ReadOnly = false;
            this.StokAdi.Size = new System.Drawing.Size(287, 24);
            this.StokAdi.TabIndex = 7;
            // 
            // karmaLabel5
            // 
            this.karmaLabel5.AutoSize = true;
            this.karmaLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.karmaLabel5.KarmaFocusControl = null;
            this.karmaLabel5.Location = new System.Drawing.Point(12, 142);
            this.karmaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.karmaLabel5.Name = "karmaLabel5";
            this.karmaLabel5.ReadOnly = false;
            this.karmaLabel5.Size = new System.Drawing.Size(115, 18);
            this.karmaLabel5.TabIndex = 5;
            this.karmaLabel5.Text = "Satış KDV Oranı";
            // 
            // karmaLabel4
            // 
            this.karmaLabel4.AutoSize = true;
            this.karmaLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.karmaLabel4.KarmaFocusControl = null;
            this.karmaLabel4.Location = new System.Drawing.Point(12, 115);
            this.karmaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.karmaLabel4.Name = "karmaLabel4";
            this.karmaLabel4.ReadOnly = false;
            this.karmaLabel4.Size = new System.Drawing.Size(106, 18);
            this.karmaLabel4.TabIndex = 4;
            this.karmaLabel4.Text = "Alış KDV Oranı";
            // 
            // karmaLabel3
            // 
            this.karmaLabel3.AutoSize = true;
            this.karmaLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.karmaLabel3.KarmaFocusControl = null;
            this.karmaLabel3.Location = new System.Drawing.Point(12, 88);
            this.karmaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.karmaLabel3.Name = "karmaLabel3";
            this.karmaLabel3.ReadOnly = false;
            this.karmaLabel3.Size = new System.Drawing.Size(83, 18);
            this.karmaLabel3.TabIndex = 3;
            this.karmaLabel3.Text = "Ölçü Birimi";
            // 
            // karmaLabel2
            // 
            this.karmaLabel2.AutoSize = true;
            this.karmaLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.karmaLabel2.KarmaFocusControl = null;
            this.karmaLabel2.Location = new System.Drawing.Point(12, 57);
            this.karmaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.karmaLabel2.Name = "karmaLabel2";
            this.karmaLabel2.ReadOnly = false;
            this.karmaLabel2.Size = new System.Drawing.Size(65, 18);
            this.karmaLabel2.TabIndex = 2;
            this.karmaLabel2.Text = "Stok Adı";
            // 
            // karmaLabel1
            // 
            this.karmaLabel1.AutoSize = true;
            this.karmaLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.karmaLabel1.KarmaFocusControl = null;
            this.karmaLabel1.Location = new System.Drawing.Point(12, 29);
            this.karmaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.karmaLabel1.Name = "karmaLabel1";
            this.karmaLabel1.ReadOnly = false;
            this.karmaLabel1.Size = new System.Drawing.Size(80, 18);
            this.karmaLabel1.TabIndex = 0;
            this.karmaLabel1.Text = "Stok Kodu";
            // 
            // FrmStok
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 664);
            this.Controls.Add(this.karmaTab1);
            this.KarmaNavClearButton = true;
            this.KarmaNavDeleteButton = true;
            this.KarmaNavFirstButton = true;
            this.KarmaNavLastButton = true;
            this.KarmaNavNewButton = true;
            this.KarmaNavNextButton = true;
            this.KarmaNavPreviousButton = true;
            this.KarmaNavSaveButton = true;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "FrmStok";
            this.Text = "Stoklar";
            this.Load += new System.EventHandler(this.FrmStok_Load);
            this.Controls.SetChildIndex(this.karmaTab1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.karmaTab1)).EndInit();
            this.karmaTab1.ResumeLayout(false);
            this.PgeStokList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdStoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStoklar)).EndInit();
            this.PgeStokIslem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.karmaTab2)).EndInit();
            this.karmaTab2.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PnlStokGrup)).EndInit();
            this.PnlStokGrup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdStokGrup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStokGrup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karmaPanel5)).EndInit();
            this.karmaPanel5.ResumeLayout(false);
            this.karmaPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrupDeger.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlStokFiyat)).EndInit();
            this.PnlStokFiyat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdStokFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStokFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karmaPanel1)).EndInit();
            this.karmaPanel1.ResumeLayout(false);
            this.karmaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FiyatKodu.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PnlStokPlan)).EndInit();
            this.PnlStokPlan.ResumeLayout(false);
            this.PnlStokPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KritikStokUyar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatisSipDahil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlisSipDahil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxStokTakibi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinStokTakibi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlStokAyar)).EndInit();
            this.PnlStokAyar.ResumeLayout(false);
            this.PnlStokAyar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TalepYok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeklifYok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SiparisYok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlisYapilmaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatisYapilmaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasifStok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlStokMas)).EndInit();
            this.PnlStokMas.ResumeLayout(false);
            this.PnlStokMas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SKdv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AKdv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OlcuBr.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private KarmaObjects.KarmaTab karmaTab1;
        private DevExpress.XtraTab.XtraTabPage PgeStokList;
        private KarmaObjects.KarmaGrid GrdStoklar;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewStoklar;
        private DevExpress.XtraTab.XtraTabPage PgeStokIslem;
        private KarmaObjects.KarmaPanel PnlStokMas;
        private KarmaObjects.KarmaTextBox StokAciklama;
        private KarmaObjects.KarmaComboBox SKdv;
        private KarmaObjects.KarmaComboBox AKdv;
        private KarmaObjects.KarmaComboBox OlcuBr;
        private KarmaObjects.KarmaLabel karmaLabel6;
        private KarmaObjects.KarmaTextBox StokAdi;
        private KarmaObjects.KarmaLabel karmaLabel5;
        private KarmaObjects.KarmaLabel karmaLabel4;
        private KarmaObjects.KarmaLabel karmaLabel3;
        private KarmaObjects.KarmaLabel karmaLabel2;
        private KarmaObjects.KarmaTextBox StokKodu;
        private KarmaObjects.KarmaLabel karmaLabel1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private KarmaObjects.KarmaButton karmaButton1;
        private KarmaObjects.KarmaTab karmaTab2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private KarmaObjects.KarmaPanel PnlStokGrup;
        private KarmaObjects.KarmaGrid GrdStokGrup;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewStokGrup;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private KarmaObjects.KarmaPanel karmaPanel5;
        private KarmaObjects.KarmaComboBox GrupDeger;
        private KarmaObjects.KarmaComboBox GrupKodu;
        private KarmaObjects.KarmaLabel karmaLabel9;
        private KarmaObjects.KarmaLabel karmaLabel10;
        private KarmaObjects.KarmaButton karmaButton3;
        private KarmaObjects.KarmaPanel PnlStokFiyat;
        private KarmaObjects.KarmaGrid GrdStokFiyat;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewStokFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private KarmaObjects.KarmaPanel karmaPanel1;
        private KarmaObjects.KarmaComboBox FiyatKodu;
        private KarmaObjects.KarmaLabel karmaLabel8;
        private KarmaObjects.KarmaLabel karmaLabel7;
        private KarmaObjects.KarmaButton karmaButton2;
        private KarmaObjects.KarmaTextBox Fiyat;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private KarmaObjects.KarmaPanel PnlStokPlan;
        private KarmaObjects.KarmaPanel PnlStokAyar;
        private KarmaObjects.KarmaCheck TalepYok;
        private KarmaObjects.KarmaCheck TeklifYok;
        private KarmaObjects.KarmaCheck SiparisYok;
        private KarmaObjects.KarmaCheck AlisYapilmaz;
        private KarmaObjects.KarmaCheck SatisYapilmaz;
        private KarmaObjects.KarmaCheck PasifStok;
        private KarmaObjects.KarmaLabel karmaLabel16;
        private KarmaObjects.KarmaLabel karmaLabel15;
        private KarmaObjects.KarmaLabel karmaLabel14;
        private KarmaObjects.KarmaLabel karmaLabel13;
        private KarmaObjects.KarmaLabel karmaLabel12;
        private KarmaObjects.KarmaLabel karmaLabel11;
        private KarmaObjects.KarmaCheck SatisSipDahil;
        private KarmaObjects.KarmaLabel karmaLabel22;
        private KarmaObjects.KarmaCheck AlisSipDahil;
        private KarmaObjects.KarmaLabel karmaLabel21;
        private KarmaObjects.KarmaTextBox MaxStok;
        private KarmaObjects.KarmaLabel karmaLabel20;
        private KarmaObjects.KarmaCheck MaxStokTakibi;
        private KarmaObjects.KarmaCheck MinStokTakibi;
        private KarmaObjects.KarmaLabel karmaLabel18;
        private KarmaObjects.KarmaLabel karmaLabel19;
        private KarmaObjects.KarmaTextBox MinStok;
        private KarmaObjects.KarmaLabel karmaLabel17;
        private KarmaObjects.KarmaCheck KritikStokUyar;
        private KarmaObjects.KarmaLabel karmaLabel23;
    }
}