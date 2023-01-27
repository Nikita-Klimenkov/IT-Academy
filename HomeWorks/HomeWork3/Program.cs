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
                Console.WriteLine(number);

                number -= 20;
            } while (number >= -100);
        }

        private static void DoubleDigit()
        {
            for (int i = 10; i <= 100; i += 5)
            {
                Console.Write($"{i} ");
            }
        }

        private static void Average()
        {
            Console.WriteLine("Введите число а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            
            int sum = 0;

            int count;
            for (count = a; count <= b; count++)
            {
                sum += count;
            }

            Console.WriteLine($"Среднее арифметическое равно: {sum / count} \nСумма всех целых чисел равна: {sum}");
        }
    }
}