using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs06_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C++에선 var 대신 auto가 있다.
            var a = 20;             // 자동으로 int가 됌
            Console.WriteLine("Type : {0}, Value : {1}", a.GetType(), a);

            var b = 3.141592f;      //f를 쓰지 않으면 double로 분류 됌
            Console.WriteLine("Type : {0}, Value : {1}", b.GetType(), b);

            var c = "Basic C#";
            Console.WriteLine("Type : {0}, Value : {1}", c.GetType(), c);

        }

    }
}
