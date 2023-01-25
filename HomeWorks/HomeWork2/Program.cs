using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Гипотенуза равна: {FindHypotenuse()}");
            
            Console.WriteLine("Нажмите любую клавишу для перехода на следующее задание: ");
            Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine($"Результат умножения равен: {Multiply()}");
            
            Console.WriteLine("Нажмите любую клавишу для перехода на следующее задание: ");
            Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine($"Таблица умножения:");
            MultiplicationTable();
            
            Console.WriteLine("Нажмите любую клавишу для перехода на второй вариант таблицы: ");
            Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine($"Таблица пифагора:");
            PythagoreanTable();
            
            Console.WriteLine("Нажмите любую клавишу для перехода на следующее задание: ");
            Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine($"Сумма равна: {Contribution()}");
        }

        private static float FindHypotenuse()
        {
            Console.Write("Введите длинну первого катета - ");
            float firstLeg = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите длинну второго катета - "); 
            float secondLeg = Convert.ToSingle(Console.ReadLine());

            if (firstLeg > 0 && secondLeg > 0)
            {
                return MathF.Sqrt((firstLeg * firstLeg) + (secondLeg * secondLeg));
            }
            else
            {
                return 0;
            }
        }

        private static float Multiply()
        {
            while (true)
            {
                Console.Write("Введите первое число - ");
                float firstNumber = Convert.ToSingle(Console.ReadLine());
                Console.Write("Введите второе число - "); 
                float secondNumber = Convert.ToSingle(Console.ReadLine());

                if ((firstNumber > 10 || firstNumber < 0) || (secondNumber > 10 || secondNumber < 0))
                {
                    Console.Clear();
                    Console.WriteLine("Некорректный ввод, введите числа заново :");
                }
                else
                {
                    return firstNumber * secondNumber;
                }
            }
        }

        private static void MultiplicationTable()
        {
            int numbers = 10;
            int column = 10;
            int currentCusrsorPosition = 0;

            for (int i = 2; i <= column; i++)
            {
                for (int j = 1; j <= numbers; j++)
                {
                    Console.SetCursorPosition(currentCusrsorPosition, j);
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                
                currentCusrsorPosition += 15;
            }
        }

        private static void PythagoreanTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j} \t");
                }
                Console.WriteLine();
            }
        }

        private static decimal Contribution()
        {
            Console.WriteLine("Введите сумму вклада: ");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите количество месяцев: ");
            int countOfMonth = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= countOfMonth; i++)
            {
                depositAmount = depositAmount + (depositAmount * 0.07m);
            }

            return depositAmount;
        }
    }
}
