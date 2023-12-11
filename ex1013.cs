using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class ex1013
    {
        static void Main10(string[] args)
        {
            // 키보드로부터 정수값(inputNum)을 하나 입력받아서, 1 ~ (입력받은 값)까지 반복하면서 숫자 출력

            // 1. 변수 선언
            // 2. 입력 받기
            // 3. 조건체크해서 출력 반복

            Console.Write("1 이상의 정수를 입력하세요 > ");

            int inNum;                          // 변수 선언
            string inStr = Console.ReadLine();  // 변수 선언 & 입력 받기
            inNum = int.Parse(inStr);           // 형변환

            // for(초기식; 조건식; 종결식)
            //for (int i = 1; i <= inNum; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // 수정1. 위 내용 홀수만 출력되게 수정
            for (int i = 1; i <= inNum; i++) 
            {
                if (i % 2 != 1) // i%2==1
                {
                    // Console.WriteLine("");
                    // continue;

                    break; // break 문을 만나면 현재 반복하고 있는 부분을 빠져나오고 더 이상 반복하지 않음
                }
                Console.WriteLine(i);
            }

            /* int i = 1;
            do 
            {
                Console.WriteLine(i);
                i++;
            } while (i == inNum);
            */
        }
    }
}
