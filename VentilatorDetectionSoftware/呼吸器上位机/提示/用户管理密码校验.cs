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
using System.Xml;
using System.Xml.Linq;
using System.IO.Ports;

namespace 呼吸器上位机.提示
{
    public partial class 用户管理密码校验 : Form
    {
        public 用户管理密码校验()
        {
            InitializeComponent();
        }
        void chaxun_mima()
        {
            string connStr, selectName, selectCmd;

            OleDbConnection conn;
            OleDbCommand cmd;
            try
            {
                connStr =
                  "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + 登录.Filename_数据文件 + ";Jet OLEDB:Engine Type=5";
                conn = new OleDbConnection(connStr);
                conn.Open();

                selectName = textBox_账号.Text;
                selectCmd =
              "SELECT * FROM data2 WHERE 用户名= '" +
              selectName + "'";

                cmd = new OleDbCommand(selectCmd, conn);

                OleDbDataAdapter dap = new OleDbDataAdapter(cmd);
                DataTable table = new DataTable();
                dap.Fill(table);
                用户.初始密码 = table.Rows[0][4].ToString();
            }
            catch
            {
                用户.初始密码 = "";
            }
          

        }
        private void button_确定_Click(object sender, EventArgs e)
        {
            if (textBox_账号.Text.Trim() == String.Empty || textBox_密码.Text.Trim() == String.Empty) //为空
            {
                MessageBox.Show("请输入用户名和密码", "提示");
            }
            else
            {

                用户.初始用户名 = textBox_账号.Text;
                chaxun_mima();
                if (textBox_密码.Text == 用户.初始密码)
                {
                    主界面单项.用户管理 a = new 主界面单项.用户管理();
                    a.Show();
                    PageList.nowPageId++;
                    PageList.pageList.Add(a);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("账号或密码错误,请重新输入", "错误");  //提示错误;
                }

            }
            
        }

        private void button_退出_Click(object sender, EventArgs e)
        {
            if (PageList.pageList.Count != 0)
            {
                PageList.pageList.Remove(PageList.nowPageId);
                PageList.nowPageId--;
            }
            this.Close();
        }

        private void 用户管理密码校验_Load(object sender, EventArgs e)
        {
           // textBox_账号.Text = "123456";
           // textBox_密码.Text = "123456";
        }
    }
}
