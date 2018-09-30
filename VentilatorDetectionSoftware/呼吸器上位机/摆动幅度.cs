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
    public partial class 摆动幅度 : Form
    {

        public int selectLimit = 0;//上限选择，初始为0，即第一个

        public int limit1_呼吸频次_Minimum = 0;
        public int limit1_呼吸频次_Maximum = 25;
        public int limit1_吸气量_Minimum = 0;
        public int limit1_吸气量_Maximum = 50;

        public int limit2_呼吸频次_Minimum = 0;
        public int limit2_呼吸频次_Maximum = 40;
        public int limit2_吸气量_Minimum = 0;
        public int limit2_吸气量_Maximum = 100;

        public static 摆动幅度 activeFromHadle = null; //静态变量保存当前打开窗口的句柄

        public static int[] backData = new int[4];


        public 摆动幅度()
        {
            InitializeComponent();

            activeFromHadle = this;

            limit1.Checked = true;
            /*      呼吸频次.Minimum = limit1_呼吸频次_Minimum;
                  呼吸频次.Maximum = limit1_呼吸频次_Maximum;
                  呼吸频次.SmallChange = 1;
                  吸气量.Minimum = limit1_吸气量_Minimum;
                  吸气量.Maximum = limit1_吸气量_Maximum;
                  吸气量.SmallChange = 1;*/

            呼吸频次.Minimum = 0;
            呼吸频次.Maximum = 100;
            呼吸频次.SmallChange = 1;
            吸气量.Minimum = 0;
            吸气量.Maximum = 100;
            吸气量.SmallChange = 1;

            limit1.Text = "呼吸频次" + limit1_呼吸频次_Maximum.ToString() + "次/min 吸气量" + limit1_吸气量_Maximum.ToString() + "L/min ";
            limit2.Text = "呼吸频次" + limit2_呼吸频次_Maximum.ToString() + "次/min 吸气量" + limit2_吸气量_Maximum.ToString() + "L/min ";

            getCfgSetting();



        }

        private void 摆动幅度_Load(object sender, EventArgs e)
        {

        }

        public void rebackData()//反馈数据
        {
            if(backData!=null)
            {
                for(int i=0;i<4;i++)
                {
                    if(backData[i]>100)
                    {
                        MessageBox.Show("第"+i.ToString()+"反馈数据高于100%！", "反馈数据错误", MessageBoxButtons.OK);
                        return;
                    }
                }
                switch(selectLimit)
                {
                    case 0:
                        呼吸频次.Value = backData[0];
                        呼吸频次_text.Text = backData[0].ToString();
                        吸气量.Value = backData[1];
                        吸气量_text.Text = backData[1].ToString();
                        break;
                    case 1:
                        呼吸频次.Value = backData[2];
                        呼吸频次_text.Text = backData[2].ToString();
                        吸气量.Value = backData[3];
                        吸气量_text.Text = backData[3].ToString();
                        break;
                    default:
                        break;
                }
            }
           


        }

        public void getCfgSetting()
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("cfg.xml");
                XmlNode xNode = xDoc.SelectSingleNode("//configuration/motorAngleLimitSetting");
                XmlElement xE1 = (XmlElement)xNode.SelectSingleNode("//add[@key='limit1_呼吸频次_Minimum']");
                XmlElement xE2 = (XmlElement)xNode.SelectSingleNode("//add[@key='limit1_呼吸频次_Maximum']");
                XmlElement xE3 = (XmlElement)xNode.SelectSingleNode("//add[@key='limit1_吸气量_Minimum']");
                XmlElement xE4 = (XmlElement)xNode.SelectSingleNode("//add[@key='limit1_吸气量_Maximum']");
                XmlElement xE5 = (XmlElement)xNode.SelectSingleNode("//add[@key='limit2_呼吸频次_Minimum']");
                XmlElement xE6 = (XmlElement)xNode.SelectSingleNode("//add[@key='limit2_呼吸频次_Maximum']");
                XmlElement xE7 = (XmlElement)xNode.SelectSingleNode("//add[@key='limit2_吸气量_Minimum']");
                XmlElement xE8 = (XmlElement)xNode.SelectSingleNode("//add[@key='limit2_吸气量_Maximum']");

                  if(xE1!=null)
                  {
                      try
                      {
                          limit1_呼吸频次_Minimum=(int)Convert.ToSingle(xE1.GetAttribute("value"));
                      }catch
                      {
                          MessageBox.Show("limit1_呼吸频次_Minimum不是数字！", "读取错误", MessageBoxButtons.OK);
                      }
                  }
                  else
                  {
                      MessageBox.Show("cfg.xml中limit1_呼吸频次_Minimum不存在！", "读取错误", MessageBoxButtons.OK);
                  }

                  if (xE2 != null)
                  {
                      try
                      {
                          limit1_呼吸频次_Maximum = (int)Convert.ToSingle(xE2.GetAttribute("value"));
                      }
                      catch
                      {
                          MessageBox.Show("limit1_呼吸频次_Maximum不是数字！", "读取错误", MessageBoxButtons.OK);
                      }
                  }
                  else
                  {
                      MessageBox.Show("cfg.xml中limit1_呼吸频次_Maximum不存在！", "读取错误", MessageBoxButtons.OK);
                  }

                  if (xE3 != null)
                  {
                      try
                      {
                          limit1_吸气量_Minimum = (int)Convert.ToSingle(xE3.GetAttribute("value"));
                      }
                      catch
                      {
                          MessageBox.Show("limit1_吸气量_Minimum不是数字！", "读取错误", MessageBoxButtons.OK);
                      }
                  }
                  else
                  {
                      MessageBox.Show("cfg.xml中limit1_吸气量_Minimum不存在！", "读取错误", MessageBoxButtons.OK);
                  }

                  if (xE4 != null)
                  {
                      try
                      {
                          limit1_吸气量_Maximum = (int)Convert.ToSingle(xE4.GetAttribute("value"));
                      }
                      catch
                      {
                          MessageBox.Show("limit1_吸气量_Maximum不是数字！", "读取错误", MessageBoxButtons.OK);
                      }
                  }
                  else
                  {
                      MessageBox.Show("cfg.xml中limit1_吸气量_Maximum不存在！", "读取错误", MessageBoxButtons.OK);
                  }

                  if (xE5 != null)
                  {
                      try
                      {
                          limit2_呼吸频次_Minimum = (int)Convert.ToSingle(xE5.GetAttribute("value"));
                      }
                      catch
                      {
                          MessageBox.Show("limit2_呼吸频次_Minimum不是数字！", "读取错误", MessageBoxButtons.OK);
                      }
                  }
                  else
                  {
                      MessageBox.Show("cfg.xml中limit2_呼吸频次_Minimum不存在！", "读取错误", MessageBoxButtons.OK);
                  }

                  if (xE6 != null)
                  {
                      try
                      {
                          limit2_呼吸频次_Maximum = (int)Convert.ToSingle(xE6.GetAttribute("value"));
                      }
                      catch
                      {
                          MessageBox.Show("limit2_呼吸频次_Maximum不是数字！", "读取错误", MessageBoxButtons.OK);
                      }
                  }
                  else
                  {
                      MessageBox.Show("cfg.xml中limit2_呼吸频次_Maximum不存在！", "读取错误", MessageBoxButtons.OK);
                  }

                  if (xE7 != null)
                  {
                      try
                      {
                          limit2_吸气量_Minimum = (int)Convert.ToSingle(xE7.GetAttribute("value"));
                      }
                      catch
                      {
                          MessageBox.Show("limit2_吸气量_Minimum不是数字！", "读取错误", MessageBoxButtons.OK);
                      }
                  }
                  else
                  {
                      MessageBox.Show("cfg.xml中limit2_吸气量_Minimum不存在！", "读取错误", MessageBoxButtons.OK);
                  }

                  if (xE8 != null)
                  {
                      try
                      {
                          limit2_吸气量_Maximum = (int)Convert.ToSingle(xE8.GetAttribute("value"));
                      }
                      catch
                      {
                          MessageBox.Show("limit2_吸气量_Maximum不是数字！", "读取错误", MessageBoxButtons.OK);
                      }
                  }
                  else
                  {
                      MessageBox.Show("cfg.xml中limit2_吸气量_Maximum不存在！", "读取错误", MessageBoxButtons.OK);
                  }

                limit1.Text = "呼吸频次" + limit1_呼吸频次_Maximum.ToString() + "次/min 吸气量" + limit1_吸气量_Maximum.ToString() + "L/min ";
                limit2.Text = "呼吸频次" + limit2_呼吸频次_Maximum.ToString() + "次/min 吸气量" + limit2_吸气量_Maximum.ToString() + "L/min ";

                fulshCheck();

            }
            catch
            {
                MessageBox.Show("cfg.xml读取出错！", "读取错误", MessageBoxButtons.OK);
            }          

        }

        void send(byte i)
        {
            try
            {
                // 串口设置.pCurrentWin_.textBox_串口发送.Text = i.ToString();
                串口设置.pCurrentWin_.sendByte(i);

            }
            catch(Exception e)
            {
                MessageBox.Show("串口连接错误！","串口错误",MessageBoxButtons.OK);
            }

        }

        void sendLimint1()
        {
            byte A=(byte)Convert.ToSingle(呼吸频次_text.Text);
            byte B=(byte)Convert.ToSingle(吸气量_text.Text);

            send(0x66);
            send(A);
            send(B);
            send(0x67);
        }

        void sendLimint2()
        {
            byte A = (byte)Convert.ToSingle(呼吸频次_text.Text);
            byte B = (byte)Convert.ToSingle(吸气量_text.Text);

            send(0x68);
            send(A);
            send(B);
            send(0x69);
        }

        void sendData() //发送呼吸频次与呼气量
        {
            switch (selectLimit)
            {
                case 0:
                    sendLimint1();
                    break;
                case 1:
                    sendLimint2();
                    break;
                default:
                    MessageBox.Show("呼吸频次和吸气量上限不在备选范围内！", "上限错误", MessageBoxButtons.OK);
                    break;
            }
        }

       

        void checkText()
        {
            try
            {
                int A = (int)Convert.ToSingle(呼吸频次_text.Text);
                if (A > 呼吸频次.Maximum)
                {
                    呼吸频次_text.Text = 呼吸频次.Maximum.ToString();
                }
                int B = (int)Convert.ToSingle(吸气量_text.Text);
                if (B > 吸气量.Maximum)
                {
                    吸气量_text.Text = 吸气量.Maximum.ToString();
                }
            }
            catch
            {
                MessageBox.Show("呼吸频次输入不是数字！", "输入错误", MessageBoxButtons.OK);
            }
        }


        private void cheackLimit1()
        {
            if (limit1.Checked)
            {
                /* 呼吸频次.Maximum = limit1_呼吸频次_Maximum;
                 吸气量.Maximum = limit1_吸气量_Maximum;
                 selectLimit = 0;*/

                呼吸频次.Maximum = 100;
                吸气量.Maximum = 100;
                selectLimit = 0;

                checkText();
            }
        }

        private void cheackLimit2()
        {
            if (limit2.Checked)
            {
                /* 呼吸频次.Maximum = limit2_呼吸频次_Maximum;
                 吸气量.Maximum = limit2_吸气量_Maximum;
                 selectLimit = 1;*/

                呼吸频次.Maximum = 100;
                吸气量.Maximum = 100;
                selectLimit = 1;

                checkText();
            }
        }

        private void fulshCheck()
        {
            cheackLimit1();
            cheackLimit2();

        }

        private void limit1_CheckedChanged(object sender, EventArgs e) //上限选择更改后设定上限
        {
            cheackLimit1();
            rebackData();
        }

        private void limit2_CheckedChanged(object sender, EventArgs e)
        {
            cheackLimit2();
            rebackData();
        }

        private void 呼吸频次_Scroll(object sender, EventArgs e)
        {
            呼吸频次_text.Text=呼吸频次.Value.ToString();
        }

        private void 吸气量_Scroll(object sender, EventArgs e)
        {
            吸气量_text.Text = 吸气量.Value.ToString();
        }

        private void 呼吸频次_text_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void 吸气量_text_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void test_Click(object sender, EventArgs e)
        {
            sendData();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            switch (selectLimit)
            {
                case 0:
                    send(0x6a);
                    break;
                case 1:
                    send(0x6b);
                    break;
                default:
                    MessageBox.Show("呼吸频次和吸气量上限不在备选范围内！", "上限错误", MessageBoxButtons.OK);
                    break;
            }

        }

        private void 呼吸频次_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== Convert.ToChar(System.Windows.Forms.Keys.Enter))
            {
                try
                {
                    int n = (int)Convert.ToSingle(呼吸频次_text.Text);
                    if (n > 呼吸频次.Maximum)
                    {
                        呼吸频次.Value = 呼吸频次.Maximum;
                        呼吸频次_text.Text = 呼吸频次.Maximum.ToString();
                    }
                    else if (n < 呼吸频次.Minimum)
                    {
                        呼吸频次.Value = 呼吸频次.Minimum;
                        呼吸频次_text.Text = 呼吸频次.Minimum.ToString();

                    }
                    else
                    {
                        呼吸频次.Value = n;
                    }

                }
                catch
                {
                    MessageBox.Show("呼吸频次输入不是数字！", "输入错误", MessageBoxButtons.OK);
                }
            }
        }

        private void 吸气量_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(System.Windows.Forms.Keys.Enter))
            {
                try
                {
                    int n = (int)Convert.ToSingle(吸气量_text.Text);
                    if (n > 吸气量.Maximum)
                    {
                        吸气量.Value = 吸气量.Maximum;
                        吸气量_text.Text = 吸气量.Maximum.ToString();
                    }
                    else if (n < 吸气量.Minimum)
                    {
                        吸气量.Value = 吸气量.Minimum;
                        吸气量_text.Text = 吸气量.Minimum.ToString();

                    }
                    else
                    {
                        吸气量.Value = n;
                    }

                }
                catch
                {
                    MessageBox.Show("吸气量输入不是数字！", "输入错误", MessageBoxButtons.OK);
                }
            }
        }

        private void 设定上限_Click(object sender, EventArgs e)
        {
            摆动幅度上限输入 a = new 摆动幅度上限输入();
            a.Show();
        }

        private void reback_Click(object sender, EventArgs e)
        {
            send(0x6c);
        }
    }
}
