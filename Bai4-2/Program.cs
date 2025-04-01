using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int a;
            Console.WriteLine("Nhập số nguyên a:");
            a = int.Parse(Console.ReadLine());

            a += 3;
            Console.WriteLine("kết quả a : {0}", a);

            a -= 5;
            Console.WriteLine("kết quả a : {0}", a);

            a *= 2;
            Console.WriteLine("kết quả a : {0}", a);

            a /= 9;
            Console.WriteLine("kết quả a : {0}", a);

            a %= 5;
            Console.WriteLine("kết quả a : {0}", a);

            int b = 2;

            a -= (b + 7);
            Console.WriteLine("kết quả a : {0}", a);

            Console.ReadKey();
        }
    }
}
