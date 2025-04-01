using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a = 1;

            int tong = 0;

            do
            {
                tong += a; //tong = tong + a;
                a++;
                Console.WriteLine("tong = " + tong);
                Console.WriteLine("a = " + a);

            } while (a <= 5);

            Console.WriteLine("Tổng từ 1 đến 5 là: " + tong);
            Console.ReadKey();
        }
    }
}
