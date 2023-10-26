﻿using NUnit.Framework;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        // Arrange
        int input = 0;

        // Act
        string actual = Triangle.PrintTriangle(input);

        // Assert
        Assert.AreEqual("", actual);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        // Arrange
        int input = 3;
        string expected = 
            "1\r\n" + 
            "1 2\r\n" + 
            "1 2 3\r\n" + 
            "1 2\r\n" + 
            "1";

        // Act
        string actual = Triangle.PrintTriangle(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        // Arrange
        int input = 5;
        string expected =
            "1\r\n" +
            "1 2\r\n" +
            "1 2 3\r\n" +
            "1 2 3 4\r\n" +
            "1 2 3 4 5\r\n" +
            "1 2 3 4\r\n" +
            "1 2 3\r\n" +
            "1 2\r\n" +
            "1";

        // Act
        string actual = Triangle.PrintTriangle(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
