namespace 呼吸器上位机.主界面单项
{
    partial class 呼吸器管理
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_输入提示 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_查询方式 = new System.Windows.Forms.ComboBox();
            this.textBox_查询索引 = new System.Windows.Forms.TextBox();
            this.button_查询 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_删除 = new System.Windows.Forms.Button();
            this.button_编辑 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_呼吸器内部编号 = new System.Windows.Forms.TextBox();
            this.textBox_呼吸器编号 = new System.Windows.Forms.TextBox();
            this.textBox_产品型号 = new System.Windows.Forms.TextBox();
            this.textBox_制造商 = new System.Windows.Forms.TextBox();
            this.textBox_使用单位 = new System.Windows.Forms.TextBox();
            this.textBox_使用者 = new System.Windows.Forms.TextBox();
            this.textBox_入库日期 = new System.Windows.Forms.TextBox();
            this.textBox_出厂日期 = new System.Windows.Forms.TextBox();
            this.textBox_呼吸器类型 = new System.Windows.Forms.TextBox();
            this.textBox_上次测试日期 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox_面罩 = new System.Windows.Forms.ComboBox();
            this.comboBox_压力表 = new System.Windows.Forms.ComboBox();
            this.comboBox_呼吸阻力 = new System.Windows.Forms.ComboBox();
            this.comboBox_报警器 = new System.Windows.Forms.ComboBox();
            this.comboBox_状态 = new System.Windows.Forms.ComboBox();
            this.comboBox_气密性 = new System.Windows.Forms.ComboBox();
            this.button_返回 = new System.Windows.Forms.Button();
            this.button_添加呼吸器 = new System.Windows.Forms.Button();
            this.button_导出 = new System.Windows.Forms.Button();
            this.button_导入外部数据 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(533, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "呼吸器管理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(23, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "查询方式：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(76, 557);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "呼吸器编号:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(114, 593);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "制造商:";
            // 
            // label_输入提示
            // 
            this.label_输入提示.AutoSize = true;
            this.label_输入提示.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_输入提示.Location = new System.Drawing.Point(265, 142);
            this.label_输入提示.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label_输入提示.Name = "label_输入提示";
            this.label_输入提示.Size = new System.Drawing.Size(85, 19);
            this.label_输入提示.TabIndex = 4;
            this.label_输入提示.Text = "请输入：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(51, 521);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "呼吸器内部编号:";
            // 
            // comboBox_查询方式
            // 
            this.comboBox_查询方式.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_查询方式.FormattingEnabled = true;
            this.comboBox_查询方式.Items.AddRange(new object[] {
            "呼吸器编号",
            "上次测试日期",
            "状态",
            "产品型号",
            "制造商",
            "出厂日期",
            "入库日期"});
            this.comboBox_查询方式.Location = new System.Drawing.Point(118, 172);
            this.comboBox_查询方式.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox_查询方式.Name = "comboBox_查询方式";
            this.comboBox_查询方式.Size = new System.Drawing.Size(138, 27);
            this.comboBox_查询方式.TabIndex = 6;
            this.comboBox_查询方式.SelectedIndexChanged += new System.EventHandler(this.comboBox_查询方式_SelectedIndexChanged);
            // 
            // textBox_查询索引
            // 
            this.textBox_查询索引.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_查询索引.Location = new System.Drawing.Point(354, 170);
            this.textBox_查询索引.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_查询索引.Name = "textBox_查询索引";
            this.textBox_查询索引.Size = new System.Drawing.Size(102, 29);
            this.textBox_查询索引.TabIndex = 7;
            // 
            // button_查询
            // 
            this.button_查询.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_查询.Location = new System.Drawing.Point(524, 172);
            this.button_查询.Margin = new System.Windows.Forms.Padding(1);
            this.button_查询.Name = "button_查询";
            this.button_查询.Size = new System.Drawing.Size(90, 30);
            this.button_查询.TabIndex = 8;
            this.button_查询.Text = "查询";
            this.button_查询.UseVisualStyleBackColor = true;
            this.button_查询.Click += new System.EventHandler(this.button_查询_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(18, 214);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1077, 273);
            this.dataGridView1.TabIndex = 9;
            // 
            // button_删除
            // 
            this.button_删除.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_删除.Location = new System.Drawing.Point(1107, 339);
            this.button_删除.Margin = new System.Windows.Forms.Padding(1);
            this.button_删除.Name = "button_删除";
            this.button_删除.Size = new System.Drawing.Size(155, 30);
            this.button_删除.TabIndex = 10;
            this.button_删除.Text = "删除";
            this.button_删除.UseVisualStyleBackColor = true;
            this.button_删除.Click += new System.EventHandler(this.button_删除_Click);
            // 
            // button_编辑
            // 
            this.button_编辑.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_编辑.Location = new System.Drawing.Point(1107, 269);
            this.button_编辑.Margin = new System.Windows.Forms.Padding(1);
            this.button_编辑.Name = "button_编辑";
            this.button_编辑.Size = new System.Drawing.Size(155, 30);
            this.button_编辑.TabIndex = 12;
            this.button_编辑.Text = "编辑";
            this.button_编辑.UseVisualStyleBackColor = true;
            this.button_编辑.Click += new System.EventHandler(this.button_编辑_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(95, 629);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "产品型号:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(76, 670);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "呼吸器类型:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(369, 521);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "使用者:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(350, 562);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "使用单位:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(350, 599);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "出厂日期:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(350, 639);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "入库日期:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(312, 677);
            this.label13.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 19);
            this.label13.TabIndex = 19;
            this.label13.Text = "上次测试日期:";
            // 
            // textBox_呼吸器内部编号
            // 
            this.textBox_呼吸器内部编号.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_呼吸器内部编号.Location = new System.Drawing.Point(205, 518);
            this.textBox_呼吸器内部编号.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_呼吸器内部编号.Name = "textBox_呼吸器内部编号";
            this.textBox_呼吸器内部编号.Size = new System.Drawing.Size(92, 29);
            this.textBox_呼吸器内部编号.TabIndex = 20;
            this.textBox_呼吸器内部编号.TextChanged += new System.EventHandler(this.textBox_呼吸器内部编号_TextChanged);
            // 
            // textBox_呼吸器编号
            // 
            this.textBox_呼吸器编号.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_呼吸器编号.Location = new System.Drawing.Point(205, 554);
            this.textBox_呼吸器编号.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_呼吸器编号.Name = "textBox_呼吸器编号";
            this.textBox_呼吸器编号.Size = new System.Drawing.Size(92, 29);
            this.textBox_呼吸器编号.TabIndex = 21;
            // 
            // textBox_产品型号
            // 
            this.textBox_产品型号.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_产品型号.Location = new System.Drawing.Point(205, 629);
            this.textBox_产品型号.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_产品型号.Name = "textBox_产品型号";
            this.textBox_产品型号.Size = new System.Drawing.Size(92, 29);
            this.textBox_产品型号.TabIndex = 23;
            // 
            // textBox_制造商
            // 
            this.textBox_制造商.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_制造商.Location = new System.Drawing.Point(205, 591);
            this.textBox_制造商.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_制造商.Name = "textBox_制造商";
            this.textBox_制造商.Size = new System.Drawing.Size(92, 29);
            this.textBox_制造商.TabIndex = 22;
            // 
            // textBox_使用单位
            // 
            this.textBox_使用单位.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_使用单位.Location = new System.Drawing.Point(468, 554);
            this.textBox_使用单位.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_使用单位.Name = "textBox_使用单位";
            this.textBox_使用单位.Size = new System.Drawing.Size(90, 29);
            this.textBox_使用单位.TabIndex = 25;
            // 
            // textBox_使用者
            // 
            this.textBox_使用者.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_使用者.Location = new System.Drawing.Point(468, 518);
            this.textBox_使用者.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_使用者.Name = "textBox_使用者";
            this.textBox_使用者.Size = new System.Drawing.Size(90, 29);
            this.textBox_使用者.TabIndex = 24;
            // 
            // textBox_入库日期
            // 
            this.textBox_入库日期.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_入库日期.Location = new System.Drawing.Point(468, 629);
            this.textBox_入库日期.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_入库日期.Name = "textBox_入库日期";
            this.textBox_入库日期.Size = new System.Drawing.Size(90, 29);
            this.textBox_入库日期.TabIndex = 27;
            // 
            // textBox_出厂日期
            // 
            this.textBox_出厂日期.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_出厂日期.Location = new System.Drawing.Point(468, 591);
            this.textBox_出厂日期.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_出厂日期.Name = "textBox_出厂日期";
            this.textBox_出厂日期.Size = new System.Drawing.Size(90, 29);
            this.textBox_出厂日期.TabIndex = 26;
            // 
            // textBox_呼吸器类型
            // 
            this.textBox_呼吸器类型.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_呼吸器类型.Location = new System.Drawing.Point(205, 667);
            this.textBox_呼吸器类型.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_呼吸器类型.Name = "textBox_呼吸器类型";
            this.textBox_呼吸器类型.Size = new System.Drawing.Size(92, 29);
            this.textBox_呼吸器类型.TabIndex = 29;
            // 
            // textBox_上次测试日期
            // 
            this.textBox_上次测试日期.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_上次测试日期.Location = new System.Drawing.Point(468, 667);
            this.textBox_上次测试日期.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_上次测试日期.Name = "textBox_上次测试日期";
            this.textBox_上次测试日期.Size = new System.Drawing.Size(90, 29);
            this.textBox_上次测试日期.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(619, 677);
            this.label14.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 19);
            this.label14.TabIndex = 34;
            this.label14.Text = "气密性:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(600, 639);
            this.label15.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 19);
            this.label15.TabIndex = 33;
            this.label15.Text = "呼吸阻力:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(619, 596);
            this.label16.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 19);
            this.label16.TabIndex = 32;
            this.label16.Text = "报警器:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(619, 557);
            this.label17.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 19);
            this.label17.TabIndex = 31;
            this.label17.Text = "压力表:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(638, 521);
            this.label18.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 19);
            this.label18.TabIndex = 30;
            this.label18.Text = "面罩:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(638, 713);
            this.label19.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 19);
            this.label19.TabIndex = 35;
            this.label19.Text = "状态:";
            // 
            // comboBox_面罩
            // 
            this.comboBox_面罩.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_面罩.FormattingEnabled = true;
            this.comboBox_面罩.Items.AddRange(new object[] {
            "正常",
            "待修"});
            this.comboBox_面罩.Location = new System.Drawing.Point(716, 517);
            this.comboBox_面罩.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox_面罩.Name = "comboBox_面罩";
            this.comboBox_面罩.Size = new System.Drawing.Size(93, 27);
            this.comboBox_面罩.TabIndex = 36;
            // 
            // comboBox_压力表
            // 
            this.comboBox_压力表.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_压力表.FormattingEnabled = true;
            this.comboBox_压力表.Items.AddRange(new object[] {
            "正常",
            "待修"});
            this.comboBox_压力表.Location = new System.Drawing.Point(716, 554);
            this.comboBox_压力表.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox_压力表.Name = "comboBox_压力表";
            this.comboBox_压力表.Size = new System.Drawing.Size(93, 27);
            this.comboBox_压力表.TabIndex = 37;
            // 
            // comboBox_呼吸阻力
            // 
            this.comboBox_呼吸阻力.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_呼吸阻力.FormattingEnabled = true;
            this.comboBox_呼吸阻力.Items.AddRange(new object[] {
            "正常",
            "待修"});
            this.comboBox_呼吸阻力.Location = new System.Drawing.Point(716, 631);
            this.comboBox_呼吸阻力.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox_呼吸阻力.Name = "comboBox_呼吸阻力";
            this.comboBox_呼吸阻力.Size = new System.Drawing.Size(93, 27);
            this.comboBox_呼吸阻力.TabIndex = 39;
            // 
            // comboBox_报警器
            // 
            this.comboBox_报警器.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_报警器.FormattingEnabled = true;
            this.comboBox_报警器.Items.AddRange(new object[] {
            "正常",
            "待修"});
            this.comboBox_报警器.Location = new System.Drawing.Point(716, 593);
            this.comboBox_报警器.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox_报警器.Name = "comboBox_报警器";
            this.comboBox_报警器.Size = new System.Drawing.Size(93, 27);
            this.comboBox_报警器.TabIndex = 38;
            // 
            // comboBox_状态
            // 
            this.comboBox_状态.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_状态.FormattingEnabled = true;
            this.comboBox_状态.Items.AddRange(new object[] {
            "正常",
            "待修",
            "禁用"});
            this.comboBox_状态.Location = new System.Drawing.Point(716, 710);
            this.comboBox_状态.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox_状态.Name = "comboBox_状态";
            this.comboBox_状态.Size = new System.Drawing.Size(93, 27);
            this.comboBox_状态.TabIndex = 41;
            // 
            // comboBox_气密性
            // 
            this.comboBox_气密性.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_气密性.FormattingEnabled = true;
            this.comboBox_气密性.Items.AddRange(new object[] {
            "正常",
            "待修"});
            this.comboBox_气密性.Location = new System.Drawing.Point(716, 669);
            this.comboBox_气密性.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox_气密性.Name = "comboBox_气密性";
            this.comboBox_气密性.Size = new System.Drawing.Size(93, 27);
            this.comboBox_气密性.TabIndex = 40;
            // 
            // button_返回
            // 
            this.button_返回.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_返回.Location = new System.Drawing.Point(1142, 698);
            this.button_返回.Margin = new System.Windows.Forms.Padding(1);
            this.button_返回.Name = "button_返回";
            this.button_返回.Size = new System.Drawing.Size(82, 48);
            this.button_返回.TabIndex = 42;
            this.button_返回.Text = "返回";
            this.button_返回.UseVisualStyleBackColor = true;
            this.button_返回.Click += new System.EventHandler(this.button_返回_Click);
            // 
            // button_添加呼吸器
            // 
            this.button_添加呼吸器.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_添加呼吸器.Location = new System.Drawing.Point(866, 693);
            this.button_添加呼吸器.Margin = new System.Windows.Forms.Padding(1);
            this.button_添加呼吸器.Name = "button_添加呼吸器";
            this.button_添加呼吸器.Size = new System.Drawing.Size(137, 44);
            this.button_添加呼吸器.TabIndex = 43;
            this.button_添加呼吸器.Text = "添加呼吸器";
            this.button_添加呼吸器.UseVisualStyleBackColor = true;
            this.button_添加呼吸器.Click += new System.EventHandler(this.button_添加呼吸器_Click);
            // 
            // button_导出
            // 
            this.button_导出.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_导出.Location = new System.Drawing.Point(1107, 410);
            this.button_导出.Margin = new System.Windows.Forms.Padding(1);
            this.button_导出.Name = "button_导出";
            this.button_导出.Size = new System.Drawing.Size(155, 30);
            this.button_导出.TabIndex = 44;
            this.button_导出.Text = "导出";
            this.button_导出.UseVisualStyleBackColor = true;
            this.button_导出.Click += new System.EventHandler(this.button_导出_Click);
            // 
            // button_导入外部数据
            // 
            this.button_导入外部数据.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_导入外部数据.Location = new System.Drawing.Point(866, 756);
            this.button_导入外部数据.Name = "button_导入外部数据";
            this.button_导入外部数据.Size = new System.Drawing.Size(137, 44);
            this.button_导入外部数据.TabIndex = 45;
            this.button_导入外部数据.Text = "导入外部数据";
            this.button_导入外部数据.UseVisualStyleBackColor = true;
            this.button_导入外部数据.Click += new System.EventHandler(this.button_导入外部数据_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(716, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 46;
            this.textBox1.Visible = false;
            // 
            // 呼吸器管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_导入外部数据);
            this.Controls.Add(this.button_导出);
            this.Controls.Add(this.button_添加呼吸器);
            this.Controls.Add(this.button_返回);
            this.Controls.Add(this.comboBox_状态);
            this.Controls.Add(this.comboBox_气密性);
            this.Controls.Add(this.comboBox_呼吸阻力);
            this.Controls.Add(this.comboBox_报警器);
            this.Controls.Add(this.comboBox_压力表);
            this.Controls.Add(this.comboBox_面罩);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox_呼吸器类型);
            this.Controls.Add(this.textBox_上次测试日期);
            this.Controls.Add(this.textBox_入库日期);
            this.Controls.Add(this.textBox_出厂日期);
            this.Controls.Add(this.textBox_使用单位);
            this.Controls.Add(this.textBox_使用者);
            this.Controls.Add(this.textBox_产品型号);
            this.Controls.Add(this.textBox_制造商);
            this.Controls.Add(this.textBox_呼吸器编号);
            this.Controls.Add(this.textBox_呼吸器内部编号);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_编辑);
            this.Controls.Add(this.button_删除);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_查询);
            this.Controls.Add(this.textBox_查询索引);
            this.Controls.Add(this.comboBox_查询方式);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_输入提示);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "呼吸器管理";
            this.Text = "呼吸器管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.呼吸器管理_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_输入提示;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_查询方式;
        private System.Windows.Forms.TextBox textBox_查询索引;
        private System.Windows.Forms.Button button_查询;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_删除;
        private System.Windows.Forms.Button button_编辑;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_呼吸器内部编号;
        private System.Windows.Forms.TextBox textBox_呼吸器编号;
        private System.Windows.Forms.TextBox textBox_产品型号;
        private System.Windows.Forms.TextBox textBox_制造商;
        private System.Windows.Forms.TextBox textBox_使用单位;
        private System.Windows.Forms.TextBox textBox_使用者;
        private System.Windows.Forms.TextBox textBox_入库日期;
        private System.Windows.Forms.TextBox textBox_出厂日期;
        private System.Windows.Forms.TextBox textBox_呼吸器类型;
        private System.Windows.Forms.TextBox textBox_上次测试日期;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox_面罩;
        private System.Windows.Forms.ComboBox comboBox_压力表;
        private System.Windows.Forms.ComboBox comboBox_呼吸阻力;
        private System.Windows.Forms.ComboBox comboBox_报警器;
        private System.Windows.Forms.ComboBox comboBox_状态;
        private System.Windows.Forms.ComboBox comboBox_气密性;
        private System.Windows.Forms.Button button_返回;
        private System.Windows.Forms.Button button_添加呼吸器;
        private System.Windows.Forms.Button button_导出;
        private System.Windows.Forms.Button button_导入外部数据;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;

    }
}