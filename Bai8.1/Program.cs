using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float diemTrungBinh;
            Console.WriteLine("Nhập điểm trung bình");
            diemTrungBinh = float.Parse(Console.ReadLine());

            string ketQua = (diemTrungBinh >= 8) ? "Giỏi" : ((diemTrungBinh < 8) && (diemTrungBinh >= 6.5)) ? "Khá" : ((diemTrungBinh < 6.5) && (diemTrungBinh >= 5)) ? "Trung bình" : "Yếu";

            Console.WriteLine("Điểm của bạn là {0} và xếp loại {1}", diemTrungBinh, ketQua);
            Console.ReadKey();
        }
    }
}
