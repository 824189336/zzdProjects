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

namespace 呼吸器上位机.主界面单项
{
    public partial class 更改密码 : Form
    {
        public 更改密码()
        {
            InitializeComponent();
        }
        int 编辑_row;  //修改数据库第几行数据
        DataTable table = new DataTable();
        void chaxun_row()
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

                selectName = 用户.初始用户名;
                selectCmd =
              "SELECT * FROM data2 WHERE 用户名= '" +
              selectName + "'";

                cmd = new OleDbCommand(selectCmd, conn);

                OleDbDataAdapter dap = new OleDbDataAdapter(cmd);

                dap.Fill(table);
                编辑_row = int.Parse(table.Rows[0][0].ToString());

            }
            catch
            {

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
            cmd.Parameters["@1"].Value = table.Rows[0][1].ToString();
            cmd.Parameters["@2"].Value = table.Rows[0][2].ToString();
            cmd.Parameters["@3"].Value = table.Rows[0][3].ToString();
            cmd.Parameters["@4"].Value = textBox_新密码.Text;
            cmd.Parameters["@5"].Value = table.Rows[0][5].ToString();
            cmd.Parameters["@6"].Value = 编辑_row;
            cmd.ExecuteNonQuery();
            数据库更新.flag_update = false;
            MessageBox.Show("修改成功", "提示");
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

        private void button_原密码_Click(object sender, EventArgs e)
        {
            if (textBox_原密码.Text == 用户.初始密码)
            {
                button_新密码.Enabled = true;
            }
            else
            {
                MessageBox.Show("密码错误","警告");
            }
        }
      
        private void button_新密码_Click(object sender, EventArgs e)  //设置新密码
        {
            chaxun_row();  //查询 修改第几行数据
            update();
        }

        private void 更改密码_Load(object sender, EventArgs e)
        {

        }

        private void textBox_原密码_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
