using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program12_04_12_
{
    class RationalNumber
    {
        public int numerator;
        public int denominator;
        public RationalNumber(int numerator,int denominator)
        {
            this.denominator = denominator;
            this.numerator = numerator;
        }
        public static bool operator == (RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            if (rationalNumber1.Equals(rationalNumber2) && rationalNumber2.Equals(rationalNumber1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            if (rationalNumber1.Equals(rationalNumber2) && rationalNumber2.Equals(rationalNumber1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            if( rationalNumber1.numerator < rationalNumber2.denominator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            if (rationalNumber1.numerator >rationalNumber2.denominator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            if(rationalNumber1.numerator * rationalNumber1.denominator <= rationalNumber2.denominator * rationalNumber1.numerator)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator >=(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            if (rationalNumber1.numerator * rationalNumber1.denominator >= rationalNumber2.denominator * rationalNumber1.numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static RationalNumber operator +(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return new RationalNumber (rationalNumber1.numerator * rationalNumber2.denominator + rationalNumber2.numerator * rationalNumber1.denominator, rationalNumber1.denominator * rationalNumber2.denominator);
        }
        public static RationalNumber operator -(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return new RationalNumber (rationalNumber1.numerator * rationalNumber2.denominator - rationalNumber2.numerator * rationalNumber1.denominator, rationalNumber1.denominator * rationalNumber2.denominator);
        }
        public static RationalNumber operator --(RationalNumber rationalNumber)
        {
            return new RationalNumber(rationalNumber.numerator -1, rationalNumber.denominator-1);
        }
        public static RationalNumber operator ++(RationalNumber rationalNumber)
        {
            return new RationalNumber(rationalNumber.numerator + 1, rationalNumber.denominator+1);
        }
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
    }
}
