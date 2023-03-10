using System;

namespace HomeWork7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("Гиллаут", 250, 100, "Абсолютная защита");
            Wizard wizard = new Wizard("Бельфаст", 250, 50, "Огненный шар");
            Archer archer = new Archer("Спинхвут", 150, 150, "Град стрел");
        }
    }
}