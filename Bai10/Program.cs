using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    // vòng lặp while
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int x = 0;
            while(x <= 5)
            {
                Console.WriteLine("x= " + x);
                x++;
            }    
            Console.ReadKey();
        }
    }
}
