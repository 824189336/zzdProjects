﻿namespace 呼吸器上位机
{
    partial class 摆动幅度上限输入
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.limit1_呼吸频次_Max = new System.Windows.Forms.TextBox();
            this.limit1_吸气量_Max = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.limit2_吸气量_Max = new System.Windows.Forms.TextBox();
            this.limit2_呼吸频次_Max = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "呼吸频次";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "次/min 吸气量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "L/min";
            // 
            // limit1_呼吸频次_Max
            // 
            this.limit1_呼吸频次_Max.Location = new System.Drawing.Point(120, 14);
            this.limit1_呼吸频次_Max.Name = "limit1_呼吸频次_Max";
            this.limit1_呼吸频次_Max.Size = new System.Drawing.Size(61, 21);
            this.limit1_呼吸频次_Max.TabIndex = 3;
            this.limit1_呼吸频次_Max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.limit1_呼吸频次_Max_KeyPress);
            // 
            // limit1_吸气量_Max
            // 
            this.limit1_吸气量_Max.Location = new System.Drawing.Point(277, 14);
            this.limit1_吸气量_Max.Name = "limit1_吸气量_Max";
            this.limit1_吸气量_Max.Size = new System.Drawing.Size(63, 21);
            this.limit1_吸气量_Max.TabIndex = 4;
            this.limit1_吸气量_Max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.limit1_吸气量_Max_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.limit1_吸气量_Max);
            this.groupBox1.Controls.Add(this.limit1_呼吸频次_Max);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "上限1:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.limit2_吸气量_Max);
            this.groupBox2.Controls.Add(this.limit2_呼吸频次_Max);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 44);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "上限2:";
            // 
            // limit2_吸气量_Max
            // 
            this.limit2_吸气量_Max.Location = new System.Drawing.Point(277, 14);
            this.limit2_吸气量_Max.Name = "limit2_吸气量_Max";
            this.limit2_吸气量_Max.Size = new System.Drawing.Size(63, 21);
            this.limit2_吸气量_Max.TabIndex = 4;
            this.limit2_吸气量_Max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.limit2_吸气量_Max_KeyPress);
            // 
            // limit2_呼吸频次_Max
            // 
            this.limit2_呼吸频次_Max.Location = new System.Drawing.Point(120, 14);
            this.limit2_呼吸频次_Max.Name = "limit2_呼吸频次_Max";
            this.limit2_呼吸频次_Max.Size = new System.Drawing.Size(61, 21);
            this.limit2_呼吸频次_Max.TabIndex = 3;
            this.limit2_呼吸频次_Max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.limit2_呼吸频次_Max_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "L/min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "次/min 吸气量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "呼吸频次";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "清除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "确定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 摆动幅度上限输入
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 183);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "摆动幅度上限输入";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "摆动幅度上限输入";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox limit1_呼吸频次_Max;
        private System.Windows.Forms.TextBox limit1_吸气量_Max;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox limit2_吸气量_Max;
        private System.Windows.Forms.TextBox limit2_呼吸频次_Max;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}