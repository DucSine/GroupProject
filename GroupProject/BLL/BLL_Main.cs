using GroupProject.DAL;
using GroupProject.GUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject.BLL
{
    class BLL_Main
    {
        frm_Main f_Main;
        DAL_Goods dal_Goods = new DAL_Goods();
        DAL_KindOfGoods dal_KindOfGoods = new DAL_KindOfGoods();
        public BLL_Main( frm_Main _f_Main)
        {
            f_Main = _f_Main;
        }

        public void Form_Load(object sender, EventArgs e)
        {
            ArrayList message_List = new System.Collections.ArrayList();
            Dictionary<string, string> kog_list = new Dictionary<string, string>();
            kog_list.Add("all", "Tất cả");
           // list message hien thi thong baos
            f_Main.listbox_Message.DataSource = message_List;
            f_Main.cb_boxKOProducts.DataSource = dal_KindOfGoods.LoadKindOfGoods("goods");
            f_Main.cb_boxKOProducts.DisplayMember = "kog_Name";
            f_Main.cb_boxKOProducts.ValueMember = "kog_ID";
            f_Main.gv_Goods.DataSource = dal_Goods.LoadGoods("B001");


            // hien thi san pham



        }

        public void cb_boxKOProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kog_ID = f_Main.cb_boxKOProducts.SelectedValue.ToString();
            f_Main.gv_Goods.DataSource = dal_Goods.LoadGoods(kog_ID);
        }

        public void Form_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
                Application.Exit();
            else
                e.Cancel = true;
        }

        public void gv_Goods_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
