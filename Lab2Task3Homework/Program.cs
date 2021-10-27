using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2HomeWComplex
{
    class Program
    {
        static void Main(string[] args)
        {

            Complex a = new Complex(1,2);
            Complex b = new Complex(3,4);
            Complex c = new Complex(2, 1);
            Complex d = new Complex(5, 5); 

            //Test 4 operations 
            Console.WriteLine("(" + a + ") + (" + b +") = " + (a + b));
            Console.WriteLine("(" + b + ") - (" + c +") = " + (b - c));
            Console.WriteLine("(" + a + ") * (" + b +") = " + (a * b));
            Console.WriteLine("(" + d + ") / (" + a +") = " + (d / a));

            //Test task 5 
            Complex compl = 5; 
            Console.WriteLine("Implicit operator Complex : " + compl);

            //Task 6
            Console.WriteLine("x1 = " + Complex.Sqrt(4)[0] + ", x2 =  " +  Complex.Sqrt(4)[1]);
            Console.WriteLine("x1 = " + Complex.Sqrt(-4)[0] + ", x2 =  " +  Complex.Sqrt(-4)[1]);

            //Task 8
            QuadraticEquation eq1 = new QuadraticEquation(1,2,-1);
            Console.WriteLine("First root is " + eq1.Roots[0] + " and second is  " + eq1.Roots[1]);

            QuadraticEquation eq2 = new QuadraticEquation(1, 4, 5);
            Console.WriteLine("First root is " + eq2.Roots[0] + " and second is  " + eq2.Roots[1]);

            Console.ReadKey(true);

        }
    }
}
