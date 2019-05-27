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
    public partial class BorrowBook : Form
    {
        public string select_ID;
        public BorrowBook()
        {
            InitializeComponent();
            //皮肤
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {
            string sql = "select * from Books_Info where 书籍序列号='" + select_ID.ToString() + "'";
            DataTable dt = new DataTable();
            dt = DataBaseApplication.GetDataTableValue(sql);
            textBox_No.Text = dt.Rows[0][0].ToString();
            textBox_Name.Text = dt.Rows[0][1].ToString();
            textBox_Author.Text = dt.Rows[0][2].ToString();
            textBox_Press.Text = dt.Rows[0][3].ToString();
            textBox_ID.Text = PublicPassBy.id;
            textBox_Who.Text = PublicPassBy._name;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            string sql = "insert into Borrow_List values('" + textBox_No.Text.ToString() + "','" + textBox_ID.Text.ToString() + "','" + DateTime.Now.ToLongDateString().ToString() + "','" + textBox_Name.Text.ToString() + "','" + PublicPassBy._name + "', '"+ DateTime.Now.AddDays(30).ToString()+"','"+PublicPassBy.email+"')";
            DataBaseApplication.ExecuteNonQuery(sql);
            string sql1 = "update Books_Info set 库存数=库存数-1 where 书籍序列号='" + textBox_No.Text.ToString() + "' ";
            DataBaseApplication.ExecuteNonQuery(sql1);
            MessageBox.Show("借阅成功！");
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
