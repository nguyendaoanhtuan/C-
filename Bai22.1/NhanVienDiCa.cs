using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22._1
{
    public class NhanVienDiCa:NhanVien
    {
        //khai báo thêm thuộc tính con

        public string ca {  get; set; }
        //kế thừa và tái định nghĩa lại phương thức (overriding method) cùng tên cùng signature (là thuộc tính trong dấu ngoặc sau tên ())

        public new double TinhLuong()
        {
            return base.TinhLuong()*1.05;
        }
    }
}
