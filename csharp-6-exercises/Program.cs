using static System.Console;

namespace csharp_6_exercises
{
  class Person
  {
    public string FirstName { get; }
    public string LastName { get; }
    public string MiddleName { get; } = "P";

    public Person(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;
    }

    public Person(string first, string middle, string last)
    {
      FirstName = first;
      MiddleName = middle;
      LastName = last;
    }

    public string AllCaps() => ToString().ToUpper();

    public override string ToString() => $"{FirstName} {MiddleName} {LastName}";
  }


  class Program
  {

    static void Main(string[] args)
    {
      WriteLine("Hello World!");
      var person = new Person("Max", "Schwartz");
      WriteLine($"The name, in all caps: " + person.AllCaps());
      WriteLine($"The name is {person.ToString()}");
    }
  }
}
