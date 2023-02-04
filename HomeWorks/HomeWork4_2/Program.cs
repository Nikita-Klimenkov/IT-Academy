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

            enterprise.HireWorker(new Worker("Jacob", "Programmer", 1900, 1, 5));
            enterprise.HireWorker(new Worker("Andrew", "Doctor", 1750, 5, 10));
            enterprise.HireWorker(new Worker("Jack", "Teacher", 1400, 3, 3));
            
            bool cycle = true;
            while (cycle)
            {
                enterprise.ShowWorkers();

                Console.WriteLine("Выберите работника которого надо изменить:\nЕсли хотите закончить программу нажмите Любую букву!");
                
                int indexOfWorker;
                
                cycle = int.TryParse(Console.ReadLine(), out indexOfWorker);
                indexOfWorker--;
                
                if (!cycle)
                {
                    break;
                }

                Console.Clear();
                enterprise.ShowWorkerInfo(indexOfWorker);
                Console.WriteLine("Что вы хотите в нём изменить:\n1 - Состояние работы\n2 - Должность\n3 - Зарплату\n4 - Разряд\n5 - Стаж работы\n6 - Уволить сотрудника");

                int indexOfCharacter = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                
                switch (indexOfCharacter)
                {
                    case 1:
                        Console.WriteLine("Выберите новое имя: ");
                        string name = Console.ReadLine();
                        enterprise.Name(indexOfWorker, name);
                        break;
                    case 2:
                        Console.WriteLine("Введите название нужной должности: ");
                        string position = Console.ReadLine();
                        enterprise.Position(indexOfWorker, position);
                        break;
                    case 3:
                        Console.WriteLine("Введите желаемую зарплату: ");
                        int salary = Convert.ToInt32(Console.ReadLine());
                        enterprise.Salary(indexOfWorker, salary);
                        break;
                    case 4:
                        Console.WriteLine("Введите нужный разряд: ");
                        int level = Convert.ToInt32(Console.ReadLine());
                        enterprise.Level(indexOfWorker, level);
                        break;
                    case 5:
                        Console.WriteLine("Введите необходимый стаж: ");
                        int workExperience = Convert.ToInt32(Console.ReadLine());
                        enterprise.WorkExperience(indexOfWorker, workExperience);
                        break;
                    case 6:
                        Console.WriteLine("Вы успешно уволили сотрудника!");
                        enterprise.FireWorker(indexOfWorker);
                        Console.WriteLine("Нажмите на любую клавишу");
                        Console.ReadLine();
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
    }
}