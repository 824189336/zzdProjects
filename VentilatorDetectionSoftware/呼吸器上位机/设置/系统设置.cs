using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 呼吸器上位机.主界面单项
{
    public partial class 系统设置 : Form
    {
        public 系统设置()
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

        private void button_检验周期和提醒设置_Click(object sender, EventArgs e)
        {
            呼吸器上位机.系统设置.检验周期和提醒设置 a = new 呼吸器上位机.系统设置.检验周期和提醒设置();
            a.Show();
          //  a.TopMost = true;
            PageList.nowPageId++;
            PageList.pageList.Add(a);
        }

        private void button_传感器校验_Click(object sender, EventArgs e)
        {
            呼吸器上位机.系统设置.传感器校验 a = new 呼吸器上位机.系统设置.传感器校验();
            a.Show();
        //    a.TopMost = true;
            PageList.nowPageId++;
            PageList.pageList.Add(a);
        }

        private void 系统设置_Load(object sender, EventArgs e)
        {

        }
    }
}
