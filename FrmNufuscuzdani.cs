using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DershaneOtomasyon
{
    public partial class FrmNufuscuzdani : Form
    {
        public FrmNufuscuzdani()
        {
            InitializeComponent();
        }

        public string ad, soyad, no, sinif, resim;

        private void FrmNufuscuzdani_Load(object sender, EventArgs e)
        {
            LblAd.Text = ad;
            LblSoyad.Text = soyad;
            LblNo.Text = no;
            LbsSinif.Text = sinif;
            PcrResim.Image = Image.FromFile(resim);
        }
    }

}
