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
using DevExpress.XtraLayout.Resizing;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using DevExpress.Utils.Animation;
using DevExpress.XtraCharts.Native;
using XAct;
using System.Windows.Forms.DataVisualization.Charting;
using Chart = System.Windows.Forms.DataVisualization.Charting.Chart;


namespace DershaneOtomasyon
{
    public partial class FrmOgrenciNot : Form
    {
        public FrmOgrenciNot()
        {
            InitializeComponent();
        }
        
        sqlbaglantisi bgl = new sqlbaglantisi();
        string resim;
        void listele()
        {
         
            SqlCommand komut = new SqlCommand("Select OGRID,NOTOGRNO,(OGRAD+' '+OGRSOYAD) as 'OGR ADSOYAD',OGRBRANS," +
              "OGRSINIF,NOTTARIHI,NOTTYT,NOTAYTSAY,NOTAYTSOZ,NOTAYTEA,OGRFOTO from TBL_OGRENCILER inner join TBL_NOT on" +
              " TBL_NOT.NOTOGRNO=TBL_OGRENCILER.OGRNO where NOTOGRNO=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
          
            if (dr.Read())
            {
                Txtadsoyad.Text = dr["OGR ADSOYAD"].ToString();
                TxtBrans.Text = dr["OGRBRANS"].ToString();
                Txtid.Text = dr["OGRID"].ToString();
                Txtsinif.Text = dr["OGRSINIF"].ToString();
                MskNotTrh.Text = dr["NOTTARIHI"].ToString();
                resim = "C:\\Users\\yucel\\Desktop\\OtomasyonProje\\DershaneOtomasyon\\DershaneOtomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(resim);

                
            }


            else
            {
                MessageBox.Show("Hatalı Öğrenci Numarası");
                TxtNo.Text = "";
                Txtid.Text = "";
            }

            bgl.baglanti().Close();

        }
        
       
        void gridviev(string veriler)
        {

           
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(veriler,bgl.baglanti());

            if (da != null)
            {
                da.Fill(ds);
              
                gridControl1.DataSource = ds.Tables[0];
             
                gridView1.OptionsBehavior.Editable = false;
            }
        
        }

       
        private void Btnogrno_Click(object sender, EventArgs e)
        {
            listele();
           
            gridviev("Select NOTOGRNO,NOTTARIHI,NOTTYT,NOTAYTSAY,NOTAYTSOZ,NOTAYTEA from TBL_NOT where NOTOGRNO like '%" + TxtNo.Text + "%'");
            tyt();

        }

       void tyt()
        {



            SqlCommand komut = new SqlCommand("Select NOTTARIHI,NOTTYT,NOTAYTSAY,NOTAYTSOZ,NOTAYTEA from TBL_NOT where NOTOGRNO like '" + TxtNo.Text + "'", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            while (oku.Read())
            {
                
                chart1.Series["TYT"].Points.AddXY(oku[0].ToString(), oku[1].ToString());
                chart1.Series["AYTSAY"].Points.AddXY(oku[0].ToString(), oku[2].ToString());
                chart1.Series["AYTSOZ"].Points.AddXY(oku[0].ToString(), oku[3].ToString());
                chart1.Series["AYTEA"].Points.AddXY(oku[0].ToString(), oku[4].ToString());
           
            }
            bgl.baglanti().Close();


        }

        private void BtnTyt_Click(object sender, EventArgs e)
        {
            chart1.Series["TYT"].ChartType=SeriesChartType.Column;
            chart1.Series["AYTSAY"].ChartType = SeriesChartType.Column;
            chart1.Series["AYTSOZ"].ChartType = SeriesChartType.Column;
            chart1.Series["AYTEA"].ChartType = SeriesChartType.Column;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            chart1.Series["TYT"].ChartType = SeriesChartType.Bar;
            chart1.Series["AYTSAY"].ChartType = SeriesChartType.Bar;
            chart1.Series["AYTSOZ"].ChartType = SeriesChartType.Bar;
            chart1.Series["AYTEA"].ChartType = SeriesChartType.Bar;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            chart1.Series["TYT"].ChartType = SeriesChartType.Point;
            chart1.Series["AYTSAY"].ChartType = SeriesChartType.Point;
            chart1.Series["AYTSOZ"].ChartType = SeriesChartType.Point;
            chart1.Series["AYTEA"].ChartType = SeriesChartType.Point;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            chart1.Series["TYT"].ChartType = SeriesChartType.Line;
            chart1.Series["AYTSAY"].ChartType = SeriesChartType.Line;
            chart1.Series["AYTSOZ"].ChartType = SeriesChartType.Line;
            chart1.Series["AYTEA"].ChartType = SeriesChartType.Line;
        }
    }
}
