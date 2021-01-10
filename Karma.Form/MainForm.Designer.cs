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
            this.PnlToolBar = new System.Windows.Forms.Panel();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTabControl)).BeginInit();
            this.MainTabControl.SuspendLayout();
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
            this.MainTabControl.Size = new System.Drawing.Size(1122, 589);
            this.MainTabControl.TabIndex = 2;
            this.MainTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.DesktopTab});
            // 
            // DesktopTab
            // 
            this.DesktopTab.Name = "DesktopTab";
            this.DesktopTab.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.DesktopTab.Size = new System.Drawing.Size(1120, 566);
            this.DesktopTab.Text = "Masaüstü";
            // 
            // PnlToolBar
            // 
            this.PnlToolBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlToolBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlToolBar.Location = new System.Drawing.Point(1122, 24);
            this.PnlToolBar.Name = "PnlToolBar";
            this.PnlToolBar.Size = new System.Drawing.Size(52, 589);
            this.PnlToolBar.TabIndex = 3;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1120, 566);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 635);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.PnlToolBar);
            this.Controls.Add(this.MainStatusBar);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Karma";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTabControl)).EndInit();
            this.MainTabControl.ResumeLayout(false);
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
        private System.Windows.Forms.Panel PnlToolBar;
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
    }
}

