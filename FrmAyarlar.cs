using DevExpress.Utils.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraLayout.Resizing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using XAct.Library.Settings;
using XAct;

namespace DershaneOtomasyon
{
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select OGRTID,(OGRTAD+' '+OGRTSOYAD) as OGRTADSOYAD,OGRTBRANS,OGRTTC,OGRTSIFRE,OGRTFOTO" +
                " from TBL_OGRTAYARLAR inner join TBL_OGRETMENLER on TBL_OGRTAYARLAR.OGRTAYARLARID=TBL_OGRETMENLER.OGRTID", bgl.baglanti());
            da1.Fill(dt1);
          
            gridControl1.DataSource = dt1;
            gridView1.Columns[5].Visible = false;
        }

        void OgretmenListesi()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select OGRTID,(OGRTAD+' '+OGRTSOYAD) as 'OGRT ADSOYAD',OGRTBRANS,OGRTTC,OGRTFOTO from TBL_OGRETMENLER", bgl.baglanti());
            da2.Fill(dt2);
            lookUpEditOgrt.Properties.ValueMember = "OGRTID";
            lookUpEditOgrt.Properties.DisplayMember = "OGRT ADSOYAD";
            lookUpEditOgrt.Properties.NullText = "Öğretmen Seçiniz";
            dt2.Columns["OGRTTC"].ColumnMapping = MappingType.Hidden;
            dt2.Columns["OGRTFOTO"].ColumnMapping = MappingType.Hidden;
            lookUpEditOgrt.Properties.DataSource = dt2;
        }
        void temizle()
        {
            TxtOgrtID.Text = "";

            TxtOgrtBrans.Text = "";


            TxtOgrtSifre.Text = "";
            MskOgrtTC.Text = "";

            pictureEdit1.Text = "";

            lookUpEditOgrt.Text = "";

            lookUpEditOgrt.Properties.NullText = "Öğretmen Seçiniz";

        }

        public string yeniyol;
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtOgrtID.Text = dr["OGRTID"].ToString();
                lookUpEditOgrt.Text = dr["OGRTADSOYAD"].ToString();
                TxtOgrtBrans.Text = dr["OGRTBRANS"].ToString();
                MskOgrtTC.Text = dr["OGRTTC"].ToString();
                TxtOgrtSifre.Text = dr["OGRTSIFRE"].ToString();
                yeniyol = "C:\\Users\\yucel\\Desktop\\OtomasyonProje\\DershaneOtomasyon\\DershaneOtomasyon" + "\\resimler\\" + dr["OGRTFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            OgretmenListesi();
            temizle();
        }

        private void lookUpEditOgrt_Properties_EditValueChanged(object sender, EventArgs e)
        {
            TxtOgrtSifre.Text = "";
            DataRowView rv = (DataRowView)lookUpEditOgrt.GetSelectedDataRow();
            DataRow kyt = rv.Row;
             TxtOgrtID.Text = kyt["OGRTID"].ToString();
                TxtOgrtBrans.Text = kyt["OGRTBRANS"].ToString();
                MskOgrtTC.Text = kyt["OGRTTC"].ToString();
                yeniyol = "C:\\Users\\yucel\\Desktop\\OtomasyonProje\\DershaneOtomasyon\\DershaneOtomasyon" + "\\resimler\\" + kyt["OGRTFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);


            bgl.baglanti().Close();

            
        }
     
        private void gridView1_FocusedRowObjectChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtOgrtID.Text = dr["OGRTID"].ToString();
                lookUpEditOgrt.Text = dr["OGRTADSOYAD"].ToString();
                TxtOgrtBrans.Text = dr["OGRTBRANS"].ToString();
                MskOgrtTC.Text = dr["OGRTTC"].ToString();
                TxtOgrtSifre.Text = dr["OGRTSIFRE"].ToString();
                yeniyol = "C:\\Users\\yucel\\Desktop\\OtomasyonProje\\DershaneOtomasyon\\DershaneOtomasyon" + "\\resimler\\" + dr["OGRTFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
            }
        }

        private void BtnOgrtKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBL_OGRTAYARLAR (OGRTAYARLARID,OGRTSIFRE) values (@p1,@p2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtOgrtID.Text);
            komut2.Parameters.AddWithValue("@p2", TxtOgrtSifre.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şifre Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listele();
            temizle();
        }

        private void BtnOgrtGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Update TBL_OGRTAYARLAR set OGRTSIFRE=@p1 where OGRTAYARLARID=@p2", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", TxtOgrtSifre.Text);
            komut3.Parameters.AddWithValue("@p2", TxtOgrtID.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şifre Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listele();
            temizle();
        }

        private void BtnOgrtTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
