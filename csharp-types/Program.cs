using System;

namespace csharp_types
{
    class Program
    {
        static void Main(string[] args)
        {
          TypesVarsValues();
        }


        // C# compiler makes sure all operations are type-safe.
        // C# is a strongly typed language
        static void TypesVarsValues()
        {
          int a = 5;
          int b = a + 2; // OK

          bool test = true;

          Console.WriteLine($"b is {b}");
          Console.WriteLine($"test is {test}");

          // Error, Operator '+' cannot be applied to operands of type 'int' and 'bool'
          // int c = a + test;
        }
    }
}
