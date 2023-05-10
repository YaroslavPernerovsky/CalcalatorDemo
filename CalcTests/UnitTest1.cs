namespace CalcTests;
using Calcalator;

public class Tests
{
    CalcCore cal;

    [OneTimeSetUp]
    public void Setup()
    {
        cal = new CalcCore();
    }


    [TestCase(255, 0, 255)]
    [TestCase(1024, 1025, -1)]
    [TestCase(int.MaxValue, 2147483641, 1)]
    [TestCase(1000, 4400, 44400)]
    public void AdditionTest(int Expected, int First, int Second)
    {
        Assert.That(Expected, Is.EqualTo(cal.Add(First, Second)));
    }

    [TestCase(10, 2, 4)]
    [TestCase(100, 50, 2)]
    [TestCase(110, 11, 10)]
    public void MultiplyTests(int Expected, int First, int Second)
    {
        Assert.That(cal.Multiply(First, Second), Is.EqualTo(Expected));
    }

    [TestCase(5, 10, 2)]
    [TestCase(100, 1000, 10)]
    [TestCase(4, 8, 2)]
    public void DivideTests(int Expected, int First, int Second)
    {
        Assert.That(Expected, Is.EqualTo(cal.Divide(First, Second)));

    }

    [Test]
    [Ignore("Test is broken. Working on fix")]
    public void DivideZeroTest()
    {
        Assert.Throws<DivideByZeroException>(() => cal.Divide(3, 0));
    }
}
