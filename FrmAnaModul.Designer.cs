namespace DershaneOtomasyon
{
    partial class FrmAnaModul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaModul));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnOgretmen = new DevExpress.XtraBars.BarButtonItem();
            this.btnogrenciler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnVeliler = new DevExpress.XtraBars.BarButtonItem();
            this.btnotgiris = new DevExpress.XtraBars.BarButtonItem();
            this.BtnNotGrafik = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnNot = new DevExpress.XtraBars.BarButtonItem();
            this.btnayarlar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.SlateGray;
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(30, 29, 30, 29);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.BtnOgretmen,
            this.btnogrenciler,
            this.BtnVeliler,
            this.btnotgiris,
            this.BtnNotGrafik,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.BtnNot,
            this.btnayarlar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(1362, 150);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "ANA SAYFA";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // BtnOgretmen
            // 
            this.BtnOgretmen.Caption = "ÖĞRETMENLER";
            this.BtnOgretmen.Id = 2;
            this.BtnOgretmen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnOgretmen.ImageOptions.Image")));
            this.BtnOgretmen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnOgretmen.ImageOptions.LargeImage")));
            this.BtnOgretmen.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOgretmen.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnOgretmen.Name = "BtnOgretmen";
            this.BtnOgretmen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnOgretmen_ItemClick);
            // 
            // btnogrenciler
            // 
            this.btnogrenciler.Caption = "ÖĞRENCİLER";
            this.btnogrenciler.Id = 3;
            this.btnogrenciler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnogrenciler.ImageOptions.Image")));
            this.btnogrenciler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnogrenciler.ImageOptions.LargeImage")));
            this.btnogrenciler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnogrenciler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnogrenciler.Name = "btnogrenciler";
            this.btnogrenciler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // BtnVeliler
            // 
            this.BtnVeliler.Caption = "VELİLER";
            this.BtnVeliler.Id = 4;
            this.BtnVeliler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnVeliler.ImageOptions.Image")));
            this.BtnVeliler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnVeliler.ImageOptions.LargeImage")));
            this.BtnVeliler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnVeliler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnVeliler.Name = "BtnVeliler";
            this.BtnVeliler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnVeliler_ItemClick);
            // 
            // btnotgiris
            // 
            this.btnotgiris.Caption = "NOT GİRİŞİ";
            this.btnotgiris.Id = 5;
            this.btnotgiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnotgiris.ImageOptions.Image")));
            this.btnotgiris.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnotgiris.ImageOptions.LargeImage")));
            this.btnotgiris.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnotgiris.ItemAppearance.Normal.Options.UseFont = true;
            this.btnotgiris.Name = "btnotgiris";
            this.btnotgiris.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // BtnNotGrafik
            // 
            this.BtnNotGrafik.Caption = "İSTATİSTİKLER";
            this.BtnNotGrafik.Id = 6;
            this.BtnNotGrafik.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNotGrafik.ImageOptions.Image")));
            this.BtnNotGrafik.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnNotGrafik.ImageOptions.LargeImage")));
            this.BtnNotGrafik.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnNotGrafik.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnNotGrafik.Name = "BtnNotGrafik";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "REHBER";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem7.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "GİDERLER";
            this.barButtonItem8.Id = 8;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem8.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "KASA";
            this.barButtonItem9.Id = 9;
            this.barButtonItem9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.Image")));
            this.barButtonItem9.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.LargeImage")));
            this.barButtonItem9.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem9.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "RAPORLAR";
            this.barButtonItem10.Id = 10;
            this.barButtonItem10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.Image")));
            this.barButtonItem10.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.LargeImage")));
            this.barButtonItem10.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem10.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // BtnNot
            // 
            this.BtnNot.Caption = "NOTLAR";
            this.BtnNot.Id = 11;
            this.BtnNot.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNot.ImageOptions.Image")));
            this.BtnNot.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnNot.ImageOptions.LargeImage")));
            this.BtnNot.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnNot.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnNot.Name = "BtnNot";
            this.BtnNot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnNot_ItemClick);
            // 
            // btnayarlar
            // 
            this.btnayarlar.Caption = "AYARLAR";
            this.btnayarlar.Id = 12;
            this.btnayarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnayarlar.ImageOptions.Image")));
            this.btnayarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnayarlar.ImageOptions.LargeImage")));
            this.btnayarlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnayarlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnayarlar.Name = "btnayarlar";
            this.btnayarlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem12_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "DERSHANE YÖNETİM SİSTEMİ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnOgretmen);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnogrenciler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnVeliler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnotgiris);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnNot);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnayarlar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmAnaModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1362, 711);
            this.Controls.Add(this.ribbonControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmAnaModul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GÜNEŞ DERSHANESİ";
            this.Load += new System.EventHandler(this.FrmAnaModul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem BtnOgretmen;
        private DevExpress.XtraBars.BarButtonItem btnogrenciler;
        private DevExpress.XtraBars.BarButtonItem BtnVeliler;
        private DevExpress.XtraBars.BarButtonItem btnotgiris;
        private DevExpress.XtraBars.BarButtonItem BtnNotGrafik;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem BtnNot;
        private DevExpress.XtraBars.BarButtonItem btnayarlar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    }
}

