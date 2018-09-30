using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 呼吸器上位机.系统设置
{
    public partial class 传感器校验 : Form
    {
        public 传感器校验()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void 传感器校验_Load(object sender, EventArgs e)
        {

        }
    }
}
