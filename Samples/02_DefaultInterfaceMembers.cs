public partial class Tester
{

    public void TestTwo()
    {
        ICustomer c = new Customer();
        c.CustomerId = 42;

    }
}


public interface ICustomer
{
    int CustomerId { get; set; }


    #region New Stuff

    //double CalcDiscount() { return 0.0; }

    #endregion
}

public class Customer : ICustomer
{
    public int CustomerId { get; set; }
}