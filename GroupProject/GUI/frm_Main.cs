using GroupProject.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject.GUI
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            BLL_Main bll_Main = new BLL_Main(this);
            InitializeComponent();
            this.Load += new EventHandler(bll_Main.Form_Load);
            this.FormClosing += new FormClosingEventHandler(bll_Main.Form_Closing);
            gv_Goods.CellClick += new DataGridViewCellEventHandler(bll_Main.gv_Goods_CellClick);
            cb_boxKOProducts.SelectedIndexChanged += new EventHandler(bll_Main.cb_boxKOProducts_SelectedIndexChanged);

        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_EditStaff"] == null)
            {
                frm_EditStaff frm = new frm_EditStaff();
                frm.MdiParent = this;
                frm.Show();
            }
            else Application.OpenForms["frm_EditStaff"].Activate();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_StaffManagement"] == null)
            {
                frm_EditStaff frm = new frm_EditStaff();
                frm.MdiParent = this;
                frm.Show();
            }
            else Application.OpenForms["frm_StaffManagement"].Activate();
        }

        private void chỉnhSửaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_EditGoods"] == null)
            {
                frm_EditStaff frm = new frm_EditStaff();
                frm.MdiParent = this;
                frm.Show();
            }
            else Application.OpenForms["frm_EditGoods"].Activate();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_MaterialManagement"] == null)
            {
                frm_EditStaff frm = new frm_EditStaff();
                frm.MdiParent = this;
                frm.Show();
            }
            else Application.OpenForms["frm_MaterialManagement"].Activate();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ProductManagement"] == null)
            {
                frm_EditStaff frm = new frm_EditStaff();
                frm.MdiParent = this;
                frm.Show();
            }
            else Application.OpenForms["frm_ProductManagement"].Activate();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_BillImport"] == null)
            {
                frm_EditStaff frm = new frm_EditStaff();
                frm.MdiParent = this;
                frm.Show();
            }
            else Application.OpenForms["frm_BillImport"].Activate();
        }

        private void hóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_BILL"] == null)
            {
                frm_EditStaff frm = new frm_EditStaff();
                frm.MdiParent = this;
                frm.Show();
            }
            else Application.OpenForms["frm_BILL"].Activate();
        }
    }
}
