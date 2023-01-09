using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public class D_QLLichTruc
    {
        public static DataTable TatCaLichTruc(string MaBm)
        {
         
            string sql = @"SELECT  ct.MaCT , FORMAT (ct.TGTruc,'dd/MM/yyyy') AS 'TGTruc',ct.MaCB,iIF((ct.GhiChu IS NULL) , N'Không có vấn đề',ct.GhiChu )AS 'GhiChu',
iIF((ct.TGTruc < CAST(GETDATE() AS Date) ) , N'Đã Thực Hiện',IIF(ct.TGTruc > CAST(GETDATE() AS Date)  ,N'Chưa Thực Hiện',N'Đang Thực Hiện')) 
AS 'TrangThai',bm.TenBM, ct.MaPhong,iIF((ct.MaCBNBG IS NULL) , N'',ct.MaCBNBG )AS 'MaCBNBG',ct.MaPhong
FROM dbo.CATRUC ct JOIN dbo.CANBO cb ON cb.MaCB = ct.MaCB 
JOIN dbo.BOMON bm ON bm.MaBM = cb.MaBM
WHERE bm.MaBM = '"+MaBm+"'";
            return Dataprovider.ExecuteQuery(sql);
        }
        public static DataTable ThongTinCanBo(string MaCb)
        {
            string sql = @"SELECT cb.MaCB, CB.TenCB , CV.TenCVu, bm.MaBM , bm.TenBM
FROM dbo.CANBO cb JOIN dbo.CHUCVU cv ON cv.MaCVu = cb.MaCV
JOIN dbo.BOMON bm ON bm.MaBM = cb.MaBM
WHERE cb.MaCB = '"+MaCb+"'";
            return Dataprovider.ExecuteQuery(sql);
        }
        public static DataTable CanBoHopLe(string MaCbPhanCong, string MaBm, DateTime TG)
        {
            string sql = @"CanBoHopLe @MaCbPhanCong , @MaBm , @TG";
            return Dataprovider.ExecuteQuery(sql, new object[] {MaCbPhanCong,MaBm,TG });
        }
        public static DataTable MaPhongHopLe( string MaBm, DateTime TG)
        {
            string sql = @"MaPhongHopLe @MaBm , @TG";
            return Dataprovider.ExecuteQuery(sql, new object[] {  MaBm, TG });
        }
        public static string LayMaCaTruc()
        {
            string sql = @"LayMaCaTruc";
            object MaCaTruc = Dataprovider.ExecuteScalar(sql);
            return Convert.ToString(MaCaTruc);
        }
        public static void ThemVaoBangCaTruc(string MaCaTruc, DateTime TG, string MaCbTruc, int MaPhong)
        {
            string sql = @"ThemVaoBangCaTruc @MaCaTruc , @TG , @MaCbTruc , @MaPhong";
            Dataprovider.ExecuteNonQuery(sql, new object[] { MaCaTruc, TG, MaCbTruc ,MaPhong});
        }
        public static DataTable LichTruc(string MaBm)
        {

      string sql = @"SELECT  ct.MaCT , FORMAT (ct.TGTruc,'dd/MM/yyyy') AS 'TGTruc',cb.TenCB AS'MaCB',iIF((ct.TGTruc < CAST(GETDATE() AS Date) ) , N'Đã Thực Hiện',IIF(ct.TGTruc > CAST(GETDATE() AS Date)  ,N'Chưa Thực Hiện',N'Đang Thực Hiện')) 
AS 'TrangThai',bm.TenBM, ct.MaPhong
FROM dbo.CATRUC ct JOIN dbo.CANBO cb ON cb.MaCB = ct.MaCB 
JOIN dbo.BOMON bm ON bm.MaBM = cb.MaBM
WHERE bm.MaBM = '"+MaBm+"'";
            return Dataprovider.ExecuteQuery(sql);
        }
        public static int KiemTraSuaLichTruc(string MaCt, int MaPhong, string MaCb, DateTime TG)
        { 
            // số lượng khác 0 thì ko thêm được, =  0 thì thêm được
            string sql = @"KiemTraSuaLichTruc @MaCt , @MaPhong , @MaCb , @TG";
            object DemSoLuong = Dataprovider.ExecuteScalar(sql, new object[] { MaCt, MaPhong, MaCb, TG });
            return Convert.ToInt32(DemSoLuong);
        }
        public static DataTable CanBoThuocBoMon(string MaBm)
        {
            string sql = @"SELECT cb.TenCB, cb.MaCB
  FROM dbo.CANBO cb JOIN dbo.BOMON bm ON bm.MaBM = cb.MaBM
  WHERE bm.MaBM = '"+MaBm+"'";
            return Dataprovider.ExecuteQuery(sql);
        }
        public static DataTable MaPhongThuocBoMon(string MaBm)
        {
            string sql = @" SELECT ptn.MaPhong
 FROM dbo.PHONGTHINGHIEM ptn JOIN dbo.BOMON bm ON bm.MaBM = ptn.MaBM 
 WHERE bm.MaBM = '"+MaBm+"'";
            return Dataprovider.ExecuteQuery(sql);
        }
        public static void CapNhatNgay(string MaCbTruc,int MaPhong,  DateTime NgayTruc, string MaCaTruc)
        {
            string sql = @"CapNhatNgay @MaCbTruc , @MaPhong , @NgayTruc , @MaCaTruc";
            Dataprovider.ExecuteNonQuery(sql, new object[] { MaCbTruc, MaPhong, NgayTruc, MaCaTruc });
        }
        public static void KhongCapNhatNgay(string MaCbTruc, int MaPhong, string GhiChu, string MaCaTruc)
        {
            string sql = @"KhongCapNhatNgay @MaCbTruc , @MaPhong , @GhiChu , @MaCaTruc";
            Dataprovider.ExecuteNonQuery(sql, new object[] { MaCbTruc, MaPhong, GhiChu, MaCaTruc });
        }
        public static string LayMaCbNhanBanGiao(int MaPhong, DateTime TG)
        {
            string sql = @"LayMaCbNhanBanGiao @MaPhong , @TG";
            object MaCbNhan = Dataprovider.ExecuteScalar(sql, new object[] { MaPhong, TG });
            return Convert.ToString(MaCbNhan);
        }
        public static int XacNhan(string MaCbNhanBanGiao, string TenDangNhap, string MatKhau)
        {
            // nếu = 1 thì xác nhận đúng
            string sql = @"XacNhan @MaCbNhanBanGiao , @TenDangNhap , @MatKhau";
            object DemSoLuong = Dataprovider.ExecuteScalar(sql, new object[] { MaCbNhanBanGiao, TenDangNhap, MatKhau});
            return Convert.ToInt32(DemSoLuong);
        }
        public static DataTable ThongTinCaTruc(string MaCt)
        {
            string sql = @"SELECT  ct.MaCT,  FORMAT (ct.TGTruc,'dd/MM/yyyy') AS 'TGTruc' , ct.MaCB, ct.MaPhong
FROM dbo.CATRUC ct
WHERE ct.MaCT = '"+MaCt+"'";
            return Dataprovider.ExecuteQuery(sql);
        }
        public static void UpdateCaTruc(string GhiChu, string MaCbNhan, string MaCaTruc)
        {
            string sql = @"UpdateCaTruc @GhiChu , @MaCbNhan , @MaCaTruc";
            Dataprovider.ExecuteNonQuery(sql, new object[] { GhiChu, MaCbNhan, MaCaTruc });
        }
    }
}
