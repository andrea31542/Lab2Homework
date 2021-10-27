using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2HomeWComplex
{
    struct Complex
    {
        private double real;
        private double imaginary;

        //Constructor 1
        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary; 
        }

        //Constructor 2
        public Complex(double real)
        {
            this.real = real;
            this.imaginary = 0;

        }

        //Property
        public double Re
        {
            get { return real;}
            set
            {
                this.real = value; 
            }
        }

        public double Im
        {
            get { return imaginary;  }
            set
            {
                this.imaginary = value; 
            }
        }

        /**
         * Addition
         */
        public static Complex operator+(Complex c1, Complex c2)
        {
            Complex addition = new Complex(c1.real+c2.real, c1.imaginary+c2.imaginary);
            return addition; 
        }

        /**
         * Subtraction 
         */
        public static Complex operator-(Complex c1, Complex c2)
        {
            Complex subtraction = new Complex(c1.real - c2.real, c1.imaginary - c2.imaginary);
            return subtraction;
        }

        /**
         * Multiplication 
         */
        public static Complex operator*(Complex c1, Complex c2)
        {
            Complex multiplication = new Complex(c1.real*c2.real - c1.imaginary*c2.imaginary, c1.real * c2.imaginary - c1.imaginary * c2.real);
            return multiplication;
        }

        /**
         * Division 
         */
        public static Complex operator/(Complex c1, Complex c2)
        {
            Complex division = new Complex((c1.real * c2.real + c1.imaginary * c2.imaginary)/(c2.Re*c2.Re + c2.Im*c2.Im),
                                         (c2.real * c1.imaginary - c1.real * c2.imaginary) / (c2.Re * c2.Re + c2.Im * c2.Im));
            return division;
        }

        /**
         * ToString override
         */
        public override string ToString()
        {
            return $"{real} + {imaginary}i";
        }

        /**
         * Implicit operator
         */
        public static implicit operator Complex(double number)
        {
            return new Complex(number); 
        }

        /**
         * Static method for sqrt
         */
        public static Complex[] Sqrt(double number)
        {
            double sqrtValue = Math.Sqrt(Math.Abs(number)); 
            Complex[] sqrtArray = new Complex[2]; 
            Complex x1;
            Complex x2;

            if (number >= 0.0)
            {
                x1 = sqrtValue; 
                x2 = -sqrtValue;
              
            }
            else
            {
                x1 = new Complex(0, sqrtValue);
                x2 = new Complex(0, -sqrtValue);

            }; 

            sqrtArray[0] = x1; 
            sqrtArray[1] = x2;

            return sqrtArray; 



        }



    }
}
