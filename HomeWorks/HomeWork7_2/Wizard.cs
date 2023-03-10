using System;

namespace HomeWork7_2
{
    public class Wizard : Unit, IRun, IFly, ISwim, IMagicalSpell
    {
        public string MagicalSpell { get; set; }
        
        public Wizard(string name, float damage, float health, string magicalSpell) : base(name, damage, health)
        {
            MagicalSpell = magicalSpell;
        }

        public override void Attack()
        {
            Console.WriteLine($"Поднимает свой жезл и применяет заклинание {MagicalSpell}, нанося {Damage} урона");
        }

        public void Jump()
        {
            Console.WriteLine($"{Name} не может прыгать");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} летает на жезле");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} не умеет плавать");
        }

        public void UseMagicalSpell()
        {
            Console.WriteLine($"Применяет {MagicalSpell}");
        }
    }
}