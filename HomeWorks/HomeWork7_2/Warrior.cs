using System;
using System.Drawing;

namespace HomeWork7_2
{
    public class Warrior : Unit, IRun, IFly, ISwim, IMagicalSpell
    {
        public string MagicalSpell { get; set; }
        
        public Warrior(string name, float damage, float health, string magicalSpell) : base(name, damage, health)
        {
            MagicalSpell = magicalSpell;
        }

        public override void Attack()
        {
            Console.WriteLine($"Бьёт мечом и применяет заклинание {MagicalSpell}, нанося {Damage} урона");
        }

        public void Jump()
        {
            Console.WriteLine($"{Name} прыгает");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} не может летать ");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} плавает");
        }

        public void UseMagicalSpell()
        {
            Console.WriteLine($"Применяет {MagicalSpell}");
        }
    }
}