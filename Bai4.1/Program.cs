using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // So sánh == Biểu đạt : 1 == 1 Kết quả : True
            // So sánh != Biểu đạt : 1 != 1 Kết quả : False
            // So sánh > Biểu đạt : 1 > 2 Kết quả : False
            // So sánh < Biểu đạt : 2 < 1 Kết quả : False
            // So sánh >= Biểu đạt : 2 >= 1 Kết quả : True
            // So sánh <= Biểu đạt : 2 <= 1 Kết quả : True

            int n;
            Console.WriteLine("Nhập số nguyên n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Bạn vừa nhập vào số  {0}:", n);

            if (n % 2 != 0)
                Console.WriteLine("n {0} là số lẻ", n);
            else
                Console.WriteLine("n {0} là số chẵn", n);

            Console.ReadKey();

        }
    }
}
