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
    public partial class FrmOgretmenlerAnaModul : Form
    {
        public FrmOgretmenlerAnaModul()
        {
            InitializeComponent();
        }
     
        FrmOgrenciler frm2;
        FrmVeliler frm3;
        FrmNotGiris frm5;
        FrmOgrenciNot frm6;
        FrmAnasayfa frm7;
    
       

      

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new FrmOgrenciler();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }

        private void BtnVeliler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new FrmVeliler();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frm5 == null || frm5.IsDisposed)
            {
                frm5 = new FrmNotGiris();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }

        private void BtnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm6 == null || frm6.IsDisposed)
            {
                frm6 = new FrmOgrenciNot();
                frm6.MdiParent = this;
                frm6.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm7 == null || frm7.IsDisposed)
            {
                frm7 = new FrmAnasayfa();
                frm7.MdiParent = this;
                frm7.Show();
            }
        }

        private void FrmOgretmenlerAnaModul_Load(object sender, EventArgs e)
        {
            if (frm7 == null || frm7.IsDisposed)
            {
                frm7 = new FrmAnasayfa();
                frm7.MdiParent = this;
                frm7.Show();
            }
        }
    }
}
