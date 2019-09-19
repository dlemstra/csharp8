using System;

public partial class Tester
{
    public void TestOne()
    {
        var l1 = new Line();
        l1.X1 = 1.0;
        l1.X2 = 2.0;
        l1.Y1 = 3.0;
        l1.Y2 = 4.0;

        var length = l1.Length;
        Console.WriteLine($"The length of the line is {length}.");

    }

}

public struct Line
{
    public double X1 { get; set; }
    public double Y1 { get; set; }
    public double X2 { get; set; }
    public double Y2 { get; set; }

    public double Length
    {
        get { return Math.Sqrt(Math.Pow((X2 - X1), 2.0) + Math.Pow((Y2 - Y1), 2.0)); }
    }

    public override string ToString()
    {
        return $"{Length}";
    }
}