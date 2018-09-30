namespace 呼吸器上位机
{
    partial class 倒计时器
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
            this.倒计时项目 = new System.Windows.Forms.Label();
            this.倒计时时间 = new System.Windows.Forms.Label();
            this.进度条 = new System.Windows.Forms.ProgressBar();
            this.返回键 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 倒计时项目
            // 
            this.倒计时项目.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.倒计时项目.Location = new System.Drawing.Point(12, 21);
            this.倒计时项目.Name = "倒计时项目";
            this.倒计时项目.Size = new System.Drawing.Size(364, 45);
            this.倒计时项目.TabIndex = 0;
            this.倒计时项目.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 倒计时时间
            // 
            this.倒计时时间.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.倒计时时间.Location = new System.Drawing.Point(36, 128);
            this.倒计时时间.Name = "倒计时时间";
            this.倒计时时间.Size = new System.Drawing.Size(294, 34);
            this.倒计时时间.TabIndex = 1;
            this.倒计时时间.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.倒计时时间.Click += new System.EventHandler(this.倒计时时间_Click);
            // 
            // 进度条
            // 
            this.进度条.Location = new System.Drawing.Point(27, 74);
            this.进度条.Name = "进度条";
            this.进度条.Size = new System.Drawing.Size(321, 37);
            this.进度条.TabIndex = 2;
            this.进度条.Click += new System.EventHandler(this.进度条_Click);
            // 
            // 返回键
            // 
            this.返回键.Location = new System.Drawing.Point(128, 175);
            this.返回键.Name = "返回键";
            this.返回键.Size = new System.Drawing.Size(113, 39);
            this.返回键.TabIndex = 3;
            this.返回键.Text = "正在倒计时...";
            this.返回键.UseVisualStyleBackColor = true;
            // 
            // 倒计时器
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 222);
            this.Controls.Add(this.返回键);
            this.Controls.Add(this.进度条);
            this.Controls.Add(this.倒计时时间);
            this.Controls.Add(this.倒计时项目);
            this.Name = "倒计时器";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "倒计时提醒";
            this.Load += new System.EventHandler(this.倒计时器_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label 倒计时项目;
        private System.Windows.Forms.Label 倒计时时间;
        private System.Windows.Forms.ProgressBar 进度条;
        private System.Windows.Forms.Button 返回键;
    }
}