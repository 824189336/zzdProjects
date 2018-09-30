namespace 呼吸器上位机
{
    partial class 登录
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(登录));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_用户名 = new System.Windows.Forms.TextBox();
            this.textBox_密码 = new System.Windows.Forms.TextBox();
            this.button_登录 = new System.Windows.Forms.Button();
            this.button_关闭 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(58, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(93, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码：";
            // 
            // textBox_用户名
            // 
            this.textBox_用户名.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_用户名.Location = new System.Drawing.Point(244, 25);
            this.textBox_用户名.Name = "textBox_用户名";
            this.textBox_用户名.Size = new System.Drawing.Size(182, 47);
            this.textBox_用户名.TabIndex = 4;
            // 
            // textBox_密码
            // 
            this.textBox_密码.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_密码.Location = new System.Drawing.Point(244, 99);
            this.textBox_密码.Name = "textBox_密码";
            this.textBox_密码.Size = new System.Drawing.Size(182, 47);
            this.textBox_密码.TabIndex = 5;
            // 
            // button_登录
            // 
            this.button_登录.BackColor = System.Drawing.Color.Transparent;
            this.button_登录.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_登录.BackgroundImage")));
            this.button_登录.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_登录.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_登录.FlatAppearance.BorderSize = 0;
            this.button_登录.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_登录.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_登录.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_登录.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_登录.Location = new System.Drawing.Point(64, 194);
            this.button_登录.Name = "button_登录";
            this.button_登录.Size = new System.Drawing.Size(149, 56);
            this.button_登录.TabIndex = 6;
            this.button_登录.Text = "登录";
            this.button_登录.UseVisualStyleBackColor = false;
            this.button_登录.Click += new System.EventHandler(this.button_登录_Click);
            // 
            // button_关闭
            // 
            this.button_关闭.BackColor = System.Drawing.Color.Transparent;
            this.button_关闭.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_关闭.BackgroundImage")));
            this.button_关闭.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_关闭.FlatAppearance.BorderSize = 0;
            this.button_关闭.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_关闭.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_关闭.Location = new System.Drawing.Point(258, 194);
            this.button_关闭.Name = "button_关闭";
            this.button_关闭.Size = new System.Drawing.Size(168, 56);
            this.button_关闭.TabIndex = 7;
            this.button_关闭.Text = "关闭";
            this.button_关闭.UseVisualStyleBackColor = false;
            this.button_关闭.Click += new System.EventHandler(this.button_关闭_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_登录);
            this.groupBox1.Controls.Add(this.button_关闭);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_密码);
            this.groupBox1.Controls.Add(this.textBox_用户名);
            this.groupBox1.Location = new System.Drawing.Point(431, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 267);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // 登录
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::呼吸器上位机.Properties.Resources.登录背景;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "登录";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.登录_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_用户名;
        private System.Windows.Forms.TextBox textBox_密码;
        private System.Windows.Forms.Button button_登录;
        private System.Windows.Forms.Button button_关闭;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

