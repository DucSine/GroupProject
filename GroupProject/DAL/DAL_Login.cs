using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.DAL
{
    class DAL_Login
    {
        DAL_Access access = new DAL_Access();

        public bool CheckLogin(string[] account)
        {
            string sql = string.Format("SELECT * FROM Account WHERE Acc_Username = '{0}' and Acc_Password = '{1}'", account);
            return access.executeCheck(sql);
        }
    }
}
