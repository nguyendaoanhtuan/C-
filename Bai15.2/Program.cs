using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string str1 = "English = 78 Science = 83 Math = 68 History = 65";
            string[] lst = str1.Split(' ');
            string strSo = "";
            foreach (string x in lst)
            {
                foreach (char c in x)
                {
                    if(char.IsDigit(c))
                    {
                        strSo += x + " ";
                        break;
                    }    
                }    
            }

            Console.WriteLine(strSo);

            strSo = strSo.Trim();
            string[] lst2 = strSo.Split(' ');
            int tong = 0;
            
            foreach (string x in lst2)
            {
                Console.WriteLine(x);
                tong += int.Parse(x);
            }
            float tbc = (float)tong/lst2.Length;
            Console.WriteLine("tổng các số cần tìm là: " +tong);

            Console.WriteLine("Trung bình là : "+ tbc);
      
            Console.ReadKey();
        }
    }
}
