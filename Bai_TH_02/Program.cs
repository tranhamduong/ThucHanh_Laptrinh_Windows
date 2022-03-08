// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;


namespace Bai_TH_02 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.ReadLine();

            Rectangle rectangle = new Rectangle(5, 8);


            Console.WriteLine("Area: {0}", rectangle.calculateArea());
            Console.WriteLine("Perimeter: {0}", rectangle.calculatePerimeter());

            Console.ReadLine();
            return 1;
        }
    }
}