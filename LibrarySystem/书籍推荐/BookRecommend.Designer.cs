namespace LibrarySystem
{
    partial class BookRecommend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookRecommend));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.button1 = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.textBox_top5 = new System.Windows.Forms.TextBox();
            this.textBox_top4 = new System.Windows.Forms.TextBox();
            this.textBox_top3 = new System.Windows.Forms.TextBox();
            this.textBox_top2 = new System.Windows.Forms.TextBox();
            this.textBox_top1 = new System.Windows.Forms.TextBox();
            this.label1_1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.cancel);
            this.groupControl1.Controls.Add(this.OK);
            this.groupControl1.Controls.Add(this.textBox_top5);
            this.groupControl1.Controls.Add(this.textBox_top4);
            this.groupControl1.Controls.Add(this.textBox_top3);
            this.groupControl1.Controls.Add(this.textBox_top2);
            this.groupControl1.Controls.Add(this.textBox_top1);
            this.groupControl1.Controls.Add(this.label1_1);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(333, 287);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "热门推荐";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "清空数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(168, 228);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 37);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(33, 228);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(100, 37);
            this.OK.TabIndex = 11;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // textBox_top5
            // 
            this.textBox_top5.Location = new System.Drawing.Point(103, 185);
            this.textBox_top5.Name = "textBox_top5";
            this.textBox_top5.Size = new System.Drawing.Size(100, 22);
            this.textBox_top5.TabIndex = 10;
            // 
            // textBox_top4
            // 
            this.textBox_top4.Location = new System.Drawing.Point(103, 148);
            this.textBox_top4.Name = "textBox_top4";
            this.textBox_top4.Size = new System.Drawing.Size(100, 22);
            this.textBox_top4.TabIndex = 9;
            // 
            // textBox_top3
            // 
            this.textBox_top3.Location = new System.Drawing.Point(103, 110);
            this.textBox_top3.Name = "textBox_top3";
            this.textBox_top3.Size = new System.Drawing.Size(100, 22);
            this.textBox_top3.TabIndex = 8;
            // 
            // textBox_top2
            // 
            this.textBox_top2.Location = new System.Drawing.Point(103, 72);
            this.textBox_top2.Name = "textBox_top2";
            this.textBox_top2.Size = new System.Drawing.Size(100, 22);
            this.textBox_top2.TabIndex = 7;
            // 
            // textBox_top1
            // 
            this.textBox_top1.Location = new System.Drawing.Point(103, 31);
            this.textBox_top1.Name = "textBox_top1";
            this.textBox_top1.Size = new System.Drawing.Size(100, 22);
            this.textBox_top1.TabIndex = 6;
            // 
            // label1_1
            // 
            this.label1_1.AutoSize = true;
            this.label1_1.Location = new System.Drawing.Point(104, 34);
            this.label1_1.Name = "label1_1";
            this.label1_1.Size = new System.Drawing.Size(0, 14);
            this.label1_1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Top5:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Top4:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Top3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Top2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top1：";
            // 
            // BookRecommend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(333, 287);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookRecommend";
            this.Text = "热门书籍推荐";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox textBox_top5;
        private System.Windows.Forms.TextBox textBox_top4;
        private System.Windows.Forms.TextBox textBox_top3;
        private System.Windows.Forms.TextBox textBox_top2;
        private System.Windows.Forms.TextBox textBox_top1;
        private System.Windows.Forms.Label label1_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}