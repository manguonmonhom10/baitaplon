using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class Config
    {
        public static SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=DESKTOP-O5DHBMF;Initial Catalog=QLTP;Integrated Security=True");
        }



        // lenh sql tra ve mot ban 
        //public DataTable getTable(string table)
        //{
        //    //SqlConnection con = getConnect();
        //    //SqlDataAdapter ad = new SqlDataAdapter(sql, con);
        //    //DataTable dt = new DataTable();
        //    //ad.Fill(dt);
        //    //return (dt);
        //    SqlConnection con = getConnect();
        //    DataTable dt = new DataTable();
        //    if (con.State == ConnectionState.Closed)
        //        con.Open();// mo ket noi sql
        //    string sqlstr = "Select * from " + table;
        //    SqlCommand cmd = new SqlCommand(sqlstr, con);
        //    try {
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        dt.Load(reader);
        //        return dt;
            
        //    }
        //    catch {
        //        throw;
        //    }

        //}
        //// lenh sql khong tra ve

        //public void ExcuteNonQuery(string sql)
        //{
        //    SqlConnection con = getConnect();
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    cmd.ExecuteNonQuery();
        //    cmd.Dispose();
        //    con.Close();
        //}
    }
}
