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
using DevExpress.Charts.Native;

namespace DershaneOtomasyon
{
    public partial class FrmNotGiris : Form
    {
        public FrmNotGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select NOTOGRID,NOTID,(OGRAD+' '+OGRSOYAD) as OGRADSOYAD,OGRBRANS,NOTTARIHI,NOTTYT,NOTAYTSAY,NOTAYTSOZ," +
                "NOTAYTEA,OGRSINIF,OGRNO,OGRTC,OGRFOTO,OGRID from TBL_OGRENCILER inner join TBL_NOT on TBL_OGRENCILER.OGRID=TBL_NOT.NOTOGRID", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[9].Visible = false;
            gridView1.Columns[10].Visible = false;
            gridView1.Columns[11].Visible = false;
            gridView1.Columns[12].Visible = false;
            gridView1.Columns[13].Visible = false;
        }
        void ogrencilistesi()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select OGRID,OGRNO,(OGRAD+' '+OGRSOYAD) as 'OGR ADSOYAD',OGRSINIF,OGRBRANS,OGRTC,OGRFOTO from TBL_OGRENCILER", bgl.baglanti());
            da2.Fill(dt2);
            lookUpEdit1.Properties.ValueMember = "OGRNO";
            lookUpEdit1.Properties.DisplayMember = "OGR ADSOYAD";
            lookUpEdit1.Properties.NullText = "Öğrenci Seçiniz";
            dt2.Columns["OGRFOTO"].ColumnMapping = MappingType.Hidden;
            dt2.Columns["OGRBRANS"].ColumnMapping = MappingType.Hidden;
            dt2.Columns["OGRTC"].ColumnMapping = MappingType.Hidden;
            dt2.Columns["OGRSINIF"].ColumnMapping = MappingType.Hidden;

            lookUpEdit1.Properties.DataSource = dt2;

        }
        void temizle()
        {
            txtnotid.Text = "";
            MskNotTrh.Text = "";
            TxtOgrno.Text = "";
            lookUpEdit1.Text = "";
            Txtbrans.Text = "";
            Txttc.Text = "";
            Txtsinif.Text = "";
            pictureEdit1.Text = "";
            TxtId.Text = "";
            TxtAytsay.Text = "";
            TxtAytsoz.Text = "";
            TxtAytea.Text = "";
            TxtTyt.Text = "";
        }
        private void FrmNotGiris_Load(object sender, EventArgs e)
        {
            listele();
            ogrencilistesi();
            temizle();
            
        }

        string yeniyol;
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["OGRID"].ToString();
                txtnotid.Text = dr["NOTID"].ToString();
                MskNotTrh.Text = dr["NOTTARIHI"].ToString();
                TxtTyt.Text = dr["NOTTYT"].ToString();
                TxtAytea.Text = dr["NOTAYTEA"].ToString();
                TxtAytsoz.Text = dr["NOTAYTSOZ"].ToString();
                TxtAytsay.Text = dr["NOTAYTSAY"].ToString();

                TxtOgrno.Text = dr["OGRNO"].ToString();               
                lookUpEdit1.Text = dr["OGRADSOYAD"].ToString();
                Txtbrans.Text = dr["OGRBRANS"].ToString();
                Txttc.Text = dr["OGRTC"].ToString();
                Txtsinif.Text = dr["OGRSINIF"].ToString();
                yeniyol = "C:\\Users\\yucel\\Desktop\\OtomasyonProje\\DershaneOtomasyon\\DershaneOtomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
            }
        }

      

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBL_NOT (NOTOGRID,NOTTYT,NOTAYTSAY,NOTAYTSOZ,NOTAYTEA,NOTTARIHI,NOTOGRNO) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtId.Text);
            komut2.Parameters.AddWithValue("@p2", TxtTyt.Text);
            komut2.Parameters.AddWithValue("@p3", TxtAytsay.Text);
            komut2.Parameters.AddWithValue("@p4", TxtAytsoz.Text);
            komut2.Parameters.AddWithValue("@p5", TxtAytea.Text);
            komut2.Parameters.AddWithValue("@p6", MskNotTrh.Text);
            komut2.Parameters.AddWithValue("@p7", TxtOgrno.Text);
            
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Update TBL_NOT set NOTTYT=@p1,NOTAYTSAY=@p2,NOTAYTSOZ=@p3,NOTAYTEA=@p4,NOTTARIHI=@p5,NOTOGRNO=@p6,NOTOGRID=@p7 where NOTID=@p8", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", TxtTyt.Text);
            komut3.Parameters.AddWithValue("@p2", TxtAytsay.Text);
            komut3.Parameters.AddWithValue("@p3", TxtAytsoz.Text);
            komut3.Parameters.AddWithValue("@p4", TxtAytea.Text);
            komut3.Parameters.AddWithValue("@p5", MskNotTrh.Text);
            komut3.Parameters.AddWithValue("@p6", TxtOgrno.Text);
            komut3.Parameters.AddWithValue("@p7", TxtId.Text);
            komut3.Parameters.AddWithValue("@p8", txtnotid.Text);

            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Notlar Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("Delete from TBL_NOT where NOTID=@p1", bgl.baglanti());
            komut4.Parameters.AddWithValue("@p1", txtnotid.Text);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Not Bilgileri Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            temizle();
            listele();
        }

       
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
        

            DataRowView rv = (DataRowView)lookUpEdit1.GetSelectedDataRow();
            if (rv != null)
            {
                DataRow kyt = rv.Row;
                TxtId.Text = kyt["OGRID"].ToString();
                TxtOgrno.Text = kyt["OGRNO"].ToString();
                Txtbrans.Text = kyt["OGRBRANS"].ToString();
                Txttc.Text = kyt["OGRTC"].ToString();
                Txtsinif.Text = kyt["OGRSINIF"].ToString();
                yeniyol = "C:\\Users\\yucel\\Desktop\\OtomasyonProje\\DershaneOtomasyon\\DershaneOtomasyon" + "\\resimler\\" + kyt["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
            }

            
            TxtAytsay.Text = "";
            TxtAytsoz.Text = "";
            TxtAytea.Text = "";
            TxtTyt.Text = "";
            txtnotid.Text = "";
            MskNotTrh.Text = "";



            bgl.baglanti().Close();

        }
    }
}
