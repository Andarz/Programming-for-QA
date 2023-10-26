using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [TestCase (2.5, "Fail")]
    [TestCase (3.4, "Average")]
    [TestCase (3.8, "Good")]
    [TestCase (4.3, "Very Good")]
    [TestCase (4.9, "Excellent")]
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestCase(0, "Invalid!")]
    [TestCase(6.0, "Invalid!")]
    [TestCase(-3.0, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
