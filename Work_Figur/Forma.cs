using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Figur
{
    public abstract class Forma
    {
        public const double pi = Math.PI;
        protected double x;
        public Forma(double x, double y)
        {
            this.x = x;
        }
        public abstract double Yardage();
    }

    //класс Круга
    public class Lap : Forma
    {
        public Lap(double radius)
            : base(radius, 0)
        {
        }
        public override double Yardage()
        {
            return pi * x * x;
        }

    }

    //класс Квадрата
    public class Quadrate : Forma
    {
        public Quadrate(double height)
            : base(height, 0)
        {
            x = height;
        }

        public override double Yardage()
        {
            return x * x;
        }
    }

    //класс Шара
    public class Ball : Forma
    {
        public Ball(double radius)
           : base(radius, 0)
        {
            x = radius;
        }

        public override double Yardage()
        {
            return 4 * pi * x * x;
        }


    }
}

