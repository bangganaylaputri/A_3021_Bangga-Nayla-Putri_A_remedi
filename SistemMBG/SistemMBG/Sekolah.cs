
using System;

namespace SistemMBG
{
    public class Sekolah
    {
        public string idSekolah;
        public string namaSekolah;
        public int jumlahPaketDiterima;

        public Sekolah(string id, string nama)
        {
            idSekolah = id;
            namaSekolah = nama;
            jumlahPaketDiterima = 0;
        }

        public void TampilInfo()
        {
            Console.WriteLine("ID Sekolah       : " + idSekolah);
            Console.WriteLine("Nama Sekolah     : " + namaSekolah);
            Console.WriteLine("Paket Diterima   : " + jumlahPaketDiterima);
        }
    }
}
