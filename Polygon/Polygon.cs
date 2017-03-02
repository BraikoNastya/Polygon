using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    class Polygon
    {
        Point[] points;
        double[] edgeLengthes;

        static int count = 0;

        public Polygon(Point[] points)
        {
            count++;

            this.points = points;

            edgeLengthes = new double[points.Length];
            for (int i = 0; i < points.Length-1; i++)
            {
                edgeLengthes[i] = new Edge(points[i], points[i + 1]).FindLenghtSegments;// создание ребер и их длины
            }
        }
        public double GetPerimetr()
        {
            double perimetr = 0;
            for (int i = 0; i < edgeLengthes.Length; i++)
            {
                perimetr += edgeLengthes[i];

            }
            return perimetr;
        }
    }
}
