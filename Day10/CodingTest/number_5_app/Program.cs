using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_5_app
{
    #region <인터페이스와 클래스>
    interface IAnimal
    {
        string Name { get; set; }
        int Age { get; set; }

        void Eat();
        void Sleep();
        void Sound();
    }

    class Dog : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("{0}({1}살)이 밥을 먹습니다.", Name, Age);
        }

        public void Sleep()
        {
            Console.WriteLine("{0}({1}살)이 자고 있습니다.", Name, Age);
        }

        public void Sound()
        {
            Console.WriteLine("{0}({1}살)이 짖습니다.", Name, Age);
            Console.WriteLine("왈!왈!왈!왈!왈!왈!왈!왈!왈!왈!왈!왈!왈!왈!왈!왈!왈!왈!왈!왈!왈!");
        }
    }

    class Cat : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("{0}({1}살)이 밥을 먹습니다.", Name, Age);
        }

        public void Sleep()
        {
            Console.WriteLine("{0}({1}살)이 자고 있습니다.", Name, Age);
        }

        public void Sound()
        {
            Console.WriteLine("{0}({1}살)이 웁니다.", Name, Age);
            Console.WriteLine("ㄴㅁ냐ㅑ냐야먀냐냔야냐먀먐아ㅑ아아아아아야야ㅁ냐야ㅏㅇ앙아오ㅗ오오옹!!!!");
        }
    }

    class Horse : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("{0}({1}살)이 당근을 씹어 먹습니다.", Name, Age);
        }

        public void Sleep()
        {
            Console.WriteLine("{0}({1}살)이 자고 있습니다.", Name, Age);
        }

        public void Sound()
        {
            Console.WriteLine("{0}({1}살)이 웁니다.", Name, Age);
            Console.WriteLine("이히히이힣ㅎ이힣이히히힝히히히힣힝!!!");
        }
    }

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Horse horse = new Horse();

            dog.Name = "멈뭐";
            dog.Age = 5;
            dog.Eat();
            dog.Sleep();
            dog.Sound();

            cat.Name = "나비";
            cat.Age = 3;
            cat.Eat();
            cat.Sleep();
            cat.Sound();

            horse.Name = "경마";
            horse.Age = 14;
            horse.Eat();
            horse.Sleep();
            horse.Sound();

        }
    }
}
