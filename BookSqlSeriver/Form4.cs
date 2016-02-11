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
    public partial class Form4 : Form
    {
        int ID = 1;
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        
        public bool TestLogin(String user, String pass,String Rpass)
        {

            SqlConnection conn;
            conn = new SqlConnection("server=.;database=sqlbook;uid =sa;pwd=1");

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            String IDS = Convert.ToString(textBox4.Text.Trim());
            cmd.CommandText = "INSERT INTO [user] (ID,username,password,ETC,LendBookNum) VALUES('" + IDS + "'," + "'" + user + "','" + pass + "','" + "0','0" + "')";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

           
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            label5.Text = null;
            if (textBox2.Text != textBox3.Text)
            {
                label5.Text = "两次密码不相等";
            }
            if (textBox2.Text == textBox3.Text)
            {

                TestLogin(textBox1.Text, textBox2.Text, textBox3.Text);
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                ID++;
                label5.Text = "注册成功";
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
