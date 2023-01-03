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
            string sql = @"SELECT cb.MaCB, cb.TenCB, cv.TenCVu, tk.Quyen
                        FROM dbo.CANBO cb
                        JOIN dbo.CHUCVU cv ON cv.MaCVu = cb.MaCV
                        JOIN dbo.TAIKHOAN tk ON tk.MaCB = cb.MaCB
						WHERE cb.MaCB != '" + MaCbHienTai + "'";
            return Dataprovider.ExecuteQuery(sql);
        }
    }
}
