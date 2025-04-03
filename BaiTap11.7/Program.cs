using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap11._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 10; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Số chia hết cho 3 = " + i);
                }
            }




            Console.ReadKey();  
        }
    }
}
