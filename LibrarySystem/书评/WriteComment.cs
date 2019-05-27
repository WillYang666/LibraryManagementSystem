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
    public partial class WriteComment : Form
    {
        public WriteComment()
        {
            InitializeComponent();
            //皮肤
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }

        private void textBox_BookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void WriteComment_Load(object sender, EventArgs e)
        {
            ReturnBook ab = new ReturnBook();
            textBox_BookName.Text = "'"+ ab.bookname + "'";
        }
    }
}
