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
           /* khachhang kh = new khachhang();
            kh.setHoTen(textb
            kh.s(Int32.Parse(textBox3.Text));
            kh.setTinhTrang(textBox1.Text);
            kh.setLoaiPhong(textBox4.Text);

            khachhangBusiness pb = new khachhangBusiness();
            kh.setMaPhong(textBox6.Text);
            int ms = pb.themkhachhang(kh);
            if (ms == 1)
            {
                MessageBox.Show("Them thanh cong");
                loadData();
            }*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
            textBox6.Text = row.Cells[5].Value.ToString();
        }

        private void khachhangForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
