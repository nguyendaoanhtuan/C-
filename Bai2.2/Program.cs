using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string hoTen;
            float diemToan;
            float diemVan;

            Console.WriteLine("Nhập họ và tên:");
            hoTen = Console.ReadLine();

            // ép kiểu dữ liệu
            Console.WriteLine("Nhập điểm Toán:");
            diemToan = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập điểm Văn:");
            diemVan = float.Parse(Console.ReadLine());

            Console.WriteLine("Học sinh {0} có điểm toán là {1}, có điểm văn là {2}", hoTen, diemToan, diemVan);

            Console.ReadKey();
        }
    }
}
