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

        // Quản lý TB - tình trạng

        public static DataTable DanhSachTB /*DanhSachTB*/()
        {
            string sql = @"DanhSachTB";
            return Dataprovider.ExecuteQuery(sql);
        }

        public static DataTable LayThongTinTB(string maTB)
        {
            string sql = @"LayTT_TB @MaTB ";
            return Dataprovider.ExecuteQuery(sql, new object[] { maTB});
        }

        public static void CapNhatTTTB(string MaTB, string MaTT, DateTime NgayNhap, string GhiChu)
        {
            string sql = @"capnhatTTTB @maTB , @maTT , @TBBD , @GhiChu ";
            Dataprovider.ExecuteNonQuery(sql, new object[] { MaTB, MaTT, NgayNhap, GhiChu });
        }

        public static DataTable LayLoaiTB()
        {
            string sql = @"SELECT MaTT , TenTT 
            FROM TINHTRANG";
            return Dataprovider.ExecuteQuery(sql);
        }


    }
}
