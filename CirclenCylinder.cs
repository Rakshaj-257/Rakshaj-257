using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNew
{
   public class Circle
    {
        public double radius;
        public Circle(double r)
        {
            radius = r;
        }

        public double getArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Cylinder
    {
        public Circle dt;
        public double height;
        public string color;

        public Cylinder(double r, double h, string c)
        {
            dt = new Circle(r);
            height = h;
        }
        public Cylinder(double r, double h)
        {
            dt = new Circle(r);
            height = h;
        }
        public Cylinder(double r)
        {
            dt = new Circle(r);

        }



        public double getVolume()
        {
            return dt.getArea() * height;
        }


    }
    class start
    {
        static void Main(string[] args)
        {
            Cylinder cylinders = new Cylinder(3.55, 9.36, "White");
           
            Cylinder[] circles = { new Cylinder(35),new Cylinder(22.3,20.7),new Cylinder(6.34, 12.0, "Green")};

            Console.WriteLine(circles[1].getVolume());
        }
    }
}

