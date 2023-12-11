using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class ex1006
    {
        static void Main8(string[] args)
        {
            int[] ILook = { 7, 5, 4, 13, 16, 9 };

            // for (초기식; 조건식; 종결식) {}

            int cnt = 0; // 초기식
            while (cnt < ILook.Length) // 조건식
            {
                Console.WriteLine(ILook[cnt]);
                cnt++; // 증감식(종결)
            }

            // 앞에 while() 반복문 for()문으로 변경
            for (int cnt2 = 0;  cnt2 < ILook.Length; cnt2++)
            {
                Console.WriteLine(ILook[cnt2]);
            }

            /*
             while (true)
            {
                // 반복하는 명령에서 조건을 거짓으로 만드는 것이 없을 경우, 무한반복
                Console.WriteLine("사랑해");
            }
            */
        }
    }
}
