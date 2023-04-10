using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs21_property
{
    class Boiler
    {
        public int temp;    // 멤버 변수
        public int Temp     // 프로퍼티(속성)
        {
            get { return temp; }
            set
            {
                if (value <= 0 || value >= 70)
                {
                    temp = 10;
                }
                temp = value;
            }
        }

        // 위의 get; set;과 비교 // 아래의 Get와 Set 메서드는 Java에서나 쓰고 C#에서는 잘 안씀
        public void SetTemp(int temp)
        {
            if ( temp <=  10 || temp >= 70)
            {
                Console.WriteLine("수온설정값이 너무 낮거나 높습니다. 10~70도 사이로 지정해주세요");
                return;
            }
            this.temp = temp;
        }

        public int GetTemp() { return this.temp;}
    }

    class Car
    {
        string name;
        string color;
        string fuelType;
        string tireType;
        int price;
        string carIdNumber;
        string carPlateNumber;
        int year;
        string fuel;

        public string Company { get; set; }

        private int door;
        public int Door {
            get { return door; } set {
                if (value != 2 || value != 4) { 
                    value = 4;
                }
                door = value; 
            } 
        }
        public string TireType { get; set; }



        public string Name { get; set; }    // 필터링이 필요 없으면  멤버변수 없이 프로 퍼티로 대체
        public string Color { get; set; }


        // 들어오는 데이터를 필터링 할 때는 private멤버 변수와 public 프로퍼티를 둘 다 사용
        public int Year {
            get { return year; }        // 이게 너무 길어서 우측처럼 람다식을 사용 get => year; 
            set {
                if (value <= 1990 || value >= 2023)
                {
                    value = 2023;
                }
                year = value;
            }
        }
        public string FuelType { get => fuelType; 
            set { 
                if(value != "휘발유" || value != "경우")
                {
                    value = "휘발유";
                }
                fuelType = FuelType;
            } 
        }


    }

    interface IProduct
    {
        string ProductName { get; set; }
        void Produce();
    }

    class MyProduct : IProduct
    {
        public string ProductName { 
            get { return ProductName; }
            set { ProductName = value; } 
        }

        public void Produce()
        {
            Console.WriteLine("{0}을 생산합니다", ProductName);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler();
            /*kitturami.temp = 60;

            //...
            kitturami.temp = 300000;
            kitturami.temp = -120;*/
            kitturami.SetTemp(50);
            Console.WriteLine(kitturami.GetTemp());

            Boiler navien = new Boiler();
            navien.Temp = 5000;
            Console.WriteLine(navien.Temp);

            Car ionic = new Car();
            ionic.Name = "아이오닉";
            Console.WriteLine(ionic.Name);

            // 생성할 때 프로퍼티로 초기화
            Car genesis = new Car()
            {
                Name = "제네시스",
                FuelType = "휘발유",
                Color = "휜색",
                Door = 4,
                TireType = "광폭 타이어",
                Year = 0,

            };

            Console.WriteLine("자동차 제조회사는 {0}", genesis.Company);
            Console.WriteLine("자동차 제조회사는 {0}년", genesis.Year);


        }
    }
}
