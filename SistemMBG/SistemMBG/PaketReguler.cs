
using System;

namespace SistemMBG
{
    public class PaketReguler : PaketMBG
    {
        public PaketReguler(
            string id,
            string nama,
            int stok
        ) : base(id, nama, stok)
        {
        }

        // Menghitung biaya paket reguler
        public override decimal HitungBiaya(int jumlah)
        {
            return jumlah * 15000;
        }

        // Menampilkan isi paket
        public void TampilIsiPaket()
        {
            Console.WriteLine(
                "Isi Paket : Nasi, Ayam, Sayur, dan Buah"
            );
        }
    }
}
