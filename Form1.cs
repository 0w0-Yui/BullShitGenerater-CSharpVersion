using System;
using System.Drawing;
using System.Windows.Forms;

namespace BullShitGenerater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string str = "adjowjdioadjoiwdijoaidowid\r\n";
            str.EndsWith("\r\n");
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxTitle.Text != "")
                {
                    Generate.title = txtBoxTitle.Text;
                    string body =
                    Generate.GenerateBody(int.Parse(txtBoxLength.Text));
                    richTextBoxBody.Text = Generate.title + Environment.NewLine;
                    richTextBoxBody.AppendText(body);
                    richTextBoxBody.SelectAll();
                    richTextBoxBody.SelectionAlignment = HorizontalAlignment.Left;
                    richTextBoxBody.SelectionFont = new Font("宋体", 12);
                    richTextBoxBody.Select(0, Generate.title.Length);
                    richTextBoxBody.SelectionAlignment = HorizontalAlignment.Center;
                    richTextBoxBody.SelectionFont = new Font("黑体", 16);
                }
                else
                    MessageBox.Show("请输入标题", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("请输入正确的字数", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
