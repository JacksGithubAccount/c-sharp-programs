using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesnocheck;
            MMCAClass[] bankArray = new MMCAClass[10]{new MMCAClass(), new MMCAClass(), 
                new MMCAClass(),new MMCAClass(),new MMCAClass(),new MMCAClass(),new MMCAClass(),
                new MMCAClass(),new MMCAClass(),new MMCAClass()};
            MMCAClass bankAccount = new MMCAClass();
            //saves the account array information
            System.IO.StreamWriter fileWrite = new System.IO.StreamWriter("accounts.txt");
            //loads the information
            System.IO.StringReader fileRead = new System.IO.StringReader("accounts.txt");
            string freeAccount = "";
            int freeAccountInt;
            for (int strNumber = 0; strNumber <= bankArray.Length; strNumber++)
            {
                freeAccount = fileRead.ReadLine();
                freeAccountInt = int.Parse(freeAccount);
                fileRead.ReadLine() = bankArray[freeAccount].firstNameProps;
                fileRead.ReadLine() = bankArray[freeAccount].lastNameProps;
                fileRead.ReadLine() = bankArray[freeAccount].accountNumberProps;
                fileRead.ReadLine() = bankArray[freeAccount].balanceProps;
            }
            //menu
            Console.WriteLine("Do you have an existing bank account?" + Environment.NewLine +
            "[1] - Yes" + Environment.NewLine + "[2] - No" + Environment.NewLine);
            yesnocheck = Console.ReadLine();

            if (yesnocheck == "2")
            {
                Console.WriteLine("Would you like to create a bank Account?" + Environment.NewLine +
                    "[1] - Yes" + Environment.NewLine + "[2] - No" +
                    Environment.NewLine);
                yesnocheck = Console.ReadLine();
                if (yesnocheck == "1")
                {
                   bankAccount.accountNumberProps = bankAccount.AccountGenerate();
                   Console.WriteLine("Please input your first name:" + Environment.NewLine);
                   bankAccount.firstNameProps = Console.ReadLine();
                   Console.WriteLine("Please input your last name:" + Environment.NewLine);
                   bankAccount.lastNameProps = Console.ReadLine();
                   Console.WriteLine(Environment.NewLine + "First Name: " + bankAccount.firstNameProps
                       + Environment.NewLine + "Last Name: " + bankAccount.lastNameProps + Environment.NewLine +
                       "Account Number: " + bankAccount.accountNumberProps + Environment.NewLine);
                   Console.ReadKey();
                    //store the information into a free account
                   int freeAccount = -1; 
                   for (int strNumber = 0; strNumber <= bankArray.Length; strNumber++)
                   {
                       if (bankArray[strNumber].accountNumberProps == null)
                       {
                           freeAccount = strNumber;
                       }
                       if (freeAccount == strNumber)
                       {
                           break;
                       }
                   }
                   bankArray[freeAccount].firstNameProps = bankAccount.firstNameProps;
                   bankArray[freeAccount].lastNameProps = bankAccount.lastNameProps;
                   bankArray[freeAccount].accountNumberProps = bankAccount.accountNumberProps;
                   fileWrite.WriteLine(freeAccount.ToString(), bankArray[freeAccount].firstNameProps, bankArray[freeAccount].lastNameProps,
                       bankArray[freeAccount].accountNumberProps, bankArray[freeAccount].balanceProps);
                   Console.WriteLine("What would you like to do?" + Environment.NewLine +
                       "[1] - check balance" + Environment.NewLine + "[2] - deposit" + Environment.NewLine +
                       "[3] - withdraw" + Environment.NewLine + "[4] - Calculate interest");
                   yesnocheck = Console.ReadLine();
                   if (yesnocheck == "1")
                   {
                       Console.WriteLine("Your balance is: " + bankArray[freeAccount].balanceProps + " usd");
                       Console.ReadKey();
                   }
                   if (yesnocheck == "2")
                   {
                       string depoString;
                       int depositValue =0
                           ;
                       Console.WriteLine("How much would you like to deposit?");
                       try
                       {
                           depoString = Console.ReadLine();
                           depositValue = int.Parse(depoString);
                       }
                       catch
                       {
                           Console.WriteLine("Please input a numeric value here that you want to deposit");
                       }
                       bankAccount.balanceProps = bankAccount.balanceProps + depositValue;
                       bankArray[freeAccount].balanceProps = bankAccount.balanceProps;
                       fileWrite.WriteLine(bankArray[freeAccount].balanceProps);
                       Console.WriteLine("Deposit Successful!" + Environment.NewLine + "Current Balance: "
                           + bankAccount.balanceProps + " usd");
                       Console.ReadKey();
                   }
                   if (yesnocheck == "3")
                   {
                       string withString;
                       int withdrawValue = 0;
                       Console.WriteLine("How much would you like to withdraw?");
                       try
                       {
                           withString = Console.ReadLine();
                           withdrawValue = int.Parse(withString);
                       }
                       catch
                       {
                           Console.WriteLine("Please input a numeric value here that you want to withdraw");
                       }
                       bankAccount.balanceProps = bankAccount.balanceProps - withdrawValue;
                       bankArray[freeAccount].balanceProps = bankAccount.balanceProps;
                       Console.WriteLine("Withdraw Successful!" + Environment.NewLine + "Current Balance: "
                           + bankAccount.balanceProps + " usd");
                       fileWrite.WriteLine(bankArray[freeAccount].balanceProps);
                       Console.ReadKey();
                   }
                   if (yesnocheck == "4")
                   {
                       Console.WriteLine("Your interest rate is X where X is this bank's interest rate");
                   }
                }
                else
                {
                    Console.WriteLine("There's nothing else to be done here. Have a good day!");
                    Console.ReadKey();
                }
            }
            else
            {
                string accountString;
                Console.WriteLine("What is your account number?");
                accountString = Console.ReadLine();
                int strIndex = 0;
                for (int strNumber = 0; strNumber < bankArray.Length; strNumber++)
                {
                    if (accountString == bankArray[strNumber].accountNumberProps)
                    {
                        bankAccount.accountNumberProps = bankArray[strNumber].accountNumberProps;
                        bankAccount.balanceProps = bankArray[strNumber].balanceProps;
                        bankAccount.firstNameProps = bankArray[strNumber].firstNameProps;
                        bankAccount.lastNameProps = bankArray[strNumber].lastNameProps;
                    }
                    if (strIndex >= 0)
                    {
                        break;
                    }
                }
                Console.WriteLine(Environment.NewLine + Environment.NewLine + "Is this your account?"
                    + Environment.NewLine + "First Name: " + bankAccount.firstNameProps + Environment.NewLine
                    + "Last Name: " + bankAccount.lastNameProps + Environment.NewLine + "[1] - Yes" + Environment.NewLine
                        + "[2] - No");
                yesnocheck = Console.ReadLine();

            }

        }
    }
}