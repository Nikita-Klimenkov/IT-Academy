using System;
using System.Collections.Generic;

namespace HomeWork4_2
{
    public class Enterprise
    {
        private List<Worker> workers = new List<Worker>();

        public void ShowWorkers()
        {
            for (int i = 0; i < workers.Count; i++)
            {
                Console.WriteLine($"{i + 1}) Имя: {workers[i].Name}, Должность: {workers[i].Position}, Зарплата: {workers[i].Salary}, Разряд: {workers[i].Level}, Стаж работы: {workers[i].WorkExperience} лет");
            }
        }

        public void ShowWorkerInfo(int index)
        {
            Console.WriteLine($"Имя: {workers[index - 1].Name}, Должность: {workers[index - 1].Position}, Зарплата: {workers[index - 1].Salary}, Разряд: {workers[index - 1].Level}");
        }
        
        public void HireWorker(Worker worker)
        {
            workers.Add(worker);
        }
        
        public void FireWorker(int index)
        {
            workers.Remove(workers[index]);
        }
        public void Name(int index, string name)
        {
            workers[index].Name = name;
        }

        public void WorkExperience(int index, int years)
        {
            workers[index].WorkExperience = years;
        }
        
        public void Salary(int index, int salary)
        {
            workers[index].Salary = salary;
        }

        public void Position(int index, string position)
        {
            workers[index].Position = position;
        }
        
        public void Level(int index, int level)
        {
            workers[index].Level = level;
        }
    }
}