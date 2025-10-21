using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIK_6._8_FERLITA_AURAKANZA_XPPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String ulangiPilihan;

            do
            {
                // --- Blok Proses yang Akan Diulang ---
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Masukkan nama Anda : ");
                string nama = Console.ReadLine();
                Console.WriteLine($"Halo, {nama}! Proses telah selesi. ");
                // -------------------------------------
                // Pertanyaan untuk Mengulang 
                Console.WriteLine("Apakah Anda ingin lagi ? (ya/tidak) : ");
                ulangiPilihan = Console.ReadLine().ToLower(); // Mengambil input dan mengubah ke huruf kecil 

                Console.WriteLine(); // Baris kosong untuk kerapian 

                // Kondisi diperiksa di akhir : Ulangi selama pengguna mengetik "ya"
            } while (ulangiPilihan == "ya");
            Console.WriteLine("Terima kasih. Program selesai. ");
        }
    }
}
