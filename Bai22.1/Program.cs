using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            NhanVien nv1 = new NhanVien();
            nv1.tenNV = "Nhan viên 1";
            nv1.maNV = 1;
            Console.WriteLine("Tên nhân viên là: "+nv1.tenNV+" Mã nhân viên là: "+nv1.maNV);
            Console.WriteLine("Lương nhân viên 1 là: " +nv1.TinhLuong());

            // đây hiển thị rõ ràng tính kế thừa thuộc tính và phương thức
            NhanVienHanhChinh hc1 = new NhanVienHanhChinh();
            hc1.tenNV = "Hành văn chính";
            hc1.maNV = 2;
            Console.WriteLine("Tên nhân viên là: " + hc1.tenNV + " Mã nhân viên là: " + hc1.maNV);
            Console.WriteLine("Lương nhân viên hành chính 1 là: " + hc1.TinhLuong());



            NhanVienDiCa dc1 = new NhanVienDiCa();
            dc1.tenNV = "Đi ca";
            dc1.maNV = 3;
            dc1.ca = "Ca ngày";
            Console.WriteLine("Tên nhân viên là: " + dc1.tenNV + " Mã nhân viên là: " + dc1.maNV + " Ca của nhân viên là: "+dc1.ca);
            Console.WriteLine("Lương nhân viên ca 1 là: " + dc1.TinhLuong());

            Console.WriteLine("***************************************************");
            Console.WriteLine(nv1.ThuongCong(26));
            Console.WriteLine(hc1.ThuongCong(26));
            Console.WriteLine(dc1.ThuongCong(25));
            Console.ReadKey();
        }
    }
}
