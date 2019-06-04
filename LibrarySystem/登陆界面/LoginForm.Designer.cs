namespace LibrarySystem
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label_id = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.radioButton_user = new System.Windows.Forms.RadioButton();
            this.radioButton_admin = new System.Windows.Forms.RadioButton();
            this.sign_in = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_id.Location = new System.Drawing.Point(45, 69);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(66, 19);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "账号：";
            this.label_id.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_password.Location = new System.Drawing.Point(45, 105);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(66, 19);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "密码：";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(117, 69);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 21);
            this.textBox_id.TabIndex = 2;
            this.textBox_id.Enter += new System.EventHandler(this.textBox_id_Enter);
            this.textBox_id.Leave += new System.EventHandler(this.textBox_id_Leave);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(117, 103);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 21);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.Enter += new System.EventHandler(this.textBox_password_Enter);
            this.textBox_password.Leave += new System.EventHandler(this.textBox_password_Leave);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_login.Location = new System.Drawing.Point(105, 192);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(92, 34);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "登陆";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // radioButton_user
            // 
            this.radioButton_user.AutoSize = true;
            this.radioButton_user.Location = new System.Drawing.Point(80, 157);
            this.radioButton_user.Name = "radioButton_user";
            this.radioButton_user.Size = new System.Drawing.Size(47, 16);
            this.radioButton_user.TabIndex = 5;
            this.radioButton_user.TabStop = true;
            this.radioButton_user.Text = "用户";
            this.radioButton_user.UseVisualStyleBackColor = true;
            this.radioButton_user.CheckedChanged += new System.EventHandler(this.radioButton_user_CheckedChanged);
            // 
            // radioButton_admin
            // 
            this.radioButton_admin.AutoSize = true;
            this.radioButton_admin.Location = new System.Drawing.Point(170, 157);
            this.radioButton_admin.Name = "radioButton_admin";
            this.radioButton_admin.Size = new System.Drawing.Size(59, 16);
            this.radioButton_admin.TabIndex = 6;
            this.radioButton_admin.Text = "管理员";
            this.radioButton_admin.UseVisualStyleBackColor = true;
            this.radioButton_admin.Click += new System.EventHandler(this.radioButton_admin_Click);
            // 
            // sign_in
            // 
            this.sign_in.Location = new System.Drawing.Point(223, 221);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(75, 23);
            this.sign_in.TabIndex = 7;
            this.sign_in.Text = "立即注册！";
            this.sign_in.UseVisualStyleBackColor = true;
            this.sign_in.Click += new System.EventHandler(this.sign_in_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(223, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "(*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(223, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "(*)";
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
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibrarySystem.Properties.Resources.登陆背景图;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(310, 256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sign_in);
            this.Controls.Add(this.radioButton_admin);
            this.Controls.Add(this.radioButton_user);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "登陆界面";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.LoginForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.RadioButton radioButton_user;
        private System.Windows.Forms.RadioButton radioButton_admin;
        private System.Windows.Forms.Button sign_in;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}

