using System;

namespace HomeWork4_2
{
    public class Worker
    {
        private float salary;
        private int level;

        public int WorkExperience { get; set; }
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
        public string Name { get; set; }
        public string Position { get; set; }

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
        
        public Worker(string name, string position, float salary, int level, int workExperience)
        {
            this.salary = salary;
            this.level = level;
            Position = position;
            Name = name;
            WorkExperience = workExperience;
        }
    }
}