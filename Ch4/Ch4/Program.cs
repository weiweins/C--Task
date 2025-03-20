using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    class Program
    {
        static void Main(string[] args)
        {
            //例題4.1
            //讀入一連串的數字，但事先不知道數字的數目。
            //設定一個特殊的數字，一旦讀到這個數字就終止迴圈。
            //假設輸入的都是正數，一旦讀到負數就終止。
            int answer;
            int input;
            bool end = false;
            Console.Write("請輸入特殊數字: ");
            answer = Convert.ToInt32(Console.ReadLine());



            do
            {
                Console.Write("請輸入數字: ");
                input = Convert.ToInt32(Console.ReadLine());

                if (input == answer)
                {
                    Console.WriteLine("猜對了!");
                    end = true;
                }
                else if (input != answer && input < 0)
                {
                    Console.WriteLine("遊戲結束");
                    end = true;
                }

            } while (end == false);

            Console.ReadKey();




            //例題4.2
            //求最大公約數(Greatest Common Divisor，簡寫G.C.D.，或稱最大公因數)。
            //指能夠整除多個整數的最大正整數。而多個整數不能都為零。例如8和12的最大公因數為4。
            //Hint: 輾轉相除法：兩數相除，取餘數重複進行相除，直到餘數為0時，前一個除數即為最大公約數。
            Console.WriteLine("請輸入兩數字 :");
            Console.Write("請輸入數字a :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入數字b :");
            int b = Convert.ToInt32(Console.ReadLine());

            while (b != 0 && a != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;

                if (b == 0)
                {
                    Console.WriteLine($"兩數的最大公因數為{a}");
                    break;
                }
            }
            Console.ReadKey();


            //習題4-1 利用while寫一程式求N個數字的最大值。
            int max = int.MinValue;
            int i = 0;
            Console.Write("輸入n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            while (i < n)
            {
                Console.Write($"輸入數字{i + 1} = ");
                if (!int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine("格式錯誤，請重新輸入...");
                    continue;
                }
                else if (num > max)
                {
                    max = num;
                }
                i++;
            }
            Console.WriteLine($"最大值 = {max}");
            Console.ReadKey();



            //習題4-2 利用while寫一程式求一個等差級數數字的和，一共有N個數字，程式應該輸入最小的起始值以及數字間的差。(即從起始值開始，間格差，共N個 的總和)
            Console.Write("請輸入N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入最小起始值 = ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入間格差 = ");
            int spacing = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int sum = 0;

            while (i < n)
            {
                sum += num;
                num += spacing;
                i++;
            }
            Console.Write($"和 = {sum}");
            Console.ReadKey();


            //習題4-3 利用while寫一程式，讀入N個數字，然後找出所有小於13的數，再求這些數字的和。
            int sum = 0;
            int num = 0;
            int i = 0;
            Console.Write("輸入n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (i < n)
            {
                Console.Write($"數字{i + 1} = ");
                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("格式錯誤，請重新輸入...");
                    continue;
                }
                else if (num < 13)
                {
                    sum += 1;
                }
                i++;
            }

            Console.WriteLine($"小於13的數字和 = {sum}");
            Console.ReadKey();

            //習題4-4 利用while寫一程式，讀入N個數字，找到第一個大於7而小於10的數字就停止，而且列印出這個數字。
            int input = 0;
            bool end = false;
            Console.Write("請輸入N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < n)
            {
                Console.Write($"請輸入數字{i + 1} = ");

                if (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("格式錯誤，請重新輸入...");
                    continue;
                }
                else if (input > 7 && input < 10)
                {

                    end = true;
                    Console.WriteLine("程式停止");
                    break;
                }
                i++;
            }
            if (end == false)
            {
                Console.WriteLine("沒有符合的數字");
            }
            else
            {
                Console.WriteLine(input);
            }

            Console.ReadKey();



            //習題4-5 利用while寫一程式，讀入a1,a2,…,a5和b1,b2,…,b5。找到第一個ai > bi，即停止，並列印出ai及bi。
            int i = 0;
            bool stop = true;
            while (i < 5)
            {
                Console.Write($"請輸入a{i + 1}:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write($"請輸入b{i + 1}:");
                int b = Convert.ToInt32(Console.ReadLine());
                if (a > b)
                {
                    Console.WriteLine($"({a}, {b})");
                    break;
                }
                else
                {
                    stop = false;
                }
                i++;
            }
            if (stop == false)
            {
                Console.WriteLine("每組的 a 與 b 沒有任一組符合 a > b");
            }
            Console.ReadKey();



            //補充題1 Eric覺得麥蒂勞的39元漢堡實在太便宜、太好吃了，因此他決定晚餐要把口袋裡所有錢通通拿來吃39元漢堡。假設他每5分鐘就能吃一個漢堡，請隨意輸入一個時間，輸出這段時間吃漢堡的紀錄。
            Console.Write("輸入時間(分鐘):");
            int time = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int i = 0;

            while (i <= time)
            {
                if (time - i < 5)
                {
                    break;
                }
                count += 1;
                i += 5;

            }
            Console.WriteLine($"{time}分鐘可以吃{count}個漢堡");
            Console.ReadKey();


            //補充題2 小明貸款買房花560萬，每個月可還4萬，每還12個月，因為年終獎金可以多還一萬，請問需要幾個月還清。
            int Cost = 5600000;
            int MonthPayment = 40000;
            int Month = 0;

            while (Cost >= 0)
            {
                Cost -= MonthPayment;
                if (Month % 12 == 11)
                {
                    Cost -= 1;
                }
                Month += 1;

            }
            Console.WriteLine($"{Month}個月可以還清");
            Console.ReadKey();


            ////補充題3 系統隨機產生一個數字，讓使用者數入數字，直到猜中才離開程式！ 猜錯時，要提示是比較大還是比較小。
            Random random = new Random();
            int secret = random.Next(0,11); // 宣告 答案
            int get;   //玩家猜的數字
            int count = 0;  //宣告 次數
            int max = 3; //宣告 次數上限
            bool win = false; //是否猜對了

            do
            {
                Console.Write("請玩家猜一個0~10的數字(有3次機會):");
                get = Convert.ToInt32(Console.ReadLine());

                if (get > secret)
                {
                    Console.WriteLine("小一點!");
                    count++;
                }
                else if (get == secret)
                {
                    Console.WriteLine("你贏了!");
                    count++;
                    win = true;
                }
                else
                {
                    Console.WriteLine("大一點!");
                    count++;
                }
            } while (count < max && win == false);  //是否繼續再跑執行迴圈的條件

            if (win == false)
            {
                Console.WriteLine($"你輸了! 答案是{secret}");
            }

            Console.ReadKey();



        }
    }
}
