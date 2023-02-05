using System;

namespace HomeWork4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Appliances dishWasher = new Dishwasher(25, 5, "Bosch SPV4XMX28E", 5, 1879);
            
            dishWasher.ShowInfo();
            dishWasher.Launch();
            dishWasher.ShutDown();
            
            Console.WriteLine("Нажмите на любую клавишу");
            Console.ReadKey();
            Console.Clear();

            Appliances washingMachine = new WashingMachine(15, 20, "LG F2J3HS4L", 5, 1560);
            
            washingMachine.ShowInfo();
            washingMachine.Launch();
            washingMachine.ShutDown();
        }
    }
}