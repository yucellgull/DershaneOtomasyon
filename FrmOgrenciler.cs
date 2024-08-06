using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace DershaneOtomasyon
{
    public partial class FrmOgrenciler : Form
    {
        public FrmOgrenciler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            //9.SINIF
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Execute OgrenciVeli9",bgl.baglanti());
            da1.Fill(dt1);
            GrdCtrl9.DataSource = dt1;

            //10.SINIF
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Execute OgrenciVeli10", bgl.baglanti());
            da2.Fill(dt2);
            GrdCtrl10.DataSource = dt2;

            //11.SINIF
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Execute OgrenciVeli11", bgl.baglanti());
            da3.Fill(dt3);
            GrdCtrl11.DataSource = dt3;

            //12.SINIF
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Execute OgrenciVeli12", bgl.baglanti());
            da4.Fill(dt4);
            GrdCtrl12.DataSource = dt4;

            //MEZUN
            DataTable dt5 = new DataTable();
            SqlDataAdapter da5 = new SqlDataAdapter("Execute OgrenciVeliMezun", bgl.baglanti());
            da5.Fill(dt5);
            GrdCtrlMzn.DataSource = dt5;
        }

        // HATA VAR!!!!!!!!!!!!!!!!!
        
        void velilistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select VELIID ,(VELIANNE+' | '+VELIBABA) AS 'VELI ANNE BABA',VELISOYAD from TBL_VELILER", bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "VELIID";
            lookUpEdit1.Properties.DisplayMember = "VELI ANNE BABA";
            lookUpEdit1.Properties.DataSource = dt;
        }
        
        void sehirekle()
        {
            SqlCommand komut = new SqlCommand("Select * from TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbil.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        private void FrmOgrenciler_Load(object sender, EventArgs e)
        {
            listele();
            sehirekle();
            temizle();
            velilistesi();
        }

        private void Cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                Cmbilce.Properties.Items.Clear();
                Cmbilce.Text = " ";

                SqlCommand komut = new SqlCommand("Select * from TBL_ILCELER where sehir=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Cmbil.SelectedIndex + 1);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    Cmbilce.Properties.Items.Add(dr[1]);
                }
                bgl.baglanti().Close();
            }
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                TxtID.Text = dr["OGRID"].ToString();
                TxtAd.Text = dr["OGRAD"].ToString();
                TxtSoyad.Text = dr["OGRSOYAD"].ToString();
                MskTC.Text = dr["OGRTC"].ToString();
                MskOgrenciNo.Text = dr["OGRNO"].ToString();
                CmbSinif.Text = dr["OGRSINIF"].ToString();
                MskTelefon.Text = dr["OGRTEL"].ToString();

                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    RdBtnErkek.Checked = true;
                }
                else
                {
                    RdnBtnBayan.Checked = true;
                }
                CmbBrans.Text = dr["OGRBRANS"].ToString();
                Cmbil.Text = dr["OGRIL"].ToString();             
                Cmbilce.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                RchAdres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\yucel\\Desktop\\OtomasyonProje\\DershaneOtomasyon\\DershaneOtomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                PcrResim.ImageLocation = yeniyol;
                lookUpEdit1.Text = dr["VELIANNEBABA"].ToString();
            }
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            if (dr != null)
            {
                TxtID.Text = dr["OGRID"].ToString();
                TxtAd.Text = dr["OGRAD"].ToString();
                TxtSoyad.Text = dr["OGRSOYAD"].ToString();
                MskTC.Text = dr["OGRTC"].ToString();
                MskOgrenciNo.Text = dr["OGRNO"].ToString();
                CmbSinif.Text = dr["OGRSINIF"].ToString();
                MskTelefon.Text = dr["OGRTEL"].ToString();

                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    RdBtnErkek.Checked = true;
                }
                else
                {
                    RdnBtnBayan.Checked = true;
                }
                CmbBrans.Text = dr["OGRBRANS"].ToString();
                Cmbil.Text = dr["OGRIL"].ToString();
                Cmbilce.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                RchAdres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\yucel\\Desktop\\OtomasyonProje\\DershaneOtomasyon\\DershaneOtomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                PcrResim.ImageLocation = yeniyol;
                lookUpEdit1.Text = dr["VELIANNEBABA"].ToString();

            }
        }

        private void gridView3_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);

            if (dr != null)
            {
                TxtID.Text = dr["OGRID"].ToString();
                TxtAd.Text = dr["OGRAD"].ToString();
                TxtSoyad.Text = dr["OGRSOYAD"].ToString();
                MskTC.Text = dr["OGRTC"].ToString();
                MskOgrenciNo.Text = dr["OGRNO"].ToString();
                CmbSinif.Text = dr["OGRSINIF"].ToString();
                MskTelefon.Text = dr["OGRTEL"].ToString();

                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    RdBtnErkek.Checked = true;
                }
                else
                {
                    RdnBtnBayan.Checked = true;
                }
                CmbBrans.Text = dr["OGRBRANS"].ToString();
                Cmbil.Text = dr["OGRIL"].ToString();
                Cmbilce.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                RchAdres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\yucel\\Desktop\\OtomasyonProje\\DershaneOtomasyon\\DershaneOtomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                PcrResim.ImageLocation = yeniyol;
                lookUpEdit1.Text = dr["VELIANNEBABA"].ToString();
            }
        }

        private void gridView4_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView4.GetDataRow(gridView4.FocusedRowHandle);

            if (dr != null)
            {
                TxtID.Text = dr["OGRID"].ToString();
                TxtAd.Text = dr["OGRAD"].ToString();
                TxtSoyad.Text = dr["OGRSOYAD"].ToString();
                MskTC.Text = dr["OGRTC"].ToString();
                MskOgrenciNo.Text = dr["OGRNO"].ToString();
                CmbSinif.Text = dr["OGRSINIF"].ToString();
                MskTelefon.Text = dr["OGRTEL"].ToString();

                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    RdBtnErkek.Checked = true;
                }
                else
                {
                    RdnBtnBayan.Checked = true;
                }
                CmbBrans.Text = dr["OGRBRANS"].ToString();
                Cmbil.Text = dr["OGRIL"].ToString();
                Cmbilce.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                RchAdres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\yucel\\Desktop\\OtomasyonProje\\DershaneOtomasyon\\DershaneOtomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                PcrResim.ImageLocation = yeniyol;
                lookUpEdit1.Text = dr["VELIANNEBABA"].ToString();
            }
        }

        private void gridView5_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView5.GetDataRow(gridView5.FocusedRowHandle);

            if (dr != null)
            {
                TxtID.Text = dr["OGRID"].ToString();
                TxtAd.Text = dr["OGRAD"].ToString();
                TxtSoyad.Text = dr["OGRSOYAD"].ToString();
                MskTC.Text = dr["OGRTC"].ToString();
                MskOgrenciNo.Text = dr["OGRNO"].ToString();
                CmbSinif.Text = dr["OGRSINIF"].ToString();
                MskTelefon.Text = dr["OGRTEL"].ToString();

                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    RdBtnErkek.Checked = true;
                }
                else
                {
                    RdnBtnBayan.Checked = true;
                }
                CmbBrans.Text = dr["OGRBRANS"].ToString();
                Cmbil.Text = dr["OGRIL"].ToString();
                Cmbilce.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                RchAdres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\yucel\\Desktop\\OtomasyonProje\\DershaneOtomasyon\\DershaneOtomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                PcrResim.ImageLocation = yeniyol;
                lookUpEdit1.Text = dr["VELIANNEBABA"].ToString();

            }
        }

        //Kaydetme İşlemleri
        public string cinsiyet;

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_OGRENCILER" +
                "(OGRAD,OGRSOYAD,OGRTC,OGRNO,OGRSINIF,OGRTEL,OGRCINSIYET,OGRBRANS,OGRIL,OGRILCE,OGRDOGTAR,OGRADRES,OGRFOTO,OGRVELIID) " +
                "values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTC.Text);
            komut.Parameters.AddWithValue("@p4", MskOgrenciNo.Text);
            komut.Parameters.AddWithValue("@p5", CmbSinif.Text);
            komut.Parameters.AddWithValue("@p6", MskTelefon.Text);
            if (RdBtnErkek.Checked == true)
            {
                komut.Parameters.AddWithValue("@p7", cinsiyet = "E");
            }
            else
            {
                komut.Parameters.AddWithValue("@p7", cinsiyet = "B");
            }
            komut.Parameters.AddWithValue("@p8", CmbBrans.Text);
            komut.Parameters.AddWithValue("@p9", Cmbil.Text);
            komut.Parameters.AddWithValue("@p10", Cmbilce.Text);
            komut.Parameters.AddWithValue("@p11", dateEdit1.Text);
            komut.Parameters.AddWithValue("@p12", RchAdres.Text);
            komut.Parameters.AddWithValue("@p13", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p14", lookUpEdit1.EditValue);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Öğrenci Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listele();
        }
         //Resim işlemleri
        public string yeniyol;

        private void BtnResimsec_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog dosya = new OpenFileDialog();
                dosya.Filter = "Resim Dosyası |*.jpg;*.png;*nef | Tüm Dosyalar |*.*";
                dosya.ShowDialog();
                string dosyayolu = dosya.FileName;
                yeniyol = "C:\\Users\\yucel\\Desktop\\OtomasyonProje\\DershaneOtomasyon\\DershaneOtomasyon" + "\\resimler\\" + Guid.NewGuid().ToString() + ".jpg";
                File.Copy(dosyayolu, yeniyol);
                PcrResim.ImageLocation = yeniyol;

            }
        }
        //Güncelleme İşlemleri
        private void BtnGucelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_OGRENCILER set" +
                " OGRAD=@p1,OGRSOYAD=@p2,OGRTC=@p3,OGRNO=@p4,OGRSINIF=@p5,OGRTEL=@p6,OGRCINSIYET=@p7,OGRBRANS=@p8,OGRIL=@p9,OGRILCE=@p10," +
                "OGRDOGTAR=@p11,OGRADRES=@p12,OGRFOTO=@p13,OGRVELIID=@p15 where OGRID=@p14",bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTC.Text);
            komut.Parameters.AddWithValue("@p4", MskOgrenciNo.Text);
            komut.Parameters.AddWithValue("@p5", CmbSinif.Text);
            komut.Parameters.AddWithValue("@p6", MskTelefon.Text);
            if (RdBtnErkek.Checked == true)
            {
                komut.Parameters.AddWithValue("@p7", cinsiyet = "E");
            }
            else
            {
                komut.Parameters.AddWithValue("@p7", cinsiyet = "B");
            }
            komut.Parameters.AddWithValue("@p8", CmbBrans.Text);
            komut.Parameters.AddWithValue("@p9", Cmbil.Text);
            komut.Parameters.AddWithValue("@p10", Cmbilce.Text);
            komut.Parameters.AddWithValue("@p11", dateEdit1.Text);
            komut.Parameters.AddWithValue("@p12", RchAdres.Text);
            komut.Parameters.AddWithValue("@p13", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p14", TxtID.Text);
            komut.Parameters.AddWithValue("@p15", lookUpEdit1.EditValue);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Öğrenci Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listele();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_OGRENCILER where OGRID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Öğrenci Bilgileri Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            listele();
        }

        //Temizleme İşlemleri
        void temizle()
        {
            TxtID.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            MskTC.Text = "";
            MskOgrenciNo.Text = "";
            CmbSinif.Text = "";
            MskTelefon.Text = "";
            RdBtnErkek.Checked = false;
            RdnBtnBayan.Checked = false;
            CmbBrans.Text = "";
            Cmbil.Text = "";
            Cmbilce.Text = "";
            dateEdit1.Text = "";
            RchAdres.Text = "";
            PcrResim.ImageLocation = "";
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }


        public void ResimDegistir(Image resim)
        {
            PcrResim.Image = resim;
        }
        
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            FrmNufuscuzdani frm = new FrmNufuscuzdani();
            if (dr != null)
            {
                frm.ad = dr["OGRAD"].ToString();
                frm.soyad = dr["OGRSOYAD"].ToString();
                frm.no = dr["OGRNO"].ToString();
                frm.sinif = dr["OGRSINIF"].ToString();
                frm.resim= yeniyol = "C:\\Users\\yucel\\Desktop\\OtomasyonProje\\DershaneOtomasyon\\DershaneOtomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
            }
            frm.Show();

        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            FrmNufuscuzdani frm = new FrmNufuscuzdani();
            if (dr != null)
            {
                frm.ad = dr["OGRAD"].ToString();
                frm.soyad = dr["OGRSOYAD"].ToString();
                frm.no = dr["OGRNO"].ToString();
                frm.sinif = dr["OGRSINIF"].ToString();
                frm.resim = yeniyol = "C:\\Users\\yucel\\Desktop\\OtomasyonProje\\DershaneOtomasyon\\DershaneOtomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
            }
            frm.Show();
        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            FrmNufuscuzdani frm = new FrmNufuscuzdani();
            if (dr != null)
            {
                frm.ad = dr["OGRAD"].ToString();
                frm.soyad = dr["OGRSOYAD"].ToString();
                frm.no = dr["OGRNO"].ToString();
                frm.sinif = dr["OGRSINIF"].ToString();
                frm.resim = yeniyol = "C:\\Users\\yucel\\Desktop\\OtomasyonProje\\DershaneOtomasyon\\DershaneOtomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
            }
            frm.Show();
        }

        private void gridView4_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            FrmNufuscuzdani frm = new FrmNufuscuzdani();
            if (dr != null)
            {
                frm.ad = dr["OGRAD"].ToString();
                frm.soyad = dr["OGRSOYAD"].ToString();
                frm.no = dr["OGRNO"].ToString();
                frm.sinif = dr["OGRSINIF"].ToString();
                frm.resim = yeniyol = "C:\\Users\\yucel\\Desktop\\OtomasyonProje\\DershaneOtomasyon\\DershaneOtomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
            }
            frm.Show();
        }

        private void gridView5_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView5.GetDataRow(gridView5.FocusedRowHandle);
            FrmNufuscuzdani frm = new FrmNufuscuzdani();
            if (dr != null)
            {
                frm.ad = dr["OGRAD"].ToString();
                frm.soyad = dr["OGRSOYAD"].ToString();
                frm.no = dr["OGRNO"].ToString();
                frm.sinif = dr["OGRSINIF"].ToString();
                frm.resim = yeniyol = "C:\\Users\\yucel\\Desktop\\OtomasyonProje\\DershaneOtomasyon\\DershaneOtomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
            }
            frm.Show();
        }
    }
    
}
