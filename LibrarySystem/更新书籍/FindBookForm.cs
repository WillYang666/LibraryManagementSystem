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
    public partial class FindBookForm : Form
    {
        public string level1;
        public string Select_ID;
        public FindBookForm()
        {
            InitializeComponent();
            //皮肤
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }

        private void dgv_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 书籍入库tSBtn_Click(object sender, EventArgs e)
        {
            Add_Book addbook = new Add_Book();
            addbook.type = "1";
            addbook.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "")
            {
                MessageBox.Show("请添加完整!");
            }
            if (toolStripComboBox1.Text == "书名")
            {
                string sql = "select distinct 书名,作者,出版社 from Books_Info where  书名 like '%" + toolStripTextBox1.Text.ToString() + "%' ";
                
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                dataGridView1.DataSource = dt;
            }
            if (toolStripComboBox1.Text == "作者")
            {
                string sql = "select * from Books_Info where 作者 like '%" + toolStripTextBox1.Text.ToString() + "%' ";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
                dataGridView1.DataSource = dt;
            }
        }

        private void Edit_Book_Info_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount == 0)
            {
                MessageBox.Show("请先选择数据");
                return;
            }
            Add_Book edit = new Add_Book();
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
            BorrowBook1 borrow = new BorrowBook1();
            borrow.Select_ID = (string)dataGridView1.CurrentCell.Value;
            borrow.ShowDialog();
        }

        private void FindBookForm_Load(object sender, EventArgs e)
        {
            //时间显示
            timer1.Interval = 1000;
            timer1.Start();
            //底部状态栏数据
            LoginForm lg = new LoginForm();
            level1 = PublicPassBy.level;
            if (level1 == "用户")
            {
                tSSL2.Text = "权限级别：普通用户";
            }
            else
            {
                tSSL2.Text = "权限级别：管理员";
            }

            tSSL5.Text = "  " + PublicPassBy._name;
        }

        private void xxx_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            xxx.Text = DateTime.Now.ToString();
        }
    }
}
