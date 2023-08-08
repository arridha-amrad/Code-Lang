using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    public class BankAccount
    {
        public string Number { get; } = string.Empty;
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;

                foreach (var item in this.allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions = new();


        public BankAccount(string name, decimal amount)
        {
            this.Owner = name;
            MakeDeposit(amount, DateTime.Now, "Initial Deposit");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            Console.WriteLine($"Deposit : {amount} for {note}");
            Transaction deposit = new(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficeient funds for this withdrawal");
            }
            Console.WriteLine($"Withdraw : {amount} for {note}");
            Transaction withdrawal = new(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            StringBuilder report = new();
            // HEADER
            report.AppendLine("Date\t\tAmount\tNote");
            foreach (Transaction transaction in allTransactions)
            {
                // ROWS
                report.AppendLine($"{transaction.Date.ToShortDateString()}\t{transaction.Amount}\t{transaction.Notes}");
            }
            return report.ToString();
        }
    }
}
