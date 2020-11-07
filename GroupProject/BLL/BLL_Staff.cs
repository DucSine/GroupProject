using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GroupProject.BLL
{

    class BLL_Staff
    {
        DAL.DAL_Staff dalstaff= new DAL.DAL_Staff();
        GUI.frm_StaffManagement GUIStaffM = new GUI.frm_StaffManagement();
        GUI.frm_EditStaff staff;

        public BLL_Staff(GUI.frm_EditStaff edits)
        {
            staff = edits;
        }

        public void LoadGUIStaffM()
        {
            GUIStaffM.gv_Staff.DataSource = dalstaff.LoadStaffTable();
        }

        public void UpdateStaff()
        {
            //lay gia tri radio
            bool valueradio;
            bool isChecked = staff.rbt_male.Checked;
            if (isChecked)
                valueradio = true;
            else
                valueradio = false;

            int value = dalstaff.UpdateStaff(staff.lb_uID_st_ID.Text, staff.txt_HoTen.Text, staff.txt_TenAnh.Text, valueradio, staff.dt_NgaySinh.Text,
                staff.txt_SDT.Text, staff.txt_DiaChi.Text, staff.comb_ViTri.Text, float.Parse(staff.txt_Luong.Text));
            if (value >= 1)
                MessageBox.Show("Sua thành công");
            else MessageBox.Show("Sua thất bai");
        }
        public void Cancel()
        {
            staff.Close();
        }
    }
}
