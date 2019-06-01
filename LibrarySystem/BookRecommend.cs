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
    public partial class BookRecommend : Form
    {
        public BookRecommend()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string sql = "insert into Book_Recommend(书名,排行) values('" + textBox_top1.Text + "','1'),('" + textBox_top2.Text + "','2'),('" + textBox_top3.Text + "','3'),('" + textBox_top4.Text + "','4'),('" + textBox_top5.Text + "','5')";
            DataBaseApplication.ExecuteNonQuery(sql);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认删除？", "温馨提示", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //执行删除语句
                MessageBox.Show("删除成功！");
            }
            string sql = "TRUNCATE TABLE Book_Recommend ";
            //string sql = "delete * from Book_Recommend";
            DataBaseApplication.ExecuteNonQuery(sql);

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
