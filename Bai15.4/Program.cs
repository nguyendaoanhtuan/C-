using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string a = "abcdefghijklmnopqrstuvwxyz"; //26
            string b = "zxcvbnmasdfghjklqwertyuiop"; //26
            Console.WriteLine("Mời nhập vào chuỗi cần mã hóa");
            string chuoiInput = Console.ReadLine();
            String chuoiOutput = "";
            foreach (char c in chuoiInput)
            {
                int indexKyTU = a.IndexOf(c);
                chuoiOutput += b[indexKyTU];
            }
            Console.WriteLine("Chuối trước khi mã hóa là: " +chuoiInput);
            Console.WriteLine("Chuôi sau khi mã hóa là: " +chuoiOutput);
            Console.ReadKey();
        }
    }
}
