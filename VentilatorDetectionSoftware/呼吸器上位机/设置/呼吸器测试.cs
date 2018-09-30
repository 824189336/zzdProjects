using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;  // 导入名称空间 
using System.Drawing.Drawing2D;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;
using ADOX;
using System.Xml;
using System.Xml.Linq;
using System.IO.Ports;
 

namespace 呼吸器上位机.主界面单项
{
    public partial class 呼吸器测试 : Form
    {
        public 呼吸器测试()
        {
            InitializeComponent();
        }

        public class 打印   //声明一个打印类
        {

            Pen blackPen1 = new Pen(Color.Black, 1); //实例化一个画笔
            Pen blackPen2 = new Pen(Color.Black, 2); //实例化一个画笔
            public void 打印格式(PrintPageEventArgs e)
            {
                string[] a = { "面罩", "背板", "着装带", "导气管和接头", "供气阀、减压阀", "警报器", "压力表", "气瓶和气瓶阀", "呼气阀开启压力", "面罩泄漏", "供气阀开启压力", "静压值", "总管压降", "启报压力值", "平均报警声强", "平均耗气量", "压力表偏差值", "吸气阻力1", "呼气阻力1", "吸气阻力2", "呼气阻力2" };
                string[] b = { "＜700pa", "＜125pa", "≥-1000pa", "＜500pa", "＞150pa", "≤2MPa", "5~6MPa", "≥90dB(A)", "≤5L/min", "≤2.5%量程", "≤500Pa", "≤1000Pa", "≤500Pa", "≤700Pa" };
                String[] 下标 = { "0", "3", "6", "9", "12", "15", "18", "21", "24", "27", "30" };
                String[] 纵标 = { "-400", "0", "400", "800", "1200" };
                
                e.Graphics.DrawString("呼吸器测试报告", new Font("Arial", 14), Brushes.Black, 350, 10); //表头
/////////////////////////////////////////////////////横线////////////////////////////////////////////////////////////////////////////////////////
                e.Graphics.DrawLine(blackPen1, 20, 40, 807, 40);

                for (int i = 0; i < 3; i++)
                    e.Graphics.DrawLine(blackPen1, 55, 62 + i * 22, 807, 62 + i * 22); //基本信息中线
            

                for (int i = 0; i < 3; i++)
                    e.Graphics.DrawLine(blackPen1, 20, 128 + i * 22, 807, 128 + i * 22);
              

                for (int i = 0; i < 7;i++ )
                    e.Graphics.DrawLine(blackPen1, 194, 194 + i * 22, 584, 194 + i * 22); //呼吸器外观检查 中间短线

                e.Graphics.DrawLine(blackPen1, 20, 348, 807, 348);
                e.Graphics.DrawLine(blackPen1, 194, 370, 584, 370);
                e.Graphics.DrawLine(blackPen1, 20, 392, 807, 392);
                e.Graphics.DrawLine(blackPen1, 55, 414, 584, 414);
                e.Graphics.DrawLine(blackPen1, 20, 458, 807, 458);
                e.Graphics.DrawLine(blackPen1, 20, 480, 807, 480);
                e.Graphics.DrawLine(blackPen1, 194, 502, 584, 502);
                e.Graphics.DrawLine(blackPen1, 194, 524, 584, 524);
                e.Graphics.DrawLine(blackPen1, 20, 546, 807, 546);
                e.Graphics.DrawLine(blackPen1, 20, 568, 807, 568);
                for (int i = 0; i < 3; i++)
                    e.Graphics.DrawLine(blackPen1, 194, 590 + i * 22, 584, 590 + i * 22);
                e.Graphics.DrawLine(blackPen2, 20, 656, 807, 656);

                e.Graphics.DrawLine(blackPen2, 20, 832, 807, 832);
                e.Graphics.DrawLine(blackPen1, 20, 1008, 807, 1008);
                e.Graphics.DrawLine(blackPen1, 20, 1074, 807, 1074);
                e.Graphics.DrawLine(blackPen1, 20, 1118, 807, 1118);
////////////////////////////////////////////竖线//////////////////////////////////////////////////////////////////////////////////////////////////
                e.Graphics.DrawLine(blackPen1, 20, 40, 20, 1118);
                e.Graphics.DrawLine(blackPen1, 807, 40, 807, 1118);

                e.Graphics.DrawLine(blackPen1, 55, 40, 55, 128);
                e.Graphics.DrawLine(blackPen1, 443, 40, 443, 128);

                e.Graphics.DrawLine(blackPen1, 55, 172-22, 55, 656);
                e.Graphics.DrawLine(blackPen1, 194, 172-22, 194, 656);

                e.Graphics.DrawLine(blackPen1, 323, 172-22, 323, 656);
                e.Graphics.DrawLine(blackPen1, 400, 172-22, 400, 656);
                e.Graphics.DrawLine(blackPen1, 490, 172-22, 490, 656);

                e.Graphics.DrawLine(blackPen1, 584, 172-22, 584, 656);
                e.Graphics.DrawLine(blackPen1, 658, 172-22, 658, 656);
                e.Graphics.DrawLine(blackPen1, 732, 172-22, 732, 656);
//////////////////////////////////////////////////////////文字///////////////////////////////////////////////////////////////////////////////////////////
                e.Graphics.DrawString("产品型号", new Font("Arial", 12), Brushes.Black, 55, 42);
                e.Graphics.DrawString("产品编号", new Font("Arial", 12), Brushes.Black, 55, 64);
                e.Graphics.DrawString("制造厂商", new Font("Arial", 12), Brushes.Black, 55, 86);
                e.Graphics.DrawString("出厂日期", new Font("Arial", 12), Brushes.Black, 55, 108);

                e.Graphics.DrawString("使用单位", new Font("Arial", 12), Brushes.Black, 443, 42);
                e.Graphics.DrawString("使用者", new Font("Arial", 12), Brushes.Black, 443, 64);
                e.Graphics.DrawString("入库日期", new Font("Arial", 12), Brushes.Black, 443, 86);
                e.Graphics.DrawString("上一次测试日期", new Font("Arial", 12), Brushes.Black, 443, 108);

                e.Graphics.DrawString("序号", new Font("Arial", 10), Brushes.Black, 20, 152);
                e.Graphics.DrawString("测试项目", new Font("Arial", 10), Brushes.Black, 55, 152);
                e.Graphics.DrawString("测试内容", new Font("Arial", 10), Brushes.Black, 194, 152);
                e.Graphics.DrawString("测试结果", new Font("Arial", 10), Brushes.Black, 323, 152);
                e.Graphics.DrawString("测试值", new Font("Arial", 10), Brushes.Black, 400, 152);
                e.Graphics.DrawString("参考值", new Font("Arial", 10), Brushes.Black, 490, 152);
                e.Graphics.DrawString("测试日期", new Font("Arial", 10), Brushes.Black, 584, 152);
                e.Graphics.DrawString("测试单位", new Font("Arial", 10), Brushes.Black, 658, 152);
                e.Graphics.DrawString("测试人员", new Font("Arial", 10), Brushes.Black, 732, 152);

                e.Graphics.DrawString("1    呼吸器外观检查", new Font("Arial", 10), Brushes.Black, 32, 255);
                e.Graphics.DrawString("2    面罩泄漏测试", new Font("Arial", 10), Brushes.Black, 32, 360);
                e.Graphics.DrawString("3    开启/静压测试", new Font("Arial", 10), Brushes.Black, 32, 416);
                e.Graphics.DrawString("4    整机气密性测试", new Font("Arial", 10), Brushes.Black, 32, 460);
                e.Graphics.DrawString("5    报警器性能测试", new Font("Arial", 10), Brushes.Black, 32, 504);
                e.Graphics.DrawString("6    压力表校验", new Font("Arial", 10), Brushes.Black, 32, 549);
                e.Graphics.DrawString("7    动态呼吸阻力测试", new Font("Arial", 10), Brushes.Black, 32, 605);

                for (int i = 0; i < 11; i++)
                { 
                e.Graphics.DrawString(a[i], new Font("Arial", 10), Brushes.Black, 194, 174+i*22);
                }
                e.Graphics.DrawString(a[11], new Font("Arial", 10), Brushes.Black, 194, 427);
                for (int i = 1; i < 10; i++)
                {
                    e.Graphics.DrawString(a[i+11], new Font("Arial", 10), Brushes.Black, 194, 439 + i * 22);
                }

                for (int i = 0; i < 14; i++)
                {
                    e.Graphics.DrawString(b[i], new Font("Arial", 10), Brushes.Black, 490, 350 + i * 22);
                }

              
                e.Graphics.DrawString("评语", new Font("Arial", 10), Brushes.Black, 20, 1008);
                e.Graphics.DrawString("系统判定：", new Font("Arial", 10), Brushes.Black, 20, 1074);
                e.Graphics.DrawString("打印日期:", new Font("Arial", 10), Brushes.Black, 584, 1074);
                ////////////////////////////////////////表格///20, 656//////////////////////////////////////////////////////////////////////
                e.Graphics.DrawLine(blackPen1, 50, 666, 50, 806);
                e.Graphics.DrawLine(blackPen1, 50, 806, 787, 806);
                for (int i = 0; i < 11; i++)
                {
                    if (i != 0)
                    {
                        e.Graphics.DrawLine(blackPen1, 50 + i * 70, 806, 50 + i * 70, 809);
                        e.Graphics.DrawString(下标[i], new Font("Arial", 10), Brushes.Black, 45 + i * 70, 810);
                    }

                }
                for (int i = 0; i < 5; i++)
                {
                    if (i != 0)
                        e.Graphics.DrawLine(blackPen1, 45, 806 - i * 30, 50, 806 - i * 30);

                    e.Graphics.DrawString(纵标[i], new Font("Arial", 10), Brushes.Black, 20, 796 - i * 30);
                }
                ////////////////////////////////////////////////////表格//// 20, 832/ 176//////////////////////////////////////////////////////////// 
                e.Graphics.DrawLine(blackPen1, 50, 666 + 176, 50, 806 + 176);
                e.Graphics.DrawLine(blackPen1, 50, 806 + 176, 787, 806 + 176);
                for (int i = 0; i < 11; i++)
                {
                    if (i != 0)
                    {
                        e.Graphics.DrawLine(blackPen1, 50 + i * 70, 806 + 176, 50 + i * 70, 809 + 176);
                        e.Graphics.DrawString(下标[i], new Font("Arial", 10), Brushes.Black, 45 + i * 70, 810 + 176);
                    }

                }
                for (int i = 0; i < 5; i++)
                {
                    if (i != 0)
                        e.Graphics.DrawLine(blackPen1, 45, 806 - i * 30 + 176, 50, 806 - i * 30 + 176);

                    e.Graphics.DrawString(纵标[i], new Font("Arial", 10), Brushes.Black, 20, 796 - i * 30 + 176);
                }
            }

        }


