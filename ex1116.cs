using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    // (1) 클래스 밖에 클래스를 선언
    class Student
    {
        public int grade;      // 학년
        public int stNumber;   // 학번
        public string gender;  // 성별
        public int age;        // 나이
        public string stName;  // 이름
        public float height;   // 키
        public float weight;   // 몸무게
        public float lVision;  // 왼쪽시력  소문자 (l)
        public float rVision;  // 오른쪽시력
        public float[] vision; // 시력
        public string belong;  // 대학소속
        public DateTime bDay;  // 생년월일
    }

    class Product
    {
        public string pName = "컴퓨터";    // 제풍명 (외부에서도 접근할 수 있게 풀어줌)
        public int pPrice = 0;              // 가격
        private string pCompany;            // 제조사 (나만 쓸 수 있게 = 외부에서 접근 못함)
    }

    internal class ex1116
    {
        static void Main19(string[] args)
        {
            // 변수 쓰려면 변수선언, 값할당
            // A
            int a;      // 변수선언
            a = 100;    // 값할당

            // B
            int b = 100;    // 변수선언&값할당(초기값)

            Console.WriteLine("Hello World!");
            // 클래스에서 객체를 인스턴스화
            // 클래스 객체명 = new 클래스();

            // A
            Product obj1 = new Product();   // 객체생성
            obj1.pName = "갤럭시";
            obj1.pPrice = 1000000;

            // B (객체생성, 초기값 할당)
            Product obj2 = new Product() { pName = "아이폰", pPrice = 1000000};
            // 생성자를 만들어서 쓸수있음 ... 메소드 학습 이후에 다시 언급

            // 방법적인 부분만 알아두기
            Product obj3 = new Product();

            Console.WriteLine(obj1.pName + "의 가격은 " + obj1.pPrice);
            Console.WriteLine(obj2.pName + "의 가격은 " + obj2.pPrice);
            Console.WriteLine(obj3.pName + "의 가격은 " + obj3.pPrice);


            /*
            Student objYJ = new Student();  // 나
            Student objSY = new Student();  // 서영
            Student objSS = new Student();    // 언니

            objYJ.stName = "최요진";
            objYJ.grade = 1;
            objYJ.lVision = 0.9f;

            objSY.stName = "이서영";

            objSS.stName = "최현진";

            Console.WriteLine(objYJ.stName + " 시력 = " + objYJ.lVision);
            */
        }
    }
}
