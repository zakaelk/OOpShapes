namespace OOpShapes
{
    internal class Triangle : Shape
    {
        private int height;
        private int baseTriangle;
        public Triangle(int h, int b)
        {
            this.height = h;
            this.baseTriangle = b;
        }

        public override double GetArea()
        {
            return this.height * this.baseTriangle / 2;
        }

    }
}