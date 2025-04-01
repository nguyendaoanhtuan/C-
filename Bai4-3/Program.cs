using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float banKinh;
            Console.WriteLine("Nhập bán kính r của đường tròn: ");
            banKinh = float.Parse(Console.ReadLine());

            float chuVi;
            float dienTich;

            chuVi = 2 * banKinh * (float) 3.14;
            Console.WriteLine("Chu vi của đường tròn là: {0}", chuVi);
            dienTich = (float)3.14 * banKinh * banKinh;
            Console.WriteLine("Diện tích hình tròn là: {0}", dienTich);

            Console.ReadKey();


        }
    }
}
