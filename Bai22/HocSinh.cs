using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22
{
    public class HocSinh
    {
        //auto-Implemented Properties thay thế việc thay tế 3 bước, biến lớp , constructor , properties
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone {  get; set; }

        public override string ToString()
        {
            return this.Name + "\t" +this.Email + "\t" + this.Phone;
        }

    }
}
