using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11._2
{ //continue
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int tong = 0;

            for (int i = 0; i <= 5; i++)
            {
                if (i == 3)
                {
                    continue; // nếu i mà == 3 thì sẽ bỏ qua
                }
                else
                {
                    Console.WriteLine("i = " + i);
                    tong += i;
                    Console.WriteLine("tổng = " + tong);
                }
            }


            Console.ReadKey();
        }
    }
}
