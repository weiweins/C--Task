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
            Console.WriteLine("輸入x和y:");
            Console.Write("輸入x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("輸入y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("x=");
            Console.WriteLine(x);
            Console.Write("y=");
            Console.WriteLine(y);
            Console.WriteLine("(x+y)/2=");
            Console.Write((x + y) / 2);
            //Console.ReadKey();
        }
    }
}
