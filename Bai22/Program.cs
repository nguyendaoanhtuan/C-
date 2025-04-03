using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            //1. tạo một đói tượng mới mà không truyền giá trị 

            SinhVien sinhvien1 = new SinhVien();
            SinhVien sinhvien2 = new SinhVien();
            // xuất
            Console.WriteLine(sinhvien1.MaSV);
            Console.WriteLine(sinhvien2.MaSV);
            Console.WriteLine(sinhvien1.TenSV);
            Console.WriteLine(sinhvien2.TenSV);

            Console.WriteLine("Tên sinh viên là:"+ sinhvien1.TenSV);

            //2. tạo một đối tượng mới nhưng mà truyền giá trị vào cho nó
            SinhVien sinhVien3 = new SinhVien(1,"Nguyễn Đào Anh Tuấn",22);
            Console.WriteLine("Tên của sinh viên 3 là: " + sinhVien3.TenSV);
            sinhVien3.MaSV = 123;
            sinhVien3.TenSV = "Nguyễn Đào Duy Tân";
            Console.WriteLine("Mã sinh viên là {0} , tên sinh viên là {1}",sinhVien3.MaSV,sinhVien3.TenSV);

            //4. Phương thức Tostring
            Console.WriteLine(sinhvien1.ToString());
            Console.WriteLine(sinhvien2.ToString());
            Console.WriteLine(sinhVien3.ToString());

            //Service method và support method

            SinhVien sinhVien4 = new SinhVien(4, "Võ Đăng Huy", 20);
            sinhVien4.XuatThongTin();

            //OverLoading method
            Console.WriteLine(sinhVien4.Tong(1, 5));
            Console.WriteLine(sinhVien4.Tong(1, 5, 3));
            Console.WriteLine(sinhVien4.Tong(1.6, 5.6, 5.5));

            // Parametter List Method dùng trong trường hợp quá nhiều đối số nên phải làm thành list, mảng

            Console.WriteLine(sinhVien4.trungBinhKTHK(7 ,8,8,9,8,5,6,2,4,7,7,9,3,8,6,5,5));

            //Auto - Implemented Properties
            HocSinh hocSinh1 = new HocSinh();
            hocSinh1.Name = "tèo";
            hocSinh1.Phone = "5456464";
            hocSinh1.Email = "teo@gmail.com";
            Console.WriteLine(hocSinh1);
            Console.ReadKey();

        }
    }
}
