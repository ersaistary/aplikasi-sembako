using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOKOST.Config
{
    class Connection
    {
        string ConnectionString = "Server=localhost;Database=iokost;Uid=root;Pwd=;";
        MySqlConnection con;

        public void OpenConnection()
        {
            con = new MySqlConnection(ConnectionString);
            con.Open();
        }

        public void CloseConnection()
        {
            con.Close();
        }

        public MySqlDataReader reader(String query)
        {
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public void ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, con);
            command.ExecuteNonQuery();
        }

        public object ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, ConnectionString);
            DataSet data = new DataSet();
            adapter.Fill(data);
            object x = data.Tables[0];
            return x;
        }
    }
}
