using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//  ENTİTİES KULLANARAK TABLOLARIMIZI SINIFLARA DÖNÜŞTÜRDÜK
namespace DershaneOtomasyon
{
    public partial class FrmVeliler : Form
    {
        public FrmVeliler()
        {
            InitializeComponent();
        }
        DbDershaneEntities db = new DbDershaneEntities();

       //entities kullanarak aldığımız öğrenci bilgilerini listeliyoruz
        void listele()
        {
            using (DbDershaneEntities db = new DbDershaneEntities())
            {

                var query = from item in db.TBL_VELILER
                            select new { item.VELIID, item.VELIANNE, item.VELIBABA, item.VELISOYAD, item.VELITEL1, item.VELITEL2, item.VELIMAIL };
                gridControl1.DataSource = query.ToList();
            }
        }

       
        void temizle()
        {
            Txtsoyad.Text = "";
            TxtID.Text = "";
            TxtAnne.Text = "";
            TxtBaba.Text = "";
            MskTel1.Text = "";
            MskTel2.Text = "";
            TxtMail.Text = "";
        }
        private void FrmVeliler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            using (DbDershaneEntities db = new DbDershaneEntities())
            {

                TBL_VELILER veli = new TBL_VELILER();
                veli.VELIANNE = TxtAnne.Text;
                veli.VELIBABA = TxtBaba.Text;
                veli.VELISOYAD = Txtsoyad.Text;
                veli.VELITEL1 = MskTel1.Text;
                veli.VELITEL2 = MskTel2.Text;
                veli.VELIMAIL = TxtMail.Text;

                db.TBL_VELILER.Add(veli);
                db.SaveChanges();
            }
            listele();
            temizle();


        }

        private void BtnGucelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"VELIID").ToString());
            using (DbDershaneEntities db = new DbDershaneEntities())
            {
                var item = db.TBL_VELILER.FirstOrDefault(x => x.VELIID == id);
                item.VELIANNE = TxtAnne.Text;
                item.VELIBABA = TxtBaba.Text;
                item.VELISOYAD = Txtsoyad.Text;
                item.VELITEL1 = MskTel1.Text;
                item.VELITEL2 = MskTel2.Text;
                item.VELIMAIL = TxtMail.Text;

                db.SaveChanges();
            }
                listele();
                temizle();

            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIID").ToString());
            using (DbDershaneEntities db = new DbDershaneEntities())
            {
                var item = db.TBL_VELILER.First(x=>x.VELIID==id);
                db.TBL_VELILER.Remove(item);

                db.SaveChanges();
                listele();
            }
        }       

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIID").ToString();
            TxtAnne.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIANNE").ToString();
            TxtBaba.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIBABA").ToString();
            Txtsoyad.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELISOYAD").ToString();
            MskTel1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELITEL1").ToString();
            MskTel2.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELITEL2").ToString(); 
            TxtMail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIMAIL").ToString();

        }
    }
}
