using System;

public partial class Tester
{
    public void TestUnmanagedConstructedTypes()
    {
        Span<Coords<int>> coordinates = stackalloc[]
        {
            new Coords<int> { X = 0, Y = 0 },
            new Coords<int> { X = 1, Y = 0 },
            new Coords<int> { X = 0, Y = 1 }
        };


    }
}

public struct Coords<T>
{
    public T X;
    public T Y;
}