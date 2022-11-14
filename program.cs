Console.WriteLine("Welcome to the Bank"); // log in C#

BankAccount account = new BankAccount(0); // ('type' 'variable name' = 'creating new, instantiates' 'function' )

// account.balance = 100;
try {
  account.makeDeposit(-2);
} catch(Exception ex){
  Console.WriteLine(ex.Message);
}

Console.Write($"your balance is: {account.getBalance()}");
Console.WriteLine($" Account Number: {account.accountNumber}");



