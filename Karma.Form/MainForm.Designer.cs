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
            this.MainTabControl = new KarmaObjects.KarmaTab(this.components);
            this.DesktopTab = new DevExpress.XtraTab.XtraTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.karmaTextBox5 = new KarmaObjects.KarmaTextBox(this.components);
            this.karmaTextBox4 = new KarmaObjects.KarmaTextBox(this.components);
            this.karmaTextBox3 = new KarmaObjects.KarmaTextBox(this.components);
            this.karmaTextBox2 = new KarmaObjects.KarmaTextBox(this.components);
            this.karmaTextBox1 = new KarmaObjects.KarmaTextBox(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.MainBarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.MainMenuBar = new DevExpress.XtraBars.Bar();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem6 = new DevExpress.XtraBars.BarSubItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.MainTabControl)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.DesktopTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainBarManager)).BeginInit();
            this.SuspendLayout();
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
            this.MainTabControl.Size = new System.Drawing.Size(1370, 638);
            this.MainTabControl.TabIndex = 2;
            this.MainTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.DesktopTab});
            // 
            // DesktopTab
            // 
            this.DesktopTab.Controls.Add(this.panel1);
            this.DesktopTab.Name = "DesktopTab";
            this.DesktopTab.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.DesktopTab.Size = new System.Drawing.Size(1368, 614);
            this.DesktopTab.Text = "Masaüstü";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.karmaTextBox5);
            this.panel1.Controls.Add(this.karmaTextBox4);
            this.panel1.Controls.Add(this.karmaTextBox3);
            this.panel1.Controls.Add(this.karmaTextBox2);
            this.panel1.Controls.Add(this.karmaTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 614);
            this.panel1.TabIndex = 0;
            // 
            // karmaTextBox5
            // 
            this.karmaTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.karmaTextBox5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.karmaTextBox5.KarmaFieldType = KarmaObjects.KarmaFieldTypes.Numeric;
            this.karmaTextBox5.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.Genel;
            this.karmaTextBox5.KarmaPasswordTextBox = false;
            this.karmaTextBox5.Location = new System.Drawing.Point(635, 375);
            this.karmaTextBox5.Name = "karmaTextBox5";
            this.karmaTextBox5.ReadOnly = false;
            this.karmaTextBox5.Size = new System.Drawing.Size(257, 20);
            this.karmaTextBox5.TabIndex = 8;
            this.karmaTextBox5.Text = "5.000,00";
            // 
            // karmaTextBox4
            // 
            this.karmaTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.karmaTextBox4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.karmaTextBox4.KarmaFieldType = KarmaObjects.KarmaFieldTypes.Numeric;
            this.karmaTextBox4.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.Tutar;
            this.karmaTextBox4.KarmaPasswordTextBox = false;
            this.karmaTextBox4.Location = new System.Drawing.Point(635, 349);
            this.karmaTextBox4.Name = "karmaTextBox4";
            this.karmaTextBox4.ReadOnly = false;
            this.karmaTextBox4.Size = new System.Drawing.Size(257, 20);
            this.karmaTextBox4.TabIndex = 7;
            this.karmaTextBox4.Text = "4.000,000";
            // 
            // karmaTextBox3
            // 
            this.karmaTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.karmaTextBox3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.karmaTextBox3.KarmaFieldType = KarmaObjects.KarmaFieldTypes.Numeric;
            this.karmaTextBox3.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.Fiyat;
            this.karmaTextBox3.KarmaPasswordTextBox = false;
            this.karmaTextBox3.Location = new System.Drawing.Point(635, 323);
            this.karmaTextBox3.Name = "karmaTextBox3";
            this.karmaTextBox3.ReadOnly = false;
            this.karmaTextBox3.Size = new System.Drawing.Size(257, 20);
            this.karmaTextBox3.TabIndex = 6;
            this.karmaTextBox3.Text = "3.000,00";
            // 
            // karmaTextBox2
            // 
            this.karmaTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.karmaTextBox2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.karmaTextBox2.KarmaFieldType = KarmaObjects.KarmaFieldTypes.Numeric;
            this.karmaTextBox2.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.Miktar;
            this.karmaTextBox2.KarmaPasswordTextBox = false;
            this.karmaTextBox2.Location = new System.Drawing.Point(635, 297);
            this.karmaTextBox2.Name = "karmaTextBox2";
            this.karmaTextBox2.ReadOnly = false;
            this.karmaTextBox2.Size = new System.Drawing.Size(257, 20);
            this.karmaTextBox2.TabIndex = 5;
            this.karmaTextBox2.Text = "2.000,00";
            // 
            // karmaTextBox1
            // 
            this.karmaTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.karmaTextBox1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.karmaTextBox1.KarmaFieldType = KarmaObjects.KarmaFieldTypes.Numeric;
            this.karmaTextBox1.KarmaNumericType = KarmaLib.KarmaLib.KarmaFieldNumericTypes.TamSayi;
            this.karmaTextBox1.KarmaPasswordTextBox = false;
            this.karmaTextBox1.Location = new System.Drawing.Point(635, 271);
            this.karmaTextBox1.Name = "karmaTextBox1";
            this.karmaTextBox1.ReadOnly = false;
            this.karmaTextBox1.Size = new System.Drawing.Size(257, 20);
            this.karmaTextBox1.TabIndex = 4;
            this.karmaTextBox1.Text = "1.000";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1120, 566);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // MainBarManager
            // 
            this.MainBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.MainMenuBar});
            this.MainBarManager.DockControls.Add(this.barDockControlTop);
            this.MainBarManager.DockControls.Add(this.barDockControlBottom);
            this.MainBarManager.DockControls.Add(this.barDockControlLeft);
            this.MainBarManager.DockControls.Add(this.barDockControlRight);
            this.MainBarManager.Form = this;
            this.MainBarManager.MainMenu = this.MainMenuBar;
            this.MainBarManager.MaxItemId = 12;
            this.MainBarManager.StatusBar = this.bar2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 3";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Custom 3";
            // 
            // MainMenuBar
            // 
            this.MainMenuBar.BarName = "Custom 4";
            this.MainMenuBar.DockCol = 0;
            this.MainMenuBar.DockRow = 0;
            this.MainMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.MainMenuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem6)});
            this.MainMenuBar.OptionsBar.MultiLine = true;
            this.MainMenuBar.OptionsBar.UseWholeRow = true;
            this.MainMenuBar.Text = "Custom 4";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Sistem";
            this.barSubItem2.Id = 7;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Düzen";
            this.barSubItem3.Id = 8;
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "İşlemler";
            this.barSubItem4.Id = 9;
            this.barSubItem4.Name = "barSubItem4";
            // 
            // barSubItem5
            // 
            this.barSubItem5.Caption = "Raporlar";
            this.barSubItem5.Id = 10;
            this.barSubItem5.Name = "barSubItem5";
            // 
            // barSubItem6
            // 
            this.barSubItem6.Caption = "Yardım";
            this.barSubItem6.Id = 11;
            this.barSubItem6.Name = "barSubItem6";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.MainBarManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1370, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 662);
            this.barDockControlBottom.Manager = this.MainBarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1370, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.MainBarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 638);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1370, 24);
            this.barDockControlRight.Manager = this.MainBarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 638);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Sistem";
            this.barSubItem1.Id = 1;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 2";
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 684);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Roboto", 9F);
            this.Name = "MainForm";
            this.Text = "Karma";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainTabControl)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.DesktopTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainBarManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private KarmaObjects.KarmaTab MainTabControl;
        private DevExpress.XtraTab.XtraTabPage DesktopTab;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Panel panel1;
        private KarmaObjects.KarmaTextBox karmaTextBox5;
        private KarmaObjects.KarmaTextBox karmaTextBox4;
        private KarmaObjects.KarmaTextBox karmaTextBox3;
        private KarmaObjects.KarmaTextBox karmaTextBox2;
        private KarmaObjects.KarmaTextBox karmaTextBox1;
        private DevExpress.XtraBars.BarManager MainBarManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar MainMenuBar;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarSubItem barSubItem5;
        private DevExpress.XtraBars.BarSubItem barSubItem6;
    }
}

