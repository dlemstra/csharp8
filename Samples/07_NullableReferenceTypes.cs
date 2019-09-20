using System;

public partial class Tester
{
    public void TestNullableReferenceTypes()
    {

        bool? nullBool = null;

        nullBool = true;

        // Enable or disable this feature by setting <Nullable>enable</Nullabble> in .csproj PropertyGroup!
        object? nullObject = null;

        //if(nullObject != null) { }

        #region The wrong way to do null checks...
        MyObject stupid = null;

        if (stupid != null)
        {
            stupid.Id = 42;
        }
        #endregion

        #region The right way to do it

        if (stupid is object)
        {
            stupid.Id = 42;
        }
        else
        {
            Console.WriteLine("It's null, silly!");
        }
        #endregion

    }

}

#region Stupid class to show valid null checks

public class MyObject
{


    public int Id { get; set; }
    #region Operators
    public static bool operator ==(MyObject o1, object o2)
    {
        return false;
    }

    public static bool operator !=(MyObject o1, object o2)
    {
        return true;
    }
    #endregion
}

#endregion