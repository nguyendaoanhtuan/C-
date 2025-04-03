using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Ép kiểu char cho dữ liệu nhập vào
            char ch3 = char.Parse("b");
            Console.WriteLine(ch3);
            Console.WriteLine(ch3.GetType().ToString());
            // CHuyển đổi kiểu dữ liệu

            char ch4 = Convert.ToChar("t");
            Console.WriteLine(ch4);
            Console.WriteLine(ch4.GetType().ToString());
            Console.ReadKey();
        }
    }
}
