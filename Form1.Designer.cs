namespace BullShitGenerater
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
            this.richTextBoxBody = new System.Windows.Forms.RichTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxLength = new System.Windows.Forms.TextBox();
            this.comboBoxLanguege = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxBody
            // 
            this.richTextBoxBody.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxBody.Name = "richTextBoxBody";
            this.richTextBoxBody.ReadOnly = true;
            this.richTextBoxBody.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxBody.Size = new System.Drawing.Size(562, 412);
            this.richTextBoxBody.TabIndex = 0;
            this.richTextBoxBody.Text = "";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(582, 380);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(189, 44);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "生成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(627, 12);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(142, 21);
            this.txtBoxTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "标题：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "字数：";
            // 
            // txtBoxLength
            // 
            this.txtBoxLength.Location = new System.Drawing.Point(627, 39);
            this.txtBoxLength.Name = "txtBoxLength";
            this.txtBoxLength.Size = new System.Drawing.Size(142, 21);
            this.txtBoxLength.TabIndex = 5;
            // 
            // comboBoxLanguege
            // 
            this.comboBoxLanguege.FormattingEnabled = true;
            this.comboBoxLanguege.Items.AddRange(new object[] {
            "中文",
            "English"});
            this.comboBoxLanguege.Location = new System.Drawing.Point(580, 84);
            this.comboBoxLanguege.Name = "comboBoxLanguege";
            this.comboBoxLanguege.Size = new System.Drawing.Size(189, 20);
            this.comboBoxLanguege.TabIndex = 6;
            this.comboBoxLanguege.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "语言（Languege）：";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 436);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxLanguege);
            this.Controls.Add(this.txtBoxLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.richTextBoxBody);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "狗屁不通文章生成器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxBody;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxLength;
        private System.Windows.Forms.ComboBox comboBoxLanguege;
        private System.Windows.Forms.Label label3;
    }
}

