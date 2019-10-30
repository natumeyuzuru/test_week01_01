using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//documents read
//using test_week01_01;

namespace test_01_2
{
    class Program
    {
        static void Main(string[] args)
        {
            readdoc();
            Console.ReadKey();
        }
        public static void readdoc()
        {
            string filename;
            filename = "C:\\Users\\Natume\\source\\repos\\test_week01_01\\data\\BL.txt";
            var reader = new StreamReader(filename);
            string buf = reader.ReadLine();
            int[] number = new int [4] ;
            string[] siteName = new string[4];
            double[] b = new double[4];
            double[] l = new double[4];

            for(int i=0;i<4;i++)
            {
                buf = reader.ReadLine();
                var arr = buf.Split(' ');
                number[i] = int.Parse(arr[0]);
                siteName[i] = arr[1];
                b[i] = Convert.ToDouble(arr[2]);
                l[i] = double.Parse(arr[3]);
                Console.WriteLine("{0}，{1}",siteName[i],l[i]);

            }
            reader.Close();
        }
    }
}
