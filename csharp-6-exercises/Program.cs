using System;
using static System.Console;
using System.Linq;

using System.Collections.Generic;

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
      NewObjectInitSyntax();
    }

    static void StringFormatting()
    {
      WriteLine("Hello World!");
      var person = new Person("Max", "Schwartz");
      WriteLine($"The name, in all caps: " + person.AllCaps());
      WriteLine($"The name is {person.ToString()}");

      var phrase = "the quick brown fox jumps over the lazy dog";
      var wordLength = from word in phrase.Split(' ') select word.Length;
      WriteLine($"The average word length is: {wordLength.Average():F2}");
    }

    static void NullChecks()
    {
      string s = null;
      WriteLine(s?.Length);

      char? c = s?[0];
      WriteLine(c.HasValue);

      string s2 = null;
      bool? hasMore = s2?.ToCharArray()?.GetEnumerator()?.MoveNext();
      WriteLine(hasMore.HasValue && hasMore.Value);

      // null coalescing operator
      string s3 = "abcdefg";
      bool hasMore3 = s3?.ToCharArray()?.GetEnumerator()?.MoveNext() ?? false;
      WriteLine(hasMore3);
    }

    private static bool LogException(Exception e)
    {
      WriteLine($"\tIn the log routine. Caught {e.GetType()}");
      WriteLine($"\tMessage: {e.Message}");
      return true;
    }
    static void ExceptionFilters()
    {
      try
      {
        string s = null;
        WriteLine(s.Length);

      }
      catch (Exception e) when (LogException(e))
      {
      }
      WriteLine("Exception must have been handled");
    }

    static void NameOf()
    {
      WriteLine(nameof(System.String));
      int j = 5;
      WriteLine(nameof(j));
      List<string> names = new List<string>();
      WriteLine(nameof(names));
    }


    static void NewObjectInitSyntax()
    {
      var messages = new Dictionary<int, string>
      {
        [404] = "Page not Found",
        [302] = "Page moved, but left a forwarding address.",
        [500] = "The web server can't come out to play today."
      };

      WriteLine(messages[302]);
    }
  }
}
