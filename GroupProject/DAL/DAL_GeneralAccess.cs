using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.DAL
{
    class DAL_GeneralAccess
    {
        bool check = false;

        public DAL_GeneralAccess()
        {
            //Constructor
        }

        internal SqlConnection GetConnection()
        {
            //Get connection
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\thanh\Source\Repos\DucSine\GroupProject\GroupProject\BakeryManagement.mdf;Integrated Security=True";
            return new SqlConnection(connectionString);
        }

        internal void OpenConnection(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        internal void CloseConnection(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public bool executeCheck(string sql)
        {
            /** execute query:
             * check login
             * check ID already exists ?
             */
            using (SqlConnection connection = GetConnection())
            {
                OpenConnection(connection);
                IDataReader reader = new SqlCommand(sql, connection).ExecuteReader();
                check = reader.Read();
                CloseConnection(connection);
            }
            return check;
        }

        public DataTable executeQuery(string sql)
        {
            // execute  select query 
            DataTable dt = new DataTable();
            new SqlDataAdapter(sql, GetConnection()).Fill(dt);

            return dt;
        }

        public int executeUpdate(string sql)
        {
            /** execute query:
             * insert
             * update
             * delete
             */
            int row;
            using (SqlConnection connection = GetConnection())
            {
                OpenConnection(connection);
                row = new SqlCommand(sql, connection).ExecuteNonQuery();
                CloseConnection(connection);
            }

            return row;
        }
    }
}



