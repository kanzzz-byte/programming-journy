using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTK_6._5_FERLITA_AURAKANZA_XPPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Inisalisasi variabel penghitung (counter)
            int angka = 1;

            Console.WriteLine(" Menampilkan angka 1 sampai 20 : ");

            // 2. Blok 'do-while'
            do
            {
                // Tampilkan nilai variabel 'angka' saat ini 
                Console.WriteLine(angka);

                // Tampilkan nilai 'angka' sebanyak 1 (increement)
                angka++;
                // uji kondisi : Loop berlanjut selama 'angka' kurang dari atau sama dengan 
            } while (angka <= 20);


            Console.WriteLine("Selesai. ");

        }
    }
}
