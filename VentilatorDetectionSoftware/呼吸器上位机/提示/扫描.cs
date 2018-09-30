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
    public partial class 扫描 : Form
    {
       

        Form f;
        public 扫描(Form _f_)
        {
            InitializeComponent();
            f = _f_;
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

        private void button_输入确认_Click(object sender, EventArgs e)
        {
            if (扫描参数.主界面 == true && 扫描参数.单个界面 == false)  //
            {
                if (textBox_呼吸器编号.Text == "123")
                { 
                   
                    呼吸器测试 a = new 呼吸器测试();
                    a.Show();

                    PageList.nowPageId++;
                    PageList.pageList.Add(a);

                }
                else
                {
                    提示.扫描失败2 a = new 扫描失败2();
                    a.Show();
                    a.TopMost = true;


                    PageList.nowPageId++;
                    PageList.pageList.Add(a);
                }
           
            }
            else if (扫描参数.主界面 == false && 扫描参数.单个界面 == true) 
            {
                if (textBox_呼吸器编号.Text == 呼吸器信息.呼吸器编号)
                {
                    呼吸器测试 a = new 呼吸器测试();
                    a.Show();                    

                    PageList.nowPageId++;
                    PageList.pageList.Add(a);

                    f.Close();
                }
                else
                {
                    提示.扫描失败1 a = new 扫描失败1();
                    a.Show();
                    a.TopMost = true;


                    PageList.nowPageId++;
                    PageList.pageList.Add(a);
                }
           
            }
            this.Close();
           
        }

        private void 扫描_Load(object sender, EventArgs e)
        {

        }

        private void textBox_呼吸器编号_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
