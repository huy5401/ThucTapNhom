using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_QLCanBo
    {
        public static DataTable TatCaCanBo(string MaCbHienTai, string MaBMHienTai)
        {
            string sql = @"SELECT cb.MaCB, cb.TenCB, cv.TenCVu, bm.TenBM, cb.SĐT
                        FROM dbo.CANBO cb
                        JOIN dbo.CHUCVU cv ON cv.MaCVu = cb.MaCV
                        JOIN dbo.BOMON bm ON bm.MaBM = cb.MaBM
						WHERE cb.MaBM = '" + MaBMHienTai + "' AND cb.MaCB != '" + MaCbHienTai + "' ";
            return Dataprovider.ExecuteQuery(sql);
        }

        public static DataTable ThongTinCB(string MaCB)
        {
            string sql = @"ThongTinCB @MaCB";
            return Dataprovider.ExecuteQuery(sql,new object[] {MaCB});
        }

        public static DataTable ALLChucVu()
        {
            string sql = @"SELECT MaCVu, TenCVu
                         FROM CHUCVU";
            return Dataprovider.ExecuteQuery(sql);
        }

        public static DataTable ALLBoMon()
        {
            string sql = @"SELECT MaBM, TenBM
                        FROM BOMON";
            return Dataprovider.ExecuteQuery(sql);
        }

        public static DataTable ALLQuyen()
        {
            string sql = @"SELECT DISTINCT Quyen
                        FROM TAIKHOAN";
            return Dataprovider.ExecuteQuery(sql);
        }

        public static void SuaThongTinCB(string MaCB, string TenCB, string MaCV, string MaBM, int SDT) {
            string sql = @"SuaThongTinCB @MaCB , @TenCB , @MaCV , @MaBM , @SDT";
            Dataprovider.ExecuteNonQuery(sql, new object[] { MaCB, TenCB, MaCV, MaBM, SDT});
        }

        public static void ThemCB(string MaCB, string TenCB, string MaCV, string MaBM, int SDT) {
            string sql = @"ThemCB @MaCB , @TenCB , @MaCV , @MaBM , @SDT";
            Dataprovider.ExecuteNonQuery(sql, new object[] { MaCB, TenCB, MaCV, MaBM, SDT});
        }

        public static int DangNhap(string TenDangNhap, string MatKhau)
        {
            string sql = @"DangNhap @TenDangNhap , @MatKhau";
            object So = Dataprovider.ExecuteScalar(sql, new object[] { TenDangNhap, MatKhau });
            return Convert.ToInt32(So);
        }

        public static DataTable LayALLThongTinCanBo(string TenDangNhap, string Matkhau)
        {
            string sql = @"LayALLThongTinCanBo @TenDangNhap , @MatKhau";
            return Dataprovider.ExecuteQuery(sql, new object[] { TenDangNhap, Matkhau });
        }

        public static DataTable ThongTinTaiKhoan(string MaBM)
        {
            string sql = @"ThongTinTaiKhoan @MaBM";
            return Dataprovider.ExecuteQuery(sql, new object[] { MaBM });
        }

        public static DataTable ALLMaCB_TaoTK(string MaBM)
        {
            string sql = @"ALLMaCB_TaoTK @MaBM";
            return Dataprovider.ExecuteQuery(sql, new object[] { MaBM });
        }

        public static void ThemTK(string MaTK, string MaCB, string TenTK, string MatKhau, string Quyen) {
            string sql = @"ThemTK @MaTK , @MaCB , @TenTK , @MatKhau , @Quyen";
            Dataprovider.ExecuteNonQuery(sql, new object[] { MaTK, MaCB, TenTK, MatKhau, Quyen });
        }
    }
}
