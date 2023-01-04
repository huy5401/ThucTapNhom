using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL
{
    public class D_QLSuDung
    {
        public static DataTable HienThiLichSD(string date, string MaPhong)
        {
            string sql = @"select MaSD, CaSD, MaPhong, NoiDungSD, CBPTrach from SUDUNG where NgaySD = '"+date+"' and MaPhong = '"+MaPhong+"'";
            return Dataprovider.ExecuteQuery(sql);
        }
        public static DataTable LayDSPhong(string mabm)
        {
            string maBM = "BM01";
            string sql = @"select MaPhong from PHONGTHINGHIEM where MaBM = '" + maBM + "'";
            return Dataprovider.ExecuteQuery(sql);
        } 
    }
}
