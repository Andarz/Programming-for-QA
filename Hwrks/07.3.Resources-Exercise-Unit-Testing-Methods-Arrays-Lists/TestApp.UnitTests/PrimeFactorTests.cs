using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        // Arrange

        long n = -2;

        // Act & Assert

        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(n), Throws.ArgumentException );
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange

        long n = 7;

        // Act

        long actual = PrimeFactor.FindLargestPrimeFactor(n);

        // Assert

        Assert.That( actual, Is.EqualTo( n ) );
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange

        long n = 987654321987654321;

        // Act

        long actual = PrimeFactor.FindLargestPrimeFactor(n);

        // Assert

        Assert.That(actual, Is.EqualTo(379721));
    }
}
