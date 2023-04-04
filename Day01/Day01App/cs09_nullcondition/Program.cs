using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs09_nullcondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foo myfoo = new Foo();      // 객체(인스턴스) 생성
            // myfoo.member = 30;

            /*int? bar;
            if (myfoo != null) 
            {
                bar = myfoo.member;
            }
            else
            {
                bar = null;
            }*/
            int? bar = myfoo?.member;   // 위의 주석 9줄을 축약한 것, myfoo가 null이 아니면 맴버변수 bar에 그 값을 넣어라
        }
    }
    class Foo
    {
        public int member;
    }

}
