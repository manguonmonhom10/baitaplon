using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public partial class khachhang
    {
        
        private string HoTen;
        private string DiaChi;
        private string SDT;
        private string MaPhong;
        private string NgayThue;
        private string NgayTra;


        //tao getsset
        public void setHoTen(string hoten)
        {
            this.HoTen = hoten;
        }
        public string getHoTen()
        {
            return HoTen;
        }

        public void setDiaChi(string diachi)
        {
            this.DiaChi = diachi;
        }
        public string getDiaChi()
        {
            return DiaChi;
        }

        public void setSDT(string sdt)
        {
            this.SDT = sdt;
        }
        public string getSDT()
        {
            return SDT;
        }

        public void setMaPhong(string maphong)
        {
            this.MaPhong = maphong;
        }
        public string getMaPhong()
        {
            return MaPhong;
        }

        public void setNgayThue(string ngaythue)
        {
            this.NgayThue = ngaythue;
        }
        public string getNgayThue()
        {
            return NgayThue;
        }

        public void setNgayTra(string ngaytra)
        {
            this.NgayTra = ngaytra;
        }
        public string getNgayTra()
        {
            return NgayTra;
        }

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
            string sqlstr = "Select * from KhachHang";
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
        public DataTable getTableById(int idkhachhang)
        {
            SqlConnection con = Config.getConnect();
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();// mo ket noi sql
            string sqlstr = "Select * from KhachHang where HoTen=" + idkhachhang;
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

        public int themkhachhang(khachhang ph)
        {
            SqlConnection con = Config.getConnect();
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();// mo ket noi sql
            string sqlstr = "INSERT INTO KhachHang values ('" + ph.getHoTen() + "', '" + ph.getDiaChi() + "', '" + ph.getSDT() + "','" + ph.getMaPhong() + "','" +ph.getNgayThue() + "','" + ph.getNgayTra() + "')";
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
        public int xoakhachhang(khachhang kh)
        {

           
            SqlConnection con = Config.getConnect();
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();// mo ket noi sql
            string sqlstr = "delete Khachhang where HoTen = '" + kh.getHoTen() + "' ";
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
        public int suakhachhang(khachhang kh)
        {
            SqlConnection con = Config.getConnect();
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();// mo ket noi sql
            string sqlstr = "update KhachHang set DiaChi = '" + kh.getDiaChi() + "',SDT ='" + kh.getSDT() + "',NgayThue = " + kh.getNgayThue() + ",NgayTra = " + kh.getNgayTra() + " where HoTen LIKE N'%" + kh.getHoTen() + "%' and MaPhong = '"+kh.getMaPhong() + "'";
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
