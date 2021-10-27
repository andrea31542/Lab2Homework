using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace L2HomeWComplex
{
    class QuadraticEquation
    {
        // Hide element
        private double a;
        private double b;
        private double c;

        public QuadraticEquation()
        {
            // by default a, b, c is 0 
        }

        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;  // "this" it is from object 
            this.b = b;
            this.c = c;

        }

        //Property ili svojstvo, special method for clients
        public double A
        {
            // we can use get and set method
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            // we can use get and set method
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            // we can use get and set method
            get { return c; }
            set { c = value; }
        }

        public double Y(double x)
        {
            return a * x * x + b * x + c;
        }

        public double Discriminant
        {
            get { return b * b - 4 * a * c; } // We could use upper case, it would use property 
        }

        public Complex[] Roots
        {
            get
            {
                Complex[] sqrtDisc = Complex.Sqrt(Discriminant);
                Complex[] results = {(-B + sqrtDisc[0]) / (2 * a), (-B + sqrtDisc[1]) / (2 * a) };
                return results; 
            }
        }
    }
}
