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
            for (int i = 10; i <= 100; i += 5)
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
                a = Parse("Введите число a: ");

                b = Parse("Введите число b: ");
                
                cycle = false;
            }
            
            for (int i = a; i <= b; i++)
            {
                sum += i;
                count++;
            }
            
            Console.WriteLine($"Среднее арифметическое равно: {sum / count} \nСумма всех целых чисел равна: {sum}");
        }

        private static int Parse(string message)
        {
            string sentence;
            int result;
            
            while (true)
            {
                Console.Write(message);

                sentence = Console.ReadLine();

                if (int.TryParse(sentence, out result) && result > 0)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Неправильный ввод, попробуйте ещё");
                    continue;
                }
            }
        }
    }
}