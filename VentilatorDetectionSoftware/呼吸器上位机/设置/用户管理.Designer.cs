namespace 呼吸器上位机.主界面单项
{
    partial class 用户管理
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_查询 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_返回 = new System.Windows.Forms.Button();
            this.comboBox_用户组 = new System.Windows.Forms.ComboBox();
            this.textBox_用户名字 = new System.Windows.Forms.TextBox();
            this.textBox_工号 = new System.Windows.Forms.TextBox();
            this.button_添加用户 = new System.Windows.Forms.Button();
            this.button_禁用 = new System.Windows.Forms.Button();
            this.button_编辑 = new System.Windows.Forms.Button();
            this.textBox_密码 = new System.Windows.Forms.TextBox();
            this.button_导出 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_用户名 = new System.Windows.Forms.TextBox();
            this.textBox_用户编号 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(624, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户管理";
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
            this.dataGridView1.Location = new System.Drawing.Point(212, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(591, 273);
            this.dataGridView1.TabIndex = 1;
            // 
            // button_查询
            // 
            this.button_查询.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_查询.Location = new System.Drawing.Point(467, 201);
            this.button_查询.Name = "button_查询";
            this.button_查询.Size = new System.Drawing.Size(87, 27);
            this.button_查询.TabIndex = 4;
            this.button_查询.Text = "查询";
            this.button_查询.UseVisualStyleBackColor = true;
            this.button_查询.Click += new System.EventHandler(this.button_查询_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(289, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "用户编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(308, 578);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "用户名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(321, 615);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "工号:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(321, 649);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "密码:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(302, 685);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "用户组:";
            // 
            // button_返回
            // 
            this.button_返回.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_返回.Location = new System.Drawing.Point(1026, 702);
            this.button_返回.Name = "button_返回";
            this.button_返回.Size = new System.Drawing.Size(150, 50);
            this.button_返回.TabIndex = 10;
            this.button_返回.Text = "返回";
            this.button_返回.UseVisualStyleBackColor = true;
            this.button_返回.Click += new System.EventHandler(this.button_返回_Click);
            // 
            // comboBox_用户组
            // 
            this.comboBox_用户组.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_用户组.FormattingEnabled = true;
            this.comboBox_用户组.Items.AddRange(new object[] {
            "操作员",
            "管理员",
            "制造商"});
            this.comboBox_用户组.Location = new System.Drawing.Point(389, 685);
            this.comboBox_用户组.Name = "comboBox_用户组";
            this.comboBox_用户组.Size = new System.Drawing.Size(100, 27);
            this.comboBox_用户组.TabIndex = 11;
            // 
            // textBox_用户名字
            // 
            this.textBox_用户名字.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_用户名字.Location = new System.Drawing.Point(389, 575);
            this.textBox_用户名字.Name = "textBox_用户名字";
            this.textBox_用户名字.Size = new System.Drawing.Size(100, 29);
            this.textBox_用户名字.TabIndex = 12;
            // 
            // textBox_工号
            // 
            this.textBox_工号.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_工号.Location = new System.Drawing.Point(389, 615);
            this.textBox_工号.Name = "textBox_工号";
            this.textBox_工号.Size = new System.Drawing.Size(100, 29);
            this.textBox_工号.TabIndex = 13;
            // 
            // button_添加用户
            // 
            this.button_添加用户.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_添加用户.Location = new System.Drawing.Point(559, 662);
            this.button_添加用户.Name = "button_添加用户";
            this.button_添加用户.Size = new System.Drawing.Size(150, 50);
            this.button_添加用户.TabIndex = 14;
            this.button_添加用户.Text = "添加用户";
            this.button_添加用户.UseVisualStyleBackColor = true;
            this.button_添加用户.Click += new System.EventHandler(this.button_添加用户_Click);
            // 
            // button_禁用
            // 
            this.button_禁用.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_禁用.Location = new System.Drawing.Point(833, 352);
            this.button_禁用.Name = "button_禁用";
            this.button_禁用.Size = new System.Drawing.Size(155, 30);
            this.button_禁用.TabIndex = 15;
            this.button_禁用.Text = "删除";
            this.button_禁用.UseVisualStyleBackColor = true;
            this.button_禁用.Click += new System.EventHandler(this.button_禁用_Click);
            // 
            // button_编辑
            // 
            this.button_编辑.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_编辑.Location = new System.Drawing.Point(833, 301);
            this.button_编辑.Name = "button_编辑";
            this.button_编辑.Size = new System.Drawing.Size(155, 30);
            this.button_编辑.TabIndex = 16;
            this.button_编辑.Text = "编辑";
            this.button_编辑.UseVisualStyleBackColor = true;
            this.button_编辑.Click += new System.EventHandler(this.button_编辑_Click);
            // 
            // textBox_密码
            // 
            this.textBox_密码.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_密码.Location = new System.Drawing.Point(389, 649);
            this.textBox_密码.Name = "textBox_密码";
            this.textBox_密码.Size = new System.Drawing.Size(100, 29);
            this.textBox_密码.TabIndex = 17;
            // 
            // button_导出
            // 
            this.button_导出.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_导出.Location = new System.Drawing.Point(833, 407);
            this.button_导出.Name = "button_导出";
            this.button_导出.Size = new System.Drawing.Size(155, 30);
            this.button_导出.TabIndex = 18;
            this.button_导出.Text = "导出";
            this.button_导出.UseVisualStyleBackColor = true;
            this.button_导出.Click += new System.EventHandler(this.button_导出_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(208, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "请输入用户名:";
            // 
            // textBox_用户名
            // 
            this.textBox_用户名.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_用户名.Location = new System.Drawing.Point(347, 199);
            this.textBox_用户名.Name = "textBox_用户名";
            this.textBox_用户名.Size = new System.Drawing.Size(100, 29);
            this.textBox_用户名.TabIndex = 20;
            // 
            // textBox_用户编号
            // 
            this.textBox_用户编号.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_用户编号.Location = new System.Drawing.Point(389, 537);
            this.textBox_用户编号.Name = "textBox_用户编号";
            this.textBox_用户编号.Size = new System.Drawing.Size(100, 29);
            this.textBox_用户编号.TabIndex = 22;
            // 
            // 用户管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_用户编号);
            this.Controls.Add(this.textBox_用户名);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_导出);
            this.Controls.Add(this.textBox_密码);
            this.Controls.Add(this.button_编辑);
            this.Controls.Add(this.button_禁用);
            this.Controls.Add(this.button_添加用户);
            this.Controls.Add(this.textBox_工号);
            this.Controls.Add(this.textBox_用户名字);
            this.Controls.Add(this.comboBox_用户组);
            this.Controls.Add(this.button_返回);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_查询);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "用户管理";
            this.Text = "用户管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.用户管理_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_查询;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_返回;
        private System.Windows.Forms.ComboBox comboBox_用户组;
        private System.Windows.Forms.TextBox textBox_用户名字;
        private System.Windows.Forms.TextBox textBox_工号;
        private System.Windows.Forms.Button button_添加用户;
        private System.Windows.Forms.Button button_禁用;
        private System.Windows.Forms.Button button_编辑;
        private System.Windows.Forms.TextBox textBox_密码;
        private System.Windows.Forms.Button button_导出;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_用户名;
        private System.Windows.Forms.TextBox textBox_用户编号;
    }
}