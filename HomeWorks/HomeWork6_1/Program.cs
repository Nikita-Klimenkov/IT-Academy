using System;
using System.Collections.Generic;

namespace HomeWork6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IInstruments> instruments = new List<IInstruments>()
            {
                new Piano("Piano", 1000, 5),
                new Drums("Drums", 2500, 24),
                new Guitar("Guitar", 1000, 4)
            };

            foreach (var instrument in instruments)
            {
                instrument.Play();
            }
        }
    }

    public class Piano : IInstruments
    {
        private string Name { get; set; }

        private float Cost { get; set; }
        
        private float Weight { get; set; }

        public Piano(string name, int cost, int weight)
        {
            Name = name;
            Cost = cost;
            Weight = weight;
        }

        public string Characteristic { get; set; }
        
        
        public void Play()
        {
            Characteristic = $"Играет инструмент {Name}.\nТекущие характеристики равны: Цена - {Cost} руб, Вес - {Weight} кг.";
            
            Console.WriteLine(Characteristic);
        }
    }
    
    public class Drums  : IInstruments
    {
        private string Name { get; set; }

        private float Cost { get; set; }
        
        private float Weight { get; set; }

        public Drums(string name, int cost, int weight)
        {
            Name = name;
            Cost = cost;
            Weight = weight;
        }

        public string Characteristic { get; set; }
        
        
        public void Play()
        {
            Characteristic = $"Играет инструмент {Name}.\nТекущие характеристики равны: Цена - {Cost}, Вес - {Weight}";
            
            Console.WriteLine(Characteristic);
        }
    }
    
    public class Guitar  : IInstruments
    {
        private string Name { get; set; }

        private float Cost { get; set; }
        
        private float Weight { get; set; }

        public Guitar(string name, int cost, int weight)
        {
            Name = name;
            Cost = cost;
            Weight = weight;
        }

        public string Characteristic { get; set; }
        
        
        public void Play()
        {
            Characteristic = $"Играет инструмент {Name}.\nТекущие характеристики равны: Цена - {Cost}, Вес - {Weight}";
            
            Console.WriteLine(Characteristic);
        }
    }

    public interface IInstruments
    {
        public string Characteristic { get; set; }

        public void Play();
    }
}