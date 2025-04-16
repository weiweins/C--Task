using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ch7
{
    class Program
    {
        static void Main(string[] args)
        {
            //檔案作業
            //1 寫一篇中文歌的歌詞到到自己指定的文字檔(使用UTF - 8編碼)。
            string path = @"C:\Users\Wei\Desktop\exercises\Fire-Task\Ch7\song.txt";
            string[] lines = { "你和我背著空空的書包", "逃出名為日常的監牢", "忘了要長大", "忘了要變老", "忘了時間有腳" };
            File.WriteAllLines(path, lines, Encoding.UTF8);
            Console.WriteLine("程式執行完畢!");
            Console.ReadKey();


            //2 讀取1.txt 顯示在畫面上。
            string path1 = @"C:\Users\Wei\Desktop\exercises\Fire-Task\Ch7\1.txt";
            string input = "123456";
            File.WriteAllText(path1, input);
            string text = File.ReadAllText(path1);
            Console.WriteLine(text);
            Console.ReadKey();


            //補充1 寫入九九乘法表資料到一個文字檔到自己指定的文字檔。(1.txt)
            string path = @"C:\Users\Wei\Desktop\exercises\Fire-Task\Ch7\1.txt";
            string content;
            string title = "九九乘法表 : \n\n";
            File.WriteAllText(path, title, Encoding.UTF8);

            for (int i = 1; i <= 9; i += 3)
            {
                for (int a = 1; a <= 9; a++)
                {
                    content = $"{i} * {a} = {i * a} \t {i + 1} * {a} = {(i + 1) * a} \t {i + 2} * {a} = {(i + 2) * a} \n";
                    File.AppendAllText(path, content);
                }
            }
            Console.WriteLine("程式執行完畢!");
            Console.ReadKey();


            //補充2 讀取1.txt 顯示在畫面上，並將1.txt 裡的阿拉伯數字，轉換成中文數字(壹、貳、叁、肆…..)，並儲存到指定的路徑。(UTF-8)
            string path = @"C:\Users\Wei\Desktop\exercises\Fire-Task\Ch7\1.txt";
            List<string> content = new List<string> { };
            //string[] content = new string[];
            string title = "九九乘法表 : \n\n";
            string title2 = "轉換前 : \n\n";
            string title3 = "轉換後 : \n\n";

            File.WriteAllText(path, title, Encoding.UTF8);
            File.AppendAllText(path, title2);
            for (int i = 1; i <= 9; i += 3)
            {
                for (int a = 1; a <= 9; a++)
                {

                    content.Add($"{i} * {a} = {i * a} \t {i + 1} * {a} = {(i + 1) * a} \t {i + 2} * {a} = {(i + 2) * a} \n");


                }
            }

            File.AppendAllLines(path, content);
            File.AppendAllText(path, title3);

            for (int n = 0; n < content.Count; n++)
            {
                content[n] = content[n].Replace("0", "零")
                    .Replace("1", "壹")
                    .Replace("2", "貳")
                    .Replace("3", "叁")
                    .Replace("4", "肆")
                    .Replace("5", "伍")
                    .Replace("6", "陸")
                    .Replace("7", "柒")
                    .Replace("8", "捌")
                    .Replace("9", "玖");

            }
            File.AppendAllLines(path, content, Encoding.UTF8);
            Console.WriteLine("程式執行完畢!");
            Console.ReadKey();

            //補充3 讀取fc4bb.csv，並將此資料轉成HTML TABLE 格式，並儲存到指定的HTML檔裡。  //可以考慮加上網格 (可用html.AppendLine跟foreach)
            string path = @"C:\Users\Wei\Desktop\exercises\Fire-Task\Ch7\fc4bb.csv";
            string path1 = @"C:\Users\Wei\Desktop\exercises\Fire-Task\Ch7\index.html";
            List<string> content = File.ReadAllLines(path).ToList();

            //string[] lineText = File.ReadAllLines(path);
            for (int i = 0; i < content.Count; i++)
            {
                //    Console.WriteLine(content[i]);
                string[] lineText = content[i].Split(',');
                string tdLines = string.Join("", lineText.Select(item => $"<td> {item} </td>"));
                content[i] = $"<tr>{tdLines}</tr>";
                //    Console.WriteLine(content[i]);
            }
            string tableHtml = "<table>\n" + string.Join("\n", content) + "\n </table>";
            //以上行可以加入boder格線: string tableHtml = "<table border=\"l\"> \n" + string.Join("\n", content) + "\n </table>";



            File.WriteAllText(path1, tableHtml, Encoding.UTF8);
            Console.ReadKey();


            //亂數作業
            //1 請隨機由0~99產生一個數字輸出。 (Random rom = new Random();//亂數種子 、 int I = rom.Next(0, 100);//回傳0-99的亂數)
            Random rom = new Random();
            int I = rom.Next(0, 100);
            Console.WriteLine(I);
            Console.ReadKey();


            //2 請隨機由0~99產生10個數字輸出。
            Random num = new Random();
            List<int> result = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                result.Add(num.Next(0, 100));
            }

            Console.WriteLine(string.Join(",", result));
            Console.ReadKey();

            //3 隨機幫每位學員產生成績，並寫入文字檔(欄位之間用，分開，換行寫入下一筆)。
            string path = @"C:\Users\Wei\Desktop\exercises\Fire-Task\Ch7\score.txt";
            Random rom = new Random();
            List<string> text = new List<string> { };
            Console.Write("請輸入一共幾位學員 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                text.Add($"學員{i + 1} = {rom.Next(101)},\n");
            }
            File.WriteAllLines(path, text, Encoding.UTF8);
            Console.ReadKey();


            //補充1 請設計樂透開獎程式。   //可以改用switch寫，程式會比較短
            Console.WriteLine("1-49之間選擇輸入6個號碼 + 1個特別號: ");
            Random rom = new Random();
            string[] myNum = new string[6];
            string mySpecial = "";
            string[] num = new string[6];
            List<string> compare = new List<string> { };
            string specialNum = Convert.ToString(rom.Next(1, 50));

            //輸入自選號
            for (int x = 0; x < 6; x++)
            {
                Console.Write($"請輸入第{x + 1}個號碼 : ");
                string input1 = Console.ReadLine(); ;
                if (!int.TryParse(input1, out int val1) || string.IsNullOrWhiteSpace(input1) || myNum.Contains(input1) || val1 <= 0 || val1 > 49)
                {
                    Console.WriteLine("輸入格式錯誤或與前面輸入的號碼重複了!請重新輸入...");
                    x--;
                }
                else
                {
                    myNum[x] = input1;
                }
            }
            for (int s = 0; s < 1; s++)
            {
                Console.Write("請輸入第7個數(特別號) :　");
                string input2 = Console.ReadLine();
                if (!int.TryParse(input2, out int val2) || string.IsNullOrWhiteSpace(input2) || myNum.Contains(input2) || val2 <= 0 || val2 > 49)
                {
                    Console.WriteLine("輸入格式錯誤或與前面6個號碼重複了!請重新輸入...");
                    s--;
                }
                else
                {
                    mySpecial = input2;
                }

            }

            //抽號碼
            for (int i = 0; i < 6; i++)
            {
                string n = Convert.ToString(rom.Next(1, 50));
                if (num.Contains(n) || specialNum == n)
                {
                    i--;
                }
                else
                {
                    num[i] = n;
                }
            }
            Console.WriteLine($"抽出的6個號碼 : {string.Join(",", num)}，特別號 : {specialNum} ");
            Console.WriteLine($"你輸入的6個號碼 : {string.Join(",", myNum)}，特別號 : {mySpecial}");

            //對獎
            for (int y = 0; y < 6; y++)
            {

                if (myNum.Contains(num[y]))
                {
                    compare.Add(num[y]);
                }
            }

            if (compare.Count == 6)
            {
                Console.WriteLine("恭喜中頭獎!");

            }
            else if (compare.Count == 5 && mySpecial == specialNum)
            {
                Console.WriteLine("恭喜中貳獎!");

            }
            else if (compare.Count == 5)
            {
                Console.WriteLine("恭喜中參獎!");
            }
            else if (compare.Count == 4 && mySpecial == specialNum)
            {
                Console.WriteLine("恭喜中肆獎!");
            }
            else if (compare.Count == 4)
            {
                Console.WriteLine("恭喜中伍獎!");
            }
            else if (compare.Count == 3 && mySpecial == specialNum)
            {
                Console.WriteLine("恭喜中陸獎!");
            }
            else if (compare.Count == 3)
            {
                Console.WriteLine("恭喜中柒獎!");
            }
            else if (compare.Count == 2 && mySpecial == specialNum)
            {
                Console.WriteLine("恭喜中普獎!");
            }
            else
            {
                Console.WriteLine("很可惜沒有中獎!");
            }
            Console.ReadKey();



            //補充2 請在文字檔裡輸入所有午餐的店家，讀取文字檔，隨機抽出今天中午要吃哪一家。
            string path = @"C:\Users\Wei\Desktop\exercises\Fire-Task\Ch7\shop.txt";
            List<string> shop = new List<string> { };
            shop = File.ReadAllLines(path).ToList();
            Random num = new Random();
            Console.WriteLine(shop[num.Next(shop.Count)]);
            Console.ReadKey();

            //補充3 請在文字檔裡輸入所有教室裡的學員名字，讀取文字檔，隨機抽出今天的值日生，抽過不能再被抽中，直到全部學員都被抽過，才可以再被抽。
            string path = @"C:\Users\Wei\Desktop\exercises\Fire-Task\Ch7\student.txt";
            List<string> student = new List<string> { };
            List<string> selected = new List<string> { };
            student = File.ReadAllLines(path).ToList();
            Random name = new Random();

            while (selected.Count < student.Count)
            {
                string today = student[name.Next(student.Count)];
                if (selected.Contains(today))
                {

                    Console.WriteLine($"{today}抽過了，請重抽!");
                    //若這裡增加 Console.ReadKey();  可以變成每次抽籤完，要按enter後才會再抽下一次 ...因為每個迴圈都有，所以可以移到if else迴圈外面
                }
                else
                {

                    Console.WriteLine($"今天值日生 : {today}");
                    selected.Add(today);
                    //若這裡增加 Console.ReadKey();  可以變成每次抽籤完，要按enter後才會再抽下一次 ...因為每個迴圈都有，所以可以移到if else迴圈外面
                }
                Console.ReadKey();
            }

            Console.WriteLine("大家都輪過了!");
            selected.Clear();
            Console.ReadKey();



            //日期作業
            //1 顯示現在日期與時間。
            DateTime nowTime = DateTime.Now;
            Console.WriteLine(nowTime);
            Console.ReadKey();


            //2 顯示再過30天為哪一天。
            DateTime nowDate = DateTime.Now;
            DateTime theDate = nowDate.AddDays(30);
            Console.WriteLine($"再過30天為 : {theDate.Year}年{theDate.Month}月{theDate.Day}日");
            Console.ReadKey();


            //3 顯示24小時前的年月日時分秒。
            DateTime nowTime = DateTime.Now;
            DateTime lastTime = nowTime.AddHours(-24);
            Console.WriteLine($"24小時前的時間為：{lastTime}");
            Console.ReadKey();


            //4 取得目前是幾月。
            DateTime nowTime = DateTime.Now;
            Console.WriteLine($"目前是{nowTime.Month}月");
            Console.ReadKey();


            //5 取得明年是否為閏年。(可以試試民國)
            DateTime year = DateTime.Today; //今年
            year = year.AddYears(+1); //明年
            int next = (int)year.Year;//轉int 
                                      //Console.WriteLine(next);
            int result = next - 1911; //轉民國

            if (LeapYear(next))
            {

                Console.WriteLine($"明年是ua民國{result}年，是閏年");
            }
            else
            {
                Console.WriteLine($"明年是民國{result}年，不是閏年");
            }


            //6 取得離2026年1月1日還有幾天。
            DateTime nowTime = DateTime.Now;
            DateTime theDate = new DateTime(2026, 01, 01);
            int total = (int)(theDate.Date - nowTime.Date).Days; //用.Date只取日期計算、不計算到時間
            Console.WriteLine($"離2026年1月1日還有{total}天");
            Console.ReadKey();


            //補充1 請顯示今天猴子做甚麼事。
            //星期一，猴子穿新衣，
            //星期二，猴子肚子餓，
            //星期三，猴子去爬山，
            //星期四，猴子看電視，
            //呈期五，猴子去跳舞，
            //星期六，猴子去斗六，
            //星期日，猴子過生日。
            DateTime today = DateTime.Now;

            switch (today.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("星期一，猴子穿新衣");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("星期二，猴子肚子餓");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("星期三，猴子去爬山");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("星期四，猴子看電視");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("呈期五，猴子去跳舞");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("星期六，猴子去斗六");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("星期日，猴子過生日");
                    break;
                default:
                    Console.WriteLine("讀取錯誤，請重新執行程式...");
                    break;

            }




            //補充2 輸入兩個日期，輸出兩個日期相差幾天。
            Console.Write("請輸入第一個日期(西元年YYYY/MM/DD) : ");
            string[] input1 = (Console.ReadLine()).Split('/');
            int year1 = int.Parse(input1[0]);
            int month1 = int.Parse(input1[1]);
            int day1 = int.Parse(input1[2]);
            DateTime A = new DateTime(year1, month1, day1);

            Console.Write("請輸入第二個日期(西元年YYYY/MM/DD) : ");
            string[] input2 = (Console.ReadLine()).Split('/');
            int year2 = int.Parse(input2[0]);
            int month2 = int.Parse(input2[1]);
            int day2 = int.Parse(input2[2]);
            DateTime B = new DateTime(year2, month2, day2);
            int total = (int)(B.Date - A.Date).Days;
            Console.WriteLine($"兩日期距離{Math.Abs(total)}天");

            //補充3 兩光法師時常替人占卜，由於他算得又快又便宜，因此生意源源不絕，時常大排長龍，他想算得更快一點，因此找了你這位電腦高手幫他用電腦來加快算命的速度。
            //他的占卜規則很簡單，規則是這樣的，隨機產生一個今年日期，然後依照下面的公式：
            //M = 月
            //D = 日
            //S = (M * 2 + D) % 3
            //得到 S 的值，再依照 S 的值從 0 到 2 分別給與 普通、吉、大吉 等三種不同的運勢，輸出運勢。
            Random rom = new Random();
            DateTime date = new DateTime(2025, 1, 1);
            date = date.AddDays(rom.Next(0, 365)); //隨機加天數 0-364天:因為2025不是閏年(若要套用任意年份、+0-366要多判斷是否為閏年)
            int m = (int)date.Month;
            int d = (int)date.Day;
            //Console.WriteLine($"今年日期:{date}");

            int s = (m * 2 + d) % 3;
            Console.WriteLine($"占卜值S = {s}");
            if (s == 0)
            {
                Console.WriteLine("運勢：普通");
            }
            else if (s == 1)
            {
                Console.WriteLine("運勢：吉");
            }
            else if (s == 2)
            {
                Console.WriteLine("運勢：大吉");
            }
            Console.ReadKey();




        }

        public static bool LeapYear(int year)
        {

            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;

        }
    }
}
