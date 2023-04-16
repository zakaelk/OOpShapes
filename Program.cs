namespace OOpShapes;
class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square(5);
        Shape square2 = new Square(2);
        Circle circle1 = new Circle(5);
        Triangle triangle = new Triangle(3, 4);

        Console.WriteLine($"Area of the square: {square1.GetArea()}");
        Console.WriteLine($"Area of the square: {square2.GetArea()}");
        Console.WriteLine($"Area of the circle: {circle1.GetArea()}");
        Console.WriteLine($"Area of the triangle: {triangle.GetArea()}");
    }
}
