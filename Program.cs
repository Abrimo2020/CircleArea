using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircleArea
{
    class CircleRectangle
    {
        double radius;

        double pi;
        public void AcceptDetails()
        {
            //length = 2; width = 3;
            pi = 3.14;
            Console.WriteLine("please Enter the radius of the Circle:");
            radius = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
        }
        public double getArea()
        {
            return radius * pi;
        }
        public void Display()
        {
            Console.WriteLine("The the radius of the circle:{0}", radius);
            Console.WriteLine("The Area of circle:{0}", getArea());

        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            CircleRectangle r = new CircleRectangle();
            r.AcceptDetails();
            r.Display();
            //r.Display();
            Console.ReadKey();
        }
    }
}
