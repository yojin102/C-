using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class ex1103_1
    {
        static void Main16(string[] args)
        {
            Random random = new Random();
            int[] selectedNumbers = new int[6];
            int minValue = 1;
            int maxValue = 45;

            for (int i = 0; i < 6; i++)
            {
                int randomNumber;
                do
                {
                    randomNumber = random.Next(minValue, maxValue + 1);
                } while (selectedNumbers.Contains(randomNumber)); // 중복 확인

                selectedNumbers[i] = randomNumber;
            }

            // 선택된 숫자 출력
            Console.WriteLine("선택된 숫자:");
            foreach (int number in selectedNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
