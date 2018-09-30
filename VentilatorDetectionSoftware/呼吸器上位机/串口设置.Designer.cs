namespace 呼吸器上位机
{
    partial class 串口设置
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox_波特率 = new System.Windows.Forms.ComboBox();
            this.comboBox_串口号 = new System.Windows.Forms.ComboBox();
            this.button_关闭串口 = new System.Windows.Forms.Button();
            this.button_打开串口 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox_串口接收 = new System.Windows.Forms.TextBox();
            this.textBox_串口发送 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.串口状态 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_波特率
            // 
            this.comboBox_波特率.AutoCompleteCustomSource.AddRange(new string[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "115200"});
            this.comboBox_波特率.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_波特率.FormattingEnabled = true;
            this.comboBox_波特率.Items.AddRange(new object[] {
            "115200"});
            this.comboBox_波特率.Location = new System.Drawing.Point(662, 359);
            this.comboBox_波特率.Name = "comboBox_波特率";
            this.comboBox_波特率.Size = new System.Drawing.Size(121, 29);
            this.comboBox_波特率.TabIndex = 17;
            this.comboBox_波特率.SelectedIndexChanged += new System.EventHandler(this.comboBox_波特率_SelectedIndexChanged);
            // 
            // comboBox_串口号
            // 
            this.comboBox_串口号.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_串口号.FormattingEnabled = true;
            this.comboBox_串口号.Items.AddRange(new object[] {
            "COM0",
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16"});
            this.comboBox_串口号.Location = new System.Drawing.Point(662, 304);
            this.comboBox_串口号.Name = "comboBox_串口号";
            this.comboBox_串口号.Size = new System.Drawing.Size(121, 29);
            this.comboBox_串口号.TabIndex = 16;
            this.comboBox_串口号.SelectedIndexChanged += new System.EventHandler(this.comboBox_串口号_SelectedIndexChanged);
            // 
            // button_关闭串口
            // 
            this.button_关闭串口.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_关闭串口.Location = new System.Drawing.Point(669, 472);
            this.button_关闭串口.Name = "button_关闭串口";
            this.button_关闭串口.Size = new System.Drawing.Size(114, 50);
            this.button_关闭串口.TabIndex = 14;
            this.button_关闭串口.Text = "关闭串口";
            this.button_关闭串口.UseVisualStyleBackColor = true;
            this.button_关闭串口.Click += new System.EventHandler(this.button_关闭串口_Click);
            // 
            // button_打开串口
            // 
            this.button_打开串口.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_打开串口.Location = new System.Drawing.Point(521, 472);
            this.button_打开串口.Name = "button_打开串口";
            this.button_打开串口.Size = new System.Drawing.Size(114, 50);
            this.button_打开串口.TabIndex = 13;
            this.button_打开串口.Text = "打开串口";
            this.button_打开串口.UseVisualStyleBackColor = true;
            this.button_打开串口.Click += new System.EventHandler(this.button_打开串口_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(532, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "波特率:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(532, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "串口号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(577, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "串口设置";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBox_串口接收
            // 
            this.textBox_串口接收.Location = new System.Drawing.Point(521, 650);
            this.textBox_串口接收.Multiline = true;
            this.textBox_串口接收.Name = "textBox_串口接收";
            this.textBox_串口接收.Size = new System.Drawing.Size(260, 98);
            this.textBox_串口接收.TabIndex = 18;
            this.textBox_串口接收.TextChanged += new System.EventHandler(this.textBox_串口接收_TextChanged);
            // 
            // textBox_串口发送
            // 
            this.textBox_串口发送.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_串口发送.Location = new System.Drawing.Point(521, 572);
            this.textBox_串口发送.Multiline = true;
            this.textBox_串口发送.Name = "textBox_串口发送";
            this.textBox_串口发送.Size = new System.Drawing.Size(260, 32);
            this.textBox_串口发送.TabIndex = 19;
            this.textBox_串口发送.TextChanged += new System.EventHandler(this.textBox_串口发送_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(530, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "发送数据:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(530, 611);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "接收数据:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(532, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "串口状态:";
            // 
            // 串口状态
            // 
            this.串口状态.AutoSize = true;
            this.串口状态.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.串口状态.ForeColor = System.Drawing.Color.Red;
            this.串口状态.Location = new System.Drawing.Point(665, 415);
            this.串口状态.Name = "串口状态";
            this.串口状态.Size = new System.Drawing.Size(98, 21);
            this.串口状态.TabIndex = 23;
            this.串口状态.Text = "串口关闭";
            this.串口状态.Click += new System.EventHandler(this.串口状态_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(984, 800);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 50);
            this.button1.TabIndex = 24;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 15.75F);
            this.button2.Location = new System.Drawing.Point(247, 800);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 49);
            this.button2.TabIndex = 25;
            this.button2.Text = "摆动幅度测试";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 串口设置
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.串口状态);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_串口发送);
            this.Controls.Add(this.textBox_串口接收);
            this.Controls.Add(this.comboBox_波特率);
            this.Controls.Add(this.comboBox_串口号);
            this.Controls.Add(this.button_关闭串口);
            this.Controls.Add(this.button_打开串口);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "串口设置";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口设置";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.串口设置_FormClosing);
            this.Load += new System.EventHandler(this.串口设置_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_波特率;
        private System.Windows.Forms.ComboBox comboBox_串口号;
        private System.Windows.Forms.Button button_关闭串口;
        private System.Windows.Forms.Button button_打开串口;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox_串口接收;
        public System.Windows.Forms.TextBox textBox_串口发送;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label 串口状态;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}