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