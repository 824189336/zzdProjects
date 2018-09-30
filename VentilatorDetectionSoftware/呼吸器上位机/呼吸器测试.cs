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

namespace 呼吸器上位机
{
    public partial class 呼吸器测试 : Form
    {
    public class DoubleBufferPanel : Panel
     {
     public DoubleBufferPanel()
      {
       this.SetStyle(ControlStyles.AllPaintingInWmPaint | //不擦除背景 ,减少闪烁
            ControlStyles.OptimizedDoubleBuffer | //双缓冲
            ControlStyles.UserPaint, //使用自定义的重绘事件,减少闪烁
            true);
      }
    }

        public int pTabControlSelectedIndex = 0;
        private System.Timers.Timer timer;
        public bool timerWorkingFlag = false;
        public 呼吸器测试()
        {        
            InitializeComponent();
     
            string URL = System.IO.Directory.GetCurrentDirectory()+ "\\视频\\教学视频.mp4";
            if (File.Exists(URL))
            {
                播放视频.currentPlaylist.appendItem(播放视频.newMedia(URL));
                播放视频.settings.setMode("loop", true);
                播放视频.Ctlcontrols.pause();

                tabControl_整体气密测试.SelectedIndexChanged += new EventHandler(this.tabControl_整体气密测试_SelectedIndexChanged);
                this.pTabControlSelectedIndex = this.tabControl_整体气密测试.SelectedIndex;
            }
            else
            {

            }

        }



    /*********************************************************************************************************************
     * 部分全局变量
     *
   **********************************************************************************************************************/
    bool 呼吸器外观检查 = false;
        bool 面罩泄漏测试 = false;
        bool 开启静压测试 = false;
        bool 整机气密测试 = false;
        bool 压力表校验 = false;
        bool 报警器测试 = false;
        bool 动态呼吸阻力测试 = false;
        
             string 面罩_1 = "未检测";
             string 面罩_2 = "未检测";
             string 面罩_3 = "未检测";
             string 面罩_4 = "未检测";
             string 面罩 = "未检测";

             string 背板_1 = "未检测";
             string 背板_2 = "未检测";
             string 背板 = "未检测";

             string 着装带_1 = "未检测";
             string 着装带_2 = "未检测";
             string 着装带 = "未检测";

             string 导气管和接头_1 = "未检测";
             string 导气管和接头_2 = "未检测";
             string 导气管和接头 = "未检测";

             string 供气阀和减压器_1 = "未检测";
             string 供气阀和减压器_2 = "未检测";
             string 供气阀和减压器 = "未检测";

             string 警报器_1 = "未检测";
             string 警报器 = "未检测";

             string 压力表_1 = "未检测";
             string 压力表_2 = "未检测";
             string 压力表_3 = "未检测";
             string 压力表 = "未检测";

             string 气瓶和气阀_1 = "未检测";
             string 气瓶和气阀 = "未检测";

             string 系统时间 = " ";
             string 用户名 = "broer";
             string 测试结果 = "a";
             public static 呼吸器测试 pCurrentWin = null;  //串口设置子窗口可调用主窗口的串口控件。

             public static string path = System.Windows.Forms.Application.StartupPath;  //获取当前程序运行路径
             string filename_1 = path + "\\报警器";    //组合路径1
             string filename_2 = path + "\\动态呼吸阻力";    //组合路径1
             string txt_name_报警器_步长 = path + "\\" + "报警器\\" + "\\" + "111" + ".txt";
             string txt_name_报警器_声强 = path + "\\" + "报警器\\" + "\\" + "111" + ".txt";
             string txt_name_动态呼吸阻力_面罩内压力 = path + "\\" + "动态呼吸阻力\\" + "\\" + "111" + ".txt";
             string txt_name_动态呼吸阻力_总管压力 = path + "\\" + "动态呼吸阻力\\" + "\\" + "111" + ".txt";

             int Mpa = 60;
             int time_面罩泄露测试时间;
             int time_静态压力测试时间;
             int time_整机气密测试时间;
             int time_呼吸阻力测试时间;
             int 测试时间 = 0;   //判断当前是哪个测试时间计时
             int 压力表校验_num = 0;
             float[] 压力表校验_值 = new float[3];
             Int32 压力 = 0;  //压力表压力
             Int32 压力_old = 0; // 上一次压力值
             public List<int> DataList_声强 = new List<int>();      //数据结构----声强  
             public List<float> DataList_总管压力 = new List<float>();      //数据结构----总管压力  
             public List<int> DataList_DrawStep = new List<int>();      //数据结构----步长

             public List<int> DataList_面罩内压力 = new List<int>();      //数据结构----线性链表  

             private bool StateMachineBreak = false;

             private bool isWorking = false;//测试进行标志

             private bool isTimeCounting = false;//倒计时进行标志

             private bool noPowerTest = false;//不进行耗气量测试进行


        


             string now_time;
             /****************************************************************************************
              * printf 0-41 (后续可继续添加)
              * 0产品型号 1产品编号 2制造厂商 3出厂日期 4使用单位 5使用者 6入库日期 7上一次测试日期
              * 8面罩 9背板 10着装带 11导气管和接头 12供气阀减压阀 13警报器 14压力表 15气瓶和气阀
              * 16呼气阀开启压力—结果    29呼气阀开启压力—值
              * 17面罩泄露-结果 1         30面罩泄露-值
              * 18供气阀开启压力-结果     31供气阀开启压力-值
              * 19静压值-结果             32静压值-值
              * 20总管压降-结果           33总管压降-值
              * 21启报压力值-结果         34启报压力值-值
              * 22平均报警声强-结果       35平均报警声强-值
              * 23平均耗气量-结果         36平均耗气量-值
              * 24压力表偏差值-结果       37压力表偏差值-值
              * 25吸气阻力1-结果          38吸气阻力1-值
              * 26呼气阻力1-结果          39呼气阻力1-值
              * 27吸气阻力2-结果          40吸气阻力2-值
              * 28呼气阻力1-结果          41呼气阻力1-值
              * **************************************************************************************/
             string[] printf = new string[42];

             /*********************************************************************************************************************
             * 类声明
             * void 打印格式(e,string,int, List<int>, List<int>, List<int>)  // 画笔，测试结果数组，数组数量，声强，步长，面罩压力。 
             **********************************************************************************************************************/
             public class 打印  
        {

            Pen blackPen1 = new Pen(Color.Black, 1); //实例化一个画笔
            Pen blackPen2 = new Pen(Color.Black, 2); //实例化一个画笔

            private int DrawStep = 2;            //默认绘制单位
            private const int StartPrint_x = 50;//点坐标偏移量   左上角
            private const int StartPrint_y = 776;//点坐标偏移量
            public void 打印格式(PrintPageEventArgs e, string[] printf, int size, List<int> 面罩压力)
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


                for (int i = 0; i < 7; i++)
                    e.Graphics.DrawLine(blackPen1, 194, 194 + i * 22, 584, 194 + i * 22); //呼吸器外观检查 中间短线

                e.Graphics.DrawLine(blackPen1, 20, 348, 807, 348);
                e.Graphics.DrawLine(blackPen1, 194, 370, 584, 370);
                e.Graphics.DrawLine(blackPen1, 20, 392, 807, 392);
                e.Graphics.DrawLine(blackPen1, 194, 414, 584, 414);
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

                e.Graphics.DrawLine(blackPen1, 55, 172 - 22, 55, 656);
                e.Graphics.DrawLine(blackPen1, 194, 172 - 22, 194, 656);

                e.Graphics.DrawLine(blackPen1, 323, 172 - 22, 323, 656);
                e.Graphics.DrawLine(blackPen1, 400, 172 - 22, 400, 656);
                e.Graphics.DrawLine(blackPen1, 490, 172 - 22, 490, 656);

                e.Graphics.DrawLine(blackPen1, 584, 172 - 22, 584, 656);
                e.Graphics.DrawLine(blackPen1, 658, 172 - 22, 658, 656);
                e.Graphics.DrawLine(blackPen1, 732, 172 - 22, 732, 656);
                //////////////////////////////////////////////////////////文字///////////////////////////////////////////////////////////////////////////////////////////
                //0产品型号 1产品编号 2制造厂商 3出厂日期 4使用单位 5使用者 6入库日期 7上一次测试日期
                e.Graphics.DrawString("产品型号", new Font("Arial", 12), Brushes.Black, 55, 42);
                e.Graphics.DrawString(printf[0], new Font("Arial", 12), Brushes.Black, 180, 42);
                e.Graphics.DrawString("产品编号", new Font("Arial", 12), Brushes.Black, 55, 64);
                e.Graphics.DrawString(printf[1], new Font("Arial", 12), Brushes.Black, 180, 64);
                e.Graphics.DrawString("制造厂商", new Font("Arial", 12), Brushes.Black, 55, 86);
                e.Graphics.DrawString(printf[2], new Font("Arial", 12), Brushes.Black, 180, 86);
                e.Graphics.DrawString("出厂日期", new Font("Arial", 12), Brushes.Black, 55, 108);
                e.Graphics.DrawString(printf[3], new Font("Arial", 12), Brushes.Black, 180, 108);

                e.Graphics.DrawString("使用单位", new Font("Arial", 12), Brushes.Black, 443, 42);
                e.Graphics.DrawString(printf[4], new Font("Arial", 12), Brushes.Black, 588, 42);
                e.Graphics.DrawString("使用者", new Font("Arial", 12), Brushes.Black, 443, 64);
                e.Graphics.DrawString(printf[5], new Font("Arial", 12), Brushes.Black, 588, 64);
                e.Graphics.DrawString("入库日期", new Font("Arial", 12), Brushes.Black, 443, 86);
                e.Graphics.DrawString(printf[6], new Font("Arial", 12), Brushes.Black, 588, 86);
                e.Graphics.DrawString("上一次测试日期", new Font("Arial", 12), Brushes.Black, 443, 108);
                e.Graphics.DrawString(printf[7], new Font("Arial", 12), Brushes.Black, 588, 108);

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
                    e.Graphics.DrawString(a[i], new Font("Arial", 10), Brushes.Black, 194, 174 + i * 22);
                    e.Graphics.DrawString(printf[i+8], new Font("Arial", 10), Brushes.Black, 325, 174 + i * 22);
                    if (i > 7)
                    {
                        e.Graphics.DrawString(printf[i + 21], new Font("Arial", 10), Brushes.Black, 402, 174 + i * 22);
                    }
                }
                e.Graphics.DrawString(a[11], new Font("Arial", 10), Brushes.Black, 194, 427);
                e.Graphics.DrawString(printf[19], new Font("Arial", 10), Brushes.Black, 325, 427);
                e.Graphics.DrawString(printf[32], new Font("Arial", 10), Brushes.Black, 402, 427);

