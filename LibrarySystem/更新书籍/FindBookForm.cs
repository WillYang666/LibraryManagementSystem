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
        /*
        #region
        //------------------------------------------------------  控件大小随窗体大小变化
        private float X;
        private float Y;

        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    setTag(con);
            }
        }

        private void setControls(float newx, float newy, Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                float a = Convert.ToSingle(mytag[0]) * newx;
                con.Width = (int)a;
                a = Convert.ToSingle(mytag[1]) * newy;
                con.Height = (int)(a);
                a = Convert.ToSingle(mytag[2]) * newx;
                con.Left = (int)(a);
                a = Convert.ToSingle(mytag[3]) * newy;
                con.Top = (int)(a);
                Single currentSize = Convert.ToSingle(mytag[4]) * Math.Min(newx, newy);
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    setControls(newx, newy, con);
                }
            }

        }

        void Form1_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / X;
            float newy = this.Height / Y;
            setControls(newx, newy, this);
            this.Text = this.Width.ToString() + " " + this.Height.ToString();

        }
        //--------------------------------------------------------------------------   控件大小随窗体大小变化结束
        #endregion
        */
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
            
            // edit.select_ID = (string)dataGridView1.CurrentCell.Value;
            int a = dataGridView1.CurrentRow.Index;
            edit.select_ID = dataGridView1.Rows[a].Cells["书籍序列号"].Value.ToString();
            if ((string)dataGridView1.CurrentCell.Value == "")
            {
                MessageBox.Show("你没选中");
                return;
            }
            edit.ShowDialog();
        }
        
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                BorrowBook1 borrow = new BorrowBook1();
                borrow.Select_ID = (string)dataGridView1.CurrentCell.Value;
                borrow.ShowDialog();
            }
            else MessageBox.Show("请先选择要借阅的书籍！");
               
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
            //权限判断
            if (level1 == "用户")
            {
                书籍入库tSBtn.Visible = false;
                Edit_Book_Info.Visible = false;
                新书入库ToolStripMenuItem.Visible = false;
                toolStripLabel_AllBooks.Visible = false;
            }
            //--------------------------------控件大小随窗体大小变化
            /*this.Resize += new EventHandler(Form1_Resize);

            X = this.Width;
            Y = this.Height;

            setTag(this);
            Form1_Resize(new object(), new EventArgs());*/
            //---------------------------------控件大小随窗体大小变化
        }

        private void xxx_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            xxx.Text = DateTime.Now.ToString();
        }

        private void 新书入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Book add = new Add_Book();
            add.ShowDialog();
        }

        private void button_FindAllBook_Click(object sender, EventArgs e)
        {
           

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            string sql = "select * from Books_Info ";
            DataTable dt = new DataTable();
            dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
            dataGridView1.DataSource = dt;
        }
    }
}
