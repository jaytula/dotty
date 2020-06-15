using System;

namespace console_demo
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      string aFriend = "Bill";
      Console.WriteLine(aFriend);

      Console.WriteLine("Hello " + aFriend);
      Console.WriteLine($"Hello {aFriend}");

      string firstFriend = "Maria";
      string secondFriend = "Sage";
      Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

      Console.WriteLine($"The name {firstFriend} had {firstFriend.Length} letters.");
      Console.WriteLine($"The name {secondFriend} had {secondFriend.Length} letters.");

    }
  }
}
