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

      names.Add("Maria");
      names.Add("Bill");
      names.Remove("Ana");

      Console.WriteLine("Updated List");

      foreach (var name in names)
      {
        Console.WriteLine($"Hello {name.ToUpper()}!");
      }

      Console.WriteLine($"My name is {names[0]}.");
      Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

      Console.WriteLine($"The list has {names.Count} people in it");

      // Search and sort lists
      var index = names.IndexOf("Felipe");
      if(index != -1) 
        Console.WriteLine($"The name {names[index]} is at index {index}");

      var notFound = names.IndexOf("Not Found");
      Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

      names.Sort();
      foreach(var name in names) {
        Console.WriteLine($"Hello {name.ToUpper()}");
      }
    }
  }
}