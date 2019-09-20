using System.IO;

public partial class Tester
{
    public void TestUsingDeclarations()
    {

        #region Old Style

        var file1 = new StreamWriter("MyFile.txt");
        try
        {
            // Do something
        }
        finally
        {
            file1.Dispose();
        }
        #endregion

        #region Slightly better style
        using (var file2 = new StreamWriter("MyFile.txt"))
        {
            // Do something...

            // Dispose happens here!
        }

        #endregion

        #region New style

        using var file3 = new StreamWriter("MyFile.txt");

        // Do something

        // Dispose happens here, at the end of the enclosing scope
        #endregion
    }
}