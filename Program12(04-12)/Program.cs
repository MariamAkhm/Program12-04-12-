using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program12_04_12_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("12.1");
            BankAccount a = new BankAccount(Type.Current, 2345);
            BankAccount b = new BankAccount(Type.Saving, 5678);
            Console.WriteLine(a != b);
            Console.WriteLine(a.Equals(b));

            Console.WriteLine("12.2");
            RationalNumber rationalNumber1 = new RationalNumber(6, 4);
            RationalNumber rationalNumber2 = new RationalNumber(7, 4);
            Console.WriteLine(rationalNumber2==rationalNumber1);
            Console.WriteLine(rationalNumber2!=rationalNumber1);
            Console.WriteLine(rationalNumber2>rationalNumber1);
            Console.WriteLine(rationalNumber1<=rationalNumber2);
            Console.WriteLine(rationalNumber2+rationalNumber1);
            Console.WriteLine(rationalNumber2--);

            Console.WriteLine("12.2.1");
            ComplexNumber complexNumber1 = new ComplexNumber(2, 6);
            ComplexNumber complexNumber2 = new ComplexNumber(5, 3);
            Console.WriteLine(complexNumber2==complexNumber1);
            Console.WriteLine(complexNumber1!=complexNumber2);
            Console.WriteLine(complexNumber2+complexNumber1);
            Console.WriteLine(complexNumber2*complexNumber1);

            Console.WriteLine("13.1");

        }
    }
}
