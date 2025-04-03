using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    //char
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            char ch1 = 'a'; // khai báo bắt buộc char là phải dùng nháy đơn
            Console.WriteLine(ch1);
            Console.WriteLine(ch1.GetType().ToString());

            char ch2 = (char)64;
            Console.WriteLine(ch2);
            Console.ReadKey();
        }
    }
}
