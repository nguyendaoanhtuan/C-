using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap11._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /* int n = 1;
             int tong = 0;

             Console.WriteLine("Nhập vào số nguyên n: ");
             n = int.Parse(Console.ReadLine());

             for (int i = 1; i < n; i++)
             {
                 if(n%i == 0)
                 {
                     tong += i;
                 }    
             }
             if(tong == n)
             {
                 Console.WriteLine("Số {0} là số hoàn hảo" , n);
             }else
             {
                 Console.WriteLine("Số {0} không phải số hoàn hảo", n);
             }    
             */
            

            for (int n = 1; n <= 1000; n++)
            {
                int tong = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        tong += i;
                    }
                }
                if (tong == n)
                {
                    Console.WriteLine("Số {0} là số hoàn hảo", n);
                }
            }

            Console.ReadKey();
        }
    }
}
