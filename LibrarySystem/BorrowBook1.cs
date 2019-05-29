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
            string sql = "select * from Books_Info where 书名='"+Select_ID+"'";
            DataBaseApplication.ExecuteNonQuery(sql);
            DataTable dt = new DataTable();
            dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
            dataGridView1.DataSource = dt;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            BorrowBook borrow = new BorrowBook();
            borrow.select_ID= (string)dataGridView1.CurrentCell.Value;
            borrow.ShowDialog();
        }
    }
}
