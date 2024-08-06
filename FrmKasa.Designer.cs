namespace DershaneOtomasyon
{
    partial class FrmKasa
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasa));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pcrogrt = new DevExpress.XtraEditors.PictureEdit();
            this.txtogrtıd = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtogrtbrans = new DevExpress.XtraEditors.TextEdit();
            this.txtogrttc = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.rcbbilgi = new System.Windows.Forms.RichTextBox();
            this.dtekasa = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtkasagider = new DevExpress.XtraEditors.TextEdit();
            this.txtkasaıd = new DevExpress.XtraEditors.TextEdit();
            this.txtkasagelir = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrogrt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtogrtıd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtogrtbrans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtogrttc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtekasa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkasagider.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkasaıd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkasagelir.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(12, 271);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1330, 238);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.ShowSearchNavButtons = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // pcrogrt
            // 
            this.pcrogrt.Location = new System.Drawing.Point(264, 49);
            this.pcrogrt.Name = "pcrogrt";
            this.pcrogrt.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcrogrt.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pcrogrt.Size = new System.Drawing.Size(134, 152);
            this.pcrogrt.TabIndex = 1;
            // 
            // txtogrtıd
            // 
            this.txtogrtıd.Enabled = false;
            this.txtogrtıd.Location = new System.Drawing.Point(87, 134);
            this.txtogrtıd.Name = "txtogrtıd";
            this.txtogrtıd.Properties.Appearance.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtogrtıd.Properties.Appearance.Options.UseFont = true;
            this.txtogrtıd.Size = new System.Drawing.Size(146, 26);
            this.txtogrtıd.TabIndex = 6;
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl2.CaptionImageOptions.SvgImage")));
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.txtogrtbrans);
            this.groupControl2.Controls.Add(this.txtogrttc);
            this.groupControl2.Controls.Add(this.txtogrtıd);
            this.groupControl2.Controls.Add(this.pcrogrt);
            this.groupControl2.Controls.Add(this.lookUpEdit1);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(421, 253);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Öğretmen Bilgileri";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(9, 220);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 19);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "BRANS:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(45, 178);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(25, 19);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "TC:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(45, 137);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 19);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "ID:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(66, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(159, 19);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "ÖĞRETMEN SEÇİNİZ";
            // 
            // txtogrtbrans
            // 
            this.txtogrtbrans.Enabled = false;
            this.txtogrtbrans.Location = new System.Drawing.Point(87, 213);
            this.txtogrtbrans.Name = "txtogrtbrans";
            this.txtogrtbrans.Properties.Appearance.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtogrtbrans.Properties.Appearance.Options.UseFont = true;
            this.txtogrtbrans.Size = new System.Drawing.Size(146, 26);
            this.txtogrtbrans.TabIndex = 6;
            // 
            // txtogrttc
            // 
            this.txtogrttc.Enabled = false;
            this.txtogrttc.Location = new System.Drawing.Point(87, 175);
            this.txtogrttc.Name = "txtogrttc";
            this.txtogrttc.Properties.Appearance.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtogrttc.Properties.Appearance.Options.UseFont = true;
            this.txtogrttc.Size = new System.Drawing.Size(146, 26);
            this.txtogrttc.TabIndex = 6;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(57, 93);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.EditValueChanged += new System.EventHandler(this.lookUpEdit1_Properties_EditValueChanged_1);
            this.lookUpEdit1.Size = new System.Drawing.Size(176, 26);
            this.lookUpEdit1.TabIndex = 8;
            // 
            // groupControl3
            // 
            this.groupControl3.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl3.CaptionImageOptions.SvgImage")));
            this.groupControl3.Controls.Add(this.rcbbilgi);
            this.groupControl3.Controls.Add(this.dtekasa);
            this.groupControl3.Controls.Add(this.btntemizle);
            this.groupControl3.Controls.Add(this.btnsil);
            this.groupControl3.Controls.Add(this.btnguncelle);
            this.groupControl3.Controls.Add(this.btnkaydet);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.labelControl9);
            this.groupControl3.Controls.Add(this.txtkasagider);
            this.groupControl3.Controls.Add(this.txtkasaıd);
            this.groupControl3.Controls.Add(this.txtkasagelir);
            this.groupControl3.Location = new System.Drawing.Point(493, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(849, 253);
            this.groupControl3.TabIndex = 9;
            this.groupControl3.Text = "Kasa Bilgileri";
            // 
            // rcbbilgi
            // 
            this.rcbbilgi.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rcbbilgi.Location = new System.Drawing.Point(409, 97);
            this.rcbbilgi.Name = "rcbbilgi";
            this.rcbbilgi.Size = new System.Drawing.Size(209, 142);
            this.rcbbilgi.TabIndex = 17;
            this.rcbbilgi.Text = "";
            // 
            // dtekasa
            // 
            this.dtekasa.EditValue = null;
            this.dtekasa.Location = new System.Drawing.Point(207, 61);
            this.dtekasa.Name = "dtekasa";
            this.dtekasa.Properties.Appearance.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtekasa.Properties.Appearance.Options.UseFont = true;
            this.dtekasa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtekasa.Properties.MaskSettings.Set("mask", "d");
            this.dtekasa.Size = new System.Drawing.Size(156, 26);
            this.dtekasa.TabIndex = 16;
            // 
            // btntemizle
            // 
            this.btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntemizle.ImageOptions.Image")));
            this.btntemizle.Location = new System.Drawing.Point(681, 203);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(124, 36);
            this.btntemizle.TabIndex = 15;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnsil
            // 
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(681, 153);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(124, 36);
            this.btnsil.TabIndex = 14;
            this.btnsil.Text = "Sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelle.ImageOptions.Image")));
            this.btnguncelle.Location = new System.Drawing.Point(681, 105);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(124, 36);
            this.btnguncelle.TabIndex = 14;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(681, 57);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(124, 36);
            this.btnkaydet.TabIndex = 13;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(121, 216);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 19);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "GİDER:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(124, 166);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(51, 19);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "GELİR:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(110, 122);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(65, 19);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "KASAID:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(489, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 19);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "BİLGİ";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(63, 68);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(112, 19);
            this.labelControl9.TabIndex = 7;
            this.labelControl9.Text = "İŞLEM TARİHİ:";
            // 
            // txtkasagider
            // 
            this.txtkasagider.Location = new System.Drawing.Point(207, 213);
            this.txtkasagider.Name = "txtkasagider";
            this.txtkasagider.Properties.Appearance.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkasagider.Properties.Appearance.Options.UseFont = true;
            this.txtkasagider.Size = new System.Drawing.Size(156, 26);
            this.txtkasagider.TabIndex = 6;
            // 
            // txtkasaıd
            // 
            this.txtkasaıd.Enabled = false;
            this.txtkasaıd.Location = new System.Drawing.Point(207, 112);
            this.txtkasaıd.Name = "txtkasaıd";
            this.txtkasaıd.Properties.Appearance.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkasaıd.Properties.Appearance.Options.UseFont = true;
            this.txtkasaıd.Size = new System.Drawing.Size(156, 26);
            this.txtkasaıd.TabIndex = 6;
            // 
            // txtkasagelir
            // 
            this.txtkasagelir.EditValue = "";
            this.txtkasagelir.Location = new System.Drawing.Point(207, 163);
            this.txtkasagelir.Name = "txtkasagelir";
            this.txtkasagelir.Properties.Appearance.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkasagelir.Properties.Appearance.Options.UseFont = true;
            this.txtkasagelir.Size = new System.Drawing.Size(156, 26);
            this.txtkasagelir.TabIndex = 6;
            // 
            // FrmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 521);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmKasa";
            this.Text = "FrmKasa";
            this.Load += new System.EventHandler(this.FrmKasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrogrt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtogrtıd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtogrtbrans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtogrttc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtekasa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkasagider.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkasaıd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkasagelir.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PictureEdit pcrogrt;
        private DevExpress.XtraEditors.TextEdit txtogrtıd;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtogrtbrans;
        private DevExpress.XtraEditors.TextEdit txtogrttc;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btntemizle;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtkasagider;
        private DevExpress.XtraEditors.TextEdit txtkasaıd;
        private System.Windows.Forms.RichTextBox rcbbilgi;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dtekasa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.TextEdit txtkasagelir;
    }
}