using System;
using Xunit;
using RepeatedWord;

namespace CodeChallenge31Test
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnTheFirstWordToOccurMoreThanOnceTestOne()
        {
            string testPhrase = "Once upon a time, there was a brave princess who...";

            Assert.Equal("a", Program.RepeatedWord(testPhrase));
        }

        [Fact]
        public void ReturnTheFirstWordToOccurMoreThanOnceTestTwo()
        {
            string testPhrase = "Hello, World! Hello, World!";

            Assert.Equal("hello", Program.RepeatedWord(testPhrase));
        }

        [Fact]
        public void ReturnTheFirstWordToOccurMoreThanOnceTestThree()
        {
            string testPhrase = "Hello, World! World! World!";

            Assert.NotEqual("hello", Program.RepeatedWord(testPhrase));
        }

        [Fact]
        public void ReturnNoRepeatedWordWhenThereIsNoRepeatedWords()
        {
            string testPhrase = "Hello, World!";

            Assert.Equal("No Repeated Word", Program.RepeatedWord(testPhrase));
        }

        [Fact]
        public void NormalizesWordToLowerCase()
        {
            string testPhrase = "HELLO, World! hello, WORLD!";

            Assert.Equal("hello", Program.RepeatedWord(testPhrase));
        }

        [Fact]
        public void IgnoresPunctuations()
        {
            string testPhrase = "!!!HELLO!!! World! *(&*%*(&hello, WORLD!";

            Assert.Equal("hello", Program.RepeatedWord(testPhrase));
        }
    }
}
