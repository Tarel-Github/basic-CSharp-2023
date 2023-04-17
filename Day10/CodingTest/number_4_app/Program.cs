using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_4_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColorDict rainbow = new ColorDict();
            rainbow.Name = "무지개";
            rainbow.dict.Add("빨간색", "Red");
            rainbow.dict.Add("주황색", "Orange");
            rainbow.dict.Add("노란색", "Yellow");
            rainbow.dict.Add("초록색", "Green");
            rainbow.dict.Add("파란색", "Blue");
            rainbow.dict.Add("남색", "Nam");
            rainbow.dict.Add("보라색", "Purple");

            rainbow.PrintAll();
            rainbow.CheckColor("Purple");
        }
    }

    internal class ColorDict
    {
        public Dictionary<string, string> dict = new Dictionary<string, string>();

        public string Name { get; internal set; }


        internal void PrintAll()
        {
            Console.Write("{0} 색은 ", Name);
            foreach (var kvp in dict)
            {
                Console.Write(kvp.Key + ", ");
            }
            Console.WriteLine("입니다.");
            Console.WriteLine();
        }
        internal void CheckColor(string target)
        {
            Console.WriteLine("Key와 Value 확인");
            foreach (var kvp in dict)
            {
                if (kvp.Value == target)
                {
                    Console.WriteLine(target + "은 " + kvp.Key + " 입니다.");
                    break;
                }
            }
        }
    }
}
