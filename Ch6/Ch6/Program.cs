using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Deployment.Internal;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using static System.Net.WebRequestMethods;

namespace Ch6
{
    class Program
    {
        static void Main(string[] args)
        {
            //字串作業

            //1、輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin。
            Console.Write("請輸入姓名:");
            Console.WriteLine($"Hi~ {Console.ReadLine()}");
            Console.ReadKey();

            //2、請輸入任何一個字，是否出現在”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡。
            string A = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";
            Console.Write("請輸入文字:");
            bool check = A.Contains(Console.ReadLine());
            Console.WriteLine(check);
            Console.ReadKey();

            //3、輸入一段字，輸出每個之間多一個 -，如輸入apple ，輸出a - p - p - l - e。
            Console.Write("請輸入文字:");
            char[] A = Console.ReadLine().ToCharArray();
            string input = string.Join("-", A);
            Console.WriteLine(input);


            //4、輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg。
            Console.Write("請輸入一個檔名:");
            string input = Console.ReadLine();

            if (input.IndexOf(".") != -1)
            {
                string output = input.Substring(input.IndexOf("."));
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("未正確輸入副檔名，請重新輸入!");
            }
            Console.ReadKey();


            //5、輸入一個大於五個字的單字，若小於五個字輸出長度不夠，若大於五個字，則輸出前三個字。Length Substring()
            Console.Write("請輸入大於5的單字:");
            string input = Console.ReadLine();
            if (input.Length < 5)
            {
                Console.WriteLine("輸入的單字長度不足5! 請重新輸入");   //檢查長度是否有大於5
                return;
            }
            else if (!Regex.IsMatch(input, @"^[a-zA-Z\u4e00-\u9fa5]+$"))  //定義只能英文字跟中文字，不能包含數字或特殊字符
            {
                Console.WriteLine("輸入大於5的單字，不得有數字，格式有誤! 請重新輸入");
                return;

            }
            else if (string.IsNullOrWhiteSpace(input))   //檢查是否為空字串或空白鍵組成
            {
                Console.WriteLine("輸入大於5的單字，不得輸入空值或只輸有空格! 請重新輸入");
                return;
            }
            else if (input.Length >= 5)
            {
                Console.WriteLine(input.Substring(0, 3));

            }
            Console.ReadKey();

            //6、輸入一段字，輸出把輸入的一段字裡面的我，改成小明，如輸入我在唱歌，輸出小明在唱歌。Replace()
            Console.Write("請輸入裡面要有「我」的一段文字:");
            string input = Console.ReadLine();
            Console.WriteLine(input.Replace("我", "小明"));
            Console.ReadKey();

            //7、輸入一串字，顯示輸入幾個字。Length
            Console.Write("請輸入一串字:");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input) || !Regex.IsMatch(input, @"^[a-zA-Z\u4e00-\u9fa5\p{P}0-9]+$"))
            {
                Console.WriteLine("格式有誤，請重新輸入!");
            }
            else
            {
                Console.WriteLine(input.Length);
            }
            Console.ReadKey();

            //補充1、連續輸入10組字，若沒輸入過，就顯示沒出現過，若輸入過，就顯示輸入過。
            string[] word = new string[10];    //可以改寫成:HashSet<string> word = new HashSet<string>();

