using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using DevExpress.XtraReports.Native.CodeCompletion;

namespace DershaneOtomasyon
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();


        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            Ogretmenler();
            OgrencilerSutun();
            OgrencilerPasta();
           
        }



        void Ogretmenler()
        {
            SqlCommand komut = new SqlCommand("Select OGRTBRANS as 'Brans',COUNT(OGRTID) as 'Toplam' from TBL_OGRETMENLER group by OGRTBRANS ", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();

            foreach (var series in chartogrt.Series)
            {
                series.Points.Clear();

            }

            while (oku.Read())
            {

                chartogrt.Series["Ogretmenler"].Points.AddXY(oku[0].ToString(), oku[1].ToString());

            }
            bgl.baglanti().Close();
        }


        void OgrencilerPasta()
        {
            SqlCommand komut2 = new SqlCommand("Select OGRSINIF as 'Sınıf',COUNT(OGRID) as 'Toplam' from TBL_OGRENCILER group by OGRSINIF ", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();

            }

            while (oku2.Read())
            {

                chart1.Series["Ogrenciler"].Points.AddXY(oku2[0].ToString(), oku2[1].ToString());

            }
            bgl.baglanti().Close();
        }
        void OgrencilerSutun()
        {
            SqlCommand komut2 = new SqlCommand("Select OGRSINIF as 'Sınıf',COUNT(OGRID) as 'Toplam' from TBL_OGRENCILER group by OGRSINIF ", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();

            foreach (var series in chartogr.Series)
            {
                series.Points.Clear();

            }

            while (oku2.Read())
            {

                chartogr.Series["Ogrenciler"].Points.AddXY(oku2[0].ToString(), oku2[1].ToString());

            }
            bgl.baglanti().Close();
        }
        void Notlar()
        {
            SqlCommand komut = new SqlCommand("Select NOTTARIHI,NOTTYT,NOTAYTSAY,NOTAYTSOZ,NOTAYTEA from TBL_NOT where NOTOGRNO like '" + txtogrno.Text + "'", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();

            foreach (var series in chartnot.Series)
            {
                series.Points.Clear();
            }
            while (oku.Read())
            {

                chartnot.Series["TYT"].Points.AddXY(oku[0].ToString(), oku[1].ToString());
                chartnot.Series["AYTSAY"].Points.AddXY(oku[0].ToString(), oku[2].ToString());
                chartnot.Series["AYTSOZ"].Points.AddXY(oku[0].ToString(), oku[3].ToString());
                chartnot.Series["AYTEA"].Points.AddXY(oku[0].ToString(), oku[4].ToString());

            }
            bgl.baglanti().Close();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Notlar();
        }
    }
}
