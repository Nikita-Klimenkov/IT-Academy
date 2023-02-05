using System;
using System.Threading;

namespace HomeWork4_3
{
    public class Dishwasher : Appliances
    {
        private int _countOfDish;
        
        private int CountOfDish
        {
            get => _countOfDish;
            set
            {
                if (value > 0 && value <= 20)
                {
                    _countOfDish = value;
                }
            }
        }

        public Dishwasher(int weight, int workTime, string name, int countOfDish, int price)
            : base(weight, workTime, name, price)
        {
            Weight = weight;
            WorkTime = workTime;
            Name = name;
            _countOfDish = countOfDish;
            Price = price;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Информация о посудомоечной машине: \n1)Вес равен - {Weight} кг \n2)Время мойки посуды - {WorkTime} секунд \n3)Название модели - {Name} \n4)Максимальное количество посуды - {CountOfDish} \n5)Цена модели - {Price} рублей");
            Console.WriteLine("Нажмите на любую клавишу");
            Console.ReadKey();
            Console.Clear();

        }

        public override void Launch()
        {
            Console.WriteLine("Посудомоечная машина запущена!");

            int dishes = CountOfDish / WorkTime;
            int result = 0; 
            
            for (int i = 0; i < WorkTime; i++)
            {
                Thread.Sleep(150);
                Console.WriteLine($"Помыто посуды - {result += dishes} штук");
            }
            
            Console.WriteLine("Мойка посуды закончена\nНажмите на любую клавишу");
            Console.ReadKey();
            Console.Clear();
        }

        public override void ShutDown()
        {
            Console.WriteLine("Посудомоечная машина выключается подождите...");
            Thread.Sleep(500);
            Console.WriteLine("Посудомоечная машина успешно выключена, спасибо за использование");
        }
    }
}