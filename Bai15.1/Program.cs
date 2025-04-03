using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int demSo = 0, demChuThuong = 0, demInHoa = 0, demSpace = 0;
            string chuoi = "Tôi là number 1";
            char[] lst = chuoi.ToCharArray();
            foreach (char c in lst)
            {
                if (char.IsDigit(c))
                {
                    demSo++;
                }
                else if (char.IsLower(c))
                {
                    demChuThuong++;
                }
                else if (char.IsUpper(c))
                {
                    demInHoa++;
                }
                else if ( char.IsWhiteSpace(c))
                {
                    demSpace++;
                }    
            }

            Console.WriteLine("Chuổi có {0} ký tự viết thường", demChuThuong);
            Console.WriteLine("Chuổi có {0} ký tự viết hoa", demInHoa);
            Console.WriteLine("Chuổi có {0} ký tự số", demSo);
            Console.WriteLine("Chuổi có {0} ký tự khoảng trắng", demSpace);

            Console.ReadKey();
        }
    }
}
