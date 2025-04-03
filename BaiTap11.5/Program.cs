using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap11._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a;
            Console.WriteLine("Nhấp số a: ");
            a = int.Parse(Console.ReadLine());
            int tong = 0;
            if (a % 2 == 0)
            {
                for (int i = 0; i <= a; i+=2)
                {
                    tong += i;
                }

                Console.WriteLine("tổng của số {0} = {1}", a, tong);
            }
            else
            {
                Console.WriteLine("Tôi không tính số lẻ");
            }    

            Console.ReadKey();

        }
    }
}
