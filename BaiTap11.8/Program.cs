using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap11._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float tong = 0;
            float dem = 1;


            for (int i = 1; i <= 10; i++)
            {
                tong += (dem *= i);
            }

            Console.WriteLine("Tổng = " + tong);

            Console.ReadKey();
        }
    }
}
