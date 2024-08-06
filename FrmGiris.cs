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

namespace DershaneOtomasyon
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void BtnYonetici_MouseHover(object sender, EventArgs e)
        {
            BtnYonetici.Size = new Size(100, 100);
       
        }

        private void BtnYonetici_MouseLeave(object sender, EventArgs e)
        {
            BtnYonetici.Size = new Size(123, 123);
        }

        private void BtnOgretmen_MouseHover(object sender, EventArgs e)
        {
            BtnOgretmen.Size = new Size(100, 100);
        }

        private void BtnOgretmen_MouseLeave(object sender, EventArgs e)
        {
            BtnOgretmen.Size = new Size(123, 123);
        }

       

        sqlbaglantisi bgl = new sqlbaglantisi();
        DbDershaneEntities db = new DbDershaneEntities();   

        private void BtnYonetici_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select OGRTTC,OGRTSIFRE " +
                "from TBL_OGRTAYARLAR inner join TBL_OGRETMENLER on TBL_OGRTAYARLAR.OGRTAYARLARID=TBL_OGRETMENLER.OGRTID" +
                " where OGRTTC=@p1 and OGRTSIFRE=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2",TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaModul frm1 = new FrmAnaModul();
                frm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı veya Şifre");
                MskTC.Text = "";
                TxtSifre.Text = "";
            }

            bgl.baglanti().Close();
                
        }

        private void BtnOgretmen_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select OGRTTC,OGRTSIFRE " +
                "from TBL_OGRTAYARLAR inner join TBL_OGRETMENLER on TBL_OGRTAYARLAR.OGRTAYARLARID=TBL_OGRETMENLER.OGRTID" +
                " where OGRTTC=@p1 and OGRTSIFRE=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmOgretmenlerAnaModul frm2 = new FrmOgretmenlerAnaModul();
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı veya Şifre");
                MskTC.Text = "";
                TxtSifre.Text = "";
            }

            bgl.baglanti().Close();
        }

       
     
    }
}
