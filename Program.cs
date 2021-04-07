using System;

namespace Methods_For_Geometric_Area_Perimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double circle1Radius = 1.0;
            double circle1Area = GetArea(circle1Radius); // 3.14159...
            double circle1Perimeter = GetPerimeter(circle1Radius); // 6.28318...
            Console.WriteLine("Circle 1      Area: " + circle1Area);
            Console.WriteLine("Circle 1 Perimeter: " + circle1Perimeter);
            Console.WriteLine();

            double rectangleLength = 2.0;
            double rectangleWidth = 3.0;
            double rectangleArea = GetArea(rectangleLength, rectangleWidth);
            double rectanglePerimeter = GetPerimeter(rectangleLength, rectangleWidth);
            Console.WriteLine("Rectangle      Area: {0}", rectangleArea);
            Console.WriteLine("Rectangle Perimeter: {0}", rectanglePerimeter);
            Console.WriteLine();

            double triangleSideA = 4.0;
            double triangleSideB = 5.0;
            double triangleSideC = 6.0;
            double triangleArea = GetArea(triangleSideA, triangleSideB, triangleSideC);
            double trianglePerimeter = GetPerimeter(triangleSideA, triangleSideB, triangleSideC);
            Console.WriteLine($"Triangle      Area: {triangleArea}");
            Console.WriteLine($"Triangle Perimeter: {trianglePerimeter}");
            Console.WriteLine();

            (circle1Area, circle1Perimeter) = GetAreaAndPerimeter(1.0);
            Console.WriteLine($"Circle 1      Area: {circle1Area}");
            Console.WriteLine($"Circle 1 Perimeter: {circle1Perimeter}");
            Console.WriteLine();
        }

        static double GetArea(double radius) // Circle
        {
            double circle1Area = Math.PI*(radius * radius);
            return circle1Area;



        }

        static double GetArea(double length, double width) // Rectangle
        {

            double rectangleArea = (2 * length) + (2 * width);
            return rectangleArea;



        }

        static double GetArea(double a, double b, double c) // Triangle
        {

            double triangleArea = (a * a) + (b * b) /2;
            return triangleArea;



        }

        static double GetPerimeter(double radius) // Circle
        {
            double circle1Perimeter = Math.PI * 2 * radius;
            return circle1Perimeter;

        }

        static double GetPerimeter(double length, double width) // Rectangle
        {

            double rectanglePerimeter = (2 * length) + (2 * width);
            return rectanglePerimeter;
        }

        static double GetPerimeter(double a, double b, double c) // Triangle
        {
            double trianglePerimeter = a + b + c;
            return trianglePerimeter;


        }

        static (double area, double perimeter) GetAreaAndPerimeter(double radius) // Circle
        {

            double circle1Area = Math.PI * radius * radius;
            double circle1Perimeter = 2 * Math.PI * radius;
            return (circle1Area, circle1Perimeter);




        }

        static (double area, double perimeter) GetAreaAndPerimeter(double length, double width) // Rectangle
        {
            double rectangleArea = length * width;
            double rectanglePerimeter = (2 * length) + (2 * width);
            return (rectangleArea, rectanglePerimeter);


        }

        static (double area, double perimeter) GetAreaAndPerimeter(double a, double b, double c) // Triangle
        {
            double triangleArea = (a * a) + (b * b) /2;
            double trianglePerimeter = a + b + c;
            return (triangleArea , trianglePerimeter);

        }
    }
}

