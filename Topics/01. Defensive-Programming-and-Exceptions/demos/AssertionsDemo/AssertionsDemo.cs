using Bytes2you.Validation;

class AssertionsDemo
{
    static void Main()
    {
        PerformAction(15);
    }

    private static bool PerformAction(int number)
    {
        Guard.WhenArgument(number, "number")
            .IsLessThan(0)
            .IsGreaterThan(10)
            .Throw();

        return true;
    }
}
