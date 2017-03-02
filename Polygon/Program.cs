using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    class Program
    {
        public static void RandomCoordinate(Point[] points)
        {
            Random gen = new Random();
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(gen.Next(1, 15), gen.Next(1, 15));
                Console.WriteLine("ваши точки x={0} и y={1}", points[i].GetCoordinateX(), points[i].GetCoordinateY());
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите кол-во углов: ");
            n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n];
            RandomCoordinate(points);

            Polygon p = new Polygon(points);
            Console.WriteLine(p.GetPerimetr());

            Console.ReadKey();
        }
    }
}
