using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIK_6._6_FERLITA_AURAKANZA_XPPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka;

            // Blok 'do' akan dieksikusi minimal satu kali 
            do
            {
                Console.Write(" Masukkan angka genap : ");
                // Mencoba membaca input dari penguna
                if (int.TryParse(Console.ReadLine(), out angka))
                {
                    Console.WriteLine(" Input tidak valid. Silahkan masukkan angka. ");
                    // Jika input tidak valid, set angka = 1 (ganjil) agar loop berlanjut 
                    angka = 1;
                    continue; // Lanjutkan ke iterasi berikutanya
                }
                // Memeriksa apakah angka tersebut ganjil 
                if (angka % 2 != 0)
                {
                    Console.WriteLine($"aNGKA {angka} adalah ganjil. Coba lagi. ");
                }
                // Kondosi diperiksa di akhir. Loop berlanjut 
            } while (angka % 2 != 0);
            Console.WriteLine($"Selamat! Anda nasukkan angka genap : {angka} ");
        }
    }
}
