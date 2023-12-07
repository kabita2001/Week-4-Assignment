using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_08
{
    public struct Point2D 
    {
        public float X { get; set; }
        public float Y {  get; set; }
    }

     public class DistanceCalculator
        {
          public static double CalculateDistance(Point2D point1, Point2D point2)
            {
                float deltaX = point2.X - point1.X;
                float deltaY = point2.Y - point1.Y;

                double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
                return distance;
            }
        }
   



}
