using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string hoTen;
            float diemVan;
            float diemToan;

            Console.WriteLine("Nhập họ và tên");
            hoTen = Console.ReadLine();

            Console.WriteLine("Nhập điểm toán");
            diemToan = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập điểm văn");
            diemVan = float.Parse(Console.ReadLine());

            Console.WriteLine("Tên: {0}, Điểm toán: {1}, Điểm văn: {2}",hoTen,diemToan,diemVan);

            Console.ReadKey();
        }
    }
}
