using System;

namespace InheritanceExample
{
    // The base class is called "Shape"
    public class Shape
    {
        // A property for the shape's color
        public string Color { get; set; }

        // A method to calculate the area of the shape
        public virtual double CalculateArea()
        {
            return 0;
        }
    }

    // The "Rectangle" class is a subclass of "Shape"
    public class Rectangle : Shape
    {
        // Properties for the length and width of the rectangle
        public double Length { get; set; }
        public double Width { get; set; }

        // Override the base class's "CalculateArea" method
        public override double CalculateArea()
        {
            return Length * Width;
        }
    }

    // The "Circle" class is also a subclass of "Shape"
    public class Circle : Shape
    {
        // Property for the radius of the circle
        public double Radius { get; set; }

        // Override the base class's "CalculateArea" method
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // The "Triangle" class is also a subclass of "Shape"
    public class Triangle : Shape
    {
        // Properties for the base and height of the triangle
        public double Base { get; set; }
        public double Height { get; set; }

        // Override the base class's "CalculateArea" method
        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Now we can create objects of each of these subclasses
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();
            Triangle triangle = new Triangle();

            // Set the properties of the objects
            rectangle.Length = 10;
            rectangle.Width = 5;
            circle.Radius = 3;
            triangle.Base = 4;
            triangle.Height = 6;

            // Call the "CalculateArea" method on each of them
            double rectangleArea = rectangle.CalculateArea();
            double circleArea = circle.CalculateArea();
            double triangleArea = triangle.CalculateArea();

            // Print the results
            Console.WriteLine("Rectangle area: " + rectangleArea);
            Console.WriteLine("Circle area: " + circleArea);
            Console.WriteLine("Triangle area: " + triangleArea);
        }
    }
}

//heritance is a feature of object-oriented programming languages
// that allows one class to inherit properties and methods from another
//class. This can be useful for creating a hierarchy of classes, where
// a subclass can inherit properties and methods from a superclass and 
//then add or override them as needed.