## CSharp-6

- https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/exploration/csharp-6?tutorial-step=1

## Notes

Did not understand the second example here:

https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/exploration/csharp-6?tutorial-step=9

```cs
public class Path : IEnumerable<Point3D>
{
    private List<Point3D> points = new List<Point3D>();
    public IEnumerator<Point3D> GetEnumerator() => points.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => points.GetEnumerator();

    public void Add(Point3D pt) => points.Add(pt);
}

public static class Extensions
{
    public static void Add(this Path path, double x, double y, double z) => path.Add(new Point3D(x, y, z));
}
```