using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap11._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("Nhập số n: ");
            n = int.Parse(Console.ReadLine());
            int tong = 0;

            if (n % 2 != 0) 
            {
                for (int i = 0; i <= n; i++)
                {
                   if(i % 2 != 0)
                    {
                        if(i == 3)
                        {
                            //break;
                            continue;
                        }    
                        tong += i;
                    }              
                }   
                    Console.WriteLine("tổng của giá trị {0} = {1}" , n, tong);
            }
            else
            {
                Console.WriteLine("Tôi không tính số chẵn");
            }

            Console.ReadKey();
        }
    }
}
