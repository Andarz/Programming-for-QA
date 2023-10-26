using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] actual = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(actual , Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] numbers = new [] {1, 2, 3};

        // Act
        int[] actual = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(numbers));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] numbers = new[] { 1, 2, 3, 3, 3, 4, 5, 5 };

        // Act
        int[] actual = Duplicates.RemoveDuplicates(numbers);
        int[] exp = new int[] { 1, 2, 3, 4, 5 };

        // Assert
        Assert.That(actual, Is.EqualTo(exp));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int[] numbers = new[] { 1, 1, 1, 1, 1 };

        // Act
        int[] actual = Duplicates.RemoveDuplicates(numbers);
        int[] exp = new int[] { 1 };

        // Assert
        Assert.That(actual, Is.EqualTo(exp));
    }
}
