using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

public partial class Tester
{
    public async void TestEight()
    {
        await foreach (var number in GenerateSequence())
        {
            Console.WriteLine(number);
        }

        // By default implemented in 
    }

    public async IAsyncEnumerable<int> GenerateSequence()
    {
        for (int i = 0; i < 20; i++)
        {
            await Task.Delay(100);
            yield return i;
        }
    }
}