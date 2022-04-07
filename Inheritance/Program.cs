using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Account 
            Account myAccount = new Account();
            double currentAmount = 0.0;
            //save money in current account
            currentAmount = myAccount.setAccountBalance(1000.00);
            Console.WriteLine($"current amount: {currentAmount}");
            //withdraw 200.00
            currentAmount = myAccount.withdrawFromAccount(200.00);
            Console.WriteLine($"current amount: {currentAmount}");
            //get balance
            currentAmount = myAccount.getAccountBalance();
            Console.WriteLine($"current amount: {currentAmount}");
            Console.ReadLine();

        }
    }
}
