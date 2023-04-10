using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs20_abstractClass
{
    abstract class AbstractParent                           // abstract(추상) 키워드를 써야지 안에 추상 메소드를 사용할 수 있음
    {
        protected void MethodA()
        {
            Console.WriteLine("AbstractParent.MethodA()");
        }

        public void MethodB()   //  클래스랑 동일!
        {
            Console.WriteLine("AbstractParent.MethodB()");
        }

        public abstract void MethodC(); // 인터페이스랑 동일!       abstract 키워드 사용!
    }

    class Child : AbstractParent        // 추상클래스를 상속받아서
    {
        public override void MethodC()      // 추상메소드를 재정의!  (사실은 구현!)
        {
            Console.WriteLine("Child.MethodC() - 추상클래스 구현!");
        }
    }
    abstract class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("포유를 시작한다");
        }

        public abstract void Sound();
    }

    class Dogs : Mammal
    {
        public override void Sound()
        {
            Console.WriteLine("뭠뭐!!");
        }
    }
    class Cats : Mammal
    {
        public override void Sound()
        {
            Console.WriteLine("모ㅑ아아아아아아아악!!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractParent parent = new Child(); 
            //parent.MethodA(); // 이건 protected라서 못씀!, protect는 자기자신과 자식 클래스 내에서만!
            parent.MethodC();
            parent.MethodB();
        }
    }
}
