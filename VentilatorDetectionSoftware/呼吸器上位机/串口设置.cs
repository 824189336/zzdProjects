using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace 呼吸器上位机
{
    public partial class 串口设置 : Form
    {
        XmlDocument xDoc;
        XmlElement xE1;
        XmlElement xE2;
        string 串口号;
        string 波特率;

        public 串口设置()
        {
            InitializeComponent();
        }
        public static 串口设置 pCurrentWin_ = null;
        private void 串口设置_Load(object sender, EventArgs e)
        {
            pCurrentWin_ = this;
          //  comboBox_串口号.Text = "COM1";
         //   comboBox_波特率.Text = "115200";
            getCfgSetting();
            comboBox_串口号.Text = 串口号;
            comboBox_波特率.Text = 波特率;
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false; //串口接收事件可以调用textbox
        }

        public void getCfgSetting()
        {
            try
            {
                xDoc = new XmlDocument();
                xDoc.Load("cfg.xml");
                XmlNode xNode = xDoc.SelectSingleNode("//configuration/uartSetting");
                xE1 = (XmlElement)xNode.SelectSingleNode("//add[@key='串口号']");
                xE2 = (XmlElement)xNode.SelectSingleNode("//add[@key='波特率']");


                if (xE1 != null)
                {
                    串口号 = xE1.GetAttribute("value");
                }
                else
                {
                    MessageBox.Show("cfg.xml中串口号不存在！", "读取错误", MessageBoxButtons.OK);
                }

                if (xE2 != null)
                {
                    波特率 = xE2.GetAttribute("value");
                }
                else
                {
                    MessageBox.Show("cfg.xml中波特率不存在！", "读取错误", MessageBoxButtons.OK);
                }

             

            }
            catch
            {
                MessageBox.Show("cfg.xml读取出错！", "读取错误", MessageBoxButtons.OK);
            }

        }

        public void setCfgSetting()
        {
            if (xE1 != null&& xE2 != null)
            {
                try
                {
                    xE1.SetAttribute("value", comboBox_串口号.Text);
                    xE2.SetAttribute("value", comboBox_波特率.Text);
                    xDoc.Save("cfg.xml");
                }
                catch
                {
                    MessageBox.Show("cfg.xml写入出错！", "写入错误", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("cfg.xml读取出错！", "读取错误", MessageBoxButtons.OK);
            }
        }

        private void button_打开串口_Click(object sender, EventArgs e)
        {
            try
            {
                 serialPort1.PortName = comboBox_串口号.Text;
                 serialPort1.BaudRate = Convert.ToInt32(comboBox_波特率.Text);
                 serialPort1.Open();

                if(serialPort1.IsOpen.Equals(true))
                {
                    this.串口状态.Text = "串口打开";
                }

                button_打开串口.Enabled = false;
                button_关闭串口.Enabled = true;
                

            }
            catch
            {
                MessageBox.Show("串口错误，请检查串口", "错误");  //提示错误
                if (serialPort1.IsOpen.Equals(false))
                {
                    this.串口状态.Text = "串口关闭";
                }
            }
        }

        private void button_关闭串口_Click(object sender, EventArgs e)
        {

            try
            {
                serialPort1.Close();
                if (serialPort1.IsOpen.Equals(false))
                {
                    this.串口状态.Text = "串口关闭";
                }
                button_关闭串口.Enabled = false;
                button_打开串口.Enabled = true;
            }
            catch (Exception)
            {

            }
        }

        private void 串口设置_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;      //禁止窗口关闭
            this.Hide();
            this.Visible = false; //不显示该窗口
        }
        int n = 0;
        public byte[] buf = new byte[7];      //接收缓冲区
        byte[] bu = new byte[4];              //和校验
        byte[] byte_to_float = new byte[4];   //byte转float 
       
        static bool ConvertIntToByteArray(Int32 m, ref byte[] arry) //int32变byte byte[0]低位
        {
            if (arry == null) return false;
            if (arry.Length < 4) return false;

            arry[0] = (byte)(m & 0xFF);
            arry[1] = (byte)((m & 0xFF00) >> 8);
            arry[2] = (byte)((m & 0xFF0000) >> 16);
            arry[3] = (byte)((m >> 24) & 0xFF);

            return true;
        }     
        Int32 check_sum()  //计算校验和
        {
            int i = 0;
            Int32 sum = 0;

            for (i = 1; i < 5; i++)
            {
                sum = sum + Convert.ToInt32(buf[i]);
            }

            return sum;
        }
        void data_chuli(TextBox a)
        {
            bool ok = ConvertIntToByteArray(check_sum(), ref bu);

            if (bu[0] == buf[5])  //和校验
            {
                for (int i = 0; i < 4; i++)
                {
                    byte_to_float[i] = buf[i + 1];
                }
                var data = BitConverter.ToSingle(byte_to_float, 0);
                a.Text = data.ToString();
            }
                     
        }


        void 反馈摆动幅度()
        {
            bool ok = ConvertIntToByteArray(check_sum(), ref bu);

            if (bu[0] == buf[5])  //和校验
            {
                for (int i = 0; i < 4; i++)
                {
                    摆动幅度.backData[i] = buf[i + 1];
                }
                摆动幅度.activeFromHadle.rebackData();
            }

        }

        void recve_chuli()
        {
            switch (buf[0])
            { 
                case 0xFC: 
                    if (buf[n - 1] == 0xCF)//首尾校验 声强
                    {
                        data_chuli(呼吸器测试.pCurrentWin.textBox_串口数据声强);                     
                    }
                    break;
                case 0xFD: 
                    if (buf[n - 1] == 0xDF)//首尾校验 总管压力
                    {
                        data_chuli(呼吸器测试.pCurrentWin.textBox_串口数据总管压力); 
                    }
                    break;
                case 0xFE: 
                    if (buf[n - 1] == 0xEF)//首尾校验 面罩压力
                    {
                        data_chuli(呼吸器测试.pCurrentWin.textBox_串口数据面罩内压力);
                    }
                    break;
                case 0xFF:
                    if (buf[n - 1] == 0xFF) //首尾校验  开启静压测试停止
                    {
                     呼吸器测试串口全局.开启静压测试停止=true;
                    }
                    break;
                case 0xFA:
                    if (buf[n - 1] == 0xAF)//首尾校验 下位机至摆动幅度反馈
                    {
                        反馈摆动幅度();
                    }
                    break;
            }

               
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
        
            System.Threading.Thread.Sleep(10); //触发接收事件后先延时一小会 20ms? 待计算 此时间为接收完一组数据的时间
            if (serialPort1.IsOpen)
                n = serialPort1.BytesToRead;
            else
                return;

            if(n!=7) //不是7个字节全丢
            {
                  serialPort1.DiscardInBuffer();
                  return;
            }

            if (serialPort1.IsOpen)
            {

                    serialPort1.Read(buf, 0, n);//读取缓冲数据
                    serialPort1.DiscardInBuffer();
                    recve_chuli();  //缓冲区接收处理         
               
            }


            try
            {
              //  呼吸器测试.pCurrentWin.textBox_串口数据传递.Text = str;
            }
            catch
            { 
            
            }
           
        }
     
        byte[] bu_send = new byte[4];
        private void textBox_串口发送_TextChanged(object sender, EventArgs e)  //
        {
            int a1 = int.Parse(textBox_串口发送.Text);                                            //string 转int 转byte
            bool ok = ConvertIntToByteArray(a1, ref bu_send);            //Int32变byte byte[0]低位 byte[3]高位
            serialPort1.Write(bu_send, 0, 1);
         
        }

        public void sendByte(byte i)
        {
            bool ok = ConvertIntToByteArray(i, ref bu_send);            //Int32变byte byte[0]低位 byte[3]高位
            serialPort1.Write(bu_send, 0, 1);
        }

        private void comboBox_波特率_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCfgSetting();
        }

        private void textBox_串口接收_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_串口号_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCfgSetting();
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

        private void 串口状态_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            摆动幅度 a = new 摆动幅度();
            a.Show();
        }
    }
}
