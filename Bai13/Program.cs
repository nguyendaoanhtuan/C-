using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    internal class Program
    {
        // Hàm ramdom
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Random ramdom = new Random();
            // ramdom số ngẫu nhiên Next(bắt đầu , gần sát kết thúc)
            int soNgauNhien = ramdom.Next(50 , 101); // 50-100
            Console.WriteLine("Số ngẫu nhiên máy sinh ra là " + soNgauNhien);

            Console.ReadKey();
        }
    }
}
