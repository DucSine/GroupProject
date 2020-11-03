using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.DAL
{
    class DAL_Bill
    {
        //xem xét lại có nên gôp để xử lý hóa đơn
        DAL_GeneralAccess access = new DAL_GeneralAccess();

        string sql;

        public DataTable LoadBillTable()
        {
            sql = "SELECT * FROM Bill";
            return access.executeQuery(sql);
        }

       
    }
}
