using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace test_week01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            demo0104();
            // Console.WriteLine("Hello World!");//consle_控制台
           // double x = 3, y = 5, res;
           // res= Max(x, y);
           // Console.WriteLine("max={0}", res);
           // Console.WriteLine("max={0,10:0.00}", res);//讲道理，逗号后的10指的是输出的宽度为十个字符，：后的0.00指的是小数点后两位
           // Console.WriteLine("max={0:E2}", res);//这里的E2意思是科学计数法保留两位
           // Console.WriteLine("max={0:F2}", res);//这里的意思是浮点数保留两位
            //console.readkey();字面意思
        }
        public static double Max(double x, double y)
        {
            return x > y ? x : y;
        }
        public static void demo0104()//c#高级编程了解一下具体的语法。
        {
            int[] a = new[] { 1, 2, 3, 4, 5 };//注意这里不同的数组构建
            double[] b = new double[4];
            int[,] c = new int[2, 2] { { 1, 2 }, { 3, 4 } };//二维数组
            double[,,] d = new double[3, 3, 3];//三维数组
            b[0] = 0.1; b[1] = 0.2; b[2] = 2.3; b[3] = 4.4;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0},{1},{2}", i, a[i], b[i]);
            }
        }
    }
}

