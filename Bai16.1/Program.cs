using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời nhập vào số phần tử của bảng");
            int n = int.Parse(Console.ReadLine());

            // Khai báo mảng
            int[] mang = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mang[i]+ " ");
            }
            Console.WriteLine();

            //1. Nhập giá trị ngẫu nhiên

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mang[i] = r.Next(101);
            }
            //2. Xuất mảng
            Console.WriteLine("Mảng ngẫu nhiên là:");
            foreach (int i in mang)
            {
                Console.Write(i+ " ");
            }    
            Console.WriteLine();

            //3. Đảo ngược mảng
            Array.Reverse(mang);
            Console.WriteLine("Mảng sau khi đảo ngược là:");
            foreach (int i in mang)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //4. Sắp xếp mảng
            Array.Sort(mang);
            Console.WriteLine("Mảng sau khi sắp xếp là:");
            foreach (int i in mang)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //5 tính tổng
            int tong = 0;
            foreach (int i in mang)
            {
                tong += i;
            }

            Console.WriteLine("Tổng của các phần từ của mảng là: " +tong);

            //6. Tìm kiếm mảng phải sắp xếp từ nhỏ đến lớn mới tìm được
            Console.WriteLine("Mời nhập vào số cần tìm: ");
            int so = int.Parse(Console.ReadLine());

            int kq = Array.BinarySearch(mang, so);

            if(kq == -1)
            {
                Console.WriteLine("Không tìm thấy số cần tìm");
            }
            else
            {
                Console.WriteLine("Tìm thấy số {0} ở vị trí index {1}", so, kq);
            }

            //7 tìm thông thường
            int demkq = 0;
            for (int i = 0; i < n; i++)
            {
                if (mang[i] == so)
                {
                    Console.WriteLine("Tìm thấy {0} tại vị trí index {1}", so,i);
                    demkq++;
                }    
            }
            if (demkq == 0) {
                Console.WriteLine("Không tìm thấy giá trị");
            }

            Console.ReadKey();
        }
    }
}
