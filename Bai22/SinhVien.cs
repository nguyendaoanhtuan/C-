using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22
{
    public class SinhVien
    {

        #region Biến lớp
        //Khai báo biến trong lớp
        private int maSV;
        private string tenSV;
        private float diemThiDH;
        #endregion
        //Khai báo constructor
        //(Gán giá trị mặc định cho đối tượng)
        #region Constructor
        public SinhVien()
        {
            this.maSV = 0;
            this.tenSV = "no name";
            this.diemThiDH = 0;
        }
        //KHởi tạo giá trị cho đối tượng do người dùng truyền vào
        public SinhVien(int maSV, string tenSV, float diemThiDH)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.diemThiDH = diemThiDH;
        }

        public SinhVien(int maSV, float diemThiDH, string tenSV)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.diemThiDH = diemThiDH;
        }
        #endregion

        #region properties
        // Khai báo properties
        public string TenSV
        {
            get { return this.tenSV; } // get giá trị để đọc
            set { this.tenSV = value; } // set để thay đổi giá trị
        }

        public int MaSV
        {
            get { return this.maSV; } // get giá trị để đọc
            set { this.maSV = value; } // set để thay đổi giá trị
        }

        public float DiemThiDH
        {
            get { return this.diemThiDH; }
            set { this.diemThiDH = value; }
        }
        #endregion

        //Phương thức Tostring
        public override string ToString()
        {
            return this.MaSV + "\t" + this.TenSV;
        }

        // support method dùng để hỗ trợ nhưng mà phải private
        private bool CheckDiemThiDH()
        {
            return (this.diemThiDH - 21 >= 0);
        }
        // service methoad được dùng hỗ trợ  một cách public
        public void XuatThongTin()
        {
            if (CheckDiemThiDH() == false)
            {
                Console.WriteLine("Điểm thi mà DH <21, cần kiểm tra lại hồ sơ học sinh này");
            }
            else
            {
                Console.WriteLine(ToString());
            }
        }
        // overloading method là cùng tên phương thức nhưng khác nhau về signature
        public int Tong(int x, int y)
        {
            return x + y;
        }

        public int Tong(int x, int y, int z)
        {
            return x + y + z;
        }
        public double Tong(double x, double y, double z)
        {
            return x + y + z;
        }

        //Parametter List MeThod
        //Tính tổng điểm tb kết thúc học kỳ

        public float trungBinhKTHK(params float[] mang)
        {
            float s = 0;
            foreach (float f in mang)
            {
                s += f;
            }
            return (s / mang.Count());
        }

             
    }
}
