using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs25_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };
            try
            {
                for (var i = 0; i < 5; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch (Exception ex)    // 에러메시지에는 Exception 말고도 IndexOutOfRangeException 등 다양하게 있으나 결국 Exception을 상속받은 것에 불과
            {                       // 모르겠다 싶으면 그냥 Exception을 사용하면 된다.
                Console.WriteLine(ex.ToString());       // 오류 내용을 전부 보여줌
                Console.WriteLine("--------------------------------");
                Console.WriteLine(ex.Message);          // 오류 메시지만 보여줌, 훨씬 짧음
            }
            finally     // 오류메시지 등장 여부와 상관없이
            {
                // 예외가 발생하더라도 무조건 처리해야 되는 로직
                // file 객체 close
                // db 연결 close
                // 네트워크 소켓 close
                Console.WriteLine("파이널 구문");
            }
            DIvideTest(array[2], array[0]);
            Console.WriteLine("프로그램 종료!!");
        }

        private static void DIvideTest(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
