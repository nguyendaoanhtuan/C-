using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    //Mảng 1 chiều
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1. Khai báo mảng

            int[] stt;
            char[] ch;
            string[] ten;

            //2. Khởi tạo mảng
            stt = new int[10]; // mặc định các phần tử là 0

            foreach (int i in stt)
            {
                Console.WriteLine(i);
            }
            int[] stt2 = new int[7];

            //3. khởi tạo và gán luôn giá trị
            int[] mang2 = {1,2,3,4,5};
            foreach (int i in mang2)
            {
                Console.Write(i);
            }    

            //4. Khởi tạo mảng ngẫu nhiên
            Random r = new Random();
            int[] mang3 = {r.Next(51),r.Next(61)};
            Console.WriteLine();
            foreach (int i in mang3)
            {
                Console.Write(i + " ");
            }

            //5. Kiểm tra độ dài của mảng
            int doDai = mang3.Length;
            Console.WriteLine();
            Console.WriteLine("Chiều dài mảng 3 là: "+ doDai);

            //6. Truy xuất phần tử qua Index
            int[] mang4 = {1,2,3,4,6};
            Console.WriteLine(mang4[0]);
            Console.WriteLine(mang4[1]);
            Console.WriteLine(mang4[mang4.Length - 1]);

            //7. Thay đổi giá trị trong mảng bằng cách gọi index
            int[] mang5 = {1,2,4, 5, 6};
            mang5[1] = 100;

            Console.WriteLine();
            foreach (int i in mang5)
            {
                Console.Write(i + " ");
            }

            //8. Duyệt mẩng bằng for
            int[] mang6 = {1,2,5, 6};
            Console.WriteLine();
            for(int i = 0; i < mang6.Length; i++)
            {
                Console.Write(mang6[i] + " ");
            }
            Console.WriteLine();

            //9. Phép gán mảng
            int[] mang7 = { 1, 2, 3, 4, 5, 6 };
            int[] mang8 = mang7;
            mang8[0] = 100;
            Console.WriteLine("Mảng 8 sau đổi tại vị trí index 0 là " + mang7[0]);

            //10. CopyTo
            int[] mang10 = { 100, 200, 300, 400, 500 };
            int[] mang11 = { 1, 2, 3, 4, 5, 6, 7 };
            mang10.CopyTo(mang11, 2);
            Console.WriteLine();
            Console.WriteLine("Mang 11 sau khi thay đổi giá trị");
            foreach (int i in mang11)
            {
                Console.Write(i + " ");
            }
            //11. Copy
            int[] mang12 = { 100, 200, 300, 400, 500 };
            int[] mang13 = new int[4];
            Array.Copy(mang12, mang13, 4);
            Console.WriteLine();
            Console.WriteLine("mảng 13 là");
            foreach (int i in mang13)
            {
                Console.Write(i + " ");
            }

            //15. Clone
            int[] mang14 = { 100, 200, 5 };
            int[] mang15 = (int[])mang14.Clone();
            Console.WriteLine();
            Console.WriteLine("mảng 15 là");
            foreach (int i in mang15)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //16. Đảo ngược mảng
            int[] mang16 = { 1, 2, 3, 4, 5, 6 };
            Array.Reverse(mang16);
            Console.WriteLine("mảng 16 là");
            foreach (int i in mang16)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //17. Sắp xếp mảng tăng dần

            int[] mang17 = { 10, 2, 50, 5, 1 };
            Array.Sort(mang17);
            Console.WriteLine("mảng 17 là");
            foreach (int i in mang17)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
