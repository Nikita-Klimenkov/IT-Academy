using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            SequenceOfNumbers();
            DoubleDigit();
            Average();
        }

        private static void SequenceOfNumbers()
        {
            int number = -20;
            
            do
            {
                if (number % 20 == 0)
                {
                    Console.WriteLine(number);
                }

                number--;
            } while (number >= -100);
        }

        private static void DoubleDigit()
        {
            for (int i = 10; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        private static void Average()
        {
            int summ = 0;
            int count = 0;
            int average = 0;
            
            for (int i = 1; i <= 100; i++)
            {
                count++;
                summ += i;
            }

            average = summ / count;
            
            Console.WriteLine($"Среднее арифметическое равно: {average} \nСумма всех целых чисел равна: {summ}");
        }
    }
}