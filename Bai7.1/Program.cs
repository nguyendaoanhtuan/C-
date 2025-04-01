using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7._1
{ // Lệnh if - else if - else
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float dtb;
            Console.WriteLine("Nhập điểm trung bình: ");
            dtb = float.Parse(Console.ReadLine());

            if (dtb >= 8)
            {
                Console.WriteLine("Điểm trung bình của bạn là {0}, Bạn là học sinh giỏi", dtb);
            }
            else if (dtb >= 6.5 && dtb <= 8)
            {
                Console.WriteLine("Điểm trung bình của bạn là {0} , Bạn là học sinh khá", dtb);
            }
            else if (dtb >= 5 && dtb <= 6.5)
            {
                Console.WriteLine("Điểm trung bình của bạn là {0} , Bạn là học sinh trung bình", dtb);
            }
            else
            {
                Console.WriteLine("Điểm trung bình của bạn là {0} , Bạn là học sinh yếu", dtb);
            }

            Console.ReadKey();
        }
    }
}
