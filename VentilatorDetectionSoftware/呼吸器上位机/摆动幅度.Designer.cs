namespace 呼吸器上位机
{
    partial class 摆动幅度
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
            this.呼吸频次 = new System.Windows.Forms.TrackBar();
            this.limit1 = new System.Windows.Forms.RadioButton();
            this.limit2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.吸气量 = new System.Windows.Forms.TrackBar();
            this.test = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.呼吸频次_text = new System.Windows.Forms.TextBox();
            this.吸气量_text = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reback = new System.Windows.Forms.Button();
            this.设定上限 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.呼吸频次)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.吸气量)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 呼吸频次
            // 
            this.呼吸频次.Location = new System.Drawing.Point(134, 101);
            this.呼吸频次.Name = "呼吸频次";
            this.呼吸频次.Size = new System.Drawing.Size(205, 45);
            this.呼吸频次.TabIndex = 0;
            this.呼吸频次.Scroll += new System.EventHandler(this.呼吸频次_Scroll);
            // 
            // limit1
            // 
            this.limit1.AutoSize = true;
            this.limit1.Location = new System.Drawing.Point(15, 20);
            this.limit1.Name = "limit1";
            this.limit1.Size = new System.Drawing.Size(215, 16);
            this.limit1.TabIndex = 1;
            this.limit1.TabStop = true;
            this.limit1.Text = "呼吸频次25 次/min 吸气量50L/min ";
            this.limit1.UseVisualStyleBackColor = true;
            this.limit1.CheckedChanged += new System.EventHandler(this.limit1_CheckedChanged);
            // 
            // limit2
            // 
            this.limit2.AutoSize = true;
            this.limit2.Location = new System.Drawing.Point(15, 62);
            this.limit2.Name = "limit2";
            this.limit2.Size = new System.Drawing.Size(221, 16);
            this.limit2.TabIndex = 2;
            this.limit2.TabStop = true;
            this.limit2.Text = "呼吸频次40 次/min 吸气量100L/min ";
            this.limit2.UseVisualStyleBackColor = true;
            this.limit2.CheckedChanged += new System.EventHandler(this.limit2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "动作频率（%）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "动作幅度（%）";
            // 
            // 吸气量
            // 
            this.吸气量.Location = new System.Drawing.Point(134, 152);
            this.吸气量.Name = "吸气量";
            this.吸气量.Size = new System.Drawing.Size(205, 45);
            this.吸气量.TabIndex = 4;
            this.吸气量.Scroll += new System.EventHandler(this.吸气量_Scroll);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(68, 203);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(75, 23);
            this.test.TabIndex = 6;
            this.test.Text = "测试";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(285, 203);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 7;
            this.confirm.Text = "确定";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // 呼吸频次_text
            // 
            this.呼吸频次_text.Location = new System.Drawing.Point(360, 101);
            this.呼吸频次_text.Name = "呼吸频次_text";
            this.呼吸频次_text.Size = new System.Drawing.Size(69, 21);
            this.呼吸频次_text.TabIndex = 10;
            this.呼吸频次_text.Text = "0";
            this.呼吸频次_text.TextChanged += new System.EventHandler(this.呼吸频次_text_TextChanged);
            this.呼吸频次_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.呼吸频次_text_KeyPress);
            // 
            // 吸气量_text
            // 
            this.吸气量_text.Location = new System.Drawing.Point(360, 143);
            this.吸气量_text.Name = "吸气量_text";
            this.吸气量_text.Size = new System.Drawing.Size(69, 21);
            this.吸气量_text.TabIndex = 11;
            this.吸气量_text.Text = "0";
            this.吸气量_text.TextChanged += new System.EventHandler(this.吸气量_text_TextChanged);
            this.吸气量_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.吸气量_text_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reback);
            this.groupBox1.Controls.Add(this.设定上限);
            this.groupBox1.Controls.Add(this.limit1);
            this.groupBox1.Controls.Add(this.吸气量_text);
            this.groupBox1.Controls.Add(this.limit2);
            this.groupBox1.Controls.Add(this.呼吸频次_text);
            this.groupBox1.Controls.Add(this.吸气量);
            this.groupBox1.Controls.Add(this.confirm);
            this.groupBox1.Controls.Add(this.呼吸频次);
            this.groupBox1.Controls.Add(this.test);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 247);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // reback
            // 
            this.reback.Location = new System.Drawing.Point(354, 54);
            this.reback.Name = "reback";
            this.reback.Size = new System.Drawing.Size(75, 23);
            this.reback.TabIndex = 13;
            this.reback.Text = "下位机反馈";
            this.reback.UseVisualStyleBackColor = true;
            this.reback.Click += new System.EventHandler(this.reback_Click);
            // 
            // 设定上限
            // 
            this.设定上限.Location = new System.Drawing.Point(354, 17);
            this.设定上限.Name = "设定上限";
            this.设定上限.Size = new System.Drawing.Size(75, 23);
            this.设定上限.TabIndex = 12;
            this.设定上限.Text = "设定上限";
            this.设定上限.UseVisualStyleBackColor = true;
            this.设定上限.Click += new System.EventHandler(this.设定上限_Click);
            // 
            // 摆动幅度
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 272);
            this.Controls.Add(this.groupBox1);
            this.Name = "摆动幅度";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "摆动幅度";
            this.Load += new System.EventHandler(this.摆动幅度_Load);
            ((System.ComponentModel.ISupportInitialize)(this.呼吸频次)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.吸气量)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar 呼吸频次;
        private System.Windows.Forms.RadioButton limit1;
        private System.Windows.Forms.RadioButton limit2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar 吸气量;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TextBox 呼吸频次_text;
        private System.Windows.Forms.TextBox 吸气量_text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button 设定上限;
        private System.Windows.Forms.Button reback;
    }
}