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
    public partial class Form3 : Form
    {
        private DataTable DT = new DataTable();
        private SqlDataAdapter SDA = new SqlDataAdapter();
        public TextBox t1;
        public Form3()
        {
            InitializeComponent();
            progressBar1.Visible = false;
        }

  

        private void prob()
        {
            for (int i = 0; i <= 10; i++)
            {
                progressBar1.PerformStep();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = null;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            DT.Rows.Clear();
            dataGridView1.DataSource = DT;
            this.registrationformTableAdapter.Fill(this.sqlbookDataSet.registrationform);
            SqlConnection conn = new SqlConnection("server=.;database=sqlbook;uid =sa;pwd=xxx”);
            SqlCommand SCD = new SqlCommand("select * from registrationform  WHERE starttime between " + this.textBox1.Text + " AND " + this.textBox2.Text + " AND PATINDEX('%" + this.textBox3.Text.Trim() + "%', Remarks) <> 0 AND PATINDEX('%" + this.textBox4.Text.Trim() + "%', address) <> 0", conn);
            SDA.SelectCommand = SCD;
            SDA.Fill(DT);
            progressBar1.Visible = true;
            prob();
            dataGridView1.DataSource = DT;
        }
    }
}
