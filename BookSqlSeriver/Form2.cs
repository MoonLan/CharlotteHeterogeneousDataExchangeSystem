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
    public partial class Form2 : Form
    {
        public MDIParent1 mdip1;
        public byte[] data;
        private DataTable DT = new DataTable();
        private SqlDataAdapter SDA = new SqlDataAdapter();
        public Form2()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“sqlbookDataSet1.registrationform”中。您可以根据需要移动或删除它。
            this.registrationformTableAdapter.Fill(this.sqlbookDataSet1.registrationform);
            SqlConnection conn = new SqlConnection("server=.;database=sqlbook;uid =sa;pwd=xxxx”);
            SqlCommand SCD = new SqlCommand("select * from registrationform", conn);
            SDA.SelectCommand = SCD;
            SDA.Fill(DT);
            dataGridView1.DataSource = DT;
            this.fillByToolStrip.Visible = false;
            try
            {
                this.registrationformTableAdapter.FillBy(this.sqlbookDataSet1.registrationform);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.registrationformTableAdapter.FillBy(this.sqlbookDataSet1.registrationform);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


    }
}
