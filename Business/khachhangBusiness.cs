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
               khachhang kh = new khachhang();
               return kh.getTable();
           }
           catch
           { throw; }

       }
       public int them(khachhang kh)
       {
           return kh.themkhachhang(kh);
       }
       public int xoa(khachhang kh)
       {
           return kh.xoakhachhang(kh);
       }
       public int sua(khachhang kh)
       {
           return kh.suakhachhang(kh);
       }
       
    }
}
