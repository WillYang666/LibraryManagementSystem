using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;

namespace LibrarySystem
{
    public partial class ExcelToSQL : Form
    {
        public ExcelToSQL()
        {
            InitializeComponent();
            //皮肤
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }
        DataTable dt = new DataTable();
        string connString = "Data Source=(local); Initial Catalog=Practice; user id=sa; password=sa;";
        SqlConnection conn;
        
       
            
        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string fileName = fd.FileName;
                bind(fileName);
            }  
        }
        private void bind(string fileName)
        {
            string fileExtenSion;
            fileExtenSion = Path.GetExtension(fileName);
            string connstr2003 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
            string connstr2007 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=\"Excel 12.0;HDR=YES\"";
            OleDbConnection conn;
           if (fileExtenSion.ToLower() == ".xls")
            {
                conn = new OleDbConnection(connstr2003);
            }
            else
            {
                conn = new OleDbConnection(connstr2007);
            }
            conn.Open();
            string sql = "select * from [Sheet$]";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Close();
            try
            {
                da.Fill(ds);
                dt = ds.Tables[0];
                this.dataGridView1.DataSource = dt;
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());
            }  
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                conn = new SqlConnection(connString);
                conn.Open();
                if (dataGridView1.Rows.Count > 0)
                {
                    DataRow datarow = null;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        datarow = dt.Rows[i];
                        insertToSql(datarow);
                    }
                    conn.Close();
                    MessageBox.Show("导入成功！");
                }
                else
                {
                    MessageBox.Show("导入失败！");
                }
            }
            else MessageBox.Show("请先选择表格！");
            this.Close();
           
        }   
        private void insertToSql(DataRow datarow)
        {
            conn = new SqlConnection(connString);
            conn.Open();
            //excel表中的列名和数据库中的列名一定要对应  
            string sql1;
           // string sql2;
            if (dt.Columns[0].ColumnName.ToString() == "书籍序列号" && dt.Columns[5].ColumnName.ToString() == "库存数")
            {
                string kehubianhao = datarow["书籍序列号"].ToString();
                string kehumingcheng = datarow["书名"].ToString();
                string kehudizhi = datarow["作者"].ToString();
                string kehuwangzhi = datarow["出版社"].ToString();
                string suoshudijishi = datarow["价格"].ToString();
                string suoshuhangye = datarow["库存数"].ToString();
                sql1 = string.Format("insert into Books_Info(书籍序列号,书名,作者,出版社,价格,库存数) values('{0}','{1}','{2}','{3}','{4}','{5}')", kehubianhao, kehumingcheng, kehudizhi, kehuwangzhi, suoshudijishi, suoshuhangye);
                SqlCommand cmd = new SqlCommand(sql1, conn);
                cmd.CommandText = sql1;
                cmd.ExecuteNonQuery();
            }
           /* else if (dt.Columns[0].ColumnName.ToString() == "客户编号" && dt.Columns[10].ColumnName.ToString() == "事后分析")
            {
                string kehubianhao = datarow["客户编号"].ToString();
                string lianxiriqi = datarow["联系日期"].ToString();
                string kehulianxiren = datarow["客户联系人"].ToString();
                string shouji = datarow["手机"].ToString();
                string guhua = datarow["固话"].ToString();
                string qq = datarow["QQ"].ToString();
                string email = datarow["邮箱"].ToString();
                string gszhixingren = datarow["公司执行人"].ToString();
                string lianxijilu = datarow["联系详细记录"].ToString();
                string goumaineirong = datarow["预计客户购买内容和报价内容"].ToString();
                string shihoufenxi = datarow["事后分析"].ToString();
                sql2 = string.Format("insert into lianxirizhi(kehubianhao,lianxiriqi,kehulianxiren,shouji,guhua,qq,email,gszhixingren,lianxijilu,goumaineirong,shihoufenxi) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", kehubianhao, lianxiriqi, kehulianxiren, shouji, guhua, qq, email, gszhixingren, lianxijilu, goumaineirong, shihoufenxi);
                SqlCommand cmd = new SqlCommand(sql2, conn);
                cmd.CommandText = sql2;
                cmd.ExecuteNonQuery();
            }
            */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
