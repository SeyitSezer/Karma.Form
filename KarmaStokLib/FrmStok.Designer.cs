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
            this.karmaTab1 = new KarmaObjects.KarmaTab(this.components);
            this.PgeStokList = new DevExpress.XtraTab.XtraTabPage();
            this.GrdStoklar = new KarmaObjects.KarmaGrid();
            this.ViewStoklar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PgeStokIslem = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.karmaTab1)).BeginInit();
            this.karmaTab1.SuspendLayout();
            this.PgeStokList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdStoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStoklar)).BeginInit();
            this.SuspendLayout();
            // 
            // karmaTab1
            // 
            this.karmaTab1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.karmaTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.karmaTab1.Location = new System.Drawing.Point(0, 0);
            this.karmaTab1.Name = "karmaTab1";
            this.karmaTab1.SelectedTabPage = this.PgeStokList;
            this.karmaTab1.Size = new System.Drawing.Size(1196, 617);
            this.karmaTab1.TabIndex = 0;
            this.karmaTab1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PgeStokList,
            this.PgeStokIslem});
            // 
            // PgeStokList
            // 
            this.PgeStokList.Controls.Add(this.GrdStoklar);
            this.PgeStokList.Name = "PgeStokList";
            this.PgeStokList.Size = new System.Drawing.Size(1194, 594);
            this.PgeStokList.Text = "Stok Listesi";
            // 
            // GrdStoklar
            // 
            this.GrdStoklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdStoklar.KarmaSQLCalistir = true;
            this.GrdStoklar.KarmaSQLText = "SELECT * FROM tblCategoryMas";
            this.GrdStoklar.Location = new System.Drawing.Point(0, 0);
            this.GrdStoklar.MainView = this.ViewStoklar;
            this.GrdStoklar.Name = "GrdStoklar";
            this.GrdStoklar.Size = new System.Drawing.Size(1194, 594);
            this.GrdStoklar.TabIndex = 1;
            this.GrdStoklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewStoklar});
            // 
            // ViewStoklar
            // 
            this.ViewStoklar.GridControl = this.GrdStoklar;
            this.ViewStoklar.Name = "ViewStoklar";
            // 
            // PgeStokIslem
            // 
            this.PgeStokIslem.Name = "PgeStokIslem";
            this.PgeStokIslem.Size = new System.Drawing.Size(1194, 594);
            this.PgeStokIslem.Text = "Stok Kart Bilgisi";
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
            this.Name = "FrmStok";
            this.Text = "Stok Kartları";
            ((System.ComponentModel.ISupportInitialize)(this.karmaTab1)).EndInit();
            this.karmaTab1.ResumeLayout(false);
            this.PgeStokList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdStoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStoklar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private KarmaObjects.KarmaTab karmaTab1;
        private DevExpress.XtraTab.XtraTabPage PgeStokList;
        private DevExpress.XtraTab.XtraTabPage PgeStokIslem;
        private KarmaObjects.KarmaGrid GrdStoklar;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewStoklar;
    }
}