using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public class BankAccount
    {
       public string AccountNumber { get; set; }
       public string AccountHolderName { get; set; }
       public decimal Balance { get; set; }


        public BankAccount(string accountNumber, string accountHolderName, decimal balance)
        {
            Balance = balance;
            AccountNumber= accountNumber; 
            AccountHolderName = accountHolderName;
        } 
        public void DepositMoney(decimal newBalance)
        {
            newBalance += Balance;
        }
        public void WithdrawMoney(decimal withdraw)
        {
            if (Balance >= withdraw)
            {
                Balance -= withdraw;
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
                
        }
    }
}
