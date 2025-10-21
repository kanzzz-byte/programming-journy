using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace TUGAS_FOR_FERLITA_AURAKANZA_XPPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabel Perkalian 5");
            for (int i = 1; i <= 10; i++)
            {
                int hasil = 5 * i;
                Console.WriteLine($"5 * {i} = {hasil} ");
            }
        }
    }
}
