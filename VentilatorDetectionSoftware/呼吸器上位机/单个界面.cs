using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 呼吸器上位机
{
    public partial class 单个界面 : Form
    {
        public 单个界面()
        {
            InitializeComponent();
        }

     
        private void button_所有测试_Click(object sender, EventArgs e)
        {
            扫描参数.主界面 = false;
            扫描参数.单个界面 = true;

            提示.扫描 a = new 提示.扫描(this);
            a.Show();
            PageList.nowPageId++;
            PageList.pageList.Add(a);

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

        private void 单个界面_Load(object sender, EventArgs e)
        {
            label_呼吸器型号.Text = 呼吸器信息.呼吸器型号;
            lable_呼吸器编号.Text = 呼吸器信息.呼吸器编号;
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[0].Cells["检测日期"].Value = 呼吸器信息.检测日期;
            this.dataGridView1.Rows[0].Cells["检验员"].Value = 呼吸器信息.检验员;
            this.dataGridView1.Rows[0].Cells["状况"].Value = 呼吸器信息.状况;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