        private void button_呼吸器外观检查_Click(object sender, EventArgs e)
        {

           
          
        }

        private void button_面罩泄漏测试_Click(object sender, EventArgs e)
        {
          
        }

        private void button_开启静压测试_Click(object sender, EventArgs e)
        {
           
        }

        private void button_整机气密测试_Click(object sender, EventArgs e)
        {
        }

        private void button_压力表校验_Click(object sender, EventArgs e)
        {
           
        }

        private void button_报警器测试_Click(object sender, EventArgs e)
        {
           
        }

        private void button_动态呼吸阻力测试_Click(object sender, EventArgs e)
        {
           
        }

        private void button_返回_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 呼吸器测试_Load(object sender, EventArgs e)
        {

        }

        private void button_串口设置_Click(object sender, EventArgs e)
        {
            
        }

        private void button_打印_Click(object sender, EventArgs e)
        {
            this.printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custum", 827, 1169);  //英寸

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ClientSize = new Size(827, 1169);  //设置预览窗体大小
            printPreviewDialog1.PrintPreviewControl.Zoom = 1.0;   //设置预览时的比例
            printPreviewDialog1.Document = this.printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)   //打印事件 加载打印预览界面
        {
            打印 print = new 打印();
            print.打印格式(e);
        }

        private void button_匹配_Click(object sender, EventArgs e)
        {

        }
    }
}
