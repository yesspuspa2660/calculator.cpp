using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemprograman2660
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan("190302123", "kiki", 2000000);
            Karyawan karyawan2 = new Karyawan("190302124", "iqro", 3500000);
         

            Console.WriteLine("No. \t\t NIK \t\t GajiBulanan");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1. {0} \t {1} \t {2}");
            Console.WriteLine("2. {0} \t {1} \t {2}");
            Console.WriteLine("3. {0} \t {1} \t {3}");

            Console.WriteLine("\n\n Yeayyyyy kenaikan gaji 10%!!");

            Console.WriteLine("No. \t\t NIK \t\t Nama \t\t GajiBulanan");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1. {0} \t {1} \t {2}");
            Console.WriteLine("2. {0} \t {1} \t {2}");
            Console.WriteLine("3. {0} \t {1} \t {3}");

            Console.ReadKey();

        }
    }
}
