using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //method 1
            Console.WriteLine("Enter either one or two numbers to be added to 5");
            int additon = Convert.ToInt32(Console.ReadLine()); //not in correct format, will only take one integer
            int sum = Class1.method1(additon, additon);
            Console.WriteLine(sum + " is the answer.");

            //user input two numbers, one at a time
            Console.WriteLine("Enter two numbers, one at a time. You dont't need to input a second number if you dont't want too.");
            int subtraction = Convert.ToInt32(Console.ReadLine());
            int difference = Class1.method2(subtraction, subtraction);
            Console.WriteLine(difference + " is the answer.");

            Console.ReadLine();
        }
    }
}
