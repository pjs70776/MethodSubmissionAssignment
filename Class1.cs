using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Class1
    {
        //method1 takes in two integers
        public int method1(int x, int z = 1)
        {
            int Add = x + z; return Add;      
        }

        //method2 takes in two integers
        public int method2(int a, int b = 5)
        {
            int Add2 = a + b; return Add2;
        }
        //method2 takes either one or two integers
        //public int method3(int a, int b)
        //{
        //    int Subtract = a - 1; return Subtract; &
        //    int Subtract2 = b - Subtract; return Subtract2;
        //}

    }
}
