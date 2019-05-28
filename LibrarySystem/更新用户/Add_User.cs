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

    public partial class Add_User : Form
    {
        public string select_ID;
        public string type;//1添加，2修改
        public long p,q;
        public Add_User()
        {
            InitializeComponent();
        }

        private void Add_User_Load(object sender, EventArgs e)
        {
            //注册界面
            if (type == "1")
            {
                    textBox_Title.Text = "用户";
                    textBox_Title.ReadOnly = true;
                
            }
            if (type == "2")
            {
                string sql = "select * from Login_ID where 账号='" + select_ID.ToString() + "'";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);
                textBox_ID.Text = dt.Rows[0][0].ToString();
                textBox_Password.Text = dt.Rows[0][1].ToString();
                textBox_Title.Text = dt.Rows[0][2].ToString();
                textBox_phonenum.Text = dt.Rows[0][3].ToString();
                textBox_email.Text = dt.Rows[0][4].ToString();
                textBox_Name.Text = dt.Rows[0][5].ToString();
            }
            if(type=="3")
            {
                string sql = "select * from Login_ID where 姓名='"+PublicPassBy._name+"'";
                DataTable dt = new DataTable();
                dt = DataBaseApplication.GetDataTableValue(sql);
                textBox_ID.Text = dt.Rows[0][0].ToString();
                textBox_Password.Text = dt.Rows[0][1].ToString();
                textBox_Title.Text = dt.Rows[0][2].ToString();
                textBox_phonenum.Text = dt.Rows[0][3].ToString();
                textBox_email.Text = dt.Rows[0][4].ToString();
                textBox_Name.Text = dt.Rows[0][5].ToString();
            }
        }
            
        private void button_OK_Click(object sender, EventArgs e)
        {//防错
            q = textBox_Password.Text.Length;//q和p在上面定义
            p = textBox_phonenum.Text.Length;
            if(q==0)
            {
                MessageBox.Show("请输入密码！");
            }
            if (q > 0)
            {
                if (q < 9 | q > 11)
                {
                    MessageBox.Show("请输入9-11位的密码！");
                }
            }
            if (p != 11)
            {
                MessageBox.Show("温馨提示：请检查您输入的号码是否正确（11位）！");
            }
            if (p == 11)
            {
                if (textBox_ID.Text == "")
                    MessageBox.Show("您的账号未填写，请输入账号！");
         
                if (textBox_Name.Text == "")
                    MessageBox.Show("您的姓名未填写，请输入姓名！");

                if (textBox_phonenum.Text == "")
                    MessageBox.Show("您的号码未填写，请输入11位号码！");

                if (q > 8 && q < 12)
                {
                    if (textBox_Password.Text == "")
                        MessageBox.Show("您的密码未填写，请输入密码！");
                    else
                        MessageBox.Show(textBox_Password.Text, "请您确认密码：");
                }
                if (textBox_email.Text == "")
                    MessageBox.Show("您的邮箱未填写，请输入邮箱号！");
              else
                    MessageBox.Show(textBox_email.Text, "请您确认邮箱地址：");
               
            }
            
            //防错
            if (type == "1")
            {
                
                if(PublicPassBy.level!="管理员")
                {
                    textBox_Title.Text = "用户";
                    textBox_Title.ReadOnly=true;
                }
                string sql = "insert into Login_ID(账号,密码,身份,电话号码,邮箱,姓名)values('" + textBox_ID.Text.ToString() + "','" + textBox_Password.Text.ToString() + "','" + textBox_Title.Text.ToString() + "','" + textBox_phonenum.Text.ToString() + "','" + textBox_email.Text.ToString() + "','"+textBox_Name.Text.ToString()+"')";
                DataBaseApplication.ExecuteNonQuery(sql);
                MessageBox.Show("添加成功");
                this.Close();
            }
            if (type == "2")
            {
                string sql = "update Login_ID set 密码='" + textBox_Password.Text.ToString() + "',身份='" + textBox_Title.Text.ToString() + "',电话号码='"+textBox_phonenum.Text.ToString()+ "',邮箱='"+textBox_email.Text.ToString()+ "',姓名='"+textBox_Name.Text.ToString()+"' where 账号='" + textBox_ID.Text.ToString() + "'";
                DataBaseApplication.ExecuteNonQuery(sql);
                MessageBox.Show("修改成功");
                this.Close();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
