﻿using System;
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
    public partial class MainForm : Form
    {
        public string level1;
        public MainForm()
        {
            InitializeComponent();
            //皮肤
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 添加用户_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
            //时间显示
            timer1.Interval = 1000;
            timer1.Start();
            //底部状态栏数据
            LoginForm lg = new LoginForm();
            level1 = PublicPassBy.level;
            if(level1=="用户")
            {
                tSSL2.Text = "权限级别：普通用户";
            }
            else
            {
                tSSL2.Text = "权限级别：管理员";
            }
            
            tSSL5.Text = "  "+PublicPassBy._name;
            //权限设置
            if (level1=="用户")
            {
                Add_User.Visible = false;
                新用户注册ToolStripMenuItem.Enabled = false;
                Add_Books.Enabled = false;
            }
        }

        private void Add_User_Click(object sender, EventArgs e)
        {
            Add_User add =new Add_User();
            add.type = "1";
            add.ShowDialog();
        }

        private void Edit_Info_Click(object sender, EventArgs e)
        {
            Edit_User edit = new Edit_User();
            edit.ShowDialog();
        }

        private void 新用户注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_User add = new Add_User();
            add.type = "1";
            add.ShowDialog();
        }

        private void 用户信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_User edit = new Edit_User();
            edit.ShowDialog();
        }

        private void Add_Books_Click(object sender, EventArgs e)
        {
            Add_Book addbook = new Add_Book();
            addbook.type = "1";
            addbook.ShowDialog();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            FindBookForm find = new FindBookForm();
            find.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            xxx.Text = DateTime.Now.ToString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            FindBookForm find = new FindBookForm();
            find.ShowDialog();
        }

        private void tSSL5_Click(object sender, EventArgs e)
        {

        }

        private void Borrow_Click(object sender, EventArgs e)
        {
            FindBookForm find = new FindBookForm();
            find.ShowDialog();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            ReturnBook re = new ReturnBook();
            re.ShowDialog();
        }

        private void 图书查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindBookForm find = new FindBookForm();
            find.ShowDialog();
        }

        private void 用户信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_User add = new Add_User();
            add.type = "3";
            add.ShowDialog();
        }

        private void Help_Click(object sender, EventArgs e)
        {

        }
    }
}
