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
    public partial class BookRecommendReader : Form
    {
        public BookRecommendReader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into Book_Recommend_Reader (书名,作者,出版社)values('" + textBox_BookName + "','" + textBox_Author + "','" + textBox_Press + "')";
            DataBaseApplication.ExecuteNonQuery(sql);
            MessageBox.Show("感谢您的推荐！");
            this.Close();
        }
    }
}
