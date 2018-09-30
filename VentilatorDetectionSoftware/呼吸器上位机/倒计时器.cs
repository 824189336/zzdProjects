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
    public partial class 倒计时器 : Form
    {
        public int total_time;
        public string message;
        public int time_count = 0;
        private Timer Timer = new Timer();


        /*********************************************
         message     ： 倒计时提示内容
         total_time  ： 倒计时总时间
         *********************************************/

        public 倒计时器(string message, int total_time)
        {
            InitializeComponent();
            this.message = message;
            this.total_time = total_time;

            this.倒计时项目.Text = message;

            Timer.Tick += new EventHandler(TimerEventProcessor);
            Timer.Interval = 100;//0.1s 执行一次定时循环
            Timer.Start();

            this.进度条.Value = 0;
            this.进度条.Maximum = total_time*10;

            this.返回键.Enabled= false;
            this.返回键.Click += new EventHandler(返回键_Click);

            this.TopMost = true;


        }

        private void 返回键_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimerEventProcessor(object sender, EventArgs e)
        {
            time_count++;
            this.进度条.Value = time_count;
            int s = total_time - time_count/10;
            this.倒计时时间.Text = s.ToString()+"/"+ total_time.ToString();
            if(time_count== total_time*10)
            {
                Timer.Stop();
                this.返回键.Text = "完成";
                this.返回键.Enabled = true;
            }
        }


        private void 倒计时器_Load(object sender, EventArgs e)
        {

        }

        private void 倒计时时间_Click(object sender, EventArgs e)
        {

        }

        private void 进度条_Click(object sender, EventArgs e)
        {

        }
    }
}
