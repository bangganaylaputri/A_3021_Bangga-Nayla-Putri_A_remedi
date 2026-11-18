
using System;

namespace SistemMBG
{
    public class DistribusiMBG : DapatDidistribusikan
    {
        private Sekolah sekolahTujuan;
        private PaketMBG paket;
        private int jumlah;

        public DistribusiMBG(
            Sekolah sekolah,
            PaketMBG paketMakanan,
            int jumlahKirim
        )
        {
            sekolahTujuan = sekolah;
            paket = paketMakanan;
            jumlah = jumlahKirim;
        }

        public void KirimPaket()
        {
            // Memeriksa jumlah pengiriman
            if (jumlah <= 0)
            {
                Console.WriteLine(
                    "Distribusi gagal! Jumlah harus lebih dari 0."
                );

                return;
            }

            // Memeriksa stok dapur
            if (jumlah > paket.StokDapur)
            {
                Console.WriteLine(
                    "Distribusi gagal! Stok dapur tidak mencukupi."
                );

                return;
            }

            // Mengurangi stok melalui method khusus
            bool berhasil = paket.KurangiStok(jumlah);

            if (berhasil)
            {
                // Menambah paket yang diterima sekolah
                sekolahTujuan.jumlahPaketDiterima += jumlah;

                Console.WriteLine(
                    "Distribusi MBG berhasil! Sebanyak "
                    + jumlah +
                    " paket makanan telah dikirim ke sekolah "
                    + sekolahTujuan.namaSekolah
                );
            }
            else
            {
                Console.WriteLine(
                    "Distribusi gagal! Stok tidak berubah."
                );
            }
        }
    }
}
