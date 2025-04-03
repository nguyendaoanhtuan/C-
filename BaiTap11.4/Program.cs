using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap11._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("Nhập n: ");
            n = int.Parse(Console.ReadLine());
            int giaiThua = 1;

            for (int i = 1; i <= n; i++)
            {
                giaiThua *=  i;
            }
            Console.WriteLine("Giai thừa của {0} = {1}", n, giaiThua);

            Console.ReadLine();
        }
    }
}
