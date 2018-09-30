namespace 呼吸器上位机.主界面单项
{
    partial class 更改密码
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_返回 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_原密码 = new System.Windows.Forms.TextBox();
            this.button_原密码 = new System.Windows.Forms.Button();
            this.button_新密码 = new System.Windows.Forms.Button();
            this.textBox_新密码 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(556, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "更改密码";
            // 
            // button_返回
            // 
            this.button_返回.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_返回.Location = new System.Drawing.Point(942, 638);
            this.button_返回.Name = "button_返回";
            this.button_返回.Size = new System.Drawing.Size(150, 50);
            this.button_返回.TabIndex = 1;
            this.button_返回.Text = "返回";
            this.button_返回.UseVisualStyleBackColor = true;
            this.button_返回.Click += new System.EventHandler(this.button_返回_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(400, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "输入原密码：";
            // 
            // textBox_原密码
            // 
            this.textBox_原密码.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_原密码.Location = new System.Drawing.Point(562, 264);
            this.textBox_原密码.Name = "textBox_原密码";
            this.textBox_原密码.Size = new System.Drawing.Size(100, 31);
            this.textBox_原密码.TabIndex = 3;
            this.textBox_原密码.TextChanged += new System.EventHandler(this.textBox_原密码_TextChanged);
            // 
            // button_原密码
            // 
            this.button_原密码.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_原密码.Location = new System.Drawing.Point(703, 257);
            this.button_原密码.Name = "button_原密码";
            this.button_原密码.Size = new System.Drawing.Size(100, 40);
            this.button_原密码.TabIndex = 4;
            this.button_原密码.Text = "确定";
            this.button_原密码.UseVisualStyleBackColor = true;
            this.button_原密码.Click += new System.EventHandler(this.button_原密码_Click);
            // 
            // button_新密码
            // 
            this.button_新密码.Enabled = false;
            this.button_新密码.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_新密码.Location = new System.Drawing.Point(703, 342);
            this.button_新密码.Name = "button_新密码";
            this.button_新密码.Size = new System.Drawing.Size(100, 40);
            this.button_新密码.TabIndex = 7;
            this.button_新密码.Text = "确定";
            this.button_新密码.UseVisualStyleBackColor = true;
            this.button_新密码.Click += new System.EventHandler(this.button_新密码_Click);
            // 
            // textBox_新密码
            // 
            this.textBox_新密码.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_新密码.Location = new System.Drawing.Point(562, 349);
            this.textBox_新密码.Name = "textBox_新密码";
            this.textBox_新密码.Size = new System.Drawing.Size(100, 31);
            this.textBox_新密码.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(400, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "输入新密码：";
            // 
            // 更改密码
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.button_新密码);
            this.Controls.Add(this.textBox_新密码);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_原密码);
            this.Controls.Add(this.textBox_原密码);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_返回);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "更改密码";
            this.Text = "更改密码";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.更改密码_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_返回;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_原密码;
        private System.Windows.Forms.Button button_原密码;
        private System.Windows.Forms.Button button_新密码;
        private System.Windows.Forms.TextBox textBox_新密码;
        private System.Windows.Forms.Label label3;
    }
}