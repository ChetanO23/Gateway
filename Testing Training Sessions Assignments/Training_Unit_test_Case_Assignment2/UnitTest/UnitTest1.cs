using System;
using UnitTestAssignment2;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void ConvertUpperCase1()
        {
            string a = "try";
            string result = a.ConvertUpper();
            Assert.Equal("TRY", result);
        }
        [Fact]
        public void ConvertUpperCase2()
        {
            string a = "try";
            string result = a.ConvertUpper();
            Assert.NotEqual("TrY", result);
        }
        [Fact]
        public void ConvertLowerCase1()
        {
            string a = "TRY";
            string result = a.ConvertLower();
            Assert.Equal("try", result);
        }
        [Fact]
        public void ConvertLowerCase2()
        {
            string a = "TRY";
            string result = a.ConvertLower();
            Assert.NotEqual("Try", result);
        }
        [Fact]
        public void ConvertTitle1()
        {
            string a = "try demo";
            string result = a.ConvertTitleCase();
            Assert.Equal("Try Demo", result);
        }
        [Fact]
        public void ConvertTitle2()
        {
            string a = "try demo";
            string result = a.ConvertTitleCase();
            Assert.NotEqual("TRY Demo", result);
        }
        [Fact]
        public void IsLowerCase1()
        {
            string a = "try";
            bool result = a.IsLower();
            Assert.True(result);
        }
        [Fact]
        public void IsLowerCase2()
        {
            string a = "Try";
            bool result = a.IsLower();
            Assert.False(result);
        }
        [Fact]
        public void IsUpperCase1()
        {
            string a = "TRY";
            bool result = a.IsUpper();
            Assert.True(result);
        }
        [Fact]
        public void IsUpperCase2()
        {
            string a = "TrY";
            bool result = a.IsUpper();
            Assert.False(result);
        }
        [Fact]
        public void ConvertCapitalizeCase1()
        {
            string a = "try demo";
            string result = a.ConvertCapitalize();
            Assert.Equal("Try demo", result);
        }
        [Fact]
        public void ConvertCapitalizeCase2()
        {
            string a = "try demo";
            string result = a.ConvertCapitalize();
            Assert.NotEqual("Try Demo", result);
        }
        [Fact]
        public void WordCountCase1()
        {
            string a = "try demo";
            int result = a.WordCount();
            Assert.Equal(2, result);
        }
        [Fact]
        public void WordCountCase2()
        {
            string a = "try demo";
            int result = a.WordCount();
            Assert.NotEqual(1, result);
        }
        [Fact]
        public void RemoveLastCharacterCase1()
        {
            string a = "try";
            string result = a.RemoveLastCharacter();
            Assert.Equal("tr", result);
        }
        [Fact]
        public void RemoveLastCharacterCase2()
        {
            string a = "try";
            string result = a.RemoveLastCharacter();
            Assert.NotEqual("try", result);
        }
        [Fact]
        public void ValidNumericCase1()
        {
            string a = "333";
            bool result = a.ValidNumeric();
            Assert.True(result);
        }
        [Fact]
        public void ValidNumericCase2()
        {
            string a = "33a3";
            bool result = a.ValidNumeric();
            Assert.False(result);
        }
        [Fact]
        public void StringToNumberCase1()
        {
            string a = "454";
            int? result = a.StringToNumber();
            Assert.Equal(454, result);
        }
        [Fact]
        public void StringToNumberCase2()
        {
            string a = "33a3";
            int? result = a.StringToNumber();
            Assert.Null(result);
        }
    }
}
