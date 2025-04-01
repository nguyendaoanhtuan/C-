using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ép kiểu ( không được ép theo kiểu dữ liệu từ lớn hơn xuống bé hơn còn cố tình ép thì gán trường cho dữ liệu)

            int a = 1;
            int b = 2;

            float z = a / b;
            Console.WriteLine("Giá trị của z là :" +z);
            // gán tường mình cho dữ liệu
            float z2 = (float)a / b;
            Console.WriteLine("Giá trị của z là :" + z2);

            byte x = 255;
            int y = x;

            // Lỗi sai khi ép kiểu dữ liệu từ lớn xuống nhỏ
            int k = 40000;
            Console.WriteLine("Giá trị của k là :" +k);
            //byte l = k;
            // cố tình thì phải khai báo tường minh 
            byte l = (byte)k;
            Console.WriteLine("Giá trị của l là :" +l);
     
        }
    }
}
