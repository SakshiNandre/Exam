using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Question2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first subject marks:");
            double firstsub = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second subject marks:");
            double secondsub = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter thrid subject marks:");
            double thirdsub = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter fourth subject marks:");
            double fourthsub = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter fifth subject marks:");
            double fifthsub = double.Parse(Console.ReadLine());
            double total = firstsub + secondsub + thirdsub + fourthsub + fifthsub;
            Console.WriteLine("Total is:" + total);
            double average = total / 500;
            Console.WriteLine("average is:" + average);
            double percentage = average * 100;
            Console.WriteLine("Percentage is:" + percentage);
        }
    }
}
