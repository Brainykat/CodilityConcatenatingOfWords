using System;
using Xunit;

namespace ConcatenatingOfWords.Test
{
    public class SolutionTests
    { 
        /// Didnt have time to test methods separately as its a timed tests
        [Theory]
        [InlineData(new string[] { "aabb", "aaaa", "bbab" }, 6)]
        [InlineData(new string[] { "xxbxx", "xbx", "x" }, 4)]
        [InlineData(new string[] { "dd", "bb", "cc", "dd" }, 4)]

        [InlineData(new string[] { "Chris" }, 1)]
        [InlineData(new string[] { "Chris Thuku" }, 1)]
        [InlineData(new string[] { }, 0)]
        [InlineData(new string[] { "Three" }, 2)]
        [InlineData(new string[] { "aabbbcc" }, 3)]
        [InlineData(new string[] { "coffee" }, 2)]
        [InlineData(new string[] { "abaaabbbqqqqqx" }, 5)]
        [InlineData(new string[] { "ab" }, 1)]
        public void solution_Returns_ExpectedResults(string[] words, int result)
        {
            Solution sln = new Solution();
            var res = sln.solution(words);
            Assert.Equal(result, res);
        }
        [Fact]
        public void solution_Returns_ExpectedResults_Large()
        {
             int result = 100000;
            var str = new string('a', result);
            string[] words = new string[] { str };
            Solution sln = new Solution();
            var res = sln.solution(words);
            Assert.Equal(result, res);
        }
    }
}
