using System;
namespace OOpShapes
{
    internal class Square : Shape
    {
        private int side;

        public Square(int a)
        {
            this.side = a;
        }
        public override double GetArea()
        {
            return  this.side * this.side;
        }
    }
}