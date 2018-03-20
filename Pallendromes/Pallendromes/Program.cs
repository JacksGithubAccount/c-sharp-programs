using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pallendromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string checkString;
            Console.WriteLine("Enter a string value here: ");
            checkString = Console.ReadLine();
            PallendromeCheck derp = new PallendromeCheck(checkString);
            Console.ReadKey();
        }
    }
}
