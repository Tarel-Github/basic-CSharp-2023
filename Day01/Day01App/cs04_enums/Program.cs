using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs04_enums
{
    internal class Program
    {
        enum DialogResult{
            YES,
            NO,
            CANCEL,
            CONFIRM,
            OK
        }
        enum HomeTown{
            SEOUL,
            DAEJEON,
            DAEGU,
            BUSAN,
            JEJU
        }

        static void Main(string[] args)
        {
            DialogResult result = DialogResult.OK;
            Console.WriteLine(result);

            HomeTown myHomeTown;
            myHomeTown = HomeTown.BUSAN;

            if (myHomeTown == HomeTown.SEOUL){
                Console.WriteLine("서울 출신이시군요!");
            } else if (myHomeTown == HomeTown.DAEJEON){
                Console.WriteLine("충청도예요");
            } else if (myHomeTown != HomeTown.DAEGU){
                Console.WriteLine("대구여");
            }else if (myHomeTown != HomeTown.BUSAN){
                Console.WriteLine("푸싼");
            }else{
                Console.WriteLine("감귤광역시");
            }
        }
    }
}
