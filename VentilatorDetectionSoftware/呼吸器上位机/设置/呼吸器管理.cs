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
  

namespace 呼吸器上位机.主界面单项
{
    public partial class 呼吸器管理 : Form
    {
        public 呼吸器管理()
        {
            InitializeComponent();
        }
      string str_呼吸器管理 = "insert into `data3`(`呼吸器内部编号`,`呼吸器编号`,`制造商`,`产品型号`,`呼吸器类型`,`使用者`,`使用单位`,`出厂日期`,`入库日期`,`上次测试日期`,`面罩`,`压力表`,`报警器`,`呼吸阻力`,`气密性`,`状态`,`全部`)" + " values";                                                       
        
      

        private void 呼吸器管理_Load(object sender, EventArgs e)
        {
            comboBox_面罩.Text = "正常";
            comboBox_压力表.Text = "正常";
            comboBox_报警器.Text = "正常";
            comboBox_呼吸阻力.Text = "正常";
            comboBox_气密性.Text = "正常";
            comboBox_状态.Text = "正常";

            string connStr;
            OleDbConnection conn;

            connStr =
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + 登录.Filename_数据文件 + ";Jet OLEDB:Engine Type=5";
            conn = new OleDbConnection(connStr);
            conn.Open();

            System.Data.OleDb.OleDbDataAdapter da = new OleDbDataAdapter(数据库参数.sql_呼吸器管理, 数据库参数.mycon);
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Clear();
            conn.Close();

            try
            {
                da.Fill(dt);  //将数据库内容填充到dt 这个DataTable（数据表）中
                DataTable datNew = new DataTable();
                datNew.Clear();                                                                                                               
                datNew = dt.DefaultView.ToTable(false, new string[] { "ID", "呼吸器内部编号", "呼吸器编号", "制造商", "产品型号", "呼吸器类型", "使用者", "使用单位", "出厂日期", "入库日期", "上次测试日期", "面罩", "压力表", "报警器", "呼吸阻力", "气密性", "状态" });
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
           
        }
        void delete(int id)  //删除数据库的一行
        {
            string sqlStr = "delete from data3 where ID=" + id;
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
        public void zengjia(string str)
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

        void chaxun_all() //重新加载
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
                "SELECT * FROM data3 WHERE 全部 = '" +
                   selectName + "'"; ///////////////////////////////////////////////////////////////////


            cmd = new OleDbCommand(selectCmd, conn);

            OleDbDataAdapter dap = new OleDbDataAdapter(cmd);
            DataTable table = new DataTable();
            dap.Fill(table);
            DataTable datNew = table.DefaultView.ToTable(false, new string[] { "ID", "呼吸器内部编号", "呼吸器编号", "制造商", "产品型号", "呼吸器类型", "使用者", "使用单位", "出厂日期", "入库日期", "上次测试日期", "面罩", "压力表", "报警器", "呼吸阻力", "气密性", "状态" });
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
            string updateCmd = "UPDATE data3 Set 呼吸器内部编号=@1, 呼吸器编号=@2, 制造商=@3, 产品型号=@4, 呼吸器类型=@5, 使用者=@6, 使用单位=@7, 出厂日期=@8, 入库日期=@9, 上次测试日期=@10, 面罩=@11, 压力表=@12, 报警器=@13, 呼吸阻力=@14, 气密性=@15, 状态=@16 Where ID=@17";
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
            cmd.Parameters.Add(new OleDbParameter("@7", OleDbType.Char));
            cmd.Parameters.Add(new OleDbParameter("@8", OleDbType.Char));
            cmd.Parameters.Add(new OleDbParameter("@9", OleDbType.Char));
            cmd.Parameters.Add(new OleDbParameter("@10", OleDbType.Char));
            cmd.Parameters.Add(new OleDbParameter("@11", OleDbType.Char));
            cmd.Parameters.Add(new OleDbParameter("@12", OleDbType.Char));
            cmd.Parameters.Add(new OleDbParameter("@13", OleDbType.Char));
            cmd.Parameters.Add(new OleDbParameter("@14", OleDbType.Char));
            cmd.Parameters.Add(new OleDbParameter("@15", OleDbType.Char));
            cmd.Parameters.Add(new OleDbParameter("@16", OleDbType.Char));
            cmd.Parameters.Add(new OleDbParameter("@17", OleDbType.Char));
          
         
            cmd.Parameters["@1"].Value = textBox_呼吸器内部编号.Text;
            cmd.Parameters["@2"].Value = textBox_呼吸器编号.Text;
            cmd.Parameters["@3"].Value = textBox_制造商.Text;
            cmd.Parameters["@4"].Value = textBox_产品型号.Text;
            cmd.Parameters["@5"].Value = textBox_呼吸器类型.Text;
            cmd.Parameters["@6"].Value = textBox_使用者.Text;
            cmd.Parameters["@7"].Value = textBox_使用单位.Text;
            cmd.Parameters["@8"].Value = textBox_出厂日期.Text;
            cmd.Parameters["@9"].Value =  textBox_入库日期.Text;
            cmd.Parameters["@10"].Value = textBox_上次测试日期.Text;
            cmd.Parameters["@11"].Value =  comboBox_面罩.Text;
            cmd.Parameters["@12"].Value = comboBox_压力表.Text;
            cmd.Parameters["@13"].Value = comboBox_报警器.Text;
            cmd.Parameters["@14"].Value = comboBox_呼吸阻力.Text;
            cmd.Parameters["@15"].Value = comboBox_气密性.Text;
            cmd.Parameters["@16"].Value = comboBox_状态.Text;
            cmd.Parameters["@17"].Value = 数据库更新.编辑_Row;
        
            cmd.ExecuteNonQuery();
            数据库更新.flag_update = false;
            MessageBox.Show("修改成功", "提示");
        }
        private void button_添加呼吸器_Click(object sender, EventArgs e)
        {
            if (数据库更新.flag_update)
                update();
            else
            {
                string data = textBox_呼吸器内部编号.Text + ',' + textBox_呼吸器编号.Text + ',' + textBox_制造商.Text + ',' + textBox_产品型号.Text + ','
                          + textBox_呼吸器类型.Text + ',' + textBox_使用者.Text + ',' + textBox_使用单位.Text + ',' + textBox_出厂日期.Text + ','
                          + textBox_入库日期.Text + ',' + textBox_上次测试日期.Text + ',' + comboBox_面罩.Text + ',' + comboBox_压力表.Text + ',' + comboBox_报警器.Text + ','
                          + comboBox_呼吸阻力.Text + ',' + comboBox_气密性.Text + ',' + comboBox_状态.Text + ',' + "abc";
                data = "'" + data.Replace(",", "','") + "'";
                string str_data = str_呼吸器管理 + '(' + data + ");";

                zengjia(str_data);
            }
          
            chaxun_all();
        }

        private void button_删除_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;  //行号从0开始
            int delete_row = int.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());
            delete(delete_row);

