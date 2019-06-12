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
    public partial class BorrowBook1 : Form
    {
        /*
        #region
        //------------------------------------------------------  控件大小随窗体大小变化
        private float X;
        private float Y;

        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    setTag(con);
            }
        }

        private void setControls(float newx, float newy, Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                float a = Convert.ToSingle(mytag[0]) * newx;
                con.Width = (int)a;
                a = Convert.ToSingle(mytag[1]) * newy;
                con.Height = (int)(a);
                a = Convert.ToSingle(mytag[2]) * newx;
                con.Left = (int)(a);
                a = Convert.ToSingle(mytag[3]) * newy;
                con.Top = (int)(a);
                Single currentSize = Convert.ToSingle(mytag[4]) * Math.Min(newx, newy);
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    setControls(newx, newy, con);
                }
            }

        }

        void BorrowBook1_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / X;
            float newy = this.Height / Y;
            setControls(newx, newy, this);
            this.Text = this.Width.ToString() + " " + this.Height.ToString();

        }
        //--------------------------------------------------------------------------   控件大小随窗体大小变化结束
        #endregion
        */
        public string Select_ID;
        public BorrowBook1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BorrowBook1_Load(object sender, EventArgs e)
        {
            string sql = "select * from Books_Info where 书名='"+Select_ID+"'and 库存数!=0";
            DataBaseApplication.ExecuteNonQuery(sql);
            DataTable dt = new DataTable();
            dt = DataBaseApplication.GetDataTableValue(sql);//执行sql语句
            dataGridView1.DataSource = dt;
            //书评展示
            string sql1 = "select 书评,评分 from IMDB where 书名='" + Select_ID + "'";
            DataBaseApplication.ExecuteNonQuery(sql1);
            DataTable dt1 = new DataTable();
            dt1 = DataBaseApplication.GetDataTableValue(sql1);
            dataGridView2.DataSource = dt1;
            //平均分
            string sql2 = "select avg(评分) from IMDB where 书名='" + Select_ID + "'";
            DataBaseApplication.ExecuteNonQuery(sql2);
            DataTable dt2 = new DataTable();
            dt2 = DataBaseApplication.GetDataTableValue(sql2);
            avgRate.Text = dt2.Rows[0][0].ToString();
            //--------------------------------控件大小随窗体大小变化
          /*  this.Resize += new EventHandler(BorrowBook1_Resize);

            X = this.Width;
            Y = this.Height;

            setTag(this);
            BorrowBook1_Resize(new object(), new EventArgs());*/
            //---------------------------------控件大小随窗体大小变化
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                BorrowBook borrow = new BorrowBook();
                borrow.select_ID = (string)dataGridView1.CurrentCell.Value;
                borrow.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("请先选择要借阅的书籍！");
                
        }

    }

}
