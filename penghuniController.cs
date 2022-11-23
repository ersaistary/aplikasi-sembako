using IOKOST.Config;
using IOKOST.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOKOST.Controller
{
    class penghuniController
    {
        Connection connection = new Connection();
        public bool Insert(modelPenghuni penghuni)
        {
            Boolean status = false;
            try
            {
                connection.OpenConnection();
                connection.ExecuteQuery("INSERT INTO profile (nama, nik, no_hp, jml, kontak, no_kamar) VALUES('" + penghuni.Nama + "','" + penghuni.Nik + "','" + penghuni.No_hp + "','" + penghuni.Jml + "','" + penghuni.Kontak + "','" + penghuni.No_kamar + "')");
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

        public bool Update(modelPenghuni penghuni)
        {
            Boolean status = false;
            try
            {
                connection.OpenConnection();
                connection.ExecuteQuery("UPDATE profile SET " +
                    "nama='" + penghuni.nama + "'," +
                    "no_hp='" + penghuni.no_hp + "'," +
                    "jml='" + penghuni.jml + "'," +
                    "kontak='" + penghuni.kontak + "'," +
                    "no_kamar='" + penghuni.no_kamar +
                    "'WHERE nik='" + penghuni.nik + "'");
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

        public bool Delete(modelPenghuni penghuni)
        {
            Boolean status = false;
            try
            {
                connection.OpenConnection();
                connection.ExecuteQuery("DELETE FROM profile WHERE nik='" + penghuni.Nik + "'");
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
    }
}
