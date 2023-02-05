namespace HomeWork4_3
{
    public abstract class Appliances
    {
        protected int Weight { get; init; }
        protected string Name { get; init; }
        protected int WorkTime { get; init; }
        protected int Price { get; init; }
        
        protected Appliances(int weight, int workTime, string name, int price)
        {
            Weight = weight;
            WorkTime = workTime;
            Name = name;
            Price = price;
        }
        
        public abstract void ShowInfo();
        public abstract void Launch();
        public abstract void ShutDown();
    }
}