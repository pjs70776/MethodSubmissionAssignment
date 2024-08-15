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
            Class1 c1 = new Class1();

            //method 1, 2 inputs
            Console.WriteLine("Enter first mandatory integer here:");
            int additon = Convert.ToInt32(Console.ReadLine()); 
            

            Console.WriteLine("Enter second optional integer here:");
            //try catch statement
            try
            {
                int additon2 = Convert.ToInt32(Console.ReadLine());
                int sum2 = c1.method1(additon,additon2);
                Console.WriteLine(sum2 + " is the answer.");
            }
            catch (Exception ex) 
            {
                int sum2 = c1.method1(additon);
                Console.WriteLine(sum2 + " is the answer.");
            }
            Console.ReadLine();


            //ask user to input two numbers. also, let user know they dont need to enter anything for the second number
            Console.WriteLine("Please enter first number:");
            int additon3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You can enter an integer here, but you dont need too:");
            //try catch statement
            try
            {
                int additonA = Convert.ToInt32(Console.ReadLine());
                int sum3 = c1.method2(additon3, additonA);
                Console.WriteLine(sum3 + " is the answer.");
            }
            catch (Exception ex)
            {
                int sum3 = c1.method2(additon3);
                Console.WriteLine(sum3 + " is the answer.");
            }
            Console.ReadLine();
        }
    }
}
