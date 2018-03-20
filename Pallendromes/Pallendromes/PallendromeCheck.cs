using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pallendromes
{
    class PallendromeCheck
    {
        string checkString = "";
        public static void spaceStripper()
        {
    
        }
        public string recursiveChecking(string sentence, int n)
        {
            string derp = "";
            if (sentence.Length == 1 || sentence.Length == 0)
            {
                derp = "true";
                return derp;
            }
            else if (sentence.StartsWith("") != sentence.EndsWith(""))
            {
                derp = "false";
                return derp;
            }
            else
            {
                sentence = sentence.Remove(0, 1);
                sentence = sentence.Remove(sentence.Length-1,1);
                return recursiveChecking(recursiveChecking(sentence, n+1), n+1);
            }
 
        }
        public PallendromeCheck(string sentence)
        {
            checkString = sentence.Trim().ToLower();
            recursiveChecking(checkString, 0);
        }
    }
}
