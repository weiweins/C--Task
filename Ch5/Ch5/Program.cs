using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5-1 寫一程式，將10個數字讀入A陣列，然後逐一檢查此陣列，如A[i] > 5，則令A[i] = A[i] - 5，否則A[i] = A[i] + 5。
            int[] Arr = new int[10];
            int Input;
            Console.WriteLine("請輸入Arr的10個數字: ");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write($"數字Arr[{i}] = ");
                Input = Convert.ToInt32(Console.ReadLine());
                if (Input > 5)
                {
                    Arr[i] = Input - 5;
                }
                else
                {
                    Arr[i] = Input + 5;
                }

            }
            foreach (int Num in Arr)
            {

                Console.WriteLine(Num);
            }
            Console.ReadKey();


            //5-2 寫一程式，將10個數字讀入A陣列，對每一個數字，令A[i] = A[i] + i。
            int[] Arr = new int[10];
            int Input;
            Console.WriteLine("請依序輸入Arr的10個數字");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write($"數字{i + 1} = ");
                int.TryParse(Console.ReadLine(), out Input);
                Arr[i] = Input + i;

            }
            foreach (int Num in Arr)
            {
                Console.WriteLine(Num);
            }

            Console.ReadKey();


            //5-3 寫一程式，將10個數字讀入A陣列，並建立一個B陣列，如A[i] >= 0，令B[i] = 1，否則令B[i] = 0。
            int[] ArrA = new int[10];
            int[] ArrB = new int[10];
            Console.WriteLine("輸入依序ArrA的10個數字:");
            for (int i = 0; i < ArrA.Length; i++)
            {
                Console.Write($"Arr[{i}] = ");
                int.TryParse(Console.ReadLine(), out int Input);
                ArrA[i] = Input;
                if (Input >= 0)
                {
                    ArrB[i] = 1;
                }
                else
                {
                    ArrB[i] = 0;
                }

            }
            Console.WriteLine("ArrA的值：");
            foreach (int Num in ArrA)
            {
                Console.WriteLine(Num);
            }

            Console.WriteLine("ArrB的值：");
            foreach (int Num in ArrB)
            {
                Console.WriteLine(Num);
            }

            Console.ReadKey();


            //5-4 寫一程式，將15數字存入3 x 5的二維陣列A中，求每一行及每一列數字的和。
            int[,] ArrA = new int[3, 5];
            int Input;
            int[] Row = new int[3];
            int[] Col = new int[5];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"ArrA[{i},{j}] = ");
                    int.TryParse(Console.ReadLine(), out Input);
                    ArrA[i, j] = Input;
                    Row[i] += Input;
                    Col[j] += Input;
                }

            }
            Console.WriteLine($"第一行和 = {Row[0]}");
            Console.WriteLine($"第二行和 = {Row[1]}");
            Console.WriteLine($"第三行和 = {Row[2]}");
            Console.WriteLine();
            Console.WriteLine($"第一列和 = {Col[0]}");
            Console.WriteLine($"第二列和 = {Col[1]}");
            Console.WriteLine($"第三列和 = {Col[2]}");
            Console.WriteLine($"第四列和 = {Col[3]}");
            Console.WriteLine($"第五列和 = {Col[4]}");
            Console.ReadKey();


            //5-5 寫一程式，將15數字存入3 x 5的二維陣列A中，求每一行及每一列數字的最小值。
            int[,] ArrA = new int[3, 5];
            int Input;
            int[] Row = new int[3];
            int[] Col = new int[5];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"ArrA[{i},{j}] = ");
                    int.TryParse(Console.ReadLine(), out Input);
                    ArrA[i, j] = Input;

                }

            }
            //判斷行最小值
            for (int i = 0; i < 3; i++)
            {
                int min = ArrA[i, 0];
                for (int j = 1; j < 5; j++)
                {
                    if (ArrA[i, j] < min)
                    {
                        min = ArrA[i, j];

                    }

                }
                Row[i] = min;
            }

            //判斷列最小值
            for (int j = 0; j < 5; j++)
            {
                int min = ArrA[0, j];
                for (int i = 1; i < 3; i++)
                {
                    if (ArrA[i, j] < min)
                    {
                        min = ArrA[i, j];

                    }

                }
                Col[j] = min;
            }


            //NewArrA[] = Array.Sort(ArrA);
            Console.WriteLine($"第一行最小值 = {Row[0]}");
            Console.WriteLine($"第二行最小值 = {Row[1]}");
            Console.WriteLine($"第三行最小值 = {Row[2]}");
            Console.WriteLine();
            Console.WriteLine($"第一列最小值 = {Col[0]}");
            Console.WriteLine($"第二列最小值 = {Col[1]}");
            Console.WriteLine($"第三列最小值 = {Col[2]}");
            Console.WriteLine($"第四列最小值 = {Col[3]}");
            Console.WriteLine($"第五列最小值 = {Col[4]}");
            Console.ReadKey();

            //5-6 寫一程式，輸入兩組數字：a1,a2,…,a5和b1,b2,…,b5。求ai + bi，i = 1到i = 5。
            int[] ArrSum = new int[5];
            int a = 0;
            int b = 0;
            Console.WriteLine("請輸入5組a與b的數字:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"a{i + 1} = ");
                int.TryParse(Console.ReadLine(), out a);
                Console.Write($"b{i + 1} = ");
                int.TryParse(Console.ReadLine(), out b);
                ArrSum[i] = a + b;


            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"a{i + 1} + b{i + 1} = {ArrSum[i]}");
            }

            Console.ReadKey();

            //5-7 寫一程式，輸入兩組數字：a1,a2,…,a5和b1,b2,…,b5。令x為a中的最大值，令y為b中的最大值，求x與y中較小者。
            int[] ArrA = new int[5];
            int[] ArrB = new int[5];
            Console.WriteLine("請輸入5個數字a :");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"a{i + 1} = ");
                //int.TryParse(Console.ReadLine(), out int a);   //因為下面判斷式會寫到將輸入值存入a，這邊就不用寫了、同時引用兩個Console.ReadLine()會error
                if (!int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.WriteLine("格式輸入錯誤請重新輸入數字a...");
                    i--;
                    continue;
                }
                ArrA[i] = a;
            }
            Array.Sort(ArrA);
            Array.Reverse(ArrA);
            int x = ArrA[0];


            Console.WriteLine("請輸入5個數字b :");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"b{i + 1} = ");
                //int.TryParse(Console.ReadLine(), out int b);   //因為下面判斷式會寫到將輸入值存入b，這邊就不用寫了、同時引用兩個Console.ReadLine()會error

                if (!int.TryParse(Console.ReadLine(), out int b))
                {
                    Console.WriteLine("格式輸入錯誤請重新輸入數字b...");
                    i--;
                    continue;
                }
                ArrB[i] = b;
            }
            Array.Sort(ArrB);
            Array.Reverse(ArrB);
            int y = ArrB[0];

            if (x < y)
            {
                Console.WriteLine(x);
            }else if (y < x) 
            {
                Console.WriteLine(y);
            }else if (y == x)
            {
                Console.WriteLine("a中的最大值 = b中的最大值");
            }

            Console.ReadKey();
        }
    }
}
