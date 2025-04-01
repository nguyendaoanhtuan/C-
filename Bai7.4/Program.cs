using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int  nam;
            Console.WriteLine("Nhập năm: ");
            nam = int.Parse(Console.ReadLine());

            if (((nam % 4 == 0) && (nam % 100 != 0)) || (nam % 400 == 0))
            {
                Console.WriteLine("Năm nhuần");
            }else
            {
                Console.WriteLine("Năm không nhuần");
            }    


            Console.ReadKey();
        }
    }
}
