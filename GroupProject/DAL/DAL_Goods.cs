using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.DAL
{
    class DAL_Goods
    {
        DAL_GeneralAccess access = new DAL_GeneralAccess();
        IDataReader reader;
        SqlCommand cmd;
        DataTable dataTable;
        int row;
        bool check;

        public DataTable LoadGoods(string kog_ID)
        {
            dataTable = new DataTable();
            using (SqlConnection conn = access.GetConnection())
            {
                access.OpenConnection(conn);
                cmd = new SqlCommand("spGetGoods", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@kog_ID", kog_ID));
                reader = cmd.ExecuteReader();
                if (reader != null)
                    dataTable.Load(reader);
                access.CloseConnection(conn);
            }
           
            return dataTable;
        }

        public int AddGoods(string g_id, string kog_id, string g_name, string g_image, string g_caption, string g_dateImport, int g_amount, string g_unit, float g_cost, float g_price)
        {
            using (SqlConnection conn = access.GetConnection())
            {
                access.OpenConnection(conn);
                cmd = new SqlCommand("spAddGoods", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@g_ID", g_id));
                cmd.Parameters.Add(new SqlParameter("@kog_ID", kog_id));
                cmd.Parameters.Add(new SqlParameter("@g_Name", g_name));
                cmd.Parameters.Add(new SqlParameter("@g_Image", g_image));
                cmd.Parameters.Add(new SqlParameter("@g_Caption", g_caption));
                cmd.Parameters.Add(new SqlParameter("@g_DateImport", g_dateImport));
                cmd.Parameters.Add(new SqlParameter("@g_Amount", g_amount));
                cmd.Parameters.Add(new SqlParameter("@g_Unit", g_unit));
                cmd.Parameters.Add(new SqlParameter("@g_Cost", g_cost));
                cmd.Parameters.Add(new SqlParameter("@g_Price", g_price));
                row = cmd.ExecuteNonQuery();
                access.CloseConnection(conn);
            }

            return row;
        }

        public int UpdateGoods(string g_id, string kog_id, string g_name, string g_image, string g_caption, string g_dateImport, int g_amount, string g_unit, float g_cost, float g_price)
        {
            using (SqlConnection conn = access.GetConnection())
            {
                access.OpenConnection(conn);
                cmd = new SqlCommand("spUpdateGoods", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@g_ID", g_id));
                cmd.Parameters.Add(new SqlParameter("@kog_ID", kog_id));
                cmd.Parameters.Add(new SqlParameter("@g_Name", g_name));
                cmd.Parameters.Add(new SqlParameter("@g_Image", g_image));
                cmd.Parameters.Add(new SqlParameter("@g_Caption", g_caption));
                cmd.Parameters.Add(new SqlParameter("@g_DateImport", g_dateImport));
                cmd.Parameters.Add(new SqlParameter("@g_Amount", g_amount));
                cmd.Parameters.Add(new SqlParameter("@g_Unit", g_unit));
                cmd.Parameters.Add(new SqlParameter("@g_Cost", g_cost));
                cmd.Parameters.Add(new SqlParameter("@g_Price", g_price));
                row = cmd.ExecuteNonQuery();
                access.CloseConnection(conn);
            }

            return row;
        }

        public bool DellGoods(string g_Id)
        {

            using (SqlConnection conn = access.GetConnection())
            {
                access.OpenConnection(conn);
                cmd = new SqlCommand("spDeleteGoods", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@g_ID", g_Id));
                check = cmd.ExecuteNonQuery() == 1 ? true : false;
                access.CloseConnection(conn);
            }

            return check;
        }

        public DataTable SearchGoods(string g_Name)
        {
            dataTable = new DataTable();
            using (SqlConnection conn = access.GetConnection())
            {
                access.OpenConnection(conn);
                cmd = new SqlCommand("spFindGoods", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@g_Name", g_Name));
                reader = cmd.ExecuteReader();
                if (reader != null)
                    dataTable.Load(reader);
                access.CloseConnection(conn);
            }

            return dataTable;
        }
    }
}
