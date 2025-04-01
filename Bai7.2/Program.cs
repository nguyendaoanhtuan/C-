using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float tong, hieu, x, y;

            Console.WriteLine("Nhập tổng: ");
            tong = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập hiệu: ");
            hieu = float.Parse(Console.ReadLine());

            y = (tong - hieu) / 2;
            x = tong - y;
            Console.WriteLine("Giá trị x cần tìm là: " + x);
            Console.WriteLine("Giá trị y cần tìm là: " + y);
            Console.ReadKey();

        }
    }
}
