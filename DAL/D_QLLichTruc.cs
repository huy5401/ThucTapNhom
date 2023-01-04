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
         
            string sql = @"SELECT  ct.MaCT , FORMAT (ct.TGTruc,'dd/MM/yyyy') AS 'TGTruc',ct.MaCB,iIF((ct.GhiChu IS NULL) , N'Không có vấn đề',ct.GhiChu )AS 'GhiChu',ct.TrangThai,  bm.TenBM, ct.MaPhong,iIF((ct.MaCBNBG IS NULL) , N'',ct.MaCBNBG )AS 'MaCBNBG'
FROM dbo.CATRUC ct JOIN dbo.CANBO cb ON cb.MaCB = ct.MaCB 
JOIN dbo.BOMON bm ON bm.MaBM = cb.MaBM";
            return Dataprovider.ExecuteQuery(sql);
        }
        public static DataTable ThongTinCanBo(string MaCb)
        {
            
            string sql = @"SELECT cb.MaCB, CB.TenCB , CV.TenCVu
FROM dbo.CANBO cb JOIN dbo.CHUCVU cv ON cv.MaCVu = cb.MaCV
WHERE cb.MaCB = '"+MaCb+"'";
            return Dataprovider.ExecuteQuery(sql);
        }
    }
}
