using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            float a, b, c , danTa;
            Console.WriteLine("Nhập số a:");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số b:");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số c:");
            c = float.Parse(Console.ReadLine());

            danTa = b * b - 4 * a * c;
            if (danTa < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
            else if (danTa == 0)
            {
                float x;
                x = -(b / 2 * a);
                Console.WriteLine("Phương trình có nghiệm kép x1 = x2 = " + x);
            }
            else if (danTa > 0)
            {
                float x1, x2;
                x1 = (-b + danTa / danTa) / 2 * a;
                x2 = (-b - danTa / danTa) / 2 * a;
                Console.WriteLine("Giá trị x1 = " + x1);
                Console.WriteLine("Giá trị x2 = " + x2);
            }

            Console.ReadKey();
        }
    }
}
