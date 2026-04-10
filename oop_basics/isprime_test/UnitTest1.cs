using isprime;
using NUnit.Framework;
namespace isPrime_test;

public class Tests
{
    
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(2, true)]
    [TestCase(13, true)]
    [TestCase(1, false)]
    [TestCase(9, false)]
    [TestCase(-5, false)]
    public void IsPrimeTest(int number, bool expectedResult)
    {
        //Arrange:
        var tool = new PrimeTool(number);
        //Act:
        bool actualResult = tool.IsPrime();
        //Assert:
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}