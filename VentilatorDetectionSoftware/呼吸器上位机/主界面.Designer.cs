namespace 呼吸器上位机
{
    partial class 主界面
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(主界面));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_设置 = new System.Windows.Forms.Button();
            this.button_扫描 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.呼吸器图片 = new System.Windows.Forms.DataGridViewImageColumn();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.使用单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.上次测试时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.检测员 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.制造商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进入 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_返回 = new System.Windows.Forms.Button();
            this.button_筛选 = new System.Windows.Forms.Button();
            this.label_待测呼吸器 = new System.Windows.Forms.Label();
            this.label_呼吸器总数 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_设置
            // 
            this.button_设置.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_设置.BackgroundImage")));
            this.button_设置.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_设置.Location = new System.Drawing.Point(13, 188);
            this.button_设置.Name = "button_设置";
            this.button_设置.Size = new System.Drawing.Size(72, 58);
            this.button_设置.TabIndex = 0;
            this.button_设置.UseVisualStyleBackColor = true;
            this.button_设置.Click += new System.EventHandler(this.button_设置_Click);
            // 
            // button_扫描
            // 
            this.button_扫描.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_扫描.BackgroundImage")));
            this.button_扫描.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_扫描.Location = new System.Drawing.Point(1181, 188);
            this.button_扫描.Name = "button_扫描";
            this.button_扫描.Size = new System.Drawing.Size(72, 58);
            this.button_扫描.TabIndex = 1;
            this.button_扫描.UseVisualStyleBackColor = true;
            this.button_扫描.Click += new System.EventHandler(this.button_扫描_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(30, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "待测呼吸器：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(547, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "呼吸器总数：";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.呼吸器图片,
            this.编号,
            this.型号,
            this.使用单位,
            this.上次测试时间,
            this.检测员,
            this.制造商,
            this.进入});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(13, 320);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1241, 526);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 呼吸器图片
            // 
            this.呼吸器图片.HeaderText = "图片";
            this.呼吸器图片.Image = ((System.Drawing.Image)(resources.GetObject("呼吸器图片.Image")));
            this.呼吸器图片.Name = "呼吸器图片";
            this.呼吸器图片.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.呼吸器图片.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 编号
            // 
            this.编号.DataPropertyName = "编号";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.编号.DefaultCellStyle = dataGridViewCellStyle3;
            this.编号.HeaderText = "编号";
            this.编号.Name = "编号";
            this.编号.Width = 150;
            // 
            // 型号
            // 
            this.型号.HeaderText = "型号";
            this.型号.Name = "型号";
            this.型号.Width = 150;
            // 
            // 使用单位
            // 
            this.使用单位.HeaderText = "使用单位";
            this.使用单位.Name = "使用单位";
            this.使用单位.Width = 200;
            // 
            // 上次测试时间
            // 
            this.上次测试时间.HeaderText = "上次测试时间";
            this.上次测试时间.Name = "上次测试时间";
            this.上次测试时间.Width = 200;
            // 
            // 检测员
            // 
            this.检测员.HeaderText = "检测员";
            this.检测员.Name = "检测员";
            this.检测员.Width = 150;
            // 
            // 制造商
            // 
            this.制造商.HeaderText = "制造商";
            this.制造商.Name = "制造商";
            this.制造商.Width = 150;
            // 
            // 进入
            // 
            this.进入.HeaderText = "进入";
            this.进入.Name = "进入";
            this.进入.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.进入.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.进入.UseColumnTextForButtonValue = true;
            // 
            // button_返回
            // 
            this.button_返回.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_返回.Location = new System.Drawing.Point(990, 864);
            this.button_返回.Name = "button_返回";
            this.button_返回.Size = new System.Drawing.Size(150, 50);
            this.button_返回.TabIndex = 10;
            this.button_返回.Text = "返回";
            this.button_返回.UseVisualStyleBackColor = true;
            this.button_返回.Click += new System.EventHandler(this.button_返回_Click);
            // 
            // button_筛选
            // 
            this.button_筛选.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_筛选.BackgroundImage")));
            this.button_筛选.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_筛选.Location = new System.Drawing.Point(1174, 854);
            this.button_筛选.Name = "button_筛选";
            this.button_筛选.Size = new System.Drawing.Size(80, 70);
            this.button_筛选.TabIndex = 11;
            this.button_筛选.UseVisualStyleBackColor = true;
            this.button_筛选.Click += new System.EventHandler(this.button_筛选_Click);
            // 
            // label_待测呼吸器
            // 
            this.label_待测呼吸器.AutoSize = true;
            this.label_待测呼吸器.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_待测呼吸器.Location = new System.Drawing.Point(170, 264);
            this.label_待测呼吸器.Name = "label_待测呼吸器";
            this.label_待测呼吸器.Size = new System.Drawing.Size(66, 31);
            this.label_待测呼吸器.TabIndex = 12;
            this.label_待测呼吸器.Text = "21件";
            // 
            // label_呼吸器总数
            // 
            this.label_呼吸器总数.AutoSize = true;
            this.label_呼吸器总数.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_呼吸器总数.Location = new System.Drawing.Point(687, 268);
            this.label_呼吸器总数.Name = "label_呼吸器总数";
            this.label_呼吸器总数.Size = new System.Drawing.Size(80, 31);
            this.label_呼吸器总数.TabIndex = 13;
            this.label_呼吸器总数.Text = "121件";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1084, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // 主界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_呼吸器总数);
            this.Controls.Add(this.label_待测呼吸器);
            this.Controls.Add(this.button_筛选);
            this.Controls.Add(this.button_返回);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_扫描);
            this.Controls.Add(this.button_设置);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "主界面";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.主界面_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_设置;
        private System.Windows.Forms.Button button_扫描;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_返回;
        private System.Windows.Forms.Button button_筛选;
        private System.Windows.Forms.Label label_待测呼吸器;
        private System.Windows.Forms.Label label_呼吸器总数;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewImageColumn 呼吸器图片;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 使用单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 上次测试时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 检测员;
        private System.Windows.Forms.DataGridViewTextBoxColumn 制造商;
        private System.Windows.Forms.DataGridViewButtonColumn 进入;
    }
}