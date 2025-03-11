using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("輸入x和y:");
            //    Console.Write("輸入x:");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("輸入y:");
            //    int y = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("x=");
            //    Console.WriteLine(x);
            //    Console.Write("y=");
            //    Console.WriteLine(y);
            //    Console.WriteLine("(x+y)/2=");
            //    Console.Write((x + y) / 2);
            //    //Console.ReadKey();
            //}


            Console.WriteLine("請輸入a1、b1、c1、a2、b2、c2 :");
            Console.Write("a1:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("b1:");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("c1:");
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("a2:");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("b2:");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("c2:");
            int c2 = Convert.ToInt32(Console.ReadLine());

            int x = ((c1 * b2) - (c2 * b1)) / ((a1 * b2) - (a2 * b1));
            int y = ((c1 * a2) - (c2 * a2)) / ((b1 * a2) - (a1 * b2));

            Console.WriteLine("二元一次方程式 x、y 的解為:");
            Console.WriteLine($" x = {x}");
            Console.WriteLine($" y = {y}");

            Console.ReadKey();
        }
        }
}
