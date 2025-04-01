using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int thang;
            Console.WriteLine("Nhập tháng trong năm: ");
            thang = int.Parse(Console.ReadLine());

            if (thang == 1 || thang == 2 || thang == 3)
            {
                Console.WriteLine("Tháng đó thuộc quý 1");
            }
            else if (thang == 4 || thang == 5 || thang == 6)
            {
                Console.WriteLine("Tháng đó thuộc quý 2");
            }
            else if (thang == 7 || thang == 8 || thang == 9)
            {
                Console.WriteLine("Tháng đó thuộc quý 3");
            }
            else if (thang == 10 || thang  == 11 || thang == 12)
            {
                Console.WriteLine("Tháng đó thuộc quý 4");
            }    

            Console.ReadKey ();
        }
    }
}
