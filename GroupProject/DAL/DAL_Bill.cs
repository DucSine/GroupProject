using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.DAL
{
    class DAL_Bill
    {
        DAL_GeneralAccess access = new DAL_GeneralAccess();
        IDataReader reader;
        SqlCommand cmd;
        DataTable dataTable;
        int row;
        bool check;

        public DataTable LoadBill(string type)
        {
            dataTable = new DataTable();
            switch (type)
            {
                case "IN":
                    new SqlDataAdapter("spGetBillIn", access.GetConnection()).Fill(dataTable);
                    break;
                case "OUT":
                    new SqlDataAdapter("spGetBillOut", access.GetConnection()).Fill(dataTable);
                    break;
            }
  
            return dataTable;
        }

       

        //thêm, sửa, xóa liên quan đến transaction


    }
}
