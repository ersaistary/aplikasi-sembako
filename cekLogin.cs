using IOKOST.Config;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOKOST.Controller
{
    class cekLogin
    {
        Connection connection = new Connection();
        public bool cek_login(string username, string password)
        {
            try
            {
                connection.OpenConnection();
                MySqlDataReader reader = connection.reader("SELECT * FROM admin WHERE username='"
                    + username + "'AND password='" + password + "'");
                if (reader.Read())
                {
                    connection.CloseConnection();
                    return true;
                }
                else
                {
                    connection.CloseConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal");
            }
            return false;
        }
    }
}
