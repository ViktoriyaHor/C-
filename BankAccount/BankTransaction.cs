namespace BankAccount;

class BankTransaction
{
    private TransactionType type;
    private double amount;
    private BankAccount account;
    private BankAccount receipt;

    public BankTransaction(BankAccount account, TransactionType type, double amount)
    {
        this.account = account;
        this.type = type;
        this.amount = amount;
    }

    public BankTransaction(BankAccount account, TransactionType type, double amount, BankAccount receipt)
    {
        this.account = account;
        this.type = type;
        this.amount = amount;
        this.receipt = receipt;
    }

    public void SetTransactionType(TransactionType type)
    {
        this.type = type;
    }

    public TransactionType GetTransactionType()
    {
        return this.type;
    }

    public string PerformTransaction()
    {
        Console.WriteLine($"Balance: {this.account.GetBalance()}");

        double accountBalance = this.account.GetBalance();
        double newBalance = accountBalance;
        if (amount < 0)
        {
            return "Amount should be greater than 0";
        }
        switch (this.type)
        {
            case TransactionType.Deposit:
                if (amount > 0)
                    newBalance = accountBalance + amount;
                    this.account.SetBalance(newBalance);
                return $"Transaction type: {this.type} was performed";
                // break;
            case TransactionType.Withdrawal:
                if (amount > accountBalance)
                {
                    newBalance = accountBalance - amount;
                    this.account.SetBalance(newBalance);
                    return $"Transaction type: {this.type} was performed";

                }
                else
                {
                    return "Amount should be greater than current balance";
                }
                // break;
            case TransactionType.Transfer:
                if (amount <= accountBalance)
                {
                    newBalance = accountBalance - amount;
                    double newReceiptBalance = this.receipt.GetBalance() + amount;
                    this.account.SetBalance(newBalance);
                    this.receipt.SetBalance(newReceiptBalance);
                    return $"Transaction type: {this.type} was performed";

                }
                else
                {
                    return "Amount should be greater than current balance";
                }
                // break;
            default:
                return $"Unknown transaction type";
                // break;
                }
    }
}