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
    public partial class ReturnBook : Form
    {
        public string select_ID;
        public string level1;
        public string s_email;
        public string bookname;
        public string username;
        public ReturnBook()
        {
            InitializeComponent();
            //皮肤
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            //发邮件控件是否可见
            if(PublicPassBy.level!="管理员")
            {
                send_email.Visible = false;
            }
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
            //
            string sql = "select * from Borrow_List where 借阅人账号='" + PublicPassBy.id + "'";
            DataTable dt = new DataTable();
            dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
            dataGridView1.DataSource = dt;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            xxx.Text = DateTime.Now.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认归还？", "温馨提示", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //执行删除语句
                MessageBox.Show("还书成功！");
            }
            select_ID = (string)dataGridView1.CurrentCell.Value;
            //从在借单中删除
            string sql="delete from Borrow_List where 书籍序列号='"+select_ID+"'";
            DataBaseApplication.ExecuteNonQuery(sql);
            //获取书名
            bookname = (string)dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //添加进还书单
            string sql1 = "insert into Return_List values('"+select_ID+"','"+dataGridView1.CurrentRow.Cells[1].Value.ToString()+"','"+ DateTime.Now.ToLongDateString().ToString() + "','"+ dataGridView1.CurrentRow.Cells[3].Value.ToString()+"','"+PublicPassBy._name+"','"+PublicPassBy.email+"')";
            DataBaseApplication.ExecuteNonQuery(sql1);
            string sql2 = "update Books_Info set 库存数=库存数+1 where 书籍序列号='"+select_ID+"'";
            DataBaseApplication.ExecuteNonQuery(sql2);
            
            //询问是否写书评
            IMDB write = new IMDB();
            write.ShowDialog();
            this.Close();
        }

        private void send_email_Click(object sender, EventArgs e)
        {
            PublicPassBy.email = (string)dataGridView1.CurrentRow.Cells[6].Value;
            Email em = new Email();
            em.ShowDialog();
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            string sql = "select * from Borrow_List";
            DataBaseApplication.ExecuteNonQuery(sql);
            DataTable dt = new DataTable();
            dt = DataBaseApplication.GetDataTableValue(sql);
            dataGridView1.DataSource = dt;
        }
    }
}
