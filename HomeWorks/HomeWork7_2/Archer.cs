using System;

namespace HomeWork7_2
{
    public class Archer : Unit, IRun, IFly, ISwim, IMagicalSpell
    {
        public string MagicalSpell { get; set; }
        
        public Archer(string name, float damage, float health, string magicalSpell) : base(name, damage, health)
        {
            MagicalSpell = magicalSpell;
        }

        public override void Attack()
        {
            Console.WriteLine($"Стреляет из лука нанося {Damage} урона, и применяет заклинание {MagicalSpell}");
        }

        public void Jump()
        {
            Console.WriteLine($"{Name} прыгает");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} не может летать");
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
}