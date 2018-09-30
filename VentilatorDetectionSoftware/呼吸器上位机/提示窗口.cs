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
    public partial class 提示窗口 : Form
    {
        public String text;

        public 提示窗口(String s)
        {
            InitializeComponent();
            this.提示内容.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 提示_Load(object sender, EventArgs e)
        {

        }

        private void 提示内容_Click(object sender, EventArgs e)
        {

        }
    }
}
