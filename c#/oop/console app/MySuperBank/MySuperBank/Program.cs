namespace MySuperBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new("Alex", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawal(100, DateTime.Now, "Buying car");
            Console.WriteLine($"Account {account.Number} for {account.Owner} with balance: {account.Balance}");

            account.MakeDeposit(200, DateTime.Now, "Sisa THR");
            Console.WriteLine($"Account {account.Number} for {account.Owner} with balance: {account.Balance}");

            string report = account.GetAccountHistory();
            Console.WriteLine(report);
        }
    }
}