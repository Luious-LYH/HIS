using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp1
{
    internal class Mysql //用来连接本地数据库的类
    {
        public static MySqlCommand Con_mysql(string sql_code)
        {
            string data = "server=localhost;database=net;uid = root; pwd='Lyh20010914...';charset=utf8";//数据库ip地址,名字,账户，密码
            MySqlConnection con = new MySqlConnection(data);
            con.Open();
            MySqlCommand com = new MySqlCommand(sql_code,con);
            return com;
        }
    }
}
