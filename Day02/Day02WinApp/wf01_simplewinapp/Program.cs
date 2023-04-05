using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf01_simplewinapp
{
    class Program : System.Windows.Forms.Form // Form 클래스 상속, 우측 아웃라이너의 참조에서 Windows.Forms를 추가해주어야 한다.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First WinApp");
            System.Windows.Forms.Application.Run(new Program());
        }
    }
}
