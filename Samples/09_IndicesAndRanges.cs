using System;

public partial class Tester
{

    public void TestNine()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Give me the first element
        var element1 = numbers[0];
        Console.WriteLine(element1);

        // Give me the last element, 
        var elementLast = numbers[^1];
        Console.WriteLine(elementLast);

        // Give me the elements 2 to 8 (not including!)
        var range = numbers[2..^3];
        foreach (var num in range) Console.WriteLine(num);

        // or to put it in another way
        Range subRange = 2..^3;

        var range2 = numbers[subRange];
        foreach (var num in range2) Console.WriteLine(num);
    }
}