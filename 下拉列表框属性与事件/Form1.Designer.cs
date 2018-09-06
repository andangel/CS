namespace 下拉列表框属性与事件
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
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(178, 54);
            this.ComboBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(508, 32);
            this.ComboBox1.TabIndex = 0;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(60, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "城市";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(438, 556);
            this.Button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(320, 46);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "SelectedItem";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(44, 556);
            this.Button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(320, 46);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "Text";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ComboBox2
            // 
            this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Location = new System.Drawing.Point(178, 168);
            this.ComboBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(508, 32);
            this.ComboBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(60, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "联动";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 646);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBox2);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox下拉列表框";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.ComboBox ComboBox2;
        private System.Windows.Forms.Label label2;
    }
}

