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
    public partial class 筛选 : Form
    {
        public 筛选()
        {
            InitializeComponent();
        }
        private void 筛选_Load(object sender, EventArgs e)
        {

        }

        private void button_查询_Click(object sender, EventArgs e)
        {

        }

        bool 产品型号_flag = false;
        bool 制造商_flag = false;
        bool 产品编号_flag = false;
        bool 状态_flag = false;
        bool 日期_flag = false;

        string 产品型号 = "";
        string 制造商 = "";
        string 产品编号 = "";
        string 状态 = "";
        string 日期1 = "";
        string 日期2 = "";
        private void checkBox_并_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_并.Checked == true)
            {

            }
            else
            { 
            
            }
        }

        private void checkBox_或_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_或.Checked == true)
            {

            }
            else
            {

            }
        }

        private void checkBox_产品型号_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_产品型号.Checked == true)
            {
                产品型号_flag = true;
                产品型号 = textBox_产品型号.Text;
            }
            else
            {
                产品型号_flag = false;
            }
        }

        private void checkBox_制造商_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_制造商.Checked == true)
            {
                制造商_flag = true;
                制造商 = textBox_制造商.Text;
            }
            else
            {
                制造商_flag = false;
            } 
        }

        private void checkBox_产品编号_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_产品编号.Checked == true)
            {
                产品编号_flag = true;
                产品编号 = textBox_产品编号.Text;
            }
            else
            {
                产品编号_flag = false;
            } 
        }

        private void checkBox_状态_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_状态.Checked == true)
            {
                状态_flag = true;
                状态 = comboBox_状态.Text;
            }
            else
            {
                状态_flag = false;
            } 
        }

        private void checkBox_检测日期_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_检测日期.Checked == true)
            {
                日期_flag = true;
                日期1 = dateTimePicker1.Value.ToString();
                日期2 = dateTimePicker2.Value.ToString();
            }
            else
            {
                日期_flag = false;
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PageList.pageList.Count != 0)
            {
                PageList.pageList.Remove(PageList.nowPageId);
                PageList.nowPageId--;
            }
            this.Close();
        }
    }
}
