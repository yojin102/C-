using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    // 클래스 생성 - 위치 3가지

    // 클래스 이름을 부여할 때 기존에 제공되는 클래스 이름은 XX

    // (1) 클래스 바깥에 클래스 선언
    class LG    // LG라는 이름의 클래스를 생성
    {
        // 데이터(속성) -- 변수 선언

        // 행위(동작) -- 메소드(함수) 선언
    }

    internal class ex1110
    {
        // (2) 클래스 안에 클래스 선언
        class KT
        {

        }

        class DS
        {
            // 데이터(속성) -- 변수 선언
            // 접근권한자 데이터타입 변수명;
            public int rank;        // rank라는 이름으로 정수형 변수를 선언
            public int foundedYear;
            public string slogon;

            // 행위(동작, 행위) -- 메소드(함수) 선언
            // 접근권한자 반환데이터타입 메소드명(매개변수, 매개변수 ...) { 동작 }
            public void PrintName()
            {
                Console.WriteLine("이름 출력");
            }
            
            // 다형성
            public void PrintName(string str)   // C에서는 같은 이름이면 오류나지만, C#에서는 이름이 같아도 매개변수가 입력되어 다른 것으로 인식됨
            {
                Console.WriteLine("감독이름은 " + str);
            }
        }

        static void Main18(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 클래스에서 객체를 인스턴스화
            // 클래스 객체명 = new 클래스();
            LG obj1 = new LG();
            KT obj2 = new KT();
            ExternalClass obj3 = new ExternalClass();

            Console.WriteLine(Math.Max(10,20));

            DS dooSanBears = new DS();
            dooSanBears.rank = 5;
            dooSanBears.foundedYear = 1999;
            dooSanBears.slogon = "최강두산";

            Console.WriteLine(dooSanBears.slogon);
            dooSanBears.PrintName();
            dooSanBears.PrintName("이승엽");

            DS obBears = new DS();
            obBears.foundedYear = 1982;
            obBears.rank = 1;
        }
    }

    // 숙제
    // 학생(Student) 클래스를 생성
    // 학생 객체가 가져야할 속성, 행위(동작)을 정의해서 선언(클래스 안에)
    // 학생 클래스에서 3개 이상 객체를 인스턴스화
    // 만들어진 객체에 속성도 넣고 출력, 동작 해보기
}
