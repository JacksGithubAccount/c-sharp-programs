using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fractions
{
    class Program
    {

        static void Main(string[] args)
        {
            string numString;
            string denomString;
            string numstring2;
            string denomString2;
            Fractions secondFrac, firstFrac;
            Fractions answer;
            int numInt, numInt2, denomInt, denomInt2;
            
            //input numbers for fractions
            Console.WriteLine("Input first Numerator:");
            numString = Console.ReadLine();                           
            Console.WriteLine("Input first Denominator:");
            denomString = Console.ReadLine();                
            Console.WriteLine("Input second Numerator:");
            numstring2 = Console.ReadLine();
            Console.WriteLine("Input second Denominator:");
            denomString2 = Console.ReadLine();

            //parse the numbers
                numInt = int.Parse(numString);
                numInt2 = int.Parse(numstring2);

                denomInt = int.Parse(denomString);
                denomInt2 = int.Parse(denomString2);
            
            
            //display fractions
            firstFrac = new Fractions(numInt, denomInt);
            secondFrac = new Fractions(numInt2, denomInt2);
            answer = firstFrac.addition(secondFrac);           
            answer = firstFrac.subtract(secondFrac);
            answer = firstFrac.multiply(secondFrac);
            answer = firstFrac.divide(secondFrac);

            Console.ReadKey();

        }
        }
}

