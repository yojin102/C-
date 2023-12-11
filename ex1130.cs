using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Student1
    {
        // 변수 Variables
        public string name;     // 이름
        public int stNumber;    // 학번
        private int height;      // 키
        private int weight;      // 몸무게
        public int age
        {
            get { return this.age;}
            set { this.age = value; }
        }
        public int grade { set; get; }  // 학년

        // 함수(메소드) Methods
        //접근권한자 반환데이터타입 함수명(매개변수) {}
        public bool GoToSchool()
        {
            return true;
        }

        // 생성자 -- 매개변수 있는 것
        public Student1(string n, int sn)
        {
            this.name = n;
            this.stNumber = sn;
        }
        public Student1(string n)
        {
            this.name = n;
        }

        // 소멸자
        ~Student1 ()
        {
            //  객체가 소멸(제거)될 때 처리해야할 부분을 이쪽에서 처리
            Console.WriteLine("소멸자: 메모리해제 등 처리해주세요 ...");
        }

        // 명칭 : setter (세터) - 값을 넣어줌
        // 함수(메소드) -- 매개변수로 값을 받아서, 객체의 속성값에 할당
        public void SetHeight(int h)
        {
            // 잘못된 데이터가 들어오면 저장하지 않도록 수정
            if (h > 0)
            {
                this.height = h;
            }
            else
            {
                Console.WriteLine("[사용자오류] 입력된 데이터가 잘못되었습니다");
            }
        }

        // 명칭 : getter (겟터) - 값을 받아옴
        // 매개변수 없이 호출하는데 객체의 속성값을 반환
        public int GetHeight()
        {
            return this.height;
        }

        public void SetWeight(int w)
        {
                this.weight = w;
        }

        // 명칭 : getter (겟터) - 값을 받아옴
        // 매개변수 없이 호출하는데 객체의 속성값을 반환
        public int GetWeight()
        {
            return this.weight;
        }

    }
    internal class ex1130
    {
        static void Main(string[] args)
        {
            // in C
            // (변수선언) int a; 데이터타입 변수명;
            // (함수선언) void funcName() {...} 반환데이터타입 함수명(매개변수) {}
            // in C#
            // 변수선언, 함수선언 -> 동일
            // 접근권한자 : public, private

            // 클래스에서 객체를 인스턴스화할 때, 매개변수 없이 생성자를 호출한 경우
            // Student1 student1 = new Student1();
            // student1.name = "최요진";

            // 인스턴스화할 때, 매개변수를 넘겨주는 생성자를 호출
            Student1 student1 = new Student1("최요진", 20232297);
            
            // private 선언으로 외부에서 접근하지 못함 (오류)
            // 값을 넣고 싶을 때 속성에 직접 접근하지 않고 public 함수에 접근해서 값을 넣음
            // student1.height = 170;
            student1.SetHeight(170);

            // 신입생이라서 아직 학번이 안나옴
            Student1 newer = new Student1("홍길동");

            // 합격 이후 학번
            

            bool res = student1.GoToSchool();

            if (res) { Console.WriteLine(student1.name + " 출석했습니다."); }
            else { Console.WriteLine(student1.name + " 출석하지않았습니다."); }

            // 오류 - height 속성이 private으로 선언되어 직접 접근 불가
            // Console.WriteLine(student1.name + " 키는 " + student1.height);

            // 직접 접근하지 않고 값을 넘겨주는 함수를 호출해서 대신 받아옴
            Console.WriteLine(student1.name + " 키는 " + student1.GetHeight());
        }
    }
}
