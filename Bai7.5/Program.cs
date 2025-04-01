using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int thang, nam;
            Console.WriteLine("Nhập tháng: ");
            thang = int.Parse(Console.ReadLine());
           

            if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
            {
                Console.WriteLine("Tháng này có 31 ngày");
            }else if (thang == 4 || thang == 6 || thang == 9 || thang == 11){
                Console.WriteLine("Tháng này có 30 ngày");
            }
            else if (thang == 2)
            {
                Console.WriteLine("Nhập năm: ");
                nam = int.Parse(Console.ReadLine());
                if (((nam % 4 == 0) && (nam % 100 != 0)) || (nam % 400 == 0))
                {
                    Console.WriteLine("Năm nhuần nên tháng này có 29 ngày");
                }
                else
                {
                    Console.WriteLine("Năm không nhuẩn nên tháng này có 28 ngày");
                }
            }
            

            Console.ReadKey();
        }
    }
}
