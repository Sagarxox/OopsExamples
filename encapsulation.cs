using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace OopsExamples
{

    public class Circle
    {
        // Declare a private field for the radius
        private double radius;

        // Declare a public property for the radius
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        // Declare a method to calculate the circumference
        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }

        // Declare a method to calculate the area
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class TestEncapsulation
    {
        public static void Main()
        {
            Circle circle = new Circle();

            // Set the radius using the property
            circle.Radius = 5;

            // Calculate and print the circumference and area
            Console.WriteLine("Circumference: " + circle.CalculateCircumference());
            Console.WriteLine("Area: " + circle.CalculateArea());
        }
    }
}


//encapsulation is a programming principle that refers to the bundling of data with the methods that
//operate on that data, or the combining of related properties and methods in a single unit
//(such as a class). Encapsulation is used to hide the implementation details of a class from other objects.
//This can be done by declaring the class' fields as private and providing public methods to access and
//modify the fields.

//In this example, the Circle class has a private field radius and a public property Radius that
//be used to access and modify the value of the field. It also has two methods, CalculateCircumference
//and CalculateArea, that use the radius field to perform calculations. By encapsulating the data
//and methods in the Circle class, the implementation details are hidden from other classes and the
//Circle class can be used simply by setting the radius and calling the appropriate methods.