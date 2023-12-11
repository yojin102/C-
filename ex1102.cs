using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class ex1102
    {
        static void Main13(string[] args)
        {
            // 가위바위보 (1판)
            // (1) 사용자(가위1, 바위2, 보3, 종료0)
            // (2) 컴퓨터 - 랜덤하게 숫자 뽑기(Random 클래스 사용)
            // (3) 사용자 vs 컴퓨터 - 비교해서 승무패 판정
            // (4) 결과 출력(승무패 카운트)

            // 승무패 계산
            int win = 0;
            int lose = 0;
            int draw = 0;

            Console.Write("가위바위보를 입력하세요. (가위1, 바위2, 보3, 종료0) ");

            // (1) 사용자 입력 받기
            string inputStr = Console.ReadLine();
            int userinput = int.Parse(inputStr);

            // (2) 클래스에서 객체를 인스턴스화
            // 클래스 객체명 = new 클래스();
            Random obj = new Random();
            int cominput = obj.Next(1, 4);
            Console.WriteLine("컴퓨터 랜덤수: " + cominput);

            // (3)
            if (userinput == 1)         // 사용자 = 1 (가위)
            {
                if (cominput == 1)      // 컴퓨터 = 1 (가위)
                {
                    Console.WriteLine("무승부"); draw++;
                }  
                else if (cominput == 2) // 컴퓨터 = 2 (바위)
                {
                    Console.WriteLine("패"); lose++;
                }
                else                    // 컴퓨터 = 3 (보)
                {
                    Console.WriteLine("승"); win++;
                }
            }
            else if (userinput == 2)    // 사용자 = 2 (바위)
            {
                if (cominput == 1)      // 컴퓨터 = 1 (가위)
                {
                    Console.WriteLine("승"); win++;
                }
                else if (cominput == 2) // 컴퓨터 = 2 (바위)
                {
                    Console.WriteLine("무승부"); draw++;
                }
                else                    // 컴퓨터 = 3 (보)
                {
                    Console.WriteLine("패"); lose++;
                }
            }
            else if (userinput == 3)    // 사용자 = 3 (보)
            {
                if (cominput == 1)      // 컴퓨터 = 1 (가위)
                {
                    Console.WriteLine("패"); lose++;
                }
                else if (cominput == 2) // 컴퓨터 = 2 (바위)
                {
                    Console.WriteLine("승"); win++;
                }
                else                    // 컴퓨터 = 3 (보)
                {
                    Console.WriteLine("무승부"); draw++;
                }
            }
            else { Console.WriteLine("잘못 입력하셨습니다."); }

            Console.WriteLine(win + "승 " + draw + "무 " + lose + "패");

            // do while() 을 사용해서 가위바위보 

            do
            {
                Console.Write("가위바위보를 입력하세요. (가위1, 바위2, 보3, 종료0) ");
                inputStr = Console.ReadLine();
                userinput = int.Parse(inputStr);

                if (userinput == 0)
                { break;  }
                
                Console.WriteLine("컴퓨터 랜덤수: " + cominput);

                if (userinput == 1)         // 사용자 = 1 (가위)
                {
                    if (cominput == 1)      // 컴퓨터 = 1 (가위)
                    {
                        Console.WriteLine("무승부"); draw++;
                    }
                    else if (cominput == 2) // 컴퓨터 = 2 (바위)
                    {
                        Console.WriteLine("패"); lose++;
                    }
                    else                    // 컴퓨터 = 3 (보)
                    {
                        Console.WriteLine("승"); win++;
                    }
                }
                else if (userinput == 2)    // 사용자 = 2 (바위)
                {
                    if (cominput == 1)      // 컴퓨터 = 1 (가위)
                    {
                        Console.WriteLine("승"); win++;
                    }
                    else if (cominput == 2) // 컴퓨터 = 2 (바위)
                    {
                        Console.WriteLine("무승부"); draw++;
                    }
                    else                    // 컴퓨터 = 3 (보)
                    {
                        Console.WriteLine("패"); lose++;
                    }
                }
                else if (userinput == 3)    // 사용자 = 3 (보)
                {
                    if (cominput == 1)      // 컴퓨터 = 1 (가위)
                    {
                        Console.WriteLine("패"); lose++;
                    }
                    else if (cominput == 2) // 컴퓨터 = 2 (바위)
                    {
                        Console.WriteLine("승"); win++;
                    }
                    else                    // 컴퓨터 = 3 (보)
                    {
                        Console.WriteLine("무승부"); draw++;
                    }
                }
                else { Console.WriteLine("잘못 입력하셨습니다."); }

            }while (userinput != 0);

            Console.WriteLine(win + "승 " + draw + "무 " + lose + "패");
        }
    }
}
