using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời nhập vào một chuỗi");
            string s = Console.ReadLine();
            string chuoiSo = "";
            string chuoi = "";

            foreach (char c in s)
            {
                if(char.IsDigit(c))
                {
                    chuoiSo += c;
                }
                else if (char.IsLetter(c)) 
                {
                    chuoi += c;
                }    
            }
            Console.WriteLine(chuoiSo);
            Console.WriteLine(chuoi);

            Console.ReadKey();  
        }
    }
}
