using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời nhập vào mật khẩu (có ít nhất một chữ cái và ít nhất 1 chữ số, tối thiếu 6 kí tự) ");
            string mk = Console.ReadLine();
            bool check = true;
            int demSo = 0;
            int demKyTu = 0;

            while (check) // while (check == true)
            {
                foreach (char s in mk)
                {
                    if(char.IsDigit(s))
                    {
                        demSo++;
                    }
                    else if (char.IsLetter(s))
                    {
                        demKyTu++;
                    }    
                }
                Console.WriteLine(demSo);
                Console.WriteLine(demKyTu);

                if(demKyTu * demSo != 0 && mk.Length >= 6)
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("Nhập sai vui lòng nhập lại !! Nhập lại mật khẩu");
                    mk = Console.ReadLine();
                    check = true;

                }
            }
            Console.WriteLine("Bạn thiết lập mật khẩu thành công, mật khẩu của bạn là:  " +mk);

            string login;
            Console.WriteLine("Mời nhập vào mật khẩu đăng nhập");
            login = Console.ReadLine();
            int demLogin = 0;

            while(true)
            {
                bool kq = mk.Equals(login);
                if(kq) // kq == true
                {
                    Console.WriteLine("Đăng nhập thành công");
                    break;
                }
                else
                {
                   
                    demLogin++;
                    if(demLogin<5)
                    {
                        Console.WriteLine("Mật khẩu không đúng, Vui lòng nhập lại không quá {0}/5 lần" , demLogin);
                        login = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Bạn đã nhập sai mật khẩu quá 5 lần");
                        break ;
                    }
                }
            }    
            Console.ReadKey();
        }
    }
}
