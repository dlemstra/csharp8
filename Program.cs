using System;

namespace csharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester tester = new Tester();

            RunTest("read only members", new Action(tester.TestReadOnlyMember));
            RunTest("default interface members", new Action(tester.TestDefaultInterfaceMembers));
            RunTest("pattern matching", new Action(tester.TestPatterns));
            RunTest("using declarations", new Action(tester.TestUsingDeclarations));
            RunTest("static local functions", new Action(tester.TestStaticLocalFunctions));
            RunTest("disposable ref structs", new Action(tester.TestDisposableRefStructs));
            RunTest("nullable reference types", new Action(tester.TestNullableReferenceTypes));
            RunTest("asynchronous stream", new Action(tester.TestAsynchronousStreams));
            RunTest("indices and ranges", new Action(tester.TestIndicesAndRanges));
            RunTest("null coalescing assignment", new Action(tester.TestNullCoalescingAssignemt));
            RunTest("unmanaged constructed types", new Action(tester.TestUnmanagedConstructedTypes));
            RunTest("enhanced interpolated strings", new Action(tester.TestEnhancedInterpolatedStrings));           

            Console.WriteLine("All done...");
            Console.ReadLine();

        }

        static void RunTest(string testDescription, Action testRun)
        {
            Console.WriteLine($"Press [enter] to test {testDescription}.");
            Console.ReadLine();
            try
            {
                testRun.Invoke();
            }
            finally {
                Console.WriteLine($"Done running test for {testDescription}\n\n");
            }
        }
    }
}
