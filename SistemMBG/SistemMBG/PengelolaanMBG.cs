using System;
using System.Collections.Generic;

namespace SistemMBG
{
    public class PengelolaMBG
    {
        private List<Sekolah> daftarSekolah =
            new List<Sekolah>();

        private List<PaketMBG> daftarPaket =
            new List<PaketMBG>();

        // Hubungan Aggregation:
        // Objek Sekolah dibuat secara terpisah.
        // PengelolaMBG hanya menyimpan kumpulan objek Sekolah.

        public void TambahSekolah(Sekolah sekolah)
        {
            daftarSekolah.Add(sekolah);
        }

        public void TambahPaket(PaketMBG paket)
        {
            daftarPaket.Add(paket);
        }

        public void TampilkanDataMBG()
        {
            Console.WriteLine("\n=== DATA SEKOLAH ===");

            foreach (Sekolah sekolah in daftarSekolah)
            {
                sekolah.TampilInfo();

                Console.WriteLine("--------------------");
            }

            Console.WriteLine("\n=== DATA PAKET MBG ===");

            foreach (PaketMBG paket in daftarPaket)
            {
                Console.WriteLine(
                    "ID Paket   : " + paket.IdPaket
                );

                Console.WriteLine(
                    "Nama Paket : " + paket.NamaPaket
                );

                Console.WriteLine(
                    "Stok Dapur : " + paket.StokDapur
                );

                Console.WriteLine("--------------------");
            }
        }
    }
}
