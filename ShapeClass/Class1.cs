namespace ShapeClass;

//Define an abstract class Shape with abstract method CalculateSurface() and fields width and height
//Define 2 classes for a triangle and a rectangle, which implement CalculateSurface()
//This method returns the areas of the rectangle and the triangle 
//Define class Circle and its method to calculate area
//Create an array of different shapes and calculate the area of each shape in another array


public abstract class Shape
{
    private double _width;
    private double _height;

    public double Width
    {
        get => _width;
        set => _width = value;
    }

    public double Height
    {
        get => _height;
        set => _height = value;
    }

    public Shape(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public abstract void CalculateSurface();
}

public class Triangle : Shape 
{
    public Triangle(double width, double height) : base(width, height)
    {
    }

    public override void CalculateSurface()
    {
        double area;
        area = this.Width * this.Height / 2; 
        Console.WriteLine("The area of the triangle is {0}", area);
    }
}

public class Rectangle : Shape
{
    public Rectangle(double width, double height) : base(width, height)
    {
    }

    public override void CalculateSurface()
    {
        double area;
        area = this.Height * this.Width;
        Console.WriteLine("The area of the rectangle is {0}", area);
    }
}


public class Circle 
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public void CalculateSurface()
    {
        double area;
        area = 2 * Math.PI * Math.Pow(this.radius, 2);
        Console.WriteLine("The area of the circle is {0}", area);
    }
}



