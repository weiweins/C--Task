using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ch2_code
{
    class Program
    {
        static void Main(string[] args)
        {
            //習題2-1

            Console.WriteLine("請輸入x、y:");
            Console.Write("x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"x = {x} , y = {y}");

            if (x >= y)
            {
                Console.WriteLine($"x>=y為true，故輸出x:{x}");
            }
            else
            {
                Console.WriteLine($"x>=y為flase，故輸出y:{y}");
            }

            Console.ReadKey();


            //習題2-2

            Console.WriteLine("請輸入x、y:");
            Console.Write("x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"x = {x}、y = {y}");

            if (x > 0 && y > 0)
            {
                Console.WriteLine("因 x 、 y 皆為正數，故 z = 1");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("因 x 、 y 皆為負數，故 z = -1");
            }
            else
            {
                Console.WriteLine("x、y 非皆為正數或皆為負數，故z = 0");
            }

            Console.ReadKey();

            //習題2-3

            Console.WriteLine("請輸入x、y、u、v:");
            Console.Write("x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("u:");
            int u = Convert.ToInt32(Console.ReadLine());
            Console.Write("v:");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"x = {x}、y = {y}、u = {u}、v = {v}");

            if ((x + y) > (u + v))
            {
                Console.WriteLine($"(x + y) = {(x + y)} 、 (u + v) = {(u + v)}");
                Console.WriteLine($"(x + y) 大於 (u + v)，故 z = x + y = {x + y}");
            }
            else
            {
                Console.WriteLine($"(x + y) = {(x + y)} 、 (u + v) = {(u + v)}");
                Console.WriteLine($"(x + y) 非大於 (u + v)，故 z = u + v = {u + v}");
            }

            Console.ReadKey();


            //習題2-4

            Console.WriteLine("請輸入x、y、u、v:");
            Console.Write("x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("u:");
            double u = Convert.ToDouble(Console.ReadLine());
            Console.Write("v:");
            double v = Convert.ToDouble(Console.ReadLine());
            double a = (Math.Round(((x + y) / (u + v)), 2));
            Console.WriteLine($"x = {x}、y = {y}、u = {u}、v = {v}");
            Console.WriteLine($"(x+y) / (u+v) = {a}");

            if (a >= 2)
            {
                Console.WriteLine($"{a} >= 2 為真，故 z = x + y = {x + y}");
            }
            else
            {
                Console.WriteLine($"{a} >= 2 為非，故 z = u + v = {u + v}");
            }

            Console.ReadKey();

            //習題2-5

            Console.WriteLine("請輸入x、y:");
            Console.Write("x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"x = {x}、y = {y}");

            if (x >= y)
            {
                double z = Math.Pow(x, 2);
                Console.WriteLine($"{x} >= {y} 為真，故 z = x^2 = {z}");
            }
            else
            {
                double z = Math.Pow(y, 2);
                Console.WriteLine($"{x} >= {y} 為非，故 z = y^2 = {z}");
            }

            Console.ReadKey();


            //習題2-6

            Console.Write("請輸入income值:");
            double income = Convert.ToDouble(Console.ReadLine());
            double rate;
            int diff;

            if ((income / 10000) > 409)
            {
                rate = 0.4;
                diff = 721100;

            }
            else if ((income / 10000) > 218)
            {
                rate = 0.3;
                diff = 312100;

            }
            else if ((income / 10000) > 109)
            {
                rate = 0.21;
                diff = 115900;

            }
            else if ((income / 10000) > 41)
            {
                rate = 0.13;
                diff = 28700;

            }
            else
            {
                rate = 0.06;
                diff = 0;
            }

            double tax = (income * rate) - diff;
            Console.WriteLine($"tax = {tax}");
            Console.ReadKey();


            //習題2-7

            Console.WriteLine("請輸入(x,y):");
            Console.Write("x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y:");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("1st quadrant");
                }
                else if (y == 0)
                {
                    Console.WriteLine("X-axis");
                }
                else
                {
                    Console.WriteLine("4th quadrant");
                }
            }
            else if (x == 0)
            {
                if (y == 0)
                {
                    Console.WriteLine("Origin");
                }
                else
                {
                    Console.WriteLine("Y-axis");
                }
            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine("2nd quadran");
                }
                else if (y == 0)
                {
                    Console.WriteLine("X-axis");
                }
                else
                {
                    Console.WriteLine("3th quadran");
                }
            }
            Console.ReadKey();


            //補充習題1

            Console.Write("請輸入答對題數 :");
            int Correct = Convert.ToInt32(Console.ReadLine());


            switch (Correct)
            {
                case int c when (c > 0 && c <= 10):

                    Console.WriteLine($"恭喜得分{Correct * 6}分");
                    break;

                case int c when (c >= 11 && c <= 20):
                    Console.WriteLine($"恭喜得分{(Correct - 10) * 2 + 60}分");
                    break;

                case int c when (c >= 21 && c <= 40):
                    Console.WriteLine($"恭喜得分{(Correct - 20) * 1 + 60 + 20}分");
                    break;

                case int c when (c >= 40):
                    Console.WriteLine("恭喜得分100分");
                    break;

                default:
                    Console.WriteLine("答對題數輸入錯誤，請重新確認!");
                    break;

            }



            //補充習題2
            //過輕(BMI<18.5)、健康體重(18.5≦BMI<24)、過重(24≦BMI<27)及肥胖(BMI≧27)

            Console.Write("請輸入身高(m):");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("請輸入體重(kg):");
            double b = Convert.ToDouble(Console.ReadLine());
            double Bmi = b / Math.Pow(a, 2);
            Console.WriteLine($"BMI值 = {Bmi}");

            if (Bmi > 0 && Bmi < 18.5)
            {
                Console.WriteLine("標準為 過輕 ");
            }
            else if (Bmi >= 18.5 && Bmi < 24)
            {
                Console.WriteLine("標準為 健康體重 ");
            }
            else if (Bmi >= 24 && Bmi < 27)
            {
                Console.WriteLine("標準為 過重 ");
            }
            else if (Bmi >= 27)
            {
                Console.WriteLine("標準為 肥胖 ");
            }
            else
            {
                Console.WriteLine("輸入資料有誤，請重新輸入!");
            }

            Console.ReadKey();



            //補充習題3

            Console.WriteLine("請輸入任意三個數 x 、 y 、 z :");
            Console.Write(" x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write(" y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write(" z: ");
            double z = Convert.ToDouble(Console.ReadLine());

            if (x > y && x > z)
            {
                Console.WriteLine($" 三者中最大為 x = {x} ");

                if (y > z)
                {
                    Console.WriteLine($" 其次為 y = {y} ");
                    Console.WriteLine($" 最小為 z = {z} ");
                }
                else if (y == z)
                {
                    Console.WriteLine($" y = z = {y} ");
                }
                else
                {
                    Console.WriteLine($" 其次為 z = {z} ");
                    Console.WriteLine($" 最小為 y = {y} ");

                }

            }
            else if (y > x && y > z)
            {
                Console.WriteLine($" 三者中最大為 y = {y} ");

                if (x > z)
                {
                    Console.WriteLine($" 其次為 x = {x} ");
                    Console.WriteLine($" 最小為 z = {z} ");

                }
                else if (x == z)
                {
                    Console.WriteLine($" x = z = {x} ");
                }
                else
                {
                    Console.WriteLine($" 其次為 z = {z} ");
                    Console.WriteLine($" 最小為 x = {x} ");
                }

            }
            else if (z > x && z > y)
            {
                Console.WriteLine($" 三者中最大為 z = {z} ");
                if (x > y)
                {
                    Console.WriteLine($" 其次為 x = {x} ");
                    Console.WriteLine($" 最小為 y = {y} ");

                }
                else if (x == y)
                {
                    Console.WriteLine($" x = y = {x} ");
                }
                else
                {
                    Console.WriteLine($" 其次為 y = {y} ");
                    Console.WriteLine($" 最小為 x = {x} ");
                }
            }
            else
            {
                Console.WriteLine(" 輸入資料有誤，請重新輸入! ");
            }

            Console.ReadKey();

            //補充習題4
            //利潤低於或等於10萬元時，獎金可提10%；
            //利潤高于10萬元，低於20萬元時，低於10萬元的部分按10 % 提成，高於10萬元的部分，可提成7.5 %；
            //20萬到40萬之間時，高於20萬元的部分，可提成5 %；
            //40萬到60萬之間時，高於40萬元的部分，可提成3 %
            //60萬到100萬之間時，高於60萬元的部分，可提成1.5 %，
            //高於100萬元時；超過100萬元的部分按1 % 提成。


            Console.Write(" 請輸入當月利潤： ");
            double Profit = Convert.ToDouble(Console.ReadLine()) / 10000;
            double Bonus;


            if (Profit <= 10)
            {

                Console.WriteLine($"獎金金額為{Profit * 0.1}萬元");

            }
            else if (Profit > 10 && Profit <= 20)
            {
                Bonus = 100000 * 0.1;
                Console.WriteLine($"獎金金額為{(Profit - 10) * 0.075 + Bonus}萬元");

            }
            else if (Profit > 20 && Profit <= 40)
            {

                Bonus = (10 * 0.1) + (10 * 0.075);
                Console.WriteLine($"獎金金額為{(Profit - 20) * 0.05 + Bonus}萬元");

            }
            else if (Profit > 40 && Profit <= 60)
            {

                Bonus = (10 * 0.1) + (10 * 0.075) + (20 * 0.05);
                Console.WriteLine($"獎金金額為{(Profit - 40) * 0.03 * 10000 + Bonus}萬元");

            }
            else if (Profit > 60 && Profit <= 100)
            {

                Bonus = (10 * 0.1) + (10 * 0.075) + (20 * 0.05) + (20 * 0.03);
                Console.WriteLine($"獎金金額為{(Profit - 60) * 0.015 + Bonus}萬元");

            }
            else if (Profit > 100)
            {
                Bonus = (10 * 0.1) + (10 * 0.075) + (20 * 0.05) + (20 * 0.03) + (40 * 0.015);
                Console.WriteLine($"獎金金額為{(Profit - 100) * 0.01 + Bonus}萬元");
            }
            else if (Profit <= 0)
            {
                Console.WriteLine(" 輸入資料有誤，請重新輸入! ");
            }

            Console.ReadKey();


            //追加習題
            //使用switch改寫：輸入一個學生的分數，輸出該成績級別

            Console.Write("請輸入學生分數:");
            int Score = Convert.ToInt32(Console.ReadLine());

            switch (Score)
            {
                case int s when (s >= 90):
                    Console.WriteLine("grade = A");
                    break;

                case int s when (s >= 80 && s < 90):
                    Console.WriteLine("grade = B");
                    break;

                case int s when (s >= 70 && s < 80):
                    Console.WriteLine("grade = C");
                    break;

                case int s when (s >= 60 && s < 70):
                    Console.WriteLine("grade = D");
                    break;

                case int s when ( s < 60):
                    Console.WriteLine("grade = F");
                    break;

                default:
                    Console.WriteLine("答對題數輸入錯誤，請重新確認!");
                    break;
            }

            Console.ReadKey();


        }
    }
}
