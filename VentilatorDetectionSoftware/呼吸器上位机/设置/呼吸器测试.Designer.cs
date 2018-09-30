namespace 呼吸器上位机.主界面单项
{
    partial class 呼吸器测试
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(呼吸器测试));
            this.button_呼吸器外观检查 = new System.Windows.Forms.Button();
            this.button_面罩泄漏测试 = new System.Windows.Forms.Button();
            this.button_开启静压测试 = new System.Windows.Forms.Button();
            this.button_整机气密测试 = new System.Windows.Forms.Button();
            this.button_压力表校验 = new System.Windows.Forms.Button();
            this.button_报警器测试 = new System.Windows.Forms.Button();
            this.button_动态呼吸阻力测试 = new System.Windows.Forms.Button();
            this.button_返回 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_串口设置 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button_打印 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_测试 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_待测呼吸器 = new System.Windows.Forms.Label();
            this.button_临时测试 = new System.Windows.Forms.Button();
            this.textBox_呼吸器编号 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_匹配 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_呼吸器外观检查
            // 
            this.button_呼吸器外观检查.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_呼吸器外观检查.Location = new System.Drawing.Point(130, 290);
            this.button_呼吸器外观检查.Name = "button_呼吸器外观检查";
            this.button_呼吸器外观检查.Size = new System.Drawing.Size(200, 80);
            this.button_呼吸器外观检查.TabIndex = 0;
            this.button_呼吸器外观检查.Text = "呼吸器外观检查";
            this.button_呼吸器外观检查.UseVisualStyleBackColor = true;
            this.button_呼吸器外观检查.Click += new System.EventHandler(this.button_呼吸器外观检查_Click);
            // 
            // button_面罩泄漏测试
            // 
            this.button_面罩泄漏测试.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_面罩泄漏测试.Location = new System.Drawing.Point(926, 290);
            this.button_面罩泄漏测试.Name = "button_面罩泄漏测试";
            this.button_面罩泄漏测试.Size = new System.Drawing.Size(200, 80);
            this.button_面罩泄漏测试.TabIndex = 1;
            this.button_面罩泄漏测试.Text = "面罩泄漏测试";
            this.button_面罩泄漏测试.UseVisualStyleBackColor = true;
            this.button_面罩泄漏测试.Click += new System.EventHandler(this.button_面罩泄漏测试_Click);
            // 
            // button_开启静压测试
            // 
            this.button_开启静压测试.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_开启静压测试.Location = new System.Drawing.Point(400, 290);
            this.button_开启静压测试.Name = "button_开启静压测试";
            this.button_开启静压测试.Size = new System.Drawing.Size(200, 80);
            this.button_开启静压测试.TabIndex = 2;
            this.button_开启静压测试.Text = "开启/静压测试";
            this.button_开启静压测试.UseVisualStyleBackColor = true;
            this.button_开启静压测试.Click += new System.EventHandler(this.button_开启静压测试_Click);
            // 
            // button_整机气密测试
            // 
            this.button_整机气密测试.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_整机气密测试.Location = new System.Drawing.Point(660, 290);
            this.button_整机气密测试.Name = "button_整机气密测试";
            this.button_整机气密测试.Size = new System.Drawing.Size(200, 80);
            this.button_整机气密测试.TabIndex = 4;
            this.button_整机气密测试.Text = "整机气密测试";
            this.button_整机气密测试.UseVisualStyleBackColor = true;
            this.button_整机气密测试.Click += new System.EventHandler(this.button_整机气密测试_Click);
            // 
            // button_压力表校验
            // 
            this.button_压力表校验.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_压力表校验.Location = new System.Drawing.Point(400, 397);
            this.button_压力表校验.Name = "button_压力表校验";
            this.button_压力表校验.Size = new System.Drawing.Size(200, 80);
            this.button_压力表校验.TabIndex = 5;
            this.button_压力表校验.Text = "压力表校验";
            this.button_压力表校验.UseVisualStyleBackColor = true;
            this.button_压力表校验.Click += new System.EventHandler(this.button_压力表校验_Click);
            // 
            // button_报警器测试
            // 
            this.button_报警器测试.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_报警器测试.Location = new System.Drawing.Point(660, 397);
            this.button_报警器测试.Name = "button_报警器测试";
            this.button_报警器测试.Size = new System.Drawing.Size(200, 80);
            this.button_报警器测试.TabIndex = 6;
            this.button_报警器测试.Text = "报警器测试";
            this.button_报警器测试.UseVisualStyleBackColor = true;
            this.button_报警器测试.Click += new System.EventHandler(this.button_报警器测试_Click);
            // 
            // button_动态呼吸阻力测试
            // 
            this.button_动态呼吸阻力测试.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_动态呼吸阻力测试.Location = new System.Drawing.Point(130, 397);
            this.button_动态呼吸阻力测试.Name = "button_动态呼吸阻力测试";
            this.button_动态呼吸阻力测试.Size = new System.Drawing.Size(200, 80);
            this.button_动态呼吸阻力测试.TabIndex = 7;
            this.button_动态呼吸阻力测试.Text = "动态呼吸阻力测试";
            this.button_动态呼吸阻力测试.UseVisualStyleBackColor = true;
            this.button_动态呼吸阻力测试.Click += new System.EventHandler(this.button_动态呼吸阻力测试_Click);
            // 
            // button_返回
            // 
            this.button_返回.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_返回.Location = new System.Drawing.Point(981, 594);
            this.button_返回.Name = "button_返回";
            this.button_返回.Size = new System.Drawing.Size(150, 50);
            this.button_返回.TabIndex = 8;
            this.button_返回.Text = "返回";
            this.button_返回.UseVisualStyleBackColor = true;
            this.button_返回.Click += new System.EventHandler(this.button_返回_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(542, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "呼吸器测试";
            // 
            // button_串口设置
            // 
            this.button_串口设置.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_串口设置.Location = new System.Drawing.Point(926, 397);
            this.button_串口设置.Name = "button_串口设置";
            this.button_串口设置.Size = new System.Drawing.Size(200, 80);
            this.button_串口设置.TabIndex = 10;
            this.button_串口设置.Text = "串口设置";
            this.button_串口设置.UseVisualStyleBackColor = true;
            this.button_串口设置.Click += new System.EventHandler(this.button_串口设置_Click);
            // 
            // button_打印
            // 
            this.button_打印.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_打印.Location = new System.Drawing.Point(130, 513);
            this.button_打印.Name = "button_打印";
            this.button_打印.Size = new System.Drawing.Size(200, 80);
            this.button_打印.TabIndex = 11;
            this.button_打印.Text = "打印预览";
            this.button_打印.UseVisualStyleBackColor = true;
            this.button_打印.Click += new System.EventHandler(this.button_打印_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_匹配);
            this.groupBox1.Controls.Add(this.button_测试);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label_待测呼吸器);
            this.groupBox1.Controls.Add(this.button_临时测试);
            this.groupBox1.Controls.Add(this.textBox_呼吸器编号);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 186);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "呼吸器信息";
            // 
            // button_测试
            // 
            this.button_测试.Location = new System.Drawing.Point(791, 36);
            this.button_测试.Name = "button_测试";
            this.button_测试.Size = new System.Drawing.Size(75, 29);
            this.button_测试.TabIndex = 5;
            this.button_测试.Text = "测试";
            this.button_测试.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(608, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 27);
            this.comboBox1.TabIndex = 4;
            // 
            // label_待测呼吸器
            // 
            this.label_待测呼吸器.AutoSize = true;
            this.label_待测呼吸器.Location = new System.Drawing.Point(496, 43);
            this.label_待测呼吸器.Name = "label_待测呼吸器";
            this.label_待测呼吸器.Size = new System.Drawing.Size(123, 19);
            this.label_待测呼吸器.TabIndex = 3;
            this.label_待测呼吸器.Text = "待测呼吸器：";
            // 
            // button_临时测试
            // 
            this.button_临时测试.Location = new System.Drawing.Point(105, 86);
            this.button_临时测试.Name = "button_临时测试";
            this.button_临时测试.Size = new System.Drawing.Size(118, 43);
            this.button_临时测试.TabIndex = 2;
            this.button_临时测试.Text = "临时测试";
            this.button_临时测试.UseVisualStyleBackColor = true;
            // 
            // textBox_呼吸器编号
            // 
            this.textBox_呼吸器编号.Location = new System.Drawing.Point(268, 43);
            this.textBox_呼吸器编号.Name = "textBox_呼吸器编号";
            this.textBox_呼吸器编号.Size = new System.Drawing.Size(100, 29);
            this.textBox_呼吸器编号.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "输入呼吸器编号：";
            // 
            // button_匹配
            // 
            this.button_匹配.Location = new System.Drawing.Point(388, 43);
            this.button_匹配.Name = "button_匹配";
            this.button_匹配.Size = new System.Drawing.Size(75, 29);
            this.button_匹配.TabIndex = 6;
            this.button_匹配.Text = "匹配";
            this.button_匹配.UseVisualStyleBackColor = true;
            this.button_匹配.Click += new System.EventHandler(this.button_匹配_Click);
            // 
            // 呼吸器测试
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_打印);
            this.Controls.Add(this.button_串口设置);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_返回);
            this.Controls.Add(this.button_动态呼吸阻力测试);
            this.Controls.Add(this.button_报警器测试);
            this.Controls.Add(this.button_压力表校验);
            this.Controls.Add(this.button_整机气密测试);
            this.Controls.Add(this.button_开启静压测试);
            this.Controls.Add(this.button_面罩泄漏测试);
            this.Controls.Add(this.button_呼吸器外观检查);
            this.Name = "呼吸器测试";
            this.Text = "呼吸器测试";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.呼吸器测试_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_呼吸器外观检查;
        private System.Windows.Forms.Button button_面罩泄漏测试;
        private System.Windows.Forms.Button button_开启静压测试;
        private System.Windows.Forms.Button button_整机气密测试;
        private System.Windows.Forms.Button button_压力表校验;
        private System.Windows.Forms.Button button_报警器测试;
        private System.Windows.Forms.Button button_动态呼吸阻力测试;
        private System.Windows.Forms.Button button_返回;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_串口设置;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button_打印;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_测试;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_待测呼吸器;
        private System.Windows.Forms.Button button_临时测试;
        private System.Windows.Forms.TextBox textBox_呼吸器编号;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_匹配;
    }
}