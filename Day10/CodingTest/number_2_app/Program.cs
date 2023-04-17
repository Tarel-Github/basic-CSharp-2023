using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_2_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler { Brand = "귀뚜라미", Voltage = 220, Temperature = 200 };
            kitturami.PrintAll();
        }
    }

    internal class Boiler
    {
        private byte voltage;
        private int temperature;
        public string Brand { get; set; }
        public byte Voltage {
            get { return this.voltage; }
            set 
            {
                this.voltage = value;
                if (value >= 220) this.voltage = 220;
                else if (value <= 110) this.voltage = 110;
                else this.voltage = 110;
            }
        }

        public int Temperature {
            get { return this.temperature; }
            set
            {
                this.temperature = value;
                if (this.temperature >= 70) this.temperature = 70; 
                else if (this.temperature <= 5) this.temperature = 5;
            }      
        }

        internal void PrintAll()
        {
            Console.WriteLine("이 보일러의 브렌드는 {0}, \n사용 전압은 {1}V, \n설정 온도는 {2}도", Brand, Voltage, Temperature);
        }
    }
}
