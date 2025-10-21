using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_fungsi_KonversiSuhu
{
    internal class Program
    {
        // Fungsi KonversiSuhu : mengubah suhu dari Celcius ke Fahrenhiet 
        static double konversisuhu(double c)
        {
            double f = (c * 9 / 5) + 32; 
            return f;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program KonversiSuhu Celcius ke Fahrenhiet ===");

            // Input dari pengguna 
            Console.Write(" Masukkan Suhu dalam Celcius : ");
            double suhuC = Convert.ToDouble(Console.ReadLine());

            // Panggil fungsi KonversiSuhu 
            double suhuF = konversisuhu(suhuC);

            // Tampilkan hasil konversi 
            Console.WriteLine($"{suhuC}°C sama dengan {suhuF}°F");

            Console.WriteLine("=== Program Selesai ==="); 
        }
    }
}
