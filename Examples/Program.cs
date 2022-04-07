using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 100;
            int sayi1;
            BiseyYap(ref sayi);
            BiseyYap1(out sayi1);
            Console.WriteLine(sayi);
            Console.WriteLine(sayi1);


            Console.ReadKey();
        }

        static void BiseyYap(ref int sayi)
        {
            sayi = 99;
        }
        static void BiseyYap1(out int sayi)
        {
            sayi = 99;
        }

    }
}
