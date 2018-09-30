namespace 呼吸器上位机.主界面单项
{
    partial class 测试记录
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
            this.button_查询 = new System.Windows.Forms.Button();
            this.textBox_查询索引 = new System.Windows.Forms.TextBox();
            this.comboBox_查询方式 = new System.Windows.Forms.ComboBox();
            this.label_请输入 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_返回 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_查询
            // 
            this.button_查询.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_查询.Location = new System.Drawing.Point(850, 253);
            this.button_查询.Name = "button_查询";
            this.button_查询.Size = new System.Drawing.Size(94, 31);
            this.button_查询.TabIndex = 13;
            this.button_查询.Text = "查询";
            this.button_查询.UseVisualStyleBackColor = true;
            this.button_查询.Click += new System.EventHandler(this.button_查询_Click);
            // 
            // textBox_查询索引
            // 
            this.textBox_查询索引.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_查询索引.Location = new System.Drawing.Point(675, 253);
            this.textBox_查询索引.Name = "textBox_查询索引";
            this.textBox_查询索引.Size = new System.Drawing.Size(125, 29);
            this.textBox_查询索引.TabIndex = 12;
            // 
            // comboBox_查询方式
            // 
            this.comboBox_查询方式.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_查询方式.FormattingEnabled = true;
            this.comboBox_查询方式.Items.AddRange(new object[] {
            "呼吸器编号",
            "测试时间",
            "测试人员",
            "测试结果",
            "型号",
            "制造商"});
            this.comboBox_查询方式.Location = new System.Drawing.Point(418, 254);
            this.comboBox_查询方式.Name = "comboBox_查询方式";
            this.comboBox_查询方式.Size = new System.Drawing.Size(121, 27);
            this.comboBox_查询方式.TabIndex = 11;
            // 
            // label_请输入
            // 
            this.label_请输入.AutoSize = true;
            this.label_请输入.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_请输入.Location = new System.Drawing.Point(560, 256);
            this.label_请输入.Name = "label_请输入";
            this.label_请输入.Size = new System.Drawing.Size(85, 19);
            this.label_请输入.TabIndex = 10;
            this.label_请输入.Text = "请输入：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(308, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "查询方式：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(558, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "测试记录";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(303, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(714, 228);
            this.dataGridView1.TabIndex = 15;
            // 
            // button_返回
            // 
            this.button_返回.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_返回.Location = new System.Drawing.Point(867, 557);
            this.button_返回.Name = "button_返回";
            this.button_返回.Size = new System.Drawing.Size(150, 53);
            this.button_返回.TabIndex = 16;
            this.button_返回.Text = "返回";
            this.button_返回.UseVisualStyleBackColor = true;
            this.button_返回.Click += new System.EventHandler(this.button_返回_Click);
            // 
            // 测试记录
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.button_返回);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_查询);
            this.Controls.Add(this.textBox_查询索引);
            this.Controls.Add(this.comboBox_查询方式);
            this.Controls.Add(this.label_请输入);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "测试记录";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "测试记录";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.测试记录_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_查询;
        private System.Windows.Forms.TextBox textBox_查询索引;
        private System.Windows.Forms.ComboBox comboBox_查询方式;
        private System.Windows.Forms.Label label_请输入;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_返回;
    }
}