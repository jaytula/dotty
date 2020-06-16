using System;

namespace console_demo
{
  class Program
  {
    static void Main(string[] args)
    {
      switch (args[0])
      {
        case "numbers": Numbers(); break;
        default: HelloWorld(); break;
      }
    }

    static void HelloWorld()
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

      // Do more with strings
      string greeting = "     Hello World!      ";
      Console.WriteLine($"[{greeting}]");
      Console.WriteLine($"[{greeting.TrimStart()}]");
      Console.WriteLine($"[{greeting.TrimEnd()}]");
      Console.WriteLine($"[{greeting.Trim()}]");

      string sayHello = "Hello World";
      Console.WriteLine(sayHello);
      Console.WriteLine(sayHello.Replace("Hello", "Greetings"));
      Console.WriteLine(sayHello.ToUpper());
      Console.WriteLine(sayHello.ToLower());

      // Search strings
      string songLyrics = "You say goodbye, and I say hello";
      Console.WriteLine(songLyrics.Contains("goodbye"));
      Console.WriteLine(songLyrics.Contains("greetings"));

      // Search strings exercise
      Console.WriteLine(songLyrics.StartsWith("You"));
      Console.WriteLine(songLyrics.StartsWith("goodbye"));
      Console.WriteLine(songLyrics.EndsWith("hello"));
      Console.WriteLine(songLyrics.EndsWith("goodbye"));
    }

    static void Numbers()
    {
      int a = 18;
      int b = 6;
      int c = a + b;
      Console.WriteLine(c);

      c = a - b;
      Console.WriteLine(c);

      c = a * b;
      Console.WriteLine(c);

      c = a / b;
      Console.WriteLine(c);

      // Multiplication before addition
      a = 5;
      b = 4;
      c = 2;
      Console.WriteLine(a + b * c);

      // Force order of operations
      Console.WriteLine((a + b) * c);

      Console.WriteLine((a + b) - 6 * c + (12 * 4) / 3 + 12);

      // Integer division produces an integer
      a = 7;
      b = 4;
      c = 3;
      Console.WriteLine((a + b) / c);
    }
  }
}
