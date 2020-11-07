using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GroupProject.BLL
{
 
    class BLL_Goods
    {
        DAL.DAL_Goods dalgoods = new DAL.DAL_Goods();
        GUI.frm_EditGoods goods;
        GUI.frm_ProductManagement product = new GUI.frm_ProductManagement();

        public BLL_Goods(GUI.frm_EditGoods editg)
        {
            goods = editg;
        }

        public void LoadGoods()
        {
            product.gv_Product.DataSource = dalgoods.LoadGoods();
        }

       
        public void UpdateGoods()
        {
            int value = dalgoods.UpdateGoods(goods.lb_uID_g_ID.Text,goods.comb_LoaiBanh.Text, goods.txt_TenBanh.Text, goods.txt_TenAnh.Text,
                goods.txt_MoTa.Text, goods.date_NgayNhap.Text, int.Parse(goods.txt_SoLuong.Text), goods.txt_DonVi.Text, float.Parse(goods.txt_MoTa.Text), float.Parse(goods.txt_Gia.Text));
            if (value >= 1)
                MessageBox.Show("Sua thành công");
            else MessageBox.Show("Sua thất bai");
        }
        public void Cancel()
        {
            goods.Close();
        }
    }
}
