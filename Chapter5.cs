using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1130_1
{
    class Unit  // 연습문제 5번
    {
        public string name = "건설 로봇";   // 이름
        public int mineral = 50;            // 미네랄
        public int supplies = 1;            // 보급품
        public int vitality = 45;           // 생명력
        public int OP = 5;                  // 공격력
    }

    class Book  // 연습문제 6번
    {
        public string name = "PHP 프로그래밍 입문";    // 이름
        public string FEP = "2013년 5월 20일";         // 초판 발행(first edition published)
        public string Autror = "황재호";               // 지은이
        public string Publisher = "김태헌";            // 펴낸이
        public string PoP = "한빛아카데미(주";         // 펴낸곳(Place of publication)
        public string RE = "김현용";                   // 책임편집(ResponsibilityEdit)
        public string plan = "김이화";                 // 기획
        public string edit = "김이화";                 // 편집
        public string design = "여동일";               // 디자인
    }

    class Pet   // 연습문제 7번
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Pet(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Person    // 연습문제 7번
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Pet> Pets { get; set; }

        public Person(string name, string address, List<Pet> pets)
        {
            Name = name;
            Address = address;
            Pets = pets;
        }
    }

    // 연습문제 9번
    
    class Chicken   // 치킨 집 검색 프로그램
    {
        public string Name;
        public string Address;
        public string PhoneNumber;
        public string menu;
    }

    class Parking   // 주차장 관리 프로그램
    {
        public string Name;
        public int Capacity;
        public string OwnerName;
        public string LicensePlate;
    }

    class Book2 // 도서 관리 프로그램
    {
        public string Title;
        public string Author;
        public int Year;
        public string ISBN;
    }

    class User  // 소셜 네트워크 서비스
    {
        public string Username;
        public string Email;
        public string Content;
        public DateTime Timestamp;
    }
    internal class Chapter5
    {
        static void Main(string[] args)
        {
            // 연습문제 5번
            Unit unit = new Unit();
            Console.WriteLine("이름: " + unit.name);
            Console.WriteLine("미네랄: " + unit.mineral);
            Console.WriteLine("보급품: " + unit.supplies);
            Console.WriteLine("생명력: " + unit.vitality);
            Console.WriteLine("공격력: " + unit.OP);

            Console.WriteLine();

            // 연습문제 6번
            Book book = new Book();
            Console.WriteLine("이름: " + book.name);
            Console.WriteLine("초판 발행: " + book.FEP);
            Console.WriteLine("지은이: " + book.Autror);
            Console.WriteLine("펴낸이: " + book.Publisher);
            Console.WriteLine("펴낸곳: " + book.PoP);
            Console.WriteLine("책임편집: " + book.RE);
            Console.WriteLine("기획: " + book.plan);
            Console.WriteLine("편집: " + book.edit);
            Console.WriteLine("디자인: " + book.design);

            Console.WriteLine() ;
            
            // 연습문제 7번
            // Pet 클래스의 인스턴스 생성
            Pet cloud = new Pet("구름", 7);
            Pet star = new Pet("별", 1);

            // Person 클래스의 인스턴스 생성 및 반려 동물 추가
            List<Pet> pets = new List<Pet> { cloud, star };
            Person person1 = new Person("윤인성", "서울특별시 강서구", pets);

            // 생성한 객체의 정보 출력
            Console.WriteLine("이름: " + person1.Name);
            Console.WriteLine("주소: " + person1.Address);
            foreach (Pet pet in person1.Pets)
            {
                Console.WriteLine($"이름: {pet.Name}, 나이: {pet.Age}세");
            }

            Console.WriteLine();

            // 연습문제 8번
            // 1부터 100 사이의 임의의 숫자 생성
            Random random = new Random();
            int targetNumber = random.Next(1, 101);

            int guess;

            do
            {
                Console.Write("1부터 100까지의 숫자를 입력하세요: ");

                // 사용자 입력 받기
                string input = Console.ReadLine();

                // 입력값이 정수인지 확인
                if (int.TryParse(input, out guess))
                {
                    // 숫자 비교
                    if (guess == targetNumber)
                    {
                        Console.WriteLine("정답입니다!");
                        break;
                    }
                    else if (guess < targetNumber)
                    {
                        Console.WriteLine(guess + "보다 큰 숫자입니다.");
                    }
                    else
                    {
                        Console.WriteLine(guess + "보다 작은 숫자입니다.");
                    }
                }
                else
                {
                    Console.WriteLine("올바른 숫자를 입력하세요.");
                }

            } while (true);
        }
    }
}
