using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program12_04_12_
{
    class ComplexNumber
    {
        public double real;
        public double imaginary;
        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public static bool operator ==(ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            if (complexNumber1.Equals(complexNumber2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            if (complexNumber1.Equals(complexNumber2))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static ComplexNumber operator +(ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            return new ComplexNumber(complexNumber1.real+complexNumber2.real, complexNumber2.imaginary+complexNumber1.imaginary);
        }
        public static ComplexNumber operator -(ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            return new ComplexNumber(complexNumber1.real - complexNumber2.real, complexNumber2.imaginary - complexNumber1.imaginary);
        }
        public static ComplexNumber operator *(ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            return new ComplexNumber(complexNumber1.real*complexNumber2.real-(complexNumber2.imaginary*complexNumber1.imaginary), complexNumber2.imaginary * complexNumber1.imaginary-(complexNumber2.imaginary*complexNumber1.real));
        }
        public override string ToString()
        {
            return $"{real},{imaginary}";
        }
    }
}
