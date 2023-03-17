using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Note", typeof(string));
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["Note"].Visible = false;
            dataGridView1.Columns["Title"].Width = 200;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(titleTextBox.Text, textBoxNote.Text);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void readItemButton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if(index > 1)
            {
                titleTextBox.Text = dt.Rows[index].ItemArray[0].ToString();
                textBoxNote.Text = dt.Rows[index].ItemArray[1].ToString();

            }
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dt.Rows[index].Delete();
        }

        private void newItemButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Clear();
            textBoxNote.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
