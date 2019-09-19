using System;
using System.Collections.Generic;
using System.Text;

namespace csharp8
{
    class MainDemoItems
    {

        public void Test()
        {
            using CustomerData c = default(CustomerData);
           

            c.Id = 42;

            
        }
        



    }

    ref struct CustomerData 
    {
        public int Id { get; set; }
        public void Dispose()
        {
        Console.WriteLine("Disposing...");
        }
    }
}
