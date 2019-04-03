namespace Algorithms.Arrays
{
    /// <summary>
    /// Is Unique: Implement an algorithm to determine if a string has all unique characters.
    /// What if you cannot use additional data structures?
    /// </summary>
    public static class IsUniqueProblem
    {
        /// <summary>
        /// Time O(n) Space O(1)
        /// </summary>
        public static bool HasUniqueCharacters(string text)
        {
            if(string.IsNullOrEmpty(text) || text.Length > 256)
                return false;

            bool[] chars = new bool[256];

            foreach (var c in text)
            {
                if (chars[c])
                    return false;

                chars[c] = true;
            }

            return true;
        }
    }
}
