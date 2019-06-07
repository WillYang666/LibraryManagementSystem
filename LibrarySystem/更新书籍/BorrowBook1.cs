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
    public partial class BorrowBook1 : Form
    {
        public string Select_ID;
        public BorrowBook1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BorrowBook1_Load(object sender, EventArgs e)
        {
            string sql = "select * from Books_Info where 书名='"+Select_ID+"'and 库存数!=0";
            DataBaseApplication.ExecuteNonQuery(sql);
            DataTable dt = new DataTable();
            dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
            dataGridView1.DataSource = dt;
            //书评展示
            string sql1 = "select 书评,评分 from IMDB where 书名='" + Select_ID + "'";
            DataBaseApplication.ExecuteNonQuery(sql1);
            DataTable dt1 = new DataTable();
            dt1 = DataBaseApplication.GetDataTableValue(sql1);
            dataGridView2.DataSource = dt1;
            //平均分
            string sql2 = "select avg(评分) from IMDB where 书名='" + Select_ID + "'";
            DataBaseApplication.ExecuteNonQuery(sql2);
            DataTable dt2 = new DataTable();
            dt2 = DataBaseApplication.GetDataTableValue(sql2);
            avgRate.Text = dt2.Rows[0][0].ToString();
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            BorrowBook borrow = new BorrowBook();
            borrow.select_ID= (string)dataGridView1.CurrentCell.Value;
            borrow.ShowDialog();
        }
    }
}
