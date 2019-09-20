using System;

public partial class Tester
{
    public void TestEnhancedInterpolatedStrings()
    {
        //var s0 = "hallo\";

        var s1 = @"hallo\";

        var s2 = $"Hello to {s1}";

        var s3 = $@"Hello \ {s2}";

        var s4 = $@"Hello \ {s2}";

        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        Console.WriteLine(s4);
    }
}