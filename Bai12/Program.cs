using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    internal class Program
    {
        //Thư viện math
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Pi = " + Math.PI);
            Console.WriteLine("kiểu dữ liệu của math.pi = " + Math.PI.GetType().ToString());
            double pi = Math.PI;

            //căn bậc hai
            int a = 4;
            int b = 10;
            Console.WriteLine("Căn bậc 2 của số a là : " + Math.Sqrt(a));
            Console.WriteLine("Kiểu dữ liệu của căn bậc hai: " + Math.Sqrt(a).GetType().ToString());

            //Lũy thừa
            Console.WriteLine("2 lũy thừa 3 = " + Math.Pow(2,3));
            //Max
            Console.WriteLine(" Max = " + Math.Max(a,b));
            Console.WriteLine(" Min = " + Math.Min(a,b));

            // Làm tròn
            float c = 1.23456789f;
            Console.WriteLine("Số c sau khi làm tròn hai chữ số là = " + Math.Round(c,2));

            //Sin
            
            Console.WriteLine(" sin 180 = " + Math.Sin(30*Math.PI/180));
            Console.ReadKey();
        }
    }
}
