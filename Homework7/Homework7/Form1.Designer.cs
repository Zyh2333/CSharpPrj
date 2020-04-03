namespace Homework7
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.dLeftBox = new System.Windows.Forms.TextBox();
            this.dRightBox = new System.Windows.Forms.TextBox();
            this.lPerBox = new System.Windows.Forms.TextBox();
            this.rPerBox = new System.Windows.Forms.TextBox();
            this.lBox = new System.Windows.Forms.TextBox();
            this.dBox = new System.Windows.Forms.TextBox();
            this.pen = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.deepth = new System.Windows.Forms.Label();
            this.dLeft = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.Label();
            this.dRight = new System.Windows.Forms.Label();
            this.rPer = new System.Windows.Forms.Label();
            this.lPer = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.create);
            this.panel1.Controls.Add(this.dLeftBox);
            this.panel1.Controls.Add(this.dRightBox);
            this.panel1.Controls.Add(this.lPerBox);
            this.panel1.Controls.Add(this.rPerBox);
            this.panel1.Controls.Add(this.lBox);
            this.panel1.Controls.Add(this.dBox);
            this.panel1.Controls.Add(this.pen);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.deepth);
            this.panel1.Controls.Add(this.dLeft);
            this.panel1.Controls.Add(this.length);
            this.panel1.Controls.Add(this.dRight);
            this.panel1.Controls.Add(this.rPer);
            this.panel1.Controls.Add(this.lPer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 450);
            this.panel1.TabIndex = 0;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(133, 365);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 15;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(16, 366);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 7;
            this.create.Text = "create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // dLeftBox
            // 
            this.dLeftBox.Location = new System.Drawing.Point(81, 251);
            this.dLeftBox.Name = "dLeftBox";
            this.dLeftBox.Size = new System.Drawing.Size(100, 25);
            this.dLeftBox.TabIndex = 14;
            // 
            // dRightBox
            // 
            this.dRightBox.Location = new System.Drawing.Point(81, 202);
            this.dRightBox.Name = "dRightBox";
            this.dRightBox.Size = new System.Drawing.Size(100, 25);
            this.dRightBox.TabIndex = 13;
            // 
            // lPerBox
            // 
            this.lPerBox.Location = new System.Drawing.Point(81, 160);
            this.lPerBox.Name = "lPerBox";
            this.lPerBox.Size = new System.Drawing.Size(100, 25);
            this.lPerBox.TabIndex = 12;
            // 
            // rPerBox
            // 
            this.rPerBox.Location = new System.Drawing.Point(81, 114);
            this.rPerBox.Name = "rPerBox";
            this.rPerBox.Size = new System.Drawing.Size(100, 25);
            this.rPerBox.TabIndex = 11;
            // 
            // lBox
            // 
            this.lBox.Location = new System.Drawing.Point(81, 68);
            this.lBox.Name = "lBox";
            this.lBox.Size = new System.Drawing.Size(100, 25);
            this.lBox.TabIndex = 10;
            // 
            // dBox
            // 
            this.dBox.Location = new System.Drawing.Point(81, 25);
            this.dBox.Name = "dBox";
            this.dBox.Size = new System.Drawing.Size(100, 25);
            this.dBox.TabIndex = 9;
            // 
            // pen
            // 
            this.pen.AutoSize = true;
            this.pen.Location = new System.Drawing.Point(13, 291);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(31, 15);
            this.pen.TabIndex = 8;
            this.pen.Text = "pen";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "蓝色",
            "绿色",
            "黑色"});
            this.comboBox1.Location = new System.Drawing.Point(81, 291);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // deepth
            // 
            this.deepth.AutoSize = true;
            this.deepth.Location = new System.Drawing.Point(13, 25);
            this.deepth.Name = "deepth";
            this.deepth.Size = new System.Drawing.Size(55, 15);
            this.deepth.TabIndex = 1;
            this.deepth.Text = "deepth";
            // 
            // dLeft
            // 
            this.dLeft.AutoSize = true;
            this.dLeft.Location = new System.Drawing.Point(13, 251);
            this.dLeft.Name = "dLeft";
            this.dLeft.Size = new System.Drawing.Size(47, 15);
            this.dLeft.TabIndex = 6;
            this.dLeft.Text = "dLeft";
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Location = new System.Drawing.Point(13, 68);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(55, 15);
            this.length.TabIndex = 2;
            this.length.Text = "length";
            // 
            // dRight
            // 
            this.dRight.AutoSize = true;
            this.dRight.Location = new System.Drawing.Point(13, 202);
            this.dRight.Name = "dRight";
            this.dRight.Size = new System.Drawing.Size(55, 15);
            this.dRight.TabIndex = 5;
            this.dRight.Text = "dRight";
            // 
            // rPer
            // 
            this.rPer.AutoSize = true;
            this.rPer.Location = new System.Drawing.Point(13, 114);
            this.rPer.Name = "rPer";
            this.rPer.Size = new System.Drawing.Size(39, 15);
            this.rPer.TabIndex = 3;
            this.rPer.Text = "rPer";
            // 
            // lPer
            // 
            this.lPer.AutoSize = true;
            this.lPer.Location = new System.Drawing.Point(13, 160);
            this.lPer.Name = "lPer";
            this.lPer.Size = new System.Drawing.Size(39, 15);
            this.lPer.TabIndex = 4;
            this.lPer.Text = "lPer";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(233, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 450);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label deepth;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.Label rPer;
        private System.Windows.Forms.Label lPer;
        private System.Windows.Forms.Label dRight;
        private System.Windows.Forms.Label pen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label dLeft;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox dLeftBox;
        private System.Windows.Forms.TextBox dRightBox;
        private System.Windows.Forms.TextBox lPerBox;
        private System.Windows.Forms.TextBox rPerBox;
        private System.Windows.Forms.TextBox lBox;
        private System.Windows.Forms.TextBox dBox;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Panel panel2;
    }
}

