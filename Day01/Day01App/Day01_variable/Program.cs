using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01_variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte bdata = byte.MaxValue;
            Console.WriteLine(bdata);

            bdata = byte.MinValue;
            Console.WriteLine(bdata);

            long ldata = long.MaxValue;
            Console.WriteLine(ldata);
            long rdata = long.MinValue;
            Console.WriteLine(rdata);

            ldata--;
            Console.WriteLine(ldata);

            int binVal = 0b1111111;         // 2진수, 2진수 접두사는 0b
            Console.WriteLine(binVal);

            int hexVal = 0xFF;              // 16진수, 접두사는 0x
            Console.WriteLine(hexVal);

            float fdata = float.MaxValue;
            Console.WriteLine(fdata);
            fdata = float.MinValue;
            Console.WriteLine(fdata);

            double ddata = double.MaxValue;
            Console.WriteLine(ddata);
        }
    }
}
