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
            int[] lst = { 1, 3, 5, 7, 9 };

            foreach (int i in lst)
            {
                Console.WriteLine("i = " + i);
            }

            Console.ReadKey();
        }
    }
}
