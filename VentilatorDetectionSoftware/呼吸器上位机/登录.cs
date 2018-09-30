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

namespace 呼吸器上位机
{
    public partial class 登录 : Form
    {
        public static 登录 pFormHandle = null;

        public 登录()
        {
            InitializeComponent();
            pFormHandle = this;
            PageList.nowPageId = 1;
            PageList.pageList.Add(this);
        }

        public static String Filename_数据文件 = "数据文件.mdb";     //数据库名字

        public static String Filename_测试记录_data = "CREATE TABLE `data1`(ID AUTOINCREMENT PRIMARY KEY,`呼吸器编号` String,`测试时间` String,`测试人员` String,`测试结果` String,`型号` String,`制造商` String ,`全部` String)";//SQLCOMMAND语句
        public static String Filename_用户管理_data = "CREATE TABLE `data2`(ID AUTOINCREMENT PRIMARY KEY,`用户编号` String,`用户名` String,`工号` String,`密码` String,`用户组` String,`全部` String)";//SQLCOMMAND语句
        public static String Filename_呼吸器管理_data = "CREATE TABLE `data3`(ID AUTOINCREMENT PRIMARY KEY,`呼吸器内部编号` String,`呼吸器编号` String,`制造商` String,`产品型号` String,`呼吸器类型` String,`使用者` String,`使用单位` String,`出厂日期` String,`入库日期` String,`上次测试日期` String,`面罩` String,`压力表` String,`报警器` String,`呼吸阻力` String,`气密性` String,`状态` String,`全部` String)";//SQLCOMMAND语句

        // public static string str_测试记录 = "insert into `data1`(`呼吸器编号`,`测试时间`,`测试人员`,`测试结果`,`型号`,`制造商`,`全部`)" + " values";
        /********************************************自定义类和函数*****************************************************/

        public static OleDbConnection opendatebase(String datebaseName)
        {
            //不存在，建立
            if (!File.Exists(@datebaseName))
            {
                ADOX.Catalog catalog = new Catalog();
                catalog.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + datebaseName + ";Jet OLEDB:Engine Type=5");

            }
            //打开
            数据库参数.mycon = null;
            try
            {

                string strcon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + datebaseName + ";";
                数据库参数.mycon = new OleDbConnection(strcon);
                数据库参数.mycon.Open();
                Console.WriteLine("数据库建立连接成功");
            }
            catch
            {
                Console.WriteLine("数据库建立连接失败,请检查(管理员权限或数据库文件的正确性)");
                数据库参数.mycon.Close();
                数据库参数.mycon = null;
            }
            return 数据库参数.mycon;
        }

        public static void new_access(string Filename, string data1, string data2, string data3)
        {
            Boolean existence = false;
            //判读数据库是否存在,不存在,等会还要建表
            if (File.Exists(@Filename))
            {
                existence = true;
            }
            //打开数据库
            数据库参数.mycon = opendatebase(Filename);
            if (数据库参数.mycon == null)
            {
                Console.WriteLine("数据库打开失败,请检查");
                Application.Exit();
            }
            //建立表
            if (existence == false)
            {

                OleDbCommand cmd1 = new OleDbCommand();
                OleDbCommand cmd2 = new OleDbCommand();
                OleDbCommand cmd3 = new OleDbCommand();

                cmd1.Connection = 数据库参数.mycon;//设置命令的对像是SLDB数据库
                //建表Folder,括号内为:字段1 类型,字段2 类型,......(NOT NULL表示不能空)
                cmd1.CommandText = data1;
                cmd1.ExecuteNonQuery();//执行SQLCMMAD

                cmd2.Connection = 数据库参数.mycon;//设置命令的对像是SLDB数据库
                //建表Folder,括号内为:字段1 类型,字段2 类型,......(NOT NULL表示不能空)
                cmd2.CommandText = data2;
                cmd2.ExecuteNonQuery();//执行SQLCMMAD

                cmd3.Connection = 数据库参数.mycon;//设置命令的对像是SLDB数据库
                //建表Folder,括号内为:字段1 类型,字段2 类型,......(NOT NULL表示不能空)
                cmd3.CommandText = data3;
                cmd3.ExecuteNonQuery();//执行SQLCMMAD

                Console.WriteLine("增加表data");

            }
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

                selectName = textBox_用户名.Text;
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
        private void button_登录_Click(object sender, EventArgs e)
        {
            //倒计时器 a = new 倒计时器("登陆倒计时",30);
            //a.Show();
            
            
            

            if (textBox_用户名.Text.Trim() == String.Empty || textBox_密码.Text.Trim() == String.Empty) //为空
            {
                MessageBox.Show("请输入用户名和密码", "提示");
            }
            else
            {

                用户.初始用户名 = textBox_用户名.Text;
                chaxun_mima();
                if (textBox_密码.Text == 用户.初始密码)
                {
                    主界面 b = new 主界面();
                    b.Show();
                    PageList.nowPageId++;
                    PageList.pageList.Add(b);


                }
                else
                {
                    MessageBox.Show("账号或密码错误,请重新输入", "错误");  //提示错误;
                }
          
            }
          
           
        }

        private void button_关闭_Click(object sender, EventArgs e)
        {

            if (PageList.pageList.Count != 0)
            {
                PageList.pageList.Remove(PageList.nowPageId);
                PageList.nowPageId--;
            }
            this.Close();
            
            
        }

        private void 登录_Load(object sender, EventArgs e)
        {
            textBox_用户名.Text = "broer";
            textBox_密码.Text = "123456";
            new_access(Filename_数据文件, Filename_测试记录_data, Filename_用户管理_data, Filename_呼吸器管理_data);  //新建或打开数据库

        }
    }
}
