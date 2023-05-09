namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shapes[] shapes = new Shapes[4];
            shapes[0] = new Shapes();
            shapes[1] = new Circles();
            shapes[2] = new Line();
            shapes[3] = new Triangle();
           
            Circles[] circle = new Circles[1];
            circle[0] = new Circles();
            foreach (var circlee in circle)
            {
                circlee.Draw();
            }

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }

        class Shapes
        {
            // es virtual sachiroa da shemdeg override torem otxive dawers simple shapes
            public virtual void Draw()
            {
                Console.WriteLine("I'm a simple shape");
            }
        }

        class Circles : Shapes
        {
            // overrides nacvlad new ro davwero isev simple shapes dawers
            public  void Draw()
            {
                Console.WriteLine("I'm a circle");
            }
        }

        class Line : Shapes
        {
            public override void Draw()
            {
                Console.WriteLine("I'm a line");
            }
        }

        class Triangle : Shapes
        {
            public override void Draw()
            {
                Console.WriteLine("I'm a triangle");
            }
        }
    }
}