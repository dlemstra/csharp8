using System;

namespace csharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester tester = new Tester();

            tester.TestReadOnlyMember();
            tester.TestDefaultInterfaceMembers();
            tester.TestPatterns();
            tester.TestUsingDeclarations();
            tester.TestStaticLocalFunctions();
            tester.TestDisposableRefStructs();
            tester.TestNullableReferenceTypes();
            tester.TestAsynchronousStreams();
            tester.TestIndicesAndRanges();
            tester.TestNullCoalescingAssignemt();
            tester.TestUnmanagedConstructedTypes();
            tester.TestEnhancedInterpolatedStrings();

            Console.WriteLine("All done...");
            Console.ReadLine();

        }
    }
}
