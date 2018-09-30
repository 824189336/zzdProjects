namespace 呼吸器上位机.主界面单项
{
    partial class 系统设置
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
            this.button_检验周期和提醒设置 = new System.Windows.Forms.Button();
            this.button_传感器校验 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_返回 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_检验周期和提醒设置
            // 
            this.button_检验周期和提醒设置.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_检验周期和提醒设置.Location = new System.Drawing.Point(319, 225);
            this.button_检验周期和提醒设置.Name = "button_检验周期和提醒设置";
            this.button_检验周期和提醒设置.Size = new System.Drawing.Size(205, 100);
            this.button_检验周期和提醒设置.TabIndex = 0;
            this.button_检验周期和提醒设置.Text = "检验周期和提醒设置";
            this.button_检验周期和提醒设置.UseVisualStyleBackColor = true;
            this.button_检验周期和提醒设置.Click += new System.EventHandler(this.button_检验周期和提醒设置_Click);
            // 
            // button_传感器校验
            // 
            this.button_传感器校验.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_传感器校验.Location = new System.Drawing.Point(716, 225);
            this.button_传感器校验.Name = "button_传感器校验";
            this.button_传感器校验.Size = new System.Drawing.Size(205, 100);
            this.button_传感器校验.TabIndex = 1;
            this.button_传感器校验.Text = "传感器校验";
            this.button_传感器校验.UseVisualStyleBackColor = true;
            this.button_传感器校验.Click += new System.EventHandler(this.button_传感器校验_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(544, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "系统设置";
            // 
            // button_返回
            // 
            this.button_返回.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_返回.Location = new System.Drawing.Point(1031, 671);
            this.button_返回.Name = "button_返回";
            this.button_返回.Size = new System.Drawing.Size(150, 50);
            this.button_返回.TabIndex = 3;
            this.button_返回.Text = "返回";
            this.button_返回.UseVisualStyleBackColor = true;
            this.button_返回.Click += new System.EventHandler(this.button_返回_Click);
            // 
            // 系统设置
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.button_返回);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_传感器校验);
            this.Controls.Add(this.button_检验周期和提醒设置);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "系统设置";
            this.Text = "系统设置";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.系统设置_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_检验周期和提醒设置;
        private System.Windows.Forms.Button button_传感器校验;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_返回;
    }
}