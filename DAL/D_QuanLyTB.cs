using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_QuanLyTB
    {

        public static DataTable LayDanhMucTB ()
        {
            string sql = @"SELECT TenLoai, MaLoai
                            FROM LOAITB";
            return Dataprovider.ExecuteQuery(sql);
        }

        public static DataTable LayAnhTB(string maloai)
        {
            string sql = @"SELECT Anh
                            FROM LOAITB
                            WHERE MaLoai = '" + maloai + "'";
            return Dataprovider.ExecuteQuery(sql);

        }

        public static string LayMaLoaiTB()
        {
            string sql = @"LayMaLoaiTB";
            object MaLoaitb = Dataprovider.ExecuteScalar(sql);
            return Convert.ToString(MaLoaitb);
        }

        public static void ThemDanhMuc(string MaLoai, string TenLoai, byte[] anh)
        {
            string sql = @"ThemDanhMucTB @MaLoai , @TenLoai , @Anh , @SoLuong";
            Dataprovider.ExecuteNonQuery(sql, new object[] { MaLoai, TenLoai, anh, 0});
        }
    }
}
