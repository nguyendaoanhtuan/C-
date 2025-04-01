using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    internal class Program
    { // vòng lặp for
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int tong = 0;


            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine("i= " + i);
                tong += i;
                Console.WriteLine("tong = " + tong);
            }

            Console.ReadKey();
        }
    }
}
