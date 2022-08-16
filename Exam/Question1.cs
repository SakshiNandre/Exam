using System;

namespace Exam
{
    class Question1
    {
        static void Main(string[] args)
        {  
          Console.WriteLine("Enter side value");
            double side = double.Parse(Console.ReadLine());
            double Area = (1.732 / 4) * side * side;
            Console.WriteLine("Area is:" + Area);
        }
    }
}
