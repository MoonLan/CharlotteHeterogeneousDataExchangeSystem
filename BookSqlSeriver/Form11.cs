using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BookSqlSeriver
{
    public partial class Form11 : Form
    {
        private DataTable DT = new DataTable();
        private SqlDataAdapter SDA = new SqlDataAdapter();
        public byte[] data;
        public Form11()
        {
            InitializeComponent();
 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
         

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DT.Rows.Clear();
            dataGridView1.DataSource = DT;
            this.registrationformTableAdapter.Fill(this.sqlbookDataSet.registrationform);
            SqlConnection conn = new SqlConnection("server=.;database=sqlbook;uid =sa;pwd=xxx”);
            SqlCommand SCD = new SqlCommand("select * from registrationform  WHERE starttime between " + this.textBox1.Text + " AND "+this.textBox2.Text+"", conn);
            SDA.SelectCommand = SCD;
            SDA.Fill(DT);
            dataGridView1.DataSource = DT;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                SDA.Update(DT);
            }
            catch (System.Exception ex)
            {
                return;
            }
        }
    }
}
