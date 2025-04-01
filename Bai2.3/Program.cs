using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // tự động ép kiểu dữ liệu
            var y = 113;
            Console.WriteLine("Kiểu dữ liệu của y là {0}", y.GetType().ToString());

            var z = "toan";

            Console.WriteLine("Kiểu dữ liệu của z là {0}", z.GetType().ToString());

            var k = 17.9;
            Console.WriteLine("Kiểu dữ liệu của k là {0}" ,k.GetType().ToString());
            Console.ReadKey();
        }
    }
}
