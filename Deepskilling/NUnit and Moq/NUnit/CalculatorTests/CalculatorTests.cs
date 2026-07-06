using NUnit.Framework;
using CalcLibrary;

namespace CalculatorTests;

[TestFixture]
public class CalculatorTests
{
    private Calculator calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [TearDown]
    public void TearDown()
    {
        calculator = null;
    }

    [Test]
    public void Add_ShouldReturnCorrectSum()
    {
        int result = calculator.Add(10, 20);

        Assert.That(result, Is.EqualTo(30));
    }

    [TestCase(2, 3, 5)]
    [TestCase(10, 15, 25)]
    [TestCase(-5, 5, 0)]
    [TestCase(100, 200, 300)]
    public void Add_TestCases(int a, int b, int expected)
    {
        int result = calculator.Add(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Ignore("Example of Ignore attribute")]
    [Test]
    public void IgnoreTest()
    {
    }
}