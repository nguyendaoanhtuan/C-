using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    //Hàm string
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //1 Khai báo string
            string chuoi = "Giải lập trình";
            Console.WriteLine(chuoi);

            //2 Khai báo nguyên văn @
            string chuoi2 = @"D:\galailaptrinh";
            Console.WriteLine(chuoi2);

            //3 Khai báo theo kí tự đặc biệt
            string chuoi3 = "C:\\galailaotrinh"; // thêm \
            string chuoi4 = "Có người nói rằng: \" abc \""; // thêm nháy kép
            string chuoi5 = "Có người nói rằng: \n \" abc \""; // \n xuống dòng 
            string chuoi6 = "Có người nói rằng: \t \" abc \""; // \t để tab


            // Chuyển đổi sang chuỗi

            int i = 1234;
            string chuoi7 = i.ToString(); // cách1
            Console.WriteLine(chuoi7);
            Console.WriteLine(chuoi7.GetType().ToString());

            string chuoi8 = i + ""; // cách 2
            Console.WriteLine(chuoi8);

            string chuoi9 = Convert.ToString(i); //cách 3

            // Tách chuỗi ra thành các ký tự lẻ, cho vào mảng

            string chuoi10 = "Xinchao";
            char [] lst = chuoi10.ToCharArray();
            Console.WriteLine(lst.GetType().ToString());
            Console.WriteLine(lst);

            //8. Length: Trả về độ dài của chuổi (số ký tự chuỗi, bao gồm cả space)
            string chuoi11 = "test haha";
            int j = chuoi11.Length;
            Console.WriteLine(j);
            Console.WriteLine("ký tự thứ 2 của chuối là: " + chuoi11[j-1]);

            // So Sánh CHuỗi

            string chuoi12 = "123456a";
            string chuoi13 = "123456o";
            int sosanh = chuoi13.CompareTo(chuoi12);

            Console.WriteLine(sosanh);


            // Kiểm tra chuỗi con
            string chuoi14 = "abc";
            string chuoi15 = "abcde";
            bool l = chuoi15.Contains(chuoi14);

            Console.WriteLine(l);

            // Hàm copyto
            string chuoi16 = "123456";
            char[] lst2 = new char[6];// tảo ra một mảng có độ dài là 6
            lst2[0] = 'a';
            lst2[1] = 'b';

            Console.WriteLine(lst2); // ab2345

            chuoi16.CopyTo(1, lst2, 2, 4);

            Console.WriteLine(lst2);

            //10. Hàm bool EnsWith
            string chuoi17 = "ditimtinhyeu.mp3";
            bool kt = chuoi17.EndsWith(".mp3");
            Console.WriteLine(kt);

            //11. gán chuổi theo string.Format

            int n = 14;
            string chuoi18 = string.Format("n = {0} và căn bậc 2 của n là {1}", n, Math.Sqrt(n));
            Console.WriteLine(chuoi18);

            //12. Hàm Equals 

            string chuoi19 = "haha";
            string chuoi20 = "haha";
            bool kt2 = chuoi19.Equals(chuoi20);

            Console.WriteLine(kt2);


            //13. Chèn thêm vào chuỗi.
            string chuoi21 = "123";
            string chuoi22 = "Obama";
            chuoi21 = chuoi21.Insert(2, chuoi22);

            Console.WriteLine(chuoi21);

            //14 Indexof
            string chuoi23 = "123asssssas";
            int kq4 = chuoi23.IndexOf('a');
            Console.WriteLine(kq4);

            //15 LastIndexof

            string chuoi24 = "123asssssas";
            int kq5 = chuoi24.LastIndexOf('a');
            Console.WriteLine(kq5);

            //16 Remove
            string chuoi25 = "123456";
            chuoi25 = chuoi25.Remove(1, 2);
            Console.WriteLine(chuoi25);

            //17 Replace
            string chuoi26 = "123445674489";
            chuoi26 = chuoi26.Replace("44","00");
            Console.WriteLine(chuoi26);

            //18 startswith
            string chuoi27 = "ditimtinhyeu.mp3";
            bool kt3 = chuoi27.StartsWith("ditim");
            Console.WriteLine(kt3);

            //19 Substring 
            string chuoi28 = "123456";
            string chuoi29 = chuoi28.Substring(1, 2);

            Console.WriteLine(chuoi29);

            //20 Tolower và ToUppper
            string chuoi30 = "Con di hoc ve muon HAHAHA";
            Console.WriteLine(chuoi30);

            chuoi30 = chuoi30.ToLower(); // chuyển đổi chữ sang thường
            Console.WriteLine(chuoi30);

            chuoi30 = chuoi30.ToUpper();
            Console.WriteLine(chuoi30); // chuyển đổi chữ sang in hoa

            //21 Trim xóa tất
            string chuoi31 = "            ds   a   dsada"; // chỉ xóa đầu và đuôi
            chuoi31 = chuoi31.Trim();
            Console.WriteLine(chuoi28);

            //22 TrimEnd xóa khoảng tắng ở cuối
            string chuoi32 = "                     dsadsa dsadsa      ";
            chuoi32 = chuoi32.TrimEnd();
            Console.WriteLine(chuoi32);

            //23 TrimStart xóa khoảng trắng ở đầu
            string chuoi33 = "               dsada dasdasda   ";
            chuoi33 = chuoi33.TrimStart();
            Console.WriteLine(chuoi33);

            //24 split tách chuỗi trả về mãng
            string chuoi34 = @"D:\galailaptrinh\Maria\video.mp4";
            string[] lst3 = chuoi34.Split('\\');
            Console.WriteLine(lst3[0]);
            Console.WriteLine(lst3[1]);
            Console.WriteLine(lst3[2]);
            Console.WriteLine(lst3[3]);

            //25 Joint string 
            string chuoi35 = string.Join("++", lst3);
            Console.WriteLine(chuoi35);


            Console.ReadKey();
        }
    }
}
