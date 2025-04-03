using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11._1
{
    internal class Program
    {
        //foreach
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] lst = { 1, 3, 5, 7, 8, 10, 12 };
            int thang;
            Console.WriteLine("Nhập tháng bất kì: ");
            thang = int.Parse(Console.ReadLine());
            foreach (int i in lst)
            {
                Console.WriteLine("i = " + i);
                if (thang == i)
                {
                    Console.WriteLine("Tháng bạn nhập có 31 ngày");
                    break;
                }    

            }

            Console.ReadKey();
        }
    }
}