                for (int i = 1; i < 10; i++)
                {
                    e.Graphics.DrawString(a[i + 11], new Font("Arial", 10), Brushes.Black, 194, 439 + i * 22);
                    e.Graphics.DrawString(printf[i + 19], new Font("Arial", 10), Brushes.Black, 325, 439 + i * 22);
                    e.Graphics.DrawString(printf[i + 32], new Font("Arial", 10), Brushes.Black, 402, 439 + i * 22);
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
                ////////////////////////////////////////////////////表格//// 20, 832/ 176///////动态呼吸阻力测试，面罩压力和时间///////////////////////////////////////////////////// 
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
                for (int i = 0; i < 面罩压力.Count - 1; i++)//绘制
                {
                    e.Graphics.DrawLine(blackPen1, StartPrint_x + i * DrawStep, 806 + 176 - (面罩压力[i]/2) - 30, StartPrint_x + (i + 1) * DrawStep, 806 + 176 - (面罩压力[i + 1]/2) - 30);
                }
            }

        }
        public class Paint_压力表
        {
            public Int32 压力;
            Int32 MPx = 50;   //矩形X轴起始坐标
            Int32 MPy = 100;   //矩形Y轴起始坐标
            Int32 MW = 30;
            Int32 MP = 50;   //矩形单位长度，实际数值代表50
            String drawString_D = "25";
            String drawString_C = "20";
            String drawString_B = "10";
            String drawString_A = "0";
            public void Paint(Graphics g,int a)
            {

                SolidBrush Red = new SolidBrush(Color.Red);
                switch (a)
                {
                    case 60:
                        g.FillRectangle(Red, MPx, MPy + MP * 6 - 压力 * 5, MW, 压力 * 5);
                        break;
                    case 25:
                        g.FillRectangle(Red, MPx, MPy + MP * 6 - 压力 * 12, MW, 压力 * 12);
                        break;
                    case 20:
                        g.FillRectangle(Red, MPx, MPy + MP * 6 - 压力 * 15, MW, 压力 * 15);
                        break;
                    case 10:
                        g.FillRectangle(Red, MPx, MPy + MP * 6 - 压力 * 30, MW, 压力 * 30);
                        break;
                }
              
                Pen p = new Pen(Color.Red, 2);//定义了一个红色,宽度为2的画笔.

                g.DrawRectangle(p, MPx, MPy, MW, MP * 6);//在画板上画矩形,起始坐标为(MPx, MPy), 宽为MW, 高为MP * 8

                switch (a)
                {
                    case 60:
                             drawString_D = "60";
                             drawString_C = "40";
                             drawString_B = "20";
                             drawString_A = "0";
                        break;
                    case 25: 
                             drawString_D = "25";
                             drawString_C = "16.7";
                             drawString_B = "8.3";
                             drawString_A = "0";
                        break;
                    case 20: 
                        drawString_D = "20";
                        drawString_C = "13.3";
                        drawString_B = "6.6";
                        drawString_A = "0";
                        break;
                    case 10:
                        drawString_D = "10";
                        drawString_C = "6.6";
                        drawString_B = "3.3";
                        drawString_A = "0";
                        break;
                  
                }
               

                Font drawFont = new Font("Arial", 8); //字符格式

                SolidBrush drawBrush = new SolidBrush(Color.Red);// 字符颜色

                Int32 x = MPx + MW + 10; Int32 y = MPy - 6;// 数字字符起始地址

                //                          字符内容    字符格式   字符颜色  字符位置
                g.DrawString(drawString_D, drawFont, drawBrush, x, y);     //添加文字
                g.DrawString(drawString_C, drawFont, drawBrush, x, y + MP * 2);
                g.DrawString(drawString_B, drawFont, drawBrush, x, y + MP * 4);
                g.DrawString(drawString_A, drawFont, drawBrush, x, y + MP * 6);
               

                g.DrawLine(p, MPx + MW, MPy, MPx + MW + 10, MPy);       //40
                g.DrawLine(p, MPx + MW, MPy + MP * 1, MPx + MW + 5, MPy + MP * 1);   //35
                g.DrawLine(p, MPx + MW, MPy + MP * 2, MPx + MW + 10, MPy + MP * 2);  //30
                g.DrawLine(p, MPx + MW, MPy + MP * 3, MPx + MW + 5, MPy + MP * 3);   //25
                g.DrawLine(p, MPx + MW, MPy + MP * 4, MPx + MW + 10, MPy + MP * 4);  //20
                g.DrawLine(p, MPx + MW, MPy + MP * 5, MPx + MW + 5, MPy + MP * 5);   //15
                g.DrawLine(p, MPx + MW, MPy + MP * 6, MPx + MW + 10, MPy + MP * 6);  //10
                g.DrawLine(p, MPx + MW, MPy + MP * 7, MPx + MW + 5, MPy + MP * 7);   //5
                g.DrawLine(p, MPx + MW, MPy + MP * 8, MPx + MW + 10, MPy + MP * 8);  //0

            }
        }

        // 横坐标 如果间隔变成60个点 3s 那么步长就是1 暂且默认 1   //75个点3s 一个点 40ms 2个点80ms
        // 纵坐标 float *1000 把Mpa变成pa 送进来就行 
        public class 动态呼吸阻力
        {
            Pen p = new Pen(Color.Black, 1);//定义了一个黑色,宽度为2的画笔
            Font drawFont = new Font("Arial", 10); //字符格式

            SolidBrush drawBrush = new SolidBrush(Color.Black);// 字符颜色
            String[] 下标 = { "0", "3", "6", "9", "12", "15", "18", "21", "24", "27", "30" };
            String[] 纵标 = { "-400", "0", "400", "800", "1200" };
            String[] 竖向文字 = { "面", "罩", "内", "压", "力", "(Pa)" };

            String[] 上标 = { "50", "45", "40", "35", "30", "25", "20", "15", "10", "5", "0" };//总管压力0~45MPa


            private Pen LinesPen = new Pen(Color.FromArgb(0xa0, 0x00, 0x00));  // 颜色波形
            private int DrawStep = 2;            //默认绘制单位
            private const int StartPrint_x = 80;//点坐标偏移量
            private const int StartPrint_y = 30;//点坐标偏移量

            private Pen LinesPenUp = new Pen(Color.FromArgb(0x90,0xee,0x90));  // 总管压力-面罩压力波形，绿色

            private int cN = 0; //绘制面罩压力-总管压力图时，绘制点的个数，为两个List的短的一方的count


            public void paint(Graphics g, List<int> DataList, List<float> DataListUp)  //929, 354
            {

                g.DrawLine(p, 80, 30, 80, 300);
                g.DrawLine(p, 80, 300, 913, 300);

                g.DrawLine(p, 80, 30, 913, 30);//上X坐标，面罩和总管压力，总管压力上坐标计算公式x/50*750+Xstart




                for (int i = 0; i < 11; i++)
                {
                    if (i != 0)
                    {
                        g.DrawLine(p, 80 + i * 75, 300, 80 + i * 75, 305);
                        g.DrawString(下标[i], drawFont, drawBrush, 75 + i * 75, 305);


                        g.DrawLine(p, 80 + i * 75, 30, 80 + i * 75, 35);             //上标，总管压力，X范围80--830
                        g.DrawString(上标[i], drawFont, drawBrush, 75 + i * 75, 35);
                    }

                }
                for (int i = 0; i < 5; i++)
                {
                    if (i != 0)
                        g.DrawLine(p, 75, 300 - i * 60, 80, 300 - i * 60);

                    g.DrawString(纵标[i], drawFont, drawBrush, 40, 293 - i * 60);
                }

                g.DrawString("时  间 （S）", drawFont, drawBrush, 450, 320);
                g.DrawString("总管压力（Mpa）", drawFont, drawBrush, 450, 10); //总管压力txt
                g.DrawString("面罩压力-总管压力", drawFont, drawBrush, 85, 50); //曲线颜色，绿色是总管压力-面罩压力
                g.DrawLine(LinesPenUp, 230, 60,300,60);
                g.DrawString("面罩压力-  时间  ", drawFont, drawBrush, 85,65); 
                g.DrawLine(LinesPen, 230, 70, 300, 70);


                for (int i = 0; i < 6; i++)
                {
                    if (i == 5)
                        g.DrawString(竖向文字[i], drawFont, drawBrush, 10, 100 + i * 30);
                    else
                        g.DrawString(竖向文字[i], drawFont, drawBrush, 20, 100 + i * 30);
                }
                for (int i = 0; i < DataList.Count - 1; i++)//绘制
                {
                    g.DrawLine(LinesPen, StartPrint_x + i * DrawStep, 300 - DataList[i]-60, StartPrint_x + (i + 1) * DrawStep, 300  -DataList[i + 1]-60);
                }

                if(DataList.Count> DataListUp.Count) //确定绘图点数
                {
                    cN = DataListUp.Count;
                }
                else
                {
                    cN = DataList.Count;
                }


                for (int i = 0; i < cN - 1; i++)//绘制总管压力-面罩压力
                {
                    g.DrawLine(LinesPenUp, StartPrint_x +(int)(750-DataListUp[i]*15), 300 - DataList[i] - 60, StartPrint_x + (int)(750-DataListUp[i+1]*15), 300 - DataList[i + 1] - 60);//DataListUp[i]*750/50=DataListUp[i]*15
                }

            }

        }
     


        //横坐标 100个点1Mpa 分辨率0.01Mpa(10pa)一个点 Mpa/100 送进去，取小数点后2位 ，如果这一次等于上一次，不添加，如果超出0.01 ，跳过。
        //纵坐标  上位机送过来的 db float 上位机/0.2后 作为整数 添加进list
        public class 报警器曲线   
        {
            Pen p = new Pen(Color.Black, 1);//定义了一个黑色,宽度为2的画笔
            Font drawFont = new Font("Arial", 10); //字符格式
            private Pen LinesPen = new Pen(Color.FromArgb(0xa0, 0x00, 0x00));  // 颜色波形
           
            SolidBrush drawBrush = new SolidBrush(Color.Black);// 字符颜色

          //  private int DrawStep = 5;            //默认绘制单位
            private const int StartPrint_x = 80;//点坐标偏移量
            private const int StartPrint_y = 30;//点坐标偏移量
            private const int 报警器零点下限 = 300;

            String[] 下标 = { "8", "7", "6", "5", "4", "3", "2", "1", "0" };
            String[] 纵标 = { "60", "70", "80", "90", "100", "110" };
            String[] 竖向文字 = { "警", "报", "器", "分", "贝", "(dB)" };
            public void paint(Graphics g, List<int> DataList, List<int> DrawStep)  //963, 362
            {
                int step=0;
                int step_old = 0;
                g.DrawLine(p, 80, 30, 80, 300);
                g.DrawLine(p, 80, 300, 913, 300);

                for (int i = 0; i < 9; i++)
                {
                    if (i != 0)
                        g.DrawLine(p, 80 + i * 100, 300, 80 + i * 100, 305);

                    g.DrawString(下标[i], drawFont, drawBrush, 75 + i * 100, 305);
                }
                for (int i = 0; i < 6; i++)
                {
                    if (i != 0)
                        g.DrawLine(p, 75, 300 - i * 50, 80, 300 - i * 50);

                    g.DrawString(纵标[i], drawFont, drawBrush, 50, 293 - i * 50);
                }

                g.DrawString("总  管  压  力 （Mpa）", drawFont, drawBrush, 400, 320);
                for (int i = 0; i < 6; i++)
                {
                    if (i == 5)
                        g.DrawString(竖向文字[i], drawFont, drawBrush, 20, 100 + i * 30);
                    else
                        g.DrawString(竖向文字[i], drawFont, drawBrush, 30, 100 + i * 30);
                }
                for (int i = 0; i < DataList.Count - 1; i++)//绘制
                {
                    step = step + DrawStep[i];
                    g.DrawLine(LinesPen, StartPrint_x + step_old, 300 - (DataList[i] - 报警器零点下限), StartPrint_x + step, 300 - (DataList[i + 1] - 报警器零点下限));
                    step_old = step;
                }
            }

          
        }
        public void AddData_声强(int Data)
        {
            DataList_声强.Add(Data);      //链表尾部添加数据
        }
        public void AddData_DrawStep(int Data)
        {
            DataList_DrawStep.Add(Data);      //链表尾部添加数据
        }
        public void AddData_总管压力(float Data)
        {
            DataList_总管压力.Add(Data);      //链表尾部添加数据
        }
        public void AddData_面罩内压力(int Data)
        {
            DataList_面罩内压力.Add(Data);      //链表尾部添加数据
        }
         
