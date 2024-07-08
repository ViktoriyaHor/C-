# C-

BankAccount
Exercise: Create a BankAccount class with accountNumber and balance attributes.
The attributes should be private, and public methods should be provided to deposit and
withdraw money, as well as to get the current balance. Additionally, add a method to transfer
money between two accounts.
Instructions:
1. Create the Class:
○ Define a class named BankAccount.
2. Define Private Attributes:
○ Inside the class, define two private attributes: accountNumber (type
string) and balance (type decimal).
3. Create Public Methods for AccountNumber and Balance:
○
Create a public method GetAccountNumber() to return the value of the
accountNumber attribute.
Create a public method GetBalance() to return the value of the balance
attribute.
4. Create Methods to Deposit and Withdraw Money:
○ Create a public method Deposit(decimal amount) to increase the
○
balance by the value of amount.
○
Create a public method Withdraw(decimal amount) to decrease the
balance by the value of amount. Ensure the amount is not greater than the
balance.
5. Create Method to Transfer Money:
○ Create a public method Transfer(BankAccount targetAccount,
decimal amount) to transfer amount from the current account (this) to
targetAccount.
6. Test the Class:
○ In the Main function, create two instances of BankAccount.
Use the Deposit, Withdraw, and Transfer methods to perform some
transactions and verify the balances.
7. Extra Functionality:
○ Add a method PrintAccountDetails() to print the accountNumber and
○
balance of the account.
