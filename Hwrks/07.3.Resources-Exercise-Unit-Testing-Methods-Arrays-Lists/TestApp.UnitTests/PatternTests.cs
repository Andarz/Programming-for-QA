using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish test
    [Test]
    public void Test_SortInPattern_NullInput_ThrowsException()
    {
        // Arrange
        int[]? inputArray = null;

        // Act + Assert

        Assert.That(() => Pattern.SortInPattern(inputArray), Throws.ArgumentException);
    }

    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange

        int[] input = new int[] { 1, 2, 1, 3, 4, 10, 12, 15 };

        // Act

        int[] actual = Pattern.SortInPattern(input);

        // Assert

        Assert.That(actual, Is.EqualTo(new int[] { 1, 15, 2, 12, 3, 10, 4 }));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange

        int[] input = new int[] {};

        // Act

        int[] actual = Pattern.SortInPattern(input);

        // Assert

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        // Arrange

        int[] input = new int[] { 1 };

        // Act

        int[] actual = Pattern.SortInPattern(input);

        // Assert

        Assert.That(actual, Is.EqualTo(new int[] { 1 }));
    }
}
