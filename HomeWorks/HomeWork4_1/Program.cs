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
            Console.WriteLine($"Количество созданных экземпляров равно: {Point.Count}");
            
        }
    }

    class Point
    {
        private int _x;
        private int _y;

        public static int Count;

        static Point()
        {
            Count = 0;
        }
        public Point(int x, int y)
        {
            this._x = x;
            this._y = y;
            
            Count++;
        }

        public static double LengthPoints(Point firstPoint, Point secondPoint)
        {
            return Math.Sqrt(Math.Pow(secondPoint._x - firstPoint._x, 2) + Math.Pow(secondPoint._y - firstPoint._y, 2));
        }
    }
}