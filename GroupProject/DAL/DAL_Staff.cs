using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.DAL
{
    class DAL_Staff
    {
        DAL_GeneralAccess access = new DAL_GeneralAccess();
        
        string sql;

        public DataTable LoadStaffTable()
        {
            sql = "SELECT * FROM Staff";
            return access.executeQuery(sql);
        }

        public DataTable SearchStaffByName(string st_name)
        {
            sql = string.Format("SELECT * FROM Staff " +
                                "WHERE st_Name = N'{0}' ",
                                st_name);
            return access.executeQuery(sql);
        }

        public int AddStaff(string st_id, string st_name, string st_image,bool st_sex , string st_bDay, string st_phone, string st_adress, string st_local, float st_salary)
        {
            sql = string.Format("INSERT INTO Staff " +
                                "VALUES ( '{0}', N'{1}', N'{2}', {3}, '{4}', '{5}', N'{6}', N'{7}', {8} )",
                                st_id, st_name, st_image, st_sex, st_bDay, st_phone, st_adress, st_local, st_salary);

            return access.executeUpdate(sql);
        }

        public int UpdateStaff(string st_id, string st_name, string st_image, bool st_sex, string st_bDay, string st_phone, string st_adress, string st_local, float st_salary)
        {
            sql = string.Format("UPDATE Staff " +
                                "SET st_Name =  N'{1}', " +
                                    "st_Image = N'{2}', " +
                                    "st_Sex = {3}, " +
                                    "st_Bday = '{4}', " +
                                    "st_Phone = '{5}', " +
                                    "st_Adress = N'{6}', " +
                                    "st_Local = N'{7}', " +
                                    "st_Salary = {8} ) " +
                                    "WHERE st_ID = '{0}' ",
                                st_id, st_name, st_image, st_sex, st_bDay, st_phone, st_adress, st_local, st_salary);

            return access.executeUpdate(sql);
        }

        public int DeleteStaff (string st_id)
        {
            sql = string.Format("DELETE FROM Staff " +
                                "wHERE st_ID = {0}", st_id);
            
            return access.executeUpdate(sql);
        }
    }
}
