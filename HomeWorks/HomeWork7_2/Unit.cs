using System;

namespace HomeWork7_2
{
    public abstract class Unit
    {
        public string Name { get; set; }
        
        public float Damage { get; set; }
        
        public float Health { get; set; }

        protected Unit(string name, float damage, float health)
        {
            Name = name;
            Damage = damage;
            Health = health;
        }

        public void Movement()
        {
            Console.WriteLine($"{Name} двигается");
        }

        public abstract void Attack();
    }
}