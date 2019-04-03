namespace AlgorithmsUnitTests.Arrays
{
    using Algorithms.Arrays;
    using NUnit.Framework;

    public class IsUniqueProblemTests
    {
        [Test]
        [TestCase("abcdef0*-h")]
        [TestCase("ab")]
        [TestCase("a")]
        public void HasUniqueCharacters_WhenStringHasUniqueChars_ShouldReturnTrue(string text)
            => Assert.True(IsUniqueProblem.HasUniqueCharacters(text));

        [Test]
        [TestCase("abcdeaf")]
        [TestCase("abba")]
        [TestCase("aa")]
        [TestCase("")]
        [TestCase(null)]
        [TestCase("2yNbC9V34QAcHdPhYsh2MmGTdKrKVsZfHYpsrL2bY7ohxof0pHzKXHWlshvcGrgtFjqSa9yTS84BBw8B5vm7tWZXj73FfiUOmxddvIW7UXwHbyx7PQJMAUnsZWNXAxuSx2EFSOmP7bZ6vTWvGoCvqcsFtvQpTeWqPnJtwEeq3oA9Md6UszuQalRD2yRgN5uhzITAOthWSNE1MDsyi2heJWvBtpe0nt7tNRnQbIRzvEGhRKlYhV3fZI1BO6oECdzZt")]
        public void HasUniqueCharacters_WhenStringHasDuplicatesOrStringIsNullOrEmpty_ShouldReturnFalse(string text)
            => Assert.False(IsUniqueProblem.HasUniqueCharacters(text));
    }
}
