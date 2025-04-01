using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Gán bằng x = 1 ý nghĩa x = 1 
            // Gán bằng x += y ý nghĩa x = x + y 
            // Gán bằng x -= y ý nghĩa x = x - y 
            // Gán bằng x *= y ý nghĩa x = x * y 
            // Gán bằng x /= y ý nghĩa x = x / y 
            // Gán bằng x %= y ý nghĩa x = x % y 

            float x,y;
            x = 9;
            y = 4;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);


            x %= y;
            Console.WriteLine("x = " + x);

            Console.ReadKey();
        }
    }
}
