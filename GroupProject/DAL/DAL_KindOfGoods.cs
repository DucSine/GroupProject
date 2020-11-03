using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.DAL
{
    class DAL_KindOfGoods
    {
        DAL_GeneralAccess access = new DAL_GeneralAccess();

        string sql;

        public DataTable LoadKindOfGoodsTable()
        {
            sql = "SELECT * FROM KindOfGoods";
            return access.executeQuery(sql);
        }

        public DataTable SearchKindOfGoodsByNane(string kog_Name)
        {
            sql = string.Format("SELECT * FROM KindOfGoods " +
                                "WHERE st_Name = N'{0}' ",
                                kog_Name);
            return access.executeQuery(sql);
        }

        public int AddKindOfGoods(string kog_id, string kog_name )
        {
            sql = string.Format("INSERT INTO KindOfGoods " +
                                "VALUES ( '{0}', N'{1}')",
                                kog_id, kog_name );

            return access.executeUpdate(sql);
        }

        public int UpdateKindOfGoods(string kog_id, string kog_name)
        {
            sql = string.Format("UPDATE KindOfGoods " +
                                "SET kog_Name =  N'{1}', " +
                                    "WHERE kog_ID = {0} ",
                                kog_id, kog_name);

            return access.executeUpdate(sql);
        }

        public int DeleteKindOfGoods(string kog_id)
        {
            string sub_sql = string.Format("DELETE FROM Goods " +
                                           "wHERE kog_ID = {0}", kog_id);
            access.executeUpdate(sub_sql);

            sql = string.Format("DELETE FROM KindOfGoods " +
                                "wHERE kog_ID = {0}", kog_id);

            return access.executeUpdate(sql);
        }
    }
}
