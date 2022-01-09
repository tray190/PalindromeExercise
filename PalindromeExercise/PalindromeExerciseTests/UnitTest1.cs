using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("RaceCar", true)]
        [InlineData("Hello", false)]
        public void Palindrome(string word, bool expected)
        {
            // Arrange
            var wordSmith = new WordSmith(word);
            //act
            var actual = wordSmith.IsAPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
