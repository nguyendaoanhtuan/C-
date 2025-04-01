using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    //If - else
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float diemTN;
            Console.WriteLine("Nhập vào điểm trắc nghiệm:");
            diemTN = float.Parse(Console.ReadLine());

            // Check điều kiện
            if (diemTN > 7)
                Console.WriteLine("Bạn đã đỗ, điểm tốt nghiệp của bạn là: {0}", diemTN);
            else
                Console.WriteLine("Bạn đã tạch, điểm tốt nghiệp của bạn là: {0}", diemTN);

            Console.ReadKey();
        }
    }
}
