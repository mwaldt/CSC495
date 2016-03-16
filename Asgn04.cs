using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asgn04_Shapes
{
    public class Program
    {

        static void Main(String[] args)
        {

            AbstractShape[] myShapes = new AbstractShape[16];
            myShapes[0] = new Rectangle(10, 5);
            myShapes[1] = new Rectangle(20, 30);
            myShapes[2] = new Rectangle(50, 10);
            myShapes[3] = new Rectangle(-10, -20);
            myShapes[4] = new Circle(20);
            myShapes[5] = new Circle(10);
            myShapes[6] = new Circle(30);
            myShapes[7] = new Circle(-20);
            myShapes[8] = new Cuboid(20, 10, 6);
            myShapes[9] = new Cuboid(40, 5, 50);
            myShapes[10] = new Cuboid(30, 20, 20);
            myShapes[11] = new Cuboid(-20, 30, -10);
            myShapes[12] = new Sphere(15);
            myShapes[13] = new Sphere(25);
            myShapes[14] = new Sphere(12);
            myShapes[15] = new Sphere(-10);

            for (int i = 0; i < myShapes.Length; i++)
            {
                Console.WriteLine("***********************\n");
                Console.WriteLine("Shape #" + (i + 1));
                myShapes[i].printShapeDimensions();
                Console.WriteLine("Area = " + myShapes[i].Area());
                Console.WriteLine("Perimeter = " + myShapes[i].Perimeter());
                Console.WriteLine("Volume = " + +myShapes[i].Volume());
                Console.WriteLine();
            }
            Console.WriteLine("***********************");
            Console.ReadLine();
        }
    }

    public interface Shape
    {
        double Area();
    }

    public interface TwoDShape : Shape
    {
        double Perimeter();
    }

    public interface ThreeDShape : Shape
    {
        double Volume();
    }

    public abstract class AbstractShape : TwoDShape, ThreeDShape
    {
        private static int numShapesCreated;

        public void IncrementNumShapesCreated()
        {
            numShapesCreated++;
        }

        public int GetNumShapesCreated()
        {
            return numShapesCreated;
        }

        public abstract double Area();
        public abstract double Perimeter();
        public abstract double Volume();
        public abstract void printShapeDimensions();
        
    }


    public class Rectangle : AbstractShape
    {
        private static int NumRectanglesCreated;
        private double length;
        private double width;

        public Rectangle(double len, double wid)
            : base()
        {
            length = len;
            width = wid;
            NumRectanglesCreated++;
        }

        public override double Area()
        {
            return length * width;
        }

        public override double Perimeter()
        {
            return 2 * (length + width);
        }

        public override double Volume()
        {
            return 0.0;
        }
        public override void printShapeDimensions()
        {
            Console.WriteLine("Dimensions: " + this.length + " X " + this.width);
        }
    }

    public class Cuboid : AbstractShape
    {
        private static int NumCuboidsCreated;
        private double length;
        private double width;
        private double height;

        public Cuboid(double len, double wid, double heigh)
            : base()
        {
            length = len;
            width = wid;
            height = heigh;
            NumCuboidsCreated++;
        }

        public override double Area()
        {       //Surface area
            return 2 * (length * width + width * height + length * height);
        }

        public override double Perimeter()
        {
            return 0.0;
        }

        public override double Volume()
        {
            return length * width * height;
        }
        public override void printShapeDimensions()
        {
            Console.WriteLine("Dimensions: " + this.length + " X " + this.width + " X " + this.height);
        }
    }

    public class Circle : AbstractShape
    {
        private static int NumSpheresCreated;
        private double radius;
        private readonly double pi = Math.PI;

        public Circle(double rad)
            : base()
        {
            radius = rad;
            NumSpheresCreated++;
        }

        public override double Area()
        {
            return radius * radius * pi;
        }

        public override double Perimeter()
        {
            return 2 * radius * pi;
        }

        public override double Volume()
        {
            return 0.0;
        }
        public override void printShapeDimensions()
        {
            Console.WriteLine("Dimensions: r = " + this.radius);
        }
    }

    public class Sphere : AbstractShape
    {
        private static int NumSpheresCreated;
        private double radius;
        private readonly double pi = Math.PI;

        public Sphere(double rad)
            : base()
        {
            radius = rad;
            NumSpheresCreated++;
        }

        public override double Area()
        {
            return 4 * radius * radius * pi;
        }

        public override double Perimeter()
        {
            return 0.0;
        }

        public override double Volume()
        {
            return (4 * pi * radius * radius * radius) / 3;
        }

        public override void printShapeDimensions()
        {
            Console.WriteLine("Dimensions: r =" + this.radius);
        }
    }

}
