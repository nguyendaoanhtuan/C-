using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap11._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            int giaiThua = 1;
            int i = 1;
            Console.WriteLine("Nhập giá trị n");
            n= int.Parse(Console.ReadLine());

            while (i <= n) {
                giaiThua *= i;
                i++;
            }

            Console.WriteLine("Giai thừa của {0} = {1}", n , giaiThua);

            Console.ReadKey();
        }
    }
}
