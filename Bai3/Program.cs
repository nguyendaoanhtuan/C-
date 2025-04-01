using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Hằng số là những giá trị không đổi trong suốt quá trình chạy chương trình
            // <const> <type> <Tên type> = giá trị

            const int doSoi = 100;
            const int doDong = 0;
            const double PI = 3.14;

            Console.WriteLine("Độ đông nước là {0}", doDong);
            Console.WriteLine("Độ sôi nước là {0}", doSoi);
            Console.WriteLine("Số pi {0}", PI);

            //Đoạn code ở dưới sẽ bị lỗi vì hằng số là những giá trị không đổi
            //doSoi = 300;

            Console.ReadKey();
        }
    }
}
