using IOKOST.Config;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOKOST.Model
{
    class transaksiController
    {
        Connection connection = new Connection();
        public bool Insert(modelTransaksi transaksi)
        {
            Boolean status = false;
            try
            {
                connection.OpenConnection();
                connection.ExecuteQuery("INSERT INTO transaksi (nama, tanggal, total, id) VALUES('" + transaksi.Nama + "','" + transaksi.Tanggal + "','" + transaksi.Total + "','" + transaksi.Id + "')");
                status = true;
                MessageBox.Show("Data berhasil di input");
                connection.CloseConnection();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "GAGAL");
            }
            return status;
        }

        public bool Update(modelTransaksi transaksi)
        {
            Boolean status = false;
            try
            {
                connection.OpenConnection();
                connection.ExecuteQuery("UPDATE transaksi SET " +
                    "nama='" + transaksi.Nama + "'," +
                    "tanggal='" + transaksi.Tanggal + "'," +
                    "total='" + transaksi.Total +
                    "'WHERE id='" + transaksi.Id + "'");
                status = true;
                MessageBox.Show("Data berhasil diubah");
                connection.CloseConnection();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "GAGAL");
            }
            return status;
        }

        public bool Delete(modelTransaksi transaksi)
        {
            Boolean status = false;
            try
            {
                connection.OpenConnection();
                connection.ExecuteQuery("DELETE FROM transaksi WHERE id='" + transaksi.Id + "'");
                status = true;
                MessageBox.Show("Data berhasil di hapus");
                connection.CloseConnection();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "GAGAL");
            }
            return status;
        }
        public int getId()
        {
            int x = 0;
            try
            {
                connection.OpenConnection();
                MySqlDataReader reader = connection.reader("SELECT id FROM transaksi ORDER BY id DESC LIMIT 1");
                if (reader.Read())
                {

                    x = Convert.ToInt32(reader["id"]);
                    connection.CloseConnection();
                    return x;
                }
                else
                {
                    connection.CloseConnection();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal");
            }
            return x;
        }
    }
}
