# Entity_Business_Rules

The BankAccount Entity represents a bank account. The code implements specific operations through methods and properties. It must supports below behaviour:
1.	It has a 10-digit number that uniquely identifies the bank account.
2.	It has a string that stores the name of owner.
3.	The balance can be retrieved.
4.	It accepts deposits.
5.	The initial balance must be Zero (positive).
6.	It does not allow negative amount to deposit.

 

Class Name: Transaction

 
Method:

          public Transaction(decimal amount, DateTime date, string note)

{}

Property:

    public decimal Amount { get; }

    public DateTime Date { get; }

    public string Notes { get; }

=================

Class Name: BankAccount

 
Method:

          public void MakeDeposit(decimal amount, DateTime date, string note)

    {


// 1) if the amount of the deposit isn't greater than 1, should throw                     ArgumentOutOfRangeException() exception
 

//2) else, create transaction object and add into collection (allTransactions)

 

// 3) maximum transaction limit per account holder is 3, if account holder try more than that, then throw custom exception (TransactionLimitReachedException)

 
 }


Property:

public string Number { get; }

    public string Owner { get; set; }

    public decimal Balance { get; }

   private List<Transaction> allTransactions = new List<Transaction>();

