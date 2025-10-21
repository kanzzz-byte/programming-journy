using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_fungsi_kali
{
    internal class Program
    {
        // Fungsi Kali: menerima tiga bilangan dan menampilkan hasil perkalian
        static void kali(double a, double b, double c)
        {
            double hasil = a * b * c;
            Console.WriteLine($"Hasil perkalian dari {a}, {b}, {c} adalah : {hasil}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("===== Program Perkalian 3 Angka ====");

            // Meminta input dari pengguna 
            Console.WriteLine("Masukkan angka pertama : ");
            double angka1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Masukkan angka kedua : ");
            double angka2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Masukkan angka ketiga : ");
            double angka3 = Convert.ToDouble(Console.ReadLine());

            // Memanggil fungsi kali 
            kali(angka1, angka2, angka3);

            Console.WriteLine("==== Program Selesai ====");
        }
    }
}
