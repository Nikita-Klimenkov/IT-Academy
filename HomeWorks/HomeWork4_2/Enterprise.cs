using System;
using System.Collections.Generic;

namespace HomeWork4_2
{
    public class Enterprise
    {
        private readonly List<Worker> _workers = new List<Worker>();

        public void ShowWorkers()
        {
            for (int i = 0; i < _workers.Count; i++)
            {
                Console.WriteLine($"{i + 1}) Имя: {_workers[i].Name}, Должность: {_workers[i].Position}, Зарплата: {_workers[i].Salary}, Разряд: {_workers[i].Level}, Стаж работы: {_workers[i].WorkExperience} лет");
            }
        }

        public void ShowWorkerInfo(int index)
        {
            Console.WriteLine($"Имя: {_workers[index].Name}, Должность: {_workers[index].Position}, Зарплата: {_workers[index].Salary}, Разряд: {_workers[index].Level}");
        }
        
        public void HireWorker(Worker worker)
        {
            _workers.Add(worker);
        }
        
        public void FireWorker(int index)
        {
            _workers.Remove(_workers[index]);
        }
        public void Name(int index, string name)
        {
            _workers[index].Name = name;
        }

        public void WorkExperience(int index, int years)
        {
            _workers[index].WorkExperience = years;
        }
        
        public void Salary(int index, int salary)
        {
            _workers[index].Salary = salary;
        }

        public void Position(int index, string position)
        {
            _workers[index].Position = position;
        }
        
        public void Level(int index, int level)
        {
            _workers[index].Level = level;
        }
    }
}