using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using DataAccess;
namespace QLTP
{
    public partial class phongForm : Form
    {
        public  phongForm()
        {
            InitializeComponent();
        } 

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void loadData()
        {
            try
            {
                phongBusiness phb = new phongBusiness();
                this.dataGridView1.DataSource = phb.hienthiphong();
            }
            catch
            {
                MessageBox.Show("Loi");
            }
        }
        
        private void phongForm_Load(object sender, EventArgs e)
        {

            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            phong ph = new phong();
            ph.setMaPhong(textBox2.Text);
            ph.setGiaPhong(Int32.Parse( textBox3.Text));
            ph.setTinhTrang(textBox1.Text);
            ph.setLoaiPhong(textBox4.Text);

            phongBusiness pb = new phongBusiness();
            ph.setMaPhong(textBox2.Text);
            int ms = pb.them(ph);
            if (ms == 1)
            {
                MessageBox.Show("Them thanh cong");
                loadData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[0].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            phong ph = new phong();
            ph.setMaPhong(textBox2.Text);
            phongBusiness pb = new phongBusiness();
            int rm = pb.xoa(ph);
            if (rm == 1)
            {
                MessageBox.Show("Xoa thanh cong");
                loadData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            phong ph = new phong();
            ph.setMaPhong(textBox2.Text); 
            ph.setTinhTrang(textBox1.Text);
            ph.setGiaPhong(Int32.Parse(textBox3.Text));
            ph.setLoaiPhong(textBox4.Text);

            phongBusiness pb = new phongBusiness();
            int sa = pb.sua(ph);
            if (sa == 1)
            {
                MessageBox.Show("Sua thanh cong");
                loadData();
            }
        }

    }
}
