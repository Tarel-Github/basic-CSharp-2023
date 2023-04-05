using System;

namespace cs12_methods
{
    class Calculator
    {
        public static int Plus(int a, int b) { // static은 최초 실행 때 메모리에 바로 올라가기 때문에 클래스 객체를 만들 필요가 없다.
            return a + b; 
        }
        public int Minus(int a, int b) {
            return a - b;
        }
    }
    internal class Program
    {
        /// <summary>
        /// 실행시 메모리에 최초 올라가야 하기 때문에 static이 되어야 하고
        /// 메서드 이름이 Main 이면 실행될 때 알아서 제일 처음에 시작된다.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region< static 메서드>

            int result = Calculator.Plus(1, 2); // 위의 Calculator 클래스에서, static이 없으면 new Calculator().Plus(1,2) 형태로 사용해야 함, new는 객체를 만드는 명령
            // Calculator.Minus(1, 2);          // Minus에는 static이 없다! 때문에 new로 객체 생성을 해줘야 한다.
            result = new Calculator().Minus(3, 2);

            Console.WriteLine(result);
            #endregion
            #region< Call by reference vs Call by value 비교>
            int x = 10; int y = 3;
            Swap(ref x, ref y);     // x, y 가 가지고 있는 주소를 전달하라는 말, 만약 Swap에서나 여기서나 ref 키워드가 없으면 제대로 스왑이 되지 않는다.
                                    // ref는 콜바이레퍼런스로 C#에선 포인터 개념이 빠진대신 그 기능을 ref가 대신해준다.
                                    // Swap가 return이 없는 void 형식이라는걸 유념할 것

            Console.WriteLine("x = {0}, y = {1}", x, y);

            Console.WriteLine(GetNumber());
            #endregion
            #region< out 매개변수>
            int divid = 30;
            int divor = 4;

            int rem = 0;

            Divide(divid, divor, out result, out rem);
            Console.WriteLine("나누기 값 {0}, 나머지 {1}", result, rem);

            (result, rem) = Divide(20, 6);
            Console.WriteLine("나누기 값 {0}, 나머지 {1}", result, rem);

            #endregion

            #region<가변길이 매개변수>

            int resSum = Sum(1, 3, 5, 7, 9);    //  params int[] args를 사용해서 가변길이 파라미터를 받음
            Console.WriteLine(resSum);

            #endregion

        }

        /*        static int Divide(int x, int y)
                {
                    return x / y;
                }
                static int Reminder(int x, int y)
                {
                    return x % y;
                }*/
        static void Divide(int x, int y, out int val, out int rem)  // out을 사용한 리턴?
        {
            val = x / y;
            rem = x % y;
        }
        static (int result, int rem) Divide(int x, int y)       // 위의 Divdie 함수와 기능이 같음
        {
            return (x / y,(int)( x % y));      // C# 7.0 부터 가져온 기능, 튜플을 사용한 함수
        }

        public static void Swap(ref int a, ref int b)   // 메인과 같은 위치에 있는 클래스는 static을 써야한다. 왜냐하면  new()를 사용했다간 Program 클래스 본인이 본인을 생성하는 이상한 사태가 발생하기 때문
        {
            int temp = 0;
            temp = a;       
            a = b;
            b = temp;
        }
        static int val = 100;

        public static ref int GetNumber()
        {
            return ref val;
        }

        public static int Sum(params int[] args)        // python 가변길이 매개변수랑 비교
        {
            int sum = 0;
            foreach (var item in args)
            {
                sum += item;
            }
            return sum;
        }
    }
}
