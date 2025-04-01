using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Bài Tập vận dụng 

            int i1 = 2;
            int i2 = 5;
            int i3 = -3;
            float d1 = (float)2.0;
            float d2 = (float)5.0;
            float d3 = (float) -0.5;

            float a = (float)i1 + (i2 * i3);
            float b = (float)i1 * (i2 + i3);
            float c = (float)i1 / (i2 + i3);
            float e = (float)i1 / i2 + i3;
            float g = (float)3 + 4 + 5 / 3;
            float i = (float)(3 + 4 + 5) / 3;
            float k = (float)d1 + (d2 * d3);
            float l = (float)d1 + d2 * d3;
            float m = (float)d1 / d2 - d3;
            float n = (float)d1 / (d2 - d3);
            float o = (float)d1 + d2 + d3 / 3;
            float p = ((float)d1 + d2 + d3) / 3;
            float q = (float)d1 + d2 + (d3 / 3);
            float r = 3 * ((float)d1 + d2) * (d1 - d3);

            Console.WriteLine("Các kết quả lần lượt là a: {0}, b: {1}, c: {2}, e: {3}, g: {4}, i: {5}, k: {6}, l: {7}, m : {8}, n: {9}, o: {10}, p: {11}, q: {12}, r: {13} ", a, b, c, e, g, i, k, l, m, n, o, p, q, r);
            
            Console.ReadKey();
        }
    }
}
