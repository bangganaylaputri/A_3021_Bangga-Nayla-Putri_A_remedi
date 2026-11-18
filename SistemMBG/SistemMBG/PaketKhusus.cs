
using System;

namespace SistemMBG
{
    public class PaketKhusus : PaketMBG
    {
        public string JenisDiet { get; set; }

        public PaketKhusus(
            string id,
            string nama,
            int stok,
            string jenisDiet
        ) : base(id, nama, stok)
        {
            JenisDiet = jenisDiet;
        }

        // Menghitung biaya paket khusus
        public override decimal HitungBiaya(int jumlah)
        {
            return jumlah * 20000;
        }

        // Menampilkan informasi diet
        public void TampilDiet()
        {
            Console.WriteLine(
                "Jenis Diet : " + JenisDiet
            );
        }
    }
}
