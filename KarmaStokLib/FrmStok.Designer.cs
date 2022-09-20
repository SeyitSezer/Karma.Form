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
            this.karmaPanel2 = new KarmaObjects.KarmaPanel(this.components);
            this.karmaPanel3 = new KarmaObjects.KarmaPanel(this.components);
            this.PnlStokMas = new KarmaObjects.KarmaPanel(this.components);
            this.karmaButton1 = new KarmaObjects.KarmaButton(this.components);
            this.karmaTextBox3 = new KarmaObjects.KarmaTextBox(this.components);
            this.karmaComboBox3 = new KarmaObjects.KarmaComboBox();
            this.karmaComboBox2 = new KarmaObjects.KarmaComboBox();
            this.karmaComboBox1 = new KarmaObjects.KarmaComboBox();
            this.karmaLabel6 = new KarmaObjects.KarmaLabel();
            this.karmaTextBox2 = new KarmaObjects.KarmaTextBox(this.components);
            this.karmaLabel5 = new KarmaObjects.KarmaLabel();
            this.karmaLabel4 = new KarmaObjects.KarmaLabel();
            this.karmaLabel3 = new KarmaObjects.KarmaLabel();
            this.karmaLabel2 = new KarmaObjects.KarmaLabel();
            this.karmaTextBox1 = new KarmaObjects.KarmaTextBox(this.components);
            this.karmaLabel1 = new KarmaObjects.KarmaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.karmaTab1)).BeginInit();
            this.karmaTab1.SuspendLayout();
            this.PgeStokList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdStoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStoklar)).BeginInit();
            this.PgeStokIslem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karmaPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karmaPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlStokMas)).BeginInit();
            this.PnlStokMas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karmaComboBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karmaComboBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karmaComboBox1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // karmaTab1
            // 
            this.karmaTab1.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.OrangeRed;
            this.karmaTab1.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.karmaTab1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.karmaTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.karmaTab1.KarmaCloseButtonMessageActive = true;
            this.karmaTab1.Location = new System.Drawing.Point(0, 0);
            this.karmaTab1.Name = "karmaTab1";
            this.karmaTab1.SelectedTabPage = this.PgeStokList;
            this.karmaTab1.Size = new System.Drawing.Size(1196, 617);
            this.karmaTab1.TabIndex = 16;
            this.karmaTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PgeStokList,
            this.PgeStokIslem});
            // 
            // PgeStokList
            // 
            this.PgeStokList.Controls.Add(this.GrdStoklar);
            this.PgeStokList.Name = "PgeStokList";
            this.PgeStokList.Size = new System.Drawing.Size(1194, 592);
            this.PgeStokList.Text = "Stok Listesi";
            // 
            // GrdStoklar
            // 
            this.GrdStoklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdStoklar.KarmaSQLCalistir = true;
            this.GrdStoklar.KarmaSQLText = "SELECT * FROM tblStok";
            this.GrdStoklar.Location = new System.Drawing.Point(0, 0);
            this.GrdStoklar.MainView = this.ViewStoklar;
            this.GrdStoklar.Name = "GrdStoklar";
            this.GrdStoklar.Size = new System.Drawing.Size(1194, 592);
            this.GrdStoklar.TabIndex = 0;
            this.GrdStoklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewStoklar});
            this.GrdStoklar.DoubleClick += new System.EventHandler(this.GrdStoklar_DoubleClick);
            // 
            // ViewStoklar
            // 
            this.ViewStoklar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.ViewStoklar.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.ViewStoklar.GridControl = this.GrdStoklar;
            this.ViewStoklar.GroupPanelText = "Gruplamak İçin Sütunu Sürükleyip Buraya Bırakın";
            this.ViewStoklar.Name = "ViewStoklar";
            this.ViewStoklar.OptionsBehavior.Editable = false;
            this.ViewStoklar.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.ViewStoklar.OptionsFind.AlwaysVisible = true;
            this.ViewStoklar.OptionsFind.FindDelay = 100;
            this.ViewStoklar.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.ViewStoklar.OptionsFind.FindNullPrompt = "Arama Yapmak İçin Buraya Yazın";
            this.ViewStoklar.OptionsFind.ShowFindButton = false;
            this.ViewStoklar.OptionsMenu.EnableColumnMenu = false;
            this.ViewStoklar.OptionsMenu.EnableGroupPanelMenu = false;
            this.ViewStoklar.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Fast;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Stok Kodu";
            this.gridColumn2.FieldName = "StokKodu";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Stok Adı";
            this.gridColumn3.FieldName = "StokAdi";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "KDV Oranı(Alış)";
            this.gridColumn4.FieldName = "AlisKDVOrani";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ölçü Birimi";
            this.gridColumn5.FieldName = "OlcuBr";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "KDV Oranı(Satış)";
            this.gridColumn6.FieldName = "SatisKDVOrani";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Açıklama";
            this.gridColumn7.FieldName = "Aciklama";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // PgeStokIslem
            // 
            this.PgeStokIslem.Controls.Add(this.karmaPanel2);
            this.PgeStokIslem.Controls.Add(this.karmaPanel3);
            this.PgeStokIslem.Controls.Add(this.PnlStokMas);
            this.PgeStokIslem.Name = "PgeStokIslem";
            this.PgeStokIslem.Size = new System.Drawing.Size(1194, 592);
            this.PgeStokIslem.Text = "Stok Bilgisi";
            // 
            // karmaPanel2
            // 
            this.karmaPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.karmaPanel2.KarmaChildPanels = null;
            this.karmaPanel2.KarmaColumnNames = null;
            this.karmaPanel2.KarmaGridControl = null;
            this.karmaPanel2.KarmaMasterButton = null;
            this.karmaPanel2.KarmaMasterTextBox = null;
            this.karmaPanel2.KarmaTableName = null;
            this.karmaPanel2.Location = new System.Drawing.Point(0, 165);
            this.karmaPanel2.Name = "karmaPanel2";
            this.karmaPanel2.Size = new System.Drawing.Size(371, 427);
            this.karmaPanel2.TabIndex = 1;
            // 
            // karmaPanel3
            // 
            this.karmaPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.karmaPanel3.KarmaChildPanels = null;
            this.karmaPanel3.KarmaColumnNames = null;
            this.karmaPanel3.KarmaGridControl = null;
            this.karmaPanel3.KarmaMasterButton = null;
            this.karmaPanel3.KarmaMasterTextBox = null;
            this.karmaPanel3.KarmaTableName = null;
            this.karmaPanel3.Location = new System.Drawing.Point(0, 165);
            this.karmaPanel3.Name = "karmaPanel3";
            this.karmaPanel3.Size = new System.Drawing.Size(1194, 427);
            this.karmaPanel3.TabIndex = 2;
            // 
            // PnlStokMas
            // 
            this.PnlStokMas.Controls.Add(this.karmaButton1);
            this.PnlStokMas.Controls.Add(this.karmaTextBox3);
            this.PnlStokMas.Controls.Add(this.karmaComboBox3);
            this.PnlStokMas.Controls.Add(this.karmaComboBox2);
            this.PnlStokMas.Controls.Add(this.karmaComboBox1);
            this.PnlStokMas.Controls.Add(this.karmaLabel6);
            this.PnlStokMas.Controls.Add(this.karmaTextBox2);
            this.PnlStokMas.Controls.Add(this.karmaLabel5);
            this.PnlStokMas.Controls.Add(this.karmaLabel4);
            this.PnlStokMas.Controls.Add(this.karmaLabel3);
            this.PnlStokMas.Controls.Add(this.karmaLabel2);
            this.PnlStokMas.Controls.Add(this.karmaTextBox1);
            this.PnlStokMas.Controls.Add(this.karmaLabel1);
            this.PnlStokMas.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlStokMas.KarmaChildPanels = null;
            this.PnlStokMas.KarmaColumnNames = null;
            this.PnlStokMas.KarmaGridControl = this.GrdStoklar;
            this.PnlStokMas.KarmaMasterButton = null;
            this.PnlStokMas.KarmaMasterTextBox = this.karmaTextBox1;
            this.PnlStokMas.KarmaTableName = "tblStok";
            this.PnlStokMas.Location = new System.Drawing.Point(0, 0);
            this.PnlStokMas.Name = "PnlStokMas";
            this.PnlStokMas.Size = new System.Drawing.Size(1194, 165);
            this.PnlStokMas.TabIndex = 0;
            // 
            // karmaButton1
            // 
            this.karmaButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.karmaButton1.Appearance.Options.UseForeColor = true;
            this.karmaButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("karmaButton1.ImageOptions.Image")));
            this.karmaButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.karmaButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("karmaButton1.ImageOptions.SvgImage")));
            this.karmaButton1.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.karmaButton1.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.karmaButton1.KarmaButtonType = KarmaObjects.KarmaButtonTypes.Topluİşlem;
            this.karmaButton1.KarmaMasterPanel = this.PnlStokMas;
            this.karmaButton1.KarmaMasterTextBox = this.karmaTextBox3;
            this.karmaButton1.Location = new System.Drawing.Point(677, 137);
            this.karmaButton1.Margin = new System.Windows.Forms.Padding(0);
            this.karmaButton1.Name = "karmaButton1";
            this.karmaButton1.Size = new System.Drawing.Size(31, 23);
            this.karmaButton1.TabIndex = 18;
            this.karmaButton1.TasinabilirMi = false;
            this.karmaButton1.Text = "Kayıt :";
            // 
            // karmaTextBox3
            // 
            this.karmaTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.karmaTextBox3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.karmaTextBox3.KarmaFieldName = "Aciklama";
            this.karmaTextBox3.KarmaFieldType = KarmaObjects.KarmaFieldTypes.String;
            this.karmaTextBox3.KarmaGuideColumnName = null;
            this.karmaTextBox3.KarmaGuideFields = null;
            this.karmaTextBox3.KarmaGuideFilter = null;
            this.karmaTextBox3.KarmaGuideName = null;
            this.karmaTextBox3.KarmaGuideTableName = null;
            this.karmaTextBox3.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.TamSayi;
            this.karmaTextBox3.KarmaPasswordTextBox = false;
            this.karmaTextBox3.Location = new System.Drawing.Point(140, 137);
            this.karmaTextBox3.Name = "karmaTextBox3";
            this.karmaTextBox3.ReadOnly = false;
            this.karmaTextBox3.Size = new System.Drawing.Size(535, 20);
            this.karmaTextBox3.TabIndex = 12;
            // 
            // karmaComboBox3
            // 
            this.karmaComboBox3.KarmaFieldName = "SatisKDVOrani";
            this.karmaComboBox3.KarmaFieldType = KarmaObjects.KarmaFieldTypes.Numeric;
            this.karmaComboBox3.KarmaLookupDisplayField = "Aciklama";
            this.karmaComboBox3.KarmaLookupFilter = null;
            this.karmaComboBox3.KarmaLookUpTable = "tblKDVTanim";
            this.karmaComboBox3.KarmaLookupValueField = "KDVKodu";
            this.karmaComboBox3.KarmaValueType = KarmaObjects.KarmaValueTypes.Lookup;
            this.karmaComboBox3.Location = new System.Drawing.Point(140, 115);
            this.karmaComboBox3.Name = "karmaComboBox3";
            this.karmaComboBox3.Properties.Appearance.Options.UseFont = true;
            this.karmaComboBox3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.karmaComboBox3.Properties.NullText = "";
            this.karmaComboBox3.Size = new System.Drawing.Size(100, 20);
            this.karmaComboBox3.TabIndex = 11;
            // 
            // karmaComboBox2
            // 
            this.karmaComboBox2.KarmaFieldName = "AlisKDVOrani";
            this.karmaComboBox2.KarmaFieldType = KarmaObjects.KarmaFieldTypes.Numeric;
            this.karmaComboBox2.KarmaLookupDisplayField = "Aciklama";
            this.karmaComboBox2.KarmaLookupFilter = null;
            this.karmaComboBox2.KarmaLookUpTable = "tblKDVTanim";
            this.karmaComboBox2.KarmaLookupValueField = "KDVKodu";
            this.karmaComboBox2.KarmaValueType = KarmaObjects.KarmaValueTypes.Lookup;
            this.karmaComboBox2.Location = new System.Drawing.Point(140, 93);
            this.karmaComboBox2.Name = "karmaComboBox2";
            this.karmaComboBox2.Properties.Appearance.Options.UseFont = true;
            this.karmaComboBox2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.karmaComboBox2.Properties.NullText = "";
            this.karmaComboBox2.Size = new System.Drawing.Size(100, 20);
            this.karmaComboBox2.TabIndex = 10;
            // 
            // karmaComboBox1
            // 
            this.karmaComboBox1.KarmaFieldName = "OlcuBr";
            this.karmaComboBox1.KarmaFieldType = KarmaObjects.KarmaFieldTypes.String;
            this.karmaComboBox1.KarmaLookupDisplayField = null;
            this.karmaComboBox1.KarmaLookupFilter = null;
            this.karmaComboBox1.KarmaLookUpTable = null;
            this.karmaComboBox1.KarmaLookupValueField = null;
            this.karmaComboBox1.KarmaValueType = KarmaObjects.KarmaValueTypes.ItemIndex;
            this.karmaComboBox1.Location = new System.Drawing.Point(140, 71);
            this.karmaComboBox1.Name = "karmaComboBox1";
            this.karmaComboBox1.Properties.Appearance.Options.UseFont = true;
            this.karmaComboBox1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.karmaComboBox1.Properties.NullText = "";
            this.karmaComboBox1.Size = new System.Drawing.Size(100, 20);
            this.karmaComboBox1.TabIndex = 9;
            // 
            // karmaLabel6
            // 
            this.karmaLabel6.AutoSize = true;
            this.karmaLabel6.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel6.KarmaFocusControl = null;
            this.karmaLabel6.Location = new System.Drawing.Point(22, 143);
            this.karmaLabel6.Name = "karmaLabel6";
            this.karmaLabel6.ReadOnly = false;
            this.karmaLabel6.Size = new System.Drawing.Size(57, 14);
            this.karmaLabel6.TabIndex = 8;
            this.karmaLabel6.Text = "Açıklama";
            // 
            // karmaTextBox2
            // 
            this.karmaTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.karmaTextBox2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.karmaTextBox2.KarmaFieldName = "StokAdi";
            this.karmaTextBox2.KarmaFieldType = KarmaObjects.KarmaFieldTypes.String;
            this.karmaTextBox2.KarmaGuideColumnName = null;
            this.karmaTextBox2.KarmaGuideFields = null;
            this.karmaTextBox2.KarmaGuideFilter = null;
            this.karmaTextBox2.KarmaGuideName = null;
            this.karmaTextBox2.KarmaGuideTableName = null;
            this.karmaTextBox2.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.TamSayi;
            this.karmaTextBox2.KarmaPasswordTextBox = false;
            this.karmaTextBox2.Location = new System.Drawing.Point(140, 49);
            this.karmaTextBox2.Name = "karmaTextBox2";
            this.karmaTextBox2.ReadOnly = false;
            this.karmaTextBox2.Size = new System.Drawing.Size(246, 20);
            this.karmaTextBox2.TabIndex = 7;
            // 
            // karmaLabel5
            // 
            this.karmaLabel5.AutoSize = true;
            this.karmaLabel5.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel5.KarmaFocusControl = null;
            this.karmaLabel5.Location = new System.Drawing.Point(22, 118);
            this.karmaLabel5.Name = "karmaLabel5";
            this.karmaLabel5.ReadOnly = false;
            this.karmaLabel5.Size = new System.Drawing.Size(93, 14);
            this.karmaLabel5.TabIndex = 5;
            this.karmaLabel5.Text = "Satış KDV Oranı";
            // 
            // karmaLabel4
            // 
            this.karmaLabel4.AutoSize = true;
            this.karmaLabel4.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel4.KarmaFocusControl = null;
            this.karmaLabel4.Location = new System.Drawing.Point(22, 96);
            this.karmaLabel4.Name = "karmaLabel4";
            this.karmaLabel4.ReadOnly = false;
            this.karmaLabel4.Size = new System.Drawing.Size(86, 14);
            this.karmaLabel4.TabIndex = 4;
            this.karmaLabel4.Text = "Alış KDV Oranı";
            // 
            // karmaLabel3
            // 
            this.karmaLabel3.AutoSize = true;
            this.karmaLabel3.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel3.KarmaFocusControl = null;
            this.karmaLabel3.Location = new System.Drawing.Point(22, 74);
            this.karmaLabel3.Name = "karmaLabel3";
            this.karmaLabel3.ReadOnly = false;
            this.karmaLabel3.Size = new System.Drawing.Size(65, 14);
            this.karmaLabel3.TabIndex = 3;
            this.karmaLabel3.Text = "Ölçü Birimi";
            // 
            // karmaLabel2
            // 
            this.karmaLabel2.AutoSize = true;
            this.karmaLabel2.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel2.KarmaFocusControl = null;
            this.karmaLabel2.Location = new System.Drawing.Point(22, 49);
            this.karmaLabel2.Name = "karmaLabel2";
            this.karmaLabel2.ReadOnly = false;
            this.karmaLabel2.Size = new System.Drawing.Size(52, 14);
            this.karmaLabel2.TabIndex = 2;
            this.karmaLabel2.Text = "Stok Adı";
            // 
            // karmaTextBox1
            // 
            this.karmaTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.karmaTextBox1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.karmaTextBox1.KarmaFieldName = "StokKodu";
            this.karmaTextBox1.KarmaFieldType = KarmaObjects.KarmaFieldTypes.Guide;
            this.karmaTextBox1.KarmaGuideColumnName = "StokKodu";
            this.karmaTextBox1.KarmaGuideFields = "StokKodu, StokAdi, OlcuBr, AlisKDVOrani, SatisKDVOrani, Aciklama";
            this.karmaTextBox1.KarmaGuideFilter = null;
            this.karmaTextBox1.KarmaGuideName = "Stok Rehberi";
            this.karmaTextBox1.KarmaGuideTableName = "tblStok";
            this.karmaTextBox1.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.TamSayi;
            this.karmaTextBox1.KarmaPasswordTextBox = false;
            this.karmaTextBox1.Location = new System.Drawing.Point(140, 27);
            this.karmaTextBox1.Name = "karmaTextBox1";
            this.karmaTextBox1.ReadOnly = false;
            this.karmaTextBox1.Size = new System.Drawing.Size(246, 20);
            this.karmaTextBox1.TabIndex = 1;
            // 
            // karmaLabel1
            // 
            this.karmaLabel1.AutoSize = true;
            this.karmaLabel1.Font = new System.Drawing.Font("Roboto", 9F);
            this.karmaLabel1.KarmaFocusControl = null;
            this.karmaLabel1.Location = new System.Drawing.Point(22, 27);
            this.karmaLabel1.Name = "karmaLabel1";
            this.karmaLabel1.ReadOnly = false;
            this.karmaLabel1.Size = new System.Drawing.Size(63, 14);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 617);
            this.Controls.Add(this.karmaTab1);
            this.KarmaNavClearButton = true;
            this.KarmaNavDeleteButton = true;
            this.KarmaNavFirstButton = true;
            this.KarmaNavLastButton = true;
            this.KarmaNavNewButton = true;
            this.KarmaNavNextButton = true;
            this.KarmaNavPreviousButton = true;
            this.KarmaNavSaveButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmStok";
            this.Text = "Stoklar";
            this.Controls.SetChildIndex(this.karmaTab1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.karmaTab1)).EndInit();
            this.karmaTab1.ResumeLayout(false);
            this.PgeStokList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdStoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStoklar)).EndInit();
            this.PgeStokIslem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.karmaPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karmaPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlStokMas)).EndInit();
            this.PnlStokMas.ResumeLayout(false);
            this.PnlStokMas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karmaComboBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karmaComboBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karmaComboBox1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private KarmaObjects.KarmaTab karmaTab1;
        private DevExpress.XtraTab.XtraTabPage PgeStokList;
        private KarmaObjects.KarmaGrid GrdStoklar;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewStoklar;
        private DevExpress.XtraTab.XtraTabPage PgeStokIslem;
        private KarmaObjects.KarmaPanel karmaPanel3;
        private KarmaObjects.KarmaPanel karmaPanel2;
        private KarmaObjects.KarmaPanel PnlStokMas;
        private KarmaObjects.KarmaTextBox karmaTextBox3;
        private KarmaObjects.KarmaComboBox karmaComboBox3;
        private KarmaObjects.KarmaComboBox karmaComboBox2;
        private KarmaObjects.KarmaComboBox karmaComboBox1;
        private KarmaObjects.KarmaLabel karmaLabel6;
        private KarmaObjects.KarmaTextBox karmaTextBox2;
        private KarmaObjects.KarmaLabel karmaLabel5;
        private KarmaObjects.KarmaLabel karmaLabel4;
        private KarmaObjects.KarmaLabel karmaLabel3;
        private KarmaObjects.KarmaLabel karmaLabel2;
        private KarmaObjects.KarmaTextBox karmaTextBox1;
        private KarmaObjects.KarmaLabel karmaLabel1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private KarmaObjects.KarmaButton karmaButton1;
    }
}