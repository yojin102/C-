using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    // 클래스 선언 방법
    // class 클래스명 {...}

    class madeMath
    {
        // 변수선언 (객체의 상태, 속성을 저장하기 위해)

        // 메소드선언 (객체의 행위, 동작을 시키기 위해)
        // 접근권한자 반환하는 데이터타입 메소드명(매개변수들) {...}

        // 합 구하기 메소드(함수)
        public int Sum(int a, int b)
        {
            return a + b;
        }

        // 제곱 구하기
        public int SQ(int a)
        {
            return (a * a);         // (int)Math.Sqrt(a);
        }

        // 절대값 출력하기 (돌아오는 데이터값 없이 만들기)
        public int Absol(int a)     // 정수 절대값
        {
            int ret;    //반환값
            // 양수, 음수 판별
            if (a >= 0)
            {
                Console.WriteLine("[양수] 절대값 = " + a);
                ret = a;
            }
            else { Console.WriteLine("[음수] 절대값 = " + -a); ret = -a; }
            return ret;
        }

        // 실수 절대값구하기
        public float Absol(float f)
        {
            float ret;
            if (f >= 0) { ret = f; }
            else { ret = -f; }
            return ret;
        } 

        public int Multiply(int a, int b)
        {
            return (a * b);
        }

    }
    internal class ex1123
    {
        static void Main20(string[] args)
        {
            // 클래스에서 객체를 인스턴스화
            // 클래스 객체명 = new 클래스();
            madeMath obj = new madeMath();
            int res = obj.Sum(10, 20);
            Console.WriteLine(res);           
            Console.WriteLine(obj.SQ(5));

            obj.Absol(-100);
            Console.WriteLine("실수절대값: " + obj.Absol(-3.4f));

            // 절대값 구하기 메소드를 추가해서 호출해보기
            // 대상 : 긴정수 long 긴실수 double를 처리하는 절대값

            // 10*20을 계산해서 출력
            //Console.WriteLine(obj.Multiply(10,20));
            res = obj.Multiply(10,20);
        }
    }
}
