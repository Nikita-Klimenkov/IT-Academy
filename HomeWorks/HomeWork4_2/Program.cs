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
                new Worker(true, "Programmer", 1900, 2),
                new Worker(false, "Ingineer", 1460, 5),
                new Worker(true, "Doctor", 1750, 1)
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
                Console.WriteLine($"Состояние работы: {workers[indexOfWorker - 1].BoolFired}, Должность: {workers[indexOfWorker - 1].Position}, Зарплата: {workers[indexOfWorker - 1].Salary}, Разряд: {workers[indexOfWorker - 1].Level}");
                Console.WriteLine("Что вы хотите в нём изменить:\n1 - Состояние работы\n2 - Должность\n3 - Зарплату\n4 - Разряд");

                int indexOfCharacter = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                
                switch (indexOfCharacter)
                {
                    case 1:
                        Console.WriteLine("Вы изменили состояние работы!");
                        enterprise.Fire(workers[indexOfWorker - 1]);
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
                Console.WriteLine($"{i + 1}) Состояние работы: {workers[i].BoolFired}, Должность: {workers[i].Position}, Зарплата: {workers[i].Salary}, Разряд: {workers[i].Level}");
            }
        }
    }

    class Enterprise
    {
        public void Fire(Worker worker)
        {
            worker.BoolFired = !worker.BoolFired;
        }

        public void Salary(Worker worker, int salary)
        {
            worker.Salary = salary;
        }

        public void Position(Worker worker, string position)
        {
            worker.Position = position;
        }
        
        public void Level(Worker worker, int level)
        {
            worker.Level = level;
        }
    }
    
    class Worker
    {
        private string position;
        private float salary;
        private bool boolFired;
        private int level;

        public int Level
        {
            get => level;
            set
            {
                if (value > 5 || value <= 0)
                {
                    Console.WriteLine("Неправильнаый разряд");
                    Console.WriteLine("Нажмите на любую клавишу");
                    Console.ReadLine();
                }
                else
                {
                    salary = value;
                }
            }
        }
        public bool BoolFired
        {
            get
            {
                return boolFired;
            }
            set
            {
                boolFired = value;
            }
        }

        public string Position
        {
            get => position;
            set => position = value;
        }

        public float Salary
        {
            get => salary;
            set
            {
                if (value > 2000 || value <= 500)
                {
                    Console.WriteLine("Неправильная сумма");
                    Console.WriteLine("Нажмите на любую клавишу");
                    Console.ReadLine();
                }
                else
                {
                    salary = value;
                }
            }
        }
        
        public Worker(bool boolFired, string position, float salary, int level)
        {
            this.boolFired = boolFired;
            this.position = position;
            this.salary = salary;
            this.level = level;
        }
    }
}