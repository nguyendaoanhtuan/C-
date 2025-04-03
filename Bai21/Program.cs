using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21
{
    internal class Program
    {
        // xử lý ngoại lệ

        static void NgoaiLe1()
        {
            try
            {
                Console.WriteLine("Nhập vào ngày tháng năm sinh: ");
                string s = Console.ReadLine();
                DateTime birthday = DateTime.Parse(s);
                Console.WriteLine("Ngày sinh của bạn là: " + birthday.ToString("dd/MM/yyyy"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Cảm ơn bạn đã sử dụng phần mềm");
            }

        }

        static void NgoaiLe2()
        {
            Console.WriteLine("Mời nhập vào tử số: ");
            int tu = int.Parse(Console.ReadLine());

            Console.WriteLine("Mời nhập vào mẫu số: ");
            int mau = int.Parse(Console.ReadLine());    

            if(mau == 0)
            {
                throw new ArithmeticException("Lỗi mẫu bằng 0");
            }    
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //NgoaiLe1();
            try
            {
                NgoaiLe2();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
