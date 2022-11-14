using Practice16;

namespace Prictice16.Tests;

public class Tests
{
    [Test]
    public void Additional_MustReturnCorrectValue()
    {
        Calculator calculator = new Calculator();
        Assert.That(calculator.Additional(15, 25) == 40);
    }
    [Test]
    public void Miltiplication_MustReturnCorrectValue()
    {
        Calculator calculator = new Calculator();
        Assert.That(calculator.Miltiplication(10, 20) == 200);
    }

    [Test]
    public void Subtraction_MustReturnCorrectValue()
    {
        Calculator calculator = new Calculator();
        Assert.That(calculator.Subtraction(250, 25) == 225);
    }
    [Test]
    public void Division_MustReturnCorrectValue()
    {
        var calculator = new Calculator();
        Assert.That(calculator.Division(250, 10) == 25);
    }

    [Test]
    public void Division_MustThrowException()
    {
        var calculator = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calculator.Division(25, 0));
    }

}