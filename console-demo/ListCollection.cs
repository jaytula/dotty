using System;
using System.Collections.Generic;

namespace console_demo
{
  class ListCollection
  {
    public static void ListCollectionMain()
    {
      var names = new List<string> { "<name>", "Ana", "Felipe" };

      foreach (var name in names)
      {
        Console.WriteLine($"Hello {name.ToUpper()}!");
      }
    }
  }
}