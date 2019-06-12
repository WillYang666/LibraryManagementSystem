using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class WriteComment : Form
    {
        public WriteComment()
        {
            InitializeComponent();
            //皮肤
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }

        private void textBox_BookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void WriteComment_Load(object sender, EventArgs e)
        {
            ReturnBook ab = new ReturnBook();
            textBox_BookName.Text = PublicPassBy.IMDB_Bookname;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null && textBox_Rate != null)
            {
                string sql = "insert into IMDB values('" + richTextBox1.Text.ToString() + "','" + PublicPassBy.IMDB_Bookname + "','" + PublicPassBy.IMDB_Bookid + "','" + PublicPassBy.id + "','" + textBox_Rate + "')";
                DataBaseApplication.ExecuteNonQuery(sql);
                DialogResult result = MessageBox.Show("确认提交？", "温馨提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    //执行删除语句
                    MessageBox.Show("提交成功！");
                }
            }
            else MessageBox.Show("请先填写完整！");
           
            this.Close();
        }

        private void textBox_Rate_TextChanged(object sender, EventArgs e)
        {
            
        }
        //默认文本框
        #region
        private void textBox_Rate_Enter(object sender, EventArgs e)
        {
            if (this.textBox_Rate.Text == "请您打分（0-5）！")
            {
                this.textBox_Rate.Text = "";
            }
        }

        private void textBox_Rate_Leave(object sender, EventArgs e)
        {
            if (this.textBox_Rate.Text.Length == 0)
            {
                this.textBox_Rate.Text = "请您打分（0-5）！";
            }
        }
        #endregion

        private void textBox_Rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只允许输入0～9中间的数字，你可以修改允许输入的字符的e.keychar值达到你的需求。
            if (e.KeyChar >= '0' && e.KeyChar <= '5')
            {
                e.Handled = false;
                return;
            }
            else
            {
                e.Handled = true;

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
