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
            
            Console.WriteLine("\nНажмите на любую клавишу");
            Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("Задание номер 3:");
            
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
            for (int i = 0; i <= 100; i ++)
            {
                if (i % 5 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        private static void Average()
        {
            bool cycle = true;

            int a = 0;
            int b = 0;
            
            float sum = 0;
            int count = 0;
            
            while (cycle)
            {
                Console.WriteLine("Введите число а: ");

                if (!int.TryParse(Console.ReadLine(), out a) && a > 0)
                {
                    Console.WriteLine("Неправильный ввод, попробуйте ещё");
                    continue;
                }
            
                Console.WriteLine("Введите число b: ");

                if (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Неправильный ввод, попробуйте ещё");
                    continue;
                }
                cycle = false;
            }
            
            for (int i = a; i <= b; i++)
            {
                sum += i;
                count++;
            }
            
            Console.WriteLine($"Среднее арифметическое равно: {sum / count} \nСумма всех целых чисел равна: {sum}");
        }
    }
}