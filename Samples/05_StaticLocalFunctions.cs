public partial class Tester
{
    public void TestFive()
    {

        var a = 1;
        var b = 2;
        var total = sum(a, b);

        // This causes a problem...
        int sum(int x, int y)
        {
            a = a * 4;
            return x + y;
        }

        
    }
}