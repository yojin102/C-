using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class ex1109
    {
        static void Main17(string[] args)
        {
            // 클래스에서 객체를 인스턴스화
            // 클래스 객체명 = new 클래스();
            Random obj1 = new Random();
            int randomNum = obj1.Next(1, 7);

            List<string> obj2 = new List<string>();
            obj2.Add("1");

            // 배열 - 고정, 리스트 - 가변(변할 수 있는 것)

            // Math는 따로 객체생성하지 않고 바로 클래스에 적용
            int largerNum = Math.Max(10, 20);

            // 임의의 수를 입력받아 절대값을 출력
            Console.Write("임의의 수 입력 > ");
            string User = Console.ReadLine();               // 유저 입력값
            int U = int.Parse(User);                        // 형변환

            Console.WriteLine(Math.Abs(U));                 // 절대값 함수 사용

            // 양수인지 음수인지 판별

            // (1) if문 사용
            /*
            if (U >= 0) { Console.WriteLine("[if문] 절대값: " + U); }
            else { Console.WriteLine("[if문] 절대값: " + -U); }

            // (2) Math 클래스 사용
            int absNum = Math.Abs(U);
            Console.WriteLine("[Math클래스] 절대값: " + Math.Abs(U)); // Math.Abs 자리에 변수 absNum 쓰는 방법도 있음
            */
        }
    }
}
