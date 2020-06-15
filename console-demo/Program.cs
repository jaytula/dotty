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
    }
  }
}
