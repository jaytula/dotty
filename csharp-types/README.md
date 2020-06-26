## Types (C# Programming Guide)

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/

### Built-in Types

#### Value Types

| C# type keyword | .NET type |
| --- | --- |
| bool | System.Boolean |
| byte | System.Byte |
| sbyte | System.SByte |
| char | System.Char |
| decimal | System.Decimal |
| double | System.Double |
| float | System.Single |
| int | System.Int32 |
| uint | System.UInt32 |
| long | System.Int64 |
| ulong | System.UInt64 |
| short | System.Int16 |
| ushort | System.UInt16 |

#### Reference Types

| C# type keyword | .NET type |
| --- | --- |
| object | System.Object |
| string | System.String |
| dynamic | System.Object |

The `C# type` keyword and `.NET type` are interchangeable.

For example, these are equivalent:

```cs
int number = 32;
System.Int32 number = 32;
```

Lastly `void` represents the absence of a type. Used to indicate that a function does not
return a value.


### Custom Types

Create own custom types with:

- `struct`
- `class`
- `interface`
- `enum`

Notes:

- The `.NET class library` is a collection of *custom types* provided by **Microsoft**.
- Frequently used types in the class library are automatically available.
- Others become available when you explicitly add a project reference to the assembly in which they
are defined

### The common type system

#### Two fundamental points about the type system in .NET

- Inheritance
  - Supports inheritance. Types can derive from other types, called *base types*
  - All types derive ultimately from a single base type: `System.Object` (C# keyword: `object`)
- Either value or reference type
  - Types defined by `struct` keyword are value types
  - Tyeps defined by `class` keyword are reference types

#### Value types

There are two categories of Value Types.

- `struct`
- `enum`

