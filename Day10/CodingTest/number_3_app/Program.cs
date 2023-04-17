using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_3_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HybridCar ioniq = new HybridCar();
            ioniq.Name = "아이오닉";
            ioniq.Maker = "현대자동차";
            ioniq.Color = "White";
            ioniq.YearModel = 2018;
            ioniq.MaxSpeed = 220;
            ioniq.UniqueNumber = "54라 3346";

            ioniq.Start();
            ioniq.Accelerate();
            ioniq.Recharge();
            ioniq.TurnRight();
            ioniq.Break();
        }
    }

    internal class HybridCar
    {
        public string Name { get; internal set; }
        public string Maker { get; internal set; }
        public string Color { get; internal set; }
        public int YearModel { get; internal set; }
        public int MaxSpeed { get; internal set; }
        public string UniqueNumber { get; internal set; }

        internal void Start()
        {
            Console.WriteLine("{0}의 시동을 겁니다.", Name);
        }
        internal void Accelerate()
        {
            Console.WriteLine("최대시속 {0}km/h로 가속합니다.", MaxSpeed);
        }
        internal void Recharge()
        {
            Console.WriteLine("달리면서 배터리를 충전합니다.");
        }
        internal void TurnRight()
        {
            Console.WriteLine("{0}를 우회전 합니다.", Name);
        }
        internal void Break()
        {
            Console.WriteLine("{0}의 브레이크를 밟습니다.", Name);
        }

    }
}
