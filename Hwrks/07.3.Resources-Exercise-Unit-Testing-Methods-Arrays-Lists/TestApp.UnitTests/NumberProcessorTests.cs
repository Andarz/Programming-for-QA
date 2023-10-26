﻿using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        // Arrange
        List<int> input = new() { 2, 4, 6 };
        List<double> expected = new() { 4, 16, 36 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        List<int> input = new() { 9, 49, 25 };
        List<double> expected = new() { 3, 7, 5 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
        //CollectionAssert.AreEqual(expected, actual);
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {
        // Arrange
        List<int> input = new() { 0 };
        List<int> expected = new() { 0 };

        // Act

        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert

        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ProcessNumbers_HandleNegativeNumbers()
    {
        // Arrange

        List<int> input = new() { -16, -9 };

        // Act & Assert

        Assert.That(() => NumberProcessor.ProcessNumbers(input), Throws.ArgumentException);



    }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        // Arrange

        List<int> input = new() {};

        // Act

        List<double> expected = NumberProcessor.ProcessNumbers(input);

        // Assert

        Assert.That(expected, Is.Empty);
    }
}
