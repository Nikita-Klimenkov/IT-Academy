using System;

namespace HomeWork4_2
{
    public class Enterprise
    {
        public void Name(Worker worker, string name)
        {
            worker.Name = name;
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
}