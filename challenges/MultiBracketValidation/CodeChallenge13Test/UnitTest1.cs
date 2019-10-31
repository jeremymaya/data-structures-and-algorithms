using System;
using Xunit;
using static MultiBracketValidation.Program;

namespace CodeChallenge13Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{}")]
        [InlineData("{}(){}")]
        [InlineData("()[[Extra Characters]]")]
        [InlineData("(){}[[]]")]
        [InlineData("{}{Code}[Fellows](())")]
        public void ExpectedOutCome(string input)
        {
            Assert.True(MultiHBracketValidation(input));
        }

        [Theory]
        [InlineData("[({}]")]
        [InlineData("(](")]
        [InlineData("{(})")]
        public void ExpectedFailure(string input)
        {
            Assert.False(MultiHBracketValidation(input));
        }

        [Theory]
        [InlineData("{")]
        [InlineData(")")]
        [InlineData("[}")]
        [InlineData("")]
        public void EdgeCases(string input)
        {
            Assert.False(MultiHBracketValidation(input));
        }
    }
}
