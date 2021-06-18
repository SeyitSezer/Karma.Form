
namespace KarmaUserLib
{
    partial class FrmUserSettings
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
            this.propertyGridControl1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.catGenel = new DevExpress.XtraVerticalGrid.Rows.PGridOfficeCategoryRow();
            this.EKRAN_KAPANIS_ONAY = new DevExpress.XtraVerticalGrid.Rows.PGridBooleanEditorRow();
            this.ACIK_EKRAN_ONAY = new DevExpress.XtraVerticalGrid.Rows.PGridBooleanEditorRow();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyGridControl1
            // 
            this.propertyGridControl1.ActiveViewType = DevExpress.XtraVerticalGrid.PropertyGridView.Office;
            this.propertyGridControl1.Appearance.Category.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.propertyGridControl1.Appearance.Category.Options.UseBackColor = true;
            this.propertyGridControl1.AutoGenerateRows = false;
            this.propertyGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.propertyGridControl1.Location = new System.Drawing.Point(0, 24);
            this.propertyGridControl1.Name = "propertyGridControl1";
            this.propertyGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
            this.propertyGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.catGenel,
            this.EKRAN_KAPANIS_ONAY,
            this.ACIK_EKRAN_ONAY});
            this.propertyGridControl1.Size = new System.Drawing.Size(394, 548);
            this.propertyGridControl1.TabIndex = 2;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // catGenel
            // 
            this.catGenel.Name = "catGenel";
            this.catGenel.Properties.Caption = "Genel Seçenekler";
            // 
            // EKRAN_KAPANIS_ONAY
            // 
            this.EKRAN_KAPANIS_ONAY.Name = "EKRAN_KAPANIS_ONAY";
            this.EKRAN_KAPANIS_ONAY.Properties.Caption = "Ekran kapanışlarında onay alınsın mı?";
            this.EKRAN_KAPANIS_ONAY.Properties.Value = true;
            this.EKRAN_KAPANIS_ONAY.Properties.RowEdit = this.repositoryItemCheckEdit2;
            this.EKRAN_KAPANIS_ONAY.Repository = this.repositoryItemCheckEdit2;
            // 
            // ACIK_EKRAN_ONAY
            // 
            this.ACIK_EKRAN_ONAY.Name = "ACIK_EKRAN_ONAY";
            this.ACIK_EKRAN_ONAY.Properties.Caption = "Açılmış olan ekran tekrar açılsın mı?";
            this.ACIK_EKRAN_ONAY.Properties.Value = true;
            this.ACIK_EKRAN_ONAY.Properties.RowEdit = this.repositoryItemCheckEdit1;
            this.ACIK_EKRAN_ONAY.Repository = this.repositoryItemCheckEdit1;
            // 
            // FrmUserSettings
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 572);
            this.Controls.Add(this.propertyGridControl1);
            this.KarmaNavClearButton = true;
            this.KarmaNavigatorPanel = true;
            this.KarmaNavSaveButton = true;
            this.Name = "FrmUserSettings";
            this.Text = "Kullanıcı Seçenekleri";
            this.KFClearButtonClick += new KarmaObjects.KarmaForm.ClearButtonClick(this.UserSettings_KFClearButtonClick);
            this.Controls.SetChildIndex(this.propertyGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl1;
        private DevExpress.XtraVerticalGrid.Rows.PGridOfficeCategoryRow category;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraVerticalGrid.Rows.PGridOfficeCategoryRow catGenel;
        private DevExpress.XtraVerticalGrid.Rows.PGridBooleanEditorRow EKRAN_KAPANIS_ONAY;
        private DevExpress.XtraVerticalGrid.Rows.PGridBooleanEditorRow ACIK_EKRAN_ONAY;
    }
}