using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_1_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler { Brand = "귀뚜라미", Voltage = 220, Temperature = 45 };
            kitturami.PrintAll();
        }
    }

    internal class Boiler
    {
        public string Brand { get; set;}
        public byte Voltage { get; set;}
        public int Temperature { get; set;}

        internal void PrintAll()
        {
            Console.WriteLine("이 보일러의 브렌드는 {0}, 전압은 {1}, 온도는 {2}", Brand, Voltage, Temperature);
        }
    }
}
