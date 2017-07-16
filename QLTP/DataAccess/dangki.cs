using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public partial class dangki
    {
        private string MaDK;
        private string HoTen;
        private string DiaChi;
        private string Email;
        private string SDT;

        //tao getsset
        public void setMaDK(string madk)
        {
            this.MaDK = madk;
        }
        public string getMaDK()
        {
            return MaDK;
        }

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

        public void setEmail(string email)
        {
            this.Email = email;
        }
        public string getEmail()
        {
            return Email;
        }

        public void setSDT(string sdt)
        {
            this.SDT = sdt;
        }
        public string getSDT()
        {
            return SDT;
            
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
            string sqlstr = "Select * from DangKi";
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
        public DataTable getTableById(int idDK)
        {
            SqlConnection con = Config.getConnect();
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();// mo ket noi sql
            string sqlstr = "Select * from DangKi where MaDK=" + idDK;
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
        public int themdangki(dangki dk)
        {
            SqlConnection con = Config.getConnect();
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
                con.Open();// mo ket noi sql
            string sqlstr = "INSERT INTO DangKi values ('" + dk.getMaDK() + "', '" + dk.getHoTen() + "', '" + dk.getDiaChi() + "','" + dk.getEmail() + "','" + dk.getSDT() + "')";
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

        
    }
}
