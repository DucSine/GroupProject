using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GroupProject.BLL
{
    class BLL_Goods
    {
        DAL.DAL_Goods dalgoods = new DAL.DAL_Goods();
        GUI.frm_Goods goods;

        public BLL_Goods(GUI.frm_Goods g) {
            goods = g;
        }

        public void LoadGoods()
        {
            goods.dgv_SanPham.DataSource = dalgoods.LoadGoodTable();
        }

        //tao ra cac ham them, sua, xoa.
        public void addGoods()
        {
            int value = dalgoods.AddGoods(goods.txt_MaBanh.Text,goods.comb_loaibanh.Text, goods.txt_TenBanh.Text,goods.txt_TenAnh.Text,
                goods.txt_GhiChu.Text, goods.date_ngaynhap.Text, int.Parse(goods.txt_SoLuong.Text), goods.txt_DonVi.Text, float.Parse(goods.txt_DonGiaNhap.Text), float.Parse(goods.txt_DonGiaBan.Text));
            if (value >= 1)
                MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bai");
        }
        public void UpdateGoods()
        {
            int value = dalgoods.UpdateGoods( goods.comb_loaibanh.Text, goods.txt_TenBanh.Text, goods.txt_TenAnh.Text,
                goods.txt_GhiChu.Text, goods.date_ngaynhap.Text, int.Parse(goods.txt_SoLuong.Text), goods.txt_DonVi.Text, float.Parse(goods.txt_DonGiaNhap.Text), float.Parse(goods.txt_DonGiaBan.Text));
            if (value >= 1)
                MessageBox.Show("Sua thành công");
            else MessageBox.Show("Sua thất bai");
        }
        public void DeleteGoods()
        {
            int ketqua = dalgoods.DeleteGoods(goods.txt_MaBanh.Text);
            if (ketqua >= 1)
                MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bai");
        }
    }
}
