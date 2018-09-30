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
    public partial class 设置 : Form
    {
        public 设置()
        {
            InitializeComponent();
        }
      
        private void 主界面_Load(object sender, EventArgs e)  //建3个数据库
        {
                     
        }

        private void button_呼吸器测试_Click(object sender, EventArgs e)
        {
           
        }

        private void button_用户管理_Click(object sender, EventArgs e)
        {
            提示.用户管理密码校验 a = new 提示.用户管理密码校验();
            a.Show();
            PageList.nowPageId++;
            PageList.pageList.Add(a);
        }

        private void button_呼吸器管理_Click(object sender, EventArgs e)
        {

            主界面单项.呼吸器管理 a = new 主界面单项.呼吸器管理();
            a.Show();
            PageList.nowPageId++;
            PageList.pageList.Add(a);

        }

        private void button_测试记录_Click(object sender, EventArgs e)
        {
            主界面单项.测试记录 a = new 主界面单项.测试记录();  
            a.Show();
            PageList.nowPageId++;
            PageList.pageList.Add(a);
        }

        private void button_系统设置_Click(object sender, EventArgs e)
        {
            主界面单项.系统设置 a = new 主界面单项.系统设置(); 
            a.Show();
            PageList.nowPageId++;
            PageList.pageList.Add(a);
        }

        private void button_更改密码_Click(object sender, EventArgs e)
        {
            主界面单项.更改密码 a = new 主界面单项.更改密码();
            a.Show();
            PageList.nowPageId++;
            PageList.pageList.Add(a);
        }

        private void button_退出登录_Click(object sender, EventArgs e)
        {
            if (PageList.pageList.Count != 0)
            {
                PageList.pageList.Remove(PageList.nowPageId);
                PageList.nowPageId--;
            }
            this.Close();
        }
       
        private void button_串口设置_Click(object sender, EventArgs e)
        {

            主界面.pCurrentWin_主界面.a.Show();

            PageList.nowPageId++;
            PageList.pageList.Add(主界面.pCurrentWin_主界面.a);

        }
    }
}
