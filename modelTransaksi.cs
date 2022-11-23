using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOKOST.Model
{
    class modelTransaksi
    {
        private int id;
        private int total;
        private string nama;
        private string tanggal;

        public modelTransaksi() { }

        public modelTransaksi(int id, int total, string nama, string tanggal)
        {
            this.Id = id;
            this.Total = total;
            this.Nama = nama;
            this.Tanggal = tanggal;
        }

        public int Id { get => id; set => id = value; }
        public int Total { get => total; set => total = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Tanggal { get => tanggal; set => tanggal = value; }
    }
}
