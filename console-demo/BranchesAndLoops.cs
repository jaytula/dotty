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

      // Use loops to repeat operations
      int counter = 0;
      while (counter < 10)
      {
        Console.WriteLine($"The counter is {counter}");
        counter++;
      }

      counter = 0;
      do
      {
        Console.WriteLine($"The counter is {counter}");
        counter++;
      } while (counter < 10);

      // Work with the for loop

      for (counter = 0; counter < 10; counter++)
      {
        Console.WriteLine($"For Loop counter is {counter}");
      }

      // Created nested loops
      for (int row = 0; row < 11; row++)
      {
        for (char col = 'a'; col < 'k'; col++) {
          Console.WriteLine($"This cell is ({row}, {col})");
        }
      }
    }
  }
}