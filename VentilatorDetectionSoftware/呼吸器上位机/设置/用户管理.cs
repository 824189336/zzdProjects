using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;  // 导入名称空间 
using System.Drawing.Drawing2D;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;
using ADOX;
using System.Threading;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;   

namespace 呼吸器上位机.主界面单项
{
    public partial class 用户管理 : Form
    {
        public 用户管理()
        {
            InitializeComponent();
        }
         string str_用户管理 = "insert into `data2`(`用户编号`,`用户名`,`工号`,`密码`,`用户组`,`全部`)" + " values";
        
        private void button_返回_Click(object sender, EventArgs e)
        {
            if (PageList.pageList.Count != 0)
            {
                PageList.pageList.Remove(PageList.nowPageId);
                PageList.nowPageId--;
            }
            this.Close();
        }

        private void 用户管理_Load(object sender, EventArgs e)
        {
            string connStr;
            OleDbConnection conn;

            connStr =
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + 登录.Filename_数据文件 + ";Jet OLEDB:Engine Type=5";
            conn = new OleDbConnection(connStr);
            conn.Open();

            System.Data.OleDb.OleDbDataAdapter da = new OleDbDataAdapter(数据库参数.sql_用户管理, 数据库参数.mycon);
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Clear();
            conn.Close();

            try
            {
                da.Fill(dt);  //将数据库内容填充到dt 这个DataTable（数据表）中
                System.Data.DataTable datNew = new System.Data.DataTable();
                datNew.Clear();                                    
                datNew = dt.DefaultView.ToTable(false, new string[] { "ID", "用户编号", "用户名", "工号", "密码", "用户组" });
                dataGridView1.DataSource = null;
                if (datNew.Rows.Count >= 1)
                {
                    dataGridView1.DataSource = datNew;
                }
                else
                {
                    dataGridView1.DataSource = null;

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            comboBox_用户组.Text = "操作员";
        }
        public void zengjia(string str)   //添加一组数据
        {
            string connStr;
            OleDbConnection conn;
            OleDbCommand cmd;
            connStr =
              "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + 登录.Filename_数据文件 + ";Jet OLEDB:Engine Type=5";
            conn = new OleDbConnection(connStr);
            conn.Open();
            cmd = new OleDbCommand(str, conn);
            cmd.ExecuteNonQuery();//执行SQLCMMAD
            conn.Close();

          
        }
        void delete(int id)  //删除数据库的一行
        {
            string sqlStr = "delete from data2 where ID=" + id;
            string connStr;
            OleDbConnection conn;
            OleDbCommand cmd;

            connStr =
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + 登录.Filename_数据文件 + ";Jet OLEDB:Engine Type=5";
            conn = new OleDbConnection(connStr);
            conn.Open();
            cmd = new OleDbCommand(sqlStr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        void chaxun()
        {
            string connStr, selectName, selectCmd;

            OleDbConnection conn;
            OleDbCommand cmd;

            connStr =
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + 登录.Filename_数据文件 + ";Jet OLEDB:Engine Type=5";
            conn = new OleDbConnection(connStr);
            conn.Open();

            selectName = textBox_用户名.Text;
            selectCmd =
          "SELECT * FROM data2 WHERE 用户名= '" +
          selectName + "'";

            cmd = new OleDbCommand(selectCmd, conn);

            OleDbDataAdapter dap = new OleDbDataAdapter(cmd);
            System.Data.DataTable table = new System.Data.DataTable();
            dap.Fill(table);

            System.Data.DataTable datNew = table.DefaultView.ToTable(false, new string[] { "ID", "用户编号", "用户名", "工号", "密码", "用户组" });
            dataGridView1.DataSource = null;
            if (datNew.Rows.Count >= 1)
            {
                dataGridView1.DataSource = datNew;
            }
            else
            {
                dataGridView1.DataSource = null;

            }
        }
        void chaxun_all()  //重新加载
        {
            string connStr, selectCmd;
            String selectName = "abc";
            OleDbConnection conn;
            OleDbCommand cmd;

            connStr =
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + 登录.Filename_数据文件 + ";Jet OLEDB:Engine Type=5";
            conn = new OleDbConnection(connStr);
            conn.Open();

            selectCmd =
                "SELECT * FROM data2 WHERE 全部 = '" +
                   selectName + "'"; ///////////////////////////////////////////////////////////////////


            cmd = new OleDbCommand(selectCmd, conn);

            OleDbDataAdapter dap = new OleDbDataAdapter(cmd);
            System.Data.DataTable table = new System.Data.DataTable();
            dap.Fill(table);
            System.Data.DataTable datNew = table.DefaultView.ToTable(false, new string[] { "ID", "用户编号", "用户名", "工号", "密码", "用户组" });
            if (datNew.Rows.Count >= 1)
            {
                dataGridView1.DataSource = datNew;
            }
            else
            {
                dataGridView1.DataSource = null;

            }
        }

        void update()
        {
            string connStr =
                     "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + 登录.Filename_数据文件 + ";Jet OLEDB:Engine Type=5";
            string updateCmd = "UPDATE data2 Set 用户编号=@1, 用户名=@2, 工号=@3,密码=@4,用户组=@5 Where ID=@6";
            OleDbConnection conn;
            OleDbCommand cmd;
            conn = new OleDbConnection(connStr);
            conn.Open();

            cmd = new OleDbCommand(updateCmd, conn);
            cmd.Parameters.Add(new OleDbParameter("@1", OleDbType.Char));
            cmd.Parameters.Add(new OleDbParameter("@2", OleDbType.Char));
            cmd.Parameters.Add(new OleDbParameter("@3", OleDbType.Char));
            cmd.Parameters.Add(new OleDbParameter("@4", OleDbType.Char));
            cmd.Parameters.Add(new OleDbParameter("@5", OleDbType.Char));
            cmd.Parameters.Add(new OleDbParameter("@6", OleDbType.Char));
            cmd.Parameters["@1"].Value = textBox_用户编号.Text;
            cmd.Parameters["@2"].Value = textBox_用户名字.Text;
            cmd.Parameters["@3"].Value = textBox_工号.Text;
            cmd.Parameters["@4"].Value = textBox_密码.Text;
            cmd.Parameters["@5"].Value = comboBox_用户组.Text;
            cmd.Parameters["@6"].Value = 数据库更新.编辑_Row;
            cmd.ExecuteNonQuery();
            数据库更新.flag_update = false;
            MessageBox.Show("修改成功","提示");
        }
        private void button_添加用户_Click(object sender, EventArgs e)
        {
            if (数据库更新.flag_update)
                update();
            else
            {
                string data = textBox_用户编号.Text + ',' + textBox_用户名字.Text + ',' + textBox_工号.Text + ',' + textBox_密码.Text + ',' + textBox_用户名字.Text + ',' + "abc";
                data = "'" + data.Replace(",", "','") + "'";
                string str_data = str_用户管理 + '(' + data + ");";
                zengjia(str_data);
                dataGridView1.DataSource = null;     
            }
            chaxun_all();
        }

        private void button_禁用_Click(object sender, EventArgs e)   //暂定禁用是删除
        {
            int row = dataGridView1.CurrentCell.RowIndex;  //行号从0开始
            int delete_row = int.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());
            delete(delete_row);

            dataGridView1.DataSource = null;
            chaxun_all();
        }

        private void button_查询_Click(object sender, EventArgs e)
        {
            chaxun(); 
        }

        private void button_编辑_Click(object sender, EventArgs e)
        {
            数据库更新.flag_update = true;  //数据库更新
            int row = dataGridView1.CurrentCell.RowIndex;  //行号从0开始
            int 编辑_row = (int)dataGridView1.Rows[row].Cells[0].Value;  //修改此ID下的数据
            数据库更新.编辑_Row = 编辑_row;
            string connStr, selectCmd;

            OleDbConnection conn;
            OleDbCommand cmd;
            selectCmd =
                            "SELECT * FROM data2 WHERE ID = " + 编辑_row;
            connStr =
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + 登录.Filename_数据文件 + ";Jet OLEDB:Engine Type=5";
            conn = new OleDbConnection(connStr);
            conn.Open();
            cmd = new OleDbCommand(selectCmd, conn);

            OleDbDataAdapter dap = new OleDbDataAdapter(cmd);
            System.Data.DataTable table = new System.Data.DataTable();
            dap.Fill(table);

            DataRow objDataRow = table.Rows[0];  //取选中行对应的数据库数据。
            textBox_用户编号.Text = objDataRow[1].ToString();
            textBox_用户名字.Text = objDataRow[2].ToString();
            textBox_工号.Text = objDataRow[3].ToString();
            textBox_密码.Text = objDataRow[4].ToString();
            comboBox_用户组.Text = objDataRow[5].ToString();

        }

        private void button_导出_Click(object sender, EventArgs e)
        {
            exporeDataToTable(dataGridView1);//将datagridview中的数据导入到表中
            OutputAsExcelFile(dataGridView1);//将datagridView中的数据导出到一张表中
        }

        /***************************将datagridview中的数据导入到表中************************************/
        private System.Data.DataTable exporeDataToTable(DataGridView dataGridView)
        {

            System.Data.DataTable tempTable = new System.Data.DataTable("tempTable");
            //定义一个模板表，专门用来获取列名
            System.Data.DataTable modelTable = new System.Data.DataTable("ModelTable");
            //创建列
            for (int column = 0; column < dataGridView1.Columns.Count; column++)
            {
                //可见的列才显示出来
                if (dataGridView1.Columns[column].Visible == true)
                {
                    DataColumn tempColumn = new DataColumn(dataGridView1.Columns[column].HeaderText, typeof(string));
                    tempTable.Columns.Add(tempColumn);
                    DataColumn modelColumn = new DataColumn(dataGridView1.Columns[column].Name, typeof(string));
                    modelTable.Columns.Add(modelColumn);
                }
            }
            //添加datagridview中行的数据到表
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                if (dataGridView1.Rows[row].Visible == false)
                {
                    continue;
                }
                DataRow tempRow = tempTable.NewRow();
                for (int i = 0; i < tempTable.Columns.Count; i++)
                {
                    tempRow[i] = dataGridView1.Rows[row].Cells[modelTable.Columns[i].ColumnName].Value;
                }
                tempTable.Rows.Add(tempRow);
            }
            return tempTable;
        }

        /******************************将datagridView中的数据导出到excel表中*****************************/
        private void OutputAsExcelFile(DataGridView dataGridView)
        {
            //将datagridView中的数据导出到一张表中
            System.Data.DataTable tempTable = this.exporeDataToTable(dataGridView);
            //导出信息到Excel表
            Microsoft.Office.Interop.Excel.Application myExcel;
            Microsoft.Office.Interop.Excel.Workbooks myWorkBooks;
            Microsoft.Office.Interop.Excel.Workbook myWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet myWorkSheet;
            char myColumns;
            Microsoft.Office.Interop.Excel.Range myRange;
            object[,] myData = new object[500, 35];
            int i, j;//j代表行,i代表列
            myExcel = new Microsoft.Office.Interop.Excel.Application();
            //显示EXCEL
            myExcel.Visible = true;
            if (myExcel == null)
            {
                MessageBox.Show("本地Excel程序无法启动!请检查您的Microsoft Office正确安装并能正常使用", "提示");
                return;
            }
            myWorkBooks = myExcel.Workbooks;
            myWorkBook = myWorkBooks.Add(System.Reflection.Missing.Value);
            myWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)myWorkBook.Worksheets[1];
            myColumns = (char)(tempTable.Columns.Count + 64);//设置列
            myRange = myWorkSheet.get_Range("A5", myColumns.ToString() + "1");//"A5"是指A列，第五行。
            int count = 0;

          
            //设置列名
            foreach (DataColumn myNewColumn in tempTable.Columns)
            {
                myData[0, count] = myNewColumn.ColumnName;
                count = count + 1;
            }
            //输出datagridview中的数据记录并放在一个二维数组中
            j = 1;
            foreach (DataRow myRow in tempTable.Rows)//循环行
            {
                for (i = 0; i < tempTable.Columns.Count; i++)//循环列
                {
                    myData[j, i] = myRow[i].ToString();
                }
                j++;
            }
            //将二维数组中的数据写到Excel中
            myRange = myRange.get_Resize(tempTable.Rows.Count + 1, tempTable.Columns.Count);//创建列和行
            myRange.Value2 = myData;
            myRange.EntireColumn.AutoFit();
        }
    }
}
