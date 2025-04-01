using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n;
            Console.WriteLine("Nhập số nguyên n");
            n = int.Parse(Console.ReadLine());

            while (n < 1 || n > 99 )
            {
                Console.WriteLine("Nhập sai!! bạn hãy nhập lại: ");
                n = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("N= " + n);

            Console.ReadKey();
        }
    }
}
