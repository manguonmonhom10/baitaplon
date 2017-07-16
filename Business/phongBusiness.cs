using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace Business
{
    public partial class phongBusiness
    {
        //phong da = new phong();
        // vieest ham lay thong va dua len datagrivew
        public DataTable hienthiphong()
        {
            try
            {
                phong ph = new phong();
                return ph.getTable();
            }
            catch
            { throw; }

        }
        //public void delete(string maphong)
        //{
        //    string sql = " delete phonghop where maphong = '" + maphong + "' ";
        //    da.ExcuteNonQuery(sql);
        //}
        //public void sua(string tang, string size, string maphong)
        //{
        //    string sql = "update phonghop set tang = '" + tang + "',size = '" + size + "'where maphong= '" + maphong + "'";
        //    da.ExcuteNonQuery(sql);
        //}
        public int them(phong ph)
        {
            return ph.themPhong(ph);
        }
        public int xoa(phong ph)
        {
            return ph.xoaPhong(ph);
        }
        public int sua(phong ph)
        {
            return ph.sua(ph);
        }

    }
}
