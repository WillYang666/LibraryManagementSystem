namespace LibrarySystem
{
    partial class FindBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindBookForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.书籍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新书入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.跳转到首页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.前一页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.后一页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.跳转到最后一页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.书籍入库tSBtn = new System.Windows.Forms.ToolStripButton();
            this.Edit_Book_Info = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.查看帮助tSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSL5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSL2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.adadssadasdsadas = new System.Windows.Forms.ToolStripStatusLabel();
            this.xxx = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.书籍ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 书籍ToolStripMenuItem
            // 
            this.书籍ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新书入库ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.刷新ToolStripMenuItem});
            this.书籍ToolStripMenuItem.Name = "书籍ToolStripMenuItem";
            this.书籍ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.书籍ToolStripMenuItem.Text = "书籍(B)";
            // 
            // 新书入库ToolStripMenuItem
            // 
            this.新书入库ToolStripMenuItem.Name = "新书入库ToolStripMenuItem";
            this.新书入库ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新书入库ToolStripMenuItem.Text = "书籍入库";
            this.新书入库ToolStripMenuItem.Click += new System.EventHandler(this.新书入库ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.修改ToolStripMenuItem.Text = "保存修改";
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.跳转到首页ToolStripMenuItem,
            this.前一页ToolStripMenuItem,
            this.后一页ToolStripMenuItem,
            this.跳转到最后一页ToolStripMenuItem});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.视图ToolStripMenuItem.Text = "视图(V)";
            // 
            // 跳转到首页ToolStripMenuItem
            // 
            this.跳转到首页ToolStripMenuItem.Name = "跳转到首页ToolStripMenuItem";
            this.跳转到首页ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.跳转到首页ToolStripMenuItem.Text = "跳转到首页";
            // 
            // 前一页ToolStripMenuItem
            // 
            this.前一页ToolStripMenuItem.Name = "前一页ToolStripMenuItem";
            this.前一页ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.前一页ToolStripMenuItem.Text = "前一页";
            // 
            // 后一页ToolStripMenuItem
            // 
            this.后一页ToolStripMenuItem.Name = "后一页ToolStripMenuItem";
            this.后一页ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.后一页ToolStripMenuItem.Text = "后一页";
            // 
            // 跳转到最后一页ToolStripMenuItem
            // 
            this.跳转到最后一页ToolStripMenuItem.Name = "跳转到最后一页ToolStripMenuItem";
            this.跳转到最后一页ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.跳转到最后一页ToolStripMenuItem.Text = "跳转到最后一页";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(H)";
            // 
            // 查看帮助ToolStripMenuItem
            // 
            this.查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem";
            this.查看帮助ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.查看帮助ToolStripMenuItem.Text = "查看帮助";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.书籍入库tSBtn,
            this.Edit_Book_Info,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.查看帮助tSBtn,
            this.toolStripLabel1,
            this.toolStripComboBox1,
            this.toolStripLabel2,
            this.toolStripTextBox1,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(623, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 书籍入库tSBtn
            // 
            this.书籍入库tSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.书籍入库tSBtn.Image = ((System.Drawing.Image)(resources.GetObject("书籍入库tSBtn.Image")));
            this.书籍入库tSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.书籍入库tSBtn.Name = "书籍入库tSBtn";
            this.书籍入库tSBtn.Size = new System.Drawing.Size(36, 36);
            this.书籍入库tSBtn.Text = "书籍入库";
            this.书籍入库tSBtn.Click += new System.EventHandler(this.书籍入库tSBtn_Click);
            // 
            // Edit_Book_Info
            // 
            this.Edit_Book_Info.AutoSize = false;
            this.Edit_Book_Info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Edit_Book_Info.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Book_Info.Image")));
            this.Edit_Book_Info.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_Book_Info.Name = "Edit_Book_Info";
            this.Edit_Book_Info.Size = new System.Drawing.Size(33, 32);
            this.Edit_Book_Info.Text = "修改信息";
            this.Edit_Book_Info.Click += new System.EventHandler(this.Edit_Book_Info_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // 查看帮助tSBtn
            // 
            this.查看帮助tSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.查看帮助tSBtn.Image = ((System.Drawing.Image)(resources.GetObject("查看帮助tSBtn.Image")));
            this.查看帮助tSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.查看帮助tSBtn.Name = "查看帮助tSBtn";
            this.查看帮助tSBtn.Size = new System.Drawing.Size(36, 36);
            this.查看帮助tSBtn.Text = "查看帮助";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 36);
            this.toolStripLabel1.Text = "输入";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "书名",
            "作者"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 39);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 36);
            this.toolStripLabel2.Text = "进行查询:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 39);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "查询";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "办理借阅";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(623, 333);
            this.dataGridView1.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSL5,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel6,
            this.tSSL2,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel3,
            this.adadssadasdsadas,
            this.xxx});
            this.statusStrip1.Location = new System.Drawing.Point(0, 375);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(623, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSSL5
            // 
            this.tSSL5.Name = "tSSL5";
            this.tSSL5.Size = new System.Drawing.Size(44, 17);
            this.tSSL5.Text = "   xxxx";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(152, 17);
            this.toolStripStatusLabel1.Text = "，欢迎登陆图书管理系统！";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel6.Text = " ";
            // 
            // tSSL2
            // 
            this.tSSL2.Name = "tSSL2";
            this.tSSL2.Size = new System.Drawing.Size(116, 17);
            this.tSSL2.Text = "权限级别：普通用户";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel4.Text = " ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel3.Text = "状态：正常";
            // 
            // adadssadasdsadas
            // 
            this.adadssadasdsadas.Name = "adadssadasdsadas";
            this.adadssadasdsadas.Size = new System.Drawing.Size(100, 17);
            this.adadssadasdsadas.Text = "        现在时间：";
            // 
            // xxx
            // 
            this.xxx.Name = "xxx";
            this.xxx.Size = new System.Drawing.Size(15, 17);
            this.xxx.Text = "1";
            this.xxx.Click += new System.EventHandler(this.xxx_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // FindBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 397);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindBookForm";
            this.Text = "书籍查询";
            this.Load += new System.EventHandler(this.FindBookForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 书籍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新书入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 跳转到首页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 前一页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 后一页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 跳转到最后一页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 书籍入库tSBtn;
        private System.Windows.Forms.ToolStripButton Edit_Book_Info;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton 查看帮助tSBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSSL5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel tSSL2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel adadssadasdsadas;
        private System.Windows.Forms.ToolStripStatusLabel xxx;
        private System.Windows.Forms.Timer timer1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}