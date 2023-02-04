using System;

namespace HomeWork4_2
{
    public class Worker
    {
        private string position;
        private float salary;
        private string name;
        private int level;
        private int workExperience;

        public int WorkExperience
        {
            get => workExperience;
            set => workExperience = value;
        }

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
        public string Name
        {
            get => name; set => name = value;
        }

        public string Position
        {
            get => position; set => position = value;
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
        
        public Worker(string name, string position, float salary, int level, int workExperience)
        {
            this.name = name;
            this.position = position;
            this.salary = salary;
            this.level = level;
            this.workExperience = workExperience;
        }
    }
}