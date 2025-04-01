using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float a, b , s, p;
            Console.WriteLine("Nhập số thực a");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập sô thực b");
            b = float.Parse(Console.ReadLine());

            if (a < b) {
                Console.WriteLine("Nhập sai vui lòng nhập lại !!");
            }
            else
            {
                s = a * b;
                p = (a + b) * 2;

                Console.WriteLine("Diện tích hình chữ nhật là: " + s);
                Console.WriteLine("Chu vi hình chữ nhật là: " + p);
            }
        }
    }
}
