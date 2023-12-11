using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class ex1027
    {
        static void Main12(string[] args)
        {
            // 객체가 필요할 때, 클래스에서 객체를 인스턴스화
            // 클래스 객체명 = new 클래스();
            Random obj1 = new Random();
            // obj1.Next(1,7);
            int dice1;

            // 주사위 10번 던지기
            for(int i = 0; i < 10;  i++)
            {
                dice1 = obj1.Next(1, 7);
                Console.WriteLine((i+1) + ":" + dice1);
            }

            // 주사위 2개를 던져서 나온 합만큼 칸수를 전진
            int dice2, dice3;
            dice2 = obj1.Next(1, 7);
            dice3 = obj1.Next(1, 7);
            Console.WriteLine("주사위1: " + dice2  + ", 주사위2: " + dice3 + "\t" + (dice2 + dice3) + "칸 전진");

            int a = obj1.Next(100);

            int UD;

            do
            {
                // 다음 입력 받기
                Console.Write("[1.가위  2.바위  3.보  0.종료] 숫자를 입력하세요: ");
                string userdice = Console.ReadLine();
                UD = int.Parse(userdice);

                // 가위바위보 컴퓨터 입력 처리
                int CD = obj1.Next(1, 4);   // 컴퓨터 computer dice = CD
                
                // 가위바위보 승무패 처리
                // 몇승몇무몇패 출력
                if (CD == 1)
                {
                    Console.WriteLine("사용자: " + UD + "컴퓨터: " + CD);
                }

            } while (UD != 0);
        }
    }
}
