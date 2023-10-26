﻿using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        string[] inputArray = Array.Empty<string>();

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        // Arrange

        string[] test = new string[] { "Hello" };

        // Act

        string[] actual = Reverser.ReverseStrings(test);



        // Assert
        Assert.That(actual, Is.EqualTo(new[] { "olleH" }));
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        // Arrange

        string[] test = new string[] { "Hello", "Bye" };

        // Act

        string[] actual = Reverser.ReverseStrings(test);



        // Assert
        Assert.That(actual, Is.EqualTo(new[] { "olleH", "eyB" }));
    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        // Arrange

        string[] test = new string[] { "Hello?", "Bye!!!" };

        // Act

        string[] actual = Reverser.ReverseStrings(test);



        // Assert
        Assert.That(actual, Is.EqualTo(new[] { "?olleH", "!!!eyB" }));
    }
}
