using System;

namespace console_oop_demo
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var account = new BankAccount("<name>", 1000);
      Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
    }
  }
}
