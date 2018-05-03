using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab10
{
    class Circle
    {
        //A=πr^2
        //C=2πr
        private double radius;

        static int counter = 0;
        //private static int count;

        public double Radius { get => radius; set => radius = value; }
        //public static int Count { get => count; set => count = value; }

        //public Circle(int radius)
        //{
        //    this.radius = radius;
        //}
        public Circle(double radius)
        {
            this.Radius = radius;
            //count = Count;
            Interlocked.Increment(ref counter);
        }

        //public static int Counter()
        //{
        //    return Count++;
        //}

        public int CountChecker()
        {
            return counter;
        }

        public double CalculateCircumference()
        {
            return Math.PI * 2 * Radius; 
        }

        public string CalculareFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());

            //return Math.Round(CalculateCircumference(), 2).ToString();
            //return string.Format("{ 0:0.00}", CalculateCircumference());
        }

        public double CalculateArea()
        {
            return Math.PI * (Radius * Radius);
        }

        public string CalculareFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }

        //think this is a helper method
        public string FormatNumber(double x)
        {
            return Math.Round(x, 2).ToString();
        }
    }
}
