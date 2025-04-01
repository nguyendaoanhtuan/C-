using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6._1
{
    // Tapms tử tiền tố và hậu tố
    // ++ , --
    // a++, a-- (Viết phía sau biến) => Postfix
    // ++a, --a (Viết phía trước biến) => Prefix
    // Ưu tiên tính toán Postfix, Prefix
    // Prefix > Các phép toán > các phép gán giá trị biến bên trái dấu bằng > Postfix
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int x = 1, y = 2;
            int z = x++ - ++y + 1;
            Console.WriteLine("Giá trị của z:" + z);
            Console.WriteLine("Giá trị của x:" + x);
            Console.WriteLine("Giá trị của y:" + y);

            Console.ReadKey();
        }
    }
}
