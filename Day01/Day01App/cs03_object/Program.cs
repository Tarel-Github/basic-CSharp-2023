using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs03_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // object 형식
            /*int idata = 1024;
            Console.WriteLine(idata);
            Console.WriteLine(idata.GetType());
*/
            long idata = 1024;
            Console.WriteLine(idata);
            Console.WriteLine(idata.GetType());

            object iobj = (object)idata;    // 박싱 : 데이터타입값을 object로 담아라.
            Console.WriteLine(iobj);
            Console.WriteLine(iobj.GetType());
            
            long udata = (long)iobj;        // 언박싱 : object를 원래 데이터 타입으로 바꿔라
            Console.WriteLine(udata);
            Console.WriteLine(udata.GetType());

            double ddata = 3.141592;
            object pobj = (object)ddata;
            double pdata = (double)pobj;

            Console.WriteLine(pobj);
            Console.WriteLine(pobj.GetType()); // 오브젝트 타입이라도 타입은 double로 나오는 것을 알 수 있다.
            Console.WriteLine(pdata);  
            Console.WriteLine(pdata.GetType());

            // short int long 형변환
            short sdata = 32000;
            int indata = sdata;             // 작은 타입, 작은 숫자를 큰 타입으로 변환
            Console.WriteLine(indata);

            long lndata =long.MaxValue;
            Console.WriteLine(lndata);
            indata = (int)lndata;           // 큰 숫자를 int로 바꿔서 작은 타입에 할당, 오버플로우 발생
            Console.WriteLine(indata);            // -1이 나옴

            // float double간 형변환
            float fval = 3.141592f;
            Console.WriteLine("fval = " + fval);
            double dval = (double) fval;
            Console.WriteLine("dval = " + dval);        // 소숫점이 훨씬 길어진다
            Console.WriteLine(fval == dval);            // True가 나온다??
            Console.WriteLine(dval == 3.141592);        // False가 나온다.

            // 정말 중요!! 실무에서 가장 많이 쓰는 것 중 하나
            int numival = 1024;
            string strival = numival.ToString();
            Console.WriteLine(strival);         // 이건 문자
            Console.WriteLine(numival);         // 이건 숫자
            //Console.WriteLine(numival == strival);
            Console.WriteLine(strival.GetType());

            double numdval = 3.14159265358979;
            string strdval = numdval.ToString();
            Console.WriteLine(strdval);

            // 반대로 문자열을 숫자로
            // 문자열내에 숫자가 아닌 특수문자나 정수인데 . 이 있거나 16진수를 썼다거나 하면 변환이 되지 않는다.
            string originstr = "34567890";              // 이 문자를 수로 바꾸는건 상관없다. 그러나 이 숫자들 사이에 . 하나만 찍어도 바로 에러가 발생한다.
            int convval = Convert.ToInt32(originstr);
            Console.WriteLine(convval);

            // 이번엔 소수를 소수로 변환
            originstr = "1.2345";
            float convfloat = float.Parse(originstr);
            Console.WriteLine(convfloat);

            // 예외가 발생하지 않도록 형변환 하는 방법
            originstr = "123.0f";       // 이것도 소수로 변환이 되지 않는다.
            float ffval;
            float.TryParse(originstr, out ffval);   // TryParse는 형변환을 시도하되, 변환이 불가능하면 0을 출력한다.
            Console.WriteLine(ffval);
            // Convert는 변환 실패시 예외가 발생한다. 그러나 TryParse는 발생하지 않으므로 이걸 쓰는게 좋다.

            const double pi = 3.14159265358979; // const가 넣었으므로 상수, 상수는 바꿀 수 없음
            Console.WriteLine(pi);  
                
        }
    }
}
