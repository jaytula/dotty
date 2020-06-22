using System;

using System.Collections.Generic;

namespace console_oop_demo
{
  public class BankAccount
  {
    private static int accountNumberSeed = 1234567890;
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance
    {
      get
      {
        decimal balance = 0;
        foreach (var item in allTransactions)
        {
          balance += item.Amount;
        }

        return balance;
      }
    }
    private List<Transaction> allTransactions = new List<Transaction>();


    public BankAccount(string name, decimal initialBalance)
    {
      this.Owner = name;
      // this.Balance = initialBalance;
      this.Number = accountNumberSeed.ToString();
      accountNumberSeed++;

      MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
      if (amount <= 0)
      {
        throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive" );
      }

      var deposit = new Transaction(amount, date, note);
      allTransactions.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
      if (amount <= 0)
      {
        throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive" );
      }
      if(Balance - amount < 0)
      {
        throw new InvalidOperationException("Not sufficient funds for this withdrawal");
      }
      var withdrawal = new Transaction(-amount, date, note);
      allTransactions.Add(withdrawal);
    }

  }
}