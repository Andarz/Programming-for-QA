using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        // Act
        StringReverse.Reverse(input);
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("", actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        //Arrange
        string input = "a";

        StringReverse.Reverse(input);
        //Act
        string actual = StringReverse.Reverse(input);
        //Assert
        Assert.AreEqual("a", actual);
        Assert.AreEqual(1, actual.Length);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "123";
        // Act
        string actual = StringReverse.Reverse(input);
        // Assert
        Assert.AreEqual("321", actual);
        Assert.AreEqual(input.Length, actual.Length);
    }
}
