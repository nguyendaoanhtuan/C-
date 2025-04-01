using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            while (true)
            {
                n++;
                Console.WriteLine("N =" +n);
                if (n == 100)
                    break;

            }

            Console.ReadKey();
        }
    }
}
