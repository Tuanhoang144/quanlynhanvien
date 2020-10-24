using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlysinhvien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_load();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int dem = 0;
        
        private void Form1_load()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Tên nhân viên",200);
            listView1.Columns.Add("Ngày sinh",150);
            listView1.Columns.Add("Địa chỉ",180);
            listView1.Columns.Add("Số điện thoại", 150);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = listView1.Items.Add(textBox2.Text);
            lvi.SubItems.Add(dateTimePicker1.Value.ToShortDateString());
            lvi.SubItems.Add(textBox3.Text);
            lvi.SubItems.Add(textBox4.Text);

            if (listView1.SelectedItems.Count > 0 )
            {
                textBox2.Text =
                listView1.SelectedItems[0].SubItems[0].Text;

                dateTimePicker1.Text =
                listView1.SelectedItems[0].SubItems[1].Text;

                textBox3.Text =
                listView1.SelectedItems[0].SubItems[2].Text;

                textBox4.Text =
                listView1.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = textBox2.Text;

                listView1.SelectedItems[0].SubItems[1].Text =
                dateTimePicker1.Value.ToShortDateString();

                listView1.SelectedItems[0].SubItems[3].Text =
                textBox4.Text;

                listView1.SelectedItems[0].SubItems[2].Text =
                textBox3.Text;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }
    }
}
