using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegLog
{
    public class Cars
    {
        MY_DB dB = new MY_DB();
        public bool insertCarsInfo(string automatemodel, string manuellmodel, string color, string time, string date)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO  `users`.`carsinfo`(`automatemodell`, `manuellmodell`, `color`, `time`, `date`) VALUES(@autmo, @manumo, @col, @time, @date)", dB.getConnection);
            command.Parameters.Add("@autmo", MySqlDbType.VarChar).Value = automatemodel;
            command.Parameters.Add("@manumo", MySqlDbType.VarChar).Value = manuellmodel;
            command.Parameters.Add("@col", MySqlDbType.VarChar).Value = color;
            command.Parameters.Add("@time", MySqlDbType.VarChar).Value = time;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = date;
            dB.openConnection();
            if (command.ExecuteNonQuery() == 1)
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
