using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs10_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 비트연산        비트연산자중 << 는 사실상 2배, >> 는 나누기 2다. 
            int firstval = 15;      // 이진수 기준 1111
            int secondval = firstval << 1;  // = 11110 (2진수 기준 -> 16 + 8 + 4 + 2 = 30)
            Console.WriteLine(secondval);

            // 1111 & 1101 => 1101      => 둘 다 1인 것만 1
            // 1010 | 0101 => 1111      => 둘 중 하나라도 1이면 1
            firstval = 15;
            secondval = 13;
            Console.WriteLine(firstval & secondval);
            firstval = 10;
            secondval = 5;
            Console.WriteLine(firstval | secondval);
            Console.WriteLine(firstval ^ secondval);        // XOR
            Console.WriteLine(~secondval); // 보수
            Console.WriteLine(~firstval);
            // 실무에서는 많이 안씀, 그나마 시프트 연산은 좀 쓰이는 편, 비트 연산은 게임에서 가끔 쓰임

            // Null 병합 연산자
            int? checkval = null;
            Console.WriteLine(checkval == null? 0: checkval);   // 3항 연산자
            Console.WriteLine(checkval ?? 0);                   // null 병합연산자는 3항 연산자를 더 축소

            checkval = 25;
            Console.WriteLine(checkval.HasValue? checkval.Value:0);
            Console.WriteLine(checkval ?? 0);
        }
    }
}
