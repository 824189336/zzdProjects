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

namespace 呼吸器上位机
{
    public partial class 主界面 : Form
    {
        public 主界面()
        {
            InitializeComponent();
        }
        public static 主界面 pCurrentWin_主界面 = null;
        public static string path = System.Windows.Forms.Application.StartupPath;  //获取当前程序运行路径
        public 串口设置 a = new 串口设置();
        private void button_设置_Click(object sender, EventArgs e)
        {
            设置 a = new 设置();
            a.Show();
            PageList.nowPageId++;
            PageList.pageList.Add(a);

        }

        private void button_返回_Click(object sender, EventArgs e)
        {
            //登录.pFormHandle.Show();
            //  登录 a = new 登录();
            // a.Show();
            if (PageList.pageList.Count != 0)
            {
                PageList.pageList.Remove(PageList.nowPageId);
                PageList.nowPageId--;
            }

            this.Close();
        }

        private void button_扫描_Click(object sender, EventArgs e)
        {
            扫描参数.主界面 = true;
            扫描参数.单个界面 = false;

            提示.扫描 a = new 提示.扫描(this);
            a.Show();
        }
        System.Data.DataTable dt = new System.Data.DataTable();
        private void 主界面_Load(object sender, EventArgs e)
        {
            pCurrentWin_主界面 = this;

            string connStr;
            OleDbConnection conn;

            connStr =
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + 登录.Filename_数据文件 + ";Jet OLEDB:Engine Type=5";
            conn = new OleDbConnection(connStr);
            conn.Open();

            System.Data.OleDb.OleDbDataAdapter da = new OleDbDataAdapter(数据库参数.sql_呼吸器管理, 数据库参数.mycon);
           
            dt.Clear();
            conn.Close();

            try
            {
                da.Fill(dt);  //将数据库内容填充到dt 这个DataTable（数据表）中
               
                if (dt.Rows.Count >= 1)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                   {
                        this.dataGridView1.Rows.Add();
                        this.dataGridView1.Rows[i].Cells["编号"].Value = dt.Rows[i][2].ToString();
                        this.dataGridView1.Rows[i].Cells["型号"].Value = dt.Rows[i][4].ToString();
                        this.dataGridView1.Rows[i].Cells["使用单位"].Value = dt.Rows[i][7].ToString();
                        this.dataGridView1.Rows[i].Cells["上次测试时间"].Value = dt.Rows[i][10].ToString();
                        this.dataGridView1.Rows[i].Cells["检测员"].Value = dt.Rows[i][6].ToString();
                        this.dataGridView1.Rows[i].Cells["制造商"].Value = dt.Rows[i][3].ToString();
                    }
                 

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

            label_呼吸器总数.Text = dt.Rows.Count.ToString();
            label_待测呼吸器.Text = dt.Rows.Count.ToString();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            当前呼吸器.ID= int.Parse(dt.Rows[e.RowIndex][0].ToString());
      
            呼吸器信息.呼吸器编号=dt.Rows[e.RowIndex][2].ToString();
            呼吸器信息.呼吸器型号=dt.Rows[e.RowIndex][4].ToString();
            呼吸器信息.检测日期=dt.Rows[e.RowIndex][10].ToString();
            呼吸器信息.检验员=dt.Rows[e.RowIndex][11].ToString();
            呼吸器信息.状况 = dt.Rows[e.RowIndex][16].ToString();
            呼吸器信息.制造商 = dt.Rows[e.RowIndex][3].ToString();
            呼吸器信息.使用者 = dt.Rows[e.RowIndex][6].ToString();
            呼吸器信息.使用单位 = dt.Rows[e.RowIndex][7].ToString();
            呼吸器信息.入库日期 = dt.Rows[e.RowIndex][9].ToString();
            呼吸器信息.出厂日期=dt.Rows[e.RowIndex][8].ToString();
            呼吸器信息.检测日期 = dt.Rows[e.RowIndex][10].ToString();

            单个界面 a = new 单个界面();
            a.Show();
            PageList.nowPageId++;
            PageList.pageList.Add(a);
        }

        private void button_筛选_Click(object sender, EventArgs e)
        {
            筛选 a = new 筛选();
            a.Show();
            PageList.nowPageId++;
            PageList.pageList.Add(a);
        }
    }
}
