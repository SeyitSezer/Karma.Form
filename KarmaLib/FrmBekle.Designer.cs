namespace KarmaLib
{
    partial class FrmBekle
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
            this.WaitPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            this.TmrGenel = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // WaitPanel
            // 
            this.WaitPanel.AnimationToTextDistance = 20;
            this.WaitPanel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.WaitPanel.Appearance.Options.UseBackColor = true;
            this.WaitPanel.Caption = "İşlem Devam Ediyor";
            this.WaitPanel.CaptionToDescriptionDistance = 20;
            this.WaitPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.WaitPanel.Description = "Lütfen Bekleyiniz...";
            this.WaitPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WaitPanel.ImageHorzOffset = 10;
            this.WaitPanel.Location = new System.Drawing.Point(0, 0);
            this.WaitPanel.Name = "WaitPanel";
            this.WaitPanel.Size = new System.Drawing.Size(261, 84);
            this.WaitPanel.TabIndex = 0;
            this.WaitPanel.Text = "WaitPanel";
            this.WaitPanel.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // TmrGenel
            // 
            this.TmrGenel.Tick += new System.EventHandler(this.TmrGenel_Tick);
            // 
            // FrmBekle
            // 
            this.Appearance.BackColor = System.Drawing.Color.Blue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 318);
            this.Controls.Add(this.WaitPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FrmBekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmBekle";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBekle_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWaitForm.ProgressPanel WaitPanel;
        private System.Windows.Forms.Timer TmrGenel;
    }
}