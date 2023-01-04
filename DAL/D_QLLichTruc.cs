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
        public static DataTable TatCaLichTruc()
        {
         
            string sql = @"SELECT  ct.MaCT , FORMAT (ct.TGTruc,'dd/MM/yyyy') AS 'TGTruc',ct.MaCB,iIF((ct.GhiChu IS NULL) , N'Không có vấn đề',ct.GhiChu )AS 'GhiChu',
iIF((ct.TGTruc < CAST(GETDATE() AS Date) ) , N'Đã Thực Hiện',IIF(ct.TGTruc > CAST(GETDATE() AS Date)  ,N'Chưa Thực Hiện',N'Đang Thực Hiện')) 
AS 'TrangThai',bm.TenBM, ct.MaPhong,iIF((ct.MaCBNBG IS NULL) , N'',ct.MaCBNBG )AS 'MaCBNBG',ct.MaPhong
FROM dbo.CATRUC ct JOIN dbo.CANBO cb ON cb.MaCB = ct.MaCB 
JOIN dbo.BOMON bm ON bm.MaBM = cb.MaBM";
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
        public static DataTable LichTruc()
        {

            string sql = @"SELECT  ct.MaCT , FORMAT (ct.TGTruc,'dd/MM/yyyy') AS 'TGTruc',cb.TenCB AS'MaCB',iIF((ct.TGTruc < CAST(GETDATE() AS Date) ) , N'Đã Thực Hiện',IIF(ct.TGTruc > CAST(GETDATE() AS Date)  ,N'Chưa Thực Hiện',N'Đang Thực Hiện')) 
AS 'TrangThai',bm.TenBM, ct.MaPhong
FROM dbo.CATRUC ct JOIN dbo.CANBO cb ON cb.MaCB = ct.MaCB 
JOIN dbo.BOMON bm ON bm.MaBM = cb.MaBM";
            return Dataprovider.ExecuteQuery(sql);
        }
        public static int KiemTraSuaLichTruc(string MaCt, int MaPhong, string MaCb, DateTime TG)
        { 
            // số lượng khác 0 thì ko thêm được, =  0 thì thêm được
            string sql = @"KiemTraSuaLichTruc @MaCt , @MaPhong , @MaCb , @TG";
            object DemSoLuong = Dataprovider.ExecuteScalar(sql, new object[] { MaCt, MaPhong, MaCb, TG });
            return Convert.ToInt32(DemSoLuong);
        }
    }
}
