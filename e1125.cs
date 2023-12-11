using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1125
{
    internal class e1125
    {
        static void Main(string[] args)
        {
            List<int> selectedNumbers = GenerateRandomNumbers();

            // 선택된 숫자 출력
            Console.WriteLine("선택된 숫자:");
            foreach (int number in selectedNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }

        static List<int> GenerateRandomNumbers()
        {
            List<int> numbers = new List<int>();
            Random random = new Random();
            int minValue = 1;
            int maxValue = 45;

            while (numbers.Count < 6)
            {
                int randomNumber = random.Next(minValue, maxValue + 1);

                if (!numbers.Contains(randomNumber))
                {
                    numbers.Add(randomNumber);
                }
            }

            return numbers;
        }
    }
    
}
