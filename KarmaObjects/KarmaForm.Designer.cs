namespace KarmaObjects
{
    partial class KarmaForm
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
        ///
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KarmaForm));
            this.PnlNavigator = new KarmaObjects.KarmaPanel(this.components);
            this.BtnNew = new KarmaObjects.KarmaButton(this.components);
            this.BtnDelete = new KarmaObjects.KarmaButton(this.components);
            this.BtnClear = new KarmaObjects.KarmaButton(this.components);
            this.BtnSave = new KarmaObjects.KarmaButton(this.components);
            this.BtnFirst = new KarmaObjects.KarmaButton(this.components);
            this.BtnPrevious = new KarmaObjects.KarmaButton(this.components);
            this.BtnNext = new KarmaObjects.KarmaButton(this.components);
            this.BtnLast = new KarmaObjects.KarmaButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PnlNavigator)).BeginInit();
            this.PnlNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlNavigator
            // 
            this.PnlNavigator.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.PnlNavigator.Controls.Add(this.BtnNew);
            this.PnlNavigator.Controls.Add(this.BtnDelete);
            this.PnlNavigator.Controls.Add(this.BtnClear);
            this.PnlNavigator.Controls.Add(this.BtnSave);
            this.PnlNavigator.Controls.Add(this.BtnFirst);
            this.PnlNavigator.Controls.Add(this.BtnPrevious);
            this.PnlNavigator.Controls.Add(this.BtnNext);
            this.PnlNavigator.Controls.Add(this.BtnLast);
            this.PnlNavigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlNavigator.KarmaChildPanels = null;
            this.PnlNavigator.KarmaColumnNames = null;
            this.PnlNavigator.KarmaGridControl = null;
            this.PnlNavigator.KarmaMasterButton = null;
            this.PnlNavigator.KarmaMasterTextBox = null;
            this.PnlNavigator.KarmaSecTextBox = null;
            this.PnlNavigator.KarmaTableName = null;
            this.PnlNavigator.Location = new System.Drawing.Point(0, 0);
            this.PnlNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PnlNavigator.Name = "PnlNavigator";
            this.PnlNavigator.ShowCaption = false;
            this.PnlNavigator.Size = new System.Drawing.Size(1105, 26);
            this.PnlNavigator.TabIndex = 1;
            // 
            // BtnNew
            // 
            this.BtnNew.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnNew.Appearance.Options.UseForeColor = true;
            this.BtnNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.ImageOptions.Image")));
            this.BtnNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnNew.KarmaButtonType = KarmaObjects.KarmaButtonTypes.Özel;
            this.BtnNew.KarmaMasterPanel = null;
            this.BtnNew.KarmaMasterTextBox = null;
            this.BtnNew.Location = new System.Drawing.Point(823, 2);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(35, 22);
            this.BtnNew.TabIndex = 4;
            this.BtnNew.TabStop = false;
            this.BtnNew.TasinabilirMi = false;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Appearance.Options.UseForeColor = true;
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnDelete.KarmaButtonType = KarmaObjects.KarmaButtonTypes.Özel;
            this.BtnDelete.KarmaMasterPanel = null;
            this.BtnDelete.KarmaMasterTextBox = null;
            this.BtnDelete.Location = new System.Drawing.Point(858, 2);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(35, 22);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.TabStop = false;
            this.BtnDelete.TasinabilirMi = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Appearance.Options.UseForeColor = true;
            this.BtnClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.ImageOptions.Image")));
            this.BtnClear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnClear.KarmaButtonType = KarmaObjects.KarmaButtonTypes.Özel;
            this.BtnClear.KarmaMasterPanel = null;
            this.BtnClear.KarmaMasterTextBox = null;
            this.BtnClear.Location = new System.Drawing.Point(893, 2);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(35, 22);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.TabStop = false;
            this.BtnClear.TasinabilirMi = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Appearance.Options.UseForeColor = true;
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnSave.KarmaButtonType = KarmaObjects.KarmaButtonTypes.Özel;
            this.BtnSave.KarmaMasterPanel = null;
            this.BtnSave.KarmaMasterTextBox = null;
            this.BtnSave.Location = new System.Drawing.Point(928, 2);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(35, 22);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.TabStop = false;
            this.BtnSave.TasinabilirMi = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnFirst
            // 
            this.BtnFirst.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnFirst.Appearance.Options.UseForeColor = true;
            this.BtnFirst.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnFirst.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnFirst.ImageOptions.Image")));
            this.BtnFirst.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnFirst.KarmaButtonType = KarmaObjects.KarmaButtonTypes.Özel;
            this.BtnFirst.KarmaMasterPanel = null;
            this.BtnFirst.KarmaMasterTextBox = null;
            this.BtnFirst.Location = new System.Drawing.Point(963, 2);
            this.BtnFirst.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(35, 22);
            this.BtnFirst.TabIndex = 0;
            this.BtnFirst.TabStop = false;
            this.BtnFirst.TasinabilirMi = false;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnPrevious.Appearance.Options.UseForeColor = true;
            this.BtnPrevious.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnPrevious.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrevious.ImageOptions.Image")));
            this.BtnPrevious.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnPrevious.KarmaButtonType = KarmaObjects.KarmaButtonTypes.Özel;
            this.BtnPrevious.KarmaMasterPanel = null;
            this.BtnPrevious.KarmaMasterTextBox = null;
            this.BtnPrevious.Location = new System.Drawing.Point(998, 2);
            this.BtnPrevious.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(35, 22);
            this.BtnPrevious.TabIndex = 1;
            this.BtnPrevious.TabStop = false;
            this.BtnPrevious.TasinabilirMi = false;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnNext.Appearance.Options.UseForeColor = true;
            this.BtnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnNext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNext.ImageOptions.Image")));
            this.BtnNext.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnNext.KarmaButtonType = KarmaObjects.KarmaButtonTypes.Özel;
            this.BtnNext.KarmaMasterPanel = null;
            this.BtnNext.KarmaMasterTextBox = null;
            this.BtnNext.Location = new System.Drawing.Point(1033, 2);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(35, 22);
            this.BtnNext.TabIndex = 2;
            this.BtnNext.TabStop = false;
            this.BtnNext.TasinabilirMi = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnLast.Appearance.Options.UseForeColor = true;
            this.BtnLast.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnLast.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLast.ImageOptions.Image")));
            this.BtnLast.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnLast.KarmaButtonType = KarmaObjects.KarmaButtonTypes.Özel;
            this.BtnLast.KarmaMasterPanel = null;
            this.BtnLast.KarmaMasterTextBox = null;
            this.BtnLast.Location = new System.Drawing.Point(1068, 2);
            this.BtnLast.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(35, 22);
            this.BtnLast.TabIndex = 3;
            this.BtnLast.TabStop = false;
            this.BtnLast.TasinabilirMi = false;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // KarmaForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1105, 592);
            this.Controls.Add(this.PnlNavigator);
            this.Font = new System.Drawing.Font("Roboto", 9F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "KarmaForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KarmaForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PnlNavigator)).EndInit();
            this.PnlNavigator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private KarmaPanel PnlNavigator;
        private KarmaButton BtnDelete;
        private KarmaButton BtnClear;
        private KarmaButton BtnSave;
        private KarmaButton BtnNew;
        private KarmaButton BtnLast;
        private KarmaButton BtnNext;
        private KarmaButton BtnPrevious;
        private KarmaButton BtnFirst;
    }

}