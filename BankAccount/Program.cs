namespace BankAccount;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("12345", 150);
        BankAccount receipt = new BankAccount("12348", 150);
        BankTransaction transaction = new BankTransaction(account, TransactionType.Deposit, 200);
        string message = transaction.PerformTransaction();
        Console.WriteLine(message);
        BankTransaction transaction1 = new BankTransaction(account, TransactionType.Transfer, 100, receipt);
        string message1 = transaction1.PerformTransaction();
        Console.WriteLine(message1);
    }
}
