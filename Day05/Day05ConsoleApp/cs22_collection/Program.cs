using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs22_collection
{

    class MyList
    {
        int[] array;

        public MyList() 
        {
            array = new int[3];
        }

        public int Length
        {
            get { return array.Length; }
            set { }
        }

        // 인덱서
        public int this[int index] {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine("MyList Resized{0}", array.Length);
                }
                array[index] = value;   // 값할당
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
            //array[5] = 6;

            Console.WriteLine(array);        // array를 출력하라고 하면 System.Int32[] 가 출력 됌
            //Console.WriteLine(array[5]);   // IndexOutOfRange() 에러

            char[] oldString = new char[5];     // 먼 옛날 방식, 문자열 길이를 지정해주어야 한다는 문제가 있음, C에서만 사용
            string curString = "";              // 문자열 길이 제한이 없음

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);    // 위 배열과 차이점으로, 길이에 맞춰야하는 위의 경우와 다르게, 이 경우는 원소 입력에 제한이 없다.

            // 여러가지 메서드
            ArrayList list2 = new ArrayList();
            list2.Add(8);
            list2.Add(4);
            list2.Add(15);
            list2.Add(10);
            list2.Add(7);
            list2.Add(2);
            
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            // list에서 데이터 삭제
            Console.WriteLine("10 삭제 후");
            list2.Remove(10);
            Console.WriteLine("3번째 데이터 삭제");
            list2.RemoveAt(3);

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("0번째 위치 7 추가");
            list2.Insert(0, 7);     // 0번째 위치에 7을 입력
            foreach(var item in list2)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("정렬");
            list2.Sort();
            foreach(var item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("정렬");
            list2.Sort();
            foreach(var item in list2)
            {
                Console.WriteLine(item);
            }
            
            // ArrayList.Add(), .Insert(x, val), .Remove(val), .RemoveAt(x), .Sort(), .Reverse()
            MyList myList = new MyList();
            for (int i = 1; i <= 5; i++)
            {
                myList[i] = i * 5;      // 5, 10, 15, 20, 25
            }

            for (int i = 0; i < myList.Length; i++) 
            {
                Console.WriteLine(myList[i]);
            }

        }
    }
}
