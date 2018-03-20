using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankProject
{
    interface ISavingsAccount : BankInterface
    {
        //method heading
        double CalculateInterest();
    }
}
