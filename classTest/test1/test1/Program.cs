using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 2~50 總和

            //int sum = 0;

            //for (int i = 2; i <= 50; i++)
            //{
            //    Console.WriteLine(Console.ReadLine());
            //    sum += i;
            //}

            //Console.WriteLine(sum);
            //Console.ReadKey();


            //猜數字小遊戲

            int secret = 55; // 宣告 答案
            int get;   //玩家猜的數字
            int count = 0;  //宣告 次數
            int max = 3; //宣告 次數上限
            bool win = false; //是否猜對了

            do
            {
                Console.Write("請玩家猜一個數字:");
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

            if ( win == false)
            {
                Console.WriteLine("你輸了!");
            }

            Console.ReadKey();
        }

    }
}
