using System;

namespace Algorithms_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Verilmiş 3 ədəddən neçəsinin tək olduğunu tapan alqoritim      
            Console.WriteLine(OddNumbersCount(4,12,5));

            // 2.Verilmiş 4 ədəddən tek olanlarının cəmini tapan alqoritm
            int[] numbers1 = { 1, 2, 3, 4 };
            Console.WriteLine(FindTheSumOfOdd(numbers1));

            //3.Verilmiş 3 ədəddən ən böyüyünü tapan alqoritm
            int[] numbers2 = { 10, 5, 12 };
            Console.WriteLine(TheGreateNumber(numbers2));

            // 4.Maşının 1k - ə görə yandırdığı benzin dəyəri,
            // maşınn bakındakı hazırki benzin miqdarı və neçə km məsafə getmək istənildiyi verilmişdir.
            // Bu dəyərlərə əsasən maşının həmin məsafəni gedib gedə bilməyəcəyini tapan alqoritm.

            int fuel = 4;
            int currentFuel = 10;
            int root = 20;
            Console.WriteLine( 4 * 10 / 20);







        }


        public static int OddNumbersCount(int number1, int number2, int number3)
        {
            int count = 0;

            if (number1 % 2 != 0)
            {
                count++;
            }
            if (number2 % 2 != 0)
            {
                count++;
            }
            if (number3 % 2 != 0)
            {
                count++;
            }

            return count;
        }


        public static int FindTheSumOfOdd(int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                if (number % 2! == 0)
                {
                    sum += number;
                }
            }

            return sum;
        }

        public static int TheGreateNumber(int[]numbers)
        {
            int GreateNumber = 0;
            foreach (int number in numbers)
            {
                if (number > GreateNumber)
                {
                    GreateNumber = number;
                }
            }
            return GreateNumber;
        }

      







    }
}
