using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Reflection;
using System.Data.OleDb; 

namespace BookSqlSeriver
{
    public partial class MDIParent1 : Form
    {
        Form1 f1 = new Form1();
        public byte[] data;
        private System.Data.DataTable DT = new System.Data.DataTable();
        private SqlDataAdapter SDA = new SqlDataAdapter();
        public MDIParent1()
        {
            InitializeComponent();
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            label1.Visible = false;
            f2.MdiParent = this;
            f2.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
// TODO: 这行代码将数据加载到表“sqlbookDataSet.registrationform”中。您可以根据需要移动或删除它。
this.registrationformTableAdapter.Fill(this.sqlbookDataSet.registrationform);
            statusStrip.Visible = false;
            SqlConnection conn = new SqlConnection("server=.;database=sqlbook;uid =sa;pwd=xxx”);
            SqlCommand SCD = new SqlCommand("select * from registrationform order by id", conn);
            SDA.SelectCommand = SCD;
            SDA.Fill(DT);
            dataGridView1.DataSource = DT;
            try
            {
                this.registrationformTableAdapter.FillBy(this.sqlbookDataSet.registrationform);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            f1.f2 = this;
            f1.MdiParent = this;

            f1.b1 = this.button1;
            f1.l1 = this.label1;

            f1.b3 = this.button3;
            f1.b4 = this.button4;
            f1.b5 = this.button5;
            f1.b6 = this.button6;
            f1.b7 = this.button7;
            f1.b8 = this.button8;
            f1.b11 = this.button11;
            f1.b12 = this.button12;
            f1.b13 = this.button13;
            f1.b14 = this.button14;
            f1.b15 = this.button15;
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.f2 = this;
            f1.MdiParent = this;
            f1.b1 = this.button1;
            f1.l1 = this.label1;
            f1.b3 = this.button3;
            f1.b4 = this.button4;
            f1.b5 = this.button5;
            f1.b6 = this.button6;
            f1.b7 = this.button7;
            f1.b8 = this.button8;
            f1.b11 = this.button11;
            f1.b12 = this.button12;
            f1.b13  = this.button13;
            f1.b14 = this.button14;
            f1.b15 = this.button15;
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        public void  VisualImage()
        {
            MemoryStream memStream = new MemoryStream(data); 	

        }

        private void 添加书目ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form5 f5 = new Form5();
            f5.MdiParent = this;
            f5.Show();
        }





        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            label1.Visible = false;
            f6.MdiParent = this;
            f6.Show();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void 删除书目ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowNewForm(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            undoToolStripMenuItem_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DataGridViewToExcel(this.dataGridView1);
        }

        #region DataGridView导出到Excel，有一定的判断性
        /// <summary>    
        ///方法，导出DataGridView中的数据到Excel文件    
        /// </summary>    
        // <remarks>   
        /// add com "Microsoft Excel 11.0 Object Library"   
        /// using Excel=Microsoft.Office.Interop.Excel;   
        /// using System.Reflection;   
        /// </remarks>   
        /// <param name= "dgv"> DataGridView </param>    
        public static void DataGridViewToExcel(DataGridView dgv)
        {

            //申明保存对话框    
            SaveFileDialog dlg = new SaveFileDialog();
            //默然文件后缀    
            dlg.DefaultExt = "xlsx";
            //文件后缀列表    
            dlg.Filter = "EXCEL文件(*.xlsx)|*.xlsx";
            //默然路径是系统当前路径    
            dlg.InitialDirectory = Directory.GetCurrentDirectory();
            //打开保存对话框    
            if (dlg.ShowDialog() == DialogResult.Cancel) return;
            //返回文件路径    
            string fileNameString = dlg.FileName;
            //验证strFileName是否为空或值无效    
            if (fileNameString.Trim() == " ")
            { return; }
            //定义表格内数据的行数和列数    
            int rowscount = dgv.Rows.Count;
            int colscount = dgv.Columns.Count;
            //行数必须大于0    
            if (rowscount <= 0)
            {
                return;
            }

            //列数必须大于0    
            if (colscount <= 0)
            {
                return;
            }

            //行数不可以大于65536    
            if (rowscount > 65536)
            {
                return;
            }

            //列数不可以大于255    
            if (colscount > 255)
            {
                return;
            }

            //验证以fileNameString命名的文件是否存在，如果存在删除它    
            FileInfo file = new FileInfo(fileNameString);
            if (file.Exists)
            {
                try
                {
                    file.Delete();
                }
                catch (Exception error)
                {
                    return;
                }
            }
            #endregion
            Microsoft.Office.Interop.Excel.Application objExcel = null;
            Microsoft.Office.Interop.Excel.Workbook objWorkbook = null;
            Microsoft.Office.Interop.Excel.Worksheet objsheet = null;
            try
            {
                //申明对象    
                objExcel = new Microsoft.Office.Interop.Excel.Application();
                objWorkbook = objExcel.Workbooks.Add(Missing.Value);
                objsheet = ( Microsoft.Office.Interop.Excel.Worksheet)objWorkbook.ActiveSheet;
                //设置EXCEL不可见    
                objExcel.Visible = true;

                //向Excel中写入表格的表头    
                int displayColumnsCount = 1;
                for (int i = 0; i <= dgv.ColumnCount - 1; i++)
                {
                    if (dgv.Columns[i].Visible == true)
                    {
                        objExcel.Cells[1, displayColumnsCount] = dgv.Columns[i].HeaderText.Trim();
                        displayColumnsCount++;
                    }
                }
                for (int row = 0; row <= dgv.RowCount - 1; row++)
                {

                    displayColumnsCount = 1;
                    for (int col = 0; col < colscount; col++)
                    {
                        if (dgv.Columns[col].Visible == true)
                        {
                            try
                            {
                                objExcel.Cells[row + 2, displayColumnsCount] = dgv.Rows[row].Cells[col].Value.ToString().Trim();
                                displayColumnsCount++;
                            }
                            catch (Exception)
                            {

                            }

                        }
                    }
                }

                objWorkbook.SaveAs(fileNameString, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                        Missing.Value,  Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlShared, Missing.Value, Missing.Value, Missing.Value,
                        Missing.Value, Missing.Value);
            }   
            catch (Exception error)
            {
                return;
            }
            finally
            {
                objsheet = null;
                objWorkbook = null;
                objExcel = null;
            }
        }
        public void TransferData(string excelFile, string sheetName, string connectionString)
        {
            DataSet ds = new DataSet();
            try
            {
                //获取全部数据 
                string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + excelFile + ";" + "Extended Properties=Excel 8.0;";
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                string strExcel = "";
                OleDbDataAdapter myCommand = null;
                strExcel = string.Format("select * from [{0}$]", sheetName);
                myCommand = new OleDbDataAdapter(strExcel, strConn);
                myCommand.Fill(ds, sheetName);

                //如果目标表不存在则创建 
                string strSql = string.Format("if object_id('{0}') is null create table {0}(", sheetName);
                foreach (System.Data.DataColumn c in ds.Tables[0].Columns)
                {
                    strSql += string.Format("[{0}] varchar(255),", c.ColumnName);
                }
                strSql = strSql.Trim(',') + ")";

                using (System.Data.SqlClient.SqlConnection sqlconn = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    sqlconn.Open();
                    System.Data.SqlClient.SqlCommand command = sqlconn.CreateCommand();
                    command.CommandText = strSql;
                    command.ExecuteNonQuery();
                    sqlconn.Close();
                }
                //用bcp导入数据 
                using (System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(connectionString))
                {
                    bcp.SqlRowsCopied += new System.Data.SqlClient.SqlRowsCopiedEventHandler(bcp_SqlRowsCopied);
                    bcp.BatchSize = 100;//每次传输的行数 
                    bcp.NotifyAfter = 100;//进度提示的行数 
                    bcp.DestinationTableName = sheetName;//目标表 
                    bcp.WriteToServer(ds.Tables[0]);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        //进度显示 
        void bcp_SqlRowsCopied(object sender, System.Data.SqlClient.SqlRowsCopiedEventArgs e)
        {
            this.Text = e.RowsCopied.ToString();
            this.Update();
        } 

        private void button14_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            Form1 f1 = new Form1();
            f1.f2 = this;
            f1.MdiParent = this;
            f1.b1 = this.button1;
            f1.l1 = this.label1;
            f1.b3 = this.button3;
            f1.b4 = this.button4;
            f1.b5 = this.button5;
            f1.b6 = this.button6;
            f1.b7 = this.button7;
            f1.b8 = this.button8;
            f1.b11 = this.button11;
            f1.b12 = this.button12;
            f1.b13 = this.button13;
            f1.b14 = this.button14;
            f1.b15 = this.button15;
            f1.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //测试，将excel中的sheet1导入到sqlserver中 
            string connString = "server=.;database=sqlbook;uid =sa;pwd=xxx”;
            System.Windows.Forms.OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                TransferData(fd.FileName, "registrationform", connString);
            } 
        }
    }
}