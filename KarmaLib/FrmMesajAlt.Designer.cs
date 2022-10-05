namespace KarmaLib
{
    partial class FrmMesajAlt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMesajAlt));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TxtMesaj = new System.Windows.Forms.RichTextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.BtnOk = new DevExpress.XtraEditors.SimpleButton();
            this.styleController1 = new DevExpress.XtraEditors.StyleController(this.components);
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnYes = new DevExpress.XtraEditors.SimpleButton();
            this.lblBekle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TmrBtnEnabled = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 713);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 465);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(872, 245);
            this.panel4.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lblBaslik);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 252);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(9);
            this.panel1.Size = new System.Drawing.Size(872, 207);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TxtMesaj);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(9, 44);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(129, 20, 129, 0);
            this.panel5.Size = new System.Drawing.Size(854, 116);
            this.panel5.TabIndex = 5;
            // 
            // TxtMesaj
            // 
            this.TxtMesaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TxtMesaj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMesaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtMesaj.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMesaj.ForeColor = System.Drawing.Color.White;
            this.TxtMesaj.Location = new System.Drawing.Point(129, 20);
            this.TxtMesaj.Name = "TxtMesaj";
            this.TxtMesaj.ReadOnly = true;
            this.TxtMesaj.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TxtMesaj.Size = new System.Drawing.Size(596, 96);
            this.TxtMesaj.TabIndex = 6;
            this.TxtMesaj.Text = "asd";
            // 
            // lblBaslik
            // 
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(9, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(854, 35);
            this.lblBaslik.TabIndex = 4;
            this.lblBaslik.Text = "Başlık";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tablePanel1);
            this.panel2.Controls.Add(this.lblBekle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(9, 160);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 129, 0);
            this.panel2.Size = new System.Drawing.Size(854, 38);
            this.panel2.TabIndex = 3;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 105F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 105F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 105F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 105F)});
            this.tablePanel1.Controls.Add(this.BtnOk);
            this.tablePanel1.Controls.Add(this.BtnCancel);
            this.tablePanel1.Controls.Add(this.BtnNo);
            this.tablePanel1.Controls.Add(this.BtnYes);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tablePanel1.Location = new System.Drawing.Point(305, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(420, 38);
            this.tablePanel1.TabIndex = 5;
            // 
            // BtnOk
            // 
            this.BtnOk.Appearance.Options.UseTextOptions = true;
            this.BtnOk.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BtnOk.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.BtnOk.AutoWidthInLayoutControl = true;
            this.BtnOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.tablePanel1.SetColumn(this.BtnOk, 0);
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnOk.ImageOptions.Image")));
            this.BtnOk.Location = new System.Drawing.Point(3, 3);
            this.BtnOk.Name = "BtnOk";
            this.tablePanel1.SetRow(this.BtnOk, 0);
            this.BtnOk.Size = new System.Drawing.Size(99, 32);
            this.BtnOk.StyleController = this.styleController1;
            this.BtnOk.TabIndex = 4;
            this.BtnOk.Text = "Tamam";
            // 
            // styleController1
            // 
            this.styleController1.Appearance.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.styleController1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.styleController1.Appearance.Options.UseFont = true;
            this.styleController1.LookAndFeel.UseWindowsXPTheme = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Appearance.Options.UseTextOptions = true;
            this.BtnCancel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BtnCancel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.BtnCancel.AutoWidthInLayoutControl = true;
            this.BtnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.tablePanel1.SetColumn(this.BtnCancel, 1);
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.ImageOptions.Image")));
            this.BtnCancel.Location = new System.Drawing.Point(108, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.tablePanel1.SetRow(this.BtnCancel, 0);
            this.BtnCancel.Size = new System.Drawing.Size(99, 32);
            this.BtnCancel.StyleController = this.styleController1;
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Vazgeç";
            // 
            // BtnNo
            // 
            this.BtnNo.Appearance.Options.UseTextOptions = true;
            this.BtnNo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BtnNo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.BtnNo.AutoWidthInLayoutControl = true;
            this.BtnNo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.tablePanel1.SetColumn(this.BtnNo, 2);
            this.BtnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BtnNo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNo.ImageOptions.Image")));
            this.BtnNo.Location = new System.Drawing.Point(213, 3);
            this.BtnNo.Name = "BtnNo";
            this.tablePanel1.SetRow(this.BtnNo, 0);
            this.BtnNo.Size = new System.Drawing.Size(99, 32);
            this.BtnNo.StyleController = this.styleController1;
            this.BtnNo.TabIndex = 2;
            this.BtnNo.Text = "Hayır";
            // 
            // BtnYes
            // 
            this.BtnYes.Appearance.Options.UseTextOptions = true;
            this.BtnYes.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BtnYes.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.BtnYes.AutoWidthInLayoutControl = true;
            this.BtnYes.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.tablePanel1.SetColumn(this.BtnYes, 3);
            this.tablePanel1.SetColumnSpan(this.BtnYes, 0);
            this.BtnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnYes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnYes.ImageOptions.Image")));
            this.BtnYes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnYes.Location = new System.Drawing.Point(318, 3);
            this.BtnYes.Name = "BtnYes";
            this.tablePanel1.SetRow(this.BtnYes, 0);
            this.BtnYes.Size = new System.Drawing.Size(99, 32);
            this.BtnYes.StyleController = this.styleController1;
            this.BtnYes.TabIndex = 1;
            this.BtnYes.Text = "Evet";
            // 
            // lblBekle
            // 
            this.lblBekle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBekle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblBekle.ForeColor = System.Drawing.Color.White;
            this.lblBekle.Location = new System.Drawing.Point(0, 0);
            this.lblBekle.Name = "lblBekle";
            this.lblBekle.Size = new System.Drawing.Size(725, 38);
            this.lblBekle.TabIndex = 4;
            this.lblBekle.Text = "Lütfen x saniye bekleyiniz...";
            this.lblBekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(872, 243);
            this.panel3.TabIndex = 1;
            // 
            // TmrBtnEnabled
            // 
            this.TmrBtnEnabled.Interval = 1000;
            this.TmrBtnEnabled.Tick += new System.EventHandler(this.TmrBtnEnabled_Tick);
            // 
            // FrmMesajAlt
            // 
            this.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 713);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FrmMesajAlt";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FrmMesajAlt_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.StyleController styleController1;
        private System.Windows.Forms.RichTextBox TxtMesaj;
        private System.Windows.Forms.Timer TmrBtnEnabled;
        private System.Windows.Forms.Label lblBekle;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton BtnOk;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnNo;
        private DevExpress.XtraEditors.SimpleButton BtnYes;
    }
}