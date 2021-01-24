namespace KarmaObjects
{
    partial class KarmaRehber
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
            this.GrdRehber = new KarmaObjects.KarmaGrid();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrdRehber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdRehber
            // 
            this.GrdRehber.DataMember = null;
            this.GrdRehber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdRehber.Location = new System.Drawing.Point(0, 0);
            this.GrdRehber.MainView = this.gridView1;
            this.GrdRehber.Name = "GrdRehber";
            this.GrdRehber.Size = new System.Drawing.Size(1029, 605);
            this.GrdRehber.TabIndex = 1;
            this.GrdRehber.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GrdRehber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GrdRehber_KeyPress);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GrdRehber;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Filter;
            this.gridView1.OptionsFind.FindDelay = 100;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView1.OptionsFind.SearchInPreview = true;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // KarmaRehber
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 605);
            this.Controls.Add(this.GrdRehber);
            this.Name = "KarmaRehber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KarmaRehber";
            this.Load += new System.EventHandler(this.KarmaRehber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdRehber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private KarmaGrid GrdRehber;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}