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
    }
  }
}