using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание номер 1:");
            
            SequenceOfNumbers();
            
            Console.WriteLine("Нажмите на любую клавишу");
            Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("Задание номер 2:");

            DoubleDigit();
            
            Console.WriteLine("Нажмите на любую клавишу");
            Console.ReadLine();
            Console.Clear();
            
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
            
            float sum = 0;
            int count = 0;
            
            for (int i = a; i <= b; i++)
            {
                sum += i;
                count++;
            }
        
            Console.WriteLine($"Среднее арифметическое равно: {sum / count} \nСумма всех целых чисел равна: {sum}");
        }
    }
}