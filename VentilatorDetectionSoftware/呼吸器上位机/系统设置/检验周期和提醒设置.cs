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
    public partial class 检验周期和提醒设置 : Form
    {
        public 检验周期和提醒设置()
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

        private void 检验周期和提醒设置_Load(object sender, EventArgs e)
        {

        }
    }
}
