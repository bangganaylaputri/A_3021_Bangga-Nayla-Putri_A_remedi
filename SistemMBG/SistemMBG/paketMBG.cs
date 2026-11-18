
using System;

namespace SistemMBG
{
    public abstract class PaketMBG
    {
        private string idPaket;
        private string namaPaket;
        private int stokDapur;

        // Property untuk membaca data
        public string IdPaket
        {
            get { return idPaket; }
        }

        public string NamaPaket
        {
            get { return namaPaket; }
        }

        public int StokDapur
        {
            get { return stokDapur; }
        }

        // Constructor
        public PaketMBG(string id, string nama, int stok)
        {
            if (stok < 0)
            {
                throw new ArgumentException(
                    "Stok tidak boleh negatif!"
                );
            }

            idPaket = id;
            namaPaket = nama;
            stokDapur = stok;
        }

        // Method khusus untuk mengurangi stok
        public bool KurangiStok(int jumlah)
        {
            if (jumlah <= 0)
            {
                return false;
            }

            if (jumlah > stokDapur)
            {
                return false;
            }

            stokDapur = stokDapur - jumlah;

            return true;
        }

        // Abstract method untuk polymorphism
        public abstract decimal HitungBiaya(int jumlah);
    }
}
