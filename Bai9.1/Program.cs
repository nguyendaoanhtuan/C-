using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9._1
{
    internal class Program
    {
        // đổi phông chữ và màu chữ, màu nền
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Red; // change màu kí tự


            Console.WriteLine("CHƯƠNG TRÌNH TIỀM KIẾM");
            Console.ForegroundColor= ConsoleColor.Yellow;

            Console.BackgroundColor = ConsoleColor.Green;// change màu nền
            Console.WriteLine("1. Tìm kiếm theo tên");
            Console.WriteLine("2. Tìm kiếm theo tác giả");
            Console.WriteLine("3. Tìm kiếm theo nhà xuất bản");
            Console.WriteLine("4. Tìm kiếm theo nhà tiêu đề");



            Console.ReadKey();
        }
    }
}
