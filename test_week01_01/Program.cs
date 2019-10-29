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
            Console.WriteLine("Hello World!");//consle_控制台
            double x = 3, y = 5, res;
             res= Max(x, y);
            Console.WriteLine("max={0}", res);
            //console.readkey();字面意思
        }
       public static double Max(double x,double y)
        {
            if (x > y)
                return x;
            else
                return y;
        }
    }
}
