using System;

using System.Linq;

namespace csharp_types
{
  class MyClass
  {

  }

  public struct Coords
  {
    public int x, y;
    public Coords(int p1, int p2)
    {
      x = p1;
      y = p2;
    }
    public override string ToString()
    {
      return $"({x}, {y})";
    }
  }

  public enum FileMode
  {
    CreateNew = 1,
    Create = 2,
    Open = 3,
    OpenOrCreate = 4,
    Truncate = 5,
    Append = 6,
  }

  class Program
  {
    static void Main(string[] args)
    {
      // TypesVarsValues();
      ValueTypes();
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

      // Specifying types in variable declarations

      // Declaration only:
      float temperature;
      string name;
      MyClass myClass;

      // Declaration with initializers
      char firstLetter = 'C';
      var limit = 3;
      int[] source = { 0, 1, 2, 3, 4, 5 };
      var query = from item in source
                  where item <= limit
                  select item;
    }

    static void ValueTypes()
    {
      var coord1 = new Coords(5, 7);
      Console.WriteLine($"coord1 is {coord1}");

      Console.WriteLine($"FileMode.Create = {FileMode.Create}");
    }
  }
}
