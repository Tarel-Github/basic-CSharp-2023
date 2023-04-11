using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs24_generic
{
    // 일반화는 가장 많이 쓰이는 중요한 문법으로써
    // 비슷비슷해보이는 함수를 하나로 통일해주는 중요한 문법이다.



  
    // 아래 클래스와 그 아래 주석처리된 클래스를 보자
    // 위 클래스가 아래클래스를 일반화 한 클래스다.
    /*class MyArray<T>
    {
        T[] array;
    }
*/
    /*class MyArray
    {
        int[] array;
    }*/

    class MyArray<T> where T : class // 일반화 클래스 // where T : class 사용할 타입은 
    {
        T[] array;
    }

    internal class Program
    {

        #region<일반화 메서드>
        // 아래 주석 처리된 수많은 CopyArray 함수는 파라미터 타입만 다를 뿐 전부 다 같은 내용이다.
        // 이런 경우, 하나로 퉁치기 위해 만든 것이 바로 일반화며 본 주석의 바로 밑에 있다.
        static void CopyArray<T>(T[] source, T[] target)
        {
            for (var i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
        #endregion

        /*

                static void CopyArray(int[] source, int[] target)
                {
                    for (var i = 0; i < source.Length; i++)
                    {
                        target[i] = source[i];
                    }
                }

                static void CopyArray(long[] source, long[] target)
                {
                    for (var i = 0; i < source.Length; i++)
                    {
                        target[i] = source[i];
                    }
                }

                static void CopyArray(float[] source, float[] target)
                {
                    for (var i = 0; i < source.Length; i++)
                    {
                        target[i] = source[i];
                    }
                }

                static void CopyArray(double[] source, double[] target)
                {
                    for (var i = 0; i < source.Length; i++)
                    {
                        target[i] = source[i];
                    }
                }

                static void CopyArray(string[] source, string[] target)
                {
                    for (var i = 0; i < source.Length; i++)
                    {
                        target[i] = source[i];
                    }
                }*/

        static void Main(string[] args)
        {
            #region<일반화시키기>
            int[] source = { 2, 4, 6, 8, 10 };
            int[] target = new int[source.Length];

            CopyArray(source, target);
            foreach(var item in target)
            {
                Console.WriteLine(item);
            }
            long[] source2 = { 2100000, 2300000, 3300000, 5600000, 7800000 };
            long[] target2 = new long[source2.Length];

            CopyArray<long>(source2, target2);
            foreach (var item in target2)
            {
                Console.WriteLine(item);
            }

            float[] source3 = { 3.14f, 3.15f, 3.16f, 3.17f, 3.18f, 3.19f };
            float[] target3 = new float[source3.Length];

            CopyArray<float>(source3, target3);
            foreach(var item in target3)
            {
                Console.WriteLine(item);
            }
            #endregion


            // 일반화 컬렉션
            List<int> list = new List<int>();
            for ( var i = 10; i > 0; i--)
            {
                list.Add(i);
            }

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveAt(3);   // 7 삭제
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
            // 아래와 같은 일반화 컬렉션을 자주 볼 수 있다.
            List<MyArray<string>> myStringArray = new List<MyArray<string>>();

            // 일반화 스텍
            Stack<float> stFloats =new Stack<float>();
            stFloats.Push(3.15f);
            stFloats.Push(4.28f);
            stFloats.Push(7.25f);

            //foreach(var item in stFloats)
            //{
            //    Console.WriteLine(item);
            //}

            while (stFloats.Count > 0)
            {
                Console.WriteLine(stFloats.Pop());
            }

            // 일반화 Queue
            Queue<string> qStrings = new Queue<string>();
            qStrings.Enqueue("Hello");
            qStrings.Enqueue("World");
            qStrings.Enqueue("My");
            qStrings.Enqueue("C#");

            while (qStrings.Count > 0)
            {
                Console.WriteLine(qStrings.Dequeue());
            }

            // 일반화 딕셔너리, 일반화 딕셔너리도 많이 사용된다.
            Dictionary<string, int> dicNumbers = new Dictionary<string, int>();
            dicNumbers["하나"] = 1;
            dicNumbers["둘"] = 2;
            dicNumbers["셋"] = 3;
            dicNumbers["넷"] = 4;

            Console.WriteLine(dicNumbers["셋"]);     // 3 이 출력


        }
    }
}
