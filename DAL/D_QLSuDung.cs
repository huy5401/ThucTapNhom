﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL
{
    public class D_QLSuDung
    {
        public static DataTable HienThiLichSD(string date, string MaPhong,string mabm)
        {
            // fix bộ môn
            string sql = @"select MaSD, CaSD, SUDUNG.MaPhong, NoiDungSD, CBPTrach, CANBO.TenCB from SUDUNG join CANBO on SUDUNG.CBPTrach = CANBO.MaCB join PHONGTHINGHIEM on PHONGTHINGHIEM.MaPhong = SUDUNG.MaPhong join BOMON on PHONGTHINGHIEM.MaBM = BOMON.MaBM where NgaySD = '"+date+"' and SUDUNG.MaPhong = '"+MaPhong+"' and BOMON.MaBM = '"+mabm+"'";
            return Dataprovider.ExecuteQuery(sql);
        }
        public static DataTable LayDSPhong(string mabm)
        {
           
            string sql = @"select MaPhong from PHONGTHINGHIEM where MaBM = '" + mabm + "'";
            return Dataprovider.ExecuteQuery(sql);
        }
        public static void SualichSD(string MaSD, string CaSD, string phong, string ND, string CBPT)
        {
            string sql = @"UPDATE SUDUNG SET CaSD = '"+CaSD+"',MaPhong = '"+phong+"', NoiDungSD = N'"+ND+"', CBPTrach=N'"+CBPT+"' WHERE MaSD = '"+MaSD+"'";
            Dataprovider.ExecuteNonQuery(sql);
        }
        public static void XoaLichSD(string MaSD)
        {
            string sql = @"DELETE FROM SUDUNG WHERE MaSD = '"+MaSD+"'";
            Dataprovider.ExecuteNonQuery(sql);
        }

        // fix mã bộ môn
        public static DataTable LayDSCbptChuaSD(string date, string casd,string mabm)
        {
            string sql = @"select MaCB, TenCB from CANBO where MaCB not in (select CANBO.MaCB from CANBO join SUDUNG on CANBO.MaCB = SUDUNG.CBPTrach where SUDUNG.NgaySD = '"+date+"' and SUDUNG.CaSD = '"+casd+ "') and CANBO.MaBM = '"+mabm+"' group by CANBO.MaCB, CANBO.TenCB";
            return Dataprovider.ExecuteQuery(sql);
        }
        public static DataTable LayDSCaChuaSD(string date, string phong)
        {
            string sql = @"select CASUDUNG.MaCa from SUDUNG, CASUDUNG where CASUDUNG.MaCa not in (select SUDUNG.CaSD from SUDUNG where SUDUNG.NgaySD = '"+date+"' and SUDUNG.MaPhong = '"+phong+"') group by CASUDUNG.MaCa";
            return Dataprovider.ExecuteQuery(sql);
        }
        public static void ThemLichSD(string date, string casd, string phong, string cbpt, string noidung)
        {
            string sql = @"exec LayMaSuDung";
            string MaSD = Convert.ToString(Dataprovider.ExecuteScalar(sql));
            string query = @"INSERT INTO SUDUNG (MaSD,CaSD,CBPTrach,NoiDungSD,NgaySD,MaPhong) VALUES ('"+MaSD+"','"+casd+"', '"+cbpt+"',N'"+noidung+"','"+date+"', '"+phong+"')";
            Dataprovider.ExecuteNonQuery(query);

        }
        public static DataTable LocLichSuDung(int Thang, int nam, string CB)
        {
            string sql = @"LocLichSuDung @Thang , @nam , @CB";
            return Dataprovider.ExecuteQuery(sql, new object[] { Thang, nam ,CB});
        }
    }
}
