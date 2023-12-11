using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class ex1012
    {
        static void Main9(string[] args)
        {
            // 키보드로부터 정수를 입력하고(해당숫자를) 출력하는 코드를 작성하세요
            // 입력받은 정수가 0이 아니면 계속 반복
            // 0이면 반복에서 빠져 나옴

            // (1) while 반복문 사용
                        
            int inNum = 1;     // 입력받은 정수(초기값을 임의의 정수로 넣어줌)

            while (inNum != 0) // do while 쓰면 // do
            {
                Console.Write("[가위 1, 바위 2, 보 3, 종료 0] 숫자를 입력하세요 >");

                string inStr = Console.ReadLine();      // 입력받은 문자열
                inNum = int.Parse(inStr);
                // 가위바위보 게임을 완성시키려면, 여기서 컴퓨터입력을 처리
                Console.WriteLine("입력한 값은" + inNum);
            }// while (inNum != 0);

            Console.WriteLine("");
        }
    }
}
