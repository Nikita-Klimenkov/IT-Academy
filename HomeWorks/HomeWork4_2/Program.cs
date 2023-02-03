using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;

namespace HomeWork4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Enterprise enterprise = new Enterprise();

            Worker[] workers = new Worker[]
            {
                new Worker("Jacob", "Programmer", 1900, 2),
                new Worker("Andrew", "Ingineer", 1460, 5),
                new Worker("Jack", "Doctor", 1750, 1)
            };
            
            bool cycle = true;

            while (cycle)
            {
                ArrayWorkers(workers);
                
                Console.WriteLine("Выберите работника которого надо изменить:\nЕсли хотите закончить программу нажмите Любую букву!");
                
                int indexOfWorker;
                cycle = int.TryParse(Console.ReadLine(), out indexOfWorker);
                if (!cycle)
                {
                    break;
                }

                Console.Clear();
                Console.WriteLine($"Имя: {workers[indexOfWorker - 1].Name}, Должность: {workers[indexOfWorker - 1].Position}, Зарплата: {workers[indexOfWorker - 1].Salary}, Разряд: {workers[indexOfWorker - 1].Level}");
                Console.WriteLine("Что вы хотите в нём изменить:\n1 - Состояние работы\n2 - Должность\n3 - Зарплату\n4 - Разряд");

                int indexOfCharacter = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                
                switch (indexOfCharacter)
                {
                    case 1:
                        Console.WriteLine("Выберите новое имя: ");
                        string name = Console.ReadLine();
                        enterprise.Name(workers[indexOfWorker - 1], name);
                        break;
                    case 2:
                        Console.WriteLine("Введите название нужной должности: ");
                        string position = Console.ReadLine();
                        enterprise.Position(workers[indexOfWorker - 1], position);
                        break;
                    case 3:
                        Console.WriteLine("Введите желаемую зарплату: ");
                        int salary = Convert.ToInt32(Console.ReadLine());
                        enterprise.Salary(workers[indexOfWorker - 1], salary);
                        break;
                    case 4:
                        Console.WriteLine("Введите нужный разряд: ");
                        int level = Convert.ToInt32(Console.ReadLine());
                        enterprise.Level(workers[indexOfWorker - 1], level);
                        break;
                    default:
                        Console.WriteLine("Такого варианта нету");
                        Console.WriteLine("Нажмите на любую клавишу");
                        Console.ReadLine();
                        break;
                }

                Console.Clear();
            }
        }

        private static void ArrayWorkers(Worker[] workers)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine($"{i + 1}) Состояние работы: {workers[i].Name}, Должность: {workers[i].Position}, Зарплата: {workers[i].Salary}, Разряд: {workers[i].Level}");
            }
        }
    }
}