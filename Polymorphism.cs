using System;

// Base class
class Shape
{
    // Virtual method
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }
}

// Derived class
class Circle : Shape
{
    // Overriding the base class method
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

// Derived class
class Rectangle : Shape
{
    // Overriding the base class method
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle.");
    }
}

// Main class
class Program
{
    static void Main(string[] args)
    {
        // Creating a Shape object
        Shape shape = new Shape();

        // Creating a Circle object
        Circle circle = new Circle();

        // Creating a Rectangle object
        Rectangle rectangle = new Rectangle();

        // Calling the virtual method on the base class
        shape.Draw();

        // Calling the overridden method on the derived class
        circle.Draw();

        // Calling the overridden method on the derived class
        rectangle.Draw();
    }
}
//Polymorphism is the ability of a method or property to behave 
//differently based on the object it is called upon. It allows
// you to define methods in a base class that can be overridden 
//by derived classes. Here is an example of polymorphism in C#:
