using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ch3
{
    class Program
    {
        static void Main(string[] args)
        {
            //重新上傳

            //3-1：讀入五個整數，求這五個整數的和 (for & while)
            // for迴圈：
            Console.WriteLine("請輸入5個整數計算總和：");
            int n = 5;
            int sum = 0;
            int num = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($" 整數{i} = ");
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine($"5個總數總和為{sum}");
            Console.ReadKey();

            //while迴圈：
            int i = 0;
            int sum = 0;
            int num = 0;
            Console.WriteLine("請輸入5個整數計算總和：");

            while (i < 5)
            {
                Console.Write($" 整數{i + 1} = ");
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                i++;
            }

            Console.WriteLine($"5個總數總和為{sum}");
            Console.ReadKey();


            //3-2：求N個整數的和，N由使用者輸入。 (for & while)

            //for迴圈：
            int sum = 0;
            int num = 0;

            Console.Write("請輸入要計算幾個整數的總和?  Ans:");
            int n = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.Write($" 整數{i} = ");
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine($"{n}個總數總和為{sum}");
            Console.ReadKey();

            //while迴圈：
            int i = 0;
            int sum = 0;
            int num = 0;
            Console.Write("請輸入要計算幾個整數的總和?  Ans:");
            int n = Convert.ToInt32(Console.ReadLine());

            while (i < n)
            {
                Console.Write($" 整數{i + 1} = ");
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                i++;

            }

            Console.WriteLine($"{n}個總數總和為{sum}");
            Console.ReadKey();


            //3-3：假設有N個正整數，求其中的最大值。(for & while)
            //先假設最大值(MAX)等於0，然後逐一檢查讀入的每一個數字，
            //如果比MAX還大，就令MAX等於這個數字，
            //如果沒有比MAX大，就不做任何事情，
            //最後MAX一定會是這一串數字中的最大值。

            //for迴圈：
            int max = 0;
            int num = 0;
            Console.Write("請輸入n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"整數{i}= ");
                num = Convert.ToInt32(Console.ReadLine());
                if (max < num)
                {
                    max = num;
                }

            }
            Console.WriteLine($"MAX={max}");
            Console.ReadKey();


            //while迴圈：
            int i = 1;
            int num = 0;
            int max = 0;
            Console.Write("請輸入n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            while (i <= n)
            {
                Console.Write($"整數{i}= ");
                num = Convert.ToInt32(Console.ReadLine());
                i++;
                if (max < num)
                {
                    max = num;

                }
            }

            Console.WriteLine($"MAX={max}");
            Console.ReadKey();


            //3-4：假設有N個正整數，求最大奇數值。(for & while)
            //用 % (取餘數)運算，例如將n除以2之後若餘0，為偶數，若餘1則為奇數。

            //for迴圈：
            int max = int.MinValue;
            int num = 0;
            Console.Write("請輸入n = ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("輸入格式錯誤，請重新執行程式...");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"正整數{i}=");
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 1 && num > max && num > 0)
                {
                    max = num;
                }
                else if (num < 0)                                       //考試可簡化不寫
                {
                    Console.WriteLine($"需輸入正整數，請重新輸入...");  //考試可簡化不寫
                    i--;                                             //考試可簡化不寫
                }
            }
            if (max == int.MinValue)                                              //考試可簡化不寫
            {
                Console.WriteLine($"輸入值皆為偶數");                    //考試可簡化不寫
            }
            else                                                       //考試可簡化不寫
            {
                Console.WriteLine($"最大奇數值={max}");
            }

            Console.ReadKey();



            //while迴圈： 
            int max = int.MinValue;
            int num = 0;

            int i = 1;
            Console.Write(" 輸入n = ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("輸入格式錯誤，請重新執行程式...");
                return;
            }

            while (i <= n)
            {
                Console.Write($"正整數{i}=");
                string input = Console.ReadLine();
                int.TryParse(input, out num);

                if (num < 0 || !int.TryParse(input, out num))
                {
                    Console.WriteLine($"格式錯誤，請重新輸入...");

                    continue;
                }

                if (num % 2 == 1 && num > 0 && max < num)
                {
                    max = num;

                }
                i++;

            }
            if (max == int.MinValue)
            {
                Console.WriteLine($"沒有輸入奇數");
            }
            else
            {
                Console.WriteLine($"最大奇數值={max}");
            }
            Console.ReadKey();


            //3-5：求N階層，即求1*2*3*…*N。請求輸入N，讓for迴圈自2依序乘到N。(for & while)
            //for迴圈：
            int sum = 1;
            Console.Write("請輸入N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= N; i++)
            {
                sum = sum * i;
            }

            Console.WriteLine($"{N} 階層 = {sum}");
            Console.ReadKey();


            //while迴圈：
            int i = 2;
            int sum = 1;
            Console.Write("請輸入N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            while (i <= N)
            {
                sum = sum * i;
                i++;

            }
            Console.WriteLine($"{N} 階層 = {sum}");
            Console.ReadKey();


            //*3-6：輸出一個九九乘法表。利用兩層迴圈，又稱巢狀迴圈；迴圈的層數沒有限制，但越多效率越差。(for & while)

            //for迴圈：
            Console.WriteLine("開始輸出九九乘法表:");

            for (int i = 1; i <= 9; i++)
            {
                for (int a = 1; a <= 9; a++)
                {
                    Console.WriteLine($"{i} * {a} = {i * a}");
                }
            }
            Console.ReadKey();

            while迴圈：

            Console.WriteLine("開始輸出九九乘法表:");
            int a = 1;
            int i = 1;

            while (i <= 9)
            {

                while (a <= 9)
                {

                    Console.WriteLine($"{i} * {a} = {i * a}");
                    a++;
                }
                i++;
                a = 1;

            }

            Console.ReadKey();


            //*3-7：輸出一個九九乘法表(排列過)

            //for迴圈：
            Console.WriteLine("開始輸出排列後九九乘法表:");


            for (int i = 1; i <= 9; i += 3)
            {
                for (int a = 1; a <= 9; a++)
                {

                    Console.WriteLine($"{i} * {a} = {i * a} \t {i + 1} * {a} = {(i + 1) * a} \t {i + 2} * {a} = {(i + 2) * a}");

                    //另一寫法: Console.WriteLine($"{i}*{a}={i * a}".PadRight(10) + $"{i + 1}*{a}={(i + 1) * a}".PadRight(10) + $"{i + 2}*{a}={(i + 2) * a}".PadRight(10));

                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();

            //while迴圈：
            Console.WriteLine("開始輸出排列後九九乘法表:");
            int a = 1;
            int i = 1;

            while (i <= 9)
            {

                while (a <= 9)
                {

                    Console.WriteLine($"{i} * {a} = {i * a} \t {i + 1} * {a} = {(i + 1) * a} \t {i + 2} * {a} = {(i + 2) * a}");
                    a++;
                }
                i += 3;
                a = 1;
                Console.WriteLine("\n");

            }

            Console.ReadKey();


            //習題3-1 寫一程式，輸入10個整數，求其最小值。(for & while)
            //for迴圈：
            int min = int.MaxValue;
            int num;
            Console.WriteLine($"請輸入10個整數:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"第{i + 1}個整數 = ");

                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("輸入錯誤，請重新輸入...");
                    i--;
                    continue;
                }

                if (num < min)
                {

                    min = num;
                }

            }
            Console.WriteLine($"最小值為:{min}");
            Console.ReadKey();


            //while迴圈：
            int min = int.MaxValue;
            int num;
            int i = 0;
            Console.WriteLine($"請輸入10個整數:");
            while (i < 10)
            {
                Console.Write($"第{i + 1}個整數 = ");

                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("輸入錯誤，請重新輸入...");

                    continue;
                }

                if (num < min)
                {

                    min = num;
                }
                i++;
            }
            Console.WriteLine($"最小值為:{min}");
            Console.ReadKey();


            //習題3-2 寫一程式，輸入N個整數，求其最小值。(for & while)

            //for迴圈：
            int min = int.MaxValue;

            Console.Write("輸入N = ");
            if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
            {
                Console.WriteLine("格式輸入錯誤，請重新輸入...");
                return;
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write($"輸入整數{i + 1}= ");

                if (!int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine("格式輸入錯誤，請重新輸入...");
                    i--;
                    continue;
                }
                else if (num < min)
                {
                    min = num;

                }

            }
            Console.WriteLine($" 最小值 = {min} ");
            return;


            //while迴圈：

            int min = int.MaxValue;
            int i = 0;
            Console.Write("輸入N = ");
            if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
            {
                Console.WriteLine("格式輸入錯誤，請重新輸入...");
                return;
            }

            while (i < N)
            {
                Console.Write($"輸入整數{i + 1}= ");

                if (!int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine("格式輸入錯誤，請重新輸入...");

                    continue;
                }
                else if (num < min)
                {
                    min = num;

                }
                i++;

            }
            Console.WriteLine($" 最小值 = {min} ");
            return;



            //習題3-3 寫一程式，輸入10個整數，列出其中所有大於12的數字。(for & while)
            //for迴圈：
            int num = 0;
            string result = "";

            Console.WriteLine("輸入10個整數:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"整數{i + 1} : ");

                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("格式錯誤，請重新輸入...");
                    i--;
                    continue;
                }
                else if (num > 12)
                {
                    if (result != "")
                    {
                        result += ",";
                    }
                    result += num;
                }

            }

            if (result == "")
            {
                Console.WriteLine("沒有大於12的整數");
            }
            else
            {
                Console.WriteLine(result);
            }
            Console.ReadKey();

            //while迴圈：
            int num = 0;
            string result = "";
            int i = 0;
            Console.WriteLine("輸入10個整數:");
            while (i < 10)
            {
                Console.Write($"整數{i + 1} : ");

                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("格式錯誤，請重新輸入...");

                    continue;
                }
                else if (num > 12)
                {
                    if (result != "")
                    {
                        result += "、";
                    }
                    result += num;
                }
                i++;
            }

            if (result == "")
            {
                Console.WriteLine("沒有大於12的整數");
            }
            else
            {
                Console.WriteLine(result);
            }

            Console.ReadKey();


            //習題3-4 寫一程式，輸入10個整數，列出其中所有大於12的數字的總和。(for & while)
            //for迴圈：
            int sum = 0;
            int num;
            Console.WriteLine("請輸入10個整數:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"整數{i + 1} : ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 12)
                {
                    sum += num;
                }
            }
            Console.WriteLine($"sum ={sum}");
            Console.ReadKey();


            //while迴圈：
            int sum = 0;
            int num;
            int i = 0;
            Console.WriteLine("請輸入10個整數:");

            while (i < 10)
            {
                Console.Write($"整數{i + 1} : ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 12)
                {
                    sum += num;
                }
                i++;
            }
            Console.WriteLine($"sum ={sum}");
            Console.ReadKey();


            //習題3-5 寫一程式，輸入N個數字，求其所有奇數中的最大值。例如輸入11,12,3,24,15，答案是15。(for & while)
            //for迴圈：
            int max = int.MinValue;
            int num;

            Console.Write("請輸入n = ");

            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("輸入格式錯誤，請重新執行程式...");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"數字{i}=");

                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine($"輸入格式錯誤，請重新輸入...");
                    i--;
                    continue;

                }
                else if (Math.Abs(num) % 2 == 1 && num > max)
                {    //Math.Abs(num)%2==1 也可以改成 num % 2 != 0
                    max = num;
                }
            }

            if (max == int.MinValue)
            {

                Console.WriteLine($"輸入值皆為偶數");
                return;
            }
            else
            {
                Console.WriteLine($"最大奇數值={max}");
                return;
            }


            //while迴圈：
            int max = int.MinValue;
            int num;
            int i = 1;
            Console.Write("請輸入n = ");

            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("輸入格式錯誤，請重新執行程式...");
                return;
            }

            while (i <= n)
            {
                Console.Write($"數字{i}=");

                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine($"輸入格式錯誤，請重新輸入...");
                    continue;

                }
                else if (Math.Abs(num) % 2 == 1 && num > max)
                {
                    max = num;
                }
                i++;
            }

            if (max == int.MinValue)
            {

                Console.WriteLine($"輸入值皆為偶數");
                return;
            }
            else
            {
                Console.WriteLine($"最大奇數值={max}");
                return;
            }


            //習題3-6 寫一程式，輸入N個數字，求其所有正數之平方的加總。例如輸入1,-2,3,-4,5五個數字，得到 1^2 + (-2)^2 + 3^2 + (-4)^2 + 5^2 => 1 + 9 + 25 = 35  (for & while)
            //for迴圈：
            int sum = 0;
            int num;
            Console.Write("N =");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)

            {
                Console.Write($"數字{i + 1} = ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                {
                    sum = sum + num * num;
                }

            }
            Console.WriteLine($"sum = {sum}");
            Console.ReadKey();

            //while迴圈：
            int sum = 0;
            int num;
            int i = 0;
            Console.Write("N =");
            int n = Convert.ToInt32(Console.ReadLine());

            while (i < n)
            {
                Console.Write($"數字{i + 1} = ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                {
                    sum = sum + num * num;
                }
                i++;
            }
            Console.WriteLine($"sum = {sum}");
            Console.ReadKey();


            //習題3-7 寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數，例如 -7會被轉換成7。(for & while)
            //for迴圈：
            string result = "";
            int num;
            Console.Write("輸入N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"數字{i + 1} = ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    if (result != "")
                    {
                        result += "、";
                    }
                    result += Math.Abs(num);

                }
                else if (num > 0)
                {
                    if (result != "")
                    {
                        result += "、";
                    }
                    result += num;
                }

            }
            Console.WriteLine(result);
            Console.ReadKey();


            //while迴圈：
            string result = "";
            int i = 0;
            int num;
            Console.Write("輸入N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (i < n)
            {
                Console.Write($"數字{i + 1} = ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    if (result != "")
                    {
                        result += "、";
                    }
                    result += Math.Abs(num);

                }
                else if (num > 0)
                {
                    if (result != "")
                    {
                        result += "、";
                    }
                    result += num;
                }
                i++;
            }
            Console.WriteLine(result);
            Console.ReadKey();





            //補充習題1 判斷101 - 200之間有多少個質數，並輸出所有質數。(for & while)
            //for迴圈：
            int num = 0;
            string result = "";

            for (int i = 101; i < 201; i += 2)
            {
                //double x = Math.Sqrt(i);
                bool IsPrime = true;
                //Console.WriteLine(i);  //檢查用
                for (int y = 2; y < i; y++)
                {

                    if (i % y == 0)
                    {
                        IsPrime = false;
                        break;
                    }

                }
                //Console.WriteLine(IsPrime);  //檢查用

                if (IsPrime == true)
                {
                    num += 1;
                    result += i + " ";
                }

            }

            Console.WriteLine($"共{num}個質數: {result}");
            Console.ReadKey();


            //while迴圈：
            int num = 0;
            string result = "";
            int i = 101;

            while (i < 201)
            {

                bool IsPrime = true;
                int y = 2;
                //Console.WriteLine(i);  //檢查用
                while (y < i)
                {

                    if (i % y == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                    y++;
                }
                //Console.WriteLine(IsPrime);  //檢查用
                if (IsPrime == true)
                {
                    num += 1;
                    result += i + " ";
                }
                i += 2;
            }

            Console.WriteLine($"共{num}個質數: {result}");
            Console.ReadKey();


            //補充習題2 輸入一個數，輸出其質因數。(for & while)        
            //for迴圈：
            string result = "";
            Console.Write("輸入一個數: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {

                    bool IsPrime = true;

                    for (int y = 2; y < i; y++)
                    {

                        if (i % y == 0)
                        {
                            IsPrime = false;
                            break;
                        }

                    }


                    if (IsPrime == true)
                    {

                        result += i + " ";
                    }

                }
            }
            Console.Write($"數字 {n} 的質因數為: {result}");
            Console.ReadKey();


            //while迴圈：
            string result = "";
            Console.Write("輸入一個數: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            while (i <= n)
            {
                if (n % i == 0)
                {
                    bool IsPrime = true;
                    int y = 2;
                    while (y < i)
                    {

                        if (i % y == 0)
                        {
                            IsPrime = false;
                            break;
                        }
                        y++;
                    }

                    if (IsPrime == true)
                    {

                        result += i + " ";
                    }

                }
                i++;
            }
            Console.Write($"數字 {n} 的質因數為: {result}");
            Console.ReadKey();



            //補充習題3 求100到300中可以被3與7整除的個數。(for & while)
            //for迴圈：
            int result = 0;
            for (int i = 100; i < 301; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    result += 1;
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();


            //while迴圈：
            int result = 0;
            int i = 100;
            while (i < 301)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    result += 1;
                }
                i++;
            }
            Console.WriteLine(result);
            Console.ReadKey();




        }





    }



    

    
}
