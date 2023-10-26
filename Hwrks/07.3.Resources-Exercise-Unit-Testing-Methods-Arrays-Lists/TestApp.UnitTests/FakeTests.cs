using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[]? input = null;

        // Act + Assert

        Assert.That(() => Fake.RemoveStringNumbers(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange

        char[] input = new char[] { '0', '1', 'a', 'c'};

        // Act

        char[] actual = Fake.RemoveStringNumbers(input);

        // Assert

        Assert.That(actual, Is.EqualTo(new char[] {'a', 'c'}));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange

        char[] input = new char[] { 'a', 'c' };

        // Act

        char[] actual = Fake.RemoveStringNumbers(input);

        // Assert

        Assert.That(actual, Is.EqualTo(new char[] { 'a', 'c' }));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange

        char[] input = new char[] {};

        // Act

        char[] actual = Fake.RemoveStringNumbers(input);

        // Assert

        Assert.That(actual, Is.Empty);
    }
}
