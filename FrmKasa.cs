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
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select OGRTID,KASAID,(OGRTAD+' '+OGRTSOYAD) as OGRTADSOYAD," +
                "KASATARIH,KASAGELIR,KASAGIDER,KASABILGI,OGRTBRANS,OGRTTC,OGRTFOTO" +
                " from TBL_KASA inner join TBL_OGRETMENLER on TBL_KASA.KASAOGRTID=TBL_OGRETMENLER.OGRTID", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[7].Visible = false;
            gridView1.Columns[8].Visible = false;
            gridView1.Columns[9].Visible = false;
     
         
        }

        void OgretmenListesi()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select OGRTID,(OGRTAD+' '+OGRTSOYAD) as 'OGRT ADSOYAD',OGRTBRANS,OGRTTC,OGRTFOTO from TBL_OGRETMENLER", bgl.baglanti());
            da2.Fill(dt2);
            lookUpEdit1.Properties.ValueMember = "OGRTID";
            lookUpEdit1.Properties.DisplayMember = "OGRT ADSOYAD";
            lookUpEdit1.Properties.NullText = "Öğretmen Seçiniz";
            dt2.Columns["OGRTTC"].ColumnMapping = MappingType.Hidden;
            dt2.Columns["OGRTFOTO"].ColumnMapping = MappingType.Hidden;
        

            lookUpEdit1.Properties.DataSource = dt2;
        }
        void temizle()
        {
            txtogrtıd.Text = "";
            txtogrttc.Text = "";
            txtogrtbrans.Text = "";
            pcrogrt.Text = "";
            lookUpEdit1.Text = "";

            txtkasaıd.Text = "";
            txtkasagelir.Text = "";
            txtkasagider.Text = "";
            dtekasa.Properties.NullText = "";
            rcbbilgi.Text = "";
        }



        private void FrmKasa_Load(object sender, EventArgs e)
        {
            listele();
            OgretmenListesi();
            temizle();
        }
        string yeniyol;
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                lookUpEdit1.Text = dr["OGRTADSOYAD"].ToString();
                txtogrtıd.Text = dr["OGRTID"].ToString();
                txtogrttc.Text = dr["OGRTTC"].ToString();
                txtogrtbrans.Text = dr["OGRTBRANS"].ToString();
                yeniyol = "C:\\Users\\yucel\\Desktop\\OtomasyonProje\\DershaneOtomasyon\\DershaneOtomasyon" + "\\resimler\\" + dr["OGRTFOTO"].ToString();
                pcrogrt.Image = Image.FromFile(yeniyol);

                txtkasaıd.Text = dr["KASAID"].ToString();
                txtkasagelir.Text = dr["KASAGELIR"].ToString();
                txtkasagider.Text = dr["KASAGIDER"].ToString();
                dtekasa.Properties.NullText = dr["KASATARIH"].ToString();
                rcbbilgi.Text = dr["KASABILGI"].ToString();
                
                
            }
        }

      

        

       

        private void lookUpEdit1_Properties_EditValueChanged_1(object sender, EventArgs e)
        {

            DataRowView rv = (DataRowView)lookUpEdit1.GetSelectedDataRow();
            if (rv != null)
            {
                DataRow kyt = rv.Row;
                txtogrtıd.Text = kyt["OGRTID"].ToString();
                txtogrttc.Text = kyt["OGRTTC"].ToString();
                txtogrtbrans.Text = kyt["OGRTBRANS"].ToString();
                yeniyol = "C:\\Users\\yucel\\Desktop\\OtomasyonProje\\DershaneOtomasyon\\DershaneOtomasyon" + "\\resimler\\" + kyt["OGRTFOTO"].ToString();
                pcrogrt.Image = Image.FromFile(yeniyol);
            }
            txtkasaıd.Text = "";
            txtkasagelir.Text = "";
            txtkasagider.Text = "";
            dtekasa.Text = "";
            rcbbilgi.Text = "";

            bgl.baglanti().Close();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBL_KASA (KASAOGRTID,KASATARIH,KASAGELIR,KASAGIDER,KASABILGI) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());

            komut2.Parameters.AddWithValue("@p1", txtogrtıd.Text);
            komut2.Parameters.AddWithValue("@p2", dtekasa.Text);
            komut2.Parameters.AddWithValue("@p3", txtkasagelir.Text);
            komut2.Parameters.AddWithValue("@p4", txtkasagider.Text);
            komut2.Parameters.AddWithValue("@p5", rcbbilgi.Text);

            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Update TBL_KASA set KASAOGRTID=@p1,KASATARIH=@p2,KASAGELIR=@p3,KASAGIDER=@p4,KASABILGI=@p5 where KASAID=@p6", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", txtogrtıd.Text);
            komut3.Parameters.AddWithValue("@p2", dtekasa.Text);
            komut3.Parameters.AddWithValue("@p3", txtkasagelir.Text);
            komut3.Parameters.AddWithValue("@p4", txtkasagider.Text);
            komut3.Parameters.AddWithValue("@p5", rcbbilgi.Text);
            komut3.Parameters.AddWithValue("@p6", txtkasaıd.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listele();
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("Delete from TBL_KASA where KASAID=@p1", bgl.baglanti());
            komut4.Parameters.AddWithValue("@p1", txtkasaıd.Text);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Bilgiler Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            temizle();
            listele();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
