namespace 呼吸器上位机
{
    partial class 单个界面
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lable_呼吸器编号 = new System.Windows.Forms.Label();
            this.label_呼吸器型号 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.检测日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.检验员 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状况 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_所有测试 = new System.Windows.Forms.Button();
            this.button_返回 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lable_呼吸器编号);
            this.groupBox1.Controls.Add(this.label_呼吸器型号);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "呼吸器资料";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lable_呼吸器编号
            // 
            this.lable_呼吸器编号.AutoSize = true;
            this.lable_呼吸器编号.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable_呼吸器编号.Location = new System.Drawing.Point(163, 89);
            this.lable_呼吸器编号.Name = "lable_呼吸器编号";
            this.lable_呼吸器编号.Size = new System.Drawing.Size(120, 25);
            this.lable_呼吸器编号.TabIndex = 3;
            this.lable_呼吸器编号.Text = "XXXXXXXXX";
            // 
            // label_呼吸器型号
            // 
            this.label_呼吸器型号.AutoSize = true;
            this.label_呼吸器型号.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_呼吸器型号.Location = new System.Drawing.Point(163, 44);
            this.label_呼吸器型号.Name = "label_呼吸器型号";
            this.label_呼吸器型号.Size = new System.Drawing.Size(108, 25);
            this.label_呼吸器型号.TabIndex = 2;
            this.label_呼吸器型号.Text = "XXXXXXXX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "呼吸器编号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "呼吸器型号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1240, 435);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "历史测试数据";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.检测日期,
            this.检验员,
            this.状况});
            this.dataGridView1.Location = new System.Drawing.Point(6, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1228, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 检测日期
            // 
            this.检测日期.HeaderText = "检测日期";
            this.检测日期.Name = "检测日期";
            this.检测日期.Width = 200;
            // 
            // 检验员
            // 
            this.检验员.HeaderText = "检验员";
            this.检验员.Name = "检验员";
            this.检验员.Width = 200;
            // 
            // 状况
            // 
            this.状况.HeaderText = "状况";
            this.状况.Name = "状况";
            this.状况.Width = 500;
            // 
            // button_所有测试
            // 
            this.button_所有测试.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_所有测试.Location = new System.Drawing.Point(1046, 817);
            this.button_所有测试.Name = "button_所有测试";
            this.button_所有测试.Size = new System.Drawing.Size(200, 50);
            this.button_所有测试.TabIndex = 2;
            this.button_所有测试.Text = "进行检测";
            this.button_所有测试.UseVisualStyleBackColor = true;
            this.button_所有测试.Click += new System.EventHandler(this.button_所有测试_Click);
            // 
            // button_返回
            // 
            this.button_返回.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_返回.Location = new System.Drawing.Point(18, 817);
            this.button_返回.Name = "button_返回";
            this.button_返回.Size = new System.Drawing.Size(200, 50);
            this.button_返回.TabIndex = 3;
            this.button_返回.Text = "返回";
            this.button_返回.UseVisualStyleBackColor = true;
            this.button_返回.Click += new System.EventHandler(this.button_返回_Click);
            // 
            // 单个界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.button_返回);
            this.Controls.Add(this.button_所有测试);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "单个界面";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "单个界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.单个界面_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lable_呼吸器编号;
        private System.Windows.Forms.Label label_呼吸器型号;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_所有测试;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_返回;
        private System.Windows.Forms.DataGridViewTextBoxColumn 检测日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 检验员;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状况;
    }
}