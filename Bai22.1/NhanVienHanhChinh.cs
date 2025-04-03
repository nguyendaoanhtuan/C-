using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22._1
{
    //chỉ cần : sau tên class thì con : cha 
    public class NhanVienHanhChinh : NhanVien
    {
        //tái định nghĩa
        public override double ThuongCong(int ngayCong)
        {
            return 0;
        }
    }
}
