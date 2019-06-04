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
    public partial class LoginForm : Form
    {
        public string level;
        
        public LoginForm()
        {
            InitializeComponent();
            //皮肤
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_id.BackColor = Color.Transparent;
            label_password.BackColor = Color.Transparent;
            radioButton_admin.BackColor = Color.Transparent;
            radioButton_user.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            //连接数据库
            DataBaseApplication.DataSource = "(local)";
            DataBaseApplication.DataBaseName = "Practice";
            DataBaseApplication.UserID = "sa";
            DataBaseApplication.PassWord = "sa";
        
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //#1判断非空 trim用于删除空格
            if (this.textBox_id.Text.ToString().Trim() == "" || this.textBox_password.Text.ToString().Trim() == "")
            {
                MessageBox.Show("请补全用户名密码");
                return;
            }
            //要求选择权限类型
            if(radioButton_admin.Checked==false && radioButton_user.Checked==false)
            {
                MessageBox.Show("请选择您的用户身份！");
            }
            //判断权限类型
            if (radioButton_admin.Checked == true)
            {
                  level = "管理员";
                PublicPassBy.level = level;
            }
            if (radioButton_user.Checked == true) 
            {
                  level = "用户";
                PublicPassBy.level = level;
            }
            //判断用户是否存在
            DataTable dt = new DataTable();
            string user_name = "";
            string pass_word = "";           
            //读取界面值
            user_name = this.textBox_id.Text.ToString().Trim();
            pass_word = this.textBox_password.Text.ToString().Trim();
            //sql
            string sql = "select * from Login_ID where 账号='" + user_name + "'";
            dt = DataBaseApplication.GetDataTableValue(sql);
            //读取账号所有人的名字
            PublicPassBy._name = dt.Rows[0]["姓名"].ToString();
            //读取账号
            PublicPassBy.id= dt.Rows[0]["账号"].ToString();
            //读取邮箱
            PublicPassBy.email = dt.Rows[0]["邮箱"].ToString();
            //判断用户是否存在
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("该用户不存在");
                return;
            }
            //判断密码和权限
            if (dt.Rows[0]["密码"].ToString() == pass_word)
            {              
                if (dt.Rows[0]["身份"].ToString() == level)
                {
                    SystemLog.loginState = "OK";
                    SystemLog.user_name = user_name;
                    SystemLog.user_key = dt.Rows[0]["密码"].ToString();
                    this.Close();
                }
              
            }
            if (dt.Rows[0]["密码"].ToString() != pass_word)
            {
                MessageBox.Show("用户名和密码不匹配");
            }
            if (dt.Rows[0]["身份"].ToString() != level)
            {
                MessageBox.Show("您无此权限！");
            }
        }

        private void radioButton_user_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_admin_Click(object sender, EventArgs e)
        {

        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            Add_User sign = new Add_User();
            sign.type = "1";
            sign.ShowDialog();
        }
       
       

        private void LoginForm_Resize(object sender, EventArgs e)
        {
           
        }

        private void textBox_id_Enter(object sender, EventArgs e)
        {
            if(this.textBox_id.Text=="请输入您的账号！")
            {
                this.textBox_id.Text = "";
            }
        }

        private void textBox_id_Leave(object sender, EventArgs e)
        {
            if (this.textBox_id.Text.Length == 0)
            {
                this.textBox_id.Text = "请输入您的账号！";
            }
        }
        
        private void textBox_password_Enter(object sender, EventArgs e)
        {
          /*  if (this.textBox_password.Text == "请输入密码！")
            {
                this.textBox_password.Text = "";
            }
            */
        }

        private void textBox_password_Leave(object sender, EventArgs e)
        {
          /*  if(this.textBox_password.Text.Length==0)
            {
                this.textBox_password.Text = "请输入密码！";
                this.textBox_password.UseSystemPasswordChar = false;
            }
            */
        }
        
    }
   

}
