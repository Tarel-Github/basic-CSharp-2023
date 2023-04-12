using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs26_delegate
{
    // 대리자 사용하겠다는 선언
    delegate int CalcDelegate(int a, int b);

    delegate int Compare(int a, int b);     // a, b중 뭐가 더 큰지(작은지) 비교하기 위한 대리자


    #region< 대리자 기본 >
    class Calc
    {
        public int Plus(int a, int b)
        { 
            return a + b; 
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }
    #endregion

    internal class Program
    {
        // 오름차순 비교
        static int AscendCompare(int a, int b)
        {
            if (a > b) return 1;
            else if (a == b) return -1;
            else return -1;
        }

        // 내림차순 비교
        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1;
            else if (a == b) return 0;
            else return -1;
        }

        static void BubbleSort(int[] DataSet, Compare comparer)
        {
            int i = 0, j = 0, temp = 0;
            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i+1); j++)
                {
                    if ((comparer(DataSet[j], DataSet[j+1])> 0 ) )   // 대리자 사용
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;          // Swap
                    }
                }
            }
        }

        static void BubbleSort2(int[] DataSet, bool isAscend)
        {
            int i = 0, j = 0, temp = 0;
            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (isAscend == true)
                    {
                        if (DataSet[j + 1] > 0)   // 대리자 사용
                        {
                            temp = DataSet[j + 1];
                            DataSet[j + 1] = DataSet[j];
                            DataSet[j] = temp;          // Swap
                        }
                    }
                    else
                    {
                        if (DataSet[j + 1] < 0)   // 대리자 사용
                        {
                            temp = DataSet[j + 1];
                            DataSet[j + 1] = DataSet[j];
                            DataSet[j] = temp;          // Swap
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            #region < 대리자 기본예 >
            // 일반적인 클래스 사용방식
            Calc normalCalc = new Calc();
            int x = 10 , y = 15 ;
            int res = normalCalc.Plus(x, y);
            Console.WriteLine(res);

            Console.WriteLine(normalCalc.Plus(x, y));

            res = Calc.Minus(x, y);

            // 대리자를 사용하는 방식
            x = 30; y = 20;
            Calc delCalc = new Calc();
            CalcDelegate Callback;

            Callback = new CalcDelegate(delCalc.Plus);
            int res2 = Callback(x, y);       
            Console.WriteLine(res2);

            Callback = new CalcDelegate(Calc.Minus);
            res2 = Callback(x, y);
            Console.WriteLine(res2);    // 10
            #endregion

            int[] origin = { 4, 7, 8, 2, 9, 1 };
            Console.WriteLine("오름차순 버블정렬");
            BubbleSort(origin, new Compare(AscendCompare));

            foreach (var item in origin)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            Console.WriteLine("내림차순 버블정렬");
            BubbleSort(origin, new Compare(DescendCompare));

            foreach(var item in origin)
            {
                Console.WriteLine("{0} ", item);
            }
            Console.WriteLine();


        }
    }
}
