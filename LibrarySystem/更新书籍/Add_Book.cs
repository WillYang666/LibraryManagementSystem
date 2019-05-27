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
    public partial class Add_Book : Form
    {
        public string select_ID;
        public string type;//1添加，2修改
        public Add_Book()
        {
            InitializeComponent();
            //皮肤
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type == "1")
            {
                if (textBox_No.Text == "")
                {
                    MessageBox.Show("请输入记录ID");
                    return;
                }
                string sql = "insert into Books_Info(书籍序列号,书名,作者,出版社,价格,库存数)values('" + textBox_No.Text.ToString() + "','" + textBox_BookName.Text.ToString() + "','" + textBox_Author.Text.ToString() + "','" + textBox_Press.Text.ToString() + "','" + textBox_Price.Text.ToString() + "','" + textBox_Storage.Text.ToString() + "')";
                DataBaseApplication.ExecuteNonQuery(sql);
                MessageBox.Show("添加成功");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Book_Load(object sender, EventArgs e)
        {
            if (type == "2")
            {
                string sql = "select * from Books_Info where 书籍序列号='" + select_ID.ToString() + "'";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);
                textBox_No.Text = dt.Rows[0][0].ToString();
                textBox_BookName.Text = dt.Rows[0][1].ToString();
                textBox_Author.Text = dt.Rows[0][2].ToString();
                textBox_Press.Text = dt.Rows[0][3].ToString();
                textBox_Price.Text = dt.Rows[0][4].ToString();
                textBox_Storage.Text = dt.Rows[0][5].ToString();
            }
        }
    }
}
