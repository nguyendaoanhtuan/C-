using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20
{
    internal class Program
    {
        //Hàm trong C#
        /// <summary>
        /// Hàm này là để tổng
        /// </summary>
        /// <param name="x">Nhập x nguyên</param>
        /// <param name="y">Nhập y nguyên</param>
        /// <param name="z">Nhập z nguyên</param>
        /// <returns>Nó return về tổng 3 số</returns>
        static int Tong(int x, int y, int z)
        {
            return x + y + z;
        }

        static int TinhGiaiThua(int n)
        {
            int gt = 1;
            for (int i = 1; i <= n; i++)
            {
                gt *= i;
            }
            return gt;
        }

        static void XinChao(string m)
        {
            if(m == "nam")
            {
                Console.WriteLine("Xin chào mình là boy");
            }else if(m == "nu")
            {
                Console.WriteLine("Xin chào mình là girl");
            }    
        }

        //Truyền tham trị: Không thay đổi sau khi gọi hàm
        static void ThamTri(int a)
        {
            a += 1;
            Console.WriteLine("Giá trị a trong hàm là : " + a);
        }

        // Truyền tham chiếu ref
        static void ThamChieuRef(ref int b)
        {
            b++;
            Console.WriteLine("B trong hàm là: " + b);
        }

        //Truyền tham chiếu out
        static void ThamChieuOut (out int c)
        {
            c = 5;
            Console.WriteLine("Giá trị của c trong hàm là: " +c);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int kq = Tong(2, 5, 6);

            Console.WriteLine("Kết quả là " +kq);
            int k = 3;
            int kq2 = TinhGiaiThua(k);
            Console.WriteLine("Kết quả gia thừa là " +kq2);

            string m = "nam";
            XinChao(m);
            string n = "nu";
            XinChao(n);

            int kq3 = Tong(7,8,9);

            //Truyền tham trị
            int a = 1;
            Console.WriteLine("A trước khi gọi hàm là " +a);
            ThamTri(a);
            Console.WriteLine("A sau khi gọi hàm là " +a);

            //Truyền tham chiếu ref
            int b = 2;
            Console.WriteLine("Giá trị b trước khi gọi hàm là: " +b);
            ThamChieuRef(ref b);
            Console.WriteLine("Giá trị b sau khi gọi hàm là: " +b);

            //Truyền tham chiếu out
            int c;
            ThamChieuOut(out c);
            Console.WriteLine("C sau khi gọi hàm là: " +5);


            Console.ReadKey();
        }
    }
}
