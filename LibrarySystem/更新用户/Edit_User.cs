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
    public partial class Edit_User : Form
    {
        public Edit_User()
        {
            InitializeComponent();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (comboBox_Search.Text == " ")
            {
                MessageBox.Show("请先选择要查找的类型!");
            }
            if (comboBox_Search.Text == "账号")
            {
                string sql = "select * from Login_ID where 账号 ='" + textBox_Search.Text.ToString() + "' ";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                dataGridView1.DataSource = dt;
            }
            if (comboBox_Search.Text == "手机号码")
            {
                string sql = "select * from Login_ID where 电话号码 ='" + textBox_Search.Text.ToString() + "' ";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                dataGridView1.DataSource = dt;
            }
            if (comboBox_Search.Text == "邮箱")
            {
                string sql = "select * from Login_ID where 邮箱 ='" + textBox_Search.Text.ToString() + "' ";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                dataGridView1.DataSource = dt;
            }
            if (comboBox_Search.Text == "姓名")
            {
                string sql = "select * from Login_ID where 姓名 ='" + textBox_Search.Text.ToString() + "' ";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                dataGridView1.DataSource = dt;
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount == 0)
            {
                MessageBox.Show("请先选择数据");
                return;
            }
            Add_User edit = new Add_User();
            edit.type = "2";
            edit.select_ID = (string)dataGridView1.CurrentCell.Value;
            //edit.select_ID = this.dataGridView1.SelectedRows[1].Cells[1].Value.ToString();//获取选中行的第一个单元格的值
            if ((string)dataGridView1.CurrentCell.Value == "")
            {
                MessageBox.Show("你没选中");
                return;
            }
            edit.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from Login_ID";
            DataBaseApplication.ExecuteNonQuery(sql);
            DataTable dt = new DataTable();
            dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
            dataGridView1.DataSource = dt;
        }

        private void Edit_User_Load(object sender, EventArgs e)
        {
            if (PublicPassBy.level == "用户")
            {
                button1.Visible = false;
            }
        }
    }
}
