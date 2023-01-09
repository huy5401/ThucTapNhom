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

        public static DataTable LayQuyen()
        {
            string sql = @"select Quyen
                            from TAIKHOAN";
            return Dataprovider.ExecuteQuery(sql);
        }

        public static void ThayDoiQuyen(string maTK, string Quyen)
        {
            string sql = @"ThayDoiQuyenTK @Quyen , @maTK";
            Dataprovider.ExecuteNonQuery(sql, new object[] { Quyen, maTK });
        }

        public static void ThayTK(string maTK, string tk, string mk)
        {
            string sql = @"ThayDoiTK  @maTK , @tk , @mk";
            Dataprovider.ExecuteNonQuery(sql, new object[] { maTK, tk, mk });
        }
    }
}
