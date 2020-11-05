using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.DAL
{
    class DAL_Account
    {
        DAL_GeneralAccess access = new DAL_GeneralAccess();

        public bool CheckLogin(string username, string password)
        {
            bool check;
            using (SqlConnection conn = access.GetConnection())
            {
                access.OpenConnection(conn);
                SqlCommand cmd = new SqlCommand("spCheckLogin", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@Acc_Username", username));
                cmd.Parameters.Add(new SqlParameter("@Acc_Password", password));
                IDataReader reader = cmd.ExecuteReader();
                check = reader.Read();
                access.CloseConnection(conn);
            }

            return check;
        }
    }
}
