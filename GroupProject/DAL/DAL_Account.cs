using System;
using System.Collections.Generic;
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
            string sql = string.Format("SELECT * FROM Account WHERE Acc_Username = '{0}' and Acc_Password = '{1}'", username, password);
            return access.executeCheck(sql);
        }
    }
}
