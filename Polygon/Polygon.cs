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
        double area;
        public Polygon(Point[] points)
        {            
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
        public double Area()
        {
            double S1 = 0;
            double S2 = 0;
            for (int i = 0; i < points.Length; i++)
            {
                if (i < points.Length - 1)
                {
                    S1 += points[i].GetCoordinateX() * points[i + 1].GetCoordinateY();
                }
                else
                {
                    S1 += points[i].GetCoordinateX() * points[0].GetCoordinateY();
                }
            }
            for (int i = 0; i < points.Length; i++)
            {
                if (i < points.Length - 1)
                {
                    S2 += points[i].GetCoordinateY() * points[i + 1].GetCoordinateX();
                }
                else
                {
                    S2 += points[i].GetCoordinateY() * points[0].GetCoordinateX();
                }
            }
            return area = (S1 - S2) / 2;
        }
    }
}
