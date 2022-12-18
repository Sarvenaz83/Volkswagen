using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Configuration;
using System.Windows.Forms;
using Org.BouncyCastle.Utilities.Collections;
using System.Drawing;


namespace RegLog
{
    class USER
    {
        MY_DB dB= new MY_DB();
        public bool usernameExist(string username)
        {
            string query = "SELECT * FROM `users`.`users` WHERE 'username' =@un;";
            MySqlCommand command = new MySqlCommand(query,dB.getConnection);
            command.Parameters.Add("@un",MySqlDbType.VarChar).Value = username;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            command.ExecuteReader();
            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool insertUser(string firstname, string lastname, string username, string password)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`.`users`(`firstname`, `lastname`, `username`, `password`) VALUES (@fn,@ln,@un,@pass)", dB.getConnection);
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@un", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
           
            dB.openConnection();
            if(command.ExecuteNonQuery() == 1)
            {
                dB.closeConnection();
                return true;
            }
            else
            {
                dB.closeConnection();
                return false;
            }
            
        }
        
    }
}
