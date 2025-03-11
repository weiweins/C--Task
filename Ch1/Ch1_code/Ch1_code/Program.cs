
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Ch1_code
{
    class Program
    {
        
        static void Main(string[] args)
        {


            ////作業1-1

            Console.WriteLine("請輸入a、b、c、d:");
            Console.Write("a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("d:");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("[(a+b)/(c-d)]*2 = ");
            int z = (a + b) / (c - d) * 2;
            Console.WriteLine(z);

            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}, 答案={4}", a, b, c, d, z);
            Console.Write((a + b) / (c - d) * 2);
            Console.ReadKey();


            /* int x = a + b;
            int y = c - d;
            Console.Write(x / y * 2);
            Console.ReadKey(); */

            //作業1-2

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


            //作業1-3

            Console.WriteLine("請輸入a、b：");
            Console.Write("a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b:");
            int b = Convert.ToInt32(Console.ReadLine());
            double c = (Math.Pow(a, 2) + Math.Pow(b, 2)) / (Math.Pow(a, 2) - Math.Pow(b, 2));
            Console.WriteLine($"a = {a}, b = {b}, 答案 y = (a平方 + b平方) / (a平方 - b平方)  = {c}");
            Console.ReadKey();


            //作業1-4

            Console.WriteLine("請輸入a、b:");
            Console.Write("a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b:");
            int b = Convert.ToInt32(Console.ReadLine());
            double y = Math.Pow(Math.Pow(a, 2) + Math.Pow(b, 2), 0.5);
            //double y = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));   //另一解法
            Console.WriteLine($"a = {a}, b = {b}, 答案 a平方 + b平方後再開根號 = {y}");
            Console.ReadKey();

            //作業1-5

            Console.WriteLine("請輸入a、b、c:");
            Console.Write("a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c:");
            int c = Convert.ToInt32(Console.ReadLine());
            int y = a - (b + c) * (3 * a - c);
            Console.WriteLine($"a = {a} ,b = {b}, c = {c}, 答案y = a - (b + c) * (3a - c) = {y}");
            Console.ReadKey();


            //作業1-6

            Console.Write("請輸入任意正負整數值:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("輸入值 = {0} 、 絕對值為{1}", a, Math.Abs(a));
            Console.ReadKey();



         

            //作業1-7

            Console.Write("請輸入西元年:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"西元{a}年，對應的民國年為: 民國{a - 1911}年");
            Console.ReadKey();



            //作業1-8
            // (BMI＝體重(公斤)÷身高(公尺)÷身高(公尺)

            Console.Write("請輸入身高(m):");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("請輸入體重(kg):");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"身高 = {a} m、體重 = {b} kg，BMI值 = {b / Math.Pow(a, 2)}");
            Console.ReadKey();

            //1-8:身高輸入為cm計算
            //Console.Write("請輸入身高(cm):");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("請輸入體重(kg):");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"身高 = {a} cm、體重 = {b} kg，BMI值 = {b / Math.Pow(a/100, 2)}");
            //Console.ReadKey();







        }
    }
}
