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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public MDIParent1 f2;
        public MenuStrip ms;
        public ToolStrip ts;
        public Button b1;
        public Label l1;
        public Panel p1;
        public String GetID;
        public byte[] data;
        public PictureBox pb1;
        public Button b3;
        public Button b4;
        public Button b5;
        public Button b6;
        public Button b7;
        public Button b8;
        public Button b11;
        public Button b12;
        public Button b13;
        public Button b14;
        public Button b15;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        public bool TestLogin(String user, String pass, String[] b)
        {
            progressBar1.PerformStep();
            SqlConnection conn;
            conn = new SqlConnection("server=.;database=sqlbook;uid =sa;pwd=xxx”);

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            progressBar1.PerformStep();

            cmd.CommandText = "SELECT password,ID FROM [user] where username = '" + user + "'";
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {
                String a = sdr["password"].ToString();
                a = a.Trim();
                if (a == pass)
                {
                    progressBar1.PerformStep();

                    GetID = sdr["ID"].ToString().Trim();
                    conn.Dispose();
                    return true;
                }
                else
                {
                    conn.Dispose();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
          
            String[] a = new String[1];

           if (this.TestLogin(textBox1.Text, textBox2.Text,a) == true)
            {
                this.Close();

                b1.Enabled = false;
                perstrp();
                    b3.Visible = true;
                    b4.Visible = true;
                    b5.Visible = true;
                    b6.Visible = true;
                    b7.Visible = true;
                    b8.Visible = true;
                    b11.Visible = true;
                    b12.Visible = true;
                    b13.Visible = true;
                    b14.Visible = true;
                    b15.Visible = true;

            }
            else
            {
                label5.Text = "用户名或密码错误";
                perstrp();
            }
        }
        private void perstrp()
        {
            for (int i = 0; i <= 7; i++)
            {
                progressBar1.PerformStep();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
          
            progressBar1.Maximum = 100;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();

        }

    }



    class DBOlogin
    {

        public DBOlogin()
        {


        }

        public bool testusername(String name)
        {
         
            SqlConnection conn;
            conn = new SqlConnection("server=.;database=sqlbook;uid =sa;pwd=1");

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT username from [user]";
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {
              
                return true;
            }
            else
            {
                return false;
            }
        }


       


    }





}