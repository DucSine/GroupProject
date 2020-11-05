using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.DAL
{
    class DAL_Goods
    {
        DAL_GeneralAccess access = new DAL_GeneralAccess();

        string sql;

        public DataTable LoadGoodTable()
        {
            sql = "SELECT * FROM Goods";
            return access.executeQuery(sql);
        }

        public DataTable SearchStaffByName(string g_name)
        {
            sql = string.Format("SELECT * FROM Goods " +
                                "WHERE st_Name = N'{0}' ",
                                g_name);
            return access.executeQuery(sql);
        }

        public int AddGoods(string g_id, string kog_id, string g_name, string g_image, string g_caption, string g_dateImport, int g_amount, string g_unit, float g_cost, float g_price)
        {
            sql = string.Format("INSERT INTO Goods " +
                                "VALUES ( '{0}', '{1}', N'{2}', N'{3}', N'{4}', '{5}', {6}, N'{7}', {8}, {9})",
                                g_id, kog_id, g_name, g_image, g_caption, g_dateImport, g_amount, g_unit, g_cost, g_price);

            return access.executeUpdate(sql);
        }

        public int UpdateGoods( string kog_id, string g_name, string g_image, string g_caption, string g_dateImport, int g_amount, string g_unit, float g_cost, float g_price)
        {
            sql = string.Format("UPDATE Goods " +
                                "SET kog_ID = '{1}' " +
                                    "g_Name =  N'{2}', " +
                                    "g_Image = N'{3}', " +
                                    "g_Caption = N'{4}', " +
                                    "g_DateImport = '{5}', " +
                                    "g_Amount = {6}, " +
                                    "g_Unit = N'{7}', " +
                                    "g_Cost = {8}, " +
                                    "g_Price = {9} ) " +
                                    "WHERE g_ID = '{0}' ",
                                kog_id, g_name, g_image, g_caption, g_dateImport, g_amount, g_unit, g_cost, g_price);

            return access.executeUpdate(sql);
        }

        public int DeleteGoods(string g_id)
        {
            sql = string.Format("DELETE FROM Goods " +
                                "wHERE g_ID = {0}", g_id);

            return access.executeUpdate(sql);
        }
    }
}
