using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankProject
{
    class MMCAClass : ICheckingAccount, ISavingsAccount
    {
        //variables
        private string firstName;
        private string lastName;
        private string accountNumber;
        private double balance;

        public string firstNameProps
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string lastNameProps
        { get { return lastName; } set { lastName = value; } }

        public string accountNumberProps
        { get { return accountNumber; } set { accountNumber = value; } }

        public double balanceProps
        { get { return balance; } set { balance = value; } }

        //method that withdraws
        public void Withdraw()
        {
        }
        //method that deposits
        public void Deposit()
        {
        }
        //method that calculates interest
        public double CalculateInterest()
        {
            double value = 0;

            return value;
        }
        //method that generates a new string account number
        public string AccountGenerate()
        {
            string accountNumberGen = "";
            for (int i = 0; i <= 7; i++)
            {
                Random rndValue = new Random();
                    int rndNumber = rndValue.Next(1, 9);
                    accountNumberGen += rndNumber.ToString(); 
            }
            return accountNumberGen;
        }
    }
}