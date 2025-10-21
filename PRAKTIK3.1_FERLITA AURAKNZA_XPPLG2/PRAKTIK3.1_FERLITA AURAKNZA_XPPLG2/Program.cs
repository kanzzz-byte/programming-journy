using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIK3._1_FERLITA_AURAKNZA_XPPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input angka pertama dan kedua 
            Console.Write("Masukkan angka pertama:");
                int angka1 = int.Parse(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            int angka2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n---- Hasil Operasi Penjumlahan ----");

            // PENJUMLAHAN (+)
            Console.WriteLine($" {angka1} + {angka2} = {angka1 + angka2} ");
        }
    }
}
