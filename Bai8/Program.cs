using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    //Toán tử 3 ngôi
    /*
     Biến = biểu thức 1 (điều kiện) ? (true) biểu thức 2 : (sai) biểu thức 3
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("Nhập số n: ");
            n = int.Parse(Console.ReadLine());

            string traLoi  = (n % 2 == 0) ?   "chẵn" : " lẻ";
            Console.WriteLine(traLoi);

            Console.ReadKey();
        }
    }
}
