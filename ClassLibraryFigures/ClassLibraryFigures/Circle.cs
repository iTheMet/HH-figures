using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle : IForm
    {
        public double radius { get;private set; }
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetАrea()
        {
            return radius = Math.PI * Math.Pow(radius,2);
        }
    }

    public class Triangle : IForm
    {
        public double firstSide { get; private set; }

        public double secondSide { get; private set; }

        public double thirdSide { get; private set; }

        public bool isRectangular { get; private set; }

        public double area { get; private set; }
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
            isRectangular = false;
        }
       
        public double GetАrea()
        {
            double p = (firstSide + secondSide + thirdSide) / 2;
            return area = Math.Sqrt(p*(p - firstSide) * (p - secondSide) * (p - thirdSide));
        }

        public bool IsRectangular()
        {
            return isRectangular = ((Math.Pow(firstSide,2) + Math.Pow(secondSide,2) == Math.Pow(thirdSide,2)) ||
               (Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2) == Math.Pow(secondSide, 2)) ||
               (Math.Pow(thirdSide, 2) + Math.Pow(secondSide, 2) == Math.Pow(firstSide, 2))) ? true : false;
        }
    }
}
