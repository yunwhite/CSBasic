using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //273;
            var name = "윤" + "희" + "나";
            Console.Write("Hello C#");
            int add = 2;
            int Alpha;
            //이게 주석
            /*
             * 여러 줄 주석
             */

            Console.WriteLine("이건 행 바꿔");
            Console.Write("이건 ");
            Console.Write("행을 안 바꿔");

            Console.Write(52);
            Console.WriteLine('A');
            Console.WriteLine("A");

            Console.WriteLine("미림\t과학고");
            Console.WriteLine("미림\n과학고");
            Console.WriteLine("\"\"\"");
            Console.WriteLine("문" + "자" + "열");

            Console.WriteLine("예외"[100]);
            Console.WriteLine(true);

        }
    }
}
