namespace KeyGenUI
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.p = new System.Windows.Forms.Button();
            this.n = new System.Windows.Forms.Button();
            this.r = new System.Windows.Forms.Button();
            this.q = new System.Windows.Forms.Button();
            this.co = new System.Windows.Forms.Button();
            this.rp = new System.Windows.Forms.Button();
            this.clearp = new System.Windows.Forms.Button();
            this.gpl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("宋体", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 117);
            this.textBox1.TabIndex = 100;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(12, 135);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(64, 33);
            this.p.TabIndex = 0;
            this.p.Text = "上一个";
            this.p.UseVisualStyleBackColor = true;
            this.p.Click += new System.EventHandler(this.p_Click);
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(121, 135);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(72, 32);
            this.n.TabIndex = 1;
            this.n.Text = "下一个";
            this.n.UseVisualStyleBackColor = true;
            this.n.Click += new System.EventHandler(this.n_Click);
            // 
            // r
            // 
            this.r.Location = new System.Drawing.Point(12, 174);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(62, 27);
            this.r.TabIndex = 2;
            this.r.Text = "复位";
            this.r.UseVisualStyleBackColor = true;
            this.r.Click += new System.EventHandler(this.r_Click);
            // 
            // q
            // 
            this.q.Location = new System.Drawing.Point(122, 174);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(70, 26);
            this.q.TabIndex = 3;
            this.q.Text = "退出";
            this.q.UseVisualStyleBackColor = true;
            this.q.Click += new System.EventHandler(this.q_Click);
            // 
            // co
            // 
            this.co.Location = new System.Drawing.Point(12, 206);
            this.co.Name = "co";
            this.co.Size = new System.Drawing.Size(64, 28);
            this.co.TabIndex = 4;
            this.co.Text = "确认密码";
            this.co.UseVisualStyleBackColor = true;
            this.co.Click += new System.EventHandler(this.co_Click);
            // 
            // rp
            // 
            this.rp.Location = new System.Drawing.Point(112, 209);
            this.rp.Name = "rp";
            this.rp.Size = new System.Drawing.Size(83, 24);
            this.rp.TabIndex = 5;
            this.rp.Text = "读取原密码";
            this.rp.UseVisualStyleBackColor = true;
            this.rp.Click += new System.EventHandler(this.rp_Click);
            // 
            // clearp
            // 
            this.clearp.Location = new System.Drawing.Point(12, 247);
            this.clearp.Name = "clearp";
            this.clearp.Size = new System.Drawing.Size(100, 27);
            this.clearp.TabIndex = 6;
            this.clearp.Text = "清空原确认密码";
            this.clearp.UseVisualStyleBackColor = true;
            this.clearp.Click += new System.EventHandler(this.clearp_Click);
            // 
            // gpl
            // 
            this.gpl.Location = new System.Drawing.Point(118, 239);
            this.gpl.Name = "gpl";
            this.gpl.Size = new System.Drawing.Size(84, 43);
            this.gpl.TabIndex = 101;
            this.gpl.Text = "GPL通知 / GPL Notice";
            this.gpl.UseVisualStyleBackColor = true;
            this.gpl.Click += new System.EventHandler(this.gpl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 290);
            this.Controls.Add(this.gpl);
            this.Controls.Add(this.clearp);
            this.Controls.Add(this.rp);
            this.Controls.Add(this.co);
            this.Controls.Add(this.q);
            this.Controls.Add(this.r);
            this.Controls.Add(this.n);
            this.Controls.Add(this.p);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "密码生成器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button p;
        private System.Windows.Forms.Button n;
        private System.Windows.Forms.Button r;
        private System.Windows.Forms.Button q;
        private System.Windows.Forms.Button co;
        private System.Windows.Forms.Button rp;
        private System.Windows.Forms.Button clearp;
        private System.Windows.Forms.Button gpl;
    }
}

