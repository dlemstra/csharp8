using System;
using System.Collections.Generic;
using System.Text;

namespace csharp8
{
    class MainDemoItems
    {
        private int[] numbers = { 1, 2, 3, 4, 5 };

        public void Test()
        {
            var sub = numbers[2..^-2];
            foreach (var x in sub)
                Console.WriteLine(x);        }
    }

    struct MyCustomer
    {
        public  int _someNumber { get { return _someNumber * 2; } }
        public readonly int SomeNumber { get => _someNumber;  }

        public readonly override string ToString()
        {
            return $"{_someNumber}";
        }
    }
}
