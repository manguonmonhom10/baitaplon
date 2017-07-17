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
    public partial class dangkiForm : Form
    {
        public dangkiForm()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loadDk()
        {
            try
            {
                dangkiBusiness dk = new dangkiBusiness();
                this.dataGridView1.DataSource = dk.hienthidangki();
            }
            catch
            {
                MessageBox.Show("Loi");
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            dangki dk = new dangki();
            dk.setMaDK(textBox1.Text);
            dk.setHoTen(textBox4.Text);
            dk.setDiaChi(textBox5.Text);
            dk.setEmail(textBox2.Text);
            dk.setSDT(textBox3.Text);

            dangkiBusiness pb = new dangkiBusiness();
            dk.setMaDK(textBox1.Text);
            int ms = pb.themdangki(dk);
            if (ms == 1)
            {
                MessageBox.Show("Them thanh cong");
                loadDk();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox4.Text = row.Cells[1].Value.ToString();
            textBox5.Text = row.Cells[2].Value.ToString();
            textBox2.Text = row.Cells[3].Value.ToString();
            textBox3.Text = row.Cells[4].Value.ToString();
        }

        private void dangkiForm_Load(object sender, EventArgs e)
        {
           
            loadDk();
       

        }

    
    }
}
