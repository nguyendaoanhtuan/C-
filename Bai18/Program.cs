using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
{ // List
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.OutputEncoding = Encoding.UTF8;
            //1. KHởi tạo list
            List<string> ds1 = new List<string>(); // danh sách với các phần tử là sting
            List<int> ds2 = new List<int>(); // danh sách với các phần tử là int
            //2.Khởi tạo danh sách có sẵn phần tử
            List<int> ds3 = new List<int>() {1,2,3,5,8,9 };

            foreach (int i in ds3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //4. Thêm phần tử vào cuối list
            List<int> ds4 = new List<int>() {1,3,5 };
            ds4.Add(100);
            ds4.Add(200);
            Console.WriteLine("Danh sách 4 là :");
            foreach (int i in ds4)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // xóa phần tử đầu tiên nếu tìm thấy trong list

            List<int> ds5 = new List<int>() {8,1,2,5,1,6,8 };
            ds5.Remove(1);
            Console.WriteLine("Danh sách 5 là :");
            foreach (int i in ds5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //6. Đếm số phần tử trong danh sách
            List<int> ds6 = new List<int>() { 8, 1, 2, 5, 1, 6, 8 };
            Console.WriteLine(ds6.Count);

            //7. xóa toàn tộ phần tử
            List<int> ds7 = new List<int>() { 8, 1, 2, 5, 1, 6, 8 };
            ds7.Clear();

            //8. thêm toàn bộ danh sách 9 vào cuối danh sách 8
            List<int> ds8 = new List<int>() { 8, 1, 2 };
            List<int> ds9 = new List<int>() { 100, 2000 };
            ds8.AddRange(ds9);
            Console.WriteLine("Danh sách 8 là :");
            foreach (int i in ds8)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //9. kiểm tra value
            List<int> ds10 = new List<int>() { 100, 200 };
            bool kq = ds10.Contains(100);
            Console.WriteLine(kq);

            //10 GetRange
            List<int> ds11 = new List<int>() { 1, 2, 1, 5, 6 };
            List<int> ds12 = ds11.GetRange(1, 2);

            Console.WriteLine("Danh sách 12 là :");
            foreach (int i in ds12)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //11. int IndexOf
            List<int> ds13 = new List<int>() { 1, 2, 1, 5, 6 };
            int checkIndex = ds13.IndexOf(5);
            Console.WriteLine(checkIndex);

            //12. Insert chèn thêm value

            List<int> ds14 = new List<int>() { 1, 2, 1, 5, 6 };
            ds14.Insert(0, 200);

            Console.WriteLine("Danh sách 14 là :");
            foreach (int i in ds14)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //13. InsertRange
            List<int> ds15 = new List<int>() { 1, 2, 1, 5, 6 };
            List<int> ds16 = new List<int>() { 9, 10 };
            ds15.InsertRange(2, ds16);

            Console.WriteLine("Danh sách 15 là :");
            foreach (int i in ds15)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //14. RemoveAt xóa phần tử tại ví trí index chỉ định
            List<int> ds17 = new List<int>() { 1, 2, 1, 5, 6 };
            ds17.RemoveAt(3);
            Console.WriteLine("Danh sách 17 là :");
            foreach (int i in ds17)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //15. RemoveRange Xóa từ index và xóa đi count phần tử
            List<int> ds18 = new List<int>() { 1, 2, 1, 5, 6 };
            ds18.RemoveRange(1, 3);
            Console.WriteLine("Danh sách 18 là :");
            foreach (int i in ds18)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //16. Đảo ngược danh sách
            List<int> ds19 = new List<int>() { 1, 2, 1, 5, 6 };
            ds19.Reverse();
            Console.WriteLine("Danh sách 19 là :");
            foreach (int i in ds19)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //17. Sắp xếp tăng dần
            List<int> ds20 = new List<int>() { 1, 2, 1, 5, 6 };
            ds20.Sort();
            Console.WriteLine("Danh sách 20 là :");
            foreach (int i in ds20)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //18. BinarySearch phải xếp sắp rồi mới tiềm kiếm
            int kq2 = ds20.BinarySearch(5);
            Console.WriteLine(kq2);

            //19.Max min
            int kq3 = ds20.Max();
            Console.WriteLine( "Giá trị max của mảng 20 là " +kq3);
            Console.WriteLine( "Giá trị min của mảng 20 là " + ds20.Min());

            Console.ReadKey();
        }
    }
}
