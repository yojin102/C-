using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class assignmnet1
    {
        static void Main(string[] args)
        {
            // Chapter 2
            // 11번 inch 단위를 입력 받아 cm 단위를 구하는 코드를 작성하시오.

            Console.WriteLine("11번. inch 단위를 입력하고 Enter>"); // 문제 제시
            string inch = Console.ReadLine();   // 입력받은거 변수에 넣기
            double Inch = double.Parse(inch);   // 문자열 숫자로 전환
            double cm = 2.54;                   // cm 변수 선언, 값 할당
            Console.WriteLine(Inch * cm + "cm");

            Console.WriteLine();

            // 12번 킬로그램(kg) 단위를 입력 받아 파운드(pound)단위를 구하는 코드를 작성하시오.

            Console.WriteLine("12번. 킬로그램(kg) 단위를 입력하고 Enter>"); // 문제 제시
            string kg = Console.ReadLine(); // 입력받은거 변수에 넣기
            double Kg = double.Parse(kg);   // 문자열 숫자로 전환
            double pound = 2.20462262;      // pound 변수 선언, 값 할당
            Console.WriteLine(Kg * pound + "pound");

            Console.WriteLine();


            // 13번 원의 반지름을 입력 받아 원의 둘레와 넓이를 구하는 코드를 작성하시오.

            Console.WriteLine("13번. 원의 반지름을 입력하고 Enter>"); // 문제제시
            string r = Console.ReadLine();  // 입력받은거 변수에 넣기
            double R = double.Parse(r);     // 문자열을 숫자로 전환
            double PI = 3.14;               // 파이값 변수 선언, 값 할당
            Console.WriteLine("원의 둘레:" + 2 * PI * R);
            Console.WriteLine("원의 넓이:" + PI * R * R);

        }
    }
}
