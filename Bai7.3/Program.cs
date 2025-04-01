using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float chieuCao, canNang, BMI;
            Console.WriteLine("Nhập chiều cao (m): ");
            chieuCao = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cân nặng (kq): ");
            canNang = float.Parse(Console.ReadLine());

            BMI = (float)(canNang / Math.Pow(chieuCao, 2));

            if(BMI < 15)
            {
                Console.WriteLine("BMI của bạn là = " + BMI);
                Console.WriteLine("Thân hình quá gầy");
            }else if(BMI >= 15 && BMI < 16)
            {
                Console.WriteLine("BMI của bạn là = " + BMI);
                Console.WriteLine("Thân hình gầy");
            }else if(BMI >= 16 && BMI < 18.5)
            {
                Console.WriteLine("BMI của bạn là = " + BMI);
                Console.WriteLine("Thân hình hơi gầy");
            }else if(BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("BMI của bạn là = " + BMI);
                Console.WriteLine("Thân hình bình thường");
            }else if(BMI >= 25 &&  BMI < 30)
            {
                Console.WriteLine("BMI của bạn là = " + BMI);
                Console.WriteLine("Thân hình hơi béo");
            }else if(BMI >= 30 && BMI < 35)
            {
                Console.WriteLine("BMI của bạn là = " + BMI);
                Console.WriteLine("Thân hình béo");
            }else if(BMI >= 35)
            {
                Console.WriteLine("BMI của bạn là = " + BMI);
                Console.WriteLine("Thân hình quá béo");
            }    
            
            Console.ReadKey();
        }
    }
}
