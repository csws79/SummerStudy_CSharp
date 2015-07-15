using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythonToCSharp
{
    abstract class Shape
    {
        public double area;
        public double perimeter;
        public double volume;
        public double defaultSize;
        public int info;

        public abstract void calcArea(double defaultSize);
        public abstract void calcPerimeter(double defaultSize);
        public abstract void calcVolume(double defaultSize);
        public abstract void print2();
        public abstract void print3();
    }

    class TwoDim : Shape
    {
        public override void calcArea(double defaultSize) { }
        public override void calcPerimeter(double defaultSize) { }
        public override void calcVolume(double defaultSize) { }
        public override void print2() { }
        public override void print3() { }
    }
    
    class Square : TwoDim
    {
        public Square(double defaultSize)
        {
            this.defaultSize = defaultSize;
            info = 1;
        }
        public override void calcPerimeter(double defaultSize)
        {
            perimeter = defaultSize * 4;
        }
        public override void calcArea(double defaultSize)
        {
            area = defaultSize * defaultSize;
        }
        public override void print2()
        {
            Console.WriteLine("The perimeter of Square is " + perimeter.ToString());
            Console.WriteLine("The area of Square is " + area.ToString());
        }
    }

    class Triangle : TwoDim
    {
        public Triangle(double defaultSize)
        {
            this.defaultSize = defaultSize;
            info = 2;
        }
        public override void calcPerimeter(double defaultSize)
        {
            perimeter = defaultSize * 3;
        }
        public override void calcArea(double defaultSize)
        {
            double rT = Math.Sqrt(3);
            area = defaultSize * defaultSize * rT / 4.0;
        }
        public override void print2()
        {
            Console.WriteLine("The perimeter of Triangle is " + perimeter.ToString());
            Console.WriteLine("The area of Triangle is " + area.ToString());
        }
    }

    class Circle : TwoDim
    {
        public Circle(double defaultSize)
        {
            this.defaultSize = defaultSize;
            info = 3;
        }
        public override void calcPerimeter(double defaultSize)
        {
            perimeter = 2 * 3.14 * defaultSize;
        }
        public override void calcArea(double defaultSize)
        {
            area = 3.14 * defaultSize * defaultSize;
        }
        public override void print2()
        {
            Console.WriteLine("The perimeter of Circle is " + perimeter.ToString());
            Console.WriteLine("The area of Circle is " + area.ToString());
        }
    }

    class ThreeDim : Shape
    {
        public override void calcArea(double defaultSize) { }
        public override void calcPerimeter(double defaultSize) { }
        public override void calcVolume(double defaultSize) { }
        public override void print2() { }
        public override void print3() { }
    }

    class Cube : ThreeDim
    {
        public Cube(double defaultSize)
        {
            this.defaultSize = defaultSize;
            info = 4;
        }
        public override void calcArea(double defaultSize)
        {
            area = defaultSize * defaultSize * 6;
        }
        public override void calcVolume(double defaultSize)
        {
            volume = defaultSize * defaultSize * defaultSize;
        }
        public override void print3()
        {
            Console.WriteLine("The volume of Cube is " + volume.ToString());
            Console.WriteLine("The area of Cube is " + area.ToString());
        }
    }

    class Sphere : ThreeDim
    {
        public Sphere(double defaultSize)
        {
            this.defaultSize = defaultSize;
            info = 5;
        }
        public override void calcArea(double defaultSize)
        {
            area = 4.0 * 3.14 * defaultSize * defaultSize;
        }
        public override void calcVolume(double defaultSize)
        {
            volume = 4.0 / 3.0 * 3.14 * defaultSize * defaultSize * defaultSize;
        }
        public override void print3()
        {
            Console.WriteLine("The volume of Sphere is " + volume.ToString());
            Console.WriteLine("The area of Sphere is " + area.ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<TwoDim> twoList = new List<TwoDim>();
            List<ThreeDim> threeList = new List<ThreeDim>();
            int count = 0;
            while(true)
            {
                int n;
                Console.WriteLine("1. Square 2. Triangle 3. Circle 4. Cube 5. Sphere 6. Exit");
                n = Int32.Parse(Console.ReadLine());
                if(n == 1)
                {
                    Console.WriteLine("Input Side of Shape: ");
                    double defaultSize = Int32.Parse(Console.ReadLine());
                    
                    foreach (TwoDim two in twoList)
                    {
                        if (two.info == n && two.defaultSize == defaultSize)
                        {
                            Console.WriteLine("Already existed");
                            count = 1;
                            break;
                        }
                    }
                    TwoDim squ = new Square(defaultSize);
                    squ.calcPerimeter(defaultSize);
                    squ.calcArea(defaultSize);
                    twoList.Add(squ);
                    if (count == 0)
                    {
                        squ.print2();
                    }
                    count = 0;
                    Console.WriteLine();
                }
                else if(n == 2)
                {
                    Console.WriteLine("Input Side of Shape: ");
                    double defaultSize = Int32.Parse(Console.ReadLine());

                    foreach (TwoDim two in twoList)
                    {
                        if (two.info == n && two.defaultSize == defaultSize)
                        {
                            Console.WriteLine("Already existed");
                            count = 1;
                            break;
                        }
                    }
                    TwoDim tri = new Triangle(defaultSize);
                    tri.calcPerimeter(defaultSize);
                    tri.calcArea(defaultSize);
                    twoList.Add(tri);
                    if (count == 0)
                    {
                        tri.print2();
                    }
                    count = 0;
                    Console.WriteLine();
                }
                else if(n == 3)
                {
                    Console.WriteLine("Input Side of Shape: ");
                    double defaultSize = Int32.Parse(Console.ReadLine());

                    foreach (TwoDim two in twoList)
                    {
                        if (two.info == n && two.defaultSize == defaultSize)
                        {
                            Console.WriteLine("Already existed");
                            count = 1;
                            break;
                        }
                    }
                    TwoDim cir = new Circle(defaultSize);
                    cir.calcPerimeter(defaultSize);
                    cir.calcArea(defaultSize);
                    twoList.Add(cir);
                    if (count == 0)
                    {
                        cir.print2();
                    }
                    count = 0;
                    Console.WriteLine();
                }
                else if(n == 4)
                {
                    Console.WriteLine("Input Side of Shape: ");
                    double defaultSize = Int32.Parse(Console.ReadLine());

                    foreach (ThreeDim three in threeList)
                    {
                        if (three.info == n && three.defaultSize == defaultSize)
                        {
                            Console.WriteLine("Already existed");
                            count = 1;
                            break;
                        }
                    }
                    ThreeDim cub = new Cube(defaultSize); 
                    cub.calcArea(defaultSize);
                    cub.calcVolume(defaultSize);
                    threeList.Add(cub);
                    if (count == 0)
                    {
                        cub.print3();
                    }
                    count = 0;
                    Console.WriteLine();
                }
                else if(n == 5)
                {
                    Console.WriteLine("Input Side of Shape: ");
                    double defaultSize = Int32.Parse(Console.ReadLine());

                    foreach (ThreeDim three in threeList)
                    {
                        if (three.info == n && three.defaultSize == defaultSize)
                        {
                            Console.WriteLine("Already existed");
                            count = 1;
                            break;
                        }
                    }
                    ThreeDim sph = new Sphere(defaultSize);
                    sph.calcArea(defaultSize);
                    sph.calcVolume(defaultSize);
                    threeList.Add(sph);
                    if (count == 0)
                    {
                        sph.print3();
                    }
                    count = 0;
                    Console.WriteLine();
                }
                else if(n == 6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
    }
}
