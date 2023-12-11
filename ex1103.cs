using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class ex1103
    {
        static void Main15(string[] args)
        {
            // 클래스 --> 객체 (인스턴스화)
            // 클래스 객체명 = new 클래스();
            // Random obj1 = new Random();
            // List<int> obj2 = new List<int>();

            Console.WriteLine(Math.Abs(-10));
            Console.WriteLine(Math.Min(10,20));
            Console.WriteLine(Math.Max(10,20));

            // 문제
            // 키보드로부터 5개 정수를 입력받아, 최댓값 최솟값을 출력하세요.
            // (1) 키보드로부터 5개 입력 받고 저장. 변수, 배열, 리스트
            // (2) (배열이나 리스트에서) 하나씩 가져와서 최솟값, 최댓값 비교해서 저장

            int[] arr = {0,0,0,0,0 };
            string inputStr;
            int minValue=1000000, maxValue=-1000000;

            for(int i = 0; i<5; i++)
            {
                Console.Write("정수를 입력하세요 ");
                inputStr = Console.ReadLine();
                // inputNum = int.Parse(inputStr);
                // arr[i] = inputNum;

                arr[i] = int.Parse(inputStr);
            }

            for (int j = 0; j<5; j++)
            {
                // 어떤 수가 작은지 판별 (최솟값)
                if (arr[j] < minValue) minValue = arr[j];
                // 어떤 수가 큰지 판별 (최댓값)
                if (arr[j] > maxValue) maxValue = arr[j];
            }
            Console.WriteLine("최댓값: " + maxValue +", 최솟값: " + minValue);
        }
    }
}
