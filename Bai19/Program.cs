using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19
{
    //Dictionary
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //1. Khai báo
            Dictionary<int , string> dic = new Dictionary<int , string>();

            //2 Khởi tạo và gán giá trị
            Dictionary<int, string> dic2 = new Dictionary<int, string>() { {1,"obama" }, {2,"jackma" } };
            
            //3.
            Dictionary<string,int> dc3 = new Dictionary<string, int>() { {"20H1321",132141 }, {"20H3214",413243 } };

            //4. add
            dic.Add(1, "Nguyễn Đào Anh Tuấn");
            dic.Add(2, "Nguyễn Võ Duy Tân");
            dic.Add(3, "Nguyễn Duy Tân");

            //5 Duyệt
            foreach (KeyValuePair<int, string> kvp in dic)
            {
                Console.WriteLine(kvp);
                Console.WriteLine("Key = {0} , Value = {1}",kvp.Key, kvp.Value);
            }

            //6. 
            bool kq = dic.ContainsKey(1);
            Console.WriteLine(kq);

            //7

            bool kq2 = dic.ContainsValue("Nguyễn Đào Anh Tuấn");
            Console.WriteLine(kq2);

            //8
            string name = dic[1];
            Console.WriteLine(name);

            //8.1
            dic[2] = "Nguyễn Văn";
            Console.WriteLine(dic[2]);

            //9. Xóa phần tử theo key
            dic.Remove(1);
            Console.WriteLine("dic sau khi xóa là: ");
            foreach(KeyValuePair<int, string> kvp in dic)
            {
                Console.WriteLine(kvp);
            }
            //10.
            Console.WriteLine("Số phần tử của dic trước khi xóa là " + dic.Count());
            dic.Clear();
            Console.WriteLine("Số phần tử của dic sau khi xóa là " + dic.Count());

            //11. Chuyển value sang list
            Dictionary<string, int> dic4 = new Dictionary<string, int>() 
            { { "20H1321", 132141 }, { "20H3214", 413243 } };
            List<int> ds = new List<int>();

            ds = dic4.Values.ToList();
            Console.WriteLine("Danh sách value là");
            foreach(int i in ds)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
            //12.  Chuyển key vao list
            List<string> dsKey = new List<string>();

            dsKey = dic4.Keys.ToList();
            Console.WriteLine("Danh sách key là : ");
            foreach(string i in dsKey)
            {
                Console.Write(i+ " ");
            }    

            Console.ReadLine();
        }
    }
}
