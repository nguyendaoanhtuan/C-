using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22._1
{
    public class NhanVien
    {
        // khởi tạo
        public int maNV {  get; set; }
        public string tenNV { get; set; }

        // Phương thức tính lương nv
        public double TinhLuong()
        {
            return 1000; // lương cơ bản 1 tháng 1000
        }

        //Hàm ảo virtual
        public virtual double ThuongCong(int ngayCong)
        {
            if(ngayCong >= 26)
            {
                return 100;
            }
            else
            {
                return 0;
            }
        }

    }
}
