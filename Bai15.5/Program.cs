using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string a = @"tôi chăm học
                         tôi chịu khó
                         tôi đẹp zai";
            string[] lst = a.Split(' ');
            int dem = 0;
            foreach (string s in lst)
            {
               if("tôi".Equals(s))
                {
                    dem++;
                }    
            }
            Console.WriteLine("Có {0} trừ tôi ở trong string a",dem);

            Console.ReadKey();
        }
    }
}
