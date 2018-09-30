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
    public partial class 扫描失败1 : Form
    {
        public 扫描失败1()
        {
            InitializeComponent();
            this.Icon = new Icon(System.IO.Directory.GetCurrentDirectory() + "\\图标\\warning.ico");
        }

        private void 扫描失败1_Load(object sender, EventArgs e)
        {

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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
