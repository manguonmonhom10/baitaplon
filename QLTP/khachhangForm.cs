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
    public partial class khachhangForm : Form
    {
        public khachhangForm()
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
                khachhangBusiness phb = new khachhangBusiness();
                this.dataGridView1.DataSource = phb.hienthikhachhang();
            }
            catch
            {
                MessageBox.Show("Loi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            khachhang ph = new khachhang();
            ph.setHoTen(textBox1.Text);
            ph.setDiaChi(textBox2.Text);
            ph.setSDT(textBox3.Text);
            ph.setMaPhong(textBox4.Text);
            ph.setNgayThue(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            ph.setNgayTra(dateTimePicker2.Value.ToString("yyyy-MM-dd"));

            khachhangBusiness pb = new khachhangBusiness();
            ph.setHoTen(textBox1.Text);
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
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(row.Cells[4].Value.ToString());
            dateTimePicker2.Value = DateTime.Parse(row.Cells[5].Value.ToString());
        }

        private void khachhangForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            khachhang ph = new khachhang();
            ph.setHoTen(textBox1.Text);
            khachhangBusiness pb = new khachhangBusiness();
            int rm = pb.xoa(ph);
            if (rm == 1)
            {
                MessageBox.Show("Xoa thanh cong");
                loadData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            khachhang ph = new khachhang();
            ph.setHoTen(textBox1.Text);
            ph.setDiaChi(textBox2.Text);
            ph.setSDT(textBox3.Text);
            ph.setMaPhong(textBox4.Text);
            ph.setNgayThue(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            ph.setNgayTra(dateTimePicker2.Value.ToString("yyyy-MM-dd"));

            khachhangBusiness pb = new khachhangBusiness();
            int sa = pb.sua(ph);
            if (sa == 1)
            {
                MessageBox.Show("Sua thanh cong");
                loadData();
            }
        }
    }
}
