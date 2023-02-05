using System;
using System.Threading;

namespace HomeWork4_3
{
    public class WashingMachine : Appliances
    {
        private int _capacity;

        private int Capacity
        {
            get => _capacity;
            set
            {
                if (value > 0 && value <= 10)
                {
                    _capacity = value;
                }
            }
        }


        public WashingMachine(int weight, int workTime, string name, int capacity, int price)
            : base(weight, workTime, name, price)
        {
            Weight = weight;
            WorkTime = workTime;
            Name = name;
            _capacity = capacity;
            Price = price;
        }
        
        public override void ShowInfo()
        {
            Console.WriteLine($"Информация о стиральной машине: " +
                              $"\n1)Вес равен - {Weight} кг " +
                              $"\n2)Время одной стирки - {WorkTime} секунд " +
                              $"\n3)Название модели - {Name} " +
                              $"\n4)Вместимость количества одежды - {Capacity} килограмм " +
                              $"\n5)Цена модели - {Price} рублей");
            
            Console.WriteLine("Нажмите на любую клавишу");
            Console.ReadKey();
            Console.Clear();
        }

        public override void Launch()
        {
            Console.WriteLine("Стиральная машина запущена!");

            int precent = 100 / WorkTime;
            int result = 0; 
            
            for (int i = 0; i < WorkTime; i++)
            {
                Thread.Sleep(150);
                Console.WriteLine($"Стирка закончена на {result += precent}%");
            }
            
            Console.WriteLine("Стирка закончена\nНажмите на любую клавишу");
            Console.ReadKey();
            Console.Clear();
        }

        public override void ShutDown()
        {
            Console.WriteLine("Стиральная машина выключается подождите...");
            Thread.Sleep(400);
            Console.WriteLine("Стиральная машина успешно выключена, спасибо за использование");
        }
    }
}