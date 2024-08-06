namespace DershaneOtomasyon
{
    partial class FrmNufuscuzdani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNufuscuzdani));
            this.LblAd = new DevExpress.XtraEditors.LabelControl();
            this.LblSoyad = new DevExpress.XtraEditors.LabelControl();
            this.LblNo = new DevExpress.XtraEditors.LabelControl();
            this.LbsSinif = new DevExpress.XtraEditors.LabelControl();
            this.PcrResim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PcrResim)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAd
            // 
            this.LblAd.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAd.Appearance.Options.UseFont = true;
            this.LblAd.Location = new System.Drawing.Point(124, 122);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(85, 16);
            this.LblAd.TabIndex = 0;
            this.LblAd.Text = "labelControl1";
            // 
            // LblSoyad
            // 
            this.LblSoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSoyad.Appearance.Options.UseFont = true;
            this.LblSoyad.Location = new System.Drawing.Point(124, 147);
            this.LblSoyad.Name = "LblSoyad";
            this.LblSoyad.Size = new System.Drawing.Size(85, 16);
            this.LblSoyad.TabIndex = 1;
            this.LblSoyad.Text = "labelControl2";
            // 
            // LblNo
            // 
            this.LblNo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNo.Appearance.Options.UseFont = true;
            this.LblNo.Location = new System.Drawing.Point(124, 173);
            this.LblNo.Name = "LblNo";
            this.LblNo.Size = new System.Drawing.Size(85, 16);
            this.LblNo.TabIndex = 2;
            this.LblNo.Text = "labelControl3";
            // 
            // LbsSinif
            // 
            this.LbsSinif.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbsSinif.Appearance.Options.UseFont = true;
            this.LbsSinif.Location = new System.Drawing.Point(124, 199);
            this.LbsSinif.Name = "LbsSinif";
            this.LbsSinif.Size = new System.Drawing.Size(85, 16);
            this.LbsSinif.TabIndex = 3;
            this.LbsSinif.Text = "labelControl4";
            // 
            // PcrResim
            // 
            this.PcrResim.Location = new System.Drawing.Point(304, 107);
            this.PcrResim.Name = "PcrResim";
            this.PcrResim.Size = new System.Drawing.Size(100, 117);
            this.PcrResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcrResim.TabIndex = 12;
            this.PcrResim.TabStop = false;
            // 
            // FrmNufuscuzdani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(417, 263);
            this.Controls.Add(this.PcrResim);
            this.Controls.Add(this.LbsSinif);
            this.Controls.Add(this.LblNo);
            this.Controls.Add(this.LblSoyad);
            this.Controls.Add(this.LblAd);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FrmNufuscuzdani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNufuscuzdani";
            this.Load += new System.EventHandler(this.FrmNufuscuzdani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcrResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblAd;
        private DevExpress.XtraEditors.LabelControl LblSoyad;
        private DevExpress.XtraEditors.LabelControl LblNo;
        private DevExpress.XtraEditors.LabelControl LbsSinif;
        private System.Windows.Forms.PictureBox PcrResim;
    }
}