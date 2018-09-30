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
    public partial class 测试记录 : Form
    {
        public 测试记录()
        {
            InitializeComponent();
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

        private void 测试记录_Load(object sender, EventArgs e)
        {
            string connStr;
            OleDbConnection conn;

            connStr =
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + 登录.Filename_数据文件 + ";Jet OLEDB:Engine Type=5";
            conn = new OleDbConnection(connStr);
            conn.Open();

            System.Data.OleDb.OleDbDataAdapter da = new OleDbDataAdapter(数据库参数.sql_测试记录, 数据库参数.mycon);
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Clear();
            conn.Close();

            try
            {
                da.Fill(dt);  //将数据库内容填充到dt 这个DataTable（数据表）中
                DataTable datNew = new DataTable();
                datNew.Clear();
                datNew = dt.DefaultView.ToTable(false, new string[] { "ID", "呼吸器编号", "测试时间", "测试人员", "测试结果", "型号", "制造商" });
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
               "SELECT * FROM data1 WHERE 呼吸器编号 = '" +
               selectName + "'";
                    break;

                case "测试时间":
                    selectName = textBox_查询索引.Text;
                    selectCmd =
               "SELECT * FROM data1 WHERE 测试时间 = '" +
               selectName + "'";
                    break;

                case "测试人员":
                    selectName = textBox_查询索引.Text;
                    selectCmd =
                "SELECT * FROM data1 WHERE 测试人员 = '" +
                selectName + "'";
                    break;

                case "测试结果":
                    selectName = textBox_查询索引.Text;
                    selectCmd =
                "SELECT * FROM data1 WHERE 测试结果 = '" +
                selectName + "'";
                    break;

                case "型号":
                    selectName = textBox_查询索引.Text;
                    selectCmd =
                "SELECT * FROM data1 WHERE 型号 = '" +
                selectName + "'";
                    break;

                case "制造商":
                    selectName = textBox_查询索引.Text;
                    selectCmd =
                "SELECT * FROM data1 WHERE 制造商 = '" +
                selectName + "'";
                    break;

             

                default:
                    selectName = "";
                    selectCmd =
               "SELECT * FROM data1 WHERE 呼吸器编号 = '" +
              selectName + "'";
                    MessageBox.Show("请选择正确的查询方式");
                    break;
            }
            cmd = new OleDbCommand(selectCmd, conn);

            OleDbDataAdapter dap = new OleDbDataAdapter(cmd);
            DataTable table = new DataTable();
            dap.Fill(table);
            DataTable datNew = table.DefaultView.ToTable(false, new string[] { "ID", "呼吸器编号", "测试时间", "测试人员", "测试结果", "型号", "制造商" });
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
    }
}
