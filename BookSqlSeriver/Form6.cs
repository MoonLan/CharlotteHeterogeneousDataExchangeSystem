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
    public partial class Form6 : Form
    {
        private DataTable DT = new DataTable();
        private SqlDataAdapter SDA = new SqlDataAdapter();

        public Form6()
        {

            InitializeComponent();

            
        }

    

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“sqlbookDataSet.registrationform”中。您可以根据需要移动或删除它。
            this.registrationformTableAdapter.Fill(this.sqlbookDataSet.registrationform);
            SqlConnection conn = new SqlConnection("server=.;database=sqlbook;uid =sa;pwd=xxx”);
            SqlCommand SCD = new SqlCommand("select * from registrationform order by starttime", conn);
            SDA.SelectCommand = SCD;
            SDA.Fill(DT);
            dataGridView1.DataSource = DT;
            this.fillByToolStrip.Visible = false;
            try
            {
                this.registrationformTableAdapter.FillBy(this.sqlbookDataSet.registrationform);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.registrationformTableAdapter.FillBy(this.sqlbookDataSet.registrationform);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.registrationformTableAdapter.FillBy(this.sqlbookDataSet.registrationform);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