        /*********************************************************************************************************************
         * 函数
         * 
         **********************************************************************************************************************/    
        void new_文件夹()
        {
            if (Directory.Exists(filename_1) == false)//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory(filename_1);  //新建文件夹
            }
            if (Directory.Exists(filename_2) == false)//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory(filename_2);  //新建文件夹
            }

        }
        void new_txt(string txt_name)
        {
            if (!File.Exists(txt_name))
            {
                FileStream fs1 = new FileStream(txt_name, FileMode.Create, FileAccess.Write);//创建写入文件 
                fs1.Close();
            }
        }//在指定位置新建一个txt文件
        void 添加_txt(List<int> list, string txt_name)  //向txt写入一个数据
        {
            FileStream fs = new FileStream(txt_name, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("gb2312"));
            for (int i = 0; i < list.Count; i++)
            {
                sw.WriteLine(list[i].ToString());
            }
            sw.Close();
            fs.Close();

        }
        public void zengjia(string str)   //添加一组数据
        {
            string connStr;
            OleDbConnection conn;
            OleDbCommand cmd;
            connStr =
              "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + 登录.Filename_数据文件 + ";Jet OLEDB:Engine Type=5";
            conn = new OleDbConnection(connStr);
            conn.Open();
            cmd = new OleDbCommand(str, conn);
            cmd.ExecuteNonQuery();//执行SQLCMMAD
            conn.Close();


        }
        string time(bool a)  //获取系统时间，字符串输出
        {
            string str;
            string year;
            string month;
            string day;
            string hour;
            string minute;
            string second;

            year = Convert.ToString(DateTime.Now.Year);

            if (DateTime.Now.Month < 10)
                month = "0" + Convert.ToString(DateTime.Now.Month);
            else
                month = Convert.ToString(DateTime.Now.Month);

            if (DateTime.Now.Day < 10)
                day = "0" + Convert.ToString(DateTime.Now.Day);
            else
                day = Convert.ToString(DateTime.Now.Day);

            if (DateTime.Now.Hour < 10)
                hour = "0" + Convert.ToString(DateTime.Now.Hour);
            else
                hour = Convert.ToString(DateTime.Now.Hour);
            if (DateTime.Now.Minute < 10)
                minute = "0" + Convert.ToString(DateTime.Now.Minute);
            else
                minute = Convert.ToString(DateTime.Now.Minute);
            if (DateTime.Now.Second < 10)
                second = "0" + Convert.ToString(DateTime.Now.Second);
            else
                second = Convert.ToString(DateTime.Now.Second);
            if (a)
                str = year + "/" + month + "/" + day + "-" + hour + ":" + minute + ":" + second;
            else
                str = year + month + day + hour + minute + second;
            return str;
        }

        void 测试记录_add()
        {
            系统时间 = time(true);   //获取系统时间
            string str_测试记录 = "insert into `data1`(`呼吸器编号`,`测试时间`,`测试人员`,`测试结果`,`型号`,`制造商`,`全部`)" + " values";
            string data = printf[0] + ',' + 系统时间 + ',' + 用户名 + ',' + 测试结果 + ',' + printf[0] + ',' + printf[2] + ',' + "abc";
            data = "'" + data.Replace(",", "','") + "'";
            string str_data = str_测试记录 + '(' + data + ");";
            zengjia(str_data);
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
       
 /*********************************************************************************************************************
  *   load 窗体初始化  呼吸阻力测试曲线 报警器曲线
  * 
  **********************************************************************************************************************/
        
        private void 呼吸器测试_Load(object sender, EventArgs e)
        {
           
            /* int i = 0;
            double[] aa =new double[6];
            aa[0] = -0.4;
            aa[1] = -0.3;
            aa[2] = -0.2;
            aa[3] = -0.1;
            aa[4] = 0;
            aa[5] = 0.1;*/
         
            pCurrentWin = this;
            用户名 = 用户.初始用户名;
            textBox_产品型号.Text = 呼吸器信息.呼吸器型号;
            textBox_制造厂商.Text = 呼吸器信息.制造商;
            textBox_使用单位.Text = 呼吸器信息.使用单位;
            textBox_入库日期.Text = 呼吸器信息.入库日期;
            textBox_产品编号.Text = 呼吸器信息.呼吸器编号;
            textBox_出厂日期.Text = 呼吸器信息.出厂日期;
            textBox_使用者.Text = 呼吸器信息.使用者;
            textBox_上一次测试日期.Text = 呼吸器信息.检测日期;
            
            printf[0] = textBox_产品型号.Text;
            printf[1] = textBox_产品编号.Text;
            printf[2] = textBox_制造厂商.Text;
            printf[3] = textBox_出厂日期.Text;
            printf[4] = textBox_使用单位.Text;
            printf[5] = textBox_使用者.Text;
            printf[6] = textBox_入库日期.Text;
            printf[7] = textBox_上一次测试日期.Text;
            comboBox_工作定额选择.Text = "每分100L/每分40次";
            new_文件夹(); //

            timer1.Enabled = true;   //初始化默认开始，1秒记录一次，
            timer1.Interval = 1000;
            now_time = time(false);
          //  报警器声强_flag = 1;//测试报警器曲线
          //  总管压力_flag = 5;  //
           // 面罩内压力_flag = 7; //测试呼吸阻力测试 
          //  总管压力_flag = 5;   //
          /*  AddData_声强(70*5);          
            AddData_DrawStep(10);
            AddData_声强(75 * 5);
            AddData_DrawStep(50);
            AddData_声强(80 * 5);
            AddData_DrawStep(100);
            AddData_声强(85 * 5);
            AddData_DrawStep(50);*/
          /*  for (int j = 0; j < 6; j++)
            {
                i = (int)Math.Round(aa[j] * 1000 / 6.67);//（保留0维小数就是取整）
                AddData_面罩内压力(i);
            }*/
               

        }

        private void groupBox_报警器曲线_Paint(object sender, PaintEventArgs e)
        {
           
          
        }
/*********************************************************************************************************************
  * 呼吸器测试翻页 表头 向下位机发送0x65以提示下位机翻页
  *  
  * 
 **********************************************************************************************************************/

       private void tabControl_整体气密测试_SelectedIndexChanged(object sender,EventArgs e)
       {

                if (this.tabControl_整体气密测试.SelectedIndex != this.pTabControlSelectedIndex)
                {
                    if (changeTabMessage() == true)
                    {
                        if (this.tabControl_整体气密测试.SelectedIndex.Equals(4))
                        {
                            播放视频.Ctlcontrols.play();
                        }
                        else
                        {
                            播放视频.Ctlcontrols.pause();
                        }
                        this.pTabControlSelectedIndex = this.tabControl_整体气密测试.SelectedIndex;
                    }
                    else
                    {
                        this.tabControl_整体气密测试.SelectedIndex = this.pTabControlSelectedIndex;
                    }
                }

        }


       private bool changeTabMessage()
       {

            try
            {
                if (isWorking.Equals(true))
                {
                    if (MessageBox.Show("测试未完成，离开当前界面会导致测试中断！", "提示测试中断", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        setBreakFlag();

                        isWorking = false;

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                return true;
            }

        
            
       }
       
        private void setBreakFlag()   //延时停止状态机
        {
            send(0x65);      //发送给下位机翻页信号                                    
            System.Timers.Timer t = new System.Timers.Timer(); //延时停止状态机，给下位机时间
            t.Interval = 100;
            t.AutoReset = false;
            t.Elapsed += new System.Timers.ElapsedEventHandler(sysTimerProcess);
            t.Start();
            StateMachineBreak = true;

        }
        private void sysTimerProcess(object sender, EventArgs e)//转换页面时所有页面和标志位全部重置
        {
            button_面罩泄露重置_Click(null, null);
            button_开启静压测试重置_Click(null,null);
            button_整机气密测试重置_Click(null,null);
            button_压力表校验开始测试重置_Click(null,null);
            button_报警器测试重置_Click(null,null);
            button_动态呼吸阻力测试重置_Click(null,null);

            测试时间 = 0;
            测试时间_num = 0;

            面罩内压力_flag = 0;
            总管压力_flag = 0;

             send(0x55);    //停止电机动作 

            StateMachineBreak = false;

        }


        private void button_呼吸器外观检查_Click(object sender, EventArgs e)
        {
            this.tabControl_整体气密测试.SelectedTab = this.tabPage_呼吸器外观检查;
        }

        private void button_面罩泄漏测试_Click(object sender, EventArgs e)
        {
            this.tabControl_整体气密测试.SelectedTab = this.tabPage_面罩泄露测试;
        }

        private void button_开启静压测试_Click(object sender, EventArgs e)
        {
            this.tabControl_整体气密测试.SelectedTab = this.tabPage_开启静压测试;
        }

        private void button_整机气密测试_Click(object sender, EventArgs e)
        {
            this.tabControl_整体气密测试.SelectedTab = this.tabPage_整机气密测试;
        }

        private void button_压力表校验_Click(object sender, EventArgs e)
        { 
            this.tabControl_整体气密测试.SelectedTab = this.tabPage_压力表校验;
        }

        private void button_报警器测试_Click(object sender, EventArgs e)
        {
            this.tabControl_整体气密测试.SelectedTab = this.tabPage_报警器测试;
        }

        private void button_动态呼吸阻力测试_Click(object sender, EventArgs e)
        {
            this.tabControl_整体气密测试.SelectedTab = this.tabPage_动态呼吸阻力测试;
        }

    
/*********************************************************************************************************************
 * 呼吸器测试 确定 将参数写入printf[] 数组。
 * 
 **********************************************************************************************************************/
        private void button_面罩泄露测试确定_Click(object sender, EventArgs e)
        {
             printf[16] = 呼气阀开启压力_合格;

             if (呼气阀开启压力_合格 == "未检测")
                printf[29] = "";
             else
                printf[29] = 呼气阀开启压力.ToString();

             printf[17] = 面罩泄露压力_合格;

             if (面罩泄露压力_合格 == "未检测")
                 printf[30] = "";
             else
                 printf[30] = 面罩泄露压力.ToString();

            面罩泄漏测试 = true;
            this.tabControl_整体气密测试.SelectedTab = this.tabPage_开启静压测试;
            this.button_面罩泄漏测试.BackColor = Color.Blue;
        }

        private void button_开启静压测试确定_Click(object sender, EventArgs e)
        {

            printf[18] = 供气阀开启压力_合格;
            if (供气阀开启压力_合格 == "未检测")
                printf[31] = "";
            else
                printf[31] = 供气阀开启压力.ToString();

            printf[19] = 静压值_合格;
            if (静压值_合格 == "未检测")
                printf[32] = "";
            else
              printf[32] = 静压值.ToString();

            开启静压测试 = true;
            this.tabControl_整体气密测试.SelectedTab = this.tabPage_整机气密测试;
            this.button_开启静压测试.BackColor = Color.Blue;
        }

        private void button_整体气密性测试确定_Click(object sender, EventArgs e)
        {


            printf[20] = 总管压降_合格;
            if (总管压降_合格 == "未检测")
                printf[33] = "";
            else
                printf[33] = 总管压降.ToString();

            整机气密测试 = true;
            this.tabControl_整体气密测试.SelectedTab = this.tabPage_压力表校验;
            this.button_整机气密测试.BackColor = Color.Blue;
        }

        private void button_压力表校验确定_Click(object sender, EventArgs e)
        {

            printf[24] = 压力表偏差值_合格;
            if (压力表偏差值_合格 == "未检测")
                printf[37] = "";
            else
                printf[37] = 压力表偏差值.ToString();

            压力表校验 = true;
            this.tabControl_整体气密测试.SelectedTab = this.tabPage_报警器测试;
            this.button_压力表校验.BackColor = Color.Blue;
        }

        private void button_报警器测试确定_Click(object sender, EventArgs e)
        {
          
            label_警报器平均耗气量.Text=耗气量测试.Mpa.ToString();

            平均耗气量 = 耗气量测试.Mpa;
            if (平均耗气量 < 平均耗气量_标准)
                平均耗气量_合格 = "合格";
            else
                平均耗气量_合格 = "不合格";

            printf[21] = 启报压力值_合格;
            if (启报压力值_合格 == "未检测")
                printf[34] = "";
            else
                printf[34] = 启报压力值.ToString();

            printf[22] = 平均报警声强_合格;
            if (平均报警声强_合格 == "未检测")
                printf[35] = "";
            else
                printf[35] = 平均报警声强.ToString();

            printf[23] = 平均耗气量_合格;
            if (平均耗气量_合格 == "未检测")
                printf[36] = "";
            else
                printf[36] = 平均耗气量.ToString();

            报警器测试 = true;
            this.tabControl_整体气密测试.SelectedTab = this.tabPage_动态呼吸阻力测试;
            this.button_报警器测试.BackColor = Color.Blue;
        }

        private void button_动态呼吸阻力测试确定_Click(object sender, EventArgs e)
        {
          
            printf[25] = 吸气阻力1_合格;
            if (吸气阻力1_合格 == "未检测")
                printf[38] = "";
            else
                printf[38] = 吸气阻力1.ToString();

            printf[26] = 呼气阻力1_合格;
            if (呼气阻力1_合格 == "未检测")
                printf[39] = "";
            else
                printf[39] = 呼气阻力1.ToString();

            printf[27] = 吸气阻力2_合格;
            if (吸气阻力2_合格 == "未检测")
                printf[40] = "";
            else
                printf[40] = 吸气阻力2.ToString();

            printf[28] = 呼气阻力2_合格;
            if (呼气阻力2_合格 == "未检测")
                printf[41] = "";
            else
                printf[41] = 呼气阻力2.ToString();

            动态呼吸阻力测试 = true;
            this.button_动态呼吸阻力测试.BackColor = Color.Blue;

            if (呼吸器外观检查 == true && 面罩泄漏测试 == true && 开启静压测试 == true && 整机气密测试 == true && 压力表校验 == true && 报警器测试 == true && 动态呼吸阻力测试 == true)
            {
              MessageBox.Show("全部测试完成，是否打印", "提示");
              this.Close();
            this.printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custum", 827, 1169);  //英寸
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ClientSize = new Size(827, 1169);  //设置预览窗体大小
            printPreviewDialog1.PrintPreviewControl.Zoom = 1.0;   //设置预览时的比例
            printPreviewDialog1.Document = this.printDocument1;
            printPreviewDialog1.ShowDialog();
            }
           

           
        }


  /*********************************************************************************************************************
  * 画压力表 选择量程
  * 
  **********************************************************************************************************************/
       
        private void groupBox_压力表_Paint(object sender, PaintEventArgs e)
        {
            Paint_压力表 压力表 = new Paint_压力表();
            压力表.压力 = 压力;
            压力表.Paint(e.Graphics, 60);
            label_Mpa.Text = 压力表.压力.ToString() +"Mpa";

        }   
        private void button_30Mpa_Click(object sender, EventArgs e)
        {
            Mpa = 25;
            压力 = 0;
            textBox_校验压力值.Text = "25";
            压力表校验_123 = 1;
            groupBox_压力表.Invalidate(); //更新显示  
            
        }

        private void button_20Mpa_Click(object sender, EventArgs e)
        {
            Mpa = 20;
            压力 = 0;
            textBox_校验压力值.Text = "20";
            压力表校验_123 = 2;
            groupBox_压力表.Invalidate(); //更新显示 
           
        }

        private void button_10Mpa_Click(object sender, EventArgs e)
        {
            Mpa = 10;
            压力 = 0;
            textBox_校验压力值.Text = "10";
            压力表校验_123 = 3;
            groupBox_压力表.Invalidate(); //更新显示 
           
        }
 /*********************************************************************************************************************
  * 呼吸器外观检查 确定
  * 
  **********************************************************************************************************************/    
        private void button_面罩确定_Click(object sender, EventArgs e)
        {
           
            this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_背板;
            if (面罩_1 == "通过" && 面罩_2 == "通过" && 面罩_3 == "通过" && 面罩_4 == "通过")
            {
                面罩 = "通过";
            }
            else
            {
                面罩 = "不通过";
            }
            printf[8] = 面罩;
        }

        private void button_背板确定_Click(object sender, EventArgs e)
        {
            
            this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_着装带;
            if (背板_1 == "通过" && 背板_2 == "通过")
            {
                背板 = "通过";
            }
            else
            {
                背板 = "不通过";
            }
            printf[9] = 背板;
        }

        private void button_着装带确定_Click(object sender, EventArgs e)
        {
           
            this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_导气管和接头;
            if (着装带_1 == "通过" && 着装带_2 == "通过")
            {
                着装带 = "通过";
            }
            else
            {
                着装带 = "不通过";
            }
            printf[10] = 着装带;
        }

        private void button_导气管和接头确定_Click(object sender, EventArgs e)
        {
            
            this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_供气阀减压器;
            if (导气管和接头_1 == "通过" && 导气管和接头_2 == "通过")
            {
                导气管和接头 = "通过";
            }
            else
            {
                导气管和接头 = "不通过";
            }
            printf[11] = 导气管和接头;
        }

        private void button_供气阀减压器确定_Click(object sender, EventArgs e)
        {
           
            this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_警报器;
            if (供气阀和减压器_1 == "通过" && 供气阀和减压器_2 == "通过")
            {
                供气阀和减压器 = "通过";
            }
            else
            {
                供气阀和减压器 = "不通过";
            }
            printf[12] = 供气阀和减压器;
        }

        private void button_警报器确定_Click(object sender, EventArgs e)
        {
            
            this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_压力表;
            if (警报器_1 == "通过")
            {
                警报器 = "通过";
            }
            else
            {
                警报器 = "不通过";
            }
            printf[13] = 警报器;
        }

        private void button_压力表确定_Click(object sender, EventArgs e)
        {
          
            this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_气瓶和气瓶阀;
            if (压力表_1 == "通过" && 压力表_2 == "通过" && 压力表_3 == "通过")
            {
                压力表 = "通过";
            }
            else
            {
                压力表 = "不通过";
            }
            printf[14] = 压力表;
        }

        private void button_气瓶和气阀确定_Click(object sender, EventArgs e)
        {
            呼吸器外观检查 = true;
            this.tabControl_整体气密测试.SelectedTab = this.tabPage_面罩泄露测试;
            this.button_呼吸器外观检查.BackColor = Color.Blue;
            this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_面罩;
            if (气瓶和气阀_1 == "通过")
            {
                气瓶和气阀 = "通过";
            }
            else
            {
                气瓶和气阀 = "不通过";
            }
            printf[15] = 气瓶和气阀;
        }
 /*********************************************************************************************************************
 * 返回 上一项 跳过 打印预览 打印
 * 
 **********************************************************************************************************************/
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            打印 print = new 打印();
            print.打印格式(e, printf, 42, DataList_面罩内压力);
        }
        private void button_查看报告_Click(object sender, EventArgs e)
        {
            this.printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custum", 827, 1169);  //英寸

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ClientSize = new Size(827, 1169);  //设置预览窗体大小
            printPreviewDialog1.PrintPreviewControl.Zoom = 1.0;   //设置预览时的比例
            printPreviewDialog1.Document = this.printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        /************************************
         * 退出界面时显示未完成的操作，但由于原作者设定的标志位并不是测试结束时置位，是测试开始时置位，不能有效反应未完成的成分，后期或许要修改
         **********************************/

        private void button_返回主页_Click(object sender, EventArgs e)
        {
            String s;
            int count = 0;

            if (呼吸器外观检查 == true && 面罩泄漏测试 == true && 开启静压测试 == true && 整机气密测试 == true && 压力表校验 == true && 报警器测试 == true && 动态呼吸阻力测试 == true)
            {
                s = "全部测试完成";
            }
            else
            {
                s = "部分测试未完成，未完成的测试有：\n";

                if(呼吸器外观检查 == false)
                {
                    count++;
                    s = s + "(" + count.ToString() + ")" + " 呼吸器外观检查\n";
                }
                if (面罩泄漏测试 == false)
                {
                    count++;
                    s = s + "(" + count.ToString() + ")" + " 面罩泄漏测试\n";
                }
                if (开启静压测试 == false)
                {
                    count++;
                    s = s + "(" + count.ToString() + ")" + " 开启静压测试\n";
                }
                if (整机气密测试 == false)
                {
                    count++;
                    s = s + "(" + count.ToString() + ")" + " 整机气密测试\n";
                }
                if (压力表校验 == false)
                {
                    count++;
                    s = s + "(" + count.ToString() + ")" + " 压力表校验\n";
                }
                if (报警器测试 == false)
                {
                    count++;
                    s = s + "(" + count.ToString() + ")" + " 报警器测试\n";
                }
                if (动态呼吸阻力测试 == false)
                {
                    count++;
                    s = s + "(" + count.ToString() + ")" + " 呼吸器外观检查\n";
                }

            }

            提示窗口 t = new 提示窗口(s);
            t.Show();


            if (PageList.pageList.Count != 0)
            {
                PageList.pageList.Remove(PageList.nowPageId);
                PageList.nowPageId--;
            }
            this.Close();
        }
        private void button_上一项_Click(object sender, EventArgs e)
        {
            switch (this.tabControl_整体气密测试.SelectedTab.Text)
            {

                case "呼吸器外观检查":
                    switch (this.tabControl_呼吸器外观检查.SelectedTab.Text)
                    {
                        case "面罩":    
                            break;
                        case "背板":
                            this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_面罩;
                            break;
                        case "着装带":
                            this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_背板;                         
                            break;
                        case "导气管和接头":
                            this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_着装带;                        
                            break;
                        case "供气阀、减压器":
                            this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_导气管和接头;                     
                            break;
                        case "警报器":
                            this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_供气阀减压器;                       
                            break;
                        case "压力表":
                            this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_警报器;
                            break;
                        case "气瓶和气瓶阀":
                             this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_压力表;
                            break;

                    }

                    break;
                case "面罩泄露测试":
                    this.tabControl_整体气密测试.SelectedTab = this.tabPage_呼吸器外观检查; 
                     this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_气瓶和气瓶阀;
                    break;
                case "开启/静压测试":
                    this.tabControl_整体气密测试.SelectedTab = this.tabPage_面罩泄露测试;                    
                    break;
                case "整机气密测试":
                    this.tabControl_整体气密测试.SelectedTab = this.tabPage_开启静压测试;
                    break;
                case "压力表校验":
                    this.tabControl_整体气密测试.SelectedTab = this.tabPage_整机气密测试;
                    break;
                case "报警器测试":
                    this.tabControl_整体气密测试.SelectedTab = this.tabPage_压力表校验;
                    break;
                case "动态呼吸阻力测试":
                    this.tabControl_整体气密测试.SelectedTab = this.tabPage_报警器测试;
                    break;


            }
        }

        private void button_跳过_Click(object sender, EventArgs e)
        {

             switch(this.tabControl_整体气密测试.SelectedTab.Text)
            {

                case "呼吸器外观检查": 
                     switch(this.tabControl_呼吸器外观检查.SelectedTab.Text)
                     {
                         case "面罩":
                             this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_背板;
                             break;
                         case "背板":
                             this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_着装带;
                             break;
                         case "着装带":
                             this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_导气管和接头;
                             break;
                         case "导气管和接头":
                             this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_供气阀减压器;
                             break;
                         case "供气阀、减压器":
                             this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_警报器;
                             break;
                         case "警报器":
                             this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_压力表;
                             break;
                         case "压力表":
                             this.tabControl_呼吸器外观检查.SelectedTab = this.tabPage_气瓶和气瓶阀;
                             break;
                         case "气瓶和气瓶阀": 
                             this.tabControl_整体气密测试.SelectedTab = this.tabPage_面罩泄露测试;
                             break;
                        
                     }
                        
                    break;
                case "面罩泄露测试":
                    this.tabControl_整体气密测试.SelectedTab = this.tabPage_开启静压测试;
                    break;
                case "开启/静压测试":
                    this.tabControl_整体气密测试.SelectedTab = this.tabPage_整机气密测试;                        
                    break;
                case "整机气密测试":
                    this.tabControl_整体气密测试.SelectedTab = this.tabPage_压力表校验;
                    break;
                case "压力表校验":
                    this.tabControl_整体气密测试.SelectedTab = this.tabPage_报警器测试;
                    break;
                case "报警器测试":
                    this.tabControl_整体气密测试.SelectedTab = this.tabPage_动态呼吸阻力测试;
                    break;


            }
          
        }

        private void button_打印_Click(object sender, EventArgs e)
        {
            测试记录_add();
            this.Close();
        }
  /*********************************************************************************************************************
  * 呼吸器外观检查 单项选择
  * 
  **********************************************************************************************************************/
        private void radioButton_面罩1通过_CheckedChanged(object sender, EventArgs e)
        {
             面罩_1 = "通过";
        }

        private void radioButton_面罩1不通过_CheckedChanged(object sender, EventArgs e)
        {
            面罩_1 = "不通过";
        }

        private void radioButton_面罩1待维修_CheckedChanged(object sender, EventArgs e)
        {
            面罩_1 = "待维修";
        }

        private void radioButton_面罩1报废_CheckedChanged(object sender, EventArgs e)
        {
            面罩_1 = "报废";
        }

        private void radioButton_面罩2通过_CheckedChanged(object sender, EventArgs e)
        {
            面罩_2 = "通过";
        }

        private void radioButton_面罩2不通过_CheckedChanged(object sender, EventArgs e)
        {
            面罩_2 = "不通过";
        }

        private void radioButton_面罩2待维修_CheckedChanged(object sender, EventArgs e)
        {
            面罩_2 = "待维修";
        }

        private void radioButton_面罩2报废_CheckedChanged(object sender, EventArgs e)
        {
            面罩_2 = "报废";
        }

        private void radioButton_面罩3通过_CheckedChanged(object sender, EventArgs e)
        {
            面罩_3 = "通过";
        }

        private void radioButton_面罩3不通过_CheckedChanged(object sender, EventArgs e)
        {
            面罩_3 = "不通过";
        }

        private void radioButton_面罩3待维修_CheckedChanged(object sender, EventArgs e)
        {
            面罩_3 = "待维修";
        }

        private void radioButton_面罩3报废_CheckedChanged(object sender, EventArgs e)
        {
            面罩_3 = "报废";
        }

        private void radioButton_面罩4通过_CheckedChanged(object sender, EventArgs e)
        {
            面罩_4 = "通过";
        }

        private void radioButton_面罩4不通过_CheckedChanged(object sender, EventArgs e)
        {
            面罩_4 = "不通过";
        }

        private void radioButton_面罩4待维修_CheckedChanged(object sender, EventArgs e)
        {
            面罩_4 = "待维修";
        }

        private void radioButton_面罩4报废_CheckedChanged(object sender, EventArgs e)
        {
            面罩_4 = "报废";
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void radioButton_背板1通过_CheckedChanged(object sender, EventArgs e)
        {
            背板_1 = "通过";
        }

        private void radioButton_背板1不通过_CheckedChanged(object sender, EventArgs e)
        {
            背板_1 = "不通过";
        }

        private void radioButton_背板1待维修_CheckedChanged(object sender, EventArgs e)
        {
            背板_1 = "待维修";
        }

        private void radioButton_背板1报废_CheckedChanged(object sender, EventArgs e)
        {
            背板_1 = "报废";
        }
   
        private void radioButton_背板2通过_CheckedChanged(object sender, EventArgs e)
        {
            背板_2 = "通过"; 
        }

        private void radioButton_背板2不通过_CheckedChanged(object sender, EventArgs e)
        {
            背板_2 = "不通过"; 
        }

        private void radioButton_背板2待维修_CheckedChanged(object sender, EventArgs e)
        {
            背板_2 = "待维修"; 
        }
        private void radioButton_背板2报废_CheckedChanged(object sender, EventArgs e)
        {
            背板_2 = "报废"; 
        }
      
 ////////////////////////////////////////////////////////////////////////////////////////////    
        private void radioButton_着装带1通过_CheckedChanged(object sender, EventArgs e)
        {
            着装带_1 = "通过";
        }
        private void radioButton_着装带1不通过_CheckedChanged(object sender, EventArgs e)
        {
            着装带_1 = "不通过";
        }

        private void radioButton_着装带1待维修_CheckedChanged(object sender, EventArgs e)
        {
            着装带_1 = "待维修";
        }

        private void radioButton_着装带1报废_CheckedChanged(object sender, EventArgs e)
        {
            着装带_1 = "报废";
        }

        private void radioButton_着装带2通过_CheckedChanged(object sender, EventArgs e)
        {
            着装带_2 = "通过";
        }

        private void radioButton_着装带2不通过_CheckedChanged(object sender, EventArgs e)
        {
            着装带_2 = "不通过";
        }

        private void radioButton_着装带2待维修_CheckedChanged(object sender, EventArgs e)
        {
            着装带_2 = "待维修";
        }
        private void radioButton_着装带2报废_CheckedChanged(object sender, EventArgs e)
        {
            着装带_2 = "报废";
        }
   
///////////////////////////////////////////////////////////////////////////////
      
        private void radioButton_导气管和接头1通过_CheckedChanged(object sender, EventArgs e)
        {
            导气管和接头_1 = "通过";
        }
        private void radioButton_导气管和接头1不通过_CheckedChanged(object sender, EventArgs e)
        {
            导气管和接头_1 = "不通过";
        }
        private void radioButton_导气管和接头1待维修_CheckedChanged(object sender, EventArgs e)
        {
            导气管和接头_1 = "待维修";
        }

        private void radioButton_导气管和接头1报废_CheckedChanged(object sender, EventArgs e)
        {
            导气管和接头_1 = "报废";
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////// 
        private void radioButton_导气管和接头2通过_CheckedChanged(object sender, EventArgs e)
        {
            导气管和接头_2 = "通过";
        }
        private void radioButton_导气管和接头2不通过_CheckedChanged(object sender, EventArgs e)
        {
            导气管和接头_2 = "不通过";
        }
        private void radioButton_导气管和接头2待维修_CheckedChanged(object sender, EventArgs e)
        {
            导气管和接头_2 = "待维修";
        }
      
        private void radioButton_导气管和接头2报废_CheckedChanged(object sender, EventArgs e)
        {
            导气管和接头_2 = "报废";
        }
 ///////////////////////////////////////////////////////////////////////////////////////////////////
      
        private void radioButton_供气阀减压器1通过_CheckedChanged(object sender, EventArgs e)
        {
            供气阀和减压器_1 = "通过";
        }
        private void radioButton_供气阀减压器1不通过_CheckedChanged(object sender, EventArgs e)
        {
            供气阀和减压器_1 = "不通过";
        }
        private void radioButton_供气阀减压器1待维修_CheckedChanged(object sender, EventArgs e)
        {
            供气阀和减压器_1 = "待维修";
        }
        private void radioButton_供气阀减压器1报废_CheckedChanged(object sender, EventArgs e)
        {
             供气阀和减压器_1 = "报废";
        }
        private void radioButton_供气阀减压器2通过_CheckedChanged(object sender, EventArgs e)
        {
             供气阀和减压器_2 = "通过";
        }
        private void radioButton_供气阀减压器2不通过_CheckedChanged(object sender, EventArgs e)
        {
            供气阀和减压器_2 = "不通过";
        }
        private void radioButton_供气阀减压器2待维修_CheckedChanged(object sender, EventArgs e)
        {
            供气阀和减压器_2 = "待维修";
        }
        private void radioButton_供气阀减压器2报废_CheckedChanged(object sender, EventArgs e)
        {
            供气阀和减压器_2 = "报废";
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void radioButton_警报器1通过_CheckedChanged(object sender, EventArgs e)
        {
            警报器_1 = "通过";
        }

        private void radioButton_警报器1不通过_CheckedChanged(object sender, EventArgs e)
        {
            警报器_1 = "不通过";
        }

        private void radioButton_警报器1待维修_CheckedChanged(object sender, EventArgs e)
        {
            警报器_1 = "待维修";
        }

        private void radioButton_警报器1报废_CheckedChanged(object sender, EventArgs e)
        {
            警报器_1 = "报废";
        }

       
        private void radioButton_压力表1通过_CheckedChanged(object sender, EventArgs e)
        {
            压力表_1 = "通过";
        }
        private void radioButton_压力表1不通过_CheckedChanged(object sender, EventArgs e)
        {
            压力表_1 = "不通过";
        }

        private void radioButton_压力表1待维修_CheckedChanged(object sender, EventArgs e)
        {
            压力表_1 = "待维修";
        }

        private void radioButton_压力表1报废_CheckedChanged(object sender, EventArgs e)
        {
            压力表_1 = "报废";
        }

        private void radioButton_压力表2通过_CheckedChanged(object sender, EventArgs e)
        {
            压力表_2 = "通过";
        }

        private void radioButton_压力表2不通过_CheckedChanged(object sender, EventArgs e)
        {
            压力表_2 = "不通过";
        }

        private void radioButton_压力表2待维修_CheckedChanged(object sender, EventArgs e)
        {
            压力表_2 = "待维修";
        }

        private void radioButton_压力表2报废_CheckedChanged(object sender, EventArgs e)
        {
            压力表_2 = "报废";
        }

        private void radioButton_压力表3通过_CheckedChanged(object sender, EventArgs e)
        {
            压力表_3 = "通过";
        }

        private void radioButton_压力表3不通过_CheckedChanged(object sender, EventArgs e)
        {
            压力表_3 = "不通过";
        }

        private void radioButton_压力表3待维修_CheckedChanged(object sender, EventArgs e)
        {
            压力表_3 = "待维修";
        }
        private void radioButton_压力表3报废_CheckedChanged(object sender, EventArgs e)
        {
            压力表_3 = "报废";
        }

        private void radioButton_气瓶和气瓶阀1通过_CheckedChanged(object sender, EventArgs e)
        {
            气瓶和气阀_1 = "通过";
        }

        private void radioButton_气瓶和气瓶阀1不通过_CheckedChanged(object sender, EventArgs e)
        {
            气瓶和气阀_1 = "不通过";
        }

        private void radioButton_气瓶和气瓶阀1待维修_CheckedChanged(object sender, EventArgs e)
        {
            气瓶和气阀_1 = "待维修";
        }

        private void radioButton_气瓶和气瓶阀1报废_CheckedChanged(object sender, EventArgs e)
        {
            气瓶和气阀_1 = "报废";
        }
 
/*********************************************************************************************************************
 * 面罩泄露测试 测试操作
 * 
 **********************************************************************************************************************/
        private void button_面罩泄露测试设置1_Click(object sender, EventArgs e)
        {
               send(0x31); //人工肺运动到底部

              isWorking = true;
        }

        private void button_面罩泄露测试设置2_Click(object sender, EventArgs e)
        {
              面罩内压力_flag = 1; //人工肺向上运动，并且向上位机发送面罩内压力
               send(0x32);
           
        }
        private void button_面罩泄露测试时间加_Click(object sender, EventArgs e)
        {

            time_面罩泄露测试时间 = int.Parse(textBox_测试时间.Text);
            time_面罩泄露测试时间++;
            textBox_测试时间.Text = time_面罩泄露测试时间.ToString();
        }
        private void button_面罩泄露测试时间减_Click(object sender, EventArgs e)
        {

            time_面罩泄露测试时间 = int.Parse(textBox_测试时间.Text);
            time_面罩泄露测试时间--;
            textBox_测试时间.Text = time_面罩泄露测试时间.ToString();  
        }
        private void button_面罩泄露重置_Click(object sender, EventArgs e)
        {
             呼气阀开启压力 = 0;
             面罩泄露压力 = 0;
             呼气阀开启压力_合格 = "未检测";
             面罩泄露压力_合格 = "未检测";
             textBox_呼气阀开启压力.Text = "";
             textBox_即时压力.Text = "";
             textBox_测试时间.Text = "5";
             textBox_面罩泄漏压力值.Text = "";


            面罩内压力_flag = 0;

            isWorking = false;
        }
        /*********************************************************************************************************************
         * 开启静压测试 测试操作
         * 
         **********************************************************************************************************************/
        private void button_开启静压测试确认_Click(object sender, EventArgs e)
        {
            button_开启静压测试设置1.Enabled = true;
            button_开启静压测试设置2.Enabled = true;

            isWorking = true;
        }

        private void button_开启静压测试设置1_Click(object sender, EventArgs e)
        {
            总管压力_flag = 1;
            面罩内压力_flag = 9;
            send(0x36);
        }

        private void button_开启静压测试设置2_Click(object sender, EventArgs e)
        {
            面罩内压力_flag = 4;

            send(0x37);

        }

        private void button_开启静压测试重置_Click(object sender, EventArgs e)
        {
             供气阀开启压力 = 0;
             静压值 = 0;
             供气阀开启压力_合格 = "未检测";
             静压值_合格 = "未检测";
            textBox_总管压力.Text="";
            textBox_面罩内压力.Text="";
            textBox_供气阀开启压力测试.Text="";
            textBox_静态压力测试.Text="";
            textBox_呼气阀开启压力测.Text="";
            textBox_静态压力测试时间.Text="5";
            textBox_测试结果.Text = "";

            面罩内压力_flag = 0;

            button_开启静压测试设置1.Enabled = false;
            button_开启静压测试设置2.Enabled = false;

            呼吸器测试串口全局.开启静压测试停止 = false;
            timerWorkingFlag = false;

            isWorking = false;
            isTimeCounting = false;
        }
        private void button_静态压力测试时间加_Click(object sender, EventArgs e)
        {
            time_静态压力测试时间 = int.Parse(textBox_静态压力测试时间.Text);
            time_静态压力测试时间++;
            textBox_静态压力测试时间.Text = time_静态压力测试时间.ToString();
        }
        private void button_静态压力测试时间减_Click(object sender, EventArgs e)
        {
            time_静态压力测试时间 = int.Parse(textBox_静态压力测试时间.Text);
            time_静态压力测试时间--;
            textBox_静态压力测试时间.Text = time_静态压力测试时间.ToString();
        }
        /*********************************************************************************************************************
         * 整机气密性测试 测试操作
         * 
         **********************************************************************************************************************/
        private void button_整机气密测试设置1_Click(object sender, EventArgs e)
        {
            总管压力_flag = 2;
            send(0x3C);
            label_总管初始压力提示.Visible = true;

            isWorking = true;

        }

        private void button整机气密测试设置2_Click(object sender, EventArgs e)
        {
            总管压力_flag = 11;
            测试时间 = 4;
            测试时间_num4 = int.Parse(textBox_整机气密测试时间.Text);
        }

        private void button_整机气密测试重置_Click(object sender, EventArgs e)
        {
             总管压降 = 0;
             总管压降_合格 = "未检测";
            textBox_总管初始压力.Text="";
            textBox_整机气密测试即时压力.Text = "";
            textBox_整机气密测试时间.Text = "10";
            textBox_整机气密性测试.Text = "";

            总管压力_flag = 0;

            isWorking = false;
            isTimeCounting = false;
        }

        private void button_整机气密测试时间加_Click(object sender, EventArgs e)
        { 
            time_整机气密测试时间 = int.Parse(textBox_整机气密测试时间.Text);
            time_整机气密测试时间++;
            textBox_整机气密测试时间.Text = time_整机气密测试时间.ToString();
        }

        private void button_整机气密测试时间减_Click(object sender, EventArgs e)
        {
            time_整机气密测试时间 = int.Parse(textBox_整机气密测试时间.Text);
            time_整机气密测试时间--;
            textBox_整机气密测试时间.Text = time_整机气密测试时间.ToString();
        }


        /*********************************************************************************************************************
         * 压力表校验测试 测试操作
         * 
         **********************************************************************************************************************/
        private void button_压力表校验开始测试设置1_Click(object sender, EventArgs e)
        {

            总管压力_flag = 12; 
            send(0x56);

            isWorking = true;

        }

        private void button_压力表校验开始测试设置2_Click(object sender, EventArgs e)
        {
            总管压力_flag = 3;
        }

      
        private void button_压力表校验开始测试设置3_Click(object sender, EventArgs e)
        {
            switch (压力表校验_123)
            {
                case 1:
                    压力表校验_num++;
                    压力表校验_值[0] = Convert.ToSingle(textBox_测压表压力.Text) / 传感器校验压力;
                    if (Convert.ToSingle(textBox_测压表压力.Text) < 传感器校验压力 * (1.0025) && Convert.ToSingle(textBox_测压表压力.Text) > 传感器校验压力 * (0.9975))            
                        压力表校验_1 = true;                   
                    else                  
                        压力表校验_1 = false;                   
                    break;
                case 2:
                    压力表校验_num++;
                    压力表校验_值[1] = Convert.ToSingle(textBox_测压表压力.Text) / 传感器校验压力;
                    if (Convert.ToSingle(textBox_测压表压力.Text) < 传感器校验压力 * (1.0025) && Convert.ToSingle(textBox_测压表压力.Text) > 传感器校验压力 * (0.9975))
                        压力表校验_2 = true;
                    else
                        压力表校验_2 = false; 
                    break;
                case 3:
                    压力表校验_num++;
                    压力表校验_值[2] = Convert.ToSingle(textBox_测压表压力.Text) / 传感器校验压力;
                    if (Convert.ToSingle(textBox_测压表压力.Text) < 传感器校验压力 * (1.0025) && Convert.ToSingle(textBox_测压表压力.Text) > 传感器校验压力 * (0.9975))
                        压力表校验_3 = true;
                    else
                        压力表校验_3 = false; 
                    break;
            }
            if (压力表校验_num == 3)
            {
                总管压力_flag = 0;
                if (压力表校验_1 == true && 压力表校验_2 == true && 压力表校验_3 == true)
                     压力表偏差值_合格 = "合格";
                else
                     压力表偏差值_合格 = "不合格";

                压力表偏差值 = (压力表校验_值[0] + 压力表校验_值[1] + 压力表校验_值[2]) / 3; //平均偏差 

                textBox_压力表校验测试结果.Text = 压力表偏差值_合格;

                压力表校验_num = 0;//清零静压测试状态机

                isWorking = false;


            }
            else
            {
                总管压力_flag = 3;
                send(0x56);
            }
           
        }

        private void button_压力表校验开始测试重置_Click(object sender, EventArgs e)
        {
              压力表偏差值 = 0;
              压力表偏差值_合格 = "未检测";
               textBox_校验压力值.Text="";
                textBox_传感器压力.Text="";
                textBox_测压表压力.Text="";
                textBox_压力表校验测试结果.Text = "";
                Mpa = 20;

            压力表校验_num = 0;//清零静压测试状态机

            总管压力_flag = 0;

            isWorking = false;
            isTimeCounting = false;
        }
        /*********************************************************************************************************************
         * 报警器测试 测试操作
         * 
         **********************************************************************************************************************/
        private void button_报警器测试设置1_Click(object sender, EventArgs e)
        {

            总管压力_flag = 4;    // 报警器性能测试，判断总管压力是否大于8Mpa
            send(0x3E);  //下位机发送总管压力

            isWorking = true;

        }

        private void button_报警器测试设置2_Click(object sender, EventArgs e)
        {
            总管压力_flag = 5;   // 报警器性能测试 关闭充气阀后开始测试  
            label_开始测试提示.Enabled = true;
            label_开始测试提示.Text = "打开供气阀上的泄压阀缓慢泄压";
            send(0x3F);
        }

        private void button_报警器测试设置3_Click(object sender, EventArgs e)
        {
            
        }

        private void button_报警器测试设置4_Click(object sender, EventArgs e)  //是否进行耗气量测试 是
        {
            耗气量测试设置 a = new 耗气量测试设置();
            a.Show();
            PageList.nowPageId++;
            PageList.pageList.Add(a);

            总管压力_flag = 7;
            send(0x51);  //进行耗气量测试
        }

        private void button_报警器测试设置5_Click(object sender, EventArgs e)
        {
            总管压力_flag = 5;//不进行耗气量测试
            报警器声强_flag = 0;//flag清零
             send(0x52); //

            DataList_声强 = new List<int>();
            DataList_DrawStep= new List<int>();

            isWorking = true;

          //  label_开始测试提示.Enabled = true;   //测试问题所在
          // label_开始测试提示.Text = "打开供气阀上的泄压阀缓慢泄压";
          // send(0x3F);
        }
       
        private void button_报警器测试保存文件_Click(object sender, EventArgs e)
        {

            txt_name_报警器_步长 = path + "\\" + "报警器\\" + "\\" + now_time + "步长" + ".txt";
            txt_name_报警器_声强 = path + "\\" + "报警器\\" + "\\" + now_time + "声强" + ".txt";
            new_txt(txt_name_报警器_步长);
            new_txt(txt_name_报警器_声强);
            添加_txt(DataList_DrawStep, txt_name_报警器_步长);  //向txt写入一个数据
            添加_txt(DataList_声强, txt_name_报警器_声强);  //向txt写入一个数据
        }

        private void button_报警器测试重置_Click(object sender, EventArgs e)
        {
             启报压力值 = 0;
             平均报警声强 = 0;
             平均耗气量 = 0;
             启报压力值_合格 = "未检测";
             平均报警声强_合格 = "未检测";
             平均耗气量_合格 = "未检测";
             textBox_总管即时压力.Text = "";
             label_开始测试提示.Enabled=false;
             button_报警器测试设置2.Enabled = false;

            总管压力_old = 8;

            DataList_声强 = new List<int>();
            DataList_DrawStep = new List<int>();
            panel_报警器曲线测试.Invalidate();


            isWorking = false;
            isTimeCounting = false;
        }
        /*********************************************************************************************************************
         * 动态呼吸阻力测试 测试操作
         * 
         **********************************************************************************************************************/
        private void button_动态呼吸阻力测试设置1_Click(object sender, EventArgs e)
        {
            总管压力_flag = 8;
           
            send(0x58);

            isWorking = true;
      
        }

        private void button_动态呼吸阻力测试设置2_Click(object sender, EventArgs e)
        {
           
        }
       
        private void button_动态呼吸阻力测试保存文件_Click(object sender, EventArgs e)
        {
                                                                //存储报警器数据
            txt_name_动态呼吸阻力_面罩内压力 = path + "\\" + "动态呼吸阻力\\" + "\\" + now_time + "面罩内压力" + ".txt";
           //txt_name_动态呼吸阻力_总管压力 = path + "\\" + "动态呼吸阻力\\" + "\\" + now_time + "总管压力" + ".txt";
            new_txt(txt_name_动态呼吸阻力_面罩内压力);
           // new_txt(txt_name_动态呼吸阻力_总管压力);
            添加_txt(DataList_面罩内压力, txt_name_动态呼吸阻力_面罩内压力);  //向txt写入一个数据
        }

        private void button_动态呼吸阻力测试重置_Click(object sender, EventArgs e)
        {
             吸气阻力1 = 0;
             呼气阻力1 = 0;
             吸气阻力2 = 0;
             呼气阻力2 = 0;
             吸气阻力1_合格 = "未检测";
             呼气阻力1_合格 = "未检测";
             吸气阻力2_合格 = "未检测";
             呼气阻力2_合格 = "未检测";
            textBox_呼吸阻力测试总管即时压力.Text="";
            textBox_呼吸阻力测试时间.Text = "30";

            // DataList_面罩内压力= new List<int>();
            // DataList_总管压力= new List<float>();
            // panel_动态呼吸阻力测试.Invalidate();

            DataList_面罩内压力.Clear();
            DataList_总管压力.Clear();
            panel_动态呼吸阻力测试.Invalidate();

            测试时间_num = 0;//清零
            测试时间 = 0;
            面罩内压力_flag = 0;
            总管压力_flag = 0;

            isWorking = false;
            isTimeCounting = false;
        }
        private void button_呼吸阻力测试时间加_Click(object sender, EventArgs e)
        {
            time_呼吸阻力测试时间 = int.Parse(textBox_呼吸阻力测试时间.Text);
            time_呼吸阻力测试时间++;
            textBox_呼吸阻力测试时间.Text = time_呼吸阻力测试时间.ToString();
        }

        private void button_button_呼吸阻力测试时间减_Click(object sender, EventArgs e)
        {
            time_呼吸阻力测试时间 = int.Parse(textBox_呼吸阻力测试时间.Text);
            time_呼吸阻力测试时间--;
            textBox_呼吸阻力测试时间.Text = time_呼吸阻力测试时间.ToString();
        }
 /*********************************************************************************************************************
  * 呼吸器测试 串口数据处理 变量
  * 
 **********************************************************************************************************************/
        float 呼气阀开启压力_标准=700F;      //= 700; 面罩
        float 面罩泄露开始压力_标准=-250F;  //= -250;
        float 供气阀开启压力_标准=-1000F;       //= -1000;
        float 面罩内静压_上限=500F;          //= 500;
        float 面罩内静压_下限=150F;         //= 150;
        float 面罩泄露压力_合格标准 = 125F;

        float 总管压降_标准=2F;              //= 2000;
        float 启报压力值_声强标准=0.09F;     //= 90;
        float 启报压力值_下限=5F;            //= 5000;
        float 启报压力值_上限 = 6F;          //= 6000;
        float 警报器总管压力=1F;            //=1000
        float 平均报警声强_标准 = 90F;      //=90DB
        float 平均耗气量_标准 = 1F;        //1000

        float 呼气阀开启压力 = 0;
        float 面罩泄露压力 = 0;
        string 呼气阀开启压力_合格 = "未检测";
        string 面罩泄露压力_合格 = "未检测";    
   
        float 供气阀开启压力 = 0;
        float 静压值 = 0;
        string 供气阀开启压力_合格 = "未检测";
        string 静压值_合格 = "未检测";

        float 总管压降 = 0;
        string 总管压降_合格 = "未检测";

        float 启报压力值 = 0;
        float 平均报警声强 = 0;
        float 平均耗气量 = 0;
        string 启报压力值_合格 = "未检测";
        string 平均报警声强_合格 = "未检测";
        string 平均耗气量_合格 = "未检测";

        float 压力表偏差值 = 0;
        string 压力表偏差值_合格 = "未检测"; 

        float 吸气阻力1 = 1200;
        float 呼气阻力1 = -400;
        float 吸气阻力2 = 1200;
        float 呼气阻力2 = -400;
        string 吸气阻力1_合格 = "未检测";
        string 呼气阻力1_合格 = "未检测";
        string 吸气阻力2_合格 = "未检测";
        string 呼气阻力2_合格 = "未检测";

        float 压力值A = 0;
        float 压力值B = 0;
        float 整体气密性初始压力1 = 0;
        float 整体气密性初始压力2 = 0;
        float 面罩内压力 = 0;
        float 面罩内压力_max = 0;  //呼气阀开启压力
        float 面罩内压力_min = 1200;  //供气阀开启压力
        float 面罩内静压 = 0;
        float 声强 = 0;
        float 总管压力 = 0;
        float 总管压力_old = 8; 
        int 面罩内压力_flag = 0; //
        int 总管压力_flag = 0;
        int 报警器声强_flag = 0;
        int 呼气阀开启压力_num = 0;
        int 供气阀开启压力_num = 0;
        float 传感器校验压力 = 0;  //压力表校验
        int 压力表校验_123 = 0;   // 1 25Mpa  2 20Mpa  3 10Mpa
        bool 压力表校验_1 = false;
        bool 压力表校验_2 = false;
        bool 压力表校验_3 = false;
        int 测试时间_num = 0;
        int 测试时间_num1 = 0;
        int 测试时间_num2 = 0;
        int 测试时间_num3 = 0;
        int 测试时间_num4 = 0;
        int 测试时间_num5 = 0;
        int 测试时间_num6 = 0;
        int 测试时间_num7 = 0;
        /*********************************************************************************************************************
         * 定时器计时刷新事件
         * 1 面罩泄露 第一组计时 记录压力值A
         * 2 面罩泄露 第二组计时 记录压力值B
         * 3 开启静压 静态压力
         * 4 整机气密性 10s
         * 5 整机气密性 1分钟
         * 6 呼吸器阻力测试 等待5s
         * 7 呼吸器阻力测试 结束
         **********************************************************************************************************************/
        private void timer1_Tick(object sender, EventArgs e)  //
        {
            
            
            switch (测试时间)
            { 
                case 1:   //面罩泄露 第一组计时 记录压力值A
                     测试时间_num++;
                    if (测试时间_num == 测试时间_num1)
                    {
                        压力值A = Convert.ToSingle(textBox_串口数据面罩内压力.Text);
                        测试时间_num2 = 5;
                        测试时间 = 2;
                        测试时间_num = 0;
                    }                  
                    break;

                case 2:   //面罩泄露 第二组计时 记录压力值B
                    测试时间_num++;
                    if (测试时间_num == 测试时间_num2)
                    {
                        压力值B = Convert.ToSingle(textBox_串口数据面罩内压力.Text);
                        面罩泄露压力 = 压力值A - 压力值B;
                        textBox_面罩泄漏压力值.Text = 面罩泄露压力.ToString();
                        if (面罩泄露压力 < 面罩泄露压力_合格标准)
                            面罩泄露压力_合格 = "合格";
                        else
                            面罩泄露压力_合格 = "不合格";
                        send(0x35);  //计时结束
                        测试时间 = 0;
                        测试时间_num = 0;

                        isWorking = false;
                    }           
                    break;

               case 3:          //静态压力
                    测试时间_num++;
                    if (测试时间_num == 测试时间_num3)
                    {

                        isTimeCounting = false;
                        send(0x3B);  //计时结束
                        面罩内静压 = Convert.ToSingle(textBox_串口数据面罩内压力.Text);

                        textBox_静态压力测试.Text = 面罩内静压.ToString();
                        if (面罩内静压 > 面罩内静压_下限 && 面罩内静压 < 面罩内静压_上限)
                        {
                            textBox_测试结果.Text = "合格";
                            静压值_合格 = "合格";
                        }
                        else
                        {
                            textBox_测试结果.Text = "不合格";
                            静压值_合格 = "不合格";
                        }
                        textBox_测试结果.Text = 静压值_合格;
                        测试时间 = 0;
                        测试时间_num = 0;
                        呼吸器测试串口全局.开启静压测试停止 = true;

                        isWorking = false;
                    }                   
                    break;

               case 4:  //整机气密性  10s
                     测试时间_num++;
                    if (测试时间_num == 测试时间_num4)
                    {
                        整体气密性初始压力1 = Convert.ToSingle(textBox_串口数据总管压力.Text);
                        测试时间_num5 = 60;       //1分钟

                        if (isTimeCounting == false)
                        {

                            倒计时器 a = new 倒计时器("整体气密性测试等待60s", 测试时间_num5);
                            a.Show();
                            isTimeCounting = true;
                        }



                        测试时间 = 5;
                        测试时间_num = 0;
                    }                  
                    break;

               case 5:  //整机气密性  1分钟
                     测试时间_num++;
                     
                     if (测试时间_num == 测试时间_num5)
                     {
                         isTimeCounting = false;

                         整体气密性初始压力2 = Convert.ToSingle(textBox_串口数据总管压力.Text);
                         if ((整体气密性初始压力1 - 整体气密性初始压力2) < 总管压降_标准)
                         {
                             textBox_整机气密性测试.Text = "合格";
                             总管压降_合格 = "合格";
                         }
                         else
                         {
                             textBox_整机气密性测试.Text = "不合格";
                             总管压降_合格 = "不合格";
                         }
                         总管压力_flag = 0;
                         send(0x3d);  //计时结束
                         测试时间 = 6;
                         测试时间_num = 0;

                        isWorking = false;
                     }                  
                    break;

                case 6:     //呼吸器阻力测试 等待5s  5s结束  进行呼吸阻力测试计时
                    测试时间_num++;
                    if (测试时间_num == 测试时间_num6)
                    {
                       
                        测试时间 = 7;
                        面罩内压力_flag = 7;
                        总管压力_flag = 10;
                        测试时间_num7 = int.Parse(textBox_呼吸阻力测试时间.Text);
                        测试时间_num = 0;
                    }
                    break;
               case 7:  //呼吸器阻力测试 结束
                    测试时间_num++;
                    if (测试时间_num == 测试时间_num7)
                    {
                        if (comboBox_工作定额选择.Text == "每分100L/每分40次")
                        {
                            if (呼气阻力1 < 1000)
                            {
                                呼气阻力1_合格 = "合格";
                                label_呼气阻力.Text = "合格 " + 呼气阻力1.ToString();
                            }
                            else
                            { 
                                呼气阻力1_合格 = "不合格";
                                label_呼气阻力.Text = "不合格 " + 呼气阻力1.ToString();
                            }


                            if (吸气阻力1 < 500)
                            {
                                吸气阻力1_合格 = "合格";
                                label_吸气阻力.Text = "合格 " + 吸气阻力1.ToString();
                            }
                            else
                            { 
                                吸气阻力1_合格 = "不合格";
                                label_吸气阻力.Text = "不合格 " + 吸气阻力1.ToString();
                            }
                            if (呼气阻力1_合格 == "合格" && 吸气阻力1_合格 == "合格")
                                label_测试结果.Text = "合格";
                            else
                                label_测试结果.Text = "不合格";
             
                        }
                        else
                        {
                            if (呼气阻力2 < 700)
                            {
                             呼气阻力2_合格 = "合格";
                             label_呼气阻力.Text = "合格 " + 呼气阻力2.ToString();
                            }                               
                            else
                            {
                            呼气阻力2_合格 = "不合格";
                            label_呼气阻力.Text = "不合格 " + 呼气阻力2.ToString();
                            }
                                

                            if (吸气阻力2 < 500)
                            {
                             吸气阻力2_合格 = "合格";
                             label_吸气阻力.Text = "合格 " + 吸气阻力2.ToString();
                            }                               
                            else
                            {
                              吸气阻力2_合格 = "不合格";
                              label_吸气阻力.Text = "不合格 " + 吸气阻力2.ToString();
                            }

                            if (呼气阻力2_合格 == "合格" && 吸气阻力2_合格 == "合格")
                                label_测试结果.Text = "合格";
                            else
                                label_测试结果.Text = "不合格";
                        }
                       

                        面罩内压力_flag = 0;
                        总管压力_flag = 0;
                        send(0x5B);    //停止发送压力信号

                        测试时间_num = 0;//清零

                        isWorking = false;
                    }                  
                    break;

            }
        }

        /*********************************************************************************************************************
        * 面罩内压力刷新事件
        *  1238 面罩泄露测试
        * 1 寻找呼气阀开启压力
        * 2 找到呼气阀开启压力，并显示，继续下命令
        * 3 找到面罩泄露压力，并开始计时
        * 456 开启 静压测试
        * 4 寻找供气阀开启压力
        * 5 找到供气阀开启压力 并判断是否合格 下命令 继续两个呼吸
        * 6 呼吸停止，开始计时 计时后记录静压
        * 
        * 7 呼吸器阻力测试
        * 8 面罩泄露测试 只是刷新 textBox_即时压力.Text
        * 9开启静压测试 刷新面罩压力（之前漏掉现在补上）
        **********************************************************************************************************************/

        private void textBox_串口数据面罩内压力_TextChanged(object sender, EventArgs e)
        {
            int i;
            面罩内压力 = Convert.ToSingle(textBox_串口数据面罩内压力.Text);
            switch (面罩内压力_flag)
            {
                case 1:                             //寻找呼气阀开启压力
                    textBox_即时压力.Text = textBox_串口数据面罩内压力.Text;
                    if (面罩内压力_max < 面罩内压力)
                  {
                    面罩内压力_max = 面罩内压力;
                    呼气阀开启压力_num = 0;
                  }
                  else
                  {
                    呼气阀开启压力_num++;
                    if (呼气阀开启压力_num == 5) //连续十次降低
                    {
                        面罩内压力_flag = 2; // 找到最大值  
                        呼气阀开启压力_num = 0;
                    }
                 }
                    break;
                case 2:                        //找到呼气阀开启压力，并显示，继续下命令
                     textBox_即时压力.Text = textBox_串口数据面罩内压力.Text;
                     呼气阀开启压力 = 面罩内压力_max;
                     textBox_呼气阀开启压力.Text = 呼气阀开启压力.ToString();
                     textBox_呼气阀开启压力测.Text = 呼气阀开启压力.ToString();
                     if (呼气阀开启压力 < 呼气阀开启压力_标准)
                        呼气阀开启压力_合格 = "合格";
                     else
                         呼气阀开启压力_合格 = "不合格";

                     面罩内压力_flag = 3;
                     send(0x33);   //工肺停止向上动作，转而快速向下移动,同时继续发送面罩内压力
                    break;
                case 3:                  //找到面罩泄露测试压力，并开始计时
                    textBox_即时压力.Text = textBox_串口数据面罩内压力.Text;
                    if (面罩内压力 <= 面罩泄露开始压力_标准)
                    {
                        send(0x34); //开始计时，人工肺停止动作                     
                        测试时间 = 1;
                        测试时间_num1 = int.Parse(textBox_测试时间.Text);                      
                        面罩内压力_flag = 8; //只是刷新 textBox_即时压力.Text
                    }
                    break;
                case 4:              //寻找供气阀开启压力
                    textBox_面罩内压力.Text = textBox_串口数据面罩内压力.Text;
                    if (面罩内压力_min > 面罩内压力)
                    {
                        面罩内压力_min = 面罩内压力;
                        供气阀开启压力_num = 0;
                    }
                    else
                    {
                        供气阀开启压力_num++;
                        if (供气阀开启压力_num == 5) //连续十次降低
                        {
                            面罩内压力_flag = 5;   // 找到最大值  
                            供气阀开启压力_num = 0;
                        }
                    }
                    break;
                case 5:       //找到供气阀开启压力 并判断是否合格 下命令 继续两个呼吸

                    textBox_面罩内压力.Text = textBox_串口数据面罩内压力.Text;
                    供气阀开启压力 = 面罩内压力_min;
                    textBox_供气阀开启压力测试.Text = 供气阀开启压力.ToString();

                    if (供气阀开启压力 > 供气阀开启压力_标准)
                        供气阀开启压力_合格 = "合格";             //合格
                    else
                        供气阀开启压力_合格 = "不合格";

                     send(0x3A);   //人工肺继续运动两个呼吸

                    if(timerWorkingFlag==false)
                    {
                        timer = new System.Timers.Timer(10000); //等待10s，10s收不到下位机反馈强制退出
                        timer.AutoReset = false;
                        timer.Elapsed += new System.Timers.ElapsedEventHandler(WaitForTime);
                        timer.Start();
                        timerWorkingFlag = true;
                    }


                    if (呼吸器测试串口全局.开启静压测试停止 == true)
                    {
                        if (timer != null)
                        {
                            timer.Stop();
                            timer = null;
                            MessageBox.Show("收到下位机反馈，呼吸停止，开始计时", "提示", MessageBoxButtons.OK);
                            
                        }
                        面罩内压力_flag = 6;
                        timerWorkingFlag = false;
                    }
                    
                    break;
                case 6:        // 呼吸停止，开始计时   
                    textBox_面罩内压力.Text = textBox_串口数据面罩内压力.Text;
                    if (呼吸器测试串口全局.开启静压测试停止)  //下位机停止呼吸后，是否需要给上位机一个命令
                    {
                        测试时间 = 3;
                        测试时间_num3 = int.Parse(textBox_静态压力测试时间.Text);

                    /*    if (测试时间_num3!=null&&isTimeCounting==false)  //弹出时卡住
                        {
                            倒计时器 a = new 倒计时器("静态压力完成倒计时", 5);
                            a.Show();

                            isTimeCounting = true;
                        }*/


                        呼吸器测试串口全局.开启静压测试停止 = false;

                        


                    }
                    break;

                case 7:               //画呼吸器阻力测试 图
                    if (吸气阻力1 > 面罩内压力) //127
                    {
                        吸气阻力1 = 面罩内压力;
                    }
                    if (吸气阻力2 > 面罩内压力)
                    {
                        吸气阻力2 = 面罩内压力;
                    }
                    if (呼气阻力1 < 面罩内压力) //0
                    {
                        呼气阻力1 = 面罩内压力;
                    }
                    if (呼气阻力2 < 面罩内压力)
                    {
                        呼气阻力2 = 面罩内压力;
                    }
                    
                    i = (int)Math.Round(面罩内压力/6.67);//（保留0维小数就是取整）
                    AddData_面罩内压力(i);
                    AddData_总管压力(Convert.ToSingle(textBox_串口数据总管压力.Text));
                    panel_动态呼吸阻力测试.Invalidate();
                             
                    break;
                case 8:
                     textBox_即时压力.Text = textBox_串口数据面罩内压力.Text;                                       
                    break;
                case 9:
                      textBox_面罩内压力.Text = textBox_串口数据面罩内压力.Text;
                    break;
               
               

            }
           
        }

        //10s后收不到反馈，询问是否跳过，不跳过重置
        private void WaitForTime(object sener,System.Timers.ElapsedEventArgs e)
        {
            timer.Stop();
            timer = null;
            if (MessageBox.Show("没有收到下位机反馈，忽略错误并继续?","错误",MessageBoxButtons.YesNo,MessageBoxIcon.Error)==DialogResult.Yes)
            {;
                呼吸器测试串口全局.开启静压测试停止 = true;
            }
            else
            {
                timerWorkingFlag = false;
                this.button_开启静压测试重置_Click(null,null);
            }
        }

        /*********************************************************************************************************************
         * 声强刷新事件
         * 1 刷线声强随压力曲线  找到启报压力值
         * 2 刷线声强随压力曲线  计算平均报警声强
         * 
         **********************************************************************************************************************/

        private void textBox_串口数据声强_TextChanged(object sender, EventArgs e)
        {
            声强 = Convert.ToSingle(textBox_串口数据声强.Text);
            switch (报警器声强_flag)
            {
                case 1:                  //刷新图像 找到启报压力
                     
                    if (声强 > 启报压力值_声强标准)  //此处要确认开启数值
                    {
                         启报压力值 = 总管压力;
                        if (启报压力值 > 启报压力值_下限 && 启报压力值 < 启报压力值_上限)
                            启报压力值_合格 = "合格";
                        else
                            启报压力值_合格 = "不合格";

                        label_警报器启报压力.Text = 启报压力值.ToString();
                                                    
                        报警器声强_flag = 2;
                    }
                    
                    break;

                case 2:                          //刷新图像 计算平均报警声强
                     
                     平均报警声强=(平均报警声强+声强)/2;                                    //计算平均报警声强
                     if (总管压力 > 警报器总管压力)                     
                    {
                        if (平均报警声强 > 平均报警声强_标准)
                            平均报警声强_合格 = "合格";
                        else
                            平均报警声强_合格 = "不合格";

                        label_警报器报警平均声级.Text = 平均报警声强.ToString();
                       // send(0x53); //通知下位机，停止发送总管压力和声强
                        报警器声强_flag = 0;
                    } 
            
                    break;
              
            }
        }
        /*********************************************************************************************************************
         * 总管压力刷新事件
         * 1 开启静压测试 显示总管压力
         * 2 整机气密性测试 提示总管初始压力是否合格
         * 3 压力表校验
         * 4 报警器性能测试，判断总管压力是否大于8Mpa
         * 5 报警器性能测试 关闭充气阀后开始测试 判断总管压力是否小于8Mpa
         * 6 报警器性能测试 时间到达指定值，停止刷新。保存数据
         * 7 报警器性能测试 耗气量测试
         * 8 呼吸器阻力测试 读取判断总管压力大于15Mpa 
         * 9 呼吸器阻力测试 什么都不干，等待 刷新显示 
         * 10 画呼吸器阻力测试 图
         * 11 整机气密测试即时压力(一开始漏掉了，最后添加)
         * 12 压力表校验 显示传感器压力（一开始漏掉了，最后添加）
         **********************************************************************************************************************/
        int 差值 = 0;
        private void textBox_串口数据总管压力_TextChanged(object sender, EventArgs e)
        {
            总管压力 = Convert.ToSingle(textBox_串口数据总管压力.Text);
            
            double y; //转换用中间变量
            int i;
            float ch;
            switch (总管压力_flag)
            {
                case 1:   //开启静压测试 显示总管压力
                    textBox_总管压力.Text = textBox_串口数据总管压力.Text;
                    break;
                case 2:  //整机气密性测试 提示总管初始压力是否合格
                    textBox_总管初始压力.Text = textBox_串口数据总管压力.Text;
                    if (总管压力 < 15)
                    {
                        label_总管初始压力提示.Text = "提示:供气压力不足15MPa，不能继续本次试验";
                        button整机气密测试设置2.Enabled = false;
                    }
                    else
                        if (总管压力 >= 15 && 总管压力 < 27)
                    {
                        label_总管初始压力提示.Text = "提示:供气压力不足27MPa，可能导致试验数据不准确，是否继续";
                        button整机气密测试设置2.Enabled = true;
                    }
                    else
                            if (总管压力 >= 27)
                            {
                                label_总管初始压力提示.Text = "提示:供气压力正常，可以继续";
                                button整机气密测试设置2.Enabled = true;
                            }
                    break;

                case 3:   //压力表校验
                    textBox_传感器压力.Text = textBox_串口数据总管压力.Text;
                    传感器校验压力 = 总管压力;
                    if (传感器校验压力 <= Mpa) //总管压力到达设定校验值
                    {
                        总管压力_flag = 0;
                        send(0x57);
                        MessageBox.Show("请输入测压表压力","提示");
                    }
                    压力_old = 压力;
                    压力 = Convert.ToInt32(传感器校验压力);
                    if (压力 != 压力_old)   //刷新压力表  与上一次不同才刷新，节约资源
                    {
                        groupBox_压力表.Invalidate(); //更新显示                    
                    }
                    break;
                case 4:    // 报警器性能测试，判断总管压力是否大于8Mpa
                    textBox_总管即时压力.Text = textBox_串口数据总管压力.Text;
                    if (总管压力 > 8)
                    {
                        button_报警器测试设置2.Enabled = true;
                        //总管压力_flag = 0;
                    }
                    break;

                case 5:    // 报警器性能测试 关闭充气阀后开始测试 判断总管压力是否小于8Mpa
                    textBox_总管即时压力.Text = textBox_串口数据总管压力.Text;
                    if (总管压力 < 8)
                    {
                        报警器声强_flag = 1;      //提示 请缓慢泄压，听到警报声后立即停止泄压                      
                        总管压力_flag = 6;
                    }
                    
                    break;
                case 6:              //报警器性能测试 时间到达指定值，停止刷新。保存数据         
                    总管压力= (float)Math.Round((double)总管压力,2);
                    if (总管压力 != 总管压力_old)   //如果这一次与上一次总管压力取小数点后2位不相同
                    {
                        if (声强 != 0)
                        {
                            y = Convert.ToDouble(声强);
                            i = (int)Math.Round(y * 5);//（保留0维小数就是取整）
                            AddData_声强(i);
                            ch = (总管压力_old - 总管压力) * 100;
                            差值 = Math.Abs((int)ch);
                            AddData_DrawStep(差值);
                            panel_报警器曲线测试.Invalidate();
                        }
                           
     
                    }
                    总管压力_old=总管压力;  
                    textBox_总管即时压力.Text = textBox_串口数据总管压力.Text;
                    if (总管压力 <= 1)  //警报至总管压力至1
                    {
                        报警器声强_flag = 0;
                        总管压力_flag = 0;
                        send(0x55);

                        isWorking = false;

                    }
                    break;
                case 7:      //耗气量测试

                    break;
                case 8:     //呼吸器阻力测试 读取判断总管压力大于15Mpa 
                    textBox_呼吸阻力测试总管即时压力.Text = textBox_串口数据总管压力.Text;
                    if (总管压力 > 15)
                    {
                        总管压力_flag = 9;              //定时5s 稳定
                        测试时间 = 6;
                        测试时间_num6 = 5;

                        label_提示.Text = "总管压力合格";

                        if (comboBox_工作定额选择.Text == "每分100L/每分40次")
                            send(0x59);
                        else
                            send(0x5C);
                    }
                    else
                    {
                        label_提示.Text = "总管压力不足";
                    }
                 
                    break;
                case 9:          //什么都不干，等待 刷新显示
                    textBox_呼吸阻力测试总管即时压力.Text = textBox_串口数据总管压力.Text;                   
                    break;
                case 10:     //什么都不干，等待 刷新显示
                    textBox_呼吸阻力测试总管即时压力.Text = textBox_串口数据总管压力.Text; 
                    break;
                case 11:   //整机气密测试即时压力(一开始漏掉了，最后添加)
                    textBox_整机气密测试即时压力.Text=textBox_串口数据总管压力.Text;
                    break;
                case 12: //压力表校验 压力上升期
                    textBox_传感器压力.Text = textBox_串口数据总管压力.Text;  //
                    传感器校验压力 = 总管压力;
                     压力_old = 压力;
                    压力 = Convert.ToInt32(传感器校验压力);
                    if (压力 != 压力_old)   //刷新压力表  与上一次不同才刷新，节约资源
                    {
                        groupBox_压力表.Invalidate(); //更新显示                    
                    }
                    break;
               
            }
        }

        private void panel_动态呼吸阻力测试_Paint(object sender, PaintEventArgs e)
        {
            动态呼吸阻力 draw = new 动态呼吸阻力();
            draw.paint(e.Graphics, DataList_面罩内压力,DataList_总管压力);  //绘制两条曲线

        }

        private void panel_报警器曲线测试_Paint(object sender, PaintEventArgs e)
        {
            报警器曲线 draw = new 报警器曲线();
            draw.paint(e.Graphics, DataList_声强, DataList_DrawStep);
        }

        private void tabPage_报警器测试_Click(object sender, EventArgs e)
        {

        }

        private void textBox_供气阀开启压力测试_TextChanged(object sender, EventArgs e)
        {

        }

        private void 播放视频_Enter(object sender, EventArgs e)
        {

        }
    }
}
