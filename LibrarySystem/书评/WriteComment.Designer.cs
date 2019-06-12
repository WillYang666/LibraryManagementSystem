namespace LibrarySystem
{
    partial class WriteComment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteComment));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox_Rate = new System.Windows.Forms.TextBox();
            this.label_Rate = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.textBox_BookName = new System.Windows.Forms.TextBox();
            this.label_BookName = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox_Rate);
            this.splitContainer1.Panel1.Controls.Add(this.label_Rate);
            this.splitContainer1.Panel1.Controls.Add(this.submit);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_BookName);
            this.splitContainer1.Panel1.Controls.Add(this.label_BookName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(533, 331);
            this.splitContainer1.SplitterDistance = 47;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBox_Rate
            // 
            this.textBox_Rate.Location = new System.Drawing.Point(230, 9);
            this.textBox_Rate.Name = "textBox_Rate";
            this.textBox_Rate.Size = new System.Drawing.Size(100, 21);
            this.textBox_Rate.TabIndex = 4;
            this.textBox_Rate.TextChanged += new System.EventHandler(this.textBox_Rate_TextChanged);
            this.textBox_Rate.Enter += new System.EventHandler(this.textBox_Rate_Enter);
            this.textBox_Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Rate_KeyPress);
            this.textBox_Rate.Leave += new System.EventHandler(this.textBox_Rate_Leave);
            // 
            // label_Rate
            // 
            this.label_Rate.AutoSize = true;
            this.label_Rate.Location = new System.Drawing.Point(183, 12);
            this.label_Rate.Name = "label_Rate";
            this.label_Rate.Size = new System.Drawing.Size(41, 12);
            this.label_Rate.TabIndex = 3;
            this.label_Rate.Text = "评分：";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(371, 9);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "提交";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // textBox_BookName
            // 
            this.textBox_BookName.Location = new System.Drawing.Point(60, 9);
            this.textBox_BookName.Name = "textBox_BookName";
            this.textBox_BookName.ReadOnly = true;
            this.textBox_BookName.Size = new System.Drawing.Size(100, 21);
            this.textBox_BookName.TabIndex = 1;
            this.textBox_BookName.TextChanged += new System.EventHandler(this.textBox_BookName_TextChanged);
            // 
            // label_BookName
            // 
            this.label_BookName.AutoSize = true;
            this.label_BookName.Location = new System.Drawing.Point(13, 12);
            this.label_BookName.Name = "label_BookName";
            this.label_BookName.Size = new System.Drawing.Size(41, 12);
            this.label_BookName.TabIndex = 0;
            this.label_BookName.Text = "书名：";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(533, 280);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
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
            // WriteComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 331);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WriteComment";
            this.Text = "填写书评";
            this.Load += new System.EventHandler(this.WriteComment_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox_BookName;
        private System.Windows.Forms.Label label_BookName;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox_Rate;
        private System.Windows.Forms.Label label_Rate;
    }
}