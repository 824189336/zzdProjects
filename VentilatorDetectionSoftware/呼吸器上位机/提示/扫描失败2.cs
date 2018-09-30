using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 呼吸器上位机.提示
{
    public partial class 扫描失败2 : Form
    {
        public 扫描失败2()
        {
            InitializeComponent();
            this.Icon = new Icon(System.IO.Directory.GetCurrentDirectory() + "\\图标\\warning.ico");
        }

        private void button_取消_Click(object sender, EventArgs e)
        {
            if (PageList.pageList.Count != 0)
            {
                PageList.pageList.Remove(PageList.nowPageId);
                PageList.nowPageId--;
            }
            this.Close();
        }

        private void button_确定_Click(object sender, EventArgs e)
        {
            if (PageList.pageList.Count != 0)
            {
                PageList.pageList.Remove(PageList.nowPageId);
                PageList.nowPageId--;
            }
            主界面单项.呼吸器管理 a = new 主界面单项.呼吸器管理();
            a.Show();
            PageList.nowPageId++;
            PageList.pageList.Add(a);

            this.Close();
        }

        private void 扫描失败2_Load(object sender, EventArgs e)
        {

        }
    }
}
