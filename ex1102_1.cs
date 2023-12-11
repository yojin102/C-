using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class ex1102_1
    {
        static void Main14(string[] args)
        {
            // 정수형 배열
            int[] intArray = { 1, 2, 3, 4, 5 };
            intArray[2] = 100;

            // 클래스에서 객체를 인스턴스화
            // 클래스 객체명 = new 클래스();
            // Random obj = new Random();
            List<int> obj1 = new List<int>();
            List<string> obj2 = new List<string>();

            // obj1.AddRange(intArray);
            obj1.Add(1);
            obj1.Add(2);

            for (int i = 1; i <= 10; i++)
            {
                obj1.Add(i*10);
            }

            // obj1.Remove(10); 제거
            
            // 들어간 정수들을 출력
            // for (int j = 0; j < obj1.Count; j++) { }
            foreach (var item in obj1)
            {
                Console.WriteLine(item);
            }

            // 숙제
            // Add(50)
            // Remove(50)

            // 동일한 데이터 값이 2개
            // 1. 앞의 데이터 삭제, 2. 뒤의 데이터, 3. 둘 다 삭제, 4. 둘 다 삭제X
            int cnt = obj1.Count;
            foreach (var item in obj1)
            {
                Console.WriteLine("Count: " + cnt + ", Item: "+ item);
            }

            for (int j = 0; j < obj1.Count; j++)
            {
                Console.WriteLine("Count: " + (j+1) + "/" + cnt + ", Item: "+ obj1[j]);
            }

            int foundInt = obj1.Find(x => x == 1000);
            Console.WriteLine(foundInt);
        }
    }
}
