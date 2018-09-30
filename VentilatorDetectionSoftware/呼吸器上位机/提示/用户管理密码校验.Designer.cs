namespace 呼吸器上位机.提示
{
    partial class 用户管理密码校验
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
            this.button_确定 = new System.Windows.Forms.Button();
            this.button_退出 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_密码 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_账号 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_确定
            // 
            this.button_确定.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_确定.Location = new System.Drawing.Point(390, 508);
            this.button_确定.Name = "button_确定";
            this.button_确定.Size = new System.Drawing.Size(144, 52);
            this.button_确定.TabIndex = 0;
            this.button_确定.Text = "确定";
            this.button_确定.UseVisualStyleBackColor = true;
            this.button_确定.Click += new System.EventHandler(this.button_确定_Click);
            // 
            // button_退出
            // 
            this.button_退出.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_退出.Location = new System.Drawing.Point(703, 508);
            this.button_退出.Name = "button_退出";
            this.button_退出.Size = new System.Drawing.Size(144, 52);
            this.button_退出.TabIndex = 1;
            this.button_退出.Text = "退出";
            this.button_退出.UseVisualStyleBackColor = true;
            this.button_退出.Click += new System.EventHandler(this.button_退出_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(290, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "管理员或制造商密码：";
            // 
            // textBox_密码
            // 
            this.textBox_密码.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_密码.Location = new System.Drawing.Point(684, 376);
            this.textBox_密码.Name = "textBox_密码";
            this.textBox_密码.Size = new System.Drawing.Size(239, 47);
            this.textBox_密码.TabIndex = 3;
            this.textBox_密码.Text = "123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(290, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "管理员或制造商账号：";
            // 
            // textBox_账号
            // 
            this.textBox_账号.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_账号.Location = new System.Drawing.Point(684, 297);
            this.textBox_账号.Name = "textBox_账号";
            this.textBox_账号.Size = new System.Drawing.Size(239, 47);
            this.textBox_账号.TabIndex = 5;
            this.textBox_账号.Text = "abc";
            // 
            // 用户管理密码校验
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.textBox_账号);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_密码);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_退出);
            this.Controls.Add(this.button_确定);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "用户管理密码校验";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理密码校验";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.用户管理密码校验_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_确定;
        private System.Windows.Forms.Button button_退出;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_密码;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_账号;
    }
}