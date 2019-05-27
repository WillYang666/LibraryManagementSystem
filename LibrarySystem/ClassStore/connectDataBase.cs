using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using System.Threading.Tasks;

namespace LibrarySystem
{
    static class  DataBaseApplication
    {
      
        static public string DataSource = "";
        static public string DataBaseName = "";
        static public string UserID = "";
        static public string PassWord = "";


        ///Data Source=(Local)          服务器地址        
        ///Initial Catalog=SimpleMESDB  数据库名称        
        ///User ID=sa                   数据库用户名        
        ///Password=sa       数据库密码
         
        

        //连接字符串
        public static SqlConnection conn;
        //打开数据库连接
        public static void OpenConn()
        {
            string connectionString = "Data Source="+DataSource+";Pooling=False;Max Pool Size = 1024;Initial Catalog="+DataBaseName+";Persist Security Info=True;User ID="+UserID+";Password="+PassWord+"";
            string SqlCon = connectionString;
            conn = new SqlConnection(SqlCon);
            if (conn.State.ToString().ToLower() == "open")
            {

            }
            else
            {
                conn.Open();
            }
        }
        //关闭数据库连接
        public static void CloseConn()
        {
            if (conn.State.ToString().ToLower() == "open")
            {
                conn.Close();
                conn.Dispose();

            }
        }

        // 查询并返回DataTable        
        static public DataTable GetDataTableValue(string sql)
        {
            OpenConn();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            CloseConn();
            return dt;
        }


        // 执行一个SQL操作:添加、删除、更新操作        
        static public void ExecuteNonQuery(string sql)
        {
            OpenConn();
            SqlCommand cmd;
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            CloseConn();
        }

    }
}
