using System;
namespace OOpShapes
{
    internal class Circle : Shape
    {
    private int radius;
    
    public  Circle(int r)
    {
        this.radius = r;
    }
    public override double GetArea()
    {
        return 3.14 * radius * radius; 
    }
}
}