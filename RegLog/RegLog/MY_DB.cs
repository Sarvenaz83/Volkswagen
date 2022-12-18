using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls.Crypto;
using System.Windows.Forms;

namespace RegLog
{
    class MY_DB
    {

        MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=Milad713$");
        public MySqlConnection getConnection
        {
            get
            {
                return conn;
            }
        }
        public void openConnection()
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
