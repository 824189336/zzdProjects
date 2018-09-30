namespace 呼吸器上位机.提示
{
    partial class 扫描
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
            this.textBox_呼吸器编号 = new System.Windows.Forms.TextBox();
            this.button_输入确认 = new System.Windows.Forms.Button();
            this.button_取消 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(501, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "请扫描面罩上的二维码：";
            // 
            // textBox_呼吸器编号
            // 
            this.textBox_呼吸器编号.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_呼吸器编号.Location = new System.Drawing.Point(468, 376);
            this.textBox_呼吸器编号.Name = "textBox_呼吸器编号";
            this.textBox_呼吸器编号.Size = new System.Drawing.Size(403, 47);
            this.textBox_呼吸器编号.TabIndex = 1;
            this.textBox_呼吸器编号.Text = "1";
            this.textBox_呼吸器编号.TextChanged += new System.EventHandler(this.textBox_呼吸器编号_TextChanged);
            // 
            // button_输入确认
            // 
            this.button_输入确认.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_输入确认.Location = new System.Drawing.Point(838, 476);
            this.button_输入确认.Name = "button_输入确认";
            this.button_输入确认.Size = new System.Drawing.Size(150, 50);
            this.button_输入确认.TabIndex = 2;
            this.button_输入确认.Text = "确认";
            this.button_输入确认.UseVisualStyleBackColor = true;
            this.button_输入确认.Click += new System.EventHandler(this.button_输入确认_Click);
            // 
            // button_取消
            // 
            this.button_取消.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_取消.Location = new System.Drawing.Point(388, 476);
            this.button_取消.Name = "button_取消";
            this.button_取消.Size = new System.Drawing.Size(150, 50);
            this.button_取消.TabIndex = 3;
            this.button_取消.Text = "取消";
            this.button_取消.UseVisualStyleBackColor = true;
            this.button_取消.Click += new System.EventHandler(this.button_取消_Click);
            // 
            // 扫描
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.button_取消);
            this.Controls.Add(this.button_输入确认);
            this.Controls.Add(this.textBox_呼吸器编号);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "扫描";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "扫描";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.扫描_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_呼吸器编号;
        private System.Windows.Forms.Button button_输入确认;
        private System.Windows.Forms.Button button_取消;
    }
}