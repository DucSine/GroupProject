using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GroupProject.BLL
{
    class BLL_Staff
    {
         DAL.DAL_Staff dalstaff = new DAL.DAL_Staff();
        GUI.frm_Staff staff;

        public BLL_Staff(GUI.frm_Staff s) {
            staff = s;
        }

        public void LoadStaff()
        {
            staff.dgv_NhanVien.DataSource = dalstaff.LoadStaffTable();
        }

        //tao ra cac ham them, sua, xoa.
        public void addStaff()
        {
             //lay gia tri radio
            bool valueradio;
            bool isChecked = staff.radioButton1.Checked;
            if(isChecked )
                 valueradio=true;
            else
                 valueradio=false;

            //goi toi ham addstaff va truyen tham so
            int value = dalstaff.AddStaff(staff.txt_MaNV.Text,staff.txt_HoTen.Text,staff.txt_TenAnh.Text,valueradio,staff.dt_NgaySinh.Text,
                staff.txt_SDT.Text,staff.txt_DiaChi.Text,staff.comb_vitri.Text,float.Parse(staff.txt_Luong.Text));

            if (value >= 1)
                MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bai");
        }
        public void UpdateStaff()
        {
             //lay gia tri radio
            bool valueradio;
            bool isChecked = staff.radioButton1.Checked;
            if(isChecked )
                 valueradio=true;
            else
                 valueradio=false;

            int value = dalstaff.UpdateStaff(staff.txt_MaNV.Text,staff.txt_HoTen.Text,staff.txt_TenAnh.Text,valueradio,staff.dt_NgaySinh.Text,
                staff.txt_SDT.Text,staff.txt_DiaChi.Text,staff.comb_vitri.Text,float.Parse(staff.txt_Luong.Text));
            if (value >= 1)
                MessageBox.Show("Sua thành công");
            else MessageBox.Show("Sua thất bai");
        }
        public void DeleteStaff()
        {
            int ketqua =  dalstaff.DeleteStaff(staff.txt_MaNV.Text);
            if (ketqua >= 1)
                MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bai");
        }
    }
    
}
