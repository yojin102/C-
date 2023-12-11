using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class ex1005
    {
        static void Main7(string[] args)
        {
            // 이름 10번 출력하세요
            // for(초기식; 조건시기 종결식){}
            // 4절
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("[" + (i+1) + "번째" + "]최요진" + i);
            }
            // 5절 역 for문
            for(int i = 10;  i > 0; i--) 
            {
                Console.WriteLine("[" + (11-i) + "번째" + "]최요진" + i);
            }

            // 중첩for문 (중첩반복문)
            for(int i=0; i<10; i++)
            {
                // Console.WriteLine("**********");
                for(int j=0; j<10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            // 배열: 동일한 데이터타입을 묶어서 처리할 때
            // 예) 정수형 변수 선언, 값 할당
            int a = 10;
            // 예) 정수형 배열 선언
            int[] b = {10,20,30};
            // in C, int b[] = {10,20,30};
            // 배열(내의) 원소에 접근하려면 [인덱스번호]로 접근가능
            Console.WriteLine(b[1]);
            b[2] = 100;

            string[] str = { "밥", "못먹어요", "라면", "기식", "바나나", "초코파이", "안먹었어요", "물" };
            Console.WriteLine(str[0]);

            // 배열은 2개이상 묶어서 처리하는 경우가 많기 때문에
            // 배열내의 모든 데이터를 {하나씩 가져와서} 처리하려면
            // 반복문을 사용

            // 고정숫자(예 5)를 쓰기보다는 배열의 갯수를 확인해서 반복 실행하는 것이 바람직함 (63줄)
            //for(int i = 0;i < 5; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}   

            // 에러: 인덱스번호 이상으로 올라가면 컴파일오류X, 실행도중 오류 발생 (런타임에러) - indexOut0fRange ..
            // 반복문 실행 전에, 인덱스번호를 확인해서 반복실행하는 것이 바람직함

            //ex1006
            Console.WriteLine("배열 갯수 확인 " + str.Length);
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }

            // in C#, 배열내의 원소 갯수 = 배열.Length
            // in C, sizeof(배열) / sizeof(데이터타입)

            // foreach문
            foreach(string item in str)
            {
                Console.WriteLine(item);
            }

            // 누적합
            int sum = 0;
            // foreach(int a1 in arrint)
            // foreach(var a1 in arrint)
            {
            //    sum += a1;
            }
            Console.WriteLine("누적합=" + sum);

            // 변수선언할 때, 데이터타입 변수명;
            // var로 선언 예) var aaa = 10;
        }
    }
}
