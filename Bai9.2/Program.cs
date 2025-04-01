using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Tìm kiếm theo tên");
            Console.WriteLine("2. Tìm kiếm theo tác giả");
            Console.WriteLine("3. Tìm kiếm theo nhà xuất bản");
            Console.WriteLine("4. Tìm kiếm theo nhà tiêu đề");
            int a;
            Console.WriteLine("Nhập a để lựa chọn: ");
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Tìm theo tên");
                    break;
                case 2:
                    Console.WriteLine("Tìm theo tác giả");
                    break;
                case 3:
                    Console.WriteLine("Tìm theo nhà xuất bản");
                    break;
                case 4:
                    Console.WriteLine("Tìm theo tiêu đề");
                    break;
                default:
                    Console.WriteLine("Tìm kiếm không hợp lệ");
                    break;

            }    



            Console.ReadKey();
        }
    }
}
