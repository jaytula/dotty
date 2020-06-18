using System;

namespace console_demo
{
  class BranchesAndLoops
  {
    public static void BranchesAndLoopsMain()
    {
      Console.WriteLine("Branches and Loops");

      int a = 5;
      int b = 6;
      if (a + b > 10)
        Console.WriteLine("The answer is greater than 10");

      b = 3;
      if (a + b > 10)
        Console.WriteLine("The answer is greater than 10");

      // Make if and else work together
      a = 5;
      b = 3;

      if (a + b > 10)
      {
        Console.WriteLine("The answer is greater than 10");
      }
      else
      {
        Console.WriteLine("The answer is not greater than 10");
      }

      int c = 4;
      if ((a + b + c > 10) || (a == b))
      {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("Or the first number is equal to the second");
      }
      else
      {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("And the first number is not equal to the second");
      }
    }
  }
}