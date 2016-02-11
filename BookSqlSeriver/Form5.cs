using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace BookSqlSeriver
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        String FileNamePath = null;

        public void UpDateImage()
        {


            SqlConnection conn;
            conn = new SqlConnection("server=.;database=sqlbook;uid =sa;pwd=1");
            String ISBN = Convert.ToString(textBox1.Text.Trim());
            string sqlstr = "Update [Book] set Photo=@Photo where ISBN='" + ISBN + "'";
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            FileStream fs = null;
            fs = new FileStream(FileNamePath, FileMode.Open, FileAccess.Read);
            byte[] data1 = new byte[fs.Length];
            fs.Read(data1, 0, (int)fs.Length);
            cmd.Parameters.Add("@Photo", SqlDbType.Image);
            cmd.Parameters["@Photo"].Value = data1;
            conn.Open();
            int i = cmd.ExecuteNonQuery();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            String filename = null;
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;

            FileNamePath = filename;
            fs = new FileStream(FileNamePath, FileMode.Open, FileAccess.Read);
            byte[] data1 = new byte[fs.Length];
            fs.Read(data1, 0, (int)fs.Length);

            MemoryStream memStream = new MemoryStream(data1);
            pictureBox1.Image = Image.FromStream(memStream);
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            conn = new SqlConnection("server=.;database=sqlbook;uid =sa;pwd=1");

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            String ISBN = Convert.ToString(textBox1.Text.Trim());
            String Name = Convert.ToString(textBox2.Text.Trim());
            String Allnum= Convert.ToString(textBox3.Text.Trim());
            String Money = Convert.ToString(textBox4.Text.Trim());
            cmd.CommandText = "INSERT INTO [Book] (ISBN,Name,Allnum,LastNum,Money) VALUES('" + ISBN + "'," + "'" + Name + "','" + Allnum + "','"+Allnum+"','" + Money + "')";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
          
            UpDateImage();
            label6.Text = "书目录入成功";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
