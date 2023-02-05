using System;

namespace HomeWork4_2
{
    public class Worker
    {
        private float _salary;
        private int _level;

        public int WorkExperience { get; set; }
        
        public string Name { get; set; }
        
        public string Position { get; set; }
        
        public int Level
        {
            get => _level;
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
                    _salary = value;
                }
            }
        }

        public float Salary
        {
            get => _salary;
            set
            {
                if (value > 2000 || value <= 500)
                {
                    Console.WriteLine("Неправильная сумма");
                    Console.WriteLine("Нажмите на любую клавишу");
                    Console.ReadKey();
                }
                else
                {
                    _salary = value;
                }
            }
        }
        
        public Worker(string name, string position, float salary, int level, int workExperience)
        {
            this._salary = salary;
            this._level = level;
            Position = position;
            Name = name;
            WorkExperience = workExperience;
        }
    }
}