            string input;
            Console.WriteLine("請輸入10組字(不能是數字):");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"請輸入第 {i + 1} 組字: ");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input) || !Regex.IsMatch(input, @"^[a-zA-Z\u4e00-\u9fa5]+$"))
                {
                    Console.WriteLine("格式有誤，請重新輸入...");
                    i--;
                }
                else if (word.Contains(input))
                {
                    Console.WriteLine("已有輸入過!請重新輸入...");
                    i--;
                }
                else
                {
                    word[i] = input;
                    Console.WriteLine("沒有出現過!");
                }
            }

            Console.ReadKey();


            //補充2、用字母大小寫來模擬波浪舞的動作後輸出，比如輸入FiFa，輸出  Fifa >fIfa >fiFa >fifA
            string input;
            Console.Write("請輸入一個全部為小寫的英文單字:");
            input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input) || !Regex.IsMatch(input, @"^[a-z]+$"))
            {
                Console.WriteLine("格式輸入錯誤，請重新執行程式");
                return;

            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {

                    char get = input[i];
                    get = char.ToUpper(get);
                    Console.WriteLine(input.Replace(input[i], get));

                }

            }

            Console.ReadKey();

            //補充3、輸入時間，顯示幾時幾分，例如輸入11: 30，輸出11點30分。
            Console.Write("輸入時間:");
            string input = Console.ReadLine();
            string[] time = input.Split(':');
            Console.WriteLine($"{time[0]}點{time[1]}分");
            Console.ReadKey();

            //補充4、輸入的字，轉成HTML，例如輸入Justin,Amy,David 輸出
            //<ul>
            //    < li > Justin<li>
            //    < li > Amy<li>
            //    < li > David<li>
            //</ul >
            Console.Write("輸入中/英文字 : ");
            string input = Console.ReadLine();

            if (!Regex.IsMatch(input, @"^[a-zA-Z\d\u4e00-\u9fa5]+(?:,[a-zA-Z\d\u4e00-\u9fa5]+)*$"))
            {
                Console.WriteLine("格式輸入錯誤，請重新執行程式");
                return;
            }
            else
            {
                string[] content = input.Split(',');

                Console.WriteLine("<ul>");
                for (int i = 0; i < content.Length; i++)
                {

                    Console.WriteLine($"\t\t<li>{content[i]}</li>");

                }
                Console.WriteLine("</ul>");
            }

            Console.ReadKey();

            //補充5、輸入5處數字，用空白隔開，輸出結果。例如：輸入‘11 19 12 25 1 7 12，輸出總和是87
            int sum = 0;
            Console.Write("請輸入多組數字(數字間用空白隔開) : ");
            string input = Console.ReadLine();
            if (!Regex.IsMatch(input, @"^\d+(\s\d+)+$"))
            {
                Console.Write("輸入格式錯誤，請重新輸入");
                return;
            }
            else
            {

                string[] num = input.Split(' ');

                for (int i = 0; i < num.Length; i++)
                {
                    sum += Convert.ToInt32(num[i]);

                }
            }
            Console.WriteLine($"和 = {sum}");
            Console.ReadKey();


            //補充6、輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ
            Console.Write("輸入一串文字 : ");
            string word = Console.ReadLine();
            char[] input = word.ToCharArray();
            Array.Reverse(input);
            Console.WriteLine(input);
            Console.ReadKey();



            //Function作業

            //1.寫一個function 可以把一般對話框的文字轉成HTML。> 轉成 & gt; < 轉成 & lt; \r\n 轉成<br> | 轉成 & brvbar; 空白 轉成 &nbsp;
            Program Change = new Program();
            Console.WriteLine(Change.ChangeHtml());
            Console.ReadKey();



            //2.寫一個function，回傳輸入的值是否數字
            Program Num = new Program();
            Console.WriteLine(Num.CheckNum());
            Console.ReadKey();


            //3.寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式
            Program Mail = new Program();
            Console.Write("請輸入值，檢查是否為E-mail格式 :");
            string input = Console.ReadLine();
            Console.WriteLine(Mail.CheckMail(input));
            Console.ReadKey();


            //4.寫一個function，回傳輸入的值是否符合手機格式
            Program Phone = new Program();
            Console.Write("請輸入值，檢查是否為手機格式 :");
            string input = Console.ReadLine();
            Console.WriteLine(Phone.CheckPhone(input));
            Console.ReadKey();


            //5.寫一個function，回傳輸入的值是否符合身分證字號格式
            Program Id = new Program();
            Console.Write("請輸入身分證字號 :");
            Console.WriteLine(Id.CheckId(Console.ReadLine()));
            Console.ReadKey();


            //6.寫一個function，若輸入的文字大於Ｎ個，則超過的字不要，變成點點點
            Console.WriteLine(Simplify());
            Console.ReadKey();


            //7.寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式
            Console.Write("請輸入日期(格式為西元年/月/日) : ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime convertDate))
            {
                Console.WriteLine(ChangeDate(convertDate));
            }
            else
            {
                Console.WriteLine("輸入格式有誤，請重新執行程式!");
                return;
            }

            Console.ReadKey();


            //8.寫一個function，輸入一個日期，把該日期轉成民國XX年XX月XX日 星期X 格式
            Console.Write("請輸入日期(格式為西元年/月/日) : ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime convertDate))
            {
                Console.WriteLine(ChangeDay(convertDate));
            }
            else
            {
                Console.WriteLine("輸入格式有誤，請重新執行程式!");
                return;
            }

            Console.ReadKey();


            //9.寫一個function，回傳輸入的年是否閏年
            Console.Write("請輸入西元年：");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int year))
            {
                if (LeapYear(year))
                {
                    Console.WriteLine("是閏年");
                }
                else
                {
                    Console.WriteLine("不是閏年");
                }
            }
            else
            {
                Console.WriteLine("輸入格式錯誤，請重新輸入!");
            }

            Console.ReadKey();


            //10.寫一個function，輸入手機號碼，回傳今天運勢(手機運勢算法：用你的手機號碼的最後四位數除以80，再減去整數部分（只留小數），再乘以80，就會得到一個數，這就是代表吉凶的數字，印出結果。)
            Console.Write("請輸入手機號碼 : ");
            string tel = Console.ReadLine();

            if (!Regex.IsMatch(tel, @"^09\d{8}$"))
            {
                Console.WriteLine("輸入格式錯誤，請重新輸入!");
            }
            else
            {
                Console.WriteLine(TestLucky(tel).Trim());
            }
            Console.ReadKey();



        }

        //函式： 修飾符 結果回傳型別 方法名稱(參數型別 參數名稱) {你的方法內容}
        // >轉成 &gt; < 轉成 &lt; \r\n 轉成<br> | 轉成 &brvbar; 空白 轉成 &nbsp;
        public string ChangeHtml()
        {
            Console.Write("請輸入要轉換Html的文字 :");
            string a = Console.ReadLine();
            string output = a.Replace(">", "&gt;").Replace("<", "&lt;").Replace("\\r", "<br>").Replace("\\n", "<br>").Replace("|", "&brvbar;").Replace(" ", "&nbsp;");
            return output;
        }

        //回傳輸入的值是否數字
        public string CheckNum()
        {
            Console.Write("請輸入一個值 : ");
      
            if (!int.TryParse(Console.ReadLine(),out int input))
            {
                return "輸入的值不是數字";
                //Console.WriteLine("輸入的值不是數字");
            }
            else
            {
                return "輸入的值為數字";
                //Console.WriteLine("輸入的值為數字");
            }
        }

        //回傳輸入的值是否符合Ｅ－ｍａｉｌ格式
        public string CheckMail(string mail)
        {
            if (!Regex.IsMatch(mail,@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]{2,}$"))
            {
                return "不符合E-mail格式";
            }
            else
            {
                return "符合E-mail格式";
            }
        }

        //回傳輸入的值是否符合手機格式
        public string CheckPhone(string phone)
        {
            if (!Regex.IsMatch(phone, @"^09\d{8}$"))
            {
                return "不符合手機格式";
            }
            else
            {
                
                return "符合手機格式";
            }
        }

        //回傳輸入的值是否符合身分證字號格式
        public  bool CheckId(string id)
        {
            return Regex.IsMatch(id, @"^[A-Z][12]\d{8}$");
        } 
        
        //若輸入的文字大於Ｎ個，則超過的字不要，變成點點點
        public static string Simplify()
        {
            Console.Write("請輸入文字 ：");
            string text = Console.ReadLine();
            Console.Write("輸入字數上限N = ");

            if (!int.TryParse(Console.ReadLine(), out int n) || n >= text.Length || n <= 0 || string.IsNullOrWhiteSpace(text))
            {
                return "輸入格式有誤，請重新執行程式";
            }
            else
            {
                string newText = text.Substring(0, n)+"...";
                return newText;
            }
       
        }

        //輸入一個日期，把該日期轉成民國年.月.日格式
        public static string ChangeDate(DateTime date)
        {
            int year = date.Year - 1911;
            return $"民國{year}年{date.Month}月{date.Day}日";
        }

        //輸入一個日期，把該日期轉成民國XX年XX月XX日 星期X 格式
        public static string ChangeDay(DateTime day)
        {
            int year = day.Year - 1911;
            string week = day.ToString("dd", new CultureInfo("zh-TW"));
            return $"民國{year}年{day.Month}月{day.Day}日({week})";
        }

        //回傳輸入的年是否閏年 
        //能被4整除且不能被100整除的年份是閏年
        //能被100整除但不能被400整除的年份不是閏年
        //能被400整除的年份是閏年
        public static bool LeapYear(int year)
        {
         
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
       
        }

        //用你的手機號碼的最後四位數除以80，再減去整數部分（只留小數），再乘以80，就會得到一個數，這就是代表吉凶的數字，印出結果。
        //原文網址：https://kknews.cc/astrology/p2x8ekp.html
        public static string TestLucky(string tel)
        {
            double get = Convert.ToDouble(tel.Substring(6));
            double newGet = (get / 80 - Math.Floor(get / 80)) * 80;
            int luckyNum = (int)Math.Round(newGet);
            //Console.Write($"幸運數字是{luckyNum}");
            string lines = @"0 有點特殊 大吉
            1 大展鴻圖．可獲成功 吉
            2 一盛一衰．勞而無功 凶
            3 蒸蒸日上．百事順遂 吉
            4 坎坷前途．苦難折磨 凶
            5 生意欣榮．名利雙收 吉
            6 天降幸運．可成大功 吉
            7 和氣致祥．必獲成功 吉
            8 貫徹志望．成功可期 吉
            9 獨營無力．財利無望 凶
            10 空費心力．徒勞無功 凶
            11 穩健著實．必得人望 吉
            12 薄弱無力．謀事難成 凶
            13 天賦吉運．能得人望 吉
            14 是成是敗．惟*堅毅 凶
            15 大事成就．一定興隆 吉
            16 成就大業．名利雙收 吉
            17 有貴人助．可得成功 吉
            18 順利昌隆．百事亨通 吉
            19 內外不合．障礙重重 凶
            20 歷盡艱難．焦心憂勞 凶
            21 專心經營．善用智能 吉
            22 懷才不遇．事不如意 凶
            23 名顯四方．終成大業 吉
            24 須*自力．能奏大功 吉
            25 天時地利．再得人格 吉
            26 波瀾起伏．凌駕萬難 凶
            27 一盛一衰．可守成功 凶帶吉
            28 遇衰轉吉. 遇厄轉好 吉
            29 青雲直上．才略奏功 吉
            30 吉凶參半．得失相伴 凶
            31 名利雙收．大業成就 吉
            32 池中之龍．成功可望 吉
            33 智能慎始．必可昌隆 吉
            34 災難不絕．難望成功 凶
            35 中吉之數．進退保守 吉
            36 波瀾重疊．常陷窮困 凶
            37 逢凶化吉．風調雨順 吉
            38 名雖可得．利則難獲 凶帶吉
            39 光明坦途．指日可待 吉
            40 一盛一衰．浮沉不定 吉帶凶
            41 天賦吉運．前途無限 吉
            42 事業不專．十九不成 吉帶凶
            43 忍耐自重．轉凶為吉 吉帶凶
            44 事難遂願．貪功好進 凶
            45 綠葉發枝．一舉成名 吉
            46 坎坷不平．艱難重重 凶
            47 有貴人助．可成大業 吉
            48 名利俱全．繁榮富貴 吉
            49 遇吉則吉．遇凶則凶 凶
            50 吉凶互見．一成一敗 吉帶凶
            51 一盛一衰．浮沉不常 吉帶凶
            52 雨過天青．即獲成功 吉
            53 盛衰參半．先吉後凶 吉帶凶
            54 雖傾全力．難望成功 凶
            55 外觀隆昌．內隱禍患 吉帶凶
            56 事與願違．終難成功 凶
            57 努力經營．時來運轉 吉
            58 浮沉多端．始凶終吉 凶帶吉
            59 遇事猶疑．難望成事 凶
            60 心迷意亂．難定方針 凶
            61 雲遮半月．百隱風波 吉帶凶
            62 煩悶懊惱．事事難展 凶
            63 萬物化育．繁榮之象 吉
            64 十九不成．徒勞無功 凶
            65 吉運自來．能享盛名 吉
            66 內外不和．信用缺乏 凶
            67 事事如意．富貴自來 吉
            68 不失先機．可望成功 吉
            69 動搖不安．常陷逆境 凶
            70 慘澹經營．難免貧困 凶
            71 吉凶參半．惟賴勇氣 吉帶凶
            72 得而復失．難以安順 凶
            73 安樂自來．自然吉祥 吉
            74 如無智謀．難望成功 凶
            75 吉中帶凶．進不如守 吉帶凶
            76 此數大凶．破產之象 凶
            77 先苦後甘．不致失敗 吉帶凶
            78 有得有失．華而不實 吉帶凶
            79 前途無光．希望不大 凶
            ";
            string[] divination = lines.Split(new[] { "\r\n","\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach(string item in divination)
            {
                 
                if (item.Trim().StartsWith(Convert.ToString(luckyNum) +" "))
                {
                    return item;
                }
              
               
            }
            return "查無匹配結果!";


        }

    }
}
