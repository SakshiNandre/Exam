using System;
using System.Collections.Generic;
using System.Text;
//WAP to check whether no is divisible by 5 and 11 or not
namespace Exam
{
    class Question5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            double num = double.Parse(Console.ReadLine());
            if (num%5==0 && num%11==0)
            Console.WriteLine("number is divisible by 5 and 11");
            else
            Console.WriteLine("number is not divisible by 5 and 11");
        }
    }
}
