using System;

namespace csharp_6_exercises
{
  class Person
  {
    public string FirstName { get; }
    public string LastName { get; }

    public Person(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;
    }

    public string AllCaps()
    {
      return ToString().ToUpper();
    }

    public override string ToString()
    {
      return $"{FirstName} {LastName}";
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var person = new Person("Max", "Schwartz");
      Console.WriteLine($"The name, in all caps: " + person.AllCaps());
      Console.WriteLine($"The name is {person.ToString()}");
    }
  }
}
