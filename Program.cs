using System;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба1___
{
     public class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
        public Point Deserialize(string json)
        {
            Point p1  = JsonConvert.DeserializeObject<Point>(json);
            return p1;
        }
        public Point Deserialize2(string json)
        {
            Point p2 = JsonConvert.DeserializeObject<Point>(json);
            return p2;
        }
        public Point Deserialize3(string json)
        {
            Point p3 = JsonConvert.DeserializeObject<Point>(json);
            return p3;
        }
    }

    class Triangle
    {
        public Point p1, p2, p3;
        public double a, b, c;
        public Triangle() 
        { 
        }
        private double Length(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        }

        public Triangle(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.a = Length(p1, p2);
            this.b = Length(p2, p3);
            this.c = Length(p1, p3);
        }
        public double Perimeter()
        {
            return a + b + c;
        }
        public double Area()
        {
            double pp = (this.a + this.b + this.c) / 2;
        return Math.Sqrt(pp * (pp - this.a) * (pp - this.b) * (pp * this.c));
         }   

        public double Round_r()
        {
            double pp = (this.a + this.b + this.c) / 2;
            return Math.Sqrt(((pp - a) * (pp - b) * (pp - c)) / pp);
           
        }
        public double Round_R()
        {
            double pp = (this.a + this.b + this.c) / 2;
            return (a * b * c) / 4 * Math.Sqrt(pp * ((pp - a) * (pp - b) * (pp - c)));
        }

        public double H1()
        {
            double pp = (this.a + this.b + this.c) / 2;
            double area = Math.Sqrt(pp * (pp - this.a) * (pp - this.b) * (pp * this.c));
            return 2 * area / a;
        }
        public double H2()
        {
            double pp = (this.a + this.b + this.c) / 2;
            double area = Math.Sqrt(pp * (pp - this.a) * (pp - this.b) * (pp * this.c));
            return 2 * area / b;
        }
        public double H3()
        {
            double pp = (this.a + this.b + this.c) / 2;
            double area = Math.Sqrt(pp * (pp - this.a) * (pp - this.b) * (pp * this.c));
            return 2 * area / c;
        }

        public double Median1()
        {
           return Math.Sqrt(2 * Math.Pow(a, 2) + 2 * Math.Pow(b, 2) - Math.Pow(c, 2));
        }
        public double Median2()
        {
            return Math.Sqrt(2 * Math.Pow(a, 2) + 2 * Math.Pow(c, 2) - Math.Pow(b, 2));
        }
        public double Median3()
        {
            return Math.Sqrt(2 * Math.Pow(c, 2) + 2 * Math.Pow(b, 2) - Math.Pow(a, 2));
        }

        public double Bi1()
        {
            return Math.Sqrt(a * b * (a + b + c) * (a + b - c)) / (a + b);
        }
        public double Bi2()
        {
            return Math.Sqrt(a * c * (a + b + c) * (a + c - b)) / (a + c);
        }
        public double Bi3()
        {
            return Math.Sqrt(c * b * (a + b + c) * (c + b - a)) / (c + b);
        }

        public string Type()
        {
            if (a == b && b == c)
                return "the triangle is equilateral";
            else if (a == b || a == c || b == c)
                return "the triangle is isosceles";
            else
                return "the triangle is versatile";
        }
        public string Angle()
        {
            double cosA = (Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c);
            double cosB = (Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c);
            double cosC = (Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2)) / (2 * b * a);
            if (cosA == 0 || cosB == 0 || cosC == 0)
                return "triangle is rectangular";
            else if (cosA < 0 || cosB < 0 || cosC < 0)
                return "triangle is obtuse-angled";
            else
                return "triangle is acute-angled";
        }
        public bool Equals(ref Triangle first, ref Triangle second)
        {
            return first.a==second.a && first.b==second.b && first.c==second.c;
        }
    }

}
