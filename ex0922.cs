using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class ex0922
    {
        static void Main6(string[] args)
        {
            // 정수(0~100)을 입력받아서, 학점(A,B,C,D,F) 출력
            Console.WriteLine("점수를 입력하세요");
            string Sum = Console.ReadLine();
            int SUM = int.Parse(Sum);

            if (SUM >= 90) { Console.WriteLine("A"); }
            else if (SUM >= 80) { Console.WriteLine("B"); }
            else if (SUM >= 70){Console.WriteLine("C");}
            else if (SUM >= 60){Console.WriteLine("D");}
            else {Console.WriteLine("F");}

            // 교수님
            int score;
            string credit;
            string inStr;

            // 키보드로부터 입력받음(문자열)
            inStr = Console.ReadLine();

            //문자열을 정수로 변환
            score = int.Parse(inStr);

            // 점수로 학점 판단
            if (score >= 90) { credit = "A"; }
            else if (score >= 80) { credit = "B"; }
            else if (score >= 70) { credit = "C"; }
            else if (score >= 60) { credit = "D"; }
            else { credit = "F"; }

            Console.WriteLine("입력한" + score + "는" + credit + "입니다");

            // A B C D F
            // A+ A B+ B C+ C D+ D F (A+은 문자열이라 string으로 선언)

            // 정수 입력, 홀수? 짝수? 판별해서 출력
            Console.Write("(홀/짝 구분하는) 정수를 입력하세요 ");
            // 입력받을 분자열, 변환하는 정수 -- 변수 선언
            // 따로 변수선언x -- 앞에서 선언한 변수들 그대로 사용
            inStr = Console.ReadLine();
            score = int.Parse(inStr);

            switch(score%2)
            {
                case 0:
                    Console.WriteLine("입력받은 수는 짝수");
                    break;
                case 1:
                    Console.WriteLine("입력받은 수는 홀수");
                    break;
                default:
                    Console.WriteLine("짝/홀수가 아닙니다");
                    break;
            }

            // (앞에서 작성한) 점수 -- 학점 출력하는 부분 switch문으로 바꾸기
            inStr = Console.ReadLine();
            score = int.Parse(inStr);

            switch (score/10)
            {
                case 9: case 10: Console.WriteLine("A"); break;
                case 8: Console.WriteLine("B"); break;
                case 7: Console.WriteLine("C"); break;
                case 6: Console.WriteLine("D"); break;
                default: Console.WriteLine("F"); break;
            }

            // 정수 홀/짝? 출력
            Console.WriteLine((score % 2 == 0) ? "짝" : "홀");
            credit = ((score % 2) == 0) ? "짝" : "홀";
            // 이놈을 if else문으로 바꿔 보세요
        }

    }
}
