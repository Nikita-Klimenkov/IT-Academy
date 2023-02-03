using System;
using System.Threading;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(21, 15);
            Point point2 = new Point(16, 8);

            Console.WriteLine($"Расстояние между двумя точками равно: {Point.LengthPoints(point1,point2)} ");
            Console.WriteLine($"Количество созданных экземпляров равно: {Point.count}");
            
        }
    }

    class Point
    {
        private int x;
        private int y;

        public static int count;

        static Point()
        {
            count = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            
            count++;
        }

        public static double LengthPoints(Point firstPoint, Point secondPoint)
        {
            return Math.Sqrt(Math.Pow(secondPoint.x - firstPoint.x, 2) + Math.Pow(secondPoint.y - firstPoint.y, 2));
        }
    }
}