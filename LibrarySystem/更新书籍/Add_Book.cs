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
        public int t=0;
        public Add_Book()
        {
            InitializeComponent();
            //皮肤
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //防错
            #region
            //书籍添加防错
            if (textBox_No.Text == "")
            {
                MessageBox.Show("请添加书籍序列号！");
            }
            if (textBox_BookName.Text == "")
            {
                MessageBox.Show("请输入书名！");
            }
            if (textBox_Author.Text == "")
            {
                MessageBox.Show("请输入作者！");
            }
            if (textBox_Press.Text == "")
            {
                MessageBox.Show("请输入出版社！");
            }
            if (textBox_Price.Text == "")
            {
                MessageBox.Show("请输入价格！");
            }
            if (textBox_Storage.Text == "")
            {
                MessageBox.Show("请输入库存数！");
            }
            if (textBox_No.Text != "")
            {
                if (textBox_BookName.Text != "")
                {
                    if (textBox_Author.Text != "")
                    {
                        if (textBox_Press.Text != "")
                        {
                            if (textBox_Price.Text != "")
                            {
                                if (textBox_Storage.Text != "")
                                {
                                    t = 1;
                                }
                            }

                        }
                    }
                }
            }//书籍添加防错
            #endregion
            if (t == 1)
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认取消添加吗？", "温馨提示", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
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

        private void textBox_Storage_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Press_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Author_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_BookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExcelToSQL ex = new ExcelToSQL();
            ex.ShowDialog();
            this.Close();
        }
    }
}
