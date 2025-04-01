using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Khai báo để có thể xuất được ký tự unicode
            Console.Write("Hello !"); // Xuất dữ liệu (giá trị) có thể là chuỗi kí tự hoặc là số
            Console.WriteLine("Xin chào, mình mới học C sharp"); // in ra dữ liệu sau đó xuống dòng, Giống lệnh bên trên, sau khi in giá trị ra màn hình thì hệ thoongs sẽ đặt con trỏ xuống dòng tiếp theo
            Console.WriteLine(200);
            // Console.ReadLine(); // Đặt tại cuối chương trình để dừng màn hình chương trình lại. Nếu không chương trình sẽ chạy xong rồi tự tắt.

           
            Console.WriteLine("Họ và Tên: Nguyễn Đào Anh Tuấn");
            Console.WriteLine( 2003);
            Console.WriteLine("Giới tính: Nam");
            Console.WriteLine( 22);
            Console.ReadKey(); // Cách thứ 2  để dừng chương trình để giá trị true bên trong dấu ngoặc thì sẽ không dừng còn để fale hoặc để trống thì sẽ dừng chương trình



        }

    }
}
