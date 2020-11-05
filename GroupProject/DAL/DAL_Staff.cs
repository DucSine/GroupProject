using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.DAL
{
    class DAL_Staff
    {
        DAL_GeneralAccess access = new DAL_GeneralAccess();
        IDataReader reader;
        SqlCommand cmd;
        DataTable dataTable;
        int row;
        bool check;
        string sql;

        public DataTable LoadStaffTable()
        {
            dataTable = new DataTable();
            new SqlDataAdapter("spGetStaff", access.GetConnection()).Fill(dataTable);

            return dataTable;
        }

        public int AddStaff(string st_id, string st_name, string st_image,bool st_sex , string st_bDay, string st_phone, string st_adress, string st_local, float st_salary)
        {
            using (SqlConnection conn = access.GetConnection())
            {
                access.OpenConnection(conn);
                cmd = new SqlCommand("spAddStaff", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@st_ID", st_id));
                cmd.Parameters.Add(new SqlParameter("@st_Name", st_name));
                cmd.Parameters.Add(new SqlParameter("@st_Image", st_image));
                cmd.Parameters.Add(new SqlParameter("@st_Sex", st_sex));
                cmd.Parameters.Add(new SqlParameter("@st_Bday", st_bDay));
                cmd.Parameters.Add(new SqlParameter("@st_Phone", st_phone));
                cmd.Parameters.Add(new SqlParameter("@st_Adress", st_adress));
                cmd.Parameters.Add(new SqlParameter("@st_Local", st_local));
                cmd.Parameters.Add(new SqlParameter("@st_Salary", st_salary));
                row = cmd.ExecuteNonQuery();
                access.CloseConnection(conn);
            }

            return row;
        }

        public int UpdateStaff(string st_id, string st_name, string st_image, bool st_sex, string st_bDay, string st_phone, string st_adress, string st_local, float st_salary)
        {
            using (SqlConnection conn = access.GetConnection())
            {
                access.OpenConnection(conn);
                cmd = new SqlCommand("spUpdateStaff", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@st_ID", st_id));
                cmd.Parameters.Add(new SqlParameter("@st_Name", st_name));
                cmd.Parameters.Add(new SqlParameter("@st_Image", st_image));
                cmd.Parameters.Add(new SqlParameter("@st_Sex", st_sex));
                cmd.Parameters.Add(new SqlParameter("@st_Bday", st_bDay));
                cmd.Parameters.Add(new SqlParameter("@st_Phone", st_phone));
                cmd.Parameters.Add(new SqlParameter("@st_Adress", st_adress));
                cmd.Parameters.Add(new SqlParameter("@st_Local", st_local));
                cmd.Parameters.Add(new SqlParameter("@st_Salary", st_salary));
                row = cmd.ExecuteNonQuery();
                access.CloseConnection(conn);
            }

            return row;
        }

        public bool DeleteStaff (string st_id)
        {
            using (SqlConnection conn = access.GetConnection())
            {
                access.OpenConnection(conn);
                cmd = new SqlCommand("spDeleteStaff", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@st_ID", st_id));
                check = cmd.ExecuteNonQuery() == 1 ? true : false;
                access.CloseConnection(conn);
            }

            return check;
        }
        //
        public DataTable SearchStaffByName(string st_name)
        {
            dataTable = new DataTable();
            using (SqlConnection conn = access.GetConnection())
            {
                access.OpenConnection(conn);
                cmd = new SqlCommand("spFindStaff", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@st_Name", st_name));
                reader = cmd.ExecuteReader();
                if (reader != null)
                    dataTable.Load(reader);
                access.CloseConnection(conn);
            }

            return dataTable;
        }
    }
}
