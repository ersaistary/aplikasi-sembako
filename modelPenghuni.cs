using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOKOST.Model
{
    class modelPenghuni
    {
        public string nama, nik, no_hp, jml, kontak;
        public int no_kamar;

        public modelPenghuni()
        {
        }

        public modelPenghuni(string nama, string nik, string no_hp, string jml, string kontak, int no_kamar)
        {
            this.Nama = nama;
            this.Nik = nik;
            this.No_hp = no_hp;
            this.Jml = jml;
            this.Kontak = kontak;
            this.No_kamar = no_kamar;
        }

        public string Nama { get => nama; set => nama = value; }
        public string Nik { get => nik; set => nik = value; }
        public string No_hp { get => no_hp; set => no_hp = value; }
        public string Jml { get => jml; set => jml = value; }
        public string Kontak { get => kontak; set => kontak = value; }
        public int No_kamar { get => no_kamar; set => no_kamar = value; }

    }
}
