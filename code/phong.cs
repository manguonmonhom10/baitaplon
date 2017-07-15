using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public partial class phong
    {
        //SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-O5DHBMF;Initial Catalog=QLTP;Integrated Security=True");
        
        private string MaPhong;
        private string TinhTrang;
        private int GiaPhong;
        private string LoaiPhong;

        //tao getsset
        public void setMaPhong(string maphong)
        {
            this.MaPhong = maphong;
        }
        public string getMaPhong()
        {
            return MaPhong;
        }

        public void setTinhTrang(string tinhtrang)
        {
            this.TinhTrang = tinhtrang;
        }
        public string getTinhTrang()
        {
            return TinhTrang;
        }

        public void setGiaPhong(int giaphong)
        {
            this.GiaPhong = giaphong;
        }
        public int getGiaPhong()
        {
            return GiaPhong;
        }

        public void setLoaiPhong(string loaiphong)
        {
            this.LoaiPhong = loaiphong;
        }
        public string getLoaiPhong()
        {
            return LoaiPhong;
        }

        // dinh nghia cac phuong thuc
        // lay tat ca cac du lieu trong bang Phong 
        public DataTable getTable()
        {
            //SqlConnection con = getConnect();
            //SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            //DataTable dt = new DataTable();
            //ad.Fill(dt);
            //return (dt);
            SqlConnection con = Config.getConnect();
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();// mo ket noi sql
            string sqlstr = "Select * from Phong";
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                con.Close();
                return dt;

            }
            catch
            {
                throw;
            }

        }

        // lay thong tin cua mot phong nao do bang id cua no
        public DataTable getTableById(int idPhong)
        {
            SqlConnection con = Config.getConnect();
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();// mo ket noi sql
            string sqlstr = "Select * from Phong where MaPhong=" + idPhong;
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                con.Close();
                return dt;

            }
            catch
            {
                throw;
            }
        }

        public int themPhong(phong ph)
        {
            SqlConnection con = Config.getConnect();
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();// mo ket noi sql
            string sqlstr = "INSERT INTO Phong values ('" + ph.getMaPhong() +"', '" + ph.getTinhTrang() + "', " + ph.getGiaPhong() + ",'" + ph.getLoaiPhong() + "')";
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            try
            {
                int add = cmd.ExecuteNonQuery();
                
                con.Close();
                return add;

            }
            catch
            {
                throw;
            }
        }
        public int xoaPhong(phong ph)
        {
            
            //string sqlstr = " delete Phong where MaPhong = '" + ph.getMaPhong + "' ";
            //cmd.ExcuteNonQuery(sqlstr);
            SqlConnection con = Config.getConnect();
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();// mo ket noi sql
            string sqlstr = "delete Phong where MaPhong = '" + ph.getMaPhong() + "' "; 
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            try
            {
                int rm = cmd.ExecuteNonQuery();

                con.Close();
                return rm;

            }
            catch
            {
                throw;
            }
        }
        public int sua(phong ph)
        {
            SqlConnection con = Config.getConnect();
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();// mo ket noi sql
            string sqlstr = "update Phong set TinhTrang = '" + ph.getTinhTrang() + "',GiaPhong = " + ph.getGiaPhong() + ",LoaiPhong = '" + ph.getLoaiPhong() + "' where MaPhong = '"+ ph.getMaPhong() + "'" ;
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            try
            {
                int sa = cmd.ExecuteNonQuery();

                con.Close();
                return sa;

            }
            catch
            {
                throw;
            }
        }
    }
}
