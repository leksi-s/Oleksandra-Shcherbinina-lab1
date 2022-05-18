using System;
using Newtonsoft.Json;

namespace лаба1___
{
    class Class
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(12, 10);
            Point p2 = new Point(7, 5);
            Point p3 = new Point(9, 8);
            Triangle triangle = new Triangle(p1,p2,p3);

            Point q1 = new Point(5, 8);
            Point q2 = new Point(1, 4);
            Point q3 = new Point(7, 3);
            Triangle triangle2 = new Triangle(q1, q2, q3);

            double area = triangle.Area();
            Console.WriteLine($"area of the triangle:{area}\n");

            double perimeter=triangle.Perimeter();
            Console.WriteLine($"perimeter of the triangle: {perimeter}\n");

            double h1=triangle.H1();
            double h2=triangle.H2();
            double h3=triangle.H3();
            Console.WriteLine($"heights of the triangle:\nh1={h1}\nh2={h2}\nh3={h3}\n");

            double m1 = triangle.Median1();
            double m2=triangle.Median2();
            double m3=triangle.Median3();
            Console.WriteLine($"medians of the triangle:\nm1={m1}\nm2={m2}\nm3={m3}\n");

            double b1 = triangle.Bi1();
            double b2=triangle.Bi2();
            double b3=triangle.Bi3();
            Console.WriteLine($"bisectrises of the triangle:\nb1={b1}\nb2={b2}\nb3={b3}\n");

            double r = triangle.Round_r();
            double R = triangle.Round_R();
            Console.WriteLine($"radiuses of the triangle:\nr={r}\nR={R}\n");

            string type = triangle.Type();
            string angle=triangle.Angle();
            Console.WriteLine(type);
            Console.WriteLine(angle);
            Console.WriteLine();

            bool equals=triangle.Equals(triangle2);
            Console.WriteLine($"are the two triangles equal? {equals}\n");
            Console.WriteLine("Serialization:");
            Console.WriteLine(p1.Serialize());
            Console.WriteLine(p2.Serialize());
            Console.WriteLine(p3.Serialize());


            Point pp = p1.Deserialize("{\'x\':\'5\',\'y\':\'13\'}");
            Triangle triangle3=new Triangle(p1, p2, pp);
            Console.WriteLine($"New point p3: ({pp.x}; {pp.y})\n");
            triangle3.Area();
            Console.WriteLine($"Deserialization:\nArea of the new triangle: {triangle3.Area()}");
                   
        }
    }
}
