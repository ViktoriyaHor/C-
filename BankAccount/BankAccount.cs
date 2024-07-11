namespace BankAccount;

class BankAccount{
    private string accountNumber;
    private double balance;


    public BankAccount(string accountNumber, double balance){
        this.accountNumber = accountNumber;
        this.balance = balance;
    }

    public string GetAccountNumber(){
        return this.accountNumber;
    }

    public double GetBalance(){
        return this.balance;
    }

    public void SetBalance(double newBalance){
        this.balance = newBalance;
    }
}