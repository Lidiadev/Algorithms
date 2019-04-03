namespace AlgorithmsUnitTests.Arrays
{
    using Algorithms.Arrays;
    using NUnit.Framework;

    public class PermutationProblemTests
    {
        [Test]
        [TestCase("elvis", "lives")]
        [TestCase("abababab", "babababa")]
        [TestCase("aaaaa", "aaaaa")]
        [TestCase("a", "a")]
        [TestCase("rail safety", "fairy tales")]
        [TestCase("", "")]
        public void IsPermutation_WhenStringsHaveIdenticalChars_ShouldReturnTrue(string text1, string text2)
            => Assert.True(PermutationProblem.IsPermutation(text1, text2));

        [Test]
        [TestCase("aaaa", "aaaaa")]
        [TestCase("aab", "aaab")]
        [TestCase("a*", "a")]
        [TestCase("a", "b")]
        [TestCase("railsafety", "fairytales ")]
        [TestCase("railsafety", " fairytales")]
        [TestCase("railsafety", " fairy tales")]
        [TestCase(null, "")]
        public void IsPermutation_WhenStringsDontHaveIdenticalChars_ShouldReturnFalse(string text1, string text2)
            => Assert.False(PermutationProblem.IsPermutation(text1, text2));
    }
}
