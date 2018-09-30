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
    public partial class 耗气量测试设置 : Form
    {
        public 耗气量测试设置()
        {
            InitializeComponent();
        }

        private void button_取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void send(byte i)
        {
            try
            {
                串口设置.pCurrentWin_.textBox_串口发送.Text = i.ToString();
            }
            catch
            {

            }

        }
        private void button_确定_Click(object sender, EventArgs e)
        {
            耗气量测试.Mpa_4 = Convert.ToSingle(textBox_4Mpa.Text);
            耗气量测试.Mpa_3 = Convert.ToSingle(textBox_3Mpa.Text);
            耗气量测试.Mpa_2 = Convert.ToSingle(textBox_2Mpa.Text);
            耗气量测试.Mpa_1 = Convert.ToSingle(textBox_1Mpa.Text);
            耗气量测试.Mpa = (耗气量测试.Mpa_4 + 耗气量测试.Mpa_3 + 耗气量测试.Mpa_2 + 耗气量测试.Mpa_1)/4;
            send(0x54);  //停止耗气量测试
            this.Close();

        }

        private void 耗气量测试设置_Load(object sender, EventArgs e)
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
    }
}