            dataGridView1.DataSource = null;
            chaxun_all();
        }

        private void comboBox_查询方式_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_输入提示.Text = "请输入" + comboBox_查询方式.Text + ":";
        }

        private void button_查询_Click(object sender, EventArgs e)
        {
            string connStr, selectName, selectCmd;         
            OleDbConnection conn;
            OleDbCommand cmd;
            connStr =
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + 登录.Filename_数据文件 + ";Jet OLEDB:Engine Type=5";
            conn = new OleDbConnection(connStr);
            conn.Open();
           
            switch (comboBox_查询方式.Text)   
            {
                case "呼吸器编号":
                    selectName = textBox_查询索引.Text;
                    selectCmd =
                selectCmd =
               "SELECT * FROM data3 WHERE 呼吸器编号 = '" +
               selectName + "'";                 
                    break;

                case "上次测试日期":
                    selectName = textBox_查询索引.Text;
                    selectCmd =
               "SELECT * FROM data3 WHERE 上次测试日期 = '" +
               selectName + "'";                  
                    break;

                case "状态":
                    selectName = textBox_查询索引.Text;
                    selectCmd =
                "SELECT * FROM data3 WHERE 状态 = '" +
                selectName + "'";  
                    break;

                case "产品型号":
                    selectName = textBox_查询索引.Text;
                    selectCmd =
                "SELECT * FROM data3 WHERE 产品型号 = '" +
                selectName + "'";
                    break;

                case "制造商":
                    selectName = textBox_查询索引.Text;
                    selectCmd =
                "SELECT * FROM data3 WHERE 制造商 = '" +
                selectName + "'";
                    break;

                case "出厂日期":
                    selectName = textBox_查询索引.Text;
                    selectCmd =
                "SELECT * FROM data3 WHERE 出厂日期 = '" +
                selectName + "'";
                    break;

                case "入库日期":
                    selectName = textBox_查询索引.Text;
                    selectCmd =
                "SELECT * FROM data3 WHERE 入库日期 = '" +
                selectName + "'";
                    break;

                default:
                    selectName = "";
                    selectCmd =
               "SELECT * FROM data3 WHERE 呼吸器编号 = '" +
              selectName + "'";
                    MessageBox.Show("请选择正确的查询方式");
                    break;
            }
            cmd = new OleDbCommand(selectCmd, conn);

            OleDbDataAdapter dap = new OleDbDataAdapter(cmd);
            DataTable table = new DataTable();
            dap.Fill(table);
            DataTable datNew = table.DefaultView.ToTable(false, new string[] { "ID", "呼吸器内部编号", "呼吸器编号", "制造商", "产品型号", "呼吸器类型", "使用者", "使用单位", "出厂日期", "入库日期", "上次测试日期", "面罩", "压力表", "报警器", "呼吸阻力", "气密性", "状态" });
            dataGridView1.DataSource = null;
            if (datNew.Rows.Count >= 1)
            {
                dataGridView1.DataSource = datNew;

              
            }
            else
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("没有对应查询数据", "错误");  //提示错误
            }


        }
        private void button_返回_Click(object sender, EventArgs e)
        {
            if (PageList.pageList.Count != 0)
            {
                PageList.pageList.Remove(PageList.nowPageId);
                PageList.nowPageId--;
            }
            this.Close();
        }
        private string name = "";//文件名
        private string dire = "";//文件路径前缀
        private void button_导入外部数据_Click(object sender, EventArgs e)  //外部 excel 数据导入access
        {
            OpenFileDialog file1 = new OpenFileDialog();       //实例化一个文件打开事件
            file1.InitialDirectory = Application.StartupPath;
            file1.Filter = "(*.xlsx)|*.xlsx";                    //筛选所要打开的文档 excel
            if (file1.ShowDialog() == DialogResult.OK)        //触发一个打开文件事件
            {
                
                 textBox1.Text = file1.FileName;
                 name = Path.GetFileName(textBox1.Text);//这边引用using System.IO;
                 dire = Path.GetDirectoryName(textBox1.Text);
                 dire = dire.EndsWith("\\") ? dire.Substring(0, dire.Length - 1) : dire;

                 if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("请填写路径！");
                return;
            }
                string connStr;
                OleDbConnection conn;
            connStr =
               "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + 登录.Filename_数据文件 + ";Jet OLEDB:Engine Type=5";
            conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbConnection conn_Excel = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Jet OLEDB:Database Password=;Extended properties=Excel 5.0;Data Source=" + textBox1.Text);
            OleDbTransaction tran = null;
            try
            {
                //查出EXCEL放入DataTable
                conn_Excel.Open();
                string sql = "select * from [Sheet1$]";
                DataTable dt = new DataTable();
                OleDbDataAdapter sda = new OleDbDataAdapter(sql, conn_Excel);
                sda.Fill(dt);
                if (dt == null)
                {
                    MessageBox.Show("您导入的文档名字有误！请去掉空格或特殊字符！");
                    return;
                }
                //去掉空行
         for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].ToString().Trim() == string.Empty)
                    {
                        dt.Rows.Remove(dt.Rows[i--]);
                    }
                }
                //开始事务
                tran = conn.BeginTransaction();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.Transaction = tran;
               for (int i = 0; i < dt.Rows.Count; i++)
                {
                   
                    string data = dt.Rows[i][0].ToString() + ',' + dt.Rows[i][1].ToString() + ',' + dt.Rows[i][2].ToString() + ',' + dt.Rows[i][3].ToString() + ','
                       + dt.Rows[i][4].ToString() + ',' + dt.Rows[i][5].ToString() + ',' + dt.Rows[i][6].ToString() + ',' + dt.Rows[i][7].ToString() + ','
                       + dt.Rows[i][8].ToString() + ',' + dt.Rows[i][9].ToString() + ',' + dt.Rows[i][10].ToString() + ',' + dt.Rows[i][11].ToString() + ',' + dt.Rows[i][12].ToString() + ','
                       + dt.Rows[i][13].ToString() + ',' + dt.Rows[i][14].ToString() + ',' + dt.Rows[i][15].ToString() + ',' + "abc";
                     data = "'" + data.Replace(",", "','") + "'";
                     string sql_insert = str_呼吸器管理 + '(' + data + ");";
                     cmd.CommandText = sql_insert;
                     cmd.ExecuteNonQuery();               
               }
                tran.Commit();//提交事务
                chaxun_all();
                MessageBox.Show("导入成功！");
                
          }
          catch
          {
               MessageBox.Show("导入失败！");
                tran.Rollback();
          }
          finally
          {
                conn.Dispose();
               conn_Excel.Dispose();
         }
            }
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
                            "SELECT * FROM data3 WHERE ID = " + 编辑_row;
            connStr =
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + 登录.Filename_数据文件 + ";Jet OLEDB:Engine Type=5";
            conn = new OleDbConnection(connStr);
            conn.Open();
            cmd = new OleDbCommand(selectCmd, conn);

            OleDbDataAdapter dap = new OleDbDataAdapter(cmd);
            System.Data.DataTable table = new System.Data.DataTable();
            dap.Fill(table);

            DataRow objDataRow = table.Rows[0];  //取选中行对应的数据库数据。

            textBox_呼吸器内部编号.Text = objDataRow[1].ToString();
            textBox_呼吸器编号.Text = objDataRow[2].ToString();
            textBox_制造商.Text = objDataRow[3].ToString();
            textBox_产品型号.Text = objDataRow[4].ToString();
            textBox_呼吸器类型.Text = objDataRow[5].ToString();
            textBox_使用者.Text = objDataRow[6].ToString();
            textBox_使用单位.Text = objDataRow[7].ToString();
            textBox_出厂日期.Text = objDataRow[8].ToString();
            textBox_入库日期.Text = objDataRow[9].ToString();
            textBox_上次测试日期.Text = objDataRow[10].ToString();
            comboBox_面罩.Text = objDataRow[11].ToString();
            comboBox_压力表.Text = objDataRow[12].ToString();
            comboBox_报警器.Text = objDataRow[13].ToString();
            comboBox_呼吸阻力.Text = objDataRow[14].ToString();
            comboBox_气密性.Text = objDataRow[15].ToString();
            comboBox_状态.Text = objDataRow[16].ToString();

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

            myExcel.Top = 0;




        }

        private void textBox_呼吸器内部编号_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
