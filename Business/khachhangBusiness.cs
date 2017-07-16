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
   public partial class khachhangBusiness
    {
       public DataTable hienthikhachhang()
       {
           try
           {
               khachhang ph = new khachhang();
               return ph.getTable();
           }
           catch
           { throw; }

       }
       public int them(khachhang ph)
       {
           return ph.themkhachhang(ph);
       }
       public int xoa(khachhang ph)
       {
           return ph.xoakhachhang(ph);
       }
       public int sua(khachhang ph)
       {
           return ph.suakhachhang(ph);
       }
       
    }
}
