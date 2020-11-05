using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.DAL
{
    class DAL_KindOfGoods
    {
        DAL_GeneralAccess access = new DAL_GeneralAccess();
        IDataReader reader;
        SqlCommand cmd;
        DataTable dataTable;
        int row;
        bool check;

        public DataTable LoadKindOfGoods()
        {
            dataTable = new DataTable();
            new SqlDataAdapter("spGetKindOfGoods", access.GetConnection()).Fill(dataTable);

            return dataTable;
        }

        public int AddKindOfGoods(string kog_Id, string kog_Name)
        {
            using (SqlConnection conn = access.GetConnection())
            {
                access.OpenConnection(conn);
                cmd = new SqlCommand("spAddKindOfGoods", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@kog_ID", kog_Id));
                cmd.Parameters.Add(new SqlParameter("@kog_Name", kog_Name));
                row = cmd.ExecuteNonQuery();
                access.CloseConnection(conn);
            }

            return row;
        }

        public bool UpdateKindOfGoods(string kog_Id, string kog_Name)
        {

            using (SqlConnection conn = access.GetConnection())
            {
                access.OpenConnection(conn);
                cmd = new SqlCommand("spUpdateKindOfGoods", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@kog_ID", kog_Id));
                cmd.Parameters.Add(new SqlParameter("@kog_ID", kog_Name));
                check = cmd.ExecuteNonQuery() == 1 ? true : false;
                access.CloseConnection(conn);
            }

            return check;
        }

        public bool DellKindOfGoods(string kog_Id)
        {

            using (SqlConnection conn = access.GetConnection())
            {
                access.OpenConnection(conn);
                cmd = new SqlCommand("spDeleteKindOfGoods", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@kog_ID", kog_Id));
                check = cmd.ExecuteNonQuery() == 1 ? true : false;
                access.CloseConnection(conn);
            }

            return check;
        }

        public DataTable SearchKindOfGoods(string kog_Name)
        {
            dataTable = new DataTable();
            using (SqlConnection conn = access.GetConnection())
            {
                access.OpenConnection(conn);
                cmd = new SqlCommand("spFindKindOfGoods", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@kog_Name", kog_Name));
                reader = cmd.ExecuteReader();
                if (reader != null)
                    dataTable.Load(reader);
                access.CloseConnection(conn);
            }

            return dataTable;
        }

    }
}
