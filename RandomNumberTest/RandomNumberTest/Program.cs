using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomNumberTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndValue = new Random();

            bool check = false;
            do
            {
                int rndNumber = rndValue.Next(1,9);
                Console.WriteLine("Random Value is " + rndNumber);
                
            
            }while(check == false);


        }
    }
}
