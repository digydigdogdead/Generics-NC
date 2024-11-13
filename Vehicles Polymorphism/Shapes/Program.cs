using Shapes._3D_Shapes;
using System.ComponentModel.Design.Serialization;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Shape> shapes = new List<Shape>{
            //    new Circle(5),
            //    new Rectangle(2, 5),
            //    new Triangle(3, 7)
            //};

            //foreach (Shape shape in shapes)
            //{
            //    Console.WriteLine(shape.GetType().Name + " area = " + shape.CalculateArea());
            //}

            //List<Shape3D> shapes3d = new List<Shape3D>();

            //foreach (Shape shape in shapes)
            //{
            //    if (shape is Circle circle)
            //    {
            //        shapes3d.Add(new Sphere(circle));
            //        shapes3d.Add(new Cylinder(circle, 5));
            //        shapes3d.Add(new Cone(circle, 5));
            //    }
            //    else if (shape is Triangle triangle)
            //    {

            //        shapes3d.Add(new Prism(triangle, 5));
            //        shapes3d.Add(new Pyramid(triangle, 5));
            //    }
            //}
            //foreach (Shape3D shape3d in shapes3d)
            //{
            //    Console.WriteLine(shape3d.GetType().Name + " with " +
            //    shape3d.BaseShape.GetType().Name + " base | Volume = " +
            //    shape3d.CalculateVolume());
            //}

            //Prism regularPrism = new Prism(new Triangle(2, 2), 2);

            //Prism circularPrism = new Prism(new Circle(2), 2);

            //double regularPrismVolume = regularPrism.CalculateVolume();
            //Console.WriteLine(regularPrismVolume);

            //double circularPrismVolume = circularPrism.CalculateVolume();
            //Console.WriteLine(circularPrismVolume);

            //Prism rectangularPrism = new Prism(new Rectangle(2, 2), 2);
            //double rectangularPrismVolume = rectangularPrism.CalculateVolume();
            //Console.WriteLine(rectangularPrismVolume);

            //Console.WriteLine(circularPrism.CalculateVolume());

            //Octahedron d8 = new Octahedron(new Triangle(2, 2));
            //Console.WriteLine(d8.CalculateVolume());
            //Console.WriteLine(d8.Roll());
            //Console.WriteLine(d8.Roll());

            //PentagonalTrapezohedron d10 = new PentagonalTrapezohedron(new Kite(3, 6, 30));
            //Console.WriteLine(d10.CalculateVolume());
            //Console.WriteLine(d10.Roll());
            //Console.WriteLine(d10.Roll());

            //RegularPentagon testPent = new RegularPentagon(3);
            //Console.WriteLine(testPent.CalculateArea());

            //RegularDodecahedron d12 = new RegularDodecahedron(new RegularPentagon(1));
            //Console.WriteLine(d12.CalculateVolume());
            //Console.WriteLine(d12.Roll());
            //Console.WriteLine(d12.Roll());

            RegularIcosahedron d20 = new RegularIcosahedron(new Triangle(3, 2.6));
            Console.WriteLine(d20.CalculateVolume());
            Console.WriteLine(d20.Roll());
            Console.WriteLine(d20.Roll());
        }
    }
}
