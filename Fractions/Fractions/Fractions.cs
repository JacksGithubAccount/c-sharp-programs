using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fractions
{
    class Fractions
    {
        private int numerator;
        private int denominator;

        public int numeratorProps
        {
            set
            {
                numerator = value;
            }
            get
            {
                return numerator;
            }
        }
        public int denominatorProps
        {
            set
            {
                denominator = value;
            }
            get
            {
                return denominator;
            }
        }

        public Fractions(int num, int denom)
        {
            numerator = num;
            denominator = denom;
        }
        public Fractions()
        {
        }

        public Fractions addition(Fractions second)
        {
            string ops = "Addition";
            Fractions answer = new Fractions();
            answer.numerator = this.numerator * second.denominator + second.numerator * this.denominator;
            answer.denominator = this.denominator * second.denominator;

            answer = this.reduce(answer);
            this.print(answer, ops);

            return answer;
        }
        public Fractions subtract(Fractions second)
        {
            string ops = "Subtraction";
            Fractions answer = new Fractions();
            answer.numerator = this.numerator * second.denominator - second.numerator * this.denominator;
            answer.denominator = this.denominator * second.denominator;

            answer = this.reduce(answer);
            this.print(answer, ops);
            return answer;
        }
        public Fractions multiply(Fractions second)
        {
            string ops = "Multiplication";
            Fractions answer = new Fractions();
            answer.numerator = this.numerator * second.numerator;
            answer.denominator = this.denominator * second.denominator;

            answer = this.reduce(answer);
            this.print(answer, ops);
            return answer;
        }
        public Fractions divide(Fractions second)
        {
            string ops = "Division";
            Fractions answer = new Fractions();
            answer.numerator = this.numerator * second.denominator;
            answer.denominator = second.numerator * this.denominator;

            answer = this.reduce(answer);
            this.print(answer, ops);
            return answer;
        }
        private int GCD(int x, int y)
        {
            int temp;
            while (y != 0)
            {
                temp = y;
                y = x % y;
                x = temp;
            }
            return x;
        }
        private Fractions reduce(Fractions x)
        {
            int gcd;

            gcd = GCD(x.numerator, x.denominator);

            x.numerator = x.numerator / gcd;
            x.denominator = x.denominator / gcd;

            if (x.denominator < 1)
            {
                x.denominator = x.denominator * -1;
                x.numerator = x.numerator * -1;
            }
            return x;
        }
        private void print(Fractions derp, string operant)
        {
            Console.WriteLine(operant + ": " + derp.numerator + "/" + derp.denominator);
        }

    }
}
