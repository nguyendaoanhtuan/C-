using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    // Cấu trúc rẽ nhánh switch-case
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a;
            Console.WriteLine("Nhập số a: ");
            a = int.Parse(Console.ReadLine());

            int div = a % 2;
            // switch - case
            switch(div)
            {
                case 0:
                    Console.WriteLine("Số {0} là số chẵn", a);
                    break;
                default:
                    Console.WriteLine("Số {0} là số lẻ", a);
                    break; 
            }    


            Console.ReadKey();
        }
    }
}
