using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_QuanLyTK
    {
        public static DataTable DanhSachTK /*DanhSachTk*/()
        {
            string sql = @"DanhSachTK";
            return Dataprovider.ExecuteQuery(sql);
        }
        public static DataTable LayThongTinTK(string maTK)
        {
            string sql = @"LayTT_TK @MaTK ";
            return Dataprovider.ExecuteQuery(sql, new object[] { maTK });
        }
    }
}
