using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs17_inheritance
{
    // 상속해줄 부모 클래스
    class Parent
    {
        public string Name;

        public Parent(string Name)
        {
            this.Name = Name;
            Console.WriteLine("{0} for Parent 생성자", Name);
        }

        public void ParentMethod()
        {
            Console.WriteLine("{0} for Parent 메서드", Name);
        }

    }
    // 상속받을 자식 클래스
    class Child : Parent
    {
        public Child(string Name): base(Name) {
            Console.WriteLine("{0} for Child 생성자 ", Name);      // 부모생성자 생성 후 자식 생성자 생성
        }
        public void ChildMethod()
        {
            Console.WriteLine("{0} fro Child 메서드", Name );
        }
    }

    // 클래스간 형변환 DB처리, DI
    class Mammal    // 포유류
    {
        public void Nurse() // 기르다
        { 
            Console.WriteLine("포유류 기르다.");
        }
    }

    class Dogs : Mammal 
    { 
        public void Bark()
        {
            Console.WriteLine("멍멍!!");
        }    
    }

    class Cats : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("야옹!!!!!");
        }
    }

    class Elephant : Mammal
    {
        public void Poo()
        {
            Console.WriteLine("뿌우우~");
        }
    }

    class ZooKeeper
    {

        public void Wash(Mammal mammal)
        {
            if (mammal is Elephant)
            {
                var animal = mammal as Elephant;
                Console.WriteLine("코끼리를 씻깁니다.");
                animal.Poo();
            }
            else if (mammal is Dogs)
            {
                var animal = mammal as Dogs;
                Console.WriteLine("강아지를 씻깁니다.");
                animal.Bark();
            }
            else if (mammal is Cats)
            {
                var animal = mammal as Cats;
                Console.WriteLine("고양이 씻기기");
                animal.Meow();
                animal.Meow();
                animal.Meow();
                animal.Meow();
                animal.Meow();
                animal.Meow();
                animal.Meow();

            }
        }

 /*       public void Wash(Dogs dog)
        {

        }

        public void Wash(Cats cat) 
        { 
            
        }

        public void Wash(Elephant el)
        {

        }*/
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region <기본상속개념>
            Parent p = new Parent("p");
            p.ParentMethod();

            Console.WriteLine("자식 클래스 생성");

            Child c= new Child("c");


            c.ParentMethod();       // 자식은 부모 자식 
            c.ChildMethod();
            #endregion

            #region<클래스간 형식변환>
            Mammal mammal = new Dogs(); // 부모는 자식을 정의할 수 있지만
            //Dogs dogs = new Mammal();   // 자식이 부모를 정의할 순 없음
            //mammal.Bark();  // 부모클래스에는 Bark()가 없다. 형변환을 해주어야 함
            if (mammal is Dogs)
            {
                Dogs midDog = mammal as Dogs;     // 옛날 방식
                midDog.Bark();
            }



            Dogs dog2 = new Dogs();
            Cats cat2 = new Cats();
            Elephant el2 = new Elephant();


            ZooKeeper keeper = new ZooKeeper();
            keeper.Wash(dog2);
            keeper.Wash(cat2);
            keeper.Wash(el2);





            #endregion

        }
    }
}
