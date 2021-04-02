using System;
using UnitTestAssignment2;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {

        [Fact]
        public void TestConvertUpperCaseEqual()
        {
            // Arrange
            string a = "chetan";
            
            // Act
            string result = a.ConvertUpper();

            // Assert
            Assert.Equal("CHETAN", result);
        }

        [Fact]
        public void TestConvertUpperCaseNotEqual()
        {
            // Arrange
            string a = "chetan";

            // Act
            string result = a.ConvertUpper();
            
            // Assert
            Assert.NotEqual("ChetaN", result);
        }

        [Fact]
        public void TestConvertLowerCaseEqual()
        {
            // Arrange
            string a = "CHETAN";

            // Act
            string result = a.ConvertLower();

            // Assert
            Assert.Equal("chetan", result);
        }

        [Fact]
        public void TestConvertLowerCaseNotEqual()
        {
            // Arrange
            string a = "CHETAN";

            // Act
            string result = a.ConvertLower();

            // Assert
            Assert.NotEqual("Chetan", result);
        }

        [Fact]
        public void TestConvertTitleEqual()
        {
            // Arrange
            string a = "hello chetan";

            // Act
            string result = a.ConvertTitleCase();

            // Assert
            Assert.Equal("Hello Chetan", result);
        }

        [Fact]
        public void TestConvertTitleNotEqual()
        {
            // Arrange
            string a = "hello chetan";

            // Act
            string result = a.ConvertTitleCase();

            // Assert
            Assert.NotEqual("HELLO Chetan", result);
        }

        [Fact]
        public void TestIsLowerCaseTrue()
        {
            // Arrange
            string a = "chetan";

            // Act
            bool result = a.IsLower();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsLowerCaseFalse()
        {
            // Arrange
            string a = "Chetan";

            // Act
            bool result = a.IsLower();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsUpperCaseTrue()
        {
            // Arrange
            string a = "CHETAN";

            // Act
            bool result = a.IsUpper();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsUpperCaseFalse()
        {
            // Arrange
            string a = "Chetan";

            // Act
            bool result = a.IsUpper();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestConvertCapitalizeCaseEqual()
        {
            // Arrange
            string a = "chetan more";

            // Act
            string result = a.ConvertCapitalize();

            // Assert
            Assert.Equal("Chetan more", result);
        }

        [Fact]
        public void TestConvertCapitalizeCaseNotEqual()
        {
            // Arrange
            string a = "chetan more";

            // Act
            string result = a.ConvertCapitalize();
            
            // Assert
            Assert.NotEqual("Chetan More", result);
        }

        [Fact]
        public void TestWordCountCaseEqual()
        {
            // Arrange
            string a = "chetan more";

            // Act
            int result = a.WordCount();

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void TestWordCountCaseNotEqual()
        {
            // Arrange
            string a = "chetan more";

            // Act
            int result = a.WordCount();

            // Assert
            Assert.NotEqual(1, result);
        }

        [Fact]
        public void TestRemoveLastCharacterCaseEqual()
        {
            // Arrange
            string a = "chetan";

            // Act
            string result = a.RemoveLastCharacter();
            
            // Assert
            Assert.Equal("cheta", result);
        }

        [Fact]
        public void TestRemoveLastCharacterCaseNotEqual()
        {
            // Arrange
            string a = "chetan";

            // Act
            string result = a.RemoveLastCharacter();
            
            // Assert
            Assert.NotEqual("chetan", result);
        }

        [Fact]
        public void TestValidNumericCaseTrue()
        {
            // Arrange
            string a = "123456";

            // Act
            bool result = a.ValidNumeric();
            
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestValidNumericCaseFalse()
        {
            // Arrange
            string a = "ndbj13562";

            // Act
            bool result = a.ValidNumeric();
            
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestStringToNumberCaseEqual()
        {
            // Arrange
            string a = "454";
            
            // Act                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
            int? result = a.StringToNumber();
            
            // Assert
            Assert.Equal(454, result);
        }

        [Fact]
        public void TestStringToNumberCaseNull()
        {
            // Arrange
            string a = "22saf3432";
            
            // Act
            int? result = a.StringToNumber();
            
            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void TestInverseMethod()
        {
            // Arrange
            string input = "hEllo CHEtan";
            string expected = "HeLLO cheTAN";

            // Act
            string output = input.InverseString();

            // Assert
            Assert.Equal(expected, output);
        }

        [Fact]
        public void TestIsNumeric_Valid_Input()
        {
            // Arrange
            string input = "23";
            string expected = "yes";

            // Act
            string ouput = input.IsNumeric();

            // Assert
            Assert.Equal(expected, ouput);
        }

        [Fact]
        public void TestIsNumeric_Invalid_Input()
        {
            // Arrange
            string input = "2 3";
            string expected = "no";

            // Act
            string output = input.IsNumeric();

            // Assert
            Assert.Equal(expected, output);
        }
    }
}
