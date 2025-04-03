using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14._2
{
    internal class Program
    {
        //So sánh theo ký tự
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Char ch7 = 'a'; // 97
            Char ch8 = 'b';// 98
            Char ch9 = 'a'; // 97
            Char ch10 = 'm'; // 109

            Console.WriteLine(ch7.CompareTo(ch8));
            Console.WriteLine(ch8.CompareTo(ch7));
            Console.WriteLine(ch7.CompareTo(ch9));
            Console.WriteLine(ch7.CompareTo(ch10));

            //So sánh ký tự sử dụng equals trả về true false, bằng nhau trả về True, < ,> thì lớn hơn False

            Console.WriteLine(ch7.Equals(ch8));
            Console.WriteLine(ch7.Equals(ch9));
            Console.WriteLine(ch7.Equals(ch10));

            //Các phương thức - char method in C#
            // Char.IsDigit kiểm tra truyền vào là chữ số hay không
            Console.WriteLine(Char.IsDigit('2')); // kiểm tra số 

            // Char.IsLetter kiểm tra truyền vào bảng chữ cái
            Console.WriteLine(Char.IsLetter('a')); // kiểm tra chữ cái

            Console.WriteLine(Char.IsWhiteSpace(' ')); // kiểm tra space

            Console.WriteLine(Char.IsLower('a')); // Kiểm tra ký tự viết thường

            Console.WriteLine(Char.IsUpper('A')); // kiểm tra ký tự viết hoa

            Console.WriteLine(Char.ToUpper('a')); // Chuyển kí tự thường sang in hoa

            Console.WriteLine(Char.ToLower('A')); // Chuyển kí tự hoa sang thường
            Console.ReadKey();
        }
    }
}
