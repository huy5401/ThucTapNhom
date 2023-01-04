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
        public static DataTable TatCaCanBo(string MaCbHienTai)
        {
            string sql = @"SELECT cb.MaCB, cb.TenCB, cv.TenCVu, bm.TenBM, cb.SĐT
                        FROM dbo.CANBO cb
                        JOIN dbo.CHUCVU cv ON cv.MaCVu = cb.MaCVu
                        JOIN dbo.BOMON bm ON bm.MaBM = cb.MaBM
						WHERE cb.MaCB != '" + MaCbHienTai + "'";
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

        public static void SuaThongTinCB(string MaCB, string TenCB, string MaCVu, string MaBM, int SDT) {
            string sql = @"SuaThongTinCB @MaCB , @TenCB , @MaCVu , @MaBM , @SDT";
            Dataprovider.ExecuteNonQuery(sql, new object[] { MaCB, TenCB, MaCVu, MaBM, SDT});
        }

        public static void ThemCB(string MaCB, string TenCB, string MaCVu, string MaBM, int SDT) {
            string sql = @"ThemCB @MaCB , @TenCB , @MaCVu , @MaBM , @SDT";
            Dataprovider.ExecuteNonQuery(sql, new object[] { MaCB, TenCB, MaCVu, MaBM, SDT});
        }
    }
}
