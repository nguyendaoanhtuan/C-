using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap11._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a;
            Console.WriteLine("Nhập số nguyên a:");
            a = int.Parse(Console.ReadLine());

            while (a <= 0)
            {
                Console.WriteLine("Nhập sai!! Nhập lại a: ");
                a = int.Parse(Console.ReadLine());
            }

            int demUoc = 0;
            for (int i = 1; i <= a; i++)
            {
                if(a % i == 0)
                {
                    demUoc++;
                    Console.WriteLine(demUoc);
                }    
                
            }
            if (demUoc == 2)
            {
                Console.WriteLine("{0} là số nguyên tố", a);
            }
            else
            {
                Console.WriteLine("Không phải là số nguyên tố");
            }    

            Console.ReadKey();
        }
    }
}
