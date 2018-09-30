using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace 呼吸器上位机
{
    public partial class 摆动幅度上限输入 : Form
    {
        public int limit1_呼吸频次 = 0;
        public int limit1_吸气量 = 0;
        public int limit2_呼吸频次 = 0;
        public int limit2_吸气量 = 0;


        public 摆动幅度上限输入()
        {
            InitializeComponent();
            getCfgSetting();
        }


        private void getCfgSetting()//从配置文件中获得参数
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("cfg.xml");
                XmlNode xNode = xDoc.SelectSingleNode("//configuration/motorAngleLimitSetting");
                XmlElement xE2 = (XmlElement)xNode.SelectSingleNode("//add[@key='limit1_呼吸频次_Maximum']");
                XmlElement xE4 = (XmlElement)xNode.SelectSingleNode("//add[@key='limit1_吸气量_Maximum']");
                XmlElement xE6 = (XmlElement)xNode.SelectSingleNode("//add[@key='limit2_呼吸频次_Maximum']");
                XmlElement xE8 = (XmlElement)xNode.SelectSingleNode("//add[@key='limit2_吸气量_Maximum']");

                if (xE2 != null)
                {
                    try
                    {
                        limit1_呼吸频次 = (int)Convert.ToSingle(xE2.GetAttribute("value"));
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


                if (xE4 != null)
                {
                    try
                    {
                        limit1_吸气量 = (int)Convert.ToSingle(xE4.GetAttribute("value"));
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

                if (xE6 != null)
                {
                    try
                    {
                        limit2_呼吸频次 = (int)Convert.ToSingle(xE6.GetAttribute("value"));
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

                if (xE8 != null)
                {
                    try
                    {
                        limit2_吸气量 = (int)Convert.ToSingle(xE8.GetAttribute("value"));
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

                limit1_呼吸频次_Max.Text = limit1_呼吸频次.ToString();
                limit1_吸气量_Max.Text = limit1_吸气量.ToString();
                limit2_呼吸频次_Max.Text = limit2_呼吸频次.ToString();
                limit2_吸气量_Max.Text = limit2_吸气量.ToString();

            }
            catch
            {
                MessageBox.Show("cfg.xml读取出错！", "读取错误", MessageBoxButtons.OK);
            }

        }


        private void setCfgSetting() //保存输入的配置文件
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("cfg.xml");
                XmlNode xNode = xDoc.SelectSingleNode("//configuration/motorAngleLimitSetting");


                  XmlElement xE2 = (XmlElement)xNode.SelectSingleNode("//add[@key='limit1_呼吸频次_Maximum']");
                  XmlElement xE4 = (XmlElement)xNode.SelectSingleNode("//add[@key='limit1_吸气量_Maximum']");
                  XmlElement xE6 = (XmlElement)xNode.SelectSingleNode("//add[@key='limit2_呼吸频次_Maximum']");
                  XmlElement xE8 = (XmlElement)xNode.SelectSingleNode("//add[@key='limit2_吸气量_Maximum']");

                  xE2.SetAttribute("value", limit1_呼吸频次_Max.Text);
                  xE4.SetAttribute("value", limit1_吸气量_Max.Text);
                  xE6.SetAttribute("value", limit2_呼吸频次_Max.Text);
                  xE8.SetAttribute("value", limit2_吸气量_Max.Text);

                

                xDoc.Save("cfg.xml");

                摆动幅度.activeFromHadle.getCfgSetting(); //通过静态变量获得当前打开的摆动幅度窗口的句柄
            }
            catch
            {
                MessageBox.Show("cfg.xml写入出错！", "写入错误", MessageBoxButtons.OK);
            }

            
        }

        private void limit1_呼吸频次_Max_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(System.Windows.Forms.Keys.Enter))
            {
                try
                {
                    int limit1_呼吸频次 = (int)Convert.ToSingle(limit1_呼吸频次_Max.Text);                }
                catch
                {
                    MessageBox.Show("呼吸频次输入不是数字！", "输入错误", MessageBoxButtons.OK);
                }
            }
        }

        private void limit1_吸气量_Max_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(System.Windows.Forms.Keys.Enter))
            {
                try
                {
                    int limit1_吸气量 = (int)Convert.ToSingle(limit1_吸气量_Max.Text);
                }
                catch
                {
                    MessageBox.Show("呼吸频次输入不是数字！", "输入错误", MessageBoxButtons.OK);
                }
            }
        }

        private void limit2_呼吸频次_Max_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(System.Windows.Forms.Keys.Enter))
            {
                try
                {
                    int limit2_呼吸频次 = (int)Convert.ToSingle(limit2_呼吸频次_Max.Text);
                }
                catch
                {
                    MessageBox.Show("呼吸频次输入不是数字！", "输入错误", MessageBoxButtons.OK);
                }
            }
        }

        private void limit2_吸气量_Max_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(System.Windows.Forms.Keys.Enter))
            {
                try
                {
                    int limit2_吸气量 = (int)Convert.ToSingle(limit2_吸气量_Max.Text);
                }
                catch
                {
                    MessageBox.Show("呼吸频次输入不是数字！", "输入错误", MessageBoxButtons.OK);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  limit1_呼吸频次_Max.Text = "";
            limit1_吸气量_Max.Text = "";
            limit2_呼吸频次_Max.Text = "";
            limit2_吸气量_Max.Text = "";*/

            getCfgSetting();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setCfgSetting();
        }
    }
}